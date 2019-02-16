Imports System.Runtime.InteropServices
Imports UoP_Telemetry_GUI.Definitions

Public Class Main

    Private Car As Car_Mixed

#Region "Callbacks"
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub SetText(ByVal [text] As String)
        If Me.InvokeRequired() Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.ToolStripStatusLabel_Updates.Text = [text]
        End If
    End Sub
    Delegate Sub SetColorCallback(ByVal [color] As Color)
    Private Sub SetColor(ByVal [color] As Color)
        If InvokeRequired() Then
            Dim d As New SetColorCallback(AddressOf SetColor)
            Invoke(d, New Object() {[color]})
        Else
            ToolStripStatusLabel_Updates.BackColor = [color]
        End If
    End Sub
    Delegate Sub SetTimerCallback(ByVal [enable] As Boolean, ByVal [interval] As Integer)
    Private Sub SetTimer(ByVal [enable] As Boolean, ByVal [interval] As Integer)
        If InvokeRequired() Then
            Dim d As New SetTimerCallback(AddressOf SetTimer)
            Invoke(d, New Object() {[enable], [interval]})
        Else
            Timer_Status.Interval = [interval]
            Timer_Status.Enabled = [enable]
        End If
    End Sub
#End Region

#Region "ComboBox Live Update"
    Private Sub ComboBox_Ports_Click(sender As Object, e As EventArgs) Handles ComboBox_Ports.Click
        Try
            ComboBox_Ports.Items.Clear()
            For Each sp As String In My.Computer.Ports.SerialPortNames
                ComboBox_Ports.Items.Add(sp)
            Next
            ComboBox_Ports.SelectedIndex = 0
        Catch err As Exception
            ComboBox_Ports.Items.Clear()
        End Try
    End Sub
#End Region

#Region "Serial Variables"
    Private Connected As Boolean = False
    Private IsWaiting As Boolean = False
    Private DataReady As Boolean = False
    Private WaitingID As Byte = 0
    Private LastReceived As DateTime = DateTime.Now
    Private RX As New List(Of Byte)
    Private RXData As Byte()
    Private Const MaxRX As Integer = 255
    Private Const ReceiveTimeout As Integer = 100
    Private TXQueue As New List(Of Byte())
    Private PacketsProcessed As Integer = 0
    ' Packet IDs
    Private Const ID_CONNECTION As Byte = 0
    Private Const ID_UNKNOWN As Byte = 1
    Private Const ID_MESSAGE As Byte = 2
    Private Const ID_SEND_RAW As Byte = 3
    Private Const ID_SEND_PROCESSED As Byte = 4
    Private Const ID_SEND_MIXED As Byte = 5
#End Region

#Region "Receive"
    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        While SerialPort.BytesToRead > 0
            If IsWaiting Then
                RX.Add(SerialPort.ReadByte())
                LastReceived = DateTime.Now
                ProcessRX()
            Else
                ' Read trash
                SerialPort.ReadByte()
            End If
        End While
    End Sub

    Private Sub ProcessRX()
        If RX.Count > 0 Then
            Dim len As Integer = 0
            If RX(0) = &H2 Then
                If RX.Count >= 2 Then
                    len = RX(1)
                    If RX.Count = 3 Then
                        If RX(2) = WaitingID Then
                        Else
                            ' Command ID not correct
                            ReceiveFailed()
                            Exit Sub
                        End If
                    End If
                    If RX.Count >= 5 + len Then
                        If RX(4 + len) = &H3 Then
                            Dim Data(len - 1) As Byte
                            For Index As Integer = 2 To len + 1
                                Data(Index - 2) = RX(Index)
                            Next
                            Dim CheckSum As CRC.CheckSum = CRC.CRC(Data)
                            If (CheckSum.First = RX(2 + len) And CheckSum.Second = RX(3 + len)) Then
                                ' Cheksum success
                                RXData = Data
                                ReceiveSuccess()
                            Else
                                ' Failed checksum
                                ReceiveFailed()
                                Exit Sub
                            End If
                        Else
                            ' Last byte not correct
                            ReceiveFailed()
                            Exit Sub
                        End If
                    End If
                End If
            Else
                ' First byte not correct
                ReceiveFailed()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ReceiveFailed()
        DisplayStatus("Receive failed", Color.Firebrick)
        IsWaiting = False
        RX.Clear()
    End Sub

    Private Sub ReceiveSuccess()
        IsWaiting = False
        DataReady = True
        RX.RemoveRange(0, RXData.Length + 5)
        DisplayStatus("Success", Color.Green)
        If Connected = False Then
            Connected = True
        End If
    End Sub

    Private Sub Timer_Serial_Tick(sender As Object, e As EventArgs) Handles Timer_Serial.Tick
        If IsWaiting Then
            Dim Span As TimeSpan = DateTime.Now - LastReceived
            If Span.TotalMilliseconds > ReceiveTimeout Then
                ReceiveFailed()
            End If
        End If
        If DataReady Then
            ProcessData()
        End If
    End Sub
#End Region

#Region "Send"
    Private Sub Send(ByVal Bytes As Byte())
        TXQueue.Add(Bytes)
    End Sub

    Private Sub Timer_SendQueue_Tick(sender As Object, e As EventArgs) Handles Timer_SendQueue.Tick
        If Not IsWaiting And TXQueue.Count > 0 And SerialPort.IsOpen Then
            Dim Bytes As Byte() = TXQueue(0)
            Dim PrefixBytes As Byte() = {&H2, Bytes.Length}
            Dim Check As CRC.CheckSum = CRC.CRC(Bytes)
            Dim SuffixBytes As Byte() = {Check.First, Check.Second, &H3}
            SerialPort.Write(PrefixBytes, 0, PrefixBytes.Length)
            SerialPort.Write(Bytes, 0, Bytes.Length)
            SerialPort.Write(SuffixBytes, 0, SuffixBytes.Length)
            LastReceived = DateTime.Now
            IsWaiting = True
            WaitingID = Bytes(0)
            TXQueue.RemoveAt(0)
        End If
    End Sub

    Private Sub ToolStripStatusLabel_SerialInfo_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel_SerialInfo.Click
        TXQueue.Clear()
    End Sub
#End Region

#Region "Process"
    Private Sub LoadMessage()
        Dim Message As String = ""
        For Index As Integer = 1 To RXData.Length - 1
            Message &= ChrW(RXData(Index))
        Next
        DisplayStatus(Message, Color.Orange, 5000)
    End Sub

    Private Sub LoadRaw()
        Dim ReceivedRawCar As New Car_Raw()
        Dim RawCarPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ReceivedRawCar))
        Marshal.Copy(RXData, 1, RawCarPointer, Marshal.SizeOf(ReceivedRawCar))
        ReceivedRawCar = CType(Marshal.PtrToStructure(RawCarPointer, GetType(Car_Raw)), Car_Raw)
        Marshal.FreeHGlobal(RawCarPointer)
        Car.Raw = ReceivedRawCar
    End Sub

    Private Sub LoadProcessed()
        Dim ReceivedProcessedCar As New Car_Processed()
        Dim ProcessedCarPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ReceivedProcessedCar))
        Marshal.Copy(RXData, 1, ProcessedCarPointer, Marshal.SizeOf(ReceivedProcessedCar))
        ReceivedProcessedCar = CType(Marshal.PtrToStructure(ProcessedCarPointer, GetType(Car_Processed)), Car_Processed)
        Marshal.FreeHGlobal(ProcessedCarPointer)
        Car.Processed = ReceivedProcessedCar
    End Sub

    Private Sub LoadMixed()
        Dim ReceivedMixedCar As New Car_Mixed()
        Dim MixedCarPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ReceivedMixedCar))
        Marshal.Copy(RXData, 1, MixedCarPointer, Marshal.SizeOf(ReceivedMixedCar))
        ReceivedMixedCar = CType(Marshal.PtrToStructure(MixedCarPointer, GetType(Car_Mixed)), Car_Mixed)
        Marshal.FreeHGlobal(MixedCarPointer)
        Car = ReceivedMixedCar
    End Sub

    Private Sub ProcessData()
        Try
            Select Case RXData(0)
                Case ID_CONNECTION
                Case ID_UNKNOWN
                    ' Client responded with unknown ID packet. That means the received
                    ' packet to the client had an ID unknown to the client.
                Case ID_MESSAGE
                    LoadMessage()
                Case ID_SEND_RAW
                    LoadRaw()
                    DisplayRaw()
                Case ID_SEND_PROCESSED
                    LoadProcessed()
                    DisplayProcessed()
                Case ID_SEND_MIXED
                    LoadMixed()
                    DisplayRaw()
                    DisplayProcessed()
                Case Else
                    DisplayStatus("Unknown packet ID", Color.Orange, 3000)
            End Select
        Catch ex As Exception
            MsgBox("Data process error. " & ex.Message, MsgBoxStyle.Critical, "Error")
            'Console.WriteLine(ex.Message)
        End Try
        ProcessSuccess()
    End Sub

    Private Sub ProcessSuccess()
        DataReady = False
        RXData = {}
        PacketsProcessed += 1
    End Sub
#End Region

#Region "GUI"
    Private Sub Timer_GUIUpdate_Tick(sender As Object, e As EventArgs) Handles Timer_GUIUpdate.Tick
        If Connected Then
            ToolStripStatusLabel_Status.ForeColor = Color.Green
            ToolStripStatusLabel_Status.Text = "Connected"
            Button_Connect.Text = "Disconnect"
        Else
            ToolStripStatusLabel_Status.ForeColor = Color.Firebrick
            ToolStripStatusLabel_Status.Text = "Disconnected"
            Button_Connect.Text = "Connect"
        End If
        ToolStripStatusLabel_SerialInfo.Text = "Queued: " & TXQueue.Count & " | Processed: " & PacketsProcessed
    End Sub

    Private Sub DisplayStatus(ByVal Message As String, ByVal Color As Color, ByVal Optional Interval As Integer = 1500)
        SetText(Message)
        SetColor(Color)
        SetTimer(True, Interval)
    End Sub

    Private Sub Timer_Status_Tick(sender As Object, e As EventArgs) Handles Timer_Status.Tick
        ToolStripStatusLabel_Updates.Text = ""
        SetTimer(False, 1500)
    End Sub
#End Region

#Region "Buttons"
    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        'Try
        If Button_Connect.Text = "Connect" Then
            If SerialPort.IsOpen Then
                SerialPort.Close()
            End If
            SerialPort.PortName = ComboBox_Ports.SelectedItem
            SerialPort.Open()
            System.Threading.Thread.Sleep(110)
            Send({ID_CONNECTION})
        Else
            SerialPort.Close()
            Connected = False
        End If

    End Sub

    Private Sub Button_Monitoring_Click(sender As Object, e As EventArgs) Handles Button_Monitoring.Click
        If Button_Monitoring.Text = "Start Monitoring" Then
            Timer_Monitoring.Start()
            Button_Monitoring.Text = "Stop Monitoring"
            Button_FetchRaw.Enabled = False
            Button_FetchProcessed.Enabled = False
        Else
            Timer_Monitoring.Stop()
            Button_Monitoring.Text = "Start Monitoring"
            Button_FetchRaw.Enabled = True
            Button_FetchProcessed.Enabled = True
        End If
    End Sub

    Private Sub Button_FetchRaw_Click(sender As Object, e As EventArgs) Handles Button_FetchRaw.Click
        RequestRawCar()
    End Sub

    Private Sub Button_FetchProcessed_Click(sender As Object, e As EventArgs) Handles Button_FetchProcessed.Click
        RequestProcessedCar()
    End Sub

    Private Sub Button_FetchMixed_Click(sender As Object, e As EventArgs) Handles Button_FetchMixed.Click
        RequestMixedCar()
    End Sub
#End Region

#Region "Arithmetic"
    Private Function ParseSingle(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As Single
        Dim Result As Single
        If BigEndian Then
            Result = BitConverter.ToSingle({Bytes(StartIndex + 3), Bytes(StartIndex + 2), Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 4
        Else
            Result = BitConverter.ToSingle(Bytes, StartIndex)
            StartIndex += 4
        End If
        Return Result
    End Function

    Private Function ParseInt16(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As Int16
        Dim Result As UInt16
        If BigEndian Then
            Result = BitConverter.ToInt16({Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 2
        Else
            Result = BitConverter.ToInt16(Bytes, StartIndex)
            StartIndex += 2
        End If
        Return Result
    End Function

    Private Function ParseUInt16(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As UInt16
        Dim Result As UInt16
        If BigEndian Then
            Result = BitConverter.ToUInt16({Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 2
        Else
            Result = BitConverter.ToUInt16(Bytes, StartIndex)
            StartIndex += 2
        End If
        Return Result
    End Function

    Private Function ParseInt32(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As Int32
        Dim Result As Int32
        If BigEndian Then
            Result = BitConverter.ToInt32({Bytes(StartIndex + 3), Bytes(StartIndex + 2), Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 4
        Else
            Result = BitConverter.ToInt32(Bytes, StartIndex)
            StartIndex += 4
        End If
        Return Result
    End Function

    Private Function ParseUInt32(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As UInt32
        Dim Result As UInt32
        If BigEndian Then
            Result = BitConverter.ToUInt32({Bytes(StartIndex + 3), Bytes(StartIndex + 2), Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 4
        Else
            Result = BitConverter.ToUInt32(Bytes, StartIndex)
            StartIndex += 4
        End If
        Return Result
    End Function

    Private Function ParseByte(ByRef Bytes As Byte(), ByRef StartIndex As Integer) As Byte
        Dim Result As Byte = Bytes(StartIndex)
        StartIndex += 1
        Return Result
    End Function

    Private Function ToDegrees(ByVal TemperatureVoltage As UInt16) As Single
        Dim Voltage As Double = TemperatureVoltage * 0.0001
        Const Rdiv As Double = 10000.0F
        Const Rref As Double = 10000.0F
        Const Vref As Double = 3.0F
        Dim Rtherm As Double = (Voltage * Rdiv) / (Vref - Voltage)
        Const A As Double = 0.003354016F
        Const B As Double = 0.000256985F
        Const C As Double = 0.000002620131F
        Const D As Double = 0.00000006383091F
        Dim LN As Double = Math.Log(Rtherm / Rref)
        Dim T As Double = 1.0 / (A + B * LN + C * Math.Pow(LN, 2) + D * Math.Pow(LN, 3))
        Return TemperatureVoltage - 273.15F
    End Function
#End Region

#Region "Displaying"
    Private Sub DisplayRaw()
        Dim RawType As Type = Car.Raw.GetType
        ListView_Raw.Items.Clear()
        For Each RawField As Reflection.FieldInfo In RawType.GetFields
            Dim Item As New ListViewItem()
            Item.Text = RawField.Name
            Dim SubItem As New ListViewItem.ListViewSubItem()
            SubItem.Text = RawField.FieldType.Name
            Item.SubItems.Add(SubItem)
            SubItem = New ListViewItem.ListViewSubItem()
            SubItem.Text = RawField.GetValue(Car.Raw)
            Item.SubItems.Add(SubItem)
            ListView_Raw.Items.Add(Item)
        Next
    End Sub

    Private Sub DisplayProcessed()
        Dim ProcessedType As Type = Car.Processed.GetType
        ListView_Processed.Items.Clear()
        For Each ProcessedField As Reflection.FieldInfo In ProcessedType.GetFields
            Dim Item As New ListViewItem()
            Item.Text = ProcessedField.Name
            Dim SubItem As New ListViewItem.ListViewSubItem()
            SubItem.Text = ProcessedField.FieldType.Name
            Item.SubItems.Add(SubItem)
            SubItem = New ListViewItem.ListViewSubItem()
            SubItem.Text = ProcessedField.GetValue(Car.Processed)
            Item.SubItems.Add(SubItem)
            ListView_Processed.Items.Add(Item)
        Next
    End Sub
#End Region

#Region "Monitoring"
    Private Sub RequestRawCar()
        Send({ID_SEND_RAW})
    End Sub

    Private Sub RequestProcessedCar()
        Send({ID_SEND_PROCESSED})
    End Sub

    Private Sub RequestMixedCar()
        Send({ID_SEND_MIXED})
    End Sub

    Private Sub Timer_Monitoring_Tick(sender As Object, e As EventArgs) Handles Timer_Monitoring.Tick
        If TabControl.SelectedIndex = 0 Then
            ' Wireless
        ElseIf TabControl.SelectedIndex = 1 Then
            ' Admin
            If CheckBox_Raw.Checked Then
                RequestRawCar()
            End If
            If CheckBox_Processed.Checked Then
                RequestProcessedCar()
            End If
        Else
            ' Graphing
        End If

    End Sub
#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
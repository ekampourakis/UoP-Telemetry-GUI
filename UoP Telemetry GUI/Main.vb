Imports UoP_Telemetry_GUI.Arithmetic
Imports UoP_Telemetry_GUI.Definitions

Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Main

    Private Telemetry As Car_Telemetry
    Private Log As Logger = Nothing
    Private Const Monitoring As Boolean = True
    Private RandomGenerator As New Random

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Log IsNot Nothing Then
            Log.Close()
        End If
    End Sub

#Region "GUI"

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

#Region "Serial"
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
    Private Const ID_MESSAGE As Byte = 4
    Private Const ID_SEND_CAN As Byte = 5
    Private Const ID_SEND_TELEMETRY As Byte = 6

#End Region

#Region "Receive"
    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        While SerialPort.BytesToRead > 0
            If IsWaiting Or Monitoring Then
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
                        If RX(2) = WaitingID Or (Monitoring And (RX(2) = ID_SEND_TELEMETRY Or RX(2) = ID_SEND_CAN)) Then
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
#End Region

#Region "Process"

    Private Sub LoadMessage()
        Dim Message As String = ""
        For Index As Integer = 1 To RXData.Length - 1
            Message &= ChrW(RXData(Index))
        Next
        DisplayStatus(Message, Color.Orange, 5000)
    End Sub

    Private LastTelemetry As Integer = 0
    Private LostPackets As Integer = 0
    Private LastIndex As Integer = 0
    Private PacketSync As Boolean = False

    Private Sub LoadCAN()
        Dim CANMessage As New CAN_Message
        Dim Ind As Integer = 1
        CANMessage.ID = ParseUInt16(RXData, Ind)
        CANMessage.Length = ParseByte(RXData, Ind)
        For Index As Integer = 0 To CANMessage.Length - 1
            CANMessage.Data(Index) = ParseByte(RXData, Ind)
        Next
        DisplayCAN(CANMessage)
    End Sub

    Private Sub LoadTelemetry()
        Dim Setting As Byte = RXData(1)
        Dim Ind As Integer = 2

        Dim Timestamp As New Packet_Timestamp
        Dim Performance As New Packet_Performance
        Dim BMS As New Packet_BMS
        Dim Temps As New Packet_Temps
        Dim Pedals As New Packet_Pedals

        Telemetry.Settings = Setting

        Dim TimestampPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Timestamp))
        Marshal.Copy(RXData, Ind, TimestampPointer, Marshal.SizeOf(Timestamp))
        Timestamp = CType(Marshal.PtrToStructure(TimestampPointer, GetType(Packet_Timestamp)), Packet_Timestamp)
        Marshal.FreeHGlobal(TimestampPointer)
        Ind += Marshal.SizeOf(New Packet_Timestamp)
        Telemetry.Timestamp = Timestamp

        If (Setting And MASK_PERF) Then
            Dim PerformancePointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Performance))
            Marshal.Copy(RXData, Ind, PerformancePointer, Marshal.SizeOf(Performance))
            Performance = CType(Marshal.PtrToStructure(PerformancePointer, GetType(Packet_Performance)), Packet_Performance)
            Marshal.FreeHGlobal(PerformancePointer)
            Ind += Marshal.SizeOf(New Packet_Performance)
            Telemetry.Performance = Performance
        End If
        If (Setting And MASK_BMS) Then
            Dim BMSPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(BMS))
            Marshal.Copy(RXData, Ind, BMSPointer, Marshal.SizeOf(BMS))
            BMS = CType(Marshal.PtrToStructure(BMSPointer, GetType(Packet_BMS)), Packet_BMS)
            Marshal.FreeHGlobal(BMSPointer)
            Ind += Marshal.SizeOf(New Packet_BMS)
            Telemetry.BMS = BMS
        End If
        If (Setting And MASK_TEMPS) Then
            Dim TempsPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Temps))
            Marshal.Copy(RXData, Ind, TempsPointer, Marshal.SizeOf(Temps))
            Temps = CType(Marshal.PtrToStructure(TempsPointer, GetType(Packet_Temps)), Packet_Temps)
            Marshal.FreeHGlobal(TempsPointer)
            Ind += Marshal.SizeOf(New Packet_Temps)
            Telemetry.Temps = Temps
        End If
        If (Setting And MASK_PEDALS) Then
            Dim PedalsPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Pedals))
            Marshal.Copy(RXData, Ind, PedalsPointer, Marshal.SizeOf(Pedals))
            Pedals = CType(Marshal.PtrToStructure(PedalsPointer, GetType(Packet_Pedals)), Packet_Pedals)
            Marshal.FreeHGlobal(PedalsPointer)
            Ind += Marshal.SizeOf(New Packet_Pedals)
            Telemetry.Pedals = Pedals
        End If
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
                Case ID_SEND_CAN
                    LoadCAN()
                Case ID_SEND_TELEMETRY
                    LoadTelemetry()
                    DisplayTelemetry(Telemetry)
                    PlotTelemetry(Telemetry)
                    LogTelemetry(Telemetry)
                Case Else
                    DisplayStatus("Unknown packet ID", Color.Orange, 3000)
            End Select
        Catch ex As Exception
            ProcessSuccess()
            'MsgBox("Data process error. " & ex.Message, MsgBoxStyle.Critical, "Error")
            Console.WriteLine(ex.Message)
        End Try
        ProcessSuccess()
    End Sub

    Private Sub ProcessSuccess()
        DataReady = False
        RXData = {}
        PacketsProcessed += 1
    End Sub

#End Region

#Region "Buttons"
    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        Try
            If Button_Connect.Text = "Connect" Then
                If SerialPort.IsOpen Then
                    SerialPort.Close()
                End If
                SerialPort.PortName = ComboBox_Ports.SelectedItem
                SerialPort.Open()
                If CheckBox_OverrideConnection.Checked Then
                    Connected = True
                    Exit Sub
                End If
                System.Threading.Thread.Sleep(110)
                Send({ID_CONNECTION})
            Else
                SerialPort.Close()
                Connected = False
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
#End Region

#Region "Displaying"
    Private Sub DisplayCAN(ByVal Message As CAN_Message)
        For Each Item As ListViewItem In ListView_CAN.Items
            If Item.Text = Message.ID Then
                ' Update item
                Item.SubItems(1).Text = Message.Length
                Item.SubItems(2).Text = HexDump(Message.Data, Message.Length)
                Exit Sub
            End If
        Next
        Dim Tmp As New ListViewItem()
        Tmp.Text = Message.ID
        Dim SubItem As New ListViewItem.ListViewSubItem()
        SubItem.Text = Message.Length
        Tmp.SubItems.Add(SubItem)
        SubItem = New ListViewItem.ListViewSubItem()
        SubItem.Text = HexDump(Message.Data, Message.Length)
        Tmp.SubItems.Add(SubItem)
        ListView_CAN.Items.Add(Tmp)
    End Sub

    Private Sub DisplayTelemetry(ByRef Telemetry As Car_Telemetry)
        ListView_Telemetry.Items.Clear()
        PrintStructure(ListView_Telemetry, Telemetry.Timestamp)
        With Telemetry.Timestamp
            Dim Tmp As Integer = ParseUInt32({0, .TimestampMSB, .TimestampMMSB, .TimestampLSB}, 0)
            Label_Interval.Text = "Interval: " & Tmp - LastTelemetry & "ms"
            LastTelemetry = Tmp
        End With
        With Telemetry.Timestamp
            Dim Tmp As Integer = ParseUInt32({0, .IndexMSB, .IndexMMSB, .IndexLSB}, 0)
            If Not PacketSync Then
                LastIndex = Tmp - 1
                PacketSync = True
            End If
            LostPackets += Tmp - LastIndex - 1
            Label_LostPackets.Text = "Lost Packets: " & LostPackets
            LastIndex = Tmp
        End With
        If Telemetry.Settings And MASK_PERF Then
            PrintStructure(ListView_Telemetry, Telemetry.Performance)
            DisplayPerformance(Telemetry.Performance)
        End If
        If Telemetry.Settings And MASK_BMS Then
            PrintStructure(ListView_Telemetry, Telemetry.BMS)
            DisplayBMS(Telemetry.BMS)
        End If
        If Telemetry.Settings And MASK_TEMPS Then
            PrintStructure(ListView_Telemetry, Telemetry.Temps)
            DisplayTemps(Telemetry.Temps)
        End If
        If Telemetry.Settings And MASK_PEDALS Then
            PrintStructure(ListView_Telemetry, Telemetry.Pedals)
            DisplayPedals(Telemetry.Pedals)
        End If
        If Telemetry.Settings And MASK_WHEELS Then
            PrintStructure(ListView_Telemetry, Telemetry.Wheels)
            DisplayWheels(Telemetry.Wheels)
        End If
        If Telemetry.Settings And MASK_VCU Then
            PrintStructure(ListView_Telemetry, Telemetry.VCU)
            DisplayVCU(Telemetry.VCU)
        End If
        If Telemetry.Settings And MASK_IMU Then
            PrintStructure(ListView_Telemetry, Telemetry.IMU)
            DisplayIMU(Telemetry.IMU)
        End If

    End Sub

    Private Sub PrintStructure(ByRef List As ListView, ByRef Struct As Object)
        Dim TelemetryType As Type = Struct.GetType
        For Each ProcessedField As Reflection.FieldInfo In TelemetryType.GetFields
            Dim Item As New ListViewItem()
            Item.Text = ProcessedField.Name
            Dim SubItem As New ListViewItem.ListViewSubItem()
            SubItem.Text = ProcessedField.FieldType.Name
            Item.SubItems.Add(SubItem)
            SubItem = New ListViewItem.ListViewSubItem()
            SubItem.Text = ProcessedField.GetValue(Struct)
            Item.SubItems.Add(SubItem)
            List.Items.Add(Item)
        Next
    End Sub

    Private Sub DisplayPerformance(ByVal Packet As Packet_Performance)
        Label_RPM.Text = Packet.RPM & " RPM"
        ' Torque not used yet
        Label_Current.Text = Packet.IVT_Current & " A"
        Label_Voltage.Text = Packet.IVT_Voltage & " V"
        Label_Power.Text = Packet.IVT_Voltage * Packet.IVT_Current & " W"
    End Sub

    Private Sub DisplayBMS(ByVal Packet As Packet_BMS)
        ListView_BMS.Items(0).SubItems(1).Text = (Packet.Voltage_Min_Left / 100.0F + 1.7) & " V"
        ListView_BMS.Items(0).SubItems(2).Text = (Packet.Voltage_Max_Left / 100.0F + 1.7) & " V"
        ListView_BMS.Items(0).SubItems(3).Text = Packet.Temp_Min_Left / 2.0F & " C"
        ListView_BMS.Items(0).SubItems(4).Text = Packet.Temp_Max_Left / 2.0F & " C"
        ListView_BMS.Items(1).SubItems(1).Text = (Packet.Voltage_Min_Right / 100.0F + 1.7) & " V"
        ListView_BMS.Items(1).SubItems(2).Text = (Packet.Voltage_Max_Right / 100.0F + 1.7) & " V"
        ListView_BMS.Items(1).SubItems(3).Text = Packet.Temp_Min_Right / 2.0F & " C"
        ListView_BMS.Items(1).SubItems(4).Text = Packet.Temp_Max_Right / 2.0F & " C"
    End Sub

    Private Sub DisplayTemps(ByVal Packet As Packet_Temps)
        ListView_Temperature.Items(0).SubItems(1).Text = (Packet.IGBT / 2.0F + 20) & " C"
        ListView_Temperature.Items(1).SubItems(1).Text = (Packet.Motor / 2.0F + 20) & " C"
        ListView_Temperature.Items(2).SubItems(1).Text = (Packet.Coolant_In / 2.0F + 20) & " C"
        ListView_Temperature.Items(3).SubItems(1).Text = (Packet.Coolant_Out / 2.0F + 20) & " C"
        ListView_Temperature.Items(4).SubItems(1).Text = (Packet.Gearbox / 2.0F + 20) & " C"
        Label_Temps_BrakeLeft.Text = (Packet.BrakeLeft * 2.0F + 20) & " C"
        Label_Temps_BrakeRight.Text = (Packet.BrakeRight * 2.0F + 20) & " C"
    End Sub

    Private Sub DisplayPedals(ByVal Packet As Packet_Pedals)
        ProgressBar_Throttle.Value = Constrain(Packet.Throttle_12 / 2, 0, 100)
        Label_Throttle.Text = Math.Floor(Packet.Throttle_12 / 2.0F) & " %"
        ProgressBar_BrakeFront.Value = Constrain(Packet.Brake_Front, 0, 200)
        Label_BrakeFront.Text = Packet.Brake_Front & " Bar"
        ProgressBar_BrakeRear.Value = Constrain(Packet.Brake_Rear, 0, 200)
        Label_BrakeRear.Text = Packet.Brake_Rear & " Bar"
    End Sub

    Private Sub DisplayWheels(ByVal Packet As Packet_Wheels)
        Label_RPM_FrontLeft.Text = Packet.RPM_Front_Left & " RPM"
        Label_RPM_FrontRight.Text = Packet.RPM_Front_Right & " RPM"
        Label_RPM_RearLeft.Text = Packet.RPM_Rear_Left & " RPM"
        Label_RPM_RearRight.Text = Packet.RPM_Rear_Right & " RPM"
    End Sub

    Private Sub DisplayVCU(ByVal Packet As Packet_VCU)
        ListView_VCU.Items(0).SubItems(1).Text = Packet.ETD
        ListView_VCU.Items(1).SubItems(1).Text = Packet.BMSA
        ListView_VCU.Items(2).SubItems(1).Text = Packet.MCMS
        ListView_VCU.Items(3).SubItems(1).Text = Packet.EMA
        ListView_VCU.Items(4).SubItems(1).Text = Packet.CDS
        ListView_VCU.Items(5).SubItems(1).Text = Packet.PLS
        ListView_VCU.Items(6).SubItems(1).Text = Packet.Current_Low_Battery
    End Sub

    Private Sub DisplayIMU(ByVal Packet As Packet_IMU)
        ' Not utilized yet
    End Sub
#End Region

#Region "Plotting"

    ' Scrolling
    Private Sub Chart_AxisViewChanged(sender As Object, e As ViewEventArgs) Handles Chart.AxisViewChanged
        ' Keep the scroll aligned between all charts
        Dim ca1 As ChartArea = Chart.ChartAreas(0)
        Dim ca2 As ChartArea = Chart.ChartAreas(1)
        Dim ca3 As ChartArea = Chart.ChartAreas(2)
        Dim ca4 As ChartArea = Chart.ChartAreas(3)
        Dim ax1 As Axis = ca1.AxisX
        Dim ax2 As Axis = ca2.AxisX
        Dim ax3 As Axis = ca3.AxisX
        Dim ax4 As Axis = ca4.AxisX
        If e.Axis Is ax1 Then
            ax2.ScaleView.Size = ax1.ScaleView.Size
            ax2.ScaleView.Position = ax1.ScaleView.Position
            ax3.ScaleView.Size = ax1.ScaleView.Size
            ax3.ScaleView.Position = ax1.ScaleView.Position
            ax4.ScaleView.Size = ax1.ScaleView.Size
            ax4.ScaleView.Position = ax1.ScaleView.Position
        End If
        If e.Axis Is ax2 Then
            ax1.ScaleView.Size = ax2.ScaleView.Size
            ax1.ScaleView.Position = ax2.ScaleView.Position
            ax3.ScaleView.Size = ax2.ScaleView.Size
            ax3.ScaleView.Position = ax2.ScaleView.Position
            ax4.ScaleView.Size = ax2.ScaleView.Size
            ax4.ScaleView.Position = ax2.ScaleView.Position
        End If
        If e.Axis Is ax3 Then
            ax1.ScaleView.Size = ax3.ScaleView.Size
            ax1.ScaleView.Position = ax3.ScaleView.Position
            ax2.ScaleView.Size = ax3.ScaleView.Size
            ax2.ScaleView.Position = ax3.ScaleView.Position
            ax4.ScaleView.Size = ax3.ScaleView.Size
            ax4.ScaleView.Position = ax3.ScaleView.Position
        End If
        If e.Axis Is ax4 Then
            ax1.ScaleView.Size = ax4.ScaleView.Size
            ax1.ScaleView.Position = ax4.ScaleView.Position
            ax2.ScaleView.Size = ax4.ScaleView.Size
            ax2.ScaleView.Position = ax4.ScaleView.Position
            ax3.ScaleView.Size = ax4.ScaleView.Size
            ax3.ScaleView.Position = ax4.ScaleView.Position
        End If
        CheckBox_AutoScroll.Checked = False
    End Sub

    ' Scaling
    Private Sub AutoScaleY()
        If CheckBox_AutoScale.Checked Then
            For Each Area As ChartArea In Chart.ChartAreas
                For Each Series As Series In Chart.Series
                    If Series.ChartArea = Area.Name And Series.Enabled Then
                        Try
                            Dim viewMin As Double = Area.AxisX.ScaleView.ViewMinimum
                            Dim viewMax As Double = Area.AxisX.ScaleView.ViewMaximum
                            Dim min As DataPoint = New DataPoint(0, Double.MaxValue)
                            Dim max As DataPoint = New DataPoint(0, Double.MinValue)
                            'Loop through all points to find min & max
                            For Each dp As DataPoint In Series.Points
                                'Set min & max points only in the range of the view
                                If dp.XValue >= viewMin And dp.XValue <= viewMax Then
                                    'Compares Yvalues(0)
                                    If dp.YValues(0) > max.YValues(0) Then max = dp
                                    If dp.YValues(0) < min.YValues(0) Then min = dp
                                ElseIf dp.XValue >= viewMax Then
                                    'Exit for if already past the view
                                    Exit For
                                End If
                            Next
                            'How much space you want between axes and zoomed min & max.
                            'A bit tricky as it has to depend on the scale of the zoom.
                            'Feel free to improve the algorithm.
                            Dim buffer As Double = 10 ^ Math.Floor(Math.Log10(max.YValues(0) - min.YValues(0))) / 10
                            'Change the y-axis limits based on min & max of current view
                            If Series.YAxisType = AxisType.Primary Then
                                Area.AxisY.Minimum = min.YValues(0) - buffer
                                Area.AxisY.Maximum = max.YValues(0) + buffer
                            Else
                                Area.AxisY2.Minimum = min.YValues(0) - buffer
                                Area.AxisY2.Maximum = max.YValues(0) + buffer
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                Next
            Next
        End If
    End Sub

    ' Zooming
    Private ScaleSize As Double = 20.0
    Private Const MinScaleSize As Double = 5.0
    Private Const MaxScaleSize As Double = 30.0
    Private Const StepScaleSize As Double = 2.5
    Private Const ScaleInterval As Integer = 4
    Private Sub Chart_MouseWheel(sender As Object, e As MouseEventArgs) Handles Chart.MouseWheel
        With Chart
            If (e.Delta > 0) Then
                ' Zoom In
                If ScaleSize > MinScaleSize Then
                    ScaleSize -= StepScaleSize
                Else
                    ScaleSize = MinScaleSize
                End If
            End If
            If (e.Delta < 0) Then
                ' Zoom Out
                If ScaleSize < MaxScaleSize Then
                    ScaleSize += StepScaleSize
                Else
                    ScaleSize = MaxScaleSize
                End If
            End If
            For Index As Integer = 0 To .ChartAreas.Count - 1
                .ChartAreas(Index).AxisX.ScaleView.Size = ScaleSize
                .ChartAreas(Index).AxisX.LabelStyle.Interval = ScaleSize / ScaleInterval
            Next
        End With
        AutoScaleY()
    End Sub

    ' Enable/disable showing of series
    Private Sub CheckSeries() Handles CheckBox_PlotThrottle.CheckedChanged, CheckBox_PlotMotorTemp.CheckedChanged,
        CheckBox_PlotIGBTTemp.CheckedChanged, CheckBox_PlotGearboxTemp.CheckedChanged, CheckBox_PlotCoolantOut.CheckedChanged, CheckBox_PlotCoolantIn.CheckedChanged,
        CheckBox_PlotBrakeRear.CheckedChanged, CheckBox_PlotBrakeFront.CheckedChanged, CheckBox_PlotBrakeLeft.CheckedChanged, CheckBox_PlotBrakeRight.CheckedChanged,
        CheckBox_PlotFrontLeftRPM.CheckedChanged, CheckBox_PlotFrontRightRPM.CheckedChanged, CheckBox_PlotRPM.CheckedChanged
        ' Make sure they were initialized
        If Chart.Series.Count > 0 Then
            Chart.Series("Series_Throttle").Enabled = CheckBox_PlotThrottle.Checked
            Chart.Series("Series_BrakeFront").Enabled = CheckBox_PlotBrakeFront.Checked
            Chart.Series("Series_BrakeRear").Enabled = CheckBox_PlotBrakeRear.Checked
            Chart.Series("Series_CoolantIn").Enabled = CheckBox_PlotCoolantIn.Checked
            Chart.Series("Series_CoolantOut").Enabled = CheckBox_PlotCoolantOut.Checked
            Chart.Series("Series_MotorTemp").Enabled = CheckBox_PlotMotorTemp.Checked
            Chart.Series("Series_IGBTTemp").Enabled = CheckBox_PlotIGBTTemp.Checked
            Chart.Series("Series_GearboxTemp").Enabled = CheckBox_PlotGearboxTemp.Checked
            Chart.Series("Series_BrakeLeft").Enabled = CheckBox_PlotBrakeLeft.Checked
            Chart.Series("Series_BrakeRight").Enabled = CheckBox_PlotBrakeRight.Checked
            Chart.Series("Series_FrontLeftRPM").Enabled = CheckBox_PlotFrontLeftRPM.Checked
            Chart.Series("Series_FrontRightRPM").Enabled = CheckBox_PlotFrontRightRPM.Checked
            Chart.Series("Series_RPM").Enabled = CheckBox_PlotRPM.Checked
        End If
        CheckAreas()
    End Sub

    ' Enable/disable showing of chart areas
    Private Sub CheckAreas()
        If Chart.ChartAreas.Count > 0 Then
            Chart.ChartAreas("ChartArea_Pedals").Visible = Chart.Series("Series_Throttle").Enabled Or
                Chart.Series("Series_BrakeFront").Enabled Or Chart.Series("Series_BrakeRear").Enabled
            Chart.ChartAreas("ChartArea_Temps2").Visible = Chart.Series("Series_CoolantIn").Enabled Or
                Chart.Series("Series_CoolantOut").Enabled Or
                Chart.Series("Series_BrakeLeft").Enabled Or Chart.Series("Series_BrakeRight").Enabled
            Chart.ChartAreas("ChartArea_Temps").Visible = Chart.Series("Series_MotorTemp").Enabled Or
                Chart.Series("Series_IGBTTemp").Enabled Or Chart.Series("Series_GearboxTemp").Enabled
            Chart.ChartAreas("ChartArea_RPM").Visible = Chart.Series("Series_FrontLeftRPM").Enabled Or
                Chart.Series("Series_FrontRightRPM").Enabled Or Chart.Series("Series_RPM").Enabled
        End If
    End Sub

#End Region

#Region "Telemetry"

    ' Create random telemetry values to try the plots
    Private Sub Timer_RandomTelemetry_Tick(sender As Object, e As EventArgs) Handles Timer_RandomTelemetry.Tick

        ' Constain to compressed values
        Telemetry.Settings = 255

        Telemetry.Pedals.Throttle_12 = RandomGenerator.Next(0, 100)
        Telemetry.Pedals.Brake_Front = RandomGenerator.Next(0, 200)
        Telemetry.Pedals.Brake_Rear = RandomGenerator.Next(0, 200)

        Telemetry.Temps.Coolant_In = RandomGenerator.Next(0, 150)
        Telemetry.Temps.Coolant_Out = RandomGenerator.Next(0, 150)
        Telemetry.Temps.Motor = RandomGenerator.Next(0, 150)
        Telemetry.Temps.IGBT = RandomGenerator.Next(0, 150)
        Telemetry.Temps.Gearbox = RandomGenerator.Next(0, 150)

        Telemetry.Temps.BrakeLeft = RandomGenerator.Next(0, 255)
        Telemetry.Temps.BrakeRight = RandomGenerator.Next(0, 255)

        Telemetry.Wheels.RPM_Front_Left = RandomGenerator.Next(0, 255)
        Telemetry.Wheels.RPM_Front_Right = RandomGenerator.Next(0, 255)
        Telemetry.Performance.RPM = RandomGenerator.Next(0, 10000)

        DisplayTelemetry(Telemetry)
        PlotTelemetry(Telemetry)
        LogTelemetry(Telemetry)

    End Sub

    Private Sub PlotTelemetry(ByVal Data As Car_Telemetry, ByVal Optional Time As Date = Nothing)
        If Not CheckBox_Plotting.Checked Then
            Exit Sub
        End If
        If Time = Nothing Then
            Time = Now
        End If
        ' Decompress telemetry values before plotting
        Chart.Series("Series_Throttle").Points.AddXY(Time, Data.Pedals.Throttle_12)
        Chart.Series("Series_BrakeFront").Points.AddXY(Time, Data.Pedals.Brake_Front)
        Chart.Series("Series_BrakeRear").Points.AddXY(Time, Data.Pedals.Brake_Rear)
        Chart.Series("Series_CoolantIn").Points.AddXY(Time, Data.Temps.Coolant_In)
        Chart.Series("Series_CoolantOut").Points.AddXY(Time, Data.Temps.Coolant_Out)
        Chart.Series("Series_MotorTemp").Points.AddXY(Time, Data.Temps.Motor)
        Chart.Series("Series_IGBTTemp").Points.AddXY(Time, Data.Temps.IGBT)
        Chart.Series("Series_GearboxTemp").Points.AddXY(Time, Data.Temps.Gearbox)
        Chart.Series("Series_BrakeLeft").Points.AddXY(Time, (Data.Temps.BrakeLeft * 2.0F + 20))
        Chart.Series("Series_BrakeRight").Points.AddXY(Time, (Data.Temps.BrakeRight * 2.0F + 20))
        Chart.Series("Series_FrontLeftRPM").Points.AddXY(Time, Data.Wheels.RPM_Front_Left)
        Chart.Series("Series_FrontRightRPM").Points.AddXY(Time, Data.Wheels.RPM_Front_Right)
        Chart.Series("Series_RPM").Points.AddXY(Time, Data.Performance.RPM)
        ' Autoscroll
        If CheckBox_AutoScroll.Checked Then
            Chart.ChartAreas("ChartArea_Pedals").AxisX.ScaleView.Scroll(Time)
            Chart.ChartAreas("ChartArea_Temps2").AxisX.ScaleView.Scroll(Time)
            Chart.ChartAreas("ChartArea_Temps").AxisX.ScaleView.Scroll(Time)
            Chart.ChartAreas("ChartArea_RPM").AxisX.ScaleView.Scroll(Time)
        End If
        ' Autoscale
        AutoScaleY()
    End Sub

    ' Enable/disable the random plotting
    Private Sub CheckBox_RandomPlot_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_RandomTelemetry.CheckedChanged
        If CheckBox_RandomTelemetry.Checked Then
            Timer_RandomTelemetry.Start()
        Else
            Timer_RandomTelemetry.Stop()
        End If
    End Sub

#End Region

#Region "Logging"

    Private Sub LogTelemetry(ByVal Data As Car_Telemetry)
        If Not CheckBox_Logging.Checked Then
            Exit Sub
        End If
        Log.Write(Telemetry)
    End Sub

    Private Sub CheckBox_Logging_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Logging.CheckedChanged
        If CheckBox_Logging.Checked Then
            Log = New Logger(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\")
        Else
            Log.Close()
            Log = Nothing
        End If
    End Sub

#End Region

End Class
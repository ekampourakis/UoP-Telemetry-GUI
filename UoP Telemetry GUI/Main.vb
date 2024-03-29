﻿Imports UoP_Telemetry_GUI.Arithmetic
Imports UoP_Telemetry_GUI.Definitions

Imports UNOLibs.Net

Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Main

    Private DeveloperMode As Boolean = False
    Private Const BypassConnection As Boolean = True
    Private Car As New Car_Mixed
    Private Const Monitoring As Boolean = True
    Private RandomGenerator As New Random

    Private Sub CreateSeries()
        Chart.Series.Clear()
        CheckedListBox_ChartSeries.Items.Clear()
        Dim S As String() = My.Resources.ChartSeries.Split(vbNewLine)

        For Each Str As String In S
            Str = Str.Replace(vbCr, "").Replace(vbLf, "")
            If Str.StartsWith("#") Then
                Continue For
            End If
            Dim L As String() = Str.Split("|")
            Dim Ser As New Series()
            Ser.Name = "Series_" & L(0)
            Ser.ChartArea = "ChartArea_" & L(1)
            Ser.Legend = "Legend_" & L(2)
            Ser.LegendText = L(3) & " Min: #MIN{D0}%, Max: #MAX{D0}%"
            Ser.Color = ColorTranslator.FromHtml(L(4))

            Ser.ChartType = SeriesChartType.FastLine
            Ser.XValueType = ChartValueType.Time
            Ser.BorderWidth = 3

            If L(5) = "Single" Then
                Ser.YValueType = ChartValueType.Single
            ElseIf L(5) = "UInt32" Then
                Ser.YValueType = ChartValueType.UInt32
            ElseIf L(5) = "Int32" Then
                Ser.YValueType = ChartValueType.Int32
            End If

            If L(6) = "Primary" Then
                Ser.YAxisType = AxisType.Primary
            Else
                Ser.YAxisType = AxisType.Secondary
            End If

            Chart.Series.Add(Ser)
            CheckedListBox_ChartSeries.Items.Add(Ser.Name)
            CheckedListBox_ChartSeries.SetItemChecked(CheckedListBox_ChartSeries.Items.Count - 1, True)
        Next

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BypassConnection Then
            HidePages()
            AutoConnectSerial()
        End If
        If CheckBox_AutoStartLog.Checked Then StartTelemetryLogging() : StartBMSLogging()
        If Not DeveloperMode Then
            HideDeveloper()
        End If
        RegisterHotKey(Me.Handle, 100, MOD_ALT, Keys.C)
        Label_Sockets_Info.Text = "Local IP: " & Server.LocalIP
        CreateSeries()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TelemetryLog IsNot Nothing Then TelemetryLog.Close()
        If BMSLog IsNot Nothing Then BMSLog.Close()
        My.Settings.Save()
        UnregisterHotKey(Me.Handle, 100)
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
        ' Serial status
        If Connected Then
            ToolStripStatusLabel_SerialStatus.ForeColor = Color.Green
            ToolStripStatusLabel_SerialStatus.Text = "Connected"
            Button_Connect.Text = "Disconnect"
            ComboBox_Ports.Enabled = False
        Else
            ToolStripStatusLabel_SerialStatus.ForeColor = Color.Firebrick
            ToolStripStatusLabel_SerialStatus.Text = "Disconnected"
            Button_Connect.Text = "Connect"
            ComboBox_Ports.Enabled = True
        End If
        ' Packets status
        ToolStripStatusLabel_SerialInfo.Text = "Queued: " & TXQueue.Count & " | Processed: " & PacketsProcessed
        ' Logging status
        Static Counter As Integer = 0
        Const BlinkInterval As Integer = 800 ' in ms
        Dim CounterLimit As Integer = (BlinkInterval / Timer_GUIUpdate.Interval)
        Counter += 1
        If Counter > CounterLimit * 2 Then Counter = 0
        If TelemetryLog IsNot Nothing Then
            If Counter >= 0 And Counter < CounterLimit Then
                ToolStripStatusLabel_TelemetryLogging.ForeColor = Color.Green
                ToolStripStatusLabel_TelemetryLogging.Text = "Telemetry Logging"
            Else
                ToolStripStatusLabel_TelemetryLogging.ForeColor = Color.Orange
                ToolStripStatusLabel_TelemetryLogging.Text = "Telemetry Logging"
            End If
        Else
            ToolStripStatusLabel_TelemetryLogging.ForeColor = Color.Firebrick
            ToolStripStatusLabel_TelemetryLogging.Text = "Telemetry Not Logging"
        End If
        If BMSLog IsNot Nothing Then
            If Counter >= 0 And Counter < CounterLimit Then
                ToolStripStatusLabel_BMSLogging.ForeColor = Color.Green
                ToolStripStatusLabel_BMSLogging.Text = "BMS Logging"
            Else
                ToolStripStatusLabel_BMSLogging.ForeColor = Color.Orange
                ToolStripStatusLabel_BMSLogging.Text = "BMS Logging"
            End If
        Else
            ToolStripStatusLabel_BMSLogging.ForeColor = Color.Firebrick
            ToolStripStatusLabel_BMSLogging.Text = "BMS Not Logging"
        End If
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

#Region "Hidden Pages"
    Private HiddenPages As New List(Of TabPage)

    Private Sub ShowHiddenPages()
        If HiddenPages.Count > 0 Then
            For Each Tab As TabPage In HiddenPages
                TabControl.TabPages.Insert(TabControl.TabCount - 1, Tab)
            Next
            HiddenPages.Clear()
            TabControl.SelectedIndex = 0
        End If
    End Sub

    Private Sub HidePages()
        If HiddenPages.Count = 0 Then
            Dim ConnectionPage As TabPage = TabControl.TabPages("TabPage_Connection")
            For Each Tab As TabPage In TabControl.TabPages()
                HiddenPages.Add(Tab)
            Next
            HiddenPages.Remove(ConnectionPage)
            TabControl.TabPages.Clear()
            TabControl.TabPages.Add(ConnectionPage)
        End If
    End Sub
#End Region

#End Region

#Region "Developer Mode"
    Public Const MOD_ALT As Integer = &H1           'Alt key
    Public Const WM_HOTKEY As Integer = &H312       '

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    If DeveloperMode Then
                        HideDeveloper()
                    Else
                        ShowDeveloper()
                    End If
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub ShowDeveloper()
        GroupBox_CAN_Outcoming.Visible = True
        TabControl.TabPages(4).Visible = True
        DeveloperMode = True
    End Sub

    Private Sub HideDeveloper()
        GroupBox_CAN_Outcoming.Visible = False
        TabControl.TabPages(4).Visible = False
        DeveloperMode = False
    End Sub
#End Region

#Region "Serial"
#Region "Connection"
    Private Sub ConnectSerial(ByVal COMPort As String)
        Try
            If SerialPort.IsOpen Then
                SerialPort.Close()
            End If
            SerialPort.PortName = COMPort
            SerialPort.Open()
            Connected = True
            My.Settings.COMPort = SerialPort.PortName
            ShowHiddenPages()
        Catch ex As Exception
            My.Settings.COMPort = ""
        End Try
        My.Settings.Save()
    End Sub

    Private Sub DisconnectSerial()
        SerialPort.Close()
        Connected = False
        HidePages()
        My.Settings.COMPort = ""
        My.Settings.Save()
    End Sub

    Private Sub AutoConnectSerial()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            If sp = My.Settings.COMPort And sp IsNot "" Then
                ComboBox_Ports.Text = sp
                While SerialPort.IsOpen() = False
                    ConnectSerial(sp)
                End While

            End If
        Next
        TabControl.SelectedIndex = 0
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
    Private AllowedIDs As Byte() = {ID_CONNECTION, ID_UNKNOWN, ID_MESSAGE, ID_SEND_CAN, ID_SEND_TELEMETRY, ID_SEND_BMS,
        ID_SEND_CAN_ANALYTICS, ID_SET_FUSEBOX_CONFIG, ID_GET_FUSEBOX_CONFIG, ID_LOG_TRANSFER}
    ' Packet IDs
    Private Const ID_CONNECTION As Byte = 0
    Private Const ID_UNKNOWN As Byte = 1
    Private Const ID_MESSAGE As Byte = 4
    Private Const ID_SEND_CAN As Byte = 5
    Private Const ID_SEND_TELEMETRY As Byte = 6
    Private Const ID_SEND_BMS As Byte = 7
    Private Const ID_SEND_CAN_ANALYTICS As Byte = 8
    Private Const ID_SET_FUSEBOX_CONFIG As Byte = 9
    Private Const ID_GET_FUSEBOX_CONFIG As Byte = 10
    Private Const ID_LOG_TRANSFER As Byte = 11

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
                        If RX(2) = WaitingID Or (Monitoring And AllowedIDs.Contains(RX(2))) Then
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
                                If CheckBox_Sockets_Forward.Checked Then
                                    For Each IP In ClientsList
                                        Try
                                            Client.SendMessage(IP, SendPort, Data)
                                        Catch ex As Exception
                                        End Try
                                    Next
                                End If
                                RXData = Data
                                RX.Clear()
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
                ReceiveFailed(False)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ReceiveFailed(ByVal Optional Display As Boolean = True)
        If Display Then DisplayStatus("Receive failed", Color.Firebrick)
        IsWaiting = False
        RX.Clear()
    End Sub

    Private Sub ReceiveSuccess()
        IsWaiting = False
        DataReady = True
        'RX.RemoveRange(0, RXData.Length + 5)
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

#Region "Serial Ping"
    Private WaitingSerialPing As Boolean = False
    Private SerialPingReceived As Boolean = False
    Private SerialPingTimerStage As Boolean = False
    Private SerialPingDelegate As New EventHandler(AddressOf SerialPingTimer)

    Private Sub SerialPingTimer()
        Timer_Generic.Stop()
        If SerialPingTimerStage Then
            RemoveHandler Timer_Generic.Tick, SerialPingDelegate
            SerialPingTimerStage = False
            Label_SerialPing.Text = ""
            Button_Ping.Enabled = True
        Else
            If SerialPingReceived Then
                Label_SerialPing.ForeColor = Color.Green
                Label_SerialPing.Text = "Connection OK"
            Else
                Label_SerialPing.ForeColor = Color.Firebrick
                Label_SerialPing.Text = "Connection Invalid"
            End If
            WaitingSerialPing = False
            SerialPingReceived = False
            SerialPingTimerStage = True
            Timer_Generic.Interval = 1500
            Timer_Generic.Start()
        End If
    End Sub

    Private Sub SerialPing()
        Button_Ping.Enabled = False
        Label_SerialPing.ForeColor = SystemColors.ControlText
        Label_SerialPing.Text = "Waiting..."
        Send({ID_CONNECTION})
        AddHandler Timer_Generic.Tick, SerialPingDelegate
        Timer_Generic.Interval = 1000
        Timer_Generic.Start()
        SerialPingTimerStage = False
        WaitingSerialPing = True
        SerialPingReceived = False
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
        Dim CANMessage As CAN_Message
        Dim Ind As Integer = 1
        CANMessage.ID = ParseUInt16(RXData, Ind)
        CANMessage.Length = ParseByte(RXData, Ind)
        Dim Tmp As Byte() = {0, 0, 0, 0, 0, 0, 0, 0}
        CANMessage.Data = Tmp
        For Index As Integer = 0 To CANMessage.Length - 1
            CANMessage.Data(Index) = ParseByte(RXData, Ind)
        Next
        DisplayCAN(CANMessage)
    End Sub

    Private Sub LoadCAN_Analytics()
        Dim CANMessage As CAN_Message
        Dim Ind As Integer = 1
        CANMessage.ID = ParseUInt16(RXData, Ind)
        CANMessage.Length = ParseByte(RXData, Ind)
        Dim Tmp As Byte() = {0, 0, 0, 0, 0, 0, 0, 0}
        CANMessage.Data = Tmp
        For Index As Integer = 0 To CANMessage.Length - 1
            CANMessage.Data(Index) = ParseByte(RXData, Ind)
        Next
        CANMessage.CycleTime = ParseUInt16(RXData, Ind, False)
        CANMessage.Count = ParseUInt32(RXData, Ind, False)
        DisplayCAN_Analytics(CANMessage)
    End Sub

    Private Sub LoadTelemetry()
        Dim Ind As Integer = 1

        Dim Timestamp As New Packet_Timestamp
        Dim Sensors As New Car_Raw

        Dim TimestampPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Timestamp))
        Marshal.Copy(RXData, Ind, TimestampPointer, Marshal.SizeOf(Timestamp))
        Timestamp = CType(Marshal.PtrToStructure(TimestampPointer, GetType(Packet_Timestamp)), Packet_Timestamp)
        Marshal.FreeHGlobal(TimestampPointer)
        Ind += Marshal.SizeOf(New Packet_Timestamp)
        Car.Timestamp = Timestamp
        Dim s As Integer = Marshal.SizeOf(Sensors)
        Dim SensorsPointer As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Sensors))
        Marshal.Copy(RXData, Ind, SensorsPointer, Marshal.SizeOf(Sensors))
        Sensors = CType(Marshal.PtrToStructure(SensorsPointer, GetType(Car_Raw)), Car_Raw)
        Marshal.FreeHGlobal(SensorsPointer)
        Ind += Marshal.SizeOf(New Car_Raw)
        Car.Sensors = Sensors

    End Sub

    Private Sub LoadBMS()
        Dim VoltagesSize As Integer = RXData(1)
        For Index As Integer = 0 To VoltagesSize - 1
            Car.BMS.Voltages(Index) = RXData(Index + 1)
        Next
        Dim TemperaturesSize As Integer = RXData(1 + VoltagesSize)
        For Index As Integer = 0 To TemperaturesSize - 1
            Car.BMS.Temperatures(Index) = RXData(Index + VoltagesSize + 1)
        Next
    End Sub

    Private Sub LoadFuseboxConfig()

        Dim Conf As Configuration_Fusebox
        Dim Ind As Integer = 1
        Conf.TelemetryEnabled = ParseByte(RXData, Ind)
        Conf.CANForward = ParseByte(RXData, Ind)
        Conf.CANForwardInterval = ParseByte(RXData, Ind)
        Conf.SelectiveSampling = ParseByte(RXData, Ind)
        Conf.TelemetryTX = ParseByte(RXData, Ind)
        Conf.Telemetry2TX = ParseByte(RXData, Ind)

        CheckBox_Config_Fusebox_TelemetryEnabled.Checked = Conf.TelemetryEnabled
        CheckBox_Config_Fusebox_CANForward.Checked = Conf.CANForward
        NumericUpDown_Config_Fusebox_CANInterval.Value = Conf.CANForwardInterval
        TextBox_Config_Fusebox_SelectiveSampling.Text = Conf.SelectiveSampling
        NumericUpDown_Config_Fusebox_TelemetryTX.Value = Conf.TelemetryTX
        NumericUpDown_Config_Fusebox_Telemetry2TX.Value = Conf.Telemetry2TX

    End Sub

    Private Sub ProcessData()
        'Try
        Select Case RXData(0)
                Case ID_CONNECTION
                    If WaitingSerialPing Then SerialPingReceived = True
                Case ID_UNKNOWN
                    ' Client responded with unknown ID packet. That means the received
                    ' packet to the client had an ID unknown to the client.
                Case ID_MESSAGE
                    LoadMessage()
                Case ID_SEND_CAN
                    LoadCAN()
                Case ID_SEND_CAN_ANALYTICS
                    LoadCAN_Analytics()
                Case ID_SEND_TELEMETRY
                    LoadTelemetry()
                    DisplayTelemetry()
                    PlotTelemetry()
                    LogTelemetry()
                Case ID_SEND_BMS
                    LoadBMS()
                    PlotBMS()
                    'LogBMS()
                Case ID_GET_FUSEBOX_CONFIG
                    LoadFuseboxConfig()
                Case ID_LOG_TRANSFER
                    LogTransfer_HandleRX()
                Case Else
                    DisplayStatus("Unknown packet ID", Color.Orange, 3000)
            End Select
        'Catch ex As Exception
        'ProcessSuccess()
        'MsgBox("Data process error. " & ex.Message, MsgBoxStyle.Critical, "Error")
        'Console.WriteLine("Process error: " & ex.Message)
        'Exit Sub
        'End Try
        'Catch ex As Exception
        '    ProcessSuccess()
        '    'MsgBox("Data process error. " & ex.Message, MsgBoxStyle.Critical, "Error")
        '    Console.WriteLine("RXData(0): " & RXData(0) & "   " & ex.Message)

        'End Try
        ProcessSuccess()
    End Sub

    Private Sub ProcessSuccess()
        RXData = {}
        PacketsProcessed += 1
        DataReady = False
    End Sub

#End Region

#Region "Buttons"
    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        Try
            If Button_Connect.Text = "Connect" Then
                ConnectSerial(ComboBox_Ports.SelectedItem)
                ' Not utilized
                'System.Threading.Thread.Sleep(110)
                'Send({ID_CONNECTION})
            Else
                DisconnectSerial()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button_Ping_Click(sender As Object, e As EventArgs) Handles Button_Ping.Click
        SerialPing()
    End Sub
#End Region

#Region "Displaying"
    Private Sub DisplayCAN(ByVal Message As CAN_Message)
        For Each Item As ListViewItem In ListView_CAN.Items
            If Item.Text = Convert.ToString(Message.ID, 16) Then
                ' Update item
                Item.SubItems(1).Text = Message.Length
                Item.SubItems(2).Text = HexDump(Message.Data, Message.Length)
                Exit Sub
            End If
        Next
        Dim Tmp As New ListViewItem()
        Tmp.Text = Convert.ToString(Message.ID, 16)

        Dim SubItem As New ListViewItem.ListViewSubItem()
        SubItem.Text = Message.Length
        Tmp.SubItems.Add(SubItem)

        SubItem = New ListViewItem.ListViewSubItem()
        SubItem.Text = HexDump(Message.Data, Message.Length)
        Tmp.SubItems.Add(SubItem)

        ListView_CAN.Items.Add(Tmp)
    End Sub

    Private Sub DisplayCAN_Analytics(ByVal Message As CAN_Message)
        Dim Load As Single = 0.0
        Dim RunningBits As Integer = 0
        Const Bandwidth As Integer = 500000
        Dim Bits As Integer = 0
        Const Overhead As Byte = 47
        Const MaxStuffing As Byte = 19
        Dim Found As Boolean = False
        For Each Item As ListViewItem In ListView_CAN.Items

            ' Calculate bus load in the same loop
            Dim MessageBits As Integer = (MaxStuffing * CSng(Item.SubItems(1).Text) / 8.0) + 1 + CInt(Item.SubItems(1).Text) * 8
            Dim Frequency As Single = 1000 / CInt(Item.SubItems(3).Text)
            RunningBits += (Overhead + MessageBits) * Frequency

            If Item.Text = Convert.ToString(Message.ID, 16) Then
                ' Update item
                Item.SubItems(1).Text = Message.Length
                Item.SubItems(2).Text = HexDump(Message.Data, Message.Length)
                Item.SubItems(3).Text = Message.CycleTime
                Item.SubItems(4).Text = Message.Count
                Found = True
            End If
        Next

        If Found Then
            GoTo CalculateLoad
        End If

        Dim Tmp As New ListViewItem()
        Tmp.Text = Convert.ToString(Message.ID, 16)

        Dim SubItem As New ListViewItem.ListViewSubItem()
        SubItem.Text = Message.Length
        Tmp.SubItems.Add(SubItem)

        SubItem = New ListViewItem.ListViewSubItem()
        SubItem.Text = HexDump(Message.Data, Message.Length)
        Tmp.SubItems.Add(SubItem)

        SubItem = New ListViewItem.ListViewSubItem()
        SubItem.Text = Message.CycleTime
        Tmp.SubItems.Add(SubItem)

        SubItem = New ListViewItem.ListViewSubItem()
        SubItem.Text = Message.Count
        Tmp.SubItems.Add(SubItem)

        ListView_CAN.Items.Add(Tmp)
CalculateLoad:

        Load = 100 * RunningBits / Bandwidth
        If Load < 0 Then Load = 0
        If Load > 100 Then Load = 100
        ProgressBar_CAN_Load.Value = Load
    End Sub

    Private Sub DisplayTelemetry()
        ListView_Telemetry.Items.Clear()
        PrintStructure(ListView_Telemetry, Car.Timestamp)
        With Car.Timestamp
            Dim Tmp As Integer = ParseUInt32({0, .TimestampMSB, .TimestampMMSB, .TimestampLSB}, 0)
            Label_Interval.Text = "Interval: " & Tmp - LastTelemetry & "ms"
            LastTelemetry = Tmp
        End With
        With Car.Timestamp
            Dim Tmp As Integer = ParseUInt32({0, .IndexMSB, .IndexMMSB, .IndexLSB}, 0)
            If Not PacketSync Then
                LastIndex = Tmp - 1
                PacketSync = True
            End If
            LostPackets += Tmp - LastIndex - 1
            Label_LostPackets.Text = "Lost Packets: " & LostPackets
            LastIndex = Tmp
        End With
        PrintStructure(ListView_Telemetry, Car.Sensors)

        ProgressBar_Throttle.Value = Car.Sensors.Throttle_12
        ProgressBar_BrakeTravel.Value = Car.Sensors.Brake_Travel
        ProgressBar_BrakeFront.Value = Car.Sensors.Brake_Front
        ProgressBar_BrakeRear.Value = Car.Sensors.Brake_Rear

        Label_SuspensionTravel_FrontLeft.Text = Car.Sensors.Suspension_Front_Left & " cm"
        Label_SuspensionTravel_FrontRight.Text = Car.Sensors.Suspension_Front_Right & " cm"
        Label_SuspensionTravel_RearLeft.Text = Car.Sensors.Suspension_Rear_Left & " cm"
        Label_SuspensionTravel_RearRight.Text = Car.Sensors.Suspension_Rear_Right & " cm"

        Label_Gearbox_FrontLeft.Text = Car.Sensors.Transmission_Front_Left & " °C"
        Label_Gearbox_FrontRight.Text = Car.Sensors.Transmission_Front_Right & " °C"
        Label_Gearbox_RearLeft.Text = Car.Sensors.Transmission_Rear_Left & " °C"
        Label_Gearbox_RearRight.Text = Car.Sensors.Transmission_Rear_Right & " °C"

        Label_CoolantTemp_InverterIn.Text = Car.Sensors.Coolant_In_1 & " °C"
        Label_CoolantTemp_InverterOut.Text = Car.Sensors.Coolant_Out_1 & " °C"
        Label_CoolantTemp_MotorIn.Text = Car.Sensors.Coolant_In_2 & " °C"
        Label_CoolantTemp_MotorOut.Text = Car.Sensors.Coolant_Out_2 & " °C"

        Label_SteeringAngle.Text = Car.Sensors.Steering_Angle & " °"

        Label_SuspensionStrain_FrontLeft.Text = Car.Sensors.Strain_Front_Left & " kg"
        Label_SuspensionStrain_FrontRight.Text = Car.Sensors.Strain_Front_Right & " kg"
        Label_SuspensionStrain_RearLeft.Text = Car.Sensors.Strain_Rear_Left & " kg"
        Label_SuspensionStrain_RearRight.Text = Car.Sensors.Strain_Rear_Right & " kg"

        Label_RPM_FrontLeft.Text = Car.Sensors.RPM_Front_Left & " RPM"
        Label_RPM_FrontRight.Text = Car.Sensors.RPM_Front_Right & " RPM"
        Label_RPM_RearLeft.Text = Car.Sensors.RPM_Rear_Left & " RPM"
        Label_RPM_RearRight.Text = Car.Sensors.RPM_Rear_Right & " RPM"

        Label_MotorTemp_FrontLeft.Text = Car.Sensors.Motor_Front_Left & " °C"
        Label_MotorTemp_FrontRight.Text = Car.Sensors.Motor_Front_Right & " °C"
        Label_MotorTemp_RearLeft.Text = Car.Sensors.Motor_Rear_Left & " °C"
        Label_MotorTemp_RearRight.Text = Car.Sensors.Motor_Rear_Right & " °C"

        Label_IGBT_FrontLeft.Text = Car.Sensors.IGBT_Front_Left & " °C"
        Label_IGBT_FrontRight.Text = Car.Sensors.IGBT_Front_Right & " °C"
        Label_IGBT_RearLeft.Text = Car.Sensors.IGBT_Rear_Left & " °C"
        Label_IGBT_RearRight.Text = Car.Sensors.IGBT_Rear_Right & " °C"

        Label_IGBT_FrontLeft.Text = Car.Sensors.IGBT_Front_Left & " °C"
        Label_IGBT_FrontRight.Text = Car.Sensors.IGBT_Front_Right & " °C"
        Label_IGBT_RearLeft.Text = Car.Sensors.IGBT_Rear_Left & " °C"
        Label_IGBT_RearRight.Text = Car.Sensors.IGBT_Rear_Right & " °C"

        Label_PlateTemp.Text = Car.Sensors.Plate_Front_Left & " °C"

        Label_Demanded_FrontLeft.Text = Car.Sensors.Demanded_Front_Left & " Nm"
        Label_Demanded_FrontRight.Text = Car.Sensors.Demanded_Front_Right & " Nm"
        Label_Demanded_RearLeft.Text = Car.Sensors.Demanded_Rear_Left & " Nm"
        Label_Demanded_RearRight.Text = Car.Sensors.Demanded_Rear_Right & " Nm"

        Label_Actual_FrontLeft.Text = Car.Sensors.Actual_Front_Left & " Nm"
        Label_Actual_FrontRight.Text = Car.Sensors.Actual_Front_Right & " Nm"
        Label_Actual_RearLeft.Text = Car.Sensors.Actual_Rear_Left & " Nm"
        Label_Actual_RearRight.Text = Car.Sensors.Actual_Rear_Right & " Nm"

        Label_Voltage.Text = Car.Sensors.IVT_Voltage & " V"
        Label_Current.Text = Car.Sensors.IVT_Current & " A"
        Label_Power.Text = Car.Sensors.IVT_Current * Car.Sensors.IVT_Voltage

        ListView_BMS.Items(0).SubItems(1).Text = Car.Sensors.Voltage_BMS_Min / 10000.0F & " V"
        ListView_BMS.Items(0).SubItems(2).Text = Car.Sensors.Voltage_BMS_Max / 10000.0F & " V"
        ' Not sure for unit
        ListView_BMS.Items(0).SubItems(3).Text = Car.Sensors.Temp_BMS_Min / 2.0F & " C"
        ListView_BMS.Items(0).SubItems(4).Text = Car.Sensors.Temp_BMS_Max / 2.0F & " C"



    End Sub

    Private Sub PrintStructure(ByRef List As ListView, ByRef Struct As Object)
        Dim TelemetryType As Type = Struct.GetType
        For Each ProcessedField As Reflection.FieldInfo In TelemetryType.GetFields
            Try
                Dim Item As New ListViewItem()
                Item.Text = ProcessedField.Name
                Dim SubItem As New ListViewItem.ListViewSubItem()
                SubItem.Text = ProcessedField.FieldType.Name
                Item.SubItems.Add(SubItem)
                SubItem = New ListViewItem.ListViewSubItem()
                SubItem.Text = ProcessedField.GetValue(Struct)
                Item.SubItems.Add(SubItem)
                List.Items.Add(Item)
            Catch ex As Exception

            End Try
        Next
    End Sub

#End Region

#Region "Telemetry Plotting"

    ' Scrolling
    Private Sub Chart_AxisViewChanged(sender As Object, e As ViewEventArgs) Handles Chart.AxisViewChanged
        If Not CheckBox_Plotting_Sync.Checked Then Exit Sub
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

    '' Enable/disable showing of series
    'Private Sub CheckSeries() Handles CheckBox_PlotThrottle.CheckedChanged, CheckBox_PlotMotorTemp.CheckedChanged,
    '    CheckBox_PlotIGBTTemp.CheckedChanged, CheckBox_PlotGearboxTemp.CheckedChanged, CheckBox_PlotCoolantOut.CheckedChanged, CheckBox_PlotCoolantIn.CheckedChanged,
    '    CheckBox_PlotBrakeRear.CheckedChanged, CheckBox_PlotBrakeFront.CheckedChanged, CheckBox_PlotBrakeLeft.CheckedChanged, CheckBox_PlotBrakeRight.CheckedChanged,
    '    CheckBox_PlotFrontLeftRPM.CheckedChanged, CheckBox_PlotFrontRightRPM.CheckedChanged, CheckBox_PlotRPM.CheckedChanged
    '    ' Make sure they were initialized
    '    If Chart.Series.Count > 0 Then
    '        Chart.Series("Series_Throttle").Enabled = CheckBox_PlotThrottle.Checked
    '        Chart.Series("Series_BrakeFront").Enabled = CheckBox_PlotBrakeFront.Checked
    '        Chart.Series("Series_BrakeRear").Enabled = CheckBox_PlotBrakeRear.Checked
    '        Chart.Series("Series_CoolantIn").Enabled = CheckBox_PlotCoolantIn.Checked
    '        Chart.Series("Series_CoolantOut").Enabled = CheckBox_PlotCoolantOut.Checked
    '        Chart.Series("Series_MotorTemp").Enabled = CheckBox_PlotMotorTemp.Checked
    '        Chart.Series("Series_IGBTTemp").Enabled = CheckBox_PlotIGBTTemp.Checked
    '        Chart.Series("Series_GearboxTemp").Enabled = CheckBox_PlotGearboxTemp.Checked
    '        Chart.Series("Series_BrakeLeft").Enabled = CheckBox_PlotBrakeLeft.Checked
    '        Chart.Series("Series_BrakeRight").Enabled = CheckBox_PlotBrakeRight.Checked
    '        Chart.Series("Series_FrontLeftRPM").Enabled = CheckBox_PlotFrontLeftRPM.Checked
    '        Chart.Series("Series_FrontRightRPM").Enabled = CheckBox_PlotFrontRightRPM.Checked
    '        Chart.Series("Series_RPM").Enabled = CheckBox_PlotRPM.Checked
    '    End If
    '    CheckAreas()
    'End Sub

    '' Enable/disable showing of chart areas
    'Private Sub CheckAreas()
    '    If Chart.ChartAreas.Count > 0 Then
    '        Chart.ChartAreas("ChartArea_Pedals").Visible = Chart.Series("Series_Throttle").Enabled Or
    '            Chart.Series("Series_BrakeFront").Enabled Or Chart.Series("Series_BrakeRear").Enabled
    '        Chart.ChartAreas("ChartArea_Temps2").Visible = Chart.Series("Series_CoolantIn").Enabled Or
    '            Chart.Series("Series_CoolantOut").Enabled Or
    '            Chart.Series("Series_BrakeLeft").Enabled Or Chart.Series("Series_BrakeRight").Enabled
    '        Chart.ChartAreas("ChartArea_Temps").Visible = Chart.Series("Series_MotorTemp").Enabled Or
    '            Chart.Series("Series_IGBTTemp").Enabled Or Chart.Series("Series_GearboxTemp").Enabled
    '        Chart.ChartAreas("ChartArea_RPM").Visible = Chart.Series("Series_FrontLeftRPM").Enabled Or
    '            Chart.Series("Series_FrontRightRPM").Enabled Or Chart.Series("Series_RPM").Enabled
    '    End If
    'End Sub

#End Region

#Region "Telemetry"

    ' Create random telemetry values to try the plots
    Private Sub Timer_RandomTelemetry_Tick(sender As Object, e As EventArgs) Handles Timer_RandomTelemetry.Tick

    End Sub

    Private Sub PlotTelemetry(ByVal Optional Time As Date = Nothing)
        If Not CheckBox_Plotting.Checked Then
            Exit Sub
        End If
        If Time = Nothing Then
            Time = Now
        End If
        ' Decompress telemetry values before plotting
        'Chart.Series("Series_Throttle").Points.AddXY(Time, Data.Pedals.Throttle_12)
        'Chart.Series("Series_BrakeFront").Points.AddXY(Time, Data.Pedals.Brake_Front)
        'Chart.Series("Series_BrakeRear").Points.AddXY(Time, Data.Pedals.Brake_Rear)
        'Chart.Series("Series_CoolantIn").Points.AddXY(Time, Data.Temps.Coolant_In)
        'Chart.Series("Series_CoolantOut").Points.AddXY(Time, Data.Temps.Coolant_Out)
        'Chart.Series("Series_MotorTemp").Points.AddXY(Time, Data.Temps.Motor)
        'Chart.Series("Series_IGBTTemp").Points.AddXY(Time, Data.Temps.IGBT)
        'Chart.Series("Series_GearboxTemp").Points.AddXY(Time, Data.Temps.Gearbox)
        'Chart.Series("Series_BrakeLeft").Points.AddXY(Time, (Data.Temps.BrakeLeft * 2.0F + 20))
        'Chart.Series("Series_BrakeRight").Points.AddXY(Time, (Data.Temps.BrakeRight * 2.0F + 20))
        'Chart.Series("Series_FrontLeftRPM").Points.AddXY(Time, Data.Wheels.RPM_Front_Left)
        'Chart.Series("Series_FrontRightRPM").Points.AddXY(Time, Data.Wheels.RPM_Front_Right)
        'Chart.Series("Series_RPM").Points.AddXY(Time, Data.Performance.RPM)
        ' Autoscroll
        'If CheckBox_AutoScroll.Checked Then
        '    Chart.ChartAreas("ChartArea_Pedals").AxisX.ScaleView.Scroll(Time)
        '    Chart.ChartAreas("ChartArea_Temps2").AxisX.ScaleView.Scroll(Time)
        '    Chart.ChartAreas("ChartArea_Temps").AxisX.ScaleView.Scroll(Time)
        '    Chart.ChartAreas("ChartArea_RPM").AxisX.ScaleView.Scroll(Time)
        'End If
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

    Private TelemetryLog As Logger = Nothing
    Private BMSLog As Logger = Nothing

    Private Sub StartTelemetryLogging()
        TelemetryLog = New Logger(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ".csv", "Telemetry Log")
        Dim FirstLine As String = "Timestamp,Index,Throttle,Brake Front,Brake Rear,Coolant In,Coolant Out,"
        FirstLine &= "Motor Temp,IGBT Temp,Gearbox Temp,RPM,Torque,IVT Voltage,IVT Current,FL Brake,FR Brake,FL RPM, FR RPM"
        If CheckBox_Logging_Delimiter.Checked Then
            FirstLine = FirstLine.Replace(",", ";")
        End If
        TelemetryLog.Write(FirstLine)
        Button_TelemetryLog_StartStop.Text = "Stop Telemetry Log"
        Button_TelemetryLog_StartStop.ForeColor = Color.Firebrick
    End Sub

    Private Sub StopTelemetryLogging()
        TelemetryLog.Close()
        TelemetryLog = Nothing
        Button_TelemetryLog_StartStop.Text = "Start Telemetry Log"
        Button_TelemetryLog_StartStop.ForeColor = Color.Green
    End Sub

    Private Sub StartBMSLogging()
        BMSLog = New Logger(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ".csv", "BMS Log")
        Dim FirstLine As String = "Timestamp,"
        ' Voltages
        For Index As Integer = 1 To 120
            FirstLine &= "Cell #" & Index & ","
        Next
        ' Temperatures
        FirstLine = FirstLine.Substring(0, FirstLine.Length - 1)
        BMSLog.Write(FirstLine)
        Button_BMSLog_StartStop.Text = "Stop BMS Log"
        Button_BMSLog_StartStop.ForeColor = Color.Firebrick
    End Sub

    Private Sub StopBMSLogging()
        BMSLog.Close()
        BMSLog = Nothing
        Button_BMSLog_StartStop.Text = "Start BMS Log"
        Button_BMSLog_StartStop.ForeColor = Color.Green
    End Sub

    Private Sub LogTelemetry()
        If TelemetryLog Is Nothing Then Exit Sub
        Dim Delimiter As Char = If(CheckBox_Logging_Delimiter.Checked, ";", ",")
        'With Car.Sensors
        '    Dim Index As UInt32 = ParseUInt32({0, .Timestamp.IndexMSB, .Timestamp.IndexMMSB, .Timestamp.IndexLSB}, 0)
        '    TelemetryLog.Write(String.Format("{0}{18}{1:d}{18}{2}{18}{3}{18}{4}{18}{5}{18}{6}{18}{7}{18}{8}{18}{9}{18}{10}{18}{11}{18}{12:F}{18}{13:F}{18}{14}{18}{15}{18}{16}{18}{17}",
        '                          Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), Index, .Pedals.Throttle_12, .Pedals.Brake_Front, .Pedals.Brake_Rear,
        '                          .Temps.Coolant_In, .Temps.Coolant_Out, .Temps.Motor, .Temps.IGBT, .Temps.Gearbox,
        '                          .Performance.RPM, .Performance.Torque, .Performance.IVT_Voltage, .Performance.IVT_Current,
        '                          .Temps.BrakeLeft, .Temps.BrakeRight, .Wheels.RPM_Front_Left, .Wheels.RPM_Front_Right, Delimiter))
        'End With
    End Sub

    Private Sub LogBMS()
        If BMSLog Is Nothing Then Exit Sub
        With Car.BMS

        End With
    End Sub

    Private Sub Button_TelemetryLog_StartStop_Click(sender As Object, e As EventArgs) Handles Button_TelemetryLog_StartStop.Click
        If TelemetryLog Is Nothing Then
            StartTelemetryLogging()
        Else
            StopTelemetryLogging()
        End If
    End Sub

    Private Sub Button_BMSLog_StartStop_Click(sender As Object, e As EventArgs) Handles Button_BMSLog_StartStop.Click
        If BMSLog Is Nothing Then
            StartBMSLogging()
        Else
            StopBMSLogging()
        End If
    End Sub

#End Region

#Region "BMS Plotting"

    Private Sub PlotBMS()
        Chart_BMS.Series("Series_BMS_Voltages").Points.Clear()
        For Index As Integer = 0 To 143
            Dim Value As Single = (Car.BMS.Voltages(Index) / 100.0) + 2.5
            Constrain(Value, NumericUpDown_BMS_VoltageMin.Value, NumericUpDown_BMS_VoltageMax.Value)
            Dim Mapped As Single = Map(Value, NumericUpDown_BMS_VoltageMin.Value, NumericUpDown_BMS_VoltageMax.Value, 0, 1)
            Dim Color As Color = If(Not CheckBox_BMS_Coloring.Checked, PictureBox_BMS_LowColor.BackColor, InterpolateColor(PictureBox_BMS_LowColor.BackColor, PictureBox_BMS_HighColor.BackColor, Mapped))
            Chart_BMS.Series("Series_BMS_Voltages").Points.AddXY(Index + 1, Value)
            Chart_BMS.Series("Series_BMS_Voltages").Points().Item(Index).Color = Color
        Next
    End Sub

    Private Sub Button_RandomBMS_Click(sender As Object, e As EventArgs) Handles Button_RandomBMS.Click
        For Index As Integer = 0 To 143
            Car.BMS.Voltages(Index) = RandomGenerator.Next(0, 170) '2.5 - 4.2 Volt
        Next
        PlotBMS()
    End Sub

    Private IgnoreCellRangeChanged As Integer = 0
    Private Sub NumericUpDown_BMS_CellMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_BMS_CellMin.ValueChanged
        Try
            With NumericUpDown_BMS_CellMin
                If .Value >= 1 And .Value < NumericUpDown_BMS_CellMax.Value Then
                    Chart_BMS.ChartAreas(0).AxisX.Minimum = .Value
                    If IgnoreCellRangeChanged <= 0 Then
                        ComboBox_BMS_CellRange.SelectedIndex = 15
                    Else
                        IgnoreCellRangeChanged -= 1
                    End If
                    .ForeColor = Color.Black
                Else
                    .ForeColor = Color.Firebrick
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NumericUpDown_BMS_CellMax_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_BMS_CellMax.ValueChanged
        Try
            With NumericUpDown_BMS_CellMax
                If .Value >= NumericUpDown_BMS_CellMin.Value And .Value <= 144 Then
                    Chart_BMS.ChartAreas(0).AxisX.Maximum = .Value
                    If IgnoreCellRangeChanged <= 0 Then
                        ComboBox_BMS_CellRange.SelectedIndex = 15
                    Else
                        IgnoreCellRangeChanged -= 1
                    End If
                    .ForeColor = Color.Black
                Else
                    .ForeColor = Color.Firebrick
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NumericUpDown_BMS_VoltageMax_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_BMS_VoltageMax.ValueChanged
        Try
            With NumericUpDown_BMS_VoltageMax
                If .Value <= 4.2 And .Value > NumericUpDown_BMS_VoltageMin.Value Then
                    Chart_BMS.ChartAreas(0).AxisY.Maximum = .Value
                    .ForeColor = Color.Black
                Else
                    .ForeColor = Color.Firebrick
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NumericUpDown_BMS_VoltageMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_BMS_VoltageMin.ValueChanged
        Try
            With NumericUpDown_BMS_VoltageMin
                If .Value >= 2.8 And .Value < NumericUpDown_BMS_VoltageMax.Value Then
                    Chart_BMS.ChartAreas(0).AxisY.Minimum = .Value
                    .ForeColor = Color.Black
                Else
                    .ForeColor = Color.Firebrick
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox_BMS_CellRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_BMS_CellRange.SelectedIndexChanged
        With ComboBox_BMS_CellRange
            If .SelectedIndex >= 0 And .SelectedIndex < 12 Then
                ' BMS Select
                IgnoreCellRangeChanged += 4
                NumericUpDown_BMS_CellMin.Value = 1
                NumericUpDown_BMS_CellMax.Value = 144
                Dim Min As Integer = .SelectedIndex * 12 + 1
                Dim Max As Integer = Min + 11
                NumericUpDown_BMS_CellMin.Value = Min
                NumericUpDown_BMS_CellMax.Value = Max
            ElseIf .SelectedIndex = 12 Then
                ' All
                IgnoreCellRangeChanged += 4
                NumericUpDown_BMS_CellMin.Value = 1
                NumericUpDown_BMS_CellMax.Value = 144
                NumericUpDown_BMS_CellMin.Value = 1
                NumericUpDown_BMS_CellMax.Value = 144
            Else
                ' Custom
            End If
        End With
    End Sub

    Private Sub CheckBox_BMS_Plot_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_BMS_PlotVoltages.CheckedChanged, CheckBox_BMS_PlotTemperatures.CheckedChanged
        If Chart_BMS.Series.Count > 0 Then
            Chart_BMS.Series("Series_BMS_Voltages").Enabled = CheckBox_BMS_PlotVoltages.Checked
            'Chart_BMS.Series("Series_BMS_Temperatures").Enabled = CheckBox_BMS_PlotTemperatures.Checked
        End If
    End Sub

    Private Sub PictureBox_BMS_HighColor_Click(sender As Object, e As EventArgs) Handles PictureBox_BMS_HighColor.Click
        ColorDialog_BMS.Color = PictureBox_BMS_HighColor.BackColor
        ColorDialog_BMS.ShowDialog()
        PictureBox_BMS_HighColor.BackColor = ColorDialog_BMS.Color
    End Sub

    Private Sub PictureBox_BMS_LowColor_Click(sender As Object, e As EventArgs) Handles PictureBox_BMS_LowColor.Click
        ColorDialog_BMS.Color = PictureBox_BMS_LowColor.BackColor
        ColorDialog_BMS.ShowDialog()
        PictureBox_BMS_LowColor.BackColor = ColorDialog_BMS.Color
    End Sub

#End Region

#Region "CAN"
#Region "CAN GUI"
    Private CANRepresentation As NumberRepresentation = NumberRepresentation.Dec

    Private Sub RadioButton_CAN_Binary_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_CAN_Binary.CheckedChanged
        If RadioButton_CAN_Binary.Checked Then
            For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
                ' 00000000-11111111
                If Control.GetType() Is GetType(TextBox) Then
                    Dim Textbox As TextBox = CType(Control, TextBox)
                    If Textbox.Name.StartsWith("TextBox_CAN_Byte") Then Textbox.MaxLength = 8
                End If
            Next
            ConvertRepresentation(NumberRepresentation.Bin)
        End If
    End Sub

    Private Sub RadioButton_CAN_Decimal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_CAN_Decimal.CheckedChanged
        If RadioButton_CAN_Decimal.Checked Then
            For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
                ' 0-255
                If Control.GetType() Is GetType(TextBox) Then
                    Dim Textbox As TextBox = CType(Control, TextBox)
                    If Textbox.Name.StartsWith("TextBox_CAN_Byte") Then Textbox.MaxLength = 3
                End If
                ConvertRepresentation(NumberRepresentation.Dec)
            Next
        End If
    End Sub

    Private Sub RadioButton_CAN_Hex_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_CAN_Hex.CheckedChanged
        If RadioButton_CAN_Hex.Checked Then
            For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
                ' 00-FF 
                If Control.GetType() Is GetType(TextBox) Then
                    Dim Textbox As TextBox = CType(Control, TextBox)
                    If Textbox.Name.StartsWith("TextBox_CAN_Byte") Then Textbox.MaxLength = 2
                End If
                ConvertRepresentation(NumberRepresentation.Hex)
            Next
        End If
    End Sub

    ' Format the content of the textboxes live
    Private Sub TextBox_CAN_Byte_TextChanged(sender As TextBox, e As EventArgs) Handles TextBox_CAN_Byte0.TextChanged, TextBox_CAN_Byte1.TextChanged,
            TextBox_CAN_Byte2.TextChanged, TextBox_CAN_Byte3.TextChanged, TextBox_CAN_Byte4.TextChanged,
            TextBox_CAN_Byte5.TextChanged, TextBox_CAN_Byte6.TextChanged, TextBox_CAN_Byte7.TextChanged

        If ConvertingRepresentation Then Exit Sub

        ' Only allow allowed characters
        Dim Allowed As String = Nothing
        Select Case CANRepresentation
            Case NumberRepresentation.Bin
                Allowed = "01-"
            Case NumberRepresentation.Dec
                Allowed = "0123456789-"
            Case NumberRepresentation.Hex
                Allowed = "0123456789ABCDEFabcdef-"
        End Select
        For Each c As Char In sender.Text
            If Not Allowed.Contains(c) Then
                sender.Text = sender.Text.Replace(c, "")
            End If
        Next
        ' 3 digits decimals can represent up to 999 while we need 0-255
        If sender.Text.Length > 0 And Not sender.Text.Contains("-") Then
            Dim Number As Integer = 0
            Select Case CANRepresentation
                Case NumberRepresentation.Bin
                    Number = BinToDec(sender.Text)
                Case NumberRepresentation.Dec
                    Number = CByte(sender.Text)
                Case NumberRepresentation.Hex
                    Number = HexToDec(sender.Text)
            End Select
            If Number > 255 Then
                ' If bigger than 255 remove the last digit
                sender.Text = sender.Text.Substring(0, sender.Text.Length - 1)
            End If
        Else
            If sender.Text.Length > 0 Then
                sender.Text = "-"
            End If
        End If
        ' Set all previous empty textboxes to 0
        For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
            If Control.GetType() Is GetType(TextBox) Then
                Dim Textbox As TextBox = CType(Control, TextBox)
                If Textbox.Name.StartsWith("TextBox_CAN_Byte") Then
                    If CByte(Textbox.Name.Replace("TextBox_CAN_Byte", "")) < CByte(sender.Name.Replace("TextBox_CAN_Byte", "")) Then
                        If Not sender.Text.Contains("-") And Textbox.Text.Contains("-") Then
                            Textbox.Text = "0"
                        End If
                    End If

                End If
            End If
        Next
        ' Set the cursor at the end of the text
        sender.SelectionStart = sender.Text.Length
    End Sub

    Private Sub TextBox_CAN_Byte_Enter(sender As Object, e As EventArgs) Handles TextBox_CAN_Byte0.Enter, TextBox_CAN_Byte1.Enter,
            TextBox_CAN_Byte2.Enter, TextBox_CAN_Byte3.Enter, TextBox_CAN_Byte4.Enter,
            TextBox_CAN_Byte5.Enter, TextBox_CAN_Byte6.Enter, TextBox_CAN_Byte7.Enter
        If sender.Text.Contains("-") Then
            sender.Text = ""
        End If
    End Sub

    Private Sub Button_CAN_Clear_Click(sender As Object, e As EventArgs) Handles Button_CAN_Clear.Click
        For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
            If Control.GetType() Is GetType(TextBox) Then
                Dim Textbox As TextBox = CType(Control, TextBox)
                If Textbox.Name.StartsWith("TextBox_CAN_Byte") Then Textbox.Text = "-"
            End If
            ConvertRepresentation(NumberRepresentation.Dec)
        Next
    End Sub

    Private ConvertingRepresentation As Boolean = False

    Private Sub ConvertRepresentation(ByVal NewRepresentation As NumberRepresentation)
        If CANRepresentation <> NewRepresentation Then
            ConvertingRepresentation = True
            For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
                If Control.GetType() Is GetType(TextBox) Then
                    Dim Textbox As TextBox = CType(Control, TextBox)
                    If Textbox.Name.StartsWith("TextBox_CAN_Byte") Then
                        If Textbox.Text = "" Then Textbox.Text = "-"
                        If Textbox.Text.Contains("-") Then Continue For
                        Dim Number As Byte = 0
                        Select Case CANRepresentation
                            Case NumberRepresentation.Bin
                                Number = BinToDec(Textbox.Text)
                            Case NumberRepresentation.Dec
                                Number = CByte(Textbox.Text)
                            Case NumberRepresentation.Hex
                                Number = HexToDec(Textbox.Text)
                        End Select
                        Select Case NewRepresentation
                            Case NumberRepresentation.Bin
                                Textbox.Text = DecToBin(Number)
                            Case NumberRepresentation.Dec
                                Textbox.Text = Number
                            Case NumberRepresentation.Hex
                                Textbox.Text = DecToHex(Number)
                        End Select
                    End If
                End If
            Next
            CANRepresentation = NewRepresentation
            ConvertingRepresentation = False
        End If
    End Sub
#End Region

#Region "CAN Send"
    Private Sub Button_CAN_Send_Click(sender As Object, e As EventArgs) Handles Button_CAN_Send.Click
        ' Format message ID
        If TextBox_CAN_MessageID.TextLength = 0 Then
            MsgBox("Please fill the message ID field.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim Allowed As String = "0123456789ABCDEFabcdef"
        For Each c As Char In TextBox_CAN_MessageID.Text
            If Not Allowed.Contains(c) Then
                MsgBox("Illegal character '" & c & "' found in message ID. Please fix the format.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Next
        ' Create message
        Dim Message As New CAN_Message(8)
        Message.ID = CInt("&H" & TextBox_CAN_MessageID.Text)
        ' Iterate textboxes in order
        For TextboxIndex As Byte = 0 To 7
            For Each Control As Control In TabControl.TabPages("TabPage_CAN").Controls
                If Control.GetType() Is GetType(TextBox) Then
                    Dim Textbox As TextBox = CType(Control, TextBox)
                    If Textbox.Name.StartsWith("TextBox_CAN_Byte" & TextboxIndex.ToString) Then
                        If Not Textbox.Text.Contains("-") And Textbox.TextLength > 0 Then
                            ' Add byte depending on representation
                            Select Case CANRepresentation
                                Case NumberRepresentation.Bin
                                    Message.Data(Message.Length) = BinToDec(Textbox.Text)
                                Case NumberRepresentation.Dec
                                    Message.Data(Message.Length) = CByte(Textbox.Text)
                                Case NumberRepresentation.Hex
                                    Message.Data(Message.Length) = HexToDec(Textbox.Text)
                            End Select
                            Message.Length += 1
                        End If
                    End If
                End If
            Next
        Next
        ' Perform last checks
        If Message.Length = 0 Then
            MsgBox("You are not allowed to send empty CAN messages. Please fill the data fields. ", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        ' Warn user
        If CheckBox_CAN_Warn.Checked Then
            Dim Result As DialogResult = MessageBox.Show("You are about to send a CAN message to the car. This is extremely dangerous and incorrect use may bring unexpected results. Are you sure you want to transmit the message?", "Warning", MessageBoxButtons.YesNo)
            If Result = DialogResult.No Then
                MsgBox("Transmission cancelled", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
        End If
        SendCAN(Message)
    End Sub

    ' Packetize CAN message and transmit
    Private Sub SendCAN(ByVal Message As CAN_Message)
        Dim BytesCount As Byte = Message.Length + 3
        Dim TX(BytesCount) As Byte
        TX(0) = ID_SEND_CAN
        TX(1) = CByte((Message.ID And &HFF00&) / 256)
        TX(2) = CByte(Message.ID And &HFF&)
        TX(3) = Message.Length
        For Index As Integer = 0 To Message.Length - 1
            TX(Index + 4) = Message.Data(Index)
        Next
        Send(TX)
    End Sub
#End Region
#End Region

    Private Sub Button_Break_Click(sender As Object, e As EventArgs) Handles Button_Break.Click
        Dim X As Byte = 0
    End Sub

    Private Sub Button_CAN_BuzzerStart_Click(sender As Object, e As EventArgs) Handles Button_CAN_BuzzerStart.Click
        Dim Message As New CAN_Message(8)
        Message.ID = &H760
        Message.Data = {0, 0, 0, 1, 0, 0, 0, 0}
        Message.Length = 8
        If CheckBox_CAN_Warn.Checked Then
            Dim Result As DialogResult = MessageBox.Show("You are about to send a CAN message to the car. This is extremely dangerous and incorrect use may bring unexpected results. Are you sure you want to transmit the message?", "Warning", MessageBoxButtons.YesNo)
            If Result = DialogResult.No Then
                MsgBox("Transmission cancelled", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
        End If
        SendCAN(Message)
    End Sub

    Private Sub Button_CAN_BuzzerStop_Click(sender As Object, e As EventArgs) Handles Button_CAN_BuzzerStop.Click
        Dim Message As New CAN_Message(8)
        Message.ID = &H760
        Message.Data = {0, 0, 0, 0, 0, 0, 0, 0}
        Message.Length = 8
        If CheckBox_CAN_Warn.Checked Then
            Dim Result As DialogResult = MessageBox.Show("You are about to send a CAN message to the car. This is extremely dangerous and incorrect use may bring unexpected results. Are you sure you want to transmit the message?", "Warning", MessageBoxButtons.YesNo)
            If Result = DialogResult.No Then
                MsgBox("Transmission cancelled", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
        End If
        SendCAN(Message)
    End Sub

    Private Sub Button_CAN_BrakeStart_Click(sender As Object, e As EventArgs) Handles Button_CAN_BrakeStart.Click
        Dim Message As New CAN_Message(8)
        Message.ID = &H760
        Message.Data = {0, 0, 1, 0, 0, 0, 0, 0}
        Message.Length = 8
        If CheckBox_CAN_Warn.Checked Then
            Dim Result As DialogResult = MessageBox.Show("You are about to send a CAN message to the car. This is extremely dangerous and incorrect use may bring unexpected results. Are you sure you want to transmit the message?", "Warning", MessageBoxButtons.YesNo)
            If Result = DialogResult.No Then
                MsgBox("Transmission cancelled", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
        End If
        SendCAN(Message)
    End Sub

    Private Sub Button_BrakeStop_Click(sender As Object, e As EventArgs) Handles Button_BrakeStop.Click
        Dim Message As New CAN_Message(8)
        Message.ID = &H760
        Message.Data = {0, 0, 0, 0, 0, 0, 0, 0}
        Message.Length = 8
        If CheckBox_CAN_Warn.Checked Then
            Dim Result As DialogResult = MessageBox.Show("You are about to send a CAN message to the car. This is extremely dangerous and incorrect use may bring unexpected results. Are you sure you want to transmit the message?", "Warning", MessageBoxButtons.YesNo)
            If Result = DialogResult.No Then
                MsgBox("Transmission cancelled", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
        End If
        SendCAN(Message)
    End Sub

    Private Sub Button_Admin_Process_Click(sender As Object, e As EventArgs) Handles Button_Admin_Process.Click
        Dim RXStr As String() = TextBox_Admin_RX.Text.Split(" ")
        RX.Clear()
        For Each Str As String In RXStr
            RX.Add(HexToDec(Str))
            ProcessRX()
        Next
    End Sub

    Private Sub Button_Config_Fusebox_Send_Click(sender As Object, e As EventArgs) Handles Button_Config_Fusebox_Send.Click
        Dim Conf(7) As Byte
        Conf(0) = ID_SET_FUSEBOX_CONFIG
        Conf(1) = If(CheckBox_Config_Fusebox_TelemetryEnabled.Checked, 1, 0)
        Conf(2) = If(CheckBox_Config_Fusebox_CANForward.Checked, 1, 0)
        Conf(3) = NumericUpDown_Config_Fusebox_CANInterval.Value
        Conf(4) = CByte(TextBox_Config_Fusebox_SelectiveSampling.Text)
        Conf(5) = NumericUpDown_Config_Fusebox_TelemetryTX.Value
        Conf(6) = NumericUpDown_Config_Fusebox_Telemetry2TX.Value
        Send(Conf)
    End Sub

    Private Sub Button_Config_Fusebox_Request_Click(sender As Object, e As EventArgs) Handles Button_Config_Fusebox_Request.Click
        Send({ID_GET_FUSEBOX_CONFIG})
    End Sub

#Region "Log Transfer"

    Const LOG_ID_REQUEST_FILE_NAMES As Byte = 0
    Const LOG_ID_SEND_FILE_NAME As Byte = 1
    Const LOG_ID_INITIATE_FILE_TRANSFER_REQUEST As Byte = 2
    Const LOG_ID_ACCEPT_FILE_TRANSFER_REQUEST As Byte = 3
    Const LOG_ID_DECLINE_FILE_TRANSFER_REQUEST As Byte = 4
    Const LOG_ID_REQUEST_FILE_PACKET As Byte = 5
    Const LOG_ID_FILE_PACKET As Byte = 6
    Const LOG_ID_DECLINE_FILE_PACKET As Byte = 7
    Const LOG_ID_CANCEL_FILE_TRANSFER_REQUEST As Byte = 8
    Const LOG_ID_CANCELLED_FILE_TRANSFER As Byte = 9

    Dim WaitingFileNames As Boolean = False
    Const WaitingFilenamesTimeout As Integer = 200
    Dim WaitingFilenamesTimeoutCounter As Integer = 0
    Dim Filenames As New List(Of String)

    Dim TransferActive As Boolean = False
    Const TransferTimeout As Integer = 500
    Const TransferRetries As Byte = 10
    Dim TransferTimeoutCounter As Integer = 0
    Const TransferMaxPacket As Integer = 250
    Dim TransferFile As String = ""
    Dim TransferBytes(1) As Byte
    Dim TransferPointer As Integer = 0
    Dim TransferTotalPackets As Integer = 0
    Dim TransferTries As Byte = 0

    Private TransferMutex As New Threading.Mutex()

    Private LogTransferTimer As New Timer
    Private LogTransferTimerDelegate As New EventHandler(AddressOf LogTransfer)

    Private Sub LogTransfer_AddFilename(ByVal Filename As String)
        Filenames.Add(Filename)
        ' Reset timeout counter
        WaitingFilenamesTimeoutCounter = 0
    End Sub

    Private Sub LogTransfer_RequestFilenames()
        Send({ID_LOG_TRANSFER, LOG_ID_REQUEST_FILE_NAMES})
        WaitingFileNames = True
    End Sub

    Private Function UnicodeBytesToString(ByVal bytes() As Byte) As String
        Return System.Text.Encoding.UTF8.GetString(bytes)
    End Function

    Private Sub LogTransfer_HandleRX()
        TransferMutex.WaitOne()
        Const StartIndex As Byte = 2
        Dim Length As Byte = RXData.Length - 2
        Console.WriteLine(RXData(StartIndex - 1))
        Select Case RXData(StartIndex - 1)
            Case LOG_ID_REQUEST_FILE_NAMES
                ' This shouldn't happen
            Case LOG_ID_SEND_FILE_NAME
                Dim Str As String = ""
                For Index As Integer = 2 To RXData.Length - 1
                    Str &= Chr(RXData(Index))
                Next
                LogTransfer_AddFilename(Str)
                Console.WriteLine("|" & Str & "|")
            Case LOG_ID_INITIATE_FILE_TRANSFER_REQUEST
                ' This shouldn't happen
            Case LOG_ID_ACCEPT_FILE_TRANSFER_REQUEST
                ' Accept File Transfer Request
                'Console.WriteLine(ParseUInt32(RXData, 2))
                Dim Filesize As Integer = ParseUInt32(RXData, 2)
                TransferActive = True
                TransferTimeoutCounter = 0
                TransferPointer = 0
                ReDim TransferBytes(Filesize)
                TransferTotalPackets = Filesize \ TransferMaxPacket + If(Filesize Mod TransferMaxPacket > 0, 1, 0)
                RemoveHandler LogTransferTimer.Tick, LogTransferTimerDelegate
                AddHandler LogTransferTimer.Tick, LogTransferTimerDelegate
                LogTransferTimer.Interval = 10
                LogTransferTimer.Start()
                Console.WriteLine("Accepted")
            Case LOG_ID_DECLINE_FILE_TRANSFER_REQUEST
                ' Decline File Transfer Request
                Console.WriteLine("Declined")
            Case LOG_ID_REQUEST_FILE_PACKET
                ' This shouldnt' happen
            Case LOG_ID_FILE_PACKET
                ' File Packet
                Dim PacketNo As UInt16 = ParseUInt16(RXData, 2)
                Dim ReceivedBytes As Integer = RXData.Length - 4
                For Index As Integer = 0 To ReceivedBytes - 1
                    TransferBytes(PacketNo * TransferMaxPacket + Index) = RXData(Index + 4)
                Next
                Console.WriteLine("Got packet " & (PacketNo + 1) & "/" & TransferTotalPackets & " with " & ReceivedBytes & " bytes")
                TransferTimeoutCounter = 0
                TransferTries = 0

                TransferPointer += ReceivedBytes
                If TransferPointer >= TransferTotalPackets * TransferMaxPacket Then
                    ' Save file
                    Console.WriteLine("Received")
                    IO.File.WriteAllBytes(TransferFile, TransferBytes)
                    LogTransfer_AbortTransfer()
                Else
                    LogTransfer_RequestNextPacket()
                End If
            Case LOG_ID_DECLINE_FILE_PACKET
                'Console.WriteLine("Timeout")
            Case LOG_ID_CANCEL_FILE_TRANSFER_REQUEST
                ' This shouldn't happen in normal cases
            Case LOG_ID_CANCELLED_FILE_TRANSFER
                ' Cancelled transfer
                Console.WriteLine("Cancelled")
        End Select
        TransferMutex.ReleaseMutex()
    End Sub

    Private Sub LogTransfer_RequestNextPacket()
        TransferTimeoutCounter = 0
        TransferTries = 0
        Dim PacketNo As Integer = TransferPointer \ TransferMaxPacket
        Dim PacketNoBytes As Byte() = BitConverter.GetBytes(PacketNo)
        Send({ID_LOG_TRANSFER, LOG_ID_REQUEST_FILE_PACKET, PacketNoBytes(1), PacketNoBytes(0)})
    End Sub

    Private Sub LogTransfer_AbortTransfer()
        TransferActive = False
        Send({ID_LOG_TRANSFER, LOG_ID_CANCEL_FILE_TRANSFER_REQUEST})
    End Sub

    Private Sub LogTransfer()
        TransferMutex.WaitOne()
        If WaitingFileNames Then

            If WaitingFilenamesTimeoutCounter > WaitingFilenamesTimeout Then
                ' Timeout
                WaitingFileNames = False
                WaitingFilenamesTimeoutCounter = 0
                ' Remove the timer handlers
                LogTransferTimer.Stop()
                RemoveHandler LogTransferTimer.Tick, LogTransferTimerDelegate
                ' Display the filenames
                ListBox_Logging_Logs.Items.Clear()
                If Filenames.Count > 0 Then
                    For Each Filename As String In Filenames
                        ListBox_Logging_Logs.Items.Add(Filename)
                    Next
                Else
                    ListBox_Logging_Logs.Items.Add("No filenames found")
                End If
            Else
                WaitingFilenamesTimeoutCounter += 10
            End If

        ElseIf TransferActive Then

            If TransferTimeoutCounter > TransferTimeout Then

                If TransferTries < TransferRetries Then

                    ' Request packet again
                    LogTransfer_RequestNextPacket()
                    TransferTries += 1
                    TransferTimeoutCounter = 0

                Else
                    ' No more retries
                    ' Abort
                    LogTransfer_AbortTransfer()
                    LogTransferTimer.Stop()
                    RemoveHandler LogTransferTimer.Tick, LogTransferTimerDelegate
                End If

            Else
                TransferTimeoutCounter += 10
            End If

        End If
        TransferMutex.ReleaseMutex()
    End Sub


    Private Sub Button_Logging_Download_Click(sender As Object, e As EventArgs) Handles Button_Logging_Download.Click
        ' Open save file dialog
        Dim Filename As String = ListBox_Logging_Logs.SelectedItem
        If Filename <> "" Then
            Dim SaveDialog As New SaveFileDialog
            SaveDialog.OverwritePrompt = True
            SaveDialog.FileName = Filename
            SaveDialog.ShowDialog()
            TransferFile = SaveDialog.FileName
            Dim Buf(Filename.Length + 2) As Byte
            Buf(0) = ID_LOG_TRANSFER
            Buf(1) = LOG_ID_INITIATE_FILE_TRANSFER_REQUEST
            Dim FilenameBuf As Byte() = System.Text.Encoding.ASCII.GetBytes(Filename)
            For Index As Integer = 0 To FilenameBuf.Count - 1
                Buf(Index + 2) = FilenameBuf(Index)
            Next
            Send(Buf)
        End If
    End Sub

    Private Sub Button_Logging_Reload_Click(sender As Object, e As EventArgs) Handles Button_Logging_Reload.Click
        RemoveHandler LogTransferTimer.Tick, LogTransferTimerDelegate
        AddHandler LogTransferTimer.Tick, LogTransferTimerDelegate
        LogTransferTimer.Interval = 10
        Filenames.Clear()
        ListBox_Logging_Logs.Items.Clear()
        LogTransfer_RequestFilenames()
        LogTransferTimer.Start()
    End Sub

#End Region

#Region "Sockets"

    Private WithEvents Server As New ServerClass(ServerPort, True)
    Private Client As New ClientClass
    Private ClientsList As New List(Of String)
    Private Const ServerPort = 567
    Private Const SendPort = 567

    Private Sub OnIncomingMessage(Args As ServerClass.InMessEvArgs) Handles Server.IncomingMessage
        Try
            RXData = Args.message
            ReceiveSuccess()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Sockets_Connect_Click(sender As Object, e As EventArgs) Handles Button_Sockets_Connect.Click
        ClientsList.Add(TextBox_Sockets_ClientIP.Text)
        ListBox_Sockets_Clients.Items.Add(TextBox_Sockets_ClientIP.Text)
    End Sub

    Private Sub Button_Sockets_Clear_Click(sender As Object, e As EventArgs) Handles Button_Sockets_Clear.Click
        ClientsList.Clear()
        ListBox_Sockets_Clients.Items.Clear()
    End Sub

#End Region

    Private Function BytesToString(ByVal Input As Byte()) As String
        Dim Result As New System.Text.StringBuilder(Input.Length * 2)
        Dim Part As String
        For Each b As Byte In Input
            Part = Conversion.Hex(b)
            If Part.Length = 1 Then Part = "0" & Part
            Result.Append(Part)
        Next
        Return Result.ToString()
    End Function

    Private Function StringToBytes(ByVal Input As String) As Byte()
        Dim Result(Input.Length / 2) As Byte
        For Index As Integer = 0 To Input.Length - 1 Step 2
            Result(Index / 2) = Convert.ToByte(Input.Chars(Index) & Input.Chars(Index + 1))
        Next
        Return Result
    End Function

    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)
        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next
    End Function

    Private Sub GroupBox_BMS_Settings_Enter(sender As Object, e As EventArgs) Handles GroupBox_BMS_Settings.Enter

    End Sub

    Private Sub CheckSeries(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox_ChartSeries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox_ChartSeries.SelectedIndexChanged
        For Index As Integer = 0 To CheckedListBox_ChartSeries.Items.Count - 1
            Chart.Series(CheckedListBox_ChartSeries.Items(Index)).Enabled = CheckedListBox_ChartSeries.GetItemChecked(Index)
        Next
    End Sub

    Private Sub CheckBox_Telemetry_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Telemetry.CheckedChanged
        If CheckBox_Telemetry.Checked Then
            Timer_Telemetry.Start()
        Else
            Timer_Telemetry.Stop()
        End If
    End Sub

    Private Sub CheckBox_TelemetryBMS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_TelemetryBMS.CheckedChanged
        If CheckBox_TelemetryBMS.Checked Then
            Timer_TelemetryBMS.Start()
        Else
            Timer_TelemetryBMS.Stop()
        End If
    End Sub

    Private Sub Timer_Telemetry_Tick(sender As Object, e As EventArgs) Handles Timer_Telemetry.Tick
        Send({ID_SEND_TELEMETRY})
    End Sub

    Private Sub Timer_TelemetryBMS_Tick(sender As Object, e As EventArgs) Handles Timer_TelemetryBMS.Tick
        Send({ID_SEND_BMS})
    End Sub

    Private Sub Timer_TelemetryCAN_Tick(sender As Object, e As EventArgs) Handles Timer_TelemetryCAN.Tick
        Send({ID_SEND_CAN_ANALYTICS})
    End Sub

    Private Sub CheckBox_TelemetryCAN_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_TelemetryCAN.CheckedChanged
        If CheckBox_TelemetryCAN.Checked Then
            Timer_TelemetryCAN.Start()
        Else
            Timer_TelemetryCAN.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Send({ID_SEND_TELEMETRY})
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox_Sockets_Forward.Checked Then
            For Each IP In ClientsList
                Try
                    Client.SendMessage(IP, SendPort, "Hello World")
                Catch ex As Exception
                End Try
            Next
        End If

        'Client.SendMessage("192.168.1.3", SendPort, "Hello World")
    End Sub
End Class
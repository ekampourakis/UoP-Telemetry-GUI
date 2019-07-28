<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"BMS", "0 V", "0 V", "0 C", "0 C"}, -1)
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_SerialStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_SerialInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TelemetryLogging = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_BMSLogging = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Spring = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Updates = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_Serial = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_SendQueue = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Status = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_GUIUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.Label_Actual_FrontRight = New System.Windows.Forms.Label()
        Me.Label_Demanded_FrontRight = New System.Windows.Forms.Label()
        Me.Label_Actual_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_Demanded_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_Actual_RearRight = New System.Windows.Forms.Label()
        Me.Label_Demanded_RearRight = New System.Windows.Forms.Label()
        Me.Label_Actual_RearLeft = New System.Windows.Forms.Label()
        Me.Label_Demanded_RearLeft = New System.Windows.Forms.Label()
        Me.Label_SteeringAngle = New System.Windows.Forms.Label()
        Me.Label_SuspensionStrain_RearRight = New System.Windows.Forms.Label()
        Me.Label_SuspensionTravel_RearRight = New System.Windows.Forms.Label()
        Me.Label_SuspensionStrain_RearLeft = New System.Windows.Forms.Label()
        Me.Label_SuspensionTravel_RearLeft = New System.Windows.Forms.Label()
        Me.Label_SuspensionStrain_FrontRight = New System.Windows.Forms.Label()
        Me.Label_SuspensionTravel_FrontRight = New System.Windows.Forms.Label()
        Me.Label_SuspensionStrain_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_SuspensionTravel_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_PlateTemp = New System.Windows.Forms.Label()
        Me.Label_CoolantTemp_InverterOut = New System.Windows.Forms.Label()
        Me.Label_CoolantTemp_InverterIn = New System.Windows.Forms.Label()
        Me.Label_CoolantTemp_MotorOut = New System.Windows.Forms.Label()
        Me.Label_CoolantTemp_MotorIn = New System.Windows.Forms.Label()
        Me.Label_Gearbox_RearRight = New System.Windows.Forms.Label()
        Me.Label_Gearbox_FrontRight = New System.Windows.Forms.Label()
        Me.Label_Gearbox_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_Gearbox_RearLeft = New System.Windows.Forms.Label()
        Me.Label_IGBT_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_IGBT_FrontRight = New System.Windows.Forms.Label()
        Me.Label_IGBT_RearRight = New System.Windows.Forms.Label()
        Me.Label_IGBT_RearLeft = New System.Windows.Forms.Label()
        Me.Label_BrakeTravel = New System.Windows.Forms.Label()
        Me.ProgressBar_BrakeTravel = New System.Windows.Forms.ProgressBar()
        Me.Label_MotorTemp_RearLeft = New System.Windows.Forms.Label()
        Me.Label_MotorTemp_RearRight = New System.Windows.Forms.Label()
        Me.Label_MotorTemp_FrontRight = New System.Windows.Forms.Label()
        Me.Label_MotorTemp_FrontLeft = New System.Windows.Forms.Label()
        Me.ListView_BMS = New System.Windows.Forms.ListView()
        Me.ColumnHeader_BMSPack = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Voltage_Min = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Voltage_Max = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Temp_Min = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Temp_Max = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView_VCU = New System.Windows.Forms.ListView()
        Me.ColumnHeader_VCUFlag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_VCUValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label_Power = New System.Windows.Forms.Label()
        Me.Label_Current = New System.Windows.Forms.Label()
        Me.Label_Voltage = New System.Windows.Forms.Label()
        Me.Label_Throttle = New System.Windows.Forms.Label()
        Me.ProgressBar_Throttle = New System.Windows.Forms.ProgressBar()
        Me.Label_BrakeFront = New System.Windows.Forms.Label()
        Me.ProgressBar_BrakeFront = New System.Windows.Forms.ProgressBar()
        Me.Label_BrakeRear = New System.Windows.Forms.Label()
        Me.ProgressBar_BrakeRear = New System.Windows.Forms.ProgressBar()
        Me.Label_RPM_FrontRight = New System.Windows.Forms.Label()
        Me.Label_RPM_RearRight = New System.Windows.Forms.Label()
        Me.Label_RPM_FrontLeft = New System.Windows.Forms.Label()
        Me.Label_RPM_RearLeft = New System.Windows.Forms.Label()
        Me.PictureBox_Car = New System.Windows.Forms.PictureBox()
        Me.TabPage_Plotting = New System.Windows.Forms.TabPage()
        Me.CheckBox_Plotting_Sync = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoScale = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoScroll = New System.Windows.Forms.CheckBox()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage_BMS = New System.Windows.Forms.TabPage()
        Me.GroupBox_BMS_Settings = New System.Windows.Forms.GroupBox()
        Me.CheckBox_BMS_PlotVoltages = New System.Windows.Forms.CheckBox()
        Me.CheckBox_BMS_PlotTemperatures = New System.Windows.Forms.CheckBox()
        Me.CheckBox_BMS_Coloring = New System.Windows.Forms.CheckBox()
        Me.Label_BMS_CellRange = New System.Windows.Forms.Label()
        Me.PictureBox_BMS_HighColor = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown_BMS_CellMin = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox_BMS_LowColor = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown_BMS_CellMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_BMS_VoltageMax = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox_BMS_CellRange = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_BMS_VoltageMin = New System.Windows.Forms.NumericUpDown()
        Me.Label_BMS_VoltageRange = New System.Windows.Forms.Label()
        Me.Chart_BMS = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage_CAN = New System.Windows.Forms.TabPage()
        Me.GroupBox_CAN_Outcoming = New System.Windows.Forms.GroupBox()
        Me.Label_CAN_MessageID = New System.Windows.Forms.Label()
        Me.RadioButton_CAN_Binary = New System.Windows.Forms.RadioButton()
        Me.Button_BrakeStop = New System.Windows.Forms.Button()
        Me.RadioButton_CAN_Decimal = New System.Windows.Forms.RadioButton()
        Me.Button_CAN_BuzzerStop = New System.Windows.Forms.Button()
        Me.RadioButton_CAN_Hex = New System.Windows.Forms.RadioButton()
        Me.Button_CAN_BrakeStart = New System.Windows.Forms.Button()
        Me.TextBox_CAN_MessageID = New System.Windows.Forms.TextBox()
        Me.Button_CAN_BuzzerStart = New System.Windows.Forms.Button()
        Me.TextBox_CAN_Byte0 = New System.Windows.Forms.TextBox()
        Me.CheckBox_CAN_Warn = New System.Windows.Forms.CheckBox()
        Me.TextBox_CAN_Byte1 = New System.Windows.Forms.TextBox()
        Me.Button_CAN_Send = New System.Windows.Forms.Button()
        Me.TextBox_CAN_Byte2 = New System.Windows.Forms.TextBox()
        Me.Button_CAN_Clear = New System.Windows.Forms.Button()
        Me.TextBox_CAN_Byte3 = New System.Windows.Forms.TextBox()
        Me.Label_CAN_Byte7 = New System.Windows.Forms.Label()
        Me.TextBox_CAN_Byte4 = New System.Windows.Forms.TextBox()
        Me.Label_CAN_Byte6 = New System.Windows.Forms.Label()
        Me.TextBox_CAN_Byte5 = New System.Windows.Forms.TextBox()
        Me.Label_CAN_Byte2 = New System.Windows.Forms.Label()
        Me.TextBox_CAN_Byte6 = New System.Windows.Forms.TextBox()
        Me.Label_CAN_Byte5 = New System.Windows.Forms.Label()
        Me.TextBox_CAN_Byte7 = New System.Windows.Forms.TextBox()
        Me.Label_CAN_Byte4 = New System.Windows.Forms.Label()
        Me.Label_CAN_Byte0 = New System.Windows.Forms.Label()
        Me.Label_CAN_Byte3 = New System.Windows.Forms.Label()
        Me.Label_CAN_Byte1 = New System.Windows.Forms.Label()
        Me.ProgressBar_CAN_Load = New System.Windows.Forms.ProgressBar()
        Me.Label_CAN_Incoming = New System.Windows.Forms.Label()
        Me.ListView_CAN = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage_Configuration = New System.Windows.Forms.TabPage()
        Me.GroupBox_Config_BMS = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Config_FrontNode = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Config_BackNode = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Config_ECU = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Config_Fusebox = New System.Windows.Forms.GroupBox()
        Me.Button_Config_Fusebox_Request = New System.Windows.Forms.Button()
        Me.Button_Config_Fusebox_Send = New System.Windows.Forms.Button()
        Me.TextBox_Config_Fusebox_SelectiveSampling = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Config_Fusebox_TelemetryTX = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Config_Fusebox_CANInterval = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_Config_Fusebox_CANForward = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Config_Fusebox_TelemetryEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage_Logging = New System.Windows.Forms.TabPage()
        Me.Button_Logging_Reload = New System.Windows.Forms.Button()
        Me.Button_Logging_Delete = New System.Windows.Forms.Button()
        Me.Button_Logging_Download = New System.Windows.Forms.Button()
        Me.Label_Logging_Logs = New System.Windows.Forms.Label()
        Me.ListBox_Logging_Logs = New System.Windows.Forms.ListBox()
        Me.CheckBox_Logging_Delimiter = New System.Windows.Forms.CheckBox()
        Me.Button_BMSLog_StartStop = New System.Windows.Forms.Button()
        Me.Button_TelemetryLog_StartStop = New System.Windows.Forms.Button()
        Me.CheckBox_AutoStartLog = New System.Windows.Forms.CheckBox()
        Me.TabPage_Admin = New System.Windows.Forms.TabPage()
        Me.Button_Admin_Process = New System.Windows.Forms.Button()
        Me.TextBox_Admin_RX = New System.Windows.Forms.TextBox()
        Me.Button_Break = New System.Windows.Forms.Button()
        Me.Button_RandomBMS = New System.Windows.Forms.Button()
        Me.CheckBox_RandomTelemetry = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Plotting = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_Interval = New System.Windows.Forms.Label()
        Me.ListView_Telemetry = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label_LostPackets = New System.Windows.Forms.Label()
        Me.TabPage_Connection = New System.Windows.Forms.TabPage()
        Me.GroupBox_Sockets = New System.Windows.Forms.GroupBox()
        Me.Label_Sockets_Clients = New System.Windows.Forms.Label()
        Me.Button_Sockets_Clear = New System.Windows.Forms.Button()
        Me.Label_Sockets_Info = New System.Windows.Forms.Label()
        Me.CheckBox_Sockets_Forward = New System.Windows.Forms.CheckBox()
        Me.ListBox_Sockets_Clients = New System.Windows.Forms.ListBox()
        Me.Button_Sockets_Connect = New System.Windows.Forms.Button()
        Me.TextBox_Sockets_ClientIP = New System.Windows.Forms.TextBox()
        Me.GroupBox_Connection = New System.Windows.Forms.GroupBox()
        Me.Label_SerialPing = New System.Windows.Forms.Label()
        Me.Button_Ping = New System.Windows.Forms.Button()
        Me.Label_Serial = New System.Windows.Forms.Label()
        Me.ComboBox_Ports = New System.Windows.Forms.ComboBox()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.Timer_RandomTelemetry = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog_BMS = New System.Windows.Forms.ColorDialog()
        Me.Timer_Generic = New System.Windows.Forms.Timer(Me.components)
        Me.CheckedListBox_ChartSeries = New System.Windows.Forms.CheckedListBox()
        Me.StatusStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage_General.SuspendLayout()
        CType(Me.PictureBox_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Plotting.SuspendLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_BMS.SuspendLayout()
        Me.GroupBox_BMS_Settings.SuspendLayout()
        CType(Me.PictureBox_BMS_HighColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_BMS_CellMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_BMS_LowColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_BMS_CellMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_BMS_VoltageMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_BMS_VoltageMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_BMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_CAN.SuspendLayout()
        Me.GroupBox_CAN_Outcoming.SuspendLayout()
        Me.TabPage_Configuration.SuspendLayout()
        Me.GroupBox_Config_Fusebox.SuspendLayout()
        CType(Me.NumericUpDown_Config_Fusebox_Telemetry2TX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Config_Fusebox_TelemetryTX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Config_Fusebox_CANInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Logging.SuspendLayout()
        Me.TabPage_Admin.SuspendLayout()
        Me.TabPage_Connection.SuspendLayout()
        Me.GroupBox_Sockets.SuspendLayout()
        Me.GroupBox_Connection.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_SerialStatus, Me.ToolStripStatusLabel_SerialInfo, Me.ToolStripStatusLabel_TelemetryLogging, Me.ToolStripStatusLabel_BMSLogging, Me.ToolStripStatusLabel_Spring, Me.ToolStripStatusLabel_Updates})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1365, 22)
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel_SerialStatus
        '
        Me.ToolStripStatusLabel_SerialStatus.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel_SerialStatus.Name = "ToolStripStatusLabel_SerialStatus"
        Me.ToolStripStatusLabel_SerialStatus.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel_SerialStatus.Text = "Disconnected"
        '
        'ToolStripStatusLabel_SerialInfo
        '
        Me.ToolStripStatusLabel_SerialInfo.Name = "ToolStripStatusLabel_SerialInfo"
        Me.ToolStripStatusLabel_SerialInfo.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel_SerialInfo.Text = "0 Packets Queued"
        '
        'ToolStripStatusLabel_TelemetryLogging
        '
        Me.ToolStripStatusLabel_TelemetryLogging.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel_TelemetryLogging.Name = "ToolStripStatusLabel_TelemetryLogging"
        Me.ToolStripStatusLabel_TelemetryLogging.Size = New System.Drawing.Size(129, 17)
        Me.ToolStripStatusLabel_TelemetryLogging.Text = "Telemetry Not Logging"
        '
        'ToolStripStatusLabel_BMSLogging
        '
        Me.ToolStripStatusLabel_BMSLogging.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel_BMSLogging.Name = "ToolStripStatusLabel_BMSLogging"
        Me.ToolStripStatusLabel_BMSLogging.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel_BMSLogging.Text = "BMS Not Logging"
        '
        'ToolStripStatusLabel_Spring
        '
        Me.ToolStripStatusLabel_Spring.Name = "ToolStripStatusLabel_Spring"
        Me.ToolStripStatusLabel_Spring.Size = New System.Drawing.Size(802, 17)
        Me.ToolStripStatusLabel_Spring.Spring = True
        '
        'ToolStripStatusLabel_Updates
        '
        Me.ToolStripStatusLabel_Updates.Name = "ToolStripStatusLabel_Updates"
        Me.ToolStripStatusLabel_Updates.Size = New System.Drawing.Size(138, 17)
        Me.ToolStripStatusLabel_Updates.Text = "Made by - ekampourakis"
        '
        'SerialPort
        '
        Me.SerialPort.BaudRate = 115200
        Me.SerialPort.PortName = "COM5"
        Me.SerialPort.ReadBufferSize = 40960
        '
        'Timer_Serial
        '
        Me.Timer_Serial.Enabled = True
        Me.Timer_Serial.Interval = 10
        '
        'Timer_SendQueue
        '
        Me.Timer_SendQueue.Enabled = True
        Me.Timer_SendQueue.Interval = 10
        '
        'Timer_Status
        '
        Me.Timer_Status.Enabled = True
        Me.Timer_Status.Interval = 1500
        '
        'Timer_GUIUpdate
        '
        Me.Timer_GUIUpdate.Enabled = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage_General)
        Me.TabControl.Controls.Add(Me.TabPage_Plotting)
        Me.TabControl.Controls.Add(Me.TabPage_BMS)
        Me.TabControl.Controls.Add(Me.TabPage_CAN)
        Me.TabControl.Controls.Add(Me.TabPage_Configuration)
        Me.TabControl.Controls.Add(Me.TabPage_Logging)
        Me.TabControl.Controls.Add(Me.TabPage_Admin)
        Me.TabControl.Controls.Add(Me.TabPage_Connection)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1365, 674)
        Me.TabControl.TabIndex = 27
        '
        'TabPage_General
        '
        Me.TabPage_General.Controls.Add(Me.Label_Actual_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_Demanded_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_Actual_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_Demanded_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_Actual_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_Demanded_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_Actual_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_Demanded_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_SteeringAngle)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionStrain_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionTravel_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionStrain_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionTravel_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionStrain_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionTravel_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionStrain_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_SuspensionTravel_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_PlateTemp)
        Me.TabPage_General.Controls.Add(Me.Label_CoolantTemp_InverterOut)
        Me.TabPage_General.Controls.Add(Me.Label_CoolantTemp_InverterIn)
        Me.TabPage_General.Controls.Add(Me.Label_CoolantTemp_MotorOut)
        Me.TabPage_General.Controls.Add(Me.Label_CoolantTemp_MotorIn)
        Me.TabPage_General.Controls.Add(Me.Label_Gearbox_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_Gearbox_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_Gearbox_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_Gearbox_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_IGBT_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_IGBT_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_IGBT_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_IGBT_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_BrakeTravel)
        Me.TabPage_General.Controls.Add(Me.ProgressBar_BrakeTravel)
        Me.TabPage_General.Controls.Add(Me.Label_MotorTemp_RearLeft)
        Me.TabPage_General.Controls.Add(Me.Label_MotorTemp_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_MotorTemp_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_MotorTemp_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.ListView_BMS)
        Me.TabPage_General.Controls.Add(Me.ListView_VCU)
        Me.TabPage_General.Controls.Add(Me.Label_Power)
        Me.TabPage_General.Controls.Add(Me.Label_Current)
        Me.TabPage_General.Controls.Add(Me.Label_Voltage)
        Me.TabPage_General.Controls.Add(Me.Label_Throttle)
        Me.TabPage_General.Controls.Add(Me.ProgressBar_Throttle)
        Me.TabPage_General.Controls.Add(Me.Label_BrakeFront)
        Me.TabPage_General.Controls.Add(Me.ProgressBar_BrakeFront)
        Me.TabPage_General.Controls.Add(Me.Label_BrakeRear)
        Me.TabPage_General.Controls.Add(Me.ProgressBar_BrakeRear)
        Me.TabPage_General.Controls.Add(Me.Label_RPM_FrontRight)
        Me.TabPage_General.Controls.Add(Me.Label_RPM_RearRight)
        Me.TabPage_General.Controls.Add(Me.Label_RPM_FrontLeft)
        Me.TabPage_General.Controls.Add(Me.Label_RPM_RearLeft)
        Me.TabPage_General.Controls.Add(Me.PictureBox_Car)
        Me.TabPage_General.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_General.Name = "TabPage_General"
        Me.TabPage_General.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_General.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_General.TabIndex = 0
        Me.TabPage_General.Text = "General"
        Me.TabPage_General.UseVisualStyleBackColor = True
        '
        'Label_Actual_FrontRight
        '
        Me.Label_Actual_FrontRight.AutoSize = True
        Me.Label_Actual_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Actual_FrontRight.Location = New System.Drawing.Point(977, 556)
        Me.Label_Actual_FrontRight.Name = "Label_Actual_FrontRight"
        Me.Label_Actual_FrontRight.Size = New System.Drawing.Size(55, 24)
        Me.Label_Actual_FrontRight.TabIndex = 54
        Me.Label_Actual_FrontRight.Text = "0 Nm"
        '
        'Label_Demanded_FrontRight
        '
        Me.Label_Demanded_FrontRight.AutoSize = True
        Me.Label_Demanded_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Demanded_FrontRight.Location = New System.Drawing.Point(977, 532)
        Me.Label_Demanded_FrontRight.Name = "Label_Demanded_FrontRight"
        Me.Label_Demanded_FrontRight.Size = New System.Drawing.Size(55, 24)
        Me.Label_Demanded_FrontRight.TabIndex = 53
        Me.Label_Demanded_FrontRight.Text = "0 Nm"
        '
        'Label_Actual_FrontLeft
        '
        Me.Label_Actual_FrontLeft.AutoSize = True
        Me.Label_Actual_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Actual_FrontLeft.Location = New System.Drawing.Point(977, 66)
        Me.Label_Actual_FrontLeft.Name = "Label_Actual_FrontLeft"
        Me.Label_Actual_FrontLeft.Size = New System.Drawing.Size(55, 24)
        Me.Label_Actual_FrontLeft.TabIndex = 52
        Me.Label_Actual_FrontLeft.Text = "0 Nm"
        '
        'Label_Demanded_FrontLeft
        '
        Me.Label_Demanded_FrontLeft.AutoSize = True
        Me.Label_Demanded_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Demanded_FrontLeft.Location = New System.Drawing.Point(977, 42)
        Me.Label_Demanded_FrontLeft.Name = "Label_Demanded_FrontLeft"
        Me.Label_Demanded_FrontLeft.Size = New System.Drawing.Size(55, 24)
        Me.Label_Demanded_FrontLeft.TabIndex = 51
        Me.Label_Demanded_FrontLeft.Text = "0 Nm"
        Me.Label_Demanded_FrontLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Actual_RearRight
        '
        Me.Label_Actual_RearRight.AutoSize = True
        Me.Label_Actual_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Actual_RearRight.Location = New System.Drawing.Point(42, 556)
        Me.Label_Actual_RearRight.Name = "Label_Actual_RearRight"
        Me.Label_Actual_RearRight.Size = New System.Drawing.Size(55, 24)
        Me.Label_Actual_RearRight.TabIndex = 50
        Me.Label_Actual_RearRight.Text = "0 Nm"
        '
        'Label_Demanded_RearRight
        '
        Me.Label_Demanded_RearRight.AutoSize = True
        Me.Label_Demanded_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Demanded_RearRight.Location = New System.Drawing.Point(42, 532)
        Me.Label_Demanded_RearRight.Name = "Label_Demanded_RearRight"
        Me.Label_Demanded_RearRight.Size = New System.Drawing.Size(55, 24)
        Me.Label_Demanded_RearRight.TabIndex = 49
        Me.Label_Demanded_RearRight.Text = "0 Nm"
        '
        'Label_Actual_RearLeft
        '
        Me.Label_Actual_RearLeft.AutoSize = True
        Me.Label_Actual_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Actual_RearLeft.Location = New System.Drawing.Point(42, 66)
        Me.Label_Actual_RearLeft.Name = "Label_Actual_RearLeft"
        Me.Label_Actual_RearLeft.Size = New System.Drawing.Size(55, 24)
        Me.Label_Actual_RearLeft.TabIndex = 48
        Me.Label_Actual_RearLeft.Text = "0 Nm"
        '
        'Label_Demanded_RearLeft
        '
        Me.Label_Demanded_RearLeft.AutoSize = True
        Me.Label_Demanded_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Demanded_RearLeft.Location = New System.Drawing.Point(42, 42)
        Me.Label_Demanded_RearLeft.Name = "Label_Demanded_RearLeft"
        Me.Label_Demanded_RearLeft.Size = New System.Drawing.Size(55, 24)
        Me.Label_Demanded_RearLeft.TabIndex = 47
        Me.Label_Demanded_RearLeft.Text = "0 Nm"
        Me.Label_Demanded_RearLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_SteeringAngle
        '
        Me.Label_SteeringAngle.AutoSize = True
        Me.Label_SteeringAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SteeringAngle.Location = New System.Drawing.Point(725, 299)
        Me.Label_SteeringAngle.Name = "Label_SteeringAngle"
        Me.Label_SteeringAngle.Size = New System.Drawing.Size(31, 24)
        Me.Label_SteeringAngle.TabIndex = 46
        Me.Label_SteeringAngle.Text = "0 °"
        '
        'Label_SuspensionStrain_RearRight
        '
        Me.Label_SuspensionStrain_RearRight.AutoSize = True
        Me.Label_SuspensionStrain_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionStrain_RearRight.Location = New System.Drawing.Point(308, 484)
        Me.Label_SuspensionStrain_RearRight.Name = "Label_SuspensionStrain_RearRight"
        Me.Label_SuspensionStrain_RearRight.Size = New System.Drawing.Size(45, 24)
        Me.Label_SuspensionStrain_RearRight.TabIndex = 45
        Me.Label_SuspensionStrain_RearRight.Text = "0 kg"
        '
        'Label_SuspensionTravel_RearRight
        '
        Me.Label_SuspensionTravel_RearRight.AutoSize = True
        Me.Label_SuspensionTravel_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionTravel_RearRight.Location = New System.Drawing.Point(308, 460)
        Me.Label_SuspensionTravel_RearRight.Name = "Label_SuspensionTravel_RearRight"
        Me.Label_SuspensionTravel_RearRight.Size = New System.Drawing.Size(51, 24)
        Me.Label_SuspensionTravel_RearRight.TabIndex = 44
        Me.Label_SuspensionTravel_RearRight.Text = "0 cm"
        '
        'Label_SuspensionStrain_RearLeft
        '
        Me.Label_SuspensionStrain_RearLeft.AutoSize = True
        Me.Label_SuspensionStrain_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionStrain_RearLeft.Location = New System.Drawing.Point(308, 134)
        Me.Label_SuspensionStrain_RearLeft.Name = "Label_SuspensionStrain_RearLeft"
        Me.Label_SuspensionStrain_RearLeft.Size = New System.Drawing.Size(45, 24)
        Me.Label_SuspensionStrain_RearLeft.TabIndex = 43
        Me.Label_SuspensionStrain_RearLeft.Text = "0 kg"
        '
        'Label_SuspensionTravel_RearLeft
        '
        Me.Label_SuspensionTravel_RearLeft.AutoSize = True
        Me.Label_SuspensionTravel_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionTravel_RearLeft.Location = New System.Drawing.Point(308, 110)
        Me.Label_SuspensionTravel_RearLeft.Name = "Label_SuspensionTravel_RearLeft"
        Me.Label_SuspensionTravel_RearLeft.Size = New System.Drawing.Size(51, 24)
        Me.Label_SuspensionTravel_RearLeft.TabIndex = 42
        Me.Label_SuspensionTravel_RearLeft.Text = "0 cm"
        '
        'Label_SuspensionStrain_FrontRight
        '
        Me.Label_SuspensionStrain_FrontRight.AutoSize = True
        Me.Label_SuspensionStrain_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionStrain_FrontRight.Location = New System.Drawing.Point(906, 460)
        Me.Label_SuspensionStrain_FrontRight.Name = "Label_SuspensionStrain_FrontRight"
        Me.Label_SuspensionStrain_FrontRight.Size = New System.Drawing.Size(45, 24)
        Me.Label_SuspensionStrain_FrontRight.TabIndex = 41
        Me.Label_SuspensionStrain_FrontRight.Text = "0 kg"
        '
        'Label_SuspensionTravel_FrontRight
        '
        Me.Label_SuspensionTravel_FrontRight.AutoSize = True
        Me.Label_SuspensionTravel_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionTravel_FrontRight.Location = New System.Drawing.Point(906, 436)
        Me.Label_SuspensionTravel_FrontRight.Name = "Label_SuspensionTravel_FrontRight"
        Me.Label_SuspensionTravel_FrontRight.Size = New System.Drawing.Size(51, 24)
        Me.Label_SuspensionTravel_FrontRight.TabIndex = 40
        Me.Label_SuspensionTravel_FrontRight.Text = "0 cm"
        '
        'Label_SuspensionStrain_FrontLeft
        '
        Me.Label_SuspensionStrain_FrontLeft.AutoSize = True
        Me.Label_SuspensionStrain_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionStrain_FrontLeft.Location = New System.Drawing.Point(906, 172)
        Me.Label_SuspensionStrain_FrontLeft.Name = "Label_SuspensionStrain_FrontLeft"
        Me.Label_SuspensionStrain_FrontLeft.Size = New System.Drawing.Size(45, 24)
        Me.Label_SuspensionStrain_FrontLeft.TabIndex = 39
        Me.Label_SuspensionStrain_FrontLeft.Text = "0 kg"
        '
        'Label_SuspensionTravel_FrontLeft
        '
        Me.Label_SuspensionTravel_FrontLeft.AutoSize = True
        Me.Label_SuspensionTravel_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SuspensionTravel_FrontLeft.Location = New System.Drawing.Point(906, 148)
        Me.Label_SuspensionTravel_FrontLeft.Name = "Label_SuspensionTravel_FrontLeft"
        Me.Label_SuspensionTravel_FrontLeft.Size = New System.Drawing.Size(51, 24)
        Me.Label_SuspensionTravel_FrontLeft.TabIndex = 38
        Me.Label_SuspensionTravel_FrontLeft.Text = "0 cm"
        '
        'Label_PlateTemp
        '
        Me.Label_PlateTemp.AutoSize = True
        Me.Label_PlateTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PlateTemp.Location = New System.Drawing.Point(243, 299)
        Me.Label_PlateTemp.Name = "Label_PlateTemp"
        Me.Label_PlateTemp.Size = New System.Drawing.Size(38, 24)
        Me.Label_PlateTemp.TabIndex = 37
        Me.Label_PlateTemp.Text = "0 C"
        '
        'Label_CoolantTemp_InverterOut
        '
        Me.Label_CoolantTemp_InverterOut.AutoSize = True
        Me.Label_CoolantTemp_InverterOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CoolantTemp_InverterOut.Location = New System.Drawing.Point(42, 360)
        Me.Label_CoolantTemp_InverterOut.Name = "Label_CoolantTemp_InverterOut"
        Me.Label_CoolantTemp_InverterOut.Size = New System.Drawing.Size(38, 24)
        Me.Label_CoolantTemp_InverterOut.TabIndex = 36
        Me.Label_CoolantTemp_InverterOut.Text = "0 C"
        '
        'Label_CoolantTemp_InverterIn
        '
        Me.Label_CoolantTemp_InverterIn.AutoSize = True
        Me.Label_CoolantTemp_InverterIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CoolantTemp_InverterIn.Location = New System.Drawing.Point(42, 484)
        Me.Label_CoolantTemp_InverterIn.Name = "Label_CoolantTemp_InverterIn"
        Me.Label_CoolantTemp_InverterIn.Size = New System.Drawing.Size(38, 24)
        Me.Label_CoolantTemp_InverterIn.TabIndex = 35
        Me.Label_CoolantTemp_InverterIn.Text = "0 C"
        '
        'Label_CoolantTemp_MotorOut
        '
        Me.Label_CoolantTemp_MotorOut.AutoSize = True
        Me.Label_CoolantTemp_MotorOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CoolantTemp_MotorOut.Location = New System.Drawing.Point(42, 114)
        Me.Label_CoolantTemp_MotorOut.Name = "Label_CoolantTemp_MotorOut"
        Me.Label_CoolantTemp_MotorOut.Size = New System.Drawing.Size(38, 24)
        Me.Label_CoolantTemp_MotorOut.TabIndex = 34
        Me.Label_CoolantTemp_MotorOut.Text = "0 C"
        '
        'Label_CoolantTemp_MotorIn
        '
        Me.Label_CoolantTemp_MotorIn.AutoSize = True
        Me.Label_CoolantTemp_MotorIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CoolantTemp_MotorIn.Location = New System.Drawing.Point(42, 239)
        Me.Label_CoolantTemp_MotorIn.Name = "Label_CoolantTemp_MotorIn"
        Me.Label_CoolantTemp_MotorIn.Size = New System.Drawing.Size(38, 24)
        Me.Label_CoolantTemp_MotorIn.TabIndex = 33
        Me.Label_CoolantTemp_MotorIn.Text = "0 C"
        '
        'Label_Gearbox_RearRight
        '
        Me.Label_Gearbox_RearRight.AutoSize = True
        Me.Label_Gearbox_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Gearbox_RearRight.Location = New System.Drawing.Point(243, 556)
        Me.Label_Gearbox_RearRight.Name = "Label_Gearbox_RearRight"
        Me.Label_Gearbox_RearRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_Gearbox_RearRight.TabIndex = 32
        Me.Label_Gearbox_RearRight.Text = "0 C"
        '
        'Label_Gearbox_FrontRight
        '
        Me.Label_Gearbox_FrontRight.AutoSize = True
        Me.Label_Gearbox_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Gearbox_FrontRight.Location = New System.Drawing.Point(881, 556)
        Me.Label_Gearbox_FrontRight.Name = "Label_Gearbox_FrontRight"
        Me.Label_Gearbox_FrontRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_Gearbox_FrontRight.TabIndex = 31
        Me.Label_Gearbox_FrontRight.Text = "0 C"
        '
        'Label_Gearbox_FrontLeft
        '
        Me.Label_Gearbox_FrontLeft.AutoSize = True
        Me.Label_Gearbox_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Gearbox_FrontLeft.Location = New System.Drawing.Point(881, 66)
        Me.Label_Gearbox_FrontLeft.Name = "Label_Gearbox_FrontLeft"
        Me.Label_Gearbox_FrontLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_Gearbox_FrontLeft.TabIndex = 30
        Me.Label_Gearbox_FrontLeft.Text = "0 C"
        '
        'Label_Gearbox_RearLeft
        '
        Me.Label_Gearbox_RearLeft.AutoSize = True
        Me.Label_Gearbox_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Gearbox_RearLeft.Location = New System.Drawing.Point(243, 66)
        Me.Label_Gearbox_RearLeft.Name = "Label_Gearbox_RearLeft"
        Me.Label_Gearbox_RearLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_Gearbox_RearLeft.TabIndex = 29
        Me.Label_Gearbox_RearLeft.Text = "0 C"
        '
        'Label_IGBT_FrontLeft
        '
        Me.Label_IGBT_FrontLeft.AutoSize = True
        Me.Label_IGBT_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IGBT_FrontLeft.Location = New System.Drawing.Point(881, 42)
        Me.Label_IGBT_FrontLeft.Name = "Label_IGBT_FrontLeft"
        Me.Label_IGBT_FrontLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_IGBT_FrontLeft.TabIndex = 28
        Me.Label_IGBT_FrontLeft.Text = "0 C"
        '
        'Label_IGBT_FrontRight
        '
        Me.Label_IGBT_FrontRight.AutoSize = True
        Me.Label_IGBT_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IGBT_FrontRight.Location = New System.Drawing.Point(881, 532)
        Me.Label_IGBT_FrontRight.Name = "Label_IGBT_FrontRight"
        Me.Label_IGBT_FrontRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_IGBT_FrontRight.TabIndex = 27
        Me.Label_IGBT_FrontRight.Text = "0 C"
        '
        'Label_IGBT_RearRight
        '
        Me.Label_IGBT_RearRight.AutoSize = True
        Me.Label_IGBT_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IGBT_RearRight.Location = New System.Drawing.Point(243, 532)
        Me.Label_IGBT_RearRight.Name = "Label_IGBT_RearRight"
        Me.Label_IGBT_RearRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_IGBT_RearRight.TabIndex = 26
        Me.Label_IGBT_RearRight.Text = "0 C"
        '
        'Label_IGBT_RearLeft
        '
        Me.Label_IGBT_RearLeft.AutoSize = True
        Me.Label_IGBT_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IGBT_RearLeft.Location = New System.Drawing.Point(243, 42)
        Me.Label_IGBT_RearLeft.Name = "Label_IGBT_RearLeft"
        Me.Label_IGBT_RearLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_IGBT_RearLeft.TabIndex = 25
        Me.Label_IGBT_RearLeft.Text = "0 C"
        '
        'Label_BrakeTravel
        '
        Me.Label_BrakeTravel.AutoSize = True
        Me.Label_BrakeTravel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BrakeTravel.Location = New System.Drawing.Point(1074, 326)
        Me.Label_BrakeTravel.Name = "Label_BrakeTravel"
        Me.Label_BrakeTravel.Size = New System.Drawing.Size(54, 20)
        Me.Label_BrakeTravel.TabIndex = 24
        Me.Label_BrakeTravel.Text = "000 %"
        '
        'ProgressBar_BrakeTravel
        '
        Me.ProgressBar_BrakeTravel.Location = New System.Drawing.Point(935, 326)
        Me.ProgressBar_BrakeTravel.Name = "ProgressBar_BrakeTravel"
        Me.ProgressBar_BrakeTravel.Size = New System.Drawing.Size(129, 20)
        Me.ProgressBar_BrakeTravel.TabIndex = 23
        '
        'Label_MotorTemp_RearLeft
        '
        Me.Label_MotorTemp_RearLeft.AutoSize = True
        Me.Label_MotorTemp_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MotorTemp_RearLeft.Location = New System.Drawing.Point(133, 66)
        Me.Label_MotorTemp_RearLeft.Name = "Label_MotorTemp_RearLeft"
        Me.Label_MotorTemp_RearLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_MotorTemp_RearLeft.TabIndex = 22
        Me.Label_MotorTemp_RearLeft.Text = "0 C"
        '
        'Label_MotorTemp_RearRight
        '
        Me.Label_MotorTemp_RearRight.AutoSize = True
        Me.Label_MotorTemp_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MotorTemp_RearRight.Location = New System.Drawing.Point(133, 556)
        Me.Label_MotorTemp_RearRight.Name = "Label_MotorTemp_RearRight"
        Me.Label_MotorTemp_RearRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_MotorTemp_RearRight.TabIndex = 21
        Me.Label_MotorTemp_RearRight.Text = "0 C"
        '
        'Label_MotorTemp_FrontRight
        '
        Me.Label_MotorTemp_FrontRight.AutoSize = True
        Me.Label_MotorTemp_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MotorTemp_FrontRight.Location = New System.Drawing.Point(771, 556)
        Me.Label_MotorTemp_FrontRight.Name = "Label_MotorTemp_FrontRight"
        Me.Label_MotorTemp_FrontRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_MotorTemp_FrontRight.TabIndex = 20
        Me.Label_MotorTemp_FrontRight.Text = "0 C"
        '
        'Label_MotorTemp_FrontLeft
        '
        Me.Label_MotorTemp_FrontLeft.AutoSize = True
        Me.Label_MotorTemp_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MotorTemp_FrontLeft.Location = New System.Drawing.Point(771, 66)
        Me.Label_MotorTemp_FrontLeft.Name = "Label_MotorTemp_FrontLeft"
        Me.Label_MotorTemp_FrontLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_MotorTemp_FrontLeft.TabIndex = 19
        Me.Label_MotorTemp_FrontLeft.Text = "0 C"
        '
        'ListView_BMS
        '
        Me.ListView_BMS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_BMSPack, Me.ColumnHeader_BMS_Voltage_Min, Me.ColumnHeader_BMS_Voltage_Max, Me.ColumnHeader_BMS_Temp_Min, Me.ColumnHeader_BMS_Temp_Max})
        Me.ListView_BMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_BMS.FullRowSelect = True
        Me.ListView_BMS.GridLines = True
        Me.ListView_BMS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_BMS.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView_BMS.Location = New System.Drawing.Point(345, 532)
        Me.ListView_BMS.MaximumSize = New System.Drawing.Size(383, 51)
        Me.ListView_BMS.MinimumSize = New System.Drawing.Size(383, 51)
        Me.ListView_BMS.Name = "ListView_BMS"
        Me.ListView_BMS.Scrollable = False
        Me.ListView_BMS.Size = New System.Drawing.Size(383, 51)
        Me.ListView_BMS.TabIndex = 18
        Me.ListView_BMS.UseCompatibleStateImageBehavior = False
        Me.ListView_BMS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_BMSPack
        '
        Me.ColumnHeader_BMSPack.Text = "Pack"
        Me.ColumnHeader_BMSPack.Width = 65
        '
        'ColumnHeader_BMS_Voltage_Min
        '
        Me.ColumnHeader_BMS_Voltage_Min.Text = "Min Cell"
        Me.ColumnHeader_BMS_Voltage_Min.Width = 70
        '
        'ColumnHeader_BMS_Voltage_Max
        '
        Me.ColumnHeader_BMS_Voltage_Max.Text = "Max Cell"
        Me.ColumnHeader_BMS_Voltage_Max.Width = 75
        '
        'ColumnHeader_BMS_Temp_Min
        '
        Me.ColumnHeader_BMS_Temp_Min.Text = "Min Temp"
        Me.ColumnHeader_BMS_Temp_Min.Width = 85
        '
        'ColumnHeader_BMS_Temp_Max
        '
        Me.ColumnHeader_BMS_Temp_Max.Text = "Max Temp"
        Me.ColumnHeader_BMS_Temp_Max.Width = 85
        '
        'ListView_VCU
        '
        Me.ListView_VCU.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_VCUFlag, Me.ColumnHeader_VCUValue})
        Me.ListView_VCU.FullRowSelect = True
        Me.ListView_VCU.GridLines = True
        Me.ListView_VCU.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_VCU.Location = New System.Drawing.Point(421, 238)
        Me.ListView_VCU.Name = "ListView_VCU"
        Me.ListView_VCU.Scrollable = False
        Me.ListView_VCU.Size = New System.Drawing.Size(113, 146)
        Me.ListView_VCU.TabIndex = 17
        Me.ListView_VCU.UseCompatibleStateImageBehavior = False
        Me.ListView_VCU.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_VCUFlag
        '
        Me.ColumnHeader_VCUFlag.Text = "Flag"
        Me.ColumnHeader_VCUFlag.Width = 50
        '
        'ColumnHeader_VCUValue
        '
        Me.ColumnHeader_VCUValue.Text = "Value"
        '
        'Label_Power
        '
        Me.Label_Power.AutoSize = True
        Me.Label_Power.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Power.Location = New System.Drawing.Point(577, 275)
        Me.Label_Power.Name = "Label_Power"
        Me.Label_Power.Size = New System.Drawing.Size(43, 24)
        Me.Label_Power.TabIndex = 15
        Me.Label_Power.Text = "0 W"
        '
        'Label_Current
        '
        Me.Label_Current.AutoSize = True
        Me.Label_Current.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Current.Location = New System.Drawing.Point(577, 323)
        Me.Label_Current.Name = "Label_Current"
        Me.Label_Current.Size = New System.Drawing.Size(38, 24)
        Me.Label_Current.TabIndex = 13
        Me.Label_Current.Text = "0 A"
        '
        'Label_Voltage
        '
        Me.Label_Voltage.AutoSize = True
        Me.Label_Voltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Voltage.Location = New System.Drawing.Point(577, 299)
        Me.Label_Voltage.Name = "Label_Voltage"
        Me.Label_Voltage.Size = New System.Drawing.Size(38, 24)
        Me.Label_Voltage.TabIndex = 12
        Me.Label_Voltage.Text = "0 V"
        '
        'Label_Throttle
        '
        Me.Label_Throttle.AutoSize = True
        Me.Label_Throttle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Throttle.Location = New System.Drawing.Point(1074, 352)
        Me.Label_Throttle.Name = "Label_Throttle"
        Me.Label_Throttle.Size = New System.Drawing.Size(54, 20)
        Me.Label_Throttle.TabIndex = 11
        Me.Label_Throttle.Text = "000 %"
        '
        'ProgressBar_Throttle
        '
        Me.ProgressBar_Throttle.Location = New System.Drawing.Point(935, 352)
        Me.ProgressBar_Throttle.Name = "ProgressBar_Throttle"
        Me.ProgressBar_Throttle.Size = New System.Drawing.Size(129, 20)
        Me.ProgressBar_Throttle.TabIndex = 10
        '
        'Label_BrakeFront
        '
        Me.Label_BrakeFront.AutoSize = True
        Me.Label_BrakeFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BrakeFront.Location = New System.Drawing.Point(1074, 282)
        Me.Label_BrakeFront.Name = "Label_BrakeFront"
        Me.Label_BrakeFront.Size = New System.Drawing.Size(65, 20)
        Me.Label_BrakeFront.TabIndex = 9
        Me.Label_BrakeFront.Text = "000 Bar"
        '
        'ProgressBar_BrakeFront
        '
        Me.ProgressBar_BrakeFront.Location = New System.Drawing.Point(935, 283)
        Me.ProgressBar_BrakeFront.Maximum = 200
        Me.ProgressBar_BrakeFront.Name = "ProgressBar_BrakeFront"
        Me.ProgressBar_BrakeFront.Size = New System.Drawing.Size(129, 20)
        Me.ProgressBar_BrakeFront.TabIndex = 8
        '
        'Label_BrakeRear
        '
        Me.Label_BrakeRear.AutoSize = True
        Me.Label_BrakeRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BrakeRear.Location = New System.Drawing.Point(1074, 257)
        Me.Label_BrakeRear.Name = "Label_BrakeRear"
        Me.Label_BrakeRear.Size = New System.Drawing.Size(65, 20)
        Me.Label_BrakeRear.TabIndex = 7
        Me.Label_BrakeRear.Text = "000 Bar"
        '
        'ProgressBar_BrakeRear
        '
        Me.ProgressBar_BrakeRear.Location = New System.Drawing.Point(935, 257)
        Me.ProgressBar_BrakeRear.Maximum = 200
        Me.ProgressBar_BrakeRear.Name = "ProgressBar_BrakeRear"
        Me.ProgressBar_BrakeRear.Size = New System.Drawing.Size(129, 20)
        Me.ProgressBar_BrakeRear.TabIndex = 5
        '
        'Label_RPM_FrontRight
        '
        Me.Label_RPM_FrontRight.AutoSize = True
        Me.Label_RPM_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_FrontRight.Location = New System.Drawing.Point(771, 532)
        Me.Label_RPM_FrontRight.Name = "Label_RPM_FrontRight"
        Me.Label_RPM_FrontRight.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_FrontRight.TabIndex = 4
        Me.Label_RPM_FrontRight.Text = "0 RPM"
        '
        'Label_RPM_RearRight
        '
        Me.Label_RPM_RearRight.AutoSize = True
        Me.Label_RPM_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_RearRight.Location = New System.Drawing.Point(133, 532)
        Me.Label_RPM_RearRight.Name = "Label_RPM_RearRight"
        Me.Label_RPM_RearRight.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_RearRight.TabIndex = 3
        Me.Label_RPM_RearRight.Text = "0 RPM"
        '
        'Label_RPM_FrontLeft
        '
        Me.Label_RPM_FrontLeft.AutoSize = True
        Me.Label_RPM_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_FrontLeft.Location = New System.Drawing.Point(771, 42)
        Me.Label_RPM_FrontLeft.Name = "Label_RPM_FrontLeft"
        Me.Label_RPM_FrontLeft.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_FrontLeft.TabIndex = 2
        Me.Label_RPM_FrontLeft.Text = "0 RPM"
        '
        'Label_RPM_RearLeft
        '
        Me.Label_RPM_RearLeft.AutoSize = True
        Me.Label_RPM_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_RearLeft.Location = New System.Drawing.Point(133, 42)
        Me.Label_RPM_RearLeft.Name = "Label_RPM_RearLeft"
        Me.Label_RPM_RearLeft.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_RearLeft.TabIndex = 1
        Me.Label_RPM_RearLeft.Text = "0 RPM"
        '
        'PictureBox_Car
        '
        Me.PictureBox_Car.Image = Global.UoP_Telemetry_GUI.My.Resources.Resources.UoP7e
        Me.PictureBox_Car.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox_Car.Name = "PictureBox_Car"
        Me.PictureBox_Car.Size = New System.Drawing.Size(1220, 615)
        Me.PictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Car.TabIndex = 0
        Me.PictureBox_Car.TabStop = False
        '
        'TabPage_Plotting
        '
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_Plotting_Sync)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_AutoScale)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_AutoScroll)
        Me.TabPage_Plotting.Controls.Add(Me.Chart)
        Me.TabPage_Plotting.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Plotting.Name = "TabPage_Plotting"
        Me.TabPage_Plotting.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_Plotting.TabIndex = 2
        Me.TabPage_Plotting.Text = "Plotting"
        Me.TabPage_Plotting.UseVisualStyleBackColor = True
        '
        'CheckBox_Plotting_Sync
        '
        Me.CheckBox_Plotting_Sync.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_Plotting_Sync.AutoSize = True
        Me.CheckBox_Plotting_Sync.Location = New System.Drawing.Point(1132, 632)
        Me.CheckBox_Plotting_Sync.Name = "CheckBox_Plotting_Sync"
        Me.CheckBox_Plotting_Sync.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox_Plotting_Sync.TabIndex = 16
        Me.CheckBox_Plotting_Sync.Text = "Sync"
        Me.CheckBox_Plotting_Sync.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoScale
        '
        Me.CheckBox_AutoScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_AutoScale.AutoSize = True
        Me.CheckBox_AutoScale.Checked = True
        Me.CheckBox_AutoScale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AutoScale.Location = New System.Drawing.Point(1188, 632)
        Me.CheckBox_AutoScale.Name = "CheckBox_AutoScale"
        Me.CheckBox_AutoScale.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox_AutoScale.TabIndex = 12
        Me.CheckBox_AutoScale.Text = "Auto Scale"
        Me.CheckBox_AutoScale.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoScroll
        '
        Me.CheckBox_AutoScroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_AutoScroll.AutoSize = True
        Me.CheckBox_AutoScroll.Checked = True
        Me.CheckBox_AutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AutoScroll.Location = New System.Drawing.Point(1272, 632)
        Me.CheckBox_AutoScroll.Name = "CheckBox_AutoScroll"
        Me.CheckBox_AutoScroll.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox_AutoScroll.TabIndex = 1
        Me.CheckBox_AutoScroll.Text = "Auto Scroll"
        Me.CheckBox_AutoScroll.UseVisualStyleBackColor = True
        '
        'Chart
        '
        ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisX.Interval = 30.0R
        ChartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea1.AxisX.LabelStyle.Interval = 5.0R
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.MajorGrid.Interval = 10.0R
        ChartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.MinorGrid.Enabled = True
        ChartArea1.AxisX.MinorGrid.Interval = 1.0R
        ChartArea1.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea1.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea1.AxisX.ScaleView.MinSize = 100.0R
        ChartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea1.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea1.AxisX.ScaleView.Size = 20.0R
        ChartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea1.AxisY.Maximum = 100.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY2.Maximum = 200.0R
        ChartArea1.AxisY2.Minimum = 0R
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea_Pedals"
        ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea2.AxisX.Interval = 30.0R
        ChartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea2.AxisX.LabelStyle.Interval = 5.0R
        ChartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.MajorGrid.Interval = 10.0R
        ChartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.MinorGrid.Enabled = True
        ChartArea2.AxisX.MinorGrid.Interval = 1.0R
        ChartArea2.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MinorTickMark.Enabled = True
        ChartArea2.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea2.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea2.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea2.AxisX.ScaleView.MinSize = 100.0R
        ChartArea2.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea2.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea2.AxisX.ScaleView.Size = 20.0R
        ChartArea2.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea2.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea2.AxisY.Maximum = 150.0R
        ChartArea2.AxisY.Minimum = 0R
        ChartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea2.AxisY2.Maximum = 150.0R
        ChartArea2.AxisY2.Minimum = 0R
        ChartArea2.CursorX.IsUserEnabled = True
        ChartArea2.CursorX.IsUserSelectionEnabled = True
        ChartArea2.Name = "ChartArea_Temps"
        ChartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea3.AxisX.Interval = 30.0R
        ChartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea3.AxisX.LabelStyle.Interval = 5.0R
        ChartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.MajorGrid.Interval = 10.0R
        ChartArea3.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea3.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.MinorGrid.Enabled = True
        ChartArea3.AxisX.MinorGrid.Interval = 1.0R
        ChartArea3.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea3.AxisX.MinorTickMark.Enabled = True
        ChartArea3.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea3.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea3.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea3.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea3.AxisX.ScaleView.MinSize = 100.0R
        ChartArea3.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea3.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea3.AxisX.ScaleView.Size = 20.0R
        ChartArea3.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea3.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea3.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea3.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea3.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea3.AxisY.IsStartedFromZero = False
        ChartArea3.AxisY.Maximum = 150.0R
        ChartArea3.AxisY.Minimum = 0R
        ChartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea3.AxisY2.IsStartedFromZero = False
        ChartArea3.AxisY2.Maximum = 400.0R
        ChartArea3.AxisY2.Minimum = 100.0R
        ChartArea3.CursorX.IsUserEnabled = True
        ChartArea3.CursorX.IsUserSelectionEnabled = True
        ChartArea3.Name = "ChartArea_Suspension"
        ChartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea4.AxisX.Interval = 30.0R
        ChartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea4.AxisX.LabelStyle.Interval = 5.0R
        ChartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.MajorGrid.Interval = 10.0R
        ChartArea4.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea4.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.MinorGrid.Enabled = True
        ChartArea4.AxisX.MinorGrid.Interval = 1.0R
        ChartArea4.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea4.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea4.AxisX.MinorTickMark.Enabled = True
        ChartArea4.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea4.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea4.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea4.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea4.AxisX.ScaleView.MinSize = 100.0R
        ChartArea4.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea4.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea4.AxisX.ScaleView.Size = 20.0R
        ChartArea4.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea4.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea4.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea4.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea4.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea4.Name = "ChartArea_Performance"
        ChartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea5.AxisX.Interval = 30.0R
        ChartArea5.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea5.AxisX.LabelStyle.Interval = 5.0R
        ChartArea5.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.MajorGrid.Interval = 10.0R
        ChartArea5.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea5.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.MinorGrid.Enabled = True
        ChartArea5.AxisX.MinorGrid.Interval = 1.0R
        ChartArea5.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea5.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea5.AxisX.MinorTickMark.Enabled = True
        ChartArea5.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea5.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea5.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea5.AxisX.ScaleView.MinSize = 100.0R
        ChartArea5.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea5.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea5.AxisX.ScaleView.Size = 20.0R
        ChartArea5.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea5.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea5.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea5.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea5.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea5.AxisY.Maximum = 130.0R
        ChartArea5.AxisY.Minimum = -130.0R
        ChartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea5.AxisY2.Maximum = 600.0R
        ChartArea5.AxisY2.Minimum = 300.0R
        ChartArea5.CursorX.IsUserEnabled = True
        ChartArea5.CursorX.IsUserSelectionEnabled = True
        ChartArea5.Name = "ChartArea_Various"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Me.Chart.ChartAreas.Add(ChartArea2)
        Me.Chart.ChartAreas.Add(ChartArea3)
        Me.Chart.ChartAreas.Add(ChartArea4)
        Me.Chart.ChartAreas.Add(ChartArea5)
        Me.Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart.IsSoftShadows = False
        Legend1.DockedToChartArea = "ChartArea_Pedals"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.IsEquallySpacedItems = True
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend1.Name = "Legend_Pedals"
        Legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend1.TextWrapThreshold = 35
        Legend2.DockedToChartArea = "ChartArea_Temps"
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.IsEquallySpacedItems = True
        Legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend2.Name = "Legend_Temps"
        Legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend2.TextWrapThreshold = 35
        Legend3.DockedToChartArea = "ChartArea_Suspension"
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.IsEquallySpacedItems = True
        Legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend3.Name = "Legend_Suspension"
        Legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend3.TextWrapThreshold = 35
        Legend4.DockedToChartArea = "ChartArea_Performance"
        Legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend4.IsEquallySpacedItems = True
        Legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend4.Name = "Legend_Performance"
        Legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend4.TextWrapThreshold = 35
        Legend5.DockedToChartArea = "ChartArea_Various"
        Legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend5.IsEquallySpacedItems = True
        Legend5.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend5.Name = "Legend_Various"
        Legend5.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend5.TextWrapThreshold = 35
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Legends.Add(Legend2)
        Me.Chart.Legends.Add(Legend3)
        Me.Chart.Legends.Add(Legend4)
        Me.Chart.Legends.Add(Legend5)
        Me.Chart.Location = New System.Drawing.Point(0, 0)
        Me.Chart.Name = "Chart"
        Me.Chart.Size = New System.Drawing.Size(1357, 648)
        Me.Chart.TabIndex = 0
        Me.Chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'TabPage_BMS
        '
        Me.TabPage_BMS.Controls.Add(Me.GroupBox_BMS_Settings)
        Me.TabPage_BMS.Controls.Add(Me.Chart_BMS)
        Me.TabPage_BMS.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_BMS.Name = "TabPage_BMS"
        Me.TabPage_BMS.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_BMS.TabIndex = 4
        Me.TabPage_BMS.Text = "BMS"
        Me.TabPage_BMS.UseVisualStyleBackColor = True
        '
        'GroupBox_BMS_Settings
        '
        Me.GroupBox_BMS_Settings.Controls.Add(Me.CheckBox_BMS_PlotVoltages)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.CheckBox_BMS_PlotTemperatures)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.CheckBox_BMS_Coloring)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.Label_BMS_CellRange)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.PictureBox_BMS_HighColor)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.NumericUpDown_BMS_CellMin)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.PictureBox_BMS_LowColor)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.NumericUpDown_BMS_CellMax)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.NumericUpDown_BMS_VoltageMax)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.ComboBox_BMS_CellRange)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.NumericUpDown_BMS_VoltageMin)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.Label_BMS_VoltageRange)
        Me.GroupBox_BMS_Settings.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox_BMS_Settings.Name = "GroupBox_BMS_Settings"
        Me.GroupBox_BMS_Settings.Size = New System.Drawing.Size(769, 58)
        Me.GroupBox_BMS_Settings.TabIndex = 16
        Me.GroupBox_BMS_Settings.TabStop = False
        Me.GroupBox_BMS_Settings.Text = "Settings"
        '
        'CheckBox_BMS_PlotVoltages
        '
        Me.CheckBox_BMS_PlotVoltages.AutoSize = True
        Me.CheckBox_BMS_PlotVoltages.Checked = True
        Me.CheckBox_BMS_PlotVoltages.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_BMS_PlotVoltages.Location = New System.Drawing.Point(518, 33)
        Me.CheckBox_BMS_PlotVoltages.Name = "CheckBox_BMS_PlotVoltages"
        Me.CheckBox_BMS_PlotVoltages.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox_BMS_PlotVoltages.TabIndex = 1
        Me.CheckBox_BMS_PlotVoltages.Text = "Voltages"
        Me.CheckBox_BMS_PlotVoltages.UseVisualStyleBackColor = True
        '
        'CheckBox_BMS_PlotTemperatures
        '
        Me.CheckBox_BMS_PlotTemperatures.AutoSize = True
        Me.CheckBox_BMS_PlotTemperatures.Location = New System.Drawing.Point(591, 33)
        Me.CheckBox_BMS_PlotTemperatures.Name = "CheckBox_BMS_PlotTemperatures"
        Me.CheckBox_BMS_PlotTemperatures.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox_BMS_PlotTemperatures.TabIndex = 2
        Me.CheckBox_BMS_PlotTemperatures.Text = "Temperatures"
        Me.CheckBox_BMS_PlotTemperatures.UseVisualStyleBackColor = True
        '
        'CheckBox_BMS_Coloring
        '
        Me.CheckBox_BMS_Coloring.AutoSize = True
        Me.CheckBox_BMS_Coloring.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_Coloring
        Me.CheckBox_BMS_Coloring.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_BMS_Coloring.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_Coloring", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox_BMS_Coloring.Location = New System.Drawing.Point(368, 12)
        Me.CheckBox_BMS_Coloring.Name = "CheckBox_BMS_Coloring"
        Me.CheckBox_BMS_Coloring.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_BMS_Coloring.TabIndex = 14
        Me.CheckBox_BMS_Coloring.Text = "Coloring"
        Me.CheckBox_BMS_Coloring.UseVisualStyleBackColor = True
        '
        'Label_BMS_CellRange
        '
        Me.Label_BMS_CellRange.AutoSize = True
        Me.Label_BMS_CellRange.Location = New System.Drawing.Point(6, 16)
        Me.Label_BMS_CellRange.Name = "Label_BMS_CellRange"
        Me.Label_BMS_CellRange.Size = New System.Drawing.Size(62, 13)
        Me.Label_BMS_CellRange.TabIndex = 7
        Me.Label_BMS_CellRange.Text = "Cell Range:"
        '
        'PictureBox_BMS_HighColor
        '
        Me.PictureBox_BMS_HighColor.BackColor = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_Coloring_High
        Me.PictureBox_BMS_HighColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_Coloring_High", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox_BMS_HighColor.Location = New System.Drawing.Point(368, 31)
        Me.PictureBox_BMS_HighColor.Name = "PictureBox_BMS_HighColor"
        Me.PictureBox_BMS_HighColor.Size = New System.Drawing.Size(69, 21)
        Me.PictureBox_BMS_HighColor.TabIndex = 13
        Me.PictureBox_BMS_HighColor.TabStop = False
        '
        'NumericUpDown_BMS_CellMin
        '
        Me.NumericUpDown_BMS_CellMin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_CellRange_Min", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown_BMS_CellMin.Location = New System.Drawing.Point(9, 32)
        Me.NumericUpDown_BMS_CellMin.Maximum = New Decimal(New Integer() {144, 0, 0, 0})
        Me.NumericUpDown_BMS_CellMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_BMS_CellMin.Name = "NumericUpDown_BMS_CellMin"
        Me.NumericUpDown_BMS_CellMin.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown_BMS_CellMin.TabIndex = 4
        Me.NumericUpDown_BMS_CellMin.Value = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_CellRange_Min
        '
        'PictureBox_BMS_LowColor
        '
        Me.PictureBox_BMS_LowColor.BackColor = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_Coloring_Low
        Me.PictureBox_BMS_LowColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_Coloring_Low", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox_BMS_LowColor.Location = New System.Drawing.Point(443, 31)
        Me.PictureBox_BMS_LowColor.Name = "PictureBox_BMS_LowColor"
        Me.PictureBox_BMS_LowColor.Size = New System.Drawing.Size(69, 21)
        Me.PictureBox_BMS_LowColor.TabIndex = 12
        Me.PictureBox_BMS_LowColor.TabStop = False
        '
        'NumericUpDown_BMS_CellMax
        '
        Me.NumericUpDown_BMS_CellMax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_CellRange_Max", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown_BMS_CellMax.Location = New System.Drawing.Point(69, 32)
        Me.NumericUpDown_BMS_CellMax.Maximum = New Decimal(New Integer() {144, 0, 0, 0})
        Me.NumericUpDown_BMS_CellMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_BMS_CellMax.Name = "NumericUpDown_BMS_CellMax"
        Me.NumericUpDown_BMS_CellMax.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown_BMS_CellMax.TabIndex = 5
        Me.NumericUpDown_BMS_CellMax.Value = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_CellRange_Max
        '
        'NumericUpDown_BMS_VoltageMax
        '
        Me.NumericUpDown_BMS_VoltageMax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_VoltageRange_Max", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown_BMS_VoltageMax.DecimalPlaces = 2
        Me.NumericUpDown_BMS_VoltageMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_BMS_VoltageMax.Location = New System.Drawing.Point(308, 32)
        Me.NumericUpDown_BMS_VoltageMax.Maximum = New Decimal(New Integer() {42, 0, 0, 65536})
        Me.NumericUpDown_BMS_VoltageMax.Minimum = New Decimal(New Integer() {28, 0, 0, 65536})
        Me.NumericUpDown_BMS_VoltageMax.Name = "NumericUpDown_BMS_VoltageMax"
        Me.NumericUpDown_BMS_VoltageMax.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown_BMS_VoltageMax.TabIndex = 11
        Me.NumericUpDown_BMS_VoltageMax.Value = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_VoltageRange_Max
        '
        'ComboBox_BMS_CellRange
        '
        Me.ComboBox_BMS_CellRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_BMS_CellRange.FormattingEnabled = True
        Me.ComboBox_BMS_CellRange.Items.AddRange(New Object() {"BMS 1", "BMS 2", "BMS 3", "BMS 4", "BMS 5", "BMS 6", "BMS 7", "BMS 8", "BMS 9", "BMS 10", "BMS 11", "BMS 12", "All", "Custom"})
        Me.ComboBox_BMS_CellRange.Location = New System.Drawing.Point(129, 31)
        Me.ComboBox_BMS_CellRange.MaxDropDownItems = 14
        Me.ComboBox_BMS_CellRange.Name = "ComboBox_BMS_CellRange"
        Me.ComboBox_BMS_CellRange.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox_BMS_CellRange.TabIndex = 6
        '
        'NumericUpDown_BMS_VoltageMin
        '
        Me.NumericUpDown_BMS_VoltageMin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.UoP_Telemetry_GUI.My.MySettings.Default, "BMS_VoltageRange_Min", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown_BMS_VoltageMin.DecimalPlaces = 2
        Me.NumericUpDown_BMS_VoltageMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_BMS_VoltageMin.Location = New System.Drawing.Point(248, 32)
        Me.NumericUpDown_BMS_VoltageMin.Maximum = New Decimal(New Integer() {42, 0, 0, 65536})
        Me.NumericUpDown_BMS_VoltageMin.Minimum = New Decimal(New Integer() {28, 0, 0, 65536})
        Me.NumericUpDown_BMS_VoltageMin.Name = "NumericUpDown_BMS_VoltageMin"
        Me.NumericUpDown_BMS_VoltageMin.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown_BMS_VoltageMin.TabIndex = 10
        Me.NumericUpDown_BMS_VoltageMin.Value = Global.UoP_Telemetry_GUI.My.MySettings.Default.BMS_VoltageRange_Min
        '
        'Label_BMS_VoltageRange
        '
        Me.Label_BMS_VoltageRange.AutoSize = True
        Me.Label_BMS_VoltageRange.Location = New System.Drawing.Point(245, 16)
        Me.Label_BMS_VoltageRange.Name = "Label_BMS_VoltageRange"
        Me.Label_BMS_VoltageRange.Size = New System.Drawing.Size(81, 13)
        Me.Label_BMS_VoltageRange.TabIndex = 9
        Me.Label_BMS_VoltageRange.Text = "Voltage Range:"
        '
        'Chart_BMS
        '
        Me.Chart_BMS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea6.AxisX.InterlacedColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisX.Interval = 1.0R
        ChartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea6.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.IsInterlaced = True
        ChartArea6.AxisX.IsStartedFromZero = False
        ChartArea6.AxisX.LabelStyle.Format = "###"
        ChartArea6.AxisX.LabelStyle.Interval = 1.0R
        ChartArea6.AxisX.MajorGrid.Interval = 12.0R
        ChartArea6.AxisX.MajorGrid.IntervalOffset = 0R
        ChartArea6.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.MajorTickMark.Interval = 6.0R
        ChartArea6.AxisX.MajorTickMark.IntervalOffset = -1.0R
        ChartArea6.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.MajorTickMark.Size = 1.5!
        ChartArea6.AxisX.Maximum = 144.0R
        ChartArea6.AxisX.Minimum = 1.0R
        ChartArea6.AxisX.MinorTickMark.Enabled = True
        ChartArea6.AxisX.MinorTickMark.Interval = 2.0R
        ChartArea6.AxisX.MinorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisX.MinorTickMark.Size = 0.5!
        ChartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea6.AxisY.Interval = 0.2R
        ChartArea6.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea6.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisY.IsStartedFromZero = False
        ChartArea6.AxisY.MajorGrid.Interval = 0.2R
        ChartArea6.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisY.MajorTickMark.Enabled = False
        ChartArea6.AxisY.MajorTickMark.Interval = 0.2R
        ChartArea6.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisY.MajorTickMark.Size = 0.5!
        ChartArea6.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None
        ChartArea6.AxisY.Maximum = 4.2R
        ChartArea6.AxisY.Minimum = 2.8R
        ChartArea6.AxisY.MinorTickMark.Enabled = True
        ChartArea6.AxisY.MinorTickMark.Interval = 0.1R
        ChartArea6.AxisY.MinorTickMark.Size = 0.5!
        ChartArea6.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea6.Name = "ChartArea_BMS"
        Me.Chart_BMS.ChartAreas.Add(ChartArea6)
        Me.Chart_BMS.Location = New System.Drawing.Point(0, 67)
        Me.Chart_BMS.Name = "Chart_BMS"
        Series1.ChartArea = "ChartArea_BMS"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series1.IsXValueIndexed = True
        Series1.Name = "Series_BMS_Voltages"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32
        Series1.YValuesPerPoint = 6
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Me.Chart_BMS.Series.Add(Series1)
        Me.Chart_BMS.Size = New System.Drawing.Size(1306, 581)
        Me.Chart_BMS.TabIndex = 0
        Me.Chart_BMS.Text = "Chart_BMS"
        '
        'TabPage_CAN
        '
        Me.TabPage_CAN.Controls.Add(Me.GroupBox_CAN_Outcoming)
        Me.TabPage_CAN.Controls.Add(Me.ProgressBar_CAN_Load)
        Me.TabPage_CAN.Controls.Add(Me.Label_CAN_Incoming)
        Me.TabPage_CAN.Controls.Add(Me.ListView_CAN)
        Me.TabPage_CAN.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_CAN.Name = "TabPage_CAN"
        Me.TabPage_CAN.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CAN.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_CAN.TabIndex = 3
        Me.TabPage_CAN.Text = "CAN"
        Me.TabPage_CAN.UseVisualStyleBackColor = True
        '
        'GroupBox_CAN_Outcoming
        '
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_MessageID)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.RadioButton_CAN_Binary)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Button_BrakeStop)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.RadioButton_CAN_Decimal)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Button_CAN_BuzzerStop)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.RadioButton_CAN_Hex)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Button_CAN_BrakeStart)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_MessageID)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Button_CAN_BuzzerStart)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte0)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.CheckBox_CAN_Warn)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte1)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Button_CAN_Send)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte2)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Button_CAN_Clear)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte3)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte7)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte4)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte6)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte5)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte2)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte6)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte5)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.TextBox_CAN_Byte7)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte4)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte0)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte3)
        Me.GroupBox_CAN_Outcoming.Controls.Add(Me.Label_CAN_Byte1)
        Me.GroupBox_CAN_Outcoming.Location = New System.Drawing.Point(475, 3)
        Me.GroupBox_CAN_Outcoming.Name = "GroupBox_CAN_Outcoming"
        Me.GroupBox_CAN_Outcoming.Size = New System.Drawing.Size(601, 295)
        Me.GroupBox_CAN_Outcoming.TabIndex = 64
        Me.GroupBox_CAN_Outcoming.TabStop = False
        Me.GroupBox_CAN_Outcoming.Text = "Outcoming CAN"
        '
        'Label_CAN_MessageID
        '
        Me.Label_CAN_MessageID.AutoSize = True
        Me.Label_CAN_MessageID.Location = New System.Drawing.Point(6, 16)
        Me.Label_CAN_MessageID.Name = "Label_CAN_MessageID"
        Me.Label_CAN_MessageID.Size = New System.Drawing.Size(67, 13)
        Me.Label_CAN_MessageID.TabIndex = 34
        Me.Label_CAN_MessageID.Text = "Message ID:"
        '
        'RadioButton_CAN_Binary
        '
        Me.RadioButton_CAN_Binary.AutoSize = True
        Me.RadioButton_CAN_Binary.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.CAN_Binary
        Me.RadioButton_CAN_Binary.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "CAN_Binary", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton_CAN_Binary.Location = New System.Drawing.Point(9, 214)
        Me.RadioButton_CAN_Binary.Name = "RadioButton_CAN_Binary"
        Me.RadioButton_CAN_Binary.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton_CAN_Binary.TabIndex = 52
        Me.RadioButton_CAN_Binary.Text = "Binary"
        Me.RadioButton_CAN_Binary.UseVisualStyleBackColor = True
        '
        'Button_BrakeStop
        '
        Me.Button_BrakeStop.Location = New System.Drawing.Point(490, 231)
        Me.Button_BrakeStop.Name = "Button_BrakeStop"
        Me.Button_BrakeStop.Size = New System.Drawing.Size(85, 23)
        Me.Button_BrakeStop.TabIndex = 62
        Me.Button_BrakeStop.Text = "Brake Off"
        Me.Button_BrakeStop.UseVisualStyleBackColor = True
        '
        'RadioButton_CAN_Decimal
        '
        Me.RadioButton_CAN_Decimal.AutoSize = True
        Me.RadioButton_CAN_Decimal.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.CAN_Decimal
        Me.RadioButton_CAN_Decimal.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "CAN_Decimal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton_CAN_Decimal.Location = New System.Drawing.Point(9, 237)
        Me.RadioButton_CAN_Decimal.Name = "RadioButton_CAN_Decimal"
        Me.RadioButton_CAN_Decimal.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton_CAN_Decimal.TabIndex = 53
        Me.RadioButton_CAN_Decimal.TabStop = True
        Me.RadioButton_CAN_Decimal.Text = "Decimal"
        Me.RadioButton_CAN_Decimal.UseVisualStyleBackColor = True
        '
        'Button_CAN_BuzzerStop
        '
        Me.Button_CAN_BuzzerStop.Location = New System.Drawing.Point(490, 123)
        Me.Button_CAN_BuzzerStop.Name = "Button_CAN_BuzzerStop"
        Me.Button_CAN_BuzzerStop.Size = New System.Drawing.Size(85, 23)
        Me.Button_CAN_BuzzerStop.TabIndex = 61
        Me.Button_CAN_BuzzerStop.Text = "Buzzer Off"
        Me.Button_CAN_BuzzerStop.UseVisualStyleBackColor = True
        '
        'RadioButton_CAN_Hex
        '
        Me.RadioButton_CAN_Hex.AutoSize = True
        Me.RadioButton_CAN_Hex.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.CAN_Hex
        Me.RadioButton_CAN_Hex.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "CAN_Hex", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton_CAN_Hex.Location = New System.Drawing.Point(9, 260)
        Me.RadioButton_CAN_Hex.Name = "RadioButton_CAN_Hex"
        Me.RadioButton_CAN_Hex.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton_CAN_Hex.TabIndex = 54
        Me.RadioButton_CAN_Hex.Text = "Hex"
        Me.RadioButton_CAN_Hex.UseVisualStyleBackColor = True
        '
        'Button_CAN_BrakeStart
        '
        Me.Button_CAN_BrakeStart.Location = New System.Drawing.Point(490, 185)
        Me.Button_CAN_BrakeStart.Name = "Button_CAN_BrakeStart"
        Me.Button_CAN_BrakeStart.Size = New System.Drawing.Size(85, 23)
        Me.Button_CAN_BrakeStart.TabIndex = 60
        Me.Button_CAN_BrakeStart.Text = "Brake On"
        Me.Button_CAN_BrakeStart.UseVisualStyleBackColor = True
        '
        'TextBox_CAN_MessageID
        '
        Me.TextBox_CAN_MessageID.Location = New System.Drawing.Point(9, 32)
        Me.TextBox_CAN_MessageID.MaxLength = 4
        Me.TextBox_CAN_MessageID.Name = "TextBox_CAN_MessageID"
        Me.TextBox_CAN_MessageID.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_MessageID.TabIndex = 35
        Me.TextBox_CAN_MessageID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_CAN_BuzzerStart
        '
        Me.Button_CAN_BuzzerStart.Location = New System.Drawing.Point(490, 78)
        Me.Button_CAN_BuzzerStart.Name = "Button_CAN_BuzzerStart"
        Me.Button_CAN_BuzzerStart.Size = New System.Drawing.Size(85, 23)
        Me.Button_CAN_BuzzerStart.TabIndex = 58
        Me.Button_CAN_BuzzerStart.Text = "Buzzer On"
        Me.Button_CAN_BuzzerStart.UseVisualStyleBackColor = True
        '
        'TextBox_CAN_Byte0
        '
        Me.TextBox_CAN_Byte0.Location = New System.Drawing.Point(9, 71)
        Me.TextBox_CAN_Byte0.MaxLength = 3
        Me.TextBox_CAN_Byte0.Name = "TextBox_CAN_Byte0"
        Me.TextBox_CAN_Byte0.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte0.TabIndex = 36
        Me.TextBox_CAN_Byte0.Text = "-"
        Me.TextBox_CAN_Byte0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox_CAN_Warn
        '
        Me.CheckBox_CAN_Warn.AutoSize = True
        Me.CheckBox_CAN_Warn.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.CAN_Warn
        Me.CheckBox_CAN_Warn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_CAN_Warn.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "CAN_Warn", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox_CAN_Warn.Location = New System.Drawing.Point(163, 237)
        Me.CheckBox_CAN_Warn.Name = "CheckBox_CAN_Warn"
        Me.CheckBox_CAN_Warn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_CAN_Warn.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox_CAN_Warn.TabIndex = 57
        Me.CheckBox_CAN_Warn.Text = "Warn"
        Me.CheckBox_CAN_Warn.UseVisualStyleBackColor = True
        '
        'TextBox_CAN_Byte1
        '
        Me.TextBox_CAN_Byte1.Location = New System.Drawing.Point(125, 71)
        Me.TextBox_CAN_Byte1.MaxLength = 3
        Me.TextBox_CAN_Byte1.Name = "TextBox_CAN_Byte1"
        Me.TextBox_CAN_Byte1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte1.TabIndex = 37
        Me.TextBox_CAN_Byte1.Text = "-"
        Me.TextBox_CAN_Byte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_CAN_Send
        '
        Me.Button_CAN_Send.Location = New System.Drawing.Point(132, 254)
        Me.Button_CAN_Send.Name = "Button_CAN_Send"
        Me.Button_CAN_Send.Size = New System.Drawing.Size(93, 23)
        Me.Button_CAN_Send.TabIndex = 56
        Me.Button_CAN_Send.Text = "Send"
        Me.Button_CAN_Send.UseVisualStyleBackColor = True
        '
        'TextBox_CAN_Byte2
        '
        Me.TextBox_CAN_Byte2.Location = New System.Drawing.Point(9, 110)
        Me.TextBox_CAN_Byte2.MaxLength = 3
        Me.TextBox_CAN_Byte2.Name = "TextBox_CAN_Byte2"
        Me.TextBox_CAN_Byte2.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte2.TabIndex = 38
        Me.TextBox_CAN_Byte2.Text = "-"
        Me.TextBox_CAN_Byte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_CAN_Clear
        '
        Me.Button_CAN_Clear.Location = New System.Drawing.Point(149, 214)
        Me.Button_CAN_Clear.Name = "Button_CAN_Clear"
        Me.Button_CAN_Clear.Size = New System.Drawing.Size(76, 23)
        Me.Button_CAN_Clear.TabIndex = 55
        Me.Button_CAN_Clear.Text = "Clear"
        Me.Button_CAN_Clear.UseVisualStyleBackColor = True
        '
        'TextBox_CAN_Byte3
        '
        Me.TextBox_CAN_Byte3.Location = New System.Drawing.Point(125, 110)
        Me.TextBox_CAN_Byte3.MaxLength = 3
        Me.TextBox_CAN_Byte3.Name = "TextBox_CAN_Byte3"
        Me.TextBox_CAN_Byte3.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte3.TabIndex = 39
        Me.TextBox_CAN_Byte3.Text = "-"
        Me.TextBox_CAN_Byte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_CAN_Byte7
        '
        Me.Label_CAN_Byte7.AutoSize = True
        Me.Label_CAN_Byte7.Location = New System.Drawing.Point(122, 172)
        Me.Label_CAN_Byte7.Name = "Label_CAN_Byte7"
        Me.Label_CAN_Byte7.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte7.TabIndex = 51
        Me.Label_CAN_Byte7.Text = "Byte 7:"
        '
        'TextBox_CAN_Byte4
        '
        Me.TextBox_CAN_Byte4.Location = New System.Drawing.Point(9, 149)
        Me.TextBox_CAN_Byte4.MaxLength = 3
        Me.TextBox_CAN_Byte4.Name = "TextBox_CAN_Byte4"
        Me.TextBox_CAN_Byte4.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte4.TabIndex = 40
        Me.TextBox_CAN_Byte4.Text = "-"
        Me.TextBox_CAN_Byte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_CAN_Byte6
        '
        Me.Label_CAN_Byte6.AutoSize = True
        Me.Label_CAN_Byte6.Location = New System.Drawing.Point(6, 172)
        Me.Label_CAN_Byte6.Name = "Label_CAN_Byte6"
        Me.Label_CAN_Byte6.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte6.TabIndex = 50
        Me.Label_CAN_Byte6.Text = "Byte 6:"
        '
        'TextBox_CAN_Byte5
        '
        Me.TextBox_CAN_Byte5.Location = New System.Drawing.Point(125, 149)
        Me.TextBox_CAN_Byte5.MaxLength = 3
        Me.TextBox_CAN_Byte5.Name = "TextBox_CAN_Byte5"
        Me.TextBox_CAN_Byte5.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte5.TabIndex = 41
        Me.TextBox_CAN_Byte5.Text = "-"
        Me.TextBox_CAN_Byte5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_CAN_Byte2
        '
        Me.Label_CAN_Byte2.AutoSize = True
        Me.Label_CAN_Byte2.Location = New System.Drawing.Point(6, 94)
        Me.Label_CAN_Byte2.Name = "Label_CAN_Byte2"
        Me.Label_CAN_Byte2.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte2.TabIndex = 49
        Me.Label_CAN_Byte2.Text = "Byte 2:"
        '
        'TextBox_CAN_Byte6
        '
        Me.TextBox_CAN_Byte6.Location = New System.Drawing.Point(9, 188)
        Me.TextBox_CAN_Byte6.MaxLength = 3
        Me.TextBox_CAN_Byte6.Name = "TextBox_CAN_Byte6"
        Me.TextBox_CAN_Byte6.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte6.TabIndex = 42
        Me.TextBox_CAN_Byte6.Text = "-"
        Me.TextBox_CAN_Byte6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_CAN_Byte5
        '
        Me.Label_CAN_Byte5.AutoSize = True
        Me.Label_CAN_Byte5.Location = New System.Drawing.Point(122, 133)
        Me.Label_CAN_Byte5.Name = "Label_CAN_Byte5"
        Me.Label_CAN_Byte5.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte5.TabIndex = 48
        Me.Label_CAN_Byte5.Text = "Byte 5:"
        '
        'TextBox_CAN_Byte7
        '
        Me.TextBox_CAN_Byte7.Location = New System.Drawing.Point(125, 187)
        Me.TextBox_CAN_Byte7.MaxLength = 3
        Me.TextBox_CAN_Byte7.Name = "TextBox_CAN_Byte7"
        Me.TextBox_CAN_Byte7.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_CAN_Byte7.TabIndex = 43
        Me.TextBox_CAN_Byte7.Text = "-"
        Me.TextBox_CAN_Byte7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_CAN_Byte4
        '
        Me.Label_CAN_Byte4.AutoSize = True
        Me.Label_CAN_Byte4.Location = New System.Drawing.Point(6, 133)
        Me.Label_CAN_Byte4.Name = "Label_CAN_Byte4"
        Me.Label_CAN_Byte4.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte4.TabIndex = 47
        Me.Label_CAN_Byte4.Text = "Byte 4:"
        '
        'Label_CAN_Byte0
        '
        Me.Label_CAN_Byte0.AutoSize = True
        Me.Label_CAN_Byte0.Location = New System.Drawing.Point(6, 55)
        Me.Label_CAN_Byte0.Name = "Label_CAN_Byte0"
        Me.Label_CAN_Byte0.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte0.TabIndex = 44
        Me.Label_CAN_Byte0.Text = "Byte 0:"
        '
        'Label_CAN_Byte3
        '
        Me.Label_CAN_Byte3.AutoSize = True
        Me.Label_CAN_Byte3.Location = New System.Drawing.Point(122, 94)
        Me.Label_CAN_Byte3.Name = "Label_CAN_Byte3"
        Me.Label_CAN_Byte3.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte3.TabIndex = 46
        Me.Label_CAN_Byte3.Text = "Byte 3:"
        '
        'Label_CAN_Byte1
        '
        Me.Label_CAN_Byte1.AutoSize = True
        Me.Label_CAN_Byte1.Location = New System.Drawing.Point(122, 55)
        Me.Label_CAN_Byte1.Name = "Label_CAN_Byte1"
        Me.Label_CAN_Byte1.Size = New System.Drawing.Size(40, 13)
        Me.Label_CAN_Byte1.TabIndex = 45
        Me.Label_CAN_Byte1.Text = "Byte 1:"
        '
        'ProgressBar_CAN_Load
        '
        Me.ProgressBar_CAN_Load.Location = New System.Drawing.Point(87, 3)
        Me.ProgressBar_CAN_Load.Name = "ProgressBar_CAN_Load"
        Me.ProgressBar_CAN_Load.Size = New System.Drawing.Size(382, 13)
        Me.ProgressBar_CAN_Load.TabIndex = 63
        '
        'Label_CAN_Incoming
        '
        Me.Label_CAN_Incoming.AutoSize = True
        Me.Label_CAN_Incoming.Location = New System.Drawing.Point(3, 3)
        Me.Label_CAN_Incoming.Name = "Label_CAN_Incoming"
        Me.Label_CAN_Incoming.Size = New System.Drawing.Size(78, 13)
        Me.Label_CAN_Incoming.TabIndex = 32
        Me.Label_CAN_Incoming.Text = "Incoming CAN:"
        '
        'ListView_CAN
        '
        Me.ListView_CAN.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView_CAN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_CAN.AutoArrange = False
        Me.ListView_CAN.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView_CAN.FullRowSelect = True
        Me.ListView_CAN.GridLines = True
        Me.ListView_CAN.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_CAN.Location = New System.Drawing.Point(6, 19)
        Me.ListView_CAN.Name = "ListView_CAN"
        Me.ListView_CAN.ShowItemToolTips = True
        Me.ListView_CAN.Size = New System.Drawing.Size(463, 626)
        Me.ListView_CAN.TabIndex = 31
        Me.ListView_CAN.UseCompatibleStateImageBehavior = False
        Me.ListView_CAN.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Length"
        Me.ColumnHeader2.Width = 58
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cycle Time"
        Me.ColumnHeader7.Width = 74
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Count"
        Me.ColumnHeader8.Width = 81
        '
        'TabPage_Configuration
        '
        Me.TabPage_Configuration.Controls.Add(Me.GroupBox_Config_BMS)
        Me.TabPage_Configuration.Controls.Add(Me.GroupBox_Config_FrontNode)
        Me.TabPage_Configuration.Controls.Add(Me.GroupBox_Config_BackNode)
        Me.TabPage_Configuration.Controls.Add(Me.GroupBox_Config_ECU)
        Me.TabPage_Configuration.Controls.Add(Me.GroupBox_Config_Fusebox)
        Me.TabPage_Configuration.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Configuration.Name = "TabPage_Configuration"
        Me.TabPage_Configuration.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_Configuration.TabIndex = 6
        Me.TabPage_Configuration.Text = "Configuration"
        Me.TabPage_Configuration.UseVisualStyleBackColor = True
        '
        'GroupBox_Config_BMS
        '
        Me.GroupBox_Config_BMS.Location = New System.Drawing.Point(1127, 196)
        Me.GroupBox_Config_BMS.Name = "GroupBox_Config_BMS"
        Me.GroupBox_Config_BMS.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_Config_BMS.TabIndex = 4
        Me.GroupBox_Config_BMS.TabStop = False
        Me.GroupBox_Config_BMS.Text = "BMS"
        '
        'GroupBox_Config_FrontNode
        '
        Me.GroupBox_Config_FrontNode.Location = New System.Drawing.Point(1127, 34)
        Me.GroupBox_Config_FrontNode.Name = "GroupBox_Config_FrontNode"
        Me.GroupBox_Config_FrontNode.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_Config_FrontNode.TabIndex = 3
        Me.GroupBox_Config_FrontNode.TabStop = False
        Me.GroupBox_Config_FrontNode.Text = "Front Node"
        '
        'GroupBox_Config_BackNode
        '
        Me.GroupBox_Config_BackNode.Location = New System.Drawing.Point(851, 196)
        Me.GroupBox_Config_BackNode.Name = "GroupBox_Config_BackNode"
        Me.GroupBox_Config_BackNode.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_Config_BackNode.TabIndex = 2
        Me.GroupBox_Config_BackNode.TabStop = False
        Me.GroupBox_Config_BackNode.Text = "Back Node"
        '
        'GroupBox_Config_ECU
        '
        Me.GroupBox_Config_ECU.Location = New System.Drawing.Point(851, 34)
        Me.GroupBox_Config_ECU.Name = "GroupBox_Config_ECU"
        Me.GroupBox_Config_ECU.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_Config_ECU.TabIndex = 1
        Me.GroupBox_Config_ECU.TabStop = False
        Me.GroupBox_Config_ECU.Text = "ECU"
        '
        'GroupBox_Config_Fusebox
        '
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.Button_Config_Fusebox_Request)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.Button_Config_Fusebox_Send)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.TextBox_Config_Fusebox_SelectiveSampling)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.NumericUpDown_Config_Fusebox_Telemetry2TX)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.NumericUpDown_Config_Fusebox_TelemetryTX)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.NumericUpDown_Config_Fusebox_CANInterval)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.CheckBox_Config_Fusebox_CANForward)
        Me.GroupBox_Config_Fusebox.Controls.Add(Me.CheckBox_Config_Fusebox_TelemetryEnabled)
        Me.GroupBox_Config_Fusebox.Location = New System.Drawing.Point(180, 129)
        Me.GroupBox_Config_Fusebox.Name = "GroupBox_Config_Fusebox"
        Me.GroupBox_Config_Fusebox.Size = New System.Drawing.Size(463, 348)
        Me.GroupBox_Config_Fusebox.TabIndex = 0
        Me.GroupBox_Config_Fusebox.TabStop = False
        Me.GroupBox_Config_Fusebox.Text = "Fusebox"
        '
        'Button_Config_Fusebox_Request
        '
        Me.Button_Config_Fusebox_Request.Location = New System.Drawing.Point(264, 250)
        Me.Button_Config_Fusebox_Request.Name = "Button_Config_Fusebox_Request"
        Me.Button_Config_Fusebox_Request.Size = New System.Drawing.Size(75, 23)
        Me.Button_Config_Fusebox_Request.TabIndex = 8
        Me.Button_Config_Fusebox_Request.Text = "Request"
        Me.Button_Config_Fusebox_Request.UseVisualStyleBackColor = True
        '
        'Button_Config_Fusebox_Send
        '
        Me.Button_Config_Fusebox_Send.Location = New System.Drawing.Point(264, 221)
        Me.Button_Config_Fusebox_Send.Name = "Button_Config_Fusebox_Send"
        Me.Button_Config_Fusebox_Send.Size = New System.Drawing.Size(75, 23)
        Me.Button_Config_Fusebox_Send.TabIndex = 7
        Me.Button_Config_Fusebox_Send.Text = "Send"
        Me.Button_Config_Fusebox_Send.UseVisualStyleBackColor = True
        '
        'TextBox_Config_Fusebox_SelectiveSampling
        '
        Me.TextBox_Config_Fusebox_SelectiveSampling.Location = New System.Drawing.Point(69, 147)
        Me.TextBox_Config_Fusebox_SelectiveSampling.Name = "TextBox_Config_Fusebox_SelectiveSampling"
        Me.TextBox_Config_Fusebox_SelectiveSampling.Size = New System.Drawing.Size(133, 20)
        Me.TextBox_Config_Fusebox_SelectiveSampling.TabIndex = 5
        Me.TextBox_Config_Fusebox_SelectiveSampling.Text = "127"
        '
        'NumericUpDown_Config_Fusebox_Telemetry2TX
        '
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX.Location = New System.Drawing.Point(69, 198)
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX.Name = "NumericUpDown_Config_Fusebox_Telemetry2TX"
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX.TabIndex = 4
        Me.NumericUpDown_Config_Fusebox_Telemetry2TX.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_Config_Fusebox_TelemetryTX
        '
        Me.NumericUpDown_Config_Fusebox_TelemetryTX.Location = New System.Drawing.Point(69, 172)
        Me.NumericUpDown_Config_Fusebox_TelemetryTX.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown_Config_Fusebox_TelemetryTX.Name = "NumericUpDown_Config_Fusebox_TelemetryTX"
        Me.NumericUpDown_Config_Fusebox_TelemetryTX.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_Config_Fusebox_TelemetryTX.TabIndex = 3
        Me.NumericUpDown_Config_Fusebox_TelemetryTX.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'NumericUpDown_Config_Fusebox_CANInterval
        '
        Me.NumericUpDown_Config_Fusebox_CANInterval.Location = New System.Drawing.Point(69, 122)
        Me.NumericUpDown_Config_Fusebox_CANInterval.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown_Config_Fusebox_CANInterval.Name = "NumericUpDown_Config_Fusebox_CANInterval"
        Me.NumericUpDown_Config_Fusebox_CANInterval.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_Config_Fusebox_CANInterval.TabIndex = 2
        Me.NumericUpDown_Config_Fusebox_CANInterval.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'CheckBox_Config_Fusebox_CANForward
        '
        Me.CheckBox_Config_Fusebox_CANForward.AutoSize = True
        Me.CheckBox_Config_Fusebox_CANForward.Location = New System.Drawing.Point(69, 99)
        Me.CheckBox_Config_Fusebox_CANForward.Name = "CheckBox_Config_Fusebox_CANForward"
        Me.CheckBox_Config_Fusebox_CANForward.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox_Config_Fusebox_CANForward.TabIndex = 1
        Me.CheckBox_Config_Fusebox_CANForward.Text = "CAN"
        Me.CheckBox_Config_Fusebox_CANForward.UseVisualStyleBackColor = True
        '
        'CheckBox_Config_Fusebox_TelemetryEnabled
        '
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.AutoSize = True
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.Checked = True
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.Location = New System.Drawing.Point(69, 76)
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.Name = "CheckBox_Config_Fusebox_TelemetryEnabled"
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.TabIndex = 0
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.Text = "Telemetry"
        Me.CheckBox_Config_Fusebox_TelemetryEnabled.UseVisualStyleBackColor = True
        '
        'TabPage_Logging
        '
        Me.TabPage_Logging.Controls.Add(Me.Button_Logging_Reload)
        Me.TabPage_Logging.Controls.Add(Me.Button_Logging_Delete)
        Me.TabPage_Logging.Controls.Add(Me.Button_Logging_Download)
        Me.TabPage_Logging.Controls.Add(Me.Label_Logging_Logs)
        Me.TabPage_Logging.Controls.Add(Me.ListBox_Logging_Logs)
        Me.TabPage_Logging.Controls.Add(Me.CheckBox_Logging_Delimiter)
        Me.TabPage_Logging.Controls.Add(Me.Button_BMSLog_StartStop)
        Me.TabPage_Logging.Controls.Add(Me.Button_TelemetryLog_StartStop)
        Me.TabPage_Logging.Controls.Add(Me.CheckBox_AutoStartLog)
        Me.TabPage_Logging.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Logging.Name = "TabPage_Logging"
        Me.TabPage_Logging.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Logging.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_Logging.TabIndex = 5
        Me.TabPage_Logging.Text = "Logging"
        Me.TabPage_Logging.UseVisualStyleBackColor = True
        '
        'Button_Logging_Reload
        '
        Me.Button_Logging_Reload.Location = New System.Drawing.Point(901, 364)
        Me.Button_Logging_Reload.Name = "Button_Logging_Reload"
        Me.Button_Logging_Reload.Size = New System.Drawing.Size(75, 23)
        Me.Button_Logging_Reload.TabIndex = 49
        Me.Button_Logging_Reload.Text = "Reload"
        Me.Button_Logging_Reload.UseVisualStyleBackColor = True
        '
        'Button_Logging_Delete
        '
        Me.Button_Logging_Delete.Location = New System.Drawing.Point(901, 335)
        Me.Button_Logging_Delete.Name = "Button_Logging_Delete"
        Me.Button_Logging_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Logging_Delete.TabIndex = 48
        Me.Button_Logging_Delete.Text = "Delete"
        Me.Button_Logging_Delete.UseVisualStyleBackColor = True
        '
        'Button_Logging_Download
        '
        Me.Button_Logging_Download.Location = New System.Drawing.Point(901, 306)
        Me.Button_Logging_Download.Name = "Button_Logging_Download"
        Me.Button_Logging_Download.Size = New System.Drawing.Size(75, 23)
        Me.Button_Logging_Download.TabIndex = 47
        Me.Button_Logging_Download.Text = "Download"
        Me.Button_Logging_Download.UseVisualStyleBackColor = True
        '
        'Label_Logging_Logs
        '
        Me.Label_Logging_Logs.AutoSize = True
        Me.Label_Logging_Logs.Location = New System.Drawing.Point(381, 132)
        Me.Label_Logging_Logs.Name = "Label_Logging_Logs"
        Me.Label_Logging_Logs.Size = New System.Drawing.Size(79, 13)
        Me.Label_Logging_Logs.TabIndex = 46
        Me.Label_Logging_Logs.Text = "Available Logs:"
        '
        'ListBox_Logging_Logs
        '
        Me.ListBox_Logging_Logs.FormattingEnabled = True
        Me.ListBox_Logging_Logs.Location = New System.Drawing.Point(384, 148)
        Me.ListBox_Logging_Logs.Name = "ListBox_Logging_Logs"
        Me.ListBox_Logging_Logs.Size = New System.Drawing.Size(323, 368)
        Me.ListBox_Logging_Logs.TabIndex = 45
        '
        'CheckBox_Logging_Delimiter
        '
        Me.CheckBox_Logging_Delimiter.AutoSize = True
        Me.CheckBox_Logging_Delimiter.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.UseLogSemicolon
        Me.CheckBox_Logging_Delimiter.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "UseLogSemicolon", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox_Logging_Delimiter.Location = New System.Drawing.Point(103, 134)
        Me.CheckBox_Logging_Delimiter.Name = "CheckBox_Logging_Delimiter"
        Me.CheckBox_Logging_Delimiter.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox_Logging_Delimiter.TabIndex = 44
        Me.CheckBox_Logging_Delimiter.Text = "Use Semicolor"
        Me.CheckBox_Logging_Delimiter.UseVisualStyleBackColor = True
        '
        'Button_BMSLog_StartStop
        '
        Me.Button_BMSLog_StartStop.Location = New System.Drawing.Point(169, 83)
        Me.Button_BMSLog_StartStop.Name = "Button_BMSLog_StartStop"
        Me.Button_BMSLog_StartStop.Size = New System.Drawing.Size(109, 23)
        Me.Button_BMSLog_StartStop.TabIndex = 43
        Me.Button_BMSLog_StartStop.Text = "Start BMS Log"
        Me.Button_BMSLog_StartStop.UseVisualStyleBackColor = True
        '
        'Button_TelemetryLog_StartStop
        '
        Me.Button_TelemetryLog_StartStop.Location = New System.Drawing.Point(30, 83)
        Me.Button_TelemetryLog_StartStop.Name = "Button_TelemetryLog_StartStop"
        Me.Button_TelemetryLog_StartStop.Size = New System.Drawing.Size(109, 23)
        Me.Button_TelemetryLog_StartStop.TabIndex = 42
        Me.Button_TelemetryLog_StartStop.Text = "Start Telemetry Log"
        Me.Button_TelemetryLog_StartStop.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoStartLog
        '
        Me.CheckBox_AutoStartLog.AutoSize = True
        Me.CheckBox_AutoStartLog.Checked = Global.UoP_Telemetry_GUI.My.MySettings.Default.AutoStartLog
        Me.CheckBox_AutoStartLog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UoP_Telemetry_GUI.My.MySettings.Default, "AutoStartLog", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox_AutoStartLog.Location = New System.Drawing.Point(103, 42)
        Me.CheckBox_AutoStartLog.Name = "CheckBox_AutoStartLog"
        Me.CheckBox_AutoStartLog.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox_AutoStartLog.TabIndex = 41
        Me.CheckBox_AutoStartLog.Text = "Auto Start Logging"
        Me.CheckBox_AutoStartLog.UseVisualStyleBackColor = True
        '
        'TabPage_Admin
        '
        Me.TabPage_Admin.Controls.Add(Me.CheckedListBox_ChartSeries)
        Me.TabPage_Admin.Controls.Add(Me.Button_Admin_Process)
        Me.TabPage_Admin.Controls.Add(Me.TextBox_Admin_RX)
        Me.TabPage_Admin.Controls.Add(Me.Button_Break)
        Me.TabPage_Admin.Controls.Add(Me.Button_RandomBMS)
        Me.TabPage_Admin.Controls.Add(Me.CheckBox_RandomTelemetry)
        Me.TabPage_Admin.Controls.Add(Me.CheckBox_Plotting)
        Me.TabPage_Admin.Controls.Add(Me.Label6)
        Me.TabPage_Admin.Controls.Add(Me.Label_Interval)
        Me.TabPage_Admin.Controls.Add(Me.ListView_Telemetry)
        Me.TabPage_Admin.Controls.Add(Me.Label_LostPackets)
        Me.TabPage_Admin.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Admin.Name = "TabPage_Admin"
        Me.TabPage_Admin.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_Admin.TabIndex = 1
        Me.TabPage_Admin.Text = "Admin"
        Me.TabPage_Admin.UseVisualStyleBackColor = True
        '
        'Button_Admin_Process
        '
        Me.Button_Admin_Process.Location = New System.Drawing.Point(642, 365)
        Me.Button_Admin_Process.Name = "Button_Admin_Process"
        Me.Button_Admin_Process.Size = New System.Drawing.Size(75, 23)
        Me.Button_Admin_Process.TabIndex = 47
        Me.Button_Admin_Process.Text = "Process RX"
        Me.Button_Admin_Process.UseVisualStyleBackColor = True
        '
        'TextBox_Admin_RX
        '
        Me.TextBox_Admin_RX.Location = New System.Drawing.Point(62, 339)
        Me.TextBox_Admin_RX.Name = "TextBox_Admin_RX"
        Me.TextBox_Admin_RX.Size = New System.Drawing.Size(655, 20)
        Me.TextBox_Admin_RX.TabIndex = 46
        '
        'Button_Break
        '
        Me.Button_Break.Location = New System.Drawing.Point(341, 281)
        Me.Button_Break.Name = "Button_Break"
        Me.Button_Break.Size = New System.Drawing.Size(75, 23)
        Me.Button_Break.TabIndex = 45
        Me.Button_Break.Text = "Break"
        Me.Button_Break.UseVisualStyleBackColor = True
        '
        'Button_RandomBMS
        '
        Me.Button_RandomBMS.Location = New System.Drawing.Point(523, 242)
        Me.Button_RandomBMS.Name = "Button_RandomBMS"
        Me.Button_RandomBMS.Size = New System.Drawing.Size(75, 23)
        Me.Button_RandomBMS.TabIndex = 44
        Me.Button_RandomBMS.Text = "Random BMS"
        Me.Button_RandomBMS.UseVisualStyleBackColor = True
        '
        'CheckBox_RandomTelemetry
        '
        Me.CheckBox_RandomTelemetry.AutoSize = True
        Me.CheckBox_RandomTelemetry.Location = New System.Drawing.Point(125, 157)
        Me.CheckBox_RandomTelemetry.Name = "CheckBox_RandomTelemetry"
        Me.CheckBox_RandomTelemetry.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox_RandomTelemetry.TabIndex = 43
        Me.CheckBox_RandomTelemetry.Text = "Random Telemetry"
        Me.CheckBox_RandomTelemetry.UseVisualStyleBackColor = True
        '
        'CheckBox_Plotting
        '
        Me.CheckBox_Plotting.AutoSize = True
        Me.CheckBox_Plotting.Checked = True
        Me.CheckBox_Plotting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Plotting.Location = New System.Drawing.Point(523, 188)
        Me.CheckBox_Plotting.Name = "CheckBox_Plotting"
        Me.CheckBox_Plotting.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox_Plotting.TabIndex = 41
        Me.CheckBox_Plotting.Text = "Plotting"
        Me.CheckBox_Plotting.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(720, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Raw Telemetry Values:"
        '
        'Label_Interval
        '
        Me.Label_Interval.AutoSize = True
        Me.Label_Interval.Location = New System.Drawing.Point(96, 247)
        Me.Label_Interval.Name = "Label_Interval"
        Me.Label_Interval.Size = New System.Drawing.Size(73, 13)
        Me.Label_Interval.TabIndex = 32
        Me.Label_Interval.Text = "Interval: 10ms"
        '
        'ListView_Telemetry
        '
        Me.ListView_Telemetry.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView_Telemetry.AutoArrange = False
        Me.ListView_Telemetry.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView_Telemetry.FullRowSelect = True
        Me.ListView_Telemetry.GridLines = True
        Me.ListView_Telemetry.Location = New System.Drawing.Point(723, 34)
        Me.ListView_Telemetry.Name = "ListView_Telemetry"
        Me.ListView_Telemetry.ShowItemToolTips = True
        Me.ListView_Telemetry.Size = New System.Drawing.Size(318, 577)
        Me.ListView_Telemetry.TabIndex = 30
        Me.ListView_Telemetry.UseCompatibleStateImageBehavior = False
        Me.ListView_Telemetry.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Field Name"
        Me.ColumnHeader4.Width = 142
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type"
        Me.ColumnHeader5.Width = 82
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Value"
        Me.ColumnHeader6.Width = 80
        '
        'Label_LostPackets
        '
        Me.Label_LostPackets.AutoSize = True
        Me.Label_LostPackets.Location = New System.Drawing.Point(96, 224)
        Me.Label_LostPackets.Name = "Label_LostPackets"
        Me.Label_LostPackets.Size = New System.Drawing.Size(81, 13)
        Me.Label_LostPackets.TabIndex = 31
        Me.Label_LostPackets.Text = "Lost Packets: 0"
        '
        'TabPage_Connection
        '
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_Sockets)
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_Connection)
        Me.TabPage_Connection.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Connection.Name = "TabPage_Connection"
        Me.TabPage_Connection.Size = New System.Drawing.Size(1357, 648)
        Me.TabPage_Connection.TabIndex = 7
        Me.TabPage_Connection.Text = "Connection"
        Me.TabPage_Connection.UseVisualStyleBackColor = True
        '
        'GroupBox_Sockets
        '
        Me.GroupBox_Sockets.Controls.Add(Me.Label_Sockets_Clients)
        Me.GroupBox_Sockets.Controls.Add(Me.Button_Sockets_Clear)
        Me.GroupBox_Sockets.Controls.Add(Me.Label_Sockets_Info)
        Me.GroupBox_Sockets.Controls.Add(Me.CheckBox_Sockets_Forward)
        Me.GroupBox_Sockets.Controls.Add(Me.ListBox_Sockets_Clients)
        Me.GroupBox_Sockets.Controls.Add(Me.Button_Sockets_Connect)
        Me.GroupBox_Sockets.Controls.Add(Me.TextBox_Sockets_ClientIP)
        Me.GroupBox_Sockets.Location = New System.Drawing.Point(8, 91)
        Me.GroupBox_Sockets.Name = "GroupBox_Sockets"
        Me.GroupBox_Sockets.Size = New System.Drawing.Size(312, 146)
        Me.GroupBox_Sockets.TabIndex = 13
        Me.GroupBox_Sockets.TabStop = False
        Me.GroupBox_Sockets.Text = "Sockets"
        '
        'Label_Sockets_Clients
        '
        Me.Label_Sockets_Clients.AutoSize = True
        Me.Label_Sockets_Clients.Location = New System.Drawing.Point(6, 16)
        Me.Label_Sockets_Clients.Name = "Label_Sockets_Clients"
        Me.Label_Sockets_Clients.Size = New System.Drawing.Size(41, 13)
        Me.Label_Sockets_Clients.TabIndex = 16
        Me.Label_Sockets_Clients.Text = "Clients:"
        '
        'Button_Sockets_Clear
        '
        Me.Button_Sockets_Clear.Location = New System.Drawing.Point(231, 87)
        Me.Button_Sockets_Clear.Name = "Button_Sockets_Clear"
        Me.Button_Sockets_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Sockets_Clear.TabIndex = 15
        Me.Button_Sockets_Clear.Text = "Clear"
        Me.Button_Sockets_Clear.UseVisualStyleBackColor = True
        '
        'Label_Sockets_Info
        '
        Me.Label_Sockets_Info.AutoSize = True
        Me.Label_Sockets_Info.Location = New System.Drawing.Point(156, 16)
        Me.Label_Sockets_Info.Name = "Label_Sockets_Info"
        Me.Label_Sockets_Info.Size = New System.Drawing.Size(49, 13)
        Me.Label_Sockets_Info.TabIndex = 14
        Me.Label_Sockets_Info.Text = "Local IP:"
        '
        'CheckBox_Sockets_Forward
        '
        Me.CheckBox_Sockets_Forward.AutoSize = True
        Me.CheckBox_Sockets_Forward.Location = New System.Drawing.Point(242, 123)
        Me.CheckBox_Sockets_Forward.Name = "CheckBox_Sockets_Forward"
        Me.CheckBox_Sockets_Forward.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_Sockets_Forward.TabIndex = 13
        Me.CheckBox_Sockets_Forward.Text = "Forward"
        Me.CheckBox_Sockets_Forward.UseVisualStyleBackColor = True
        '
        'ListBox_Sockets_Clients
        '
        Me.ListBox_Sockets_Clients.FormattingEnabled = True
        Me.ListBox_Sockets_Clients.Location = New System.Drawing.Point(6, 32)
        Me.ListBox_Sockets_Clients.Name = "ListBox_Sockets_Clients"
        Me.ListBox_Sockets_Clients.Size = New System.Drawing.Size(147, 108)
        Me.ListBox_Sockets_Clients.TabIndex = 12
        '
        'Button_Sockets_Connect
        '
        Me.Button_Sockets_Connect.Location = New System.Drawing.Point(231, 58)
        Me.Button_Sockets_Connect.Name = "Button_Sockets_Connect"
        Me.Button_Sockets_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Sockets_Connect.TabIndex = 10
        Me.Button_Sockets_Connect.Text = "Connect"
        Me.Button_Sockets_Connect.UseVisualStyleBackColor = True
        '
        'TextBox_Sockets_ClientIP
        '
        Me.TextBox_Sockets_ClientIP.Location = New System.Drawing.Point(159, 32)
        Me.TextBox_Sockets_ClientIP.Name = "TextBox_Sockets_ClientIP"
        Me.TextBox_Sockets_ClientIP.Size = New System.Drawing.Size(147, 20)
        Me.TextBox_Sockets_ClientIP.TabIndex = 11
        '
        'GroupBox_Connection
        '
        Me.GroupBox_Connection.Controls.Add(Me.Label_SerialPing)
        Me.GroupBox_Connection.Controls.Add(Me.Button_Ping)
        Me.GroupBox_Connection.Controls.Add(Me.Label_Serial)
        Me.GroupBox_Connection.Controls.Add(Me.ComboBox_Ports)
        Me.GroupBox_Connection.Controls.Add(Me.Button_Connect)
        Me.GroupBox_Connection.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox_Connection.Name = "GroupBox_Connection"
        Me.GroupBox_Connection.Size = New System.Drawing.Size(290, 82)
        Me.GroupBox_Connection.TabIndex = 8
        Me.GroupBox_Connection.TabStop = False
        Me.GroupBox_Connection.Text = "Connection"
        '
        'Label_SerialPing
        '
        Me.Label_SerialPing.AutoSize = True
        Me.Label_SerialPing.Location = New System.Drawing.Point(6, 58)
        Me.Label_SerialPing.Name = "Label_SerialPing"
        Me.Label_SerialPing.Size = New System.Drawing.Size(0, 13)
        Me.Label_SerialPing.TabIndex = 10
        '
        'Button_Ping
        '
        Me.Button_Ping.Location = New System.Drawing.Point(209, 53)
        Me.Button_Ping.Name = "Button_Ping"
        Me.Button_Ping.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ping.TabIndex = 9
        Me.Button_Ping.Text = "Ping"
        Me.Button_Ping.UseVisualStyleBackColor = True
        '
        'Label_Serial
        '
        Me.Label_Serial.AutoSize = True
        Me.Label_Serial.Location = New System.Drawing.Point(6, 29)
        Me.Label_Serial.Name = "Label_Serial"
        Me.Label_Serial.Size = New System.Drawing.Size(36, 13)
        Me.Label_Serial.TabIndex = 3
        Me.Label_Serial.Text = "Serial:"
        '
        'ComboBox_Ports
        '
        Me.ComboBox_Ports.FormattingEnabled = True
        Me.ComboBox_Ports.Location = New System.Drawing.Point(48, 25)
        Me.ComboBox_Ports.Name = "ComboBox_Ports"
        Me.ComboBox_Ports.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox_Ports.TabIndex = 4
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(209, 24)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connect.TabIndex = 1
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'Timer_RandomTelemetry
        '
        Me.Timer_RandomTelemetry.Interval = 50
        '
        'ColorDialog_BMS
        '
        Me.ColorDialog_BMS.AnyColor = True
        Me.ColorDialog_BMS.FullOpen = True
        '
        'CheckedListBox_ChartSeries
        '
        Me.CheckedListBox_ChartSeries.FormattingEnabled = True
        Me.CheckedListBox_ChartSeries.Location = New System.Drawing.Point(1047, 34)
        Me.CheckedListBox_ChartSeries.Name = "CheckedListBox_ChartSeries"
        Me.CheckedListBox_ChartSeries.Size = New System.Drawing.Size(215, 574)
        Me.CheckedListBox_ChartSeries.TabIndex = 48
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 696)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1256, 714)
        Me.Name = "Main"
        Me.Text = " UoP7e Telemetry"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage_General.ResumeLayout(False)
        Me.TabPage_General.PerformLayout()
        CType(Me.PictureBox_Car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Plotting.ResumeLayout(False)
        Me.TabPage_Plotting.PerformLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_BMS.ResumeLayout(False)
        Me.GroupBox_BMS_Settings.ResumeLayout(False)
        Me.GroupBox_BMS_Settings.PerformLayout()
        CType(Me.PictureBox_BMS_HighColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_BMS_CellMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_BMS_LowColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_BMS_CellMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_BMS_VoltageMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_BMS_VoltageMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_BMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_CAN.ResumeLayout(False)
        Me.TabPage_CAN.PerformLayout()
        Me.GroupBox_CAN_Outcoming.ResumeLayout(False)
        Me.GroupBox_CAN_Outcoming.PerformLayout()
        Me.TabPage_Configuration.ResumeLayout(False)
        Me.GroupBox_Config_Fusebox.ResumeLayout(False)
        Me.GroupBox_Config_Fusebox.PerformLayout()
        CType(Me.NumericUpDown_Config_Fusebox_Telemetry2TX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Config_Fusebox_TelemetryTX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Config_Fusebox_CANInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Logging.ResumeLayout(False)
        Me.TabPage_Logging.PerformLayout()
        Me.TabPage_Admin.ResumeLayout(False)
        Me.TabPage_Admin.PerformLayout()
        Me.TabPage_Connection.ResumeLayout(False)
        Me.GroupBox_Sockets.ResumeLayout(False)
        Me.GroupBox_Sockets.PerformLayout()
        Me.GroupBox_Connection.ResumeLayout(False)
        Me.GroupBox_Connection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel_SerialStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_SerialInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Updates As ToolStripStatusLabel
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Timer_Serial As Timer
    Friend WithEvents Timer_SendQueue As Timer
    Friend WithEvents Timer_Status As Timer
    Friend WithEvents Timer_GUIUpdate As Timer
    Friend WithEvents ToolStripStatusLabel_Spring As ToolStripStatusLabel
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage_General As TabPage
    Friend WithEvents TabPage_Admin As TabPage
    Friend WithEvents PictureBox_Car As PictureBox
    Friend WithEvents Label_Power As Label
    Friend WithEvents Label_Current As Label
    Friend WithEvents Label_Voltage As Label
    Friend WithEvents Label_Throttle As Label
    Friend WithEvents ProgressBar_Throttle As ProgressBar
    Friend WithEvents Label_BrakeFront As Label
    Friend WithEvents ProgressBar_BrakeFront As ProgressBar
    Friend WithEvents Label_BrakeRear As Label
    Friend WithEvents ProgressBar_BrakeRear As ProgressBar
    Friend WithEvents Label_RPM_FrontRight As Label
    Friend WithEvents Label_RPM_RearRight As Label
    Friend WithEvents Label_RPM_FrontLeft As Label
    Friend WithEvents Label_RPM_RearLeft As Label
    Friend WithEvents ListView_VCU As ListView
    Friend WithEvents ColumnHeader_VCUFlag As ColumnHeader
    Friend WithEvents ColumnHeader_VCUValue As ColumnHeader
    Friend WithEvents ListView_BMS As ListView
    Friend WithEvents ColumnHeader_BMSPack As ColumnHeader
    Friend WithEvents ColumnHeader_BMS_Voltage_Min As ColumnHeader
    Friend WithEvents ColumnHeader_BMS_Voltage_Max As ColumnHeader
    Friend WithEvents ColumnHeader_BMS_Temp_Min As ColumnHeader
    Friend WithEvents ColumnHeader_BMS_Temp_Max As ColumnHeader
    Friend WithEvents TabPage_CAN As TabPage
    Friend WithEvents ListView_Telemetry As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label_Interval As Label
    Friend WithEvents Label_LostPackets As Label
    Friend WithEvents TabPage_Plotting As TabPage
    Friend WithEvents Timer_RandomTelemetry As Timer
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents CheckBox_AutoScroll As CheckBox
    Friend WithEvents TabPage_BMS As TabPage
    Friend WithEvents CheckBox_Plotting As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox_RandomTelemetry As CheckBox
    Friend WithEvents Label_MotorTemp_FrontRight As Label
    Friend WithEvents Label_MotorTemp_FrontLeft As Label
    Friend WithEvents TabPage_Logging As TabPage
    Friend WithEvents ListView_CAN As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label_CAN_Incoming As Label
    Friend WithEvents CheckBox_AutoScale As CheckBox
    Friend WithEvents Chart_BMS As DataVisualization.Charting.Chart
    Friend WithEvents Label_BMS_CellRange As Label
    Friend WithEvents ComboBox_BMS_CellRange As ComboBox
    Friend WithEvents NumericUpDown_BMS_CellMax As NumericUpDown
    Friend WithEvents NumericUpDown_BMS_CellMin As NumericUpDown
    Friend WithEvents CheckBox_BMS_PlotTemperatures As CheckBox
    Friend WithEvents CheckBox_BMS_PlotVoltages As CheckBox
    Friend WithEvents NumericUpDown_BMS_VoltageMax As NumericUpDown
    Friend WithEvents NumericUpDown_BMS_VoltageMin As NumericUpDown
    Friend WithEvents Label_BMS_VoltageRange As Label
    Friend WithEvents CheckBox_BMS_Coloring As CheckBox
    Friend WithEvents PictureBox_BMS_HighColor As PictureBox
    Friend WithEvents PictureBox_BMS_LowColor As PictureBox
    Friend WithEvents ColorDialog_BMS As ColorDialog
    Friend WithEvents GroupBox_BMS_Settings As GroupBox
    Friend WithEvents CheckBox_AutoStartLog As CheckBox
    Friend WithEvents Button_TelemetryLog_StartStop As Button
    Friend WithEvents Button_BMSLog_StartStop As Button
    Friend WithEvents TabPage_Configuration As TabPage
    Friend WithEvents TabPage_Connection As TabPage
    Friend WithEvents GroupBox_Connection As GroupBox
    Friend WithEvents Label_Serial As Label
    Friend WithEvents ComboBox_Ports As ComboBox
    Friend WithEvents Button_Connect As Button
    Friend WithEvents Button_Ping As Button
    Friend WithEvents Timer_Generic As Timer
    Friend WithEvents Label_SerialPing As Label
    Friend WithEvents Button_RandomBMS As Button
    Friend WithEvents ToolStripStatusLabel_TelemetryLogging As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_BMSLogging As ToolStripStatusLabel
    Friend WithEvents RadioButton_CAN_Hex As RadioButton
    Friend WithEvents RadioButton_CAN_Decimal As RadioButton
    Friend WithEvents RadioButton_CAN_Binary As RadioButton
    Friend WithEvents Label_CAN_Byte7 As Label
    Friend WithEvents Label_CAN_Byte6 As Label
    Friend WithEvents Label_CAN_Byte2 As Label
    Friend WithEvents Label_CAN_Byte5 As Label
    Friend WithEvents Label_CAN_Byte4 As Label
    Friend WithEvents Label_CAN_Byte3 As Label
    Friend WithEvents Label_CAN_Byte1 As Label
    Friend WithEvents Label_CAN_Byte0 As Label
    Friend WithEvents TextBox_CAN_Byte7 As TextBox
    Friend WithEvents TextBox_CAN_Byte6 As TextBox
    Friend WithEvents TextBox_CAN_Byte5 As TextBox
    Friend WithEvents TextBox_CAN_Byte4 As TextBox
    Friend WithEvents TextBox_CAN_Byte3 As TextBox
    Friend WithEvents TextBox_CAN_Byte2 As TextBox
    Friend WithEvents TextBox_CAN_Byte1 As TextBox
    Friend WithEvents TextBox_CAN_Byte0 As TextBox
    Friend WithEvents TextBox_CAN_MessageID As TextBox
    Friend WithEvents Label_CAN_MessageID As Label
    Friend WithEvents Button_CAN_Clear As Button
    Friend WithEvents CheckBox_CAN_Warn As CheckBox
    Friend WithEvents Button_CAN_Send As Button
    Friend WithEvents Button_Break As Button
    Friend WithEvents GroupBox_Config_BMS As GroupBox
    Friend WithEvents GroupBox_Config_FrontNode As GroupBox
    Friend WithEvents GroupBox_Config_BackNode As GroupBox
    Friend WithEvents GroupBox_Config_ECU As GroupBox
    Friend WithEvents GroupBox_Config_Fusebox As GroupBox
    Friend WithEvents CheckBox_Logging_Delimiter As CheckBox
    Friend WithEvents CheckBox_Plotting_Sync As CheckBox
    Friend WithEvents Button_BrakeStop As Button
    Friend WithEvents Button_CAN_BuzzerStop As Button
    Friend WithEvents Button_CAN_BrakeStart As Button
    Friend WithEvents Button_CAN_BuzzerStart As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Button_Admin_Process As Button
    Friend WithEvents TextBox_Admin_RX As TextBox
    Friend WithEvents Button_Config_Fusebox_Send As Button
    Friend WithEvents TextBox_Config_Fusebox_SelectiveSampling As TextBox
    Friend WithEvents NumericUpDown_Config_Fusebox_Telemetry2TX As NumericUpDown
    Friend WithEvents NumericUpDown_Config_Fusebox_TelemetryTX As NumericUpDown
    Friend WithEvents NumericUpDown_Config_Fusebox_CANInterval As NumericUpDown
    Friend WithEvents CheckBox_Config_Fusebox_CANForward As CheckBox
    Friend WithEvents CheckBox_Config_Fusebox_TelemetryEnabled As CheckBox
    Friend WithEvents Button_Config_Fusebox_Request As Button
    Friend WithEvents ProgressBar_CAN_Load As ProgressBar
    Friend WithEvents Button_Logging_Reload As Button
    Friend WithEvents Button_Logging_Delete As Button
    Friend WithEvents Button_Logging_Download As Button
    Friend WithEvents Label_Logging_Logs As Label
    Friend WithEvents ListBox_Logging_Logs As ListBox
    Friend WithEvents Label_BrakeTravel As Label
    Friend WithEvents ProgressBar_BrakeTravel As ProgressBar
    Friend WithEvents Label_MotorTemp_RearLeft As Label
    Friend WithEvents Label_MotorTemp_RearRight As Label
    Friend WithEvents Label_IGBT_FrontLeft As Label
    Friend WithEvents Label_IGBT_FrontRight As Label
    Friend WithEvents Label_IGBT_RearRight As Label
    Friend WithEvents Label_IGBT_RearLeft As Label
    Friend WithEvents Label_Gearbox_RearRight As Label
    Friend WithEvents Label_Gearbox_FrontRight As Label
    Friend WithEvents Label_Gearbox_FrontLeft As Label
    Friend WithEvents Label_Gearbox_RearLeft As Label
    Friend WithEvents Label_CoolantTemp_InverterOut As Label
    Friend WithEvents Label_CoolantTemp_InverterIn As Label
    Friend WithEvents Label_CoolantTemp_MotorOut As Label
    Friend WithEvents Label_CoolantTemp_MotorIn As Label
    Friend WithEvents Label_PlateTemp As Label
    Friend WithEvents GroupBox_CAN_Outcoming As GroupBox
    Friend WithEvents Label_SuspensionStrain_RearRight As Label
    Friend WithEvents Label_SuspensionTravel_RearRight As Label
    Friend WithEvents Label_SuspensionStrain_RearLeft As Label
    Friend WithEvents Label_SuspensionTravel_RearLeft As Label
    Friend WithEvents Label_SuspensionStrain_FrontRight As Label
    Friend WithEvents Label_SuspensionTravel_FrontRight As Label
    Friend WithEvents Label_SuspensionStrain_FrontLeft As Label
    Friend WithEvents Label_SuspensionTravel_FrontLeft As Label
    Friend WithEvents GroupBox_Sockets As GroupBox
    Friend WithEvents Button_Sockets_Connect As Button
    Friend WithEvents TextBox_Sockets_ClientIP As TextBox
    Friend WithEvents ListBox_Sockets_Clients As ListBox
    Friend WithEvents CheckBox_Sockets_Forward As CheckBox
    Friend WithEvents Label_Sockets_Info As Label
    Friend WithEvents Button_Sockets_Clear As Button
    Friend WithEvents Label_Sockets_Clients As Label
    Friend WithEvents Label_SteeringAngle As Label
    Friend WithEvents Label_Demanded_RearRight As Label
    Friend WithEvents Label_Actual_RearLeft As Label
    Friend WithEvents Label_Demanded_RearLeft As Label
    Friend WithEvents Label_Actual_FrontRight As Label
    Friend WithEvents Label_Demanded_FrontRight As Label
    Friend WithEvents Label_Actual_FrontLeft As Label
    Friend WithEvents Label_Demanded_FrontLeft As Label
    Friend WithEvents Label_Actual_RearRight As Label
    Friend WithEvents CheckedListBox_ChartSeries As CheckedListBox
End Class

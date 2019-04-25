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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Left", "0 V", "0 V", "0 C", "0 C"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Right", "0 V", "0 V", "0 C", "0 C"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ETD", "0"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"BMSA", "0"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"MCMS", "0"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"EMA", "0"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CDS", "0"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PLS", "0"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Current", "0"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Coolant In", "0 C"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Coolant Out", "0 C"}, -1)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Gearbox", "0 C"}, -1)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"IGBT", "0 C"}, -1)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Motor", "0 C"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_SerialInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Spring = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Updates = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_Serial = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_SendQueue = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Status = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_GUIUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.Label_Temps_BrakeRight = New System.Windows.Forms.Label()
        Me.Label_Temps_BrakeLeft = New System.Windows.Forms.Label()
        Me.ListView_BMS = New System.Windows.Forms.ListView()
        Me.ColumnHeader_BMSPack = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Voltage_Min = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Voltage_Max = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Temp_Min = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_BMS_Temp_Max = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView_VCU = New System.Windows.Forms.ListView()
        Me.ColumnHeader_VCUFlag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_VCUValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView_Temperature = New System.Windows.Forms.ListView()
        Me.ColumnHeader_TempSensor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_TempValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label_Power = New System.Windows.Forms.Label()
        Me.Label_RPM = New System.Windows.Forms.Label()
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
        Me.CheckBox_PlotRPM = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotFrontRightRPM = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotFrontLeftRPM = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoScale = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotBrakeRight = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotBrakeLeft = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotGearboxTemp = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotIGBTTemp = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotMotorTemp = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotCoolantOut = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotCoolantIn = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotBrakeRear = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotBrakeFront = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PlotThrottle = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoScroll = New System.Windows.Forms.CheckBox()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage_BMS = New System.Windows.Forms.TabPage()
        Me.GroupBox_BMS_Settings = New System.Windows.Forms.GroupBox()
        Me.CheckBox_BMS_PlotVoltages = New System.Windows.Forms.CheckBox()
        Me.Button_RandomBMS = New System.Windows.Forms.Button()
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
        Me.Label_CAN_Incoming = New System.Windows.Forms.Label()
        Me.ListView_CAN = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage_Configuration = New System.Windows.Forms.TabPage()
        Me.TabPage_Logging = New System.Windows.Forms.TabPage()
        Me.Button_BMSLog_StartStop = New System.Windows.Forms.Button()
        Me.Button_TelemetryLog_StartStop = New System.Windows.Forms.Button()
        Me.CheckBox_AutoStartLog = New System.Windows.Forms.CheckBox()
        Me.TabPage_Admin = New System.Windows.Forms.TabPage()
        Me.CheckBox_RandomTelemetry = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Plotting = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_Interval = New System.Windows.Forms.Label()
        Me.ListView_Telemetry = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label_LostPackets = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage_Connection = New System.Windows.Forms.TabPage()
        Me.GroupBox_Connection = New System.Windows.Forms.GroupBox()
        Me.Label_SerialPing = New System.Windows.Forms.Label()
        Me.Button_Ping = New System.Windows.Forms.Button()
        Me.Label_Serial = New System.Windows.Forms.Label()
        Me.ComboBox_Ports = New System.Windows.Forms.ComboBox()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.Timer_RandomTelemetry = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog_BMS = New System.Windows.Forms.ColorDialog()
        Me.Timer_Generic = New System.Windows.Forms.Timer(Me.components)
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
        Me.TabPage_Logging.SuspendLayout()
        Me.TabPage_Admin.SuspendLayout()
        Me.TabPage_Connection.SuspendLayout()
        Me.GroupBox_Connection.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_Status, Me.ToolStripStatusLabel_SerialInfo, Me.ToolStripStatusLabel_Spring, Me.ToolStripStatusLabel_Updates})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1314, 22)
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel_Status
        '
        Me.ToolStripStatusLabel_Status.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel_Status.Name = "ToolStripStatusLabel_Status"
        Me.ToolStripStatusLabel_Status.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel_Status.Text = "Disconnected"
        '
        'ToolStripStatusLabel_SerialInfo
        '
        Me.ToolStripStatusLabel_SerialInfo.Name = "ToolStripStatusLabel_SerialInfo"
        Me.ToolStripStatusLabel_SerialInfo.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel_SerialInfo.Text = "0 Packets Queued"
        '
        'ToolStripStatusLabel_Spring
        '
        Me.ToolStripStatusLabel_Spring.Name = "ToolStripStatusLabel_Spring"
        Me.ToolStripStatusLabel_Spring.Size = New System.Drawing.Size(981, 17)
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
        Me.TabControl.Size = New System.Drawing.Size(1314, 674)
        Me.TabControl.TabIndex = 27
        '
        'TabPage_General
        '
        Me.TabPage_General.Controls.Add(Me.Label_Temps_BrakeRight)
        Me.TabPage_General.Controls.Add(Me.Label_Temps_BrakeLeft)
        Me.TabPage_General.Controls.Add(Me.ListView_BMS)
        Me.TabPage_General.Controls.Add(Me.ListView_VCU)
        Me.TabPage_General.Controls.Add(Me.ListView_Temperature)
        Me.TabPage_General.Controls.Add(Me.Label_Power)
        Me.TabPage_General.Controls.Add(Me.Label_RPM)
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
        Me.TabPage_General.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_General.TabIndex = 0
        Me.TabPage_General.Text = "General"
        Me.TabPage_General.UseVisualStyleBackColor = True
        '
        'Label_Temps_BrakeRight
        '
        Me.Label_Temps_BrakeRight.AutoSize = True
        Me.Label_Temps_BrakeRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Temps_BrakeRight.Location = New System.Drawing.Point(808, 574)
        Me.Label_Temps_BrakeRight.Name = "Label_Temps_BrakeRight"
        Me.Label_Temps_BrakeRight.Size = New System.Drawing.Size(38, 24)
        Me.Label_Temps_BrakeRight.TabIndex = 20
        Me.Label_Temps_BrakeRight.Text = "0 C"
        '
        'Label_Temps_BrakeLeft
        '
        Me.Label_Temps_BrakeLeft.AutoSize = True
        Me.Label_Temps_BrakeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Temps_BrakeLeft.Location = New System.Drawing.Point(808, 51)
        Me.Label_Temps_BrakeLeft.Name = "Label_Temps_BrakeLeft"
        Me.Label_Temps_BrakeLeft.Size = New System.Drawing.Size(38, 24)
        Me.Label_Temps_BrakeLeft.TabIndex = 19
        Me.Label_Temps_BrakeLeft.Text = "0 C"
        '
        'ListView_BMS
        '
        Me.ListView_BMS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_BMSPack, Me.ColumnHeader_BMS_Voltage_Min, Me.ColumnHeader_BMS_Voltage_Max, Me.ColumnHeader_BMS_Temp_Min, Me.ColumnHeader_BMS_Temp_Max})
        Me.ListView_BMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_BMS.FullRowSelect = True
        Me.ListView_BMS.GridLines = True
        Me.ListView_BMS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_BMS.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView_BMS.Location = New System.Drawing.Point(321, 506)
        Me.ListView_BMS.MaximumSize = New System.Drawing.Size(383, 75)
        Me.ListView_BMS.MinimumSize = New System.Drawing.Size(383, 75)
        Me.ListView_BMS.Name = "ListView_BMS"
        Me.ListView_BMS.Scrollable = False
        Me.ListView_BMS.Size = New System.Drawing.Size(383, 75)
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
        Me.ListView_VCU.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.ListView_VCU.Location = New System.Drawing.Point(406, 239)
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
        'ListView_Temperature
        '
        Me.ListView_Temperature.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_TempSensor, Me.ColumnHeader_TempValue})
        Me.ListView_Temperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Temperature.FullRowSelect = True
        Me.ListView_Temperature.GridLines = True
        Me.ListView_Temperature.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        Me.ListView_Temperature.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14})
        Me.ListView_Temperature.Location = New System.Drawing.Point(399, 13)
        Me.ListView_Temperature.MaximumSize = New System.Drawing.Size(204, 147)
        Me.ListView_Temperature.MinimumSize = New System.Drawing.Size(204, 147)
        Me.ListView_Temperature.Name = "ListView_Temperature"
        Me.ListView_Temperature.Scrollable = False
        Me.ListView_Temperature.Size = New System.Drawing.Size(204, 147)
        Me.ListView_Temperature.TabIndex = 16
        Me.ListView_Temperature.UseCompatibleStateImageBehavior = False
        Me.ListView_Temperature.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_TempSensor
        '
        Me.ColumnHeader_TempSensor.Text = "Sensor"
        Me.ColumnHeader_TempSensor.Width = 96
        '
        'ColumnHeader_TempValue
        '
        Me.ColumnHeader_TempValue.Text = "Temperature"
        Me.ColumnHeader_TempValue.Width = 105
        '
        'Label_Power
        '
        Me.Label_Power.AutoSize = True
        Me.Label_Power.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Power.Location = New System.Drawing.Point(715, 278)
        Me.Label_Power.Name = "Label_Power"
        Me.Label_Power.Size = New System.Drawing.Size(43, 24)
        Me.Label_Power.TabIndex = 15
        Me.Label_Power.Text = "0 W"
        '
        'Label_RPM
        '
        Me.Label_RPM.AutoSize = True
        Me.Label_RPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM.Location = New System.Drawing.Point(715, 242)
        Me.Label_RPM.Name = "Label_RPM"
        Me.Label_RPM.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM.TabIndex = 14
        Me.Label_RPM.Text = "0 RPM"
        '
        'Label_Current
        '
        Me.Label_Current.AutoSize = True
        Me.Label_Current.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Current.Location = New System.Drawing.Point(715, 360)
        Me.Label_Current.Name = "Label_Current"
        Me.Label_Current.Size = New System.Drawing.Size(38, 24)
        Me.Label_Current.TabIndex = 13
        Me.Label_Current.Text = "0 A"
        '
        'Label_Voltage
        '
        Me.Label_Voltage.AutoSize = True
        Me.Label_Voltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Voltage.Location = New System.Drawing.Point(715, 324)
        Me.Label_Voltage.Name = "Label_Voltage"
        Me.Label_Voltage.Size = New System.Drawing.Size(38, 24)
        Me.Label_Voltage.TabIndex = 12
        Me.Label_Voltage.Text = "0 V"
        '
        'Label_Throttle
        '
        Me.Label_Throttle.AutoSize = True
        Me.Label_Throttle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Throttle.Location = New System.Drawing.Point(1064, 338)
        Me.Label_Throttle.Name = "Label_Throttle"
        Me.Label_Throttle.Size = New System.Drawing.Size(54, 20)
        Me.Label_Throttle.TabIndex = 11
        Me.Label_Throttle.Text = "000 %"
        '
        'ProgressBar_Throttle
        '
        Me.ProgressBar_Throttle.Location = New System.Drawing.Point(922, 338)
        Me.ProgressBar_Throttle.Name = "ProgressBar_Throttle"
        Me.ProgressBar_Throttle.Size = New System.Drawing.Size(132, 20)
        Me.ProgressBar_Throttle.TabIndex = 10
        '
        'Label_BrakeFront
        '
        Me.Label_BrakeFront.AutoSize = True
        Me.Label_BrakeFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BrakeFront.Location = New System.Drawing.Point(1064, 281)
        Me.Label_BrakeFront.Name = "Label_BrakeFront"
        Me.Label_BrakeFront.Size = New System.Drawing.Size(65, 20)
        Me.Label_BrakeFront.TabIndex = 9
        Me.Label_BrakeFront.Text = "000 Bar"
        '
        'ProgressBar_BrakeFront
        '
        Me.ProgressBar_BrakeFront.Location = New System.Drawing.Point(922, 281)
        Me.ProgressBar_BrakeFront.Maximum = 200
        Me.ProgressBar_BrakeFront.Name = "ProgressBar_BrakeFront"
        Me.ProgressBar_BrakeFront.Size = New System.Drawing.Size(132, 20)
        Me.ProgressBar_BrakeFront.TabIndex = 8
        '
        'Label_BrakeRear
        '
        Me.Label_BrakeRear.AutoSize = True
        Me.Label_BrakeRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BrakeRear.Location = New System.Drawing.Point(1064, 255)
        Me.Label_BrakeRear.Name = "Label_BrakeRear"
        Me.Label_BrakeRear.Size = New System.Drawing.Size(65, 20)
        Me.Label_BrakeRear.TabIndex = 7
        Me.Label_BrakeRear.Text = "000 Bar"
        '
        'ProgressBar_BrakeRear
        '
        Me.ProgressBar_BrakeRear.Location = New System.Drawing.Point(921, 255)
        Me.ProgressBar_BrakeRear.Maximum = 200
        Me.ProgressBar_BrakeRear.Name = "ProgressBar_BrakeRear"
        Me.ProgressBar_BrakeRear.Size = New System.Drawing.Size(132, 20)
        Me.ProgressBar_BrakeRear.TabIndex = 5
        '
        'Label_RPM_FrontRight
        '
        Me.Label_RPM_FrontRight.AutoSize = True
        Me.Label_RPM_FrontRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_FrontRight.Location = New System.Drawing.Point(808, 550)
        Me.Label_RPM_FrontRight.Name = "Label_RPM_FrontRight"
        Me.Label_RPM_FrontRight.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_FrontRight.TabIndex = 4
        Me.Label_RPM_FrontRight.Text = "0 RPM"
        '
        'Label_RPM_RearRight
        '
        Me.Label_RPM_RearRight.AutoSize = True
        Me.Label_RPM_RearRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_RearRight.Location = New System.Drawing.Point(130, 561)
        Me.Label_RPM_RearRight.Name = "Label_RPM_RearRight"
        Me.Label_RPM_RearRight.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_RearRight.TabIndex = 3
        Me.Label_RPM_RearRight.Text = "0 RPM"
        '
        'Label_RPM_FrontLeft
        '
        Me.Label_RPM_FrontLeft.AutoSize = True
        Me.Label_RPM_FrontLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_FrontLeft.Location = New System.Drawing.Point(808, 27)
        Me.Label_RPM_FrontLeft.Name = "Label_RPM_FrontLeft"
        Me.Label_RPM_FrontLeft.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_FrontLeft.TabIndex = 2
        Me.Label_RPM_FrontLeft.Text = "0 RPM"
        '
        'Label_RPM_RearLeft
        '
        Me.Label_RPM_RearLeft.AutoSize = True
        Me.Label_RPM_RearLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RPM_RearLeft.Location = New System.Drawing.Point(130, 41)
        Me.Label_RPM_RearLeft.Name = "Label_RPM_RearLeft"
        Me.Label_RPM_RearLeft.Size = New System.Drawing.Size(66, 24)
        Me.Label_RPM_RearLeft.TabIndex = 1
        Me.Label_RPM_RearLeft.Text = "0 RPM"
        '
        'PictureBox_Car
        '
        Me.PictureBox_Car.Image = CType(resources.GetObject("PictureBox_Car.Image"), System.Drawing.Image)
        Me.PictureBox_Car.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox_Car.Name = "PictureBox_Car"
        Me.PictureBox_Car.Size = New System.Drawing.Size(1220, 615)
        Me.PictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Car.TabIndex = 0
        Me.PictureBox_Car.TabStop = False
        '
        'TabPage_Plotting
        '
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotRPM)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotFrontRightRPM)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotFrontLeftRPM)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_AutoScale)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotBrakeRight)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotBrakeLeft)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotGearboxTemp)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotIGBTTemp)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotMotorTemp)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotCoolantOut)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotCoolantIn)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotBrakeRear)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotBrakeFront)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_PlotThrottle)
        Me.TabPage_Plotting.Controls.Add(Me.CheckBox_AutoScroll)
        Me.TabPage_Plotting.Controls.Add(Me.Chart)
        Me.TabPage_Plotting.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Plotting.Name = "TabPage_Plotting"
        Me.TabPage_Plotting.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_Plotting.TabIndex = 2
        Me.TabPage_Plotting.Text = "Plotting"
        Me.TabPage_Plotting.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotRPM
        '
        Me.CheckBox_PlotRPM.AutoSize = True
        Me.CheckBox_PlotRPM.Checked = True
        Me.CheckBox_PlotRPM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotRPM.Location = New System.Drawing.Point(1076, 3)
        Me.CheckBox_PlotRPM.Name = "CheckBox_PlotRPM"
        Me.CheckBox_PlotRPM.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox_PlotRPM.TabIndex = 15
        Me.CheckBox_PlotRPM.Text = "RPM"
        Me.CheckBox_PlotRPM.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotFrontRightRPM
        '
        Me.CheckBox_PlotFrontRightRPM.AutoSize = True
        Me.CheckBox_PlotFrontRightRPM.Checked = True
        Me.CheckBox_PlotFrontRightRPM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotFrontRightRPM.Location = New System.Drawing.Point(965, 3)
        Me.CheckBox_PlotFrontRightRPM.Name = "CheckBox_PlotFrontRightRPM"
        Me.CheckBox_PlotFrontRightRPM.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox_PlotFrontRightRPM.TabIndex = 14
        Me.CheckBox_PlotFrontRightRPM.Text = "Front Right RPM"
        Me.CheckBox_PlotFrontRightRPM.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotFrontLeftRPM
        '
        Me.CheckBox_PlotFrontLeftRPM.AutoSize = True
        Me.CheckBox_PlotFrontLeftRPM.Checked = True
        Me.CheckBox_PlotFrontLeftRPM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotFrontLeftRPM.Location = New System.Drawing.Point(861, 3)
        Me.CheckBox_PlotFrontLeftRPM.Name = "CheckBox_PlotFrontLeftRPM"
        Me.CheckBox_PlotFrontLeftRPM.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox_PlotFrontLeftRPM.TabIndex = 13
        Me.CheckBox_PlotFrontLeftRPM.Text = "Front Left RPM"
        Me.CheckBox_PlotFrontLeftRPM.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoScale
        '
        Me.CheckBox_AutoScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_AutoScale.AutoSize = True
        Me.CheckBox_AutoScale.Checked = True
        Me.CheckBox_AutoScale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AutoScale.Location = New System.Drawing.Point(1142, 3)
        Me.CheckBox_AutoScale.Name = "CheckBox_AutoScale"
        Me.CheckBox_AutoScale.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox_AutoScale.TabIndex = 12
        Me.CheckBox_AutoScale.Text = "Auto Scale"
        Me.CheckBox_AutoScale.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotBrakeRight
        '
        Me.CheckBox_PlotBrakeRight.AutoSize = True
        Me.CheckBox_PlotBrakeRight.Checked = True
        Me.CheckBox_PlotBrakeRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotBrakeRight.Location = New System.Drawing.Point(495, 3)
        Me.CheckBox_PlotBrakeRight.Name = "CheckBox_PlotBrakeRight"
        Me.CheckBox_PlotBrakeRight.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox_PlotBrakeRight.TabIndex = 11
        Me.CheckBox_PlotBrakeRight.Text = "Right Brake"
        Me.CheckBox_PlotBrakeRight.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotBrakeLeft
        '
        Me.CheckBox_PlotBrakeLeft.AutoSize = True
        Me.CheckBox_PlotBrakeLeft.Checked = True
        Me.CheckBox_PlotBrakeLeft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotBrakeLeft.Location = New System.Drawing.Point(414, 3)
        Me.CheckBox_PlotBrakeLeft.Name = "CheckBox_PlotBrakeLeft"
        Me.CheckBox_PlotBrakeLeft.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox_PlotBrakeLeft.TabIndex = 10
        Me.CheckBox_PlotBrakeLeft.Text = "Left Brake"
        Me.CheckBox_PlotBrakeLeft.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotGearboxTemp
        '
        Me.CheckBox_PlotGearboxTemp.AutoSize = True
        Me.CheckBox_PlotGearboxTemp.Checked = True
        Me.CheckBox_PlotGearboxTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotGearboxTemp.Location = New System.Drawing.Point(759, 3)
        Me.CheckBox_PlotGearboxTemp.Name = "CheckBox_PlotGearboxTemp"
        Me.CheckBox_PlotGearboxTemp.Size = New System.Drawing.Size(96, 17)
        Me.CheckBox_PlotGearboxTemp.TabIndex = 9
        Me.CheckBox_PlotGearboxTemp.Text = "Gearbox Temp"
        Me.CheckBox_PlotGearboxTemp.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotIGBTTemp
        '
        Me.CheckBox_PlotIGBTTemp.AutoSize = True
        Me.CheckBox_PlotIGBTTemp.Checked = True
        Me.CheckBox_PlotIGBTTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotIGBTTemp.Location = New System.Drawing.Point(672, 3)
        Me.CheckBox_PlotIGBTTemp.Name = "CheckBox_PlotIGBTTemp"
        Me.CheckBox_PlotIGBTTemp.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_PlotIGBTTemp.TabIndex = 8
        Me.CheckBox_PlotIGBTTemp.Text = "IGBT Temp"
        Me.CheckBox_PlotIGBTTemp.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotMotorTemp
        '
        Me.CheckBox_PlotMotorTemp.AutoSize = True
        Me.CheckBox_PlotMotorTemp.Checked = True
        Me.CheckBox_PlotMotorTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotMotorTemp.Location = New System.Drawing.Point(583, 3)
        Me.CheckBox_PlotMotorTemp.Name = "CheckBox_PlotMotorTemp"
        Me.CheckBox_PlotMotorTemp.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox_PlotMotorTemp.TabIndex = 7
        Me.CheckBox_PlotMotorTemp.Text = "Motor Temp"
        Me.CheckBox_PlotMotorTemp.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotCoolantOut
        '
        Me.CheckBox_PlotCoolantOut.AutoSize = True
        Me.CheckBox_PlotCoolantOut.Checked = True
        Me.CheckBox_PlotCoolantOut.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotCoolantOut.Location = New System.Drawing.Point(326, 3)
        Me.CheckBox_PlotCoolantOut.Name = "CheckBox_PlotCoolantOut"
        Me.CheckBox_PlotCoolantOut.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox_PlotCoolantOut.TabIndex = 6
        Me.CheckBox_PlotCoolantOut.Text = "Coolant Out"
        Me.CheckBox_PlotCoolantOut.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotCoolantIn
        '
        Me.CheckBox_PlotCoolantIn.AutoSize = True
        Me.CheckBox_PlotCoolantIn.Checked = True
        Me.CheckBox_PlotCoolantIn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotCoolantIn.Location = New System.Drawing.Point(246, 3)
        Me.CheckBox_PlotCoolantIn.Name = "CheckBox_PlotCoolantIn"
        Me.CheckBox_PlotCoolantIn.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox_PlotCoolantIn.TabIndex = 5
        Me.CheckBox_PlotCoolantIn.Text = "Coolant In"
        Me.CheckBox_PlotCoolantIn.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotBrakeRear
        '
        Me.CheckBox_PlotBrakeRear.AutoSize = True
        Me.CheckBox_PlotBrakeRear.Checked = True
        Me.CheckBox_PlotBrakeRear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotBrakeRear.Location = New System.Drawing.Point(160, 3)
        Me.CheckBox_PlotBrakeRear.Name = "CheckBox_PlotBrakeRear"
        Me.CheckBox_PlotBrakeRear.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox_PlotBrakeRear.TabIndex = 4
        Me.CheckBox_PlotBrakeRear.Text = "Brake Rear"
        Me.CheckBox_PlotBrakeRear.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotBrakeFront
        '
        Me.CheckBox_PlotBrakeFront.AutoSize = True
        Me.CheckBox_PlotBrakeFront.Checked = True
        Me.CheckBox_PlotBrakeFront.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotBrakeFront.Location = New System.Drawing.Point(73, 3)
        Me.CheckBox_PlotBrakeFront.Name = "CheckBox_PlotBrakeFront"
        Me.CheckBox_PlotBrakeFront.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_PlotBrakeFront.TabIndex = 3
        Me.CheckBox_PlotBrakeFront.Text = "Brake Front"
        Me.CheckBox_PlotBrakeFront.UseVisualStyleBackColor = True
        '
        'CheckBox_PlotThrottle
        '
        Me.CheckBox_PlotThrottle.AutoSize = True
        Me.CheckBox_PlotThrottle.Checked = True
        Me.CheckBox_PlotThrottle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_PlotThrottle.Location = New System.Drawing.Point(5, 3)
        Me.CheckBox_PlotThrottle.Name = "CheckBox_PlotThrottle"
        Me.CheckBox_PlotThrottle.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox_PlotThrottle.TabIndex = 2
        Me.CheckBox_PlotThrottle.Text = "Throttle"
        Me.CheckBox_PlotThrottle.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoScroll
        '
        Me.CheckBox_AutoScroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_AutoScroll.AutoSize = True
        Me.CheckBox_AutoScroll.Checked = True
        Me.CheckBox_AutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AutoScroll.Location = New System.Drawing.Point(1226, 3)
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
        ChartArea3.Name = "ChartArea_Temps2"
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
        ChartArea4.Name = "ChartArea_RPM"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Me.Chart.ChartAreas.Add(ChartArea2)
        Me.Chart.ChartAreas.Add(ChartArea3)
        Me.Chart.ChartAreas.Add(ChartArea4)
        Me.Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart.IsSoftShadows = False
        Legend1.DockedToChartArea = "ChartArea_Pedals"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.IsEquallySpacedItems = True
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend1.Name = "Legend_Pedals"
        Legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend1.TextWrapThreshold = 35
        Legend2.DockedToChartArea = "ChartArea_Temps2"
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.IsEquallySpacedItems = True
        Legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend2.Name = "Legend_Temps2"
        Legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend2.TextWrapThreshold = 35
        Legend3.DockedToChartArea = "ChartArea_Temps"
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.IsEquallySpacedItems = True
        Legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend3.Name = "Legend_Temps"
        Legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend3.TextWrapThreshold = 35
        Legend4.DockedToChartArea = "ChartArea_RPM"
        Legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend4.IsEquallySpacedItems = True
        Legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend4.Name = "Legend_RPM"
        Legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend4.TextWrapThreshold = 35
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Legends.Add(Legend2)
        Me.Chart.Legends.Add(Legend3)
        Me.Chart.Legends.Add(Legend4)
        Me.Chart.Location = New System.Drawing.Point(0, 0)
        Me.Chart.Name = "Chart"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea_Pedals"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Color = System.Drawing.Color.LimeGreen
        Series1.CustomProperties = "IsXAxisQuantitative=False"
        Series1.Legend = "Legend_Pedals"
        Series1.LegendText = "Throttle Min: #MIN{D0}%, Max: #MAX{D0}%"
        Series1.LegendToolTip = "The position of the throttle pedal"
        Series1.Name = "Series_Throttle"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea_Pedals"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.Firebrick
        Series2.Legend = "Legend_Pedals"
        Series2.LegendText = "Front Min: #MIN{D0}Bar, Max: #MAX{D0}Bar"
        Series2.LegendToolTip = "The front brake pressure"
        Series2.Name = "Series_BrakeFront"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series3.BorderWidth = 3
        Series3.ChartArea = "ChartArea_Pedals"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series3.Color = System.Drawing.Color.Coral
        Series3.Legend = "Legend_Pedals"
        Series3.LegendText = "Rear Min: #MIN{D0}Bar, Max: #MAX{D0}Bar"
        Series3.LegendToolTip = "The rear brake pressure"
        Series3.Name = "Series_BrakeRear"
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series4.BorderWidth = 3
        Series4.ChartArea = "ChartArea_Temps2"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series4.Color = System.Drawing.Color.Firebrick
        Series4.Legend = "Legend_Temps2"
        Series4.LegendText = "Coolant In Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series4.LegendToolTip = "The input temperature of the coolant"
        Series4.Name = "Series_CoolantIn"
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series5.BorderWidth = 3
        Series5.ChartArea = "ChartArea_Temps2"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series5.Color = System.Drawing.Color.LimeGreen
        Series5.Legend = "Legend_Temps2"
        Series5.LegendText = "Coolant Out Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series5.LegendToolTip = "The output temperature of the coolant"
        Series5.Name = "Series_CoolantOut"
        Series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series6.BorderWidth = 3
        Series6.ChartArea = "ChartArea_Temps2"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series6.Color = System.Drawing.Color.RoyalBlue
        Series6.Legend = "Legend_Temps2"
        Series6.LegendText = "Left Brake Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series6.LegendToolTip = "The temperature of the front left brake caliper"
        Series6.Name = "Series_BrakeLeft"
        Series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series7.BorderWidth = 3
        Series7.ChartArea = "ChartArea_Temps2"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series7.Color = System.Drawing.Color.BlueViolet
        Series7.Legend = "Legend_Temps2"
        Series7.LegendText = "Right Brake Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series7.LegendToolTip = "The temperature of the front right brake caliper"
        Series7.Name = "Series_BrakeRight"
        Series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series7.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series8.BorderWidth = 3
        Series8.ChartArea = "ChartArea_Temps"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series8.Legend = "Legend_Temps"
        Series8.LegendText = "Gearbox Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series8.LegendToolTip = "The temperature of the gearbox"
        Series8.Name = "Series_GearboxTemp"
        Series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series9.BorderWidth = 3
        Series9.ChartArea = "ChartArea_Temps"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series9.Legend = "Legend_Temps"
        Series9.LegendText = "Motor Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series9.LegendToolTip = "The temperature of the motor"
        Series9.Name = "Series_MotorTemp"
        Series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series10.BorderWidth = 3
        Series10.ChartArea = "ChartArea_Temps"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series10.Legend = "Legend_Temps"
        Series10.LegendText = "IGBT Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series10.LegendToolTip = "The temperature of the inverter's IGBTs"
        Series10.Name = "Series_IGBTTemp"
        Series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series10.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series11.BorderWidth = 3
        Series11.ChartArea = "ChartArea_RPM"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series11.Legend = "Legend_RPM"
        Series11.LegendText = "Left Wheel Min: #MIN{D0} RPM, #MAX{D0} RPM"
        Series11.LegendToolTip = "The RPM of the front left wheel"
        Series11.Name = "Series_FrontLeftRPM"
        Series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series12.BorderWidth = 3
        Series12.ChartArea = "ChartArea_RPM"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series12.Legend = "Legend_RPM"
        Series12.LegendText = "Right Wheel Min: #MIN{D0} RPM, #MAX{D0} RPM"
        Series12.LegendToolTip = "The RPM of the front right wheel"
        Series12.Name = "Series_FrontRightRPM"
        Series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series13.BorderWidth = 3
        Series13.ChartArea = "ChartArea_RPM"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series13.Legend = "Legend_RPM"
        Series13.LegendText = "RPM Min: #MIN{D0} RPM, Max: #MAX{D0} RPM"
        Series13.LegendToolTip = "The RPM of the motor"
        Series13.Name = "Series_RPM"
        Series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series13.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.Chart.Series.Add(Series1)
        Me.Chart.Series.Add(Series2)
        Me.Chart.Series.Add(Series3)
        Me.Chart.Series.Add(Series4)
        Me.Chart.Series.Add(Series5)
        Me.Chart.Series.Add(Series6)
        Me.Chart.Series.Add(Series7)
        Me.Chart.Series.Add(Series8)
        Me.Chart.Series.Add(Series9)
        Me.Chart.Series.Add(Series10)
        Me.Chart.Series.Add(Series11)
        Me.Chart.Series.Add(Series12)
        Me.Chart.Series.Add(Series13)
        Me.Chart.Size = New System.Drawing.Size(1306, 648)
        Me.Chart.TabIndex = 0
        Me.Chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'TabPage_BMS
        '
        Me.TabPage_BMS.Controls.Add(Me.GroupBox_BMS_Settings)
        Me.TabPage_BMS.Controls.Add(Me.Chart_BMS)
        Me.TabPage_BMS.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_BMS.Name = "TabPage_BMS"
        Me.TabPage_BMS.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_BMS.TabIndex = 4
        Me.TabPage_BMS.Text = "BMS"
        Me.TabPage_BMS.UseVisualStyleBackColor = True
        '
        'GroupBox_BMS_Settings
        '
        Me.GroupBox_BMS_Settings.Controls.Add(Me.CheckBox_BMS_PlotVoltages)
        Me.GroupBox_BMS_Settings.Controls.Add(Me.Button_RandomBMS)
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
        'Button_RandomBMS
        '
        Me.Button_RandomBMS.Location = New System.Drawing.Point(688, 29)
        Me.Button_RandomBMS.Name = "Button_RandomBMS"
        Me.Button_RandomBMS.Size = New System.Drawing.Size(75, 23)
        Me.Button_RandomBMS.TabIndex = 15
        Me.Button_RandomBMS.Text = "Random"
        Me.Button_RandomBMS.UseVisualStyleBackColor = True
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
        Me.NumericUpDown_BMS_CellMin.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
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
        Me.NumericUpDown_BMS_CellMax.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
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
        Me.ComboBox_BMS_CellRange.Items.AddRange(New Object() {"BMS 1", "BMS 2", "BMS 3", "BMS 4", "BMS 5", "BMS 6", "BMS 7", "BMS 8", "BMS 9", "BMS 10", "BMS 11", "BMS 12", "Left Box", "Right Box", "All", "Custom"})
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
        ChartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea5.AxisX.InterlacedColor = System.Drawing.Color.WhiteSmoke
        ChartArea5.AxisX.Interval = 1.0R
        ChartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea5.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.IsInterlaced = True
        ChartArea5.AxisX.IsStartedFromZero = False
        ChartArea5.AxisX.LabelStyle.Format = "###"
        ChartArea5.AxisX.LabelStyle.Interval = 1.0R
        ChartArea5.AxisX.MajorGrid.Interval = 10.0R
        ChartArea5.AxisX.MajorGrid.IntervalOffset = 0R
        ChartArea5.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.MajorTickMark.Interval = 5.0R
        ChartArea5.AxisX.MajorTickMark.IntervalOffset = -1.0R
        ChartArea5.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.MajorTickMark.Size = 1.5!
        ChartArea5.AxisX.Maximum = 120.0R
        ChartArea5.AxisX.Minimum = 1.0R
        ChartArea5.AxisX.MinorTickMark.Enabled = True
        ChartArea5.AxisX.MinorTickMark.Interval = 2.0R
        ChartArea5.AxisX.MinorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisX.MinorTickMark.Size = 0.5!
        ChartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea5.AxisY.Interval = 0.2R
        ChartArea5.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea5.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisY.IsStartedFromZero = False
        ChartArea5.AxisY.MajorGrid.Interval = 0.2R
        ChartArea5.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisY.MajorTickMark.Enabled = False
        ChartArea5.AxisY.MajorTickMark.Interval = 0.2R
        ChartArea5.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisY.MajorTickMark.Size = 0.5!
        ChartArea5.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None
        ChartArea5.AxisY.Maximum = 4.2R
        ChartArea5.AxisY.Minimum = 2.8R
        ChartArea5.AxisY.MinorTickMark.Enabled = True
        ChartArea5.AxisY.MinorTickMark.Interval = 0.1R
        ChartArea5.AxisY.MinorTickMark.Size = 0.5!
        ChartArea5.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea5.Name = "ChartArea_BMS"
        Me.Chart_BMS.ChartAreas.Add(ChartArea5)
        Me.Chart_BMS.Location = New System.Drawing.Point(0, 67)
        Me.Chart_BMS.Name = "Chart_BMS"
        Series14.ChartArea = "ChartArea_BMS"
        Series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series14.IsXValueIndexed = True
        Series14.Name = "Series_BMS_Voltages"
        Series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32
        Series14.YValuesPerPoint = 6
        Series14.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Me.Chart_BMS.Series.Add(Series14)
        Me.Chart_BMS.Size = New System.Drawing.Size(1306, 581)
        Me.Chart_BMS.TabIndex = 0
        Me.Chart_BMS.Text = "Chart_BMS"
        '
        'TabPage_CAN
        '
        Me.TabPage_CAN.Controls.Add(Me.Label_CAN_Incoming)
        Me.TabPage_CAN.Controls.Add(Me.ListView_CAN)
        Me.TabPage_CAN.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_CAN.Name = "TabPage_CAN"
        Me.TabPage_CAN.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CAN.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_CAN.TabIndex = 3
        Me.TabPage_CAN.Text = "CAN"
        Me.TabPage_CAN.UseVisualStyleBackColor = True
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
        Me.ListView_CAN.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView_CAN.FullRowSelect = True
        Me.ListView_CAN.GridLines = True
        Me.ListView_CAN.Location = New System.Drawing.Point(6, 19)
        Me.ListView_CAN.Name = "ListView_CAN"
        Me.ListView_CAN.ShowItemToolTips = True
        Me.ListView_CAN.Size = New System.Drawing.Size(484, 626)
        Me.ListView_CAN.TabIndex = 31
        Me.ListView_CAN.UseCompatibleStateImageBehavior = False
        Me.ListView_CAN.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Length"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data"
        Me.ColumnHeader3.Width = 293
        '
        'TabPage_Configuration
        '
        Me.TabPage_Configuration.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Configuration.Name = "TabPage_Configuration"
        Me.TabPage_Configuration.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_Configuration.TabIndex = 6
        Me.TabPage_Configuration.Text = "Configuration"
        Me.TabPage_Configuration.UseVisualStyleBackColor = True
        '
        'TabPage_Logging
        '
        Me.TabPage_Logging.Controls.Add(Me.Button_BMSLog_StartStop)
        Me.TabPage_Logging.Controls.Add(Me.Button_TelemetryLog_StartStop)
        Me.TabPage_Logging.Controls.Add(Me.CheckBox_AutoStartLog)
        Me.TabPage_Logging.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Logging.Name = "TabPage_Logging"
        Me.TabPage_Logging.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Logging.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_Logging.TabIndex = 5
        Me.TabPage_Logging.Text = "Logging"
        Me.TabPage_Logging.UseVisualStyleBackColor = True
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
        Me.TabPage_Admin.Controls.Add(Me.CheckBox_RandomTelemetry)
        Me.TabPage_Admin.Controls.Add(Me.CheckBox_Plotting)
        Me.TabPage_Admin.Controls.Add(Me.Label6)
        Me.TabPage_Admin.Controls.Add(Me.Label_Interval)
        Me.TabPage_Admin.Controls.Add(Me.ListView_Telemetry)
        Me.TabPage_Admin.Controls.Add(Me.Label_LostPackets)
        Me.TabPage_Admin.Controls.Add(Me.Label11)
        Me.TabPage_Admin.Controls.Add(Me.Label10)
        Me.TabPage_Admin.Controls.Add(Me.Label5)
        Me.TabPage_Admin.Controls.Add(Me.Label9)
        Me.TabPage_Admin.Controls.Add(Me.Label3)
        Me.TabPage_Admin.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Admin.Name = "TabPage_Admin"
        Me.TabPage_Admin.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_Admin.TabIndex = 1
        Me.TabPage_Admin.Text = "Admin"
        Me.TabPage_Admin.UseVisualStyleBackColor = True
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
        Me.Label6.Location = New System.Drawing.Point(807, 12)
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
        Me.ListView_Telemetry.Location = New System.Drawing.Point(810, 28)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(66, 431)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "bms: minimums and maximums global"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(66, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "perf 2: rpm / 2 wheel speed at different scale"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "create bidirectional protocol"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "perf: voltage current / power at another scale "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "add dynamic min/max for progress bars with 30sec history"
        '
        'TabPage_Connection
        '
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_Connection)
        Me.TabPage_Connection.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Connection.Name = "TabPage_Connection"
        Me.TabPage_Connection.Size = New System.Drawing.Size(1306, 648)
        Me.TabPage_Connection.TabIndex = 7
        Me.TabPage_Connection.Text = "Connection"
        Me.TabPage_Connection.UseVisualStyleBackColor = True
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 696)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1256, 714)
        Me.Name = "Main"
        Me.Text = " UoP6e Telemetry"
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
        Me.TabPage_Logging.ResumeLayout(False)
        Me.TabPage_Logging.PerformLayout()
        Me.TabPage_Admin.ResumeLayout(False)
        Me.TabPage_Admin.PerformLayout()
        Me.TabPage_Connection.ResumeLayout(False)
        Me.GroupBox_Connection.ResumeLayout(False)
        Me.GroupBox_Connection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel_Status As ToolStripStatusLabel
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
    Friend WithEvents ListView_Temperature As ListView
    Friend WithEvents ColumnHeader_TempSensor As ColumnHeader
    Friend WithEvents ColumnHeader_TempValue As ColumnHeader
    Friend WithEvents Label_Power As Label
    Friend WithEvents Label_RPM As Label
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage_Plotting As TabPage
    Friend WithEvents Timer_RandomTelemetry As Timer
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents CheckBox_AutoScroll As CheckBox
    Friend WithEvents CheckBox_PlotCoolantOut As CheckBox
    Friend WithEvents CheckBox_PlotCoolantIn As CheckBox
    Friend WithEvents CheckBox_PlotBrakeRear As CheckBox
    Friend WithEvents CheckBox_PlotBrakeFront As CheckBox
    Friend WithEvents CheckBox_PlotThrottle As CheckBox
    Friend WithEvents TabPage_BMS As TabPage
    Friend WithEvents CheckBox_PlotGearboxTemp As CheckBox
    Friend WithEvents CheckBox_PlotIGBTTemp As CheckBox
    Friend WithEvents CheckBox_PlotMotorTemp As CheckBox
    Friend WithEvents CheckBox_Plotting As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox_RandomTelemetry As CheckBox
    Friend WithEvents Label_Temps_BrakeRight As Label
    Friend WithEvents Label_Temps_BrakeLeft As Label
    Friend WithEvents TabPage_Logging As TabPage
    Friend WithEvents ListView_CAN As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label_CAN_Incoming As Label
    Friend WithEvents CheckBox_PlotBrakeRight As CheckBox
    Friend WithEvents CheckBox_PlotBrakeLeft As CheckBox
    Friend WithEvents CheckBox_AutoScale As CheckBox
    Friend WithEvents CheckBox_PlotRPM As CheckBox
    Friend WithEvents CheckBox_PlotFrontRightRPM As CheckBox
    Friend WithEvents CheckBox_PlotFrontLeftRPM As CheckBox
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
    Friend WithEvents Button_RandomBMS As Button
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Left", "0 V", "0 V", "0 C", "0 C"}, -1)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Right", "0 V", "0 V", "0 C", "0 C"}, -1)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ETD", "0"}, -1)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"BMSA", "0"}, -1)
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"MCMS", "0"}, -1)
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"EMA", "0"}, -1)
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CDS", "0"}, -1)
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PLS", "0"}, -1)
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Current", "0"}, -1)
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Coolant In", "0 C"}, -1)
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Coolant Out", "0 C"}, -1)
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Gearbox", "0 C"}, -1)
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"IGBT", "0 C"}, -1)
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Motor", "0 C"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series27 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series28 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series29 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series30 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series31 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series32 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series33 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series34 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series35 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series36 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series37 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series38 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series39 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox_Connection = New System.Windows.Forms.GroupBox()
        Me.Label_Serial = New System.Windows.Forms.Label()
        Me.CheckBox_OverrideConnection = New System.Windows.Forms.CheckBox()
        Me.ComboBox_Ports = New System.Windows.Forms.ComboBox()
        Me.Button_Connect = New System.Windows.Forms.Button()
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
        Me.TabPage_CAN = New System.Windows.Forms.TabPage()
        Me.Label_CAN_Incoming = New System.Windows.Forms.Label()
        Me.ListView_CAN = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage_Logging = New System.Windows.Forms.TabPage()
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
        Me.Timer_RandomTelemetry = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox_Logging = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Connection.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage_General.SuspendLayout()
        CType(Me.PictureBox_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Plotting.SuspendLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_CAN.SuspendLayout()
        Me.TabPage_Logging.SuspendLayout()
        Me.TabPage_Admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Connection
        '
        Me.GroupBox_Connection.Controls.Add(Me.Label_Serial)
        Me.GroupBox_Connection.Controls.Add(Me.CheckBox_OverrideConnection)
        Me.GroupBox_Connection.Controls.Add(Me.ComboBox_Ports)
        Me.GroupBox_Connection.Controls.Add(Me.Button_Connect)
        Me.GroupBox_Connection.Location = New System.Drawing.Point(37, 45)
        Me.GroupBox_Connection.Name = "GroupBox_Connection"
        Me.GroupBox_Connection.Size = New System.Drawing.Size(290, 65)
        Me.GroupBox_Connection.TabIndex = 7
        Me.GroupBox_Connection.TabStop = False
        Me.GroupBox_Connection.Text = "Connection"
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
        'CheckBox_OverrideConnection
        '
        Me.CheckBox_OverrideConnection.AutoSize = True
        Me.CheckBox_OverrideConnection.Checked = True
        Me.CheckBox_OverrideConnection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_OverrideConnection.Location = New System.Drawing.Point(210, 46)
        Me.CheckBox_OverrideConnection.Name = "CheckBox_OverrideConnection"
        Me.CheckBox_OverrideConnection.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox_OverrideConnection.TabIndex = 34
        Me.CheckBox_OverrideConnection.Text = "Override"
        Me.CheckBox_OverrideConnection.UseVisualStyleBackColor = True
        '
        'ComboBox_Ports
        '
        Me.ComboBox_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_Status, Me.ToolStripStatusLabel_SerialInfo, Me.ToolStripStatusLabel_Spring, Me.ToolStripStatusLabel_Updates})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 653)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1364, 22)
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
        Me.ToolStripStatusLabel_Spring.Size = New System.Drawing.Size(1031, 17)
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
        Me.TabControl.Controls.Add(Me.TabPage_Logging)
        Me.TabControl.Controls.Add(Me.TabPage_Admin)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1364, 653)
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
        Me.TabPage_General.Size = New System.Drawing.Size(1356, 627)
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
        Me.ListView_BMS.GridLines = True
        Me.ListView_BMS.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem29, ListViewItem30})
        Me.ListView_BMS.Location = New System.Drawing.Point(321, 506)
        Me.ListView_BMS.Name = "ListView_BMS"
        Me.ListView_BMS.Scrollable = False
        Me.ListView_BMS.Size = New System.Drawing.Size(386, 77)
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
        Me.ListView_VCU.GridLines = True
        Me.ListView_VCU.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37})
        Me.ListView_VCU.Location = New System.Drawing.Point(406, 237)
        Me.ListView_VCU.Name = "ListView_VCU"
        Me.ListView_VCU.Size = New System.Drawing.Size(118, 150)
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
        ListViewItem38.StateImageIndex = 0
        ListViewItem39.StateImageIndex = 0
        ListViewItem40.StateImageIndex = 0
        ListViewItem41.StateImageIndex = 0
        ListViewItem42.StateImageIndex = 0
        Me.ListView_Temperature.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42})
        Me.ListView_Temperature.Location = New System.Drawing.Point(399, 13)
        Me.ListView_Temperature.Name = "ListView_Temperature"
        Me.ListView_Temperature.Size = New System.Drawing.Size(210, 151)
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
        Me.TabPage_Plotting.Size = New System.Drawing.Size(1356, 627)
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
        Me.CheckBox_AutoScale.Location = New System.Drawing.Point(1192, 3)
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
        Me.CheckBox_AutoScroll.Location = New System.Drawing.Point(1276, 3)
        Me.CheckBox_AutoScroll.Name = "CheckBox_AutoScroll"
        Me.CheckBox_AutoScroll.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox_AutoScroll.TabIndex = 1
        Me.CheckBox_AutoScroll.Text = "Auto Scroll"
        Me.CheckBox_AutoScroll.UseVisualStyleBackColor = True
        '
        'Chart
        '
        ChartArea9.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea9.AxisX.Interval = 30.0R
        ChartArea9.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea9.AxisX.LabelStyle.Interval = 5.0R
        ChartArea9.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.MajorGrid.Interval = 10.0R
        ChartArea9.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea9.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.MinorGrid.Enabled = True
        ChartArea9.AxisX.MinorGrid.Interval = 1.0R
        ChartArea9.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea9.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea9.AxisX.MinorTickMark.Enabled = True
        ChartArea9.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea9.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea9.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea9.AxisX.ScaleView.MinSize = 100.0R
        ChartArea9.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea9.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea9.AxisX.ScaleView.Size = 20.0R
        ChartArea9.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea9.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea9.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea9.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea9.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea9.AxisY.Maximum = 100.0R
        ChartArea9.AxisY.Minimum = 0R
        ChartArea9.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea9.AxisY2.Maximum = 200.0R
        ChartArea9.AxisY2.Minimum = 0R
        ChartArea9.CursorX.IsUserEnabled = True
        ChartArea9.CursorX.IsUserSelectionEnabled = True
        ChartArea9.Name = "ChartArea_Pedals"
        ChartArea10.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea10.AxisX.Interval = 30.0R
        ChartArea10.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea10.AxisX.LabelStyle.Interval = 5.0R
        ChartArea10.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.MajorGrid.Interval = 10.0R
        ChartArea10.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea10.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.MinorGrid.Enabled = True
        ChartArea10.AxisX.MinorGrid.Interval = 1.0R
        ChartArea10.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea10.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea10.AxisX.MinorTickMark.Enabled = True
        ChartArea10.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea10.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea10.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea10.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea10.AxisX.ScaleView.MinSize = 100.0R
        ChartArea10.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea10.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea10.AxisX.ScaleView.Size = 20.0R
        ChartArea10.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea10.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea10.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea10.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea10.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea10.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea10.AxisY.Maximum = 150.0R
        ChartArea10.AxisY.Minimum = 0R
        ChartArea10.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea10.AxisY2.Maximum = 150.0R
        ChartArea10.AxisY2.Minimum = 0R
        ChartArea10.CursorX.IsUserEnabled = True
        ChartArea10.CursorX.IsUserSelectionEnabled = True
        ChartArea10.Name = "ChartArea_Temps"
        ChartArea11.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea11.AxisX.Interval = 30.0R
        ChartArea11.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea11.AxisX.LabelStyle.Interval = 5.0R
        ChartArea11.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.MajorGrid.Interval = 10.0R
        ChartArea11.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea11.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.MinorGrid.Enabled = True
        ChartArea11.AxisX.MinorGrid.Interval = 1.0R
        ChartArea11.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea11.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea11.AxisX.MinorTickMark.Enabled = True
        ChartArea11.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea11.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea11.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea11.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea11.AxisX.ScaleView.MinSize = 100.0R
        ChartArea11.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea11.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea11.AxisX.ScaleView.Size = 20.0R
        ChartArea11.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea11.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea11.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea11.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea11.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea11.AxisY.IsStartedFromZero = False
        ChartArea11.AxisY.Maximum = 150.0R
        ChartArea11.AxisY.Minimum = 0R
        ChartArea11.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea11.AxisY2.IsStartedFromZero = False
        ChartArea11.AxisY2.Maximum = 400.0R
        ChartArea11.AxisY2.Minimum = 100.0R
        ChartArea11.CursorX.IsUserEnabled = True
        ChartArea11.CursorX.IsUserSelectionEnabled = True
        ChartArea11.Name = "ChartArea_Temps2"
        ChartArea12.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea12.AxisX.Interval = 30.0R
        ChartArea12.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea12.AxisX.LabelStyle.Interval = 5.0R
        ChartArea12.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.MajorGrid.Interval = 10.0R
        ChartArea12.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.MajorTickMark.Interval = 30.0R
        ChartArea12.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.MinorGrid.Enabled = True
        ChartArea12.AxisX.MinorGrid.Interval = 1.0R
        ChartArea12.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray
        ChartArea12.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea12.AxisX.MinorTickMark.Enabled = True
        ChartArea12.AxisX.MinorTickMark.Interval = 1.0R
        ChartArea12.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea12.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea12.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea12.AxisX.ScaleView.MinSize = 100.0R
        ChartArea12.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds
        ChartArea12.AxisX.ScaleView.Position = 0.66192726851851857R
        ChartArea12.AxisX.ScaleView.Size = 20.0R
        ChartArea12.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.ScaleView.SmallScrollSize = 10.0R
        ChartArea12.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea12.AxisX.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea12.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ControlLight
        ChartArea12.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
        ChartArea12.Name = "ChartArea_RPM"
        Me.Chart.ChartAreas.Add(ChartArea9)
        Me.Chart.ChartAreas.Add(ChartArea10)
        Me.Chart.ChartAreas.Add(ChartArea11)
        Me.Chart.ChartAreas.Add(ChartArea12)
        Me.Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart.IsSoftShadows = False
        Legend9.DockedToChartArea = "ChartArea_Pedals"
        Legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend9.IsEquallySpacedItems = True
        Legend9.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend9.Name = "Legend_Pedals"
        Legend9.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend9.TextWrapThreshold = 35
        Legend10.DockedToChartArea = "ChartArea_Temps2"
        Legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend10.IsEquallySpacedItems = True
        Legend10.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend10.Name = "Legend_Temps2"
        Legend10.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend10.TextWrapThreshold = 35
        Legend11.DockedToChartArea = "ChartArea_Temps"
        Legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend11.IsEquallySpacedItems = True
        Legend11.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend11.Name = "Legend_Temps"
        Legend11.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend11.TextWrapThreshold = 35
        Legend12.DockedToChartArea = "ChartArea_RPM"
        Legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend12.IsEquallySpacedItems = True
        Legend12.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend12.Name = "Legend_RPM"
        Legend12.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend12.TextWrapThreshold = 35
        Me.Chart.Legends.Add(Legend9)
        Me.Chart.Legends.Add(Legend10)
        Me.Chart.Legends.Add(Legend11)
        Me.Chart.Legends.Add(Legend12)
        Me.Chart.Location = New System.Drawing.Point(0, 0)
        Me.Chart.Name = "Chart"
        Series27.BorderWidth = 3
        Series27.ChartArea = "ChartArea_Pedals"
        Series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series27.Color = System.Drawing.Color.LimeGreen
        Series27.CustomProperties = "IsXAxisQuantitative=False"
        Series27.Legend = "Legend_Pedals"
        Series27.LegendText = "Throttle Min: #MIN{D0}%, Max: #MAX{D0}%"
        Series27.LegendToolTip = "The position of the throttle pedal"
        Series27.Name = "Series_Throttle"
        Series27.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series28.BorderWidth = 3
        Series28.ChartArea = "ChartArea_Pedals"
        Series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series28.Color = System.Drawing.Color.Firebrick
        Series28.Legend = "Legend_Pedals"
        Series28.LegendText = "Front Min: #MIN{D0}Bar, Max: #MAX{D0}Bar"
        Series28.LegendToolTip = "The front brake pressure"
        Series28.Name = "Series_BrakeFront"
        Series28.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series28.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series29.BorderWidth = 3
        Series29.ChartArea = "ChartArea_Pedals"
        Series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series29.Color = System.Drawing.Color.Coral
        Series29.Legend = "Legend_Pedals"
        Series29.LegendText = "Rear Min: #MIN{D0}Bar, Max: #MAX{D0}Bar"
        Series29.LegendToolTip = "The rear brake pressure"
        Series29.Name = "Series_BrakeRear"
        Series29.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series29.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series30.BorderWidth = 3
        Series30.ChartArea = "ChartArea_Temps2"
        Series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series30.Color = System.Drawing.Color.Firebrick
        Series30.Legend = "Legend_Temps2"
        Series30.LegendText = "Coolant In Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series30.LegendToolTip = "The input temperature of the coolant"
        Series30.Name = "Series_CoolantIn"
        Series30.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series31.BorderWidth = 3
        Series31.ChartArea = "ChartArea_Temps2"
        Series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series31.Color = System.Drawing.Color.LimeGreen
        Series31.Legend = "Legend_Temps2"
        Series31.LegendText = "Coolant Out Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series31.LegendToolTip = "The output temperature of the coolant"
        Series31.Name = "Series_CoolantOut"
        Series31.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series32.BorderWidth = 3
        Series32.ChartArea = "ChartArea_Temps2"
        Series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series32.Color = System.Drawing.Color.RoyalBlue
        Series32.Legend = "Legend_Temps2"
        Series32.LegendText = "Left Brake Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series32.LegendToolTip = "The temperature of the front left brake caliper"
        Series32.Name = "Series_BrakeLeft"
        Series32.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series32.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series33.BorderWidth = 3
        Series33.ChartArea = "ChartArea_Temps2"
        Series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series33.Color = System.Drawing.Color.BlueViolet
        Series33.Legend = "Legend_Temps2"
        Series33.LegendText = "Right Brake Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series33.LegendToolTip = "The temperature of the front right brake caliper"
        Series33.Name = "Series_BrakeRight"
        Series33.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series33.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series34.BorderWidth = 3
        Series34.ChartArea = "ChartArea_Temps"
        Series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series34.Legend = "Legend_Temps"
        Series34.LegendText = "Gearbox Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series34.LegendToolTip = "The temperature of the gearbox"
        Series34.Name = "Series_GearboxTemp"
        Series34.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series35.BorderWidth = 3
        Series35.ChartArea = "ChartArea_Temps"
        Series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series35.Legend = "Legend_Temps"
        Series35.LegendText = "Motor Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series35.LegendToolTip = "The temperature of the motor"
        Series35.Name = "Series_MotorTemp"
        Series35.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series36.BorderWidth = 3
        Series36.ChartArea = "ChartArea_Temps"
        Series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series36.Legend = "Legend_Temps"
        Series36.LegendText = "IGBT Min: #MIN{D0}°C, Max: #MAX{D0}°C"
        Series36.LegendToolTip = "The temperature of the inverter's IGBTs"
        Series36.Name = "Series_IGBTTemp"
        Series36.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series36.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series37.BorderWidth = 3
        Series37.ChartArea = "ChartArea_RPM"
        Series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series37.Legend = "Legend_RPM"
        Series37.LegendText = "Left Wheel Min: #MIN{D0} RPM, #MAX{D0} RPM"
        Series37.LegendToolTip = "The RPM of the front left wheel"
        Series37.Name = "Series_FrontLeftRPM"
        Series37.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series38.BorderWidth = 3
        Series38.ChartArea = "ChartArea_RPM"
        Series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series38.Legend = "Legend_RPM"
        Series38.LegendText = "Right Wheel Min: #MIN{D0} RPM, #MAX{D0} RPM"
        Series38.LegendToolTip = "The RPM of the front right wheel"
        Series38.Name = "Series_FrontRightRPM"
        Series38.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series39.BorderWidth = 3
        Series39.ChartArea = "ChartArea_RPM"
        Series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series39.Legend = "Legend_RPM"
        Series39.LegendText = "RPM Min: #MIN{D0} RPM, Max: #MAX{D0} RPM"
        Series39.LegendToolTip = "The RPM of the motor"
        Series39.Name = "Series_RPM"
        Series39.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series39.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.Chart.Series.Add(Series27)
        Me.Chart.Series.Add(Series28)
        Me.Chart.Series.Add(Series29)
        Me.Chart.Series.Add(Series30)
        Me.Chart.Series.Add(Series31)
        Me.Chart.Series.Add(Series32)
        Me.Chart.Series.Add(Series33)
        Me.Chart.Series.Add(Series34)
        Me.Chart.Series.Add(Series35)
        Me.Chart.Series.Add(Series36)
        Me.Chart.Series.Add(Series37)
        Me.Chart.Series.Add(Series38)
        Me.Chart.Series.Add(Series39)
        Me.Chart.Size = New System.Drawing.Size(1356, 627)
        Me.Chart.TabIndex = 0
        Me.Chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'TabPage_BMS
        '
        Me.TabPage_BMS.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_BMS.Name = "TabPage_BMS"
        Me.TabPage_BMS.Size = New System.Drawing.Size(1356, 627)
        Me.TabPage_BMS.TabIndex = 4
        Me.TabPage_BMS.Text = "BMS"
        Me.TabPage_BMS.UseVisualStyleBackColor = True
        '
        'TabPage_CAN
        '
        Me.TabPage_CAN.Controls.Add(Me.Label_CAN_Incoming)
        Me.TabPage_CAN.Controls.Add(Me.ListView_CAN)
        Me.TabPage_CAN.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_CAN.Name = "TabPage_CAN"
        Me.TabPage_CAN.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CAN.Size = New System.Drawing.Size(1356, 627)
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
        Me.ListView_CAN.Size = New System.Drawing.Size(484, 605)
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
        'TabPage_Logging
        '
        Me.TabPage_Logging.Controls.Add(Me.CheckBox_Logging)
        Me.TabPage_Logging.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Logging.Name = "TabPage_Logging"
        Me.TabPage_Logging.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Logging.Size = New System.Drawing.Size(1356, 627)
        Me.TabPage_Logging.TabIndex = 5
        Me.TabPage_Logging.Text = "Logging"
        Me.TabPage_Logging.UseVisualStyleBackColor = True
        '
        'TabPage_Admin
        '
        Me.TabPage_Admin.Controls.Add(Me.CheckBox_RandomTelemetry)
        Me.TabPage_Admin.Controls.Add(Me.CheckBox_Plotting)
        Me.TabPage_Admin.Controls.Add(Me.Label6)
        Me.TabPage_Admin.Controls.Add(Me.Label_Interval)
        Me.TabPage_Admin.Controls.Add(Me.ListView_Telemetry)
        Me.TabPage_Admin.Controls.Add(Me.GroupBox_Connection)
        Me.TabPage_Admin.Controls.Add(Me.Label_LostPackets)
        Me.TabPage_Admin.Controls.Add(Me.Label11)
        Me.TabPage_Admin.Controls.Add(Me.Label10)
        Me.TabPage_Admin.Controls.Add(Me.Label5)
        Me.TabPage_Admin.Controls.Add(Me.Label9)
        Me.TabPage_Admin.Controls.Add(Me.Label3)
        Me.TabPage_Admin.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Admin.Name = "TabPage_Admin"
        Me.TabPage_Admin.Size = New System.Drawing.Size(1356, 627)
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
        'Timer_RandomTelemetry
        '
        Me.Timer_RandomTelemetry.Interval = 50
        '
        'CheckBox_Logging
        '
        Me.CheckBox_Logging.AutoSize = True
        Me.CheckBox_Logging.Location = New System.Drawing.Point(127, 181)
        Me.CheckBox_Logging.Name = "CheckBox_Logging"
        Me.CheckBox_Logging.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_Logging.TabIndex = 40
        Me.CheckBox_Logging.Text = "Logging"
        Me.CheckBox_Logging.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 675)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1256, 714)
        Me.Name = "Main"
        Me.Text = " UoP6e Telemetry"
        Me.GroupBox_Connection.ResumeLayout(False)
        Me.GroupBox_Connection.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage_General.ResumeLayout(False)
        Me.TabPage_General.PerformLayout()
        CType(Me.PictureBox_Car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Plotting.ResumeLayout(False)
        Me.TabPage_Plotting.PerformLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_CAN.ResumeLayout(False)
        Me.TabPage_CAN.PerformLayout()
        Me.TabPage_Logging.ResumeLayout(False)
        Me.TabPage_Logging.PerformLayout()
        Me.TabPage_Admin.ResumeLayout(False)
        Me.TabPage_Admin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Connection As GroupBox
    Friend WithEvents Label_Serial As Label
    Friend WithEvents ComboBox_Ports As ComboBox
    Friend WithEvents Button_Connect As Button
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
    Friend WithEvents CheckBox_OverrideConnection As CheckBox
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
    Friend WithEvents CheckBox_Logging As CheckBox
End Class

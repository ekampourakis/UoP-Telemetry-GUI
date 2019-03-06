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
        Me.GroupBox_Connection = New System.Windows.Forms.GroupBox()
        Me.Label_Serial = New System.Windows.Forms.Label()
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
        Me.ListView_Raw = New System.Windows.Forms.ListView()
        Me.ColumnHeader_FieldName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_FieldType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_FieldValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView_Processed = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer_Monitoring = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_Monitoring = New System.Windows.Forms.GroupBox()
        Me.Button_FetchRaw = New System.Windows.Forms.Button()
        Me.Button_FetchProcessed = New System.Windows.Forms.Button()
        Me.CheckBox_Raw = New System.Windows.Forms.CheckBox()
        Me.Button_Monitoring = New System.Windows.Forms.Button()
        Me.CheckBox_Processed = New System.Windows.Forms.CheckBox()
        Me.Button_FetchMixed = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage_Wireless = New System.Windows.Forms.TabPage()
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
        Me.TabPage_Graphing = New System.Windows.Forms.TabPage()
        Me.TabPage_Admin = New System.Windows.Forms.TabPage()
        Me.ListView_Telemetry = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage_CAN = New System.Windows.Forms.TabPage()
        Me.GroupBox_Connection.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox_Monitoring.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage_Wireless.SuspendLayout()
        CType(Me.PictureBox_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Connection
        '
        Me.GroupBox_Connection.Controls.Add(Me.Label_Serial)
        Me.GroupBox_Connection.Controls.Add(Me.ComboBox_Ports)
        Me.GroupBox_Connection.Controls.Add(Me.Button_Connect)
        Me.GroupBox_Connection.Location = New System.Drawing.Point(12, 12)
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
        Me.StatusStrip.Location = New System.Drawing.Point(0, 739)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1264, 22)
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
        Me.ToolStripStatusLabel_Spring.Size = New System.Drawing.Size(931, 17)
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
        'ListView_Raw
        '
        Me.ListView_Raw.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView_Raw.AutoArrange = False
        Me.ListView_Raw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_FieldName, Me.ColumnHeader_FieldType, Me.ColumnHeader_FieldValue})
        Me.ListView_Raw.FullRowSelect = True
        Me.ListView_Raw.GridLines = True
        Me.ListView_Raw.Location = New System.Drawing.Point(3, 20)
        Me.ListView_Raw.Name = "ListView_Raw"
        Me.ListView_Raw.ShowItemToolTips = True
        Me.ListView_Raw.Size = New System.Drawing.Size(318, 604)
        Me.ListView_Raw.TabIndex = 14
        Me.ListView_Raw.UseCompatibleStateImageBehavior = False
        Me.ListView_Raw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_FieldName
        '
        Me.ColumnHeader_FieldName.Text = "Field Name"
        Me.ColumnHeader_FieldName.Width = 142
        '
        'ColumnHeader_FieldType
        '
        Me.ColumnHeader_FieldType.Text = "Type"
        Me.ColumnHeader_FieldType.Width = 82
        '
        'ColumnHeader_FieldValue
        '
        Me.ColumnHeader_FieldValue.Text = "Value"
        Me.ColumnHeader_FieldValue.Width = 80
        '
        'ListView_Processed
        '
        Me.ListView_Processed.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView_Processed.AutoArrange = False
        Me.ListView_Processed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView_Processed.FullRowSelect = True
        Me.ListView_Processed.GridLines = True
        Me.ListView_Processed.Location = New System.Drawing.Point(327, 20)
        Me.ListView_Processed.Name = "ListView_Processed"
        Me.ListView_Processed.ShowItemToolTips = True
        Me.ListView_Processed.Size = New System.Drawing.Size(318, 604)
        Me.ListView_Processed.TabIndex = 16
        Me.ListView_Processed.UseCompatibleStateImageBehavior = False
        Me.ListView_Processed.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Field Name"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 82
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Value"
        Me.ColumnHeader3.Width = 80
        '
        'Timer_Monitoring
        '
        Me.Timer_Monitoring.Interval = 500
        '
        'GroupBox_Monitoring
        '
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_FetchRaw)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_FetchProcessed)
        Me.GroupBox_Monitoring.Controls.Add(Me.CheckBox_Raw)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_Monitoring)
        Me.GroupBox_Monitoring.Controls.Add(Me.CheckBox_Processed)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_FetchMixed)
        Me.GroupBox_Monitoring.Location = New System.Drawing.Point(651, 4)
        Me.GroupBox_Monitoring.Name = "GroupBox_Monitoring"
        Me.GroupBox_Monitoring.Size = New System.Drawing.Size(221, 106)
        Me.GroupBox_Monitoring.TabIndex = 26
        Me.GroupBox_Monitoring.TabStop = False
        Me.GroupBox_Monitoring.Text = "Monitoring"
        '
        'Button_FetchRaw
        '
        Me.Button_FetchRaw.Location = New System.Drawing.Point(6, 19)
        Me.Button_FetchRaw.Name = "Button_FetchRaw"
        Me.Button_FetchRaw.Size = New System.Drawing.Size(112, 23)
        Me.Button_FetchRaw.TabIndex = 10
        Me.Button_FetchRaw.Text = "Fetch Raw"
        Me.Button_FetchRaw.UseVisualStyleBackColor = True
        '
        'Button_FetchProcessed
        '
        Me.Button_FetchProcessed.Location = New System.Drawing.Point(6, 48)
        Me.Button_FetchProcessed.Name = "Button_FetchProcessed"
        Me.Button_FetchProcessed.Size = New System.Drawing.Size(112, 23)
        Me.Button_FetchProcessed.TabIndex = 3
        Me.Button_FetchProcessed.Text = "Fetch Processed"
        Me.Button_FetchProcessed.UseVisualStyleBackColor = True
        '
        'CheckBox_Raw
        '
        Me.CheckBox_Raw.AutoSize = True
        Me.CheckBox_Raw.Checked = True
        Me.CheckBox_Raw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Raw.Location = New System.Drawing.Point(124, 23)
        Me.CheckBox_Raw.Name = "CheckBox_Raw"
        Me.CheckBox_Raw.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox_Raw.TabIndex = 12
        Me.CheckBox_Raw.Text = "Raw Car"
        Me.CheckBox_Raw.UseVisualStyleBackColor = True
        '
        'Button_Monitoring
        '
        Me.Button_Monitoring.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Monitoring.Location = New System.Drawing.Point(124, 77)
        Me.Button_Monitoring.Name = "Button_Monitoring"
        Me.Button_Monitoring.Size = New System.Drawing.Size(91, 23)
        Me.Button_Monitoring.TabIndex = 2
        Me.Button_Monitoring.Text = "Start Monitoring"
        Me.Button_Monitoring.UseVisualStyleBackColor = True
        '
        'CheckBox_Processed
        '
        Me.CheckBox_Processed.AutoSize = True
        Me.CheckBox_Processed.Checked = True
        Me.CheckBox_Processed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Processed.Location = New System.Drawing.Point(124, 52)
        Me.CheckBox_Processed.Name = "CheckBox_Processed"
        Me.CheckBox_Processed.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox_Processed.TabIndex = 13
        Me.CheckBox_Processed.Text = "Processed Car"
        Me.CheckBox_Processed.UseVisualStyleBackColor = True
        '
        'Button_FetchMixed
        '
        Me.Button_FetchMixed.Location = New System.Drawing.Point(6, 77)
        Me.Button_FetchMixed.Name = "Button_FetchMixed"
        Me.Button_FetchMixed.Size = New System.Drawing.Size(112, 23)
        Me.Button_FetchMixed.TabIndex = 11
        Me.Button_FetchMixed.Text = "Fetch Mixed"
        Me.Button_FetchMixed.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage_Wireless)
        Me.TabControl.Controls.Add(Me.TabPage_Graphing)
        Me.TabControl.Controls.Add(Me.TabPage_Admin)
        Me.TabControl.Controls.Add(Me.TabPage_CAN)
        Me.TabControl.Location = New System.Drawing.Point(12, 83)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1240, 653)
        Me.TabControl.TabIndex = 27
        '
        'TabPage_Wireless
        '
        Me.TabPage_Wireless.Controls.Add(Me.ListView_BMS)
        Me.TabPage_Wireless.Controls.Add(Me.ListView_VCU)
        Me.TabPage_Wireless.Controls.Add(Me.ListView_Temperature)
        Me.TabPage_Wireless.Controls.Add(Me.Label_Power)
        Me.TabPage_Wireless.Controls.Add(Me.Label_RPM)
        Me.TabPage_Wireless.Controls.Add(Me.Label_Current)
        Me.TabPage_Wireless.Controls.Add(Me.Label_Voltage)
        Me.TabPage_Wireless.Controls.Add(Me.Label_Throttle)
        Me.TabPage_Wireless.Controls.Add(Me.ProgressBar_Throttle)
        Me.TabPage_Wireless.Controls.Add(Me.Label_BrakeFront)
        Me.TabPage_Wireless.Controls.Add(Me.ProgressBar_BrakeFront)
        Me.TabPage_Wireless.Controls.Add(Me.Label_BrakeRear)
        Me.TabPage_Wireless.Controls.Add(Me.ProgressBar_BrakeRear)
        Me.TabPage_Wireless.Controls.Add(Me.Label_RPM_FrontRight)
        Me.TabPage_Wireless.Controls.Add(Me.Label_RPM_RearRight)
        Me.TabPage_Wireless.Controls.Add(Me.Label_RPM_FrontLeft)
        Me.TabPage_Wireless.Controls.Add(Me.Label_RPM_RearLeft)
        Me.TabPage_Wireless.Controls.Add(Me.PictureBox_Car)
        Me.TabPage_Wireless.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Wireless.Name = "TabPage_Wireless"
        Me.TabPage_Wireless.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Wireless.Size = New System.Drawing.Size(1232, 627)
        Me.TabPage_Wireless.TabIndex = 0
        Me.TabPage_Wireless.Text = "Wireless"
        Me.TabPage_Wireless.UseVisualStyleBackColor = True
        '
        'ListView_BMS
        '
        Me.ListView_BMS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_BMSPack, Me.ColumnHeader_BMS_Voltage_Min, Me.ColumnHeader_BMS_Voltage_Max, Me.ColumnHeader_BMS_Temp_Min, Me.ColumnHeader_BMS_Temp_Max})
        Me.ListView_BMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_BMS.GridLines = True
        Me.ListView_BMS.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
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
        Me.ListView_VCU.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.ListView_VCU.Location = New System.Drawing.Point(412, 237)
        Me.ListView_VCU.Name = "ListView_VCU"
        Me.ListView_VCU.Size = New System.Drawing.Size(106, 150)
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
        Me.ColumnHeader_VCUValue.Width = 45
        '
        'ListView_Temperature
        '
        Me.ListView_Temperature.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_TempSensor, Me.ColumnHeader_TempValue})
        Me.ListView_Temperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Temperature.FullRowSelect = True
        Me.ListView_Temperature.GridLines = True
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        Me.ListView_Temperature.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14})
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
        Me.Label_RPM_FrontRight.Location = New System.Drawing.Point(808, 561)
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
        Me.Label_RPM_FrontLeft.Location = New System.Drawing.Point(808, 41)
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
        'TabPage_Graphing
        '
        Me.TabPage_Graphing.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Graphing.Name = "TabPage_Graphing"
        Me.TabPage_Graphing.Size = New System.Drawing.Size(1232, 627)
        Me.TabPage_Graphing.TabIndex = 2
        Me.TabPage_Graphing.Text = "Graphing"
        Me.TabPage_Graphing.UseVisualStyleBackColor = True
        '
        'TabPage_Admin
        '
        Me.TabPage_Admin.Controls.Add(Me.ListView_Telemetry)
        Me.TabPage_Admin.Controls.Add(Me.Label2)
        Me.TabPage_Admin.Controls.Add(Me.Label1)
        Me.TabPage_Admin.Controls.Add(Me.ListView_Processed)
        Me.TabPage_Admin.Controls.Add(Me.GroupBox_Monitoring)
        Me.TabPage_Admin.Controls.Add(Me.ListView_Raw)
        Me.TabPage_Admin.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Admin.Name = "TabPage_Admin"
        Me.TabPage_Admin.Size = New System.Drawing.Size(1232, 627)
        Me.TabPage_Admin.TabIndex = 1
        Me.TabPage_Admin.Text = "Admin"
        Me.TabPage_Admin.UseVisualStyleBackColor = True
        '
        'ListView_Telemetry
        '
        Me.ListView_Telemetry.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView_Telemetry.AutoArrange = False
        Me.ListView_Telemetry.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView_Telemetry.FullRowSelect = True
        Me.ListView_Telemetry.GridLines = True
        Me.ListView_Telemetry.Location = New System.Drawing.Point(878, 20)
        Me.ListView_Telemetry.Name = "ListView_Telemetry"
        Me.ListView_Telemetry.ShowItemToolTips = True
        Me.ListView_Telemetry.Size = New System.Drawing.Size(318, 604)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Processed Sensor Values:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Raw Sensor Readings:"
        '
        'TabPage_CAN
        '
        Me.TabPage_CAN.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_CAN.Name = "TabPage_CAN"
        Me.TabPage_CAN.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CAN.Size = New System.Drawing.Size(1232, 627)
        Me.TabPage_CAN.TabIndex = 3
        Me.TabPage_CAN.Text = "CAN"
        Me.TabPage_CAN.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox_Connection)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 800)
        Me.MinimumSize = New System.Drawing.Size(1280, 800)
        Me.Name = "Main"
        Me.Text = "UoP Racing Telemetry"
        Me.GroupBox_Connection.ResumeLayout(False)
        Me.GroupBox_Connection.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox_Monitoring.ResumeLayout(False)
        Me.GroupBox_Monitoring.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage_Wireless.ResumeLayout(False)
        Me.TabPage_Wireless.PerformLayout()
        CType(Me.PictureBox_Car, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ListView_Raw As ListView
    Friend WithEvents ColumnHeader_FieldName As ColumnHeader
    Friend WithEvents ColumnHeader_FieldValue As ColumnHeader
    Friend WithEvents ColumnHeader_FieldType As ColumnHeader
    Friend WithEvents ListView_Processed As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Timer_Monitoring As Timer
    Friend WithEvents GroupBox_Monitoring As GroupBox
    Friend WithEvents Button_FetchRaw As Button
    Friend WithEvents Button_FetchProcessed As Button
    Friend WithEvents CheckBox_Raw As CheckBox
    Friend WithEvents Button_Monitoring As Button
    Friend WithEvents CheckBox_Processed As CheckBox
    Friend WithEvents Button_FetchMixed As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage_Wireless As TabPage
    Friend WithEvents TabPage_Admin As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage_Graphing As TabPage
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
End Class

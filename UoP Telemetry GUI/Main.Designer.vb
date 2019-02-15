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
        Me.GroupBox_Connection.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox_Monitoring.SuspendLayout()
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
        Me.StatusStrip.Location = New System.Drawing.Point(0, 685)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(666, 22)
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
        Me.ToolStripStatusLabel_Spring.Size = New System.Drawing.Size(333, 17)
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
        Me.ListView_Raw.Location = New System.Drawing.Point(12, 83)
        Me.ListView_Raw.Name = "ListView_Raw"
        Me.ListView_Raw.ShowItemToolTips = True
        Me.ListView_Raw.Size = New System.Drawing.Size(318, 599)
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
        Me.ListView_Processed.Location = New System.Drawing.Point(336, 124)
        Me.ListView_Processed.Name = "ListView_Processed"
        Me.ListView_Processed.ShowItemToolTips = True
        Me.ListView_Processed.Size = New System.Drawing.Size(318, 558)
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
        Me.GroupBox_Monitoring.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_FetchRaw)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_FetchProcessed)
        Me.GroupBox_Monitoring.Controls.Add(Me.CheckBox_Raw)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_Monitoring)
        Me.GroupBox_Monitoring.Controls.Add(Me.CheckBox_Processed)
        Me.GroupBox_Monitoring.Controls.Add(Me.Button_FetchMixed)
        Me.GroupBox_Monitoring.Location = New System.Drawing.Point(336, 12)
        Me.GroupBox_Monitoring.Name = "GroupBox_Monitoring"
        Me.GroupBox_Monitoring.Size = New System.Drawing.Size(318, 106)
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
        Me.Button_Monitoring.Location = New System.Drawing.Point(210, 77)
        Me.Button_Monitoring.Name = "Button_Monitoring"
        Me.Button_Monitoring.Size = New System.Drawing.Size(102, 23)
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 707)
        Me.Controls.Add(Me.GroupBox_Monitoring)
        Me.Controls.Add(Me.ListView_Processed)
        Me.Controls.Add(Me.ListView_Raw)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox_Connection)
        Me.MaximumSize = New System.Drawing.Size(682, 746)
        Me.MinimumSize = New System.Drawing.Size(682, 746)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "UoP Telemetry GUI"
        Me.GroupBox_Connection.ResumeLayout(False)
        Me.GroupBox_Connection.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox_Monitoring.ResumeLayout(False)
        Me.GroupBox_Monitoring.PerformLayout()
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
End Class

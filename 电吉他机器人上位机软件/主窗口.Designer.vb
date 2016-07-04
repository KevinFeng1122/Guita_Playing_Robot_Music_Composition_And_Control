<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 主窗口
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(主窗口))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_MelodyName = New System.Windows.Forms.Label
        Me.dgv_Composing = New System.Windows.Forms.DataGridView
        Me.小节 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmb_tempo = New System.Windows.Forms.ComboBox
        Me.cmb_Speed = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tls_btn_New = New System.Windows.Forms.ToolStripButton
        Me.tls_ReadIn = New System.Windows.Forms.ToolStripButton
        Me.tls_btn_Save = New System.Windows.Forms.ToolStripButton
        Me.tls_ProduceCode = New System.Windows.Forms.ToolStripButton
        Me.btn_InsertNote = New System.Windows.Forms.Button
        Me.btn_EditNote = New System.Windows.Forms.Button
        Me.btn_DeleteNote = New System.Windows.Forms.Button
        Me.btn_AddNote = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lbl_ReturnInformation = New System.Windows.Forms.Label
        Me.lbl_ConnectPic = New System.Windows.Forms.Label
        Me.imglst_ConnectOrNot = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_SerialPortDataReceived = New System.Windows.Forms.Label
        Me.dgv_Code = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_MechanismReset = New System.Windows.Forms.Button
        Me.lbl_Connect = New System.Windows.Forms.Label
        Me.btn_ConnectSerialPort = New System.Windows.Forms.Button
        Me.combobox_PortNum = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_StopCodePlay = New System.Windows.Forms.Button
        Me.btn_PlayOrPauseCodeFile = New System.Windows.Forms.Button
        Me.imglst_PlayOrPause = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_OpenCodeFile = New System.Windows.Forms.Button
        Me.lbl_FileName = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog_Code = New System.Windows.Forms.OpenFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog_Melody = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog_Melody = New System.Windows.Forms.SaveFileDialog
        Me.SaveFileDialog_Code = New System.Windows.Forms.SaveFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_Composing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(494, 408)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lbl_MelodyName)
        Me.TabPage1.Controls.Add(Me.dgv_Composing)
        Me.TabPage1.Controls.Add(Me.cmb_tempo)
        Me.TabPage1.Controls.Add(Me.cmb_Speed)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.btn_InsertNote)
        Me.TabPage1.Controls.Add(Me.btn_EditNote)
        Me.TabPage1.Controls.Add(Me.btn_DeleteNote)
        Me.TabPage1.Controls.Add(Me.btn_AddNote)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(486, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "编曲区"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "拍/分钟"
        '
        'lbl_MelodyName
        '
        Me.lbl_MelodyName.AutoSize = True
        Me.lbl_MelodyName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_MelodyName.ForeColor = System.Drawing.Color.Blue
        Me.lbl_MelodyName.Location = New System.Drawing.Point(24, 40)
        Me.lbl_MelodyName.Name = "lbl_MelodyName"
        Me.lbl_MelodyName.Size = New System.Drawing.Size(65, 12)
        Me.lbl_MelodyName.TabIndex = 15
        Me.lbl_MelodyName.Text = "乐曲名称："
        '
        'dgv_Composing
        '
        Me.dgv_Composing.AllowUserToAddRows = False
        Me.dgv_Composing.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Composing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Composing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Composing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.小节, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Composing.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Composing.Location = New System.Drawing.Point(26, 67)
        Me.dgv_Composing.Name = "dgv_Composing"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Composing.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Composing.RowHeadersVisible = False
        Me.dgv_Composing.RowTemplate.Height = 23
        Me.dgv_Composing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Composing.Size = New System.Drawing.Size(435, 242)
        Me.dgv_Composing.TabIndex = 14
        '
        '小节
        '
        Me.小节.HeaderText = "小节"
        Me.小节.Name = "小节"
        Me.小节.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "和弦"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "拨弦/扫弦"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "时值"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "备注"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 141
        '
        'cmb_tempo
        '
        Me.cmb_tempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tempo.FormattingEnabled = True
        Me.cmb_tempo.Items.AddRange(New Object() {"二分音符", "四分音符", "八分音符"})
        Me.cmb_tempo.Location = New System.Drawing.Point(382, 37)
        Me.cmb_tempo.Name = "cmb_tempo"
        Me.cmb_tempo.Size = New System.Drawing.Size(79, 20)
        Me.cmb_tempo.TabIndex = 12
        '
        'cmb_Speed
        '
        Me.cmb_Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Speed.FormattingEnabled = True
        Me.cmb_Speed.Items.AddRange(New Object() {"60", "90", "120", "150"})
        Me.cmb_Speed.Location = New System.Drawing.Point(231, 37)
        Me.cmb_Speed.Name = "cmb_Speed"
        Me.cmb_Speed.Size = New System.Drawing.Size(43, 20)
        Me.cmb_Speed.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "1拍子="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "速度："
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tls_btn_New, Me.tls_ReadIn, Me.tls_btn_Save, Me.tls_ProduceCode})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(480, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tls_btn_New
        '
        Me.tls_btn_New.Image = CType(resources.GetObject("tls_btn_New.Image"), System.Drawing.Image)
        Me.tls_btn_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_btn_New.Name = "tls_btn_New"
        Me.tls_btn_New.Size = New System.Drawing.Size(76, 22)
        Me.tls_btn_New.Text = "新建乐曲"
        '
        'tls_ReadIn
        '
        Me.tls_ReadIn.Image = CType(resources.GetObject("tls_ReadIn.Image"), System.Drawing.Image)
        Me.tls_ReadIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_ReadIn.Name = "tls_ReadIn"
        Me.tls_ReadIn.Size = New System.Drawing.Size(100, 22)
        Me.tls_ReadIn.Text = "读入已有乐曲"
        '
        'tls_btn_Save
        '
        Me.tls_btn_Save.Image = CType(resources.GetObject("tls_btn_Save.Image"), System.Drawing.Image)
        Me.tls_btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_btn_Save.Name = "tls_btn_Save"
        Me.tls_btn_Save.Size = New System.Drawing.Size(76, 22)
        Me.tls_btn_Save.Text = "保存乐曲"
        '
        'tls_ProduceCode
        '
        Me.tls_ProduceCode.Image = CType(resources.GetObject("tls_ProduceCode.Image"), System.Drawing.Image)
        Me.tls_ProduceCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_ProduceCode.Name = "tls_ProduceCode"
        Me.tls_ProduceCode.Size = New System.Drawing.Size(100, 22)
        Me.tls_ProduceCode.Text = "生成命令代码"
        '
        'btn_InsertNote
        '
        Me.btn_InsertNote.Location = New System.Drawing.Point(159, 328)
        Me.btn_InsertNote.Name = "btn_InsertNote"
        Me.btn_InsertNote.Size = New System.Drawing.Size(67, 31)
        Me.btn_InsertNote.TabIndex = 7
        Me.btn_InsertNote.Text = "插入音符"
        Me.ToolTip1.SetToolTip(Me.btn_InsertNote, "插入到选定音符的前面")
        Me.btn_InsertNote.UseVisualStyleBackColor = True
        '
        'btn_EditNote
        '
        Me.btn_EditNote.Location = New System.Drawing.Point(261, 328)
        Me.btn_EditNote.Name = "btn_EditNote"
        Me.btn_EditNote.Size = New System.Drawing.Size(67, 31)
        Me.btn_EditNote.TabIndex = 6
        Me.btn_EditNote.Text = "修改音符"
        Me.btn_EditNote.UseVisualStyleBackColor = True
        '
        'btn_DeleteNote
        '
        Me.btn_DeleteNote.Location = New System.Drawing.Point(363, 328)
        Me.btn_DeleteNote.Name = "btn_DeleteNote"
        Me.btn_DeleteNote.Size = New System.Drawing.Size(67, 31)
        Me.btn_DeleteNote.TabIndex = 5
        Me.btn_DeleteNote.Text = "删除音符"
        Me.btn_DeleteNote.UseVisualStyleBackColor = True
        '
        'btn_AddNote
        '
        Me.btn_AddNote.Location = New System.Drawing.Point(57, 328)
        Me.btn_AddNote.Name = "btn_AddNote"
        Me.btn_AddNote.Size = New System.Drawing.Size(67, 31)
        Me.btn_AddNote.TabIndex = 4
        Me.btn_AddNote.Text = "添加音符"
        Me.btn_AddNote.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbl_ReturnInformation)
        Me.TabPage2.Controls.Add(Me.lbl_ConnectPic)
        Me.TabPage2.Controls.Add(Me.lbl_SerialPortDataReceived)
        Me.TabPage2.Controls.Add(Me.dgv_Code)
        Me.TabPage2.Controls.Add(Me.btn_MechanismReset)
        Me.TabPage2.Controls.Add(Me.lbl_Connect)
        Me.TabPage2.Controls.Add(Me.btn_ConnectSerialPort)
        Me.TabPage2.Controls.Add(Me.combobox_PortNum)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btn_StopCodePlay)
        Me.TabPage2.Controls.Add(Me.btn_PlayOrPauseCodeFile)
        Me.TabPage2.Controls.Add(Me.btn_OpenCodeFile)
        Me.TabPage2.Controls.Add(Me.lbl_FileName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(486, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "播放区"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_ReturnInformation
        '
        Me.lbl_ReturnInformation.AutoSize = True
        Me.lbl_ReturnInformation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_ReturnInformation.Location = New System.Drawing.Point(287, 26)
        Me.lbl_ReturnInformation.Name = "lbl_ReturnInformation"
        Me.lbl_ReturnInformation.Size = New System.Drawing.Size(103, 12)
        Me.lbl_ReturnInformation.TabIndex = 15
        Me.lbl_ReturnInformation.Text = "下位机返回信息:"
        '
        'lbl_ConnectPic
        '
        Me.lbl_ConnectPic.ImageIndex = 1
        Me.lbl_ConnectPic.ImageList = Me.imglst_ConnectOrNot
        Me.lbl_ConnectPic.Location = New System.Drawing.Point(206, 22)
        Me.lbl_ConnectPic.Name = "lbl_ConnectPic"
        Me.lbl_ConnectPic.Size = New System.Drawing.Size(22, 20)
        Me.lbl_ConnectPic.TabIndex = 14
        '
        'imglst_ConnectOrNot
        '
        Me.imglst_ConnectOrNot.ImageStream = CType(resources.GetObject("imglst_ConnectOrNot.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst_ConnectOrNot.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst_ConnectOrNot.Images.SetKeyName(0, "yes")
        Me.imglst_ConnectOrNot.Images.SetKeyName(1, "no")
        '
        'lbl_SerialPortDataReceived
        '
        Me.lbl_SerialPortDataReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_SerialPortDataReceived.Location = New System.Drawing.Point(394, 22)
        Me.lbl_SerialPortDataReceived.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.lbl_SerialPortDataReceived.Name = "lbl_SerialPortDataReceived"
        Me.lbl_SerialPortDataReceived.Size = New System.Drawing.Size(70, 20)
        Me.lbl_SerialPortDataReceived.TabIndex = 13
        Me.lbl_SerialPortDataReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_Code
        '
        Me.dgv_Code.AllowUserToAddRows = False
        Me.dgv_Code.AllowUserToDeleteRows = False
        Me.dgv_Code.AllowUserToResizeRows = False
        Me.dgv_Code.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Code.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Code.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Code.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Code.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Code.Location = New System.Drawing.Point(19, 77)
        Me.dgv_Code.MultiSelect = False
        Me.dgv_Code.Name = "dgv_Code"
        Me.dgv_Code.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Code.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Code.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Code.RowTemplate.Height = 23
        Me.dgv_Code.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Code.Size = New System.Drawing.Size(445, 222)
        Me.dgv_Code.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "序号"
        Me.Column1.MinimumWidth = 40
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 54
        '
        'Column3
        '
        Me.Column3.HeaderText = "执行时长"
        Me.Column3.MinimumWidth = 60
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 78
        '
        'Column2
        '
        Me.Column2.HeaderText = "命令代码"
        Me.Column2.MinimumWidth = 300
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'btn_MechanismReset
        '
        Me.btn_MechanismReset.BackgroundImage = CType(resources.GetObject("btn_MechanismReset.BackgroundImage"), System.Drawing.Image)
        Me.btn_MechanismReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_MechanismReset.Enabled = False
        Me.btn_MechanismReset.Location = New System.Drawing.Point(357, 308)
        Me.btn_MechanismReset.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_MechanismReset.Name = "btn_MechanismReset"
        Me.btn_MechanismReset.Size = New System.Drawing.Size(57, 52)
        Me.btn_MechanismReset.TabIndex = 11
        Me.btn_MechanismReset.UseVisualStyleBackColor = True
        '
        'lbl_Connect
        '
        Me.lbl_Connect.AutoSize = True
        Me.lbl_Connect.Font = New System.Drawing.Font("宋体", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Connect.Location = New System.Drawing.Point(225, 25)
        Me.lbl_Connect.Name = "lbl_Connect"
        Me.lbl_Connect.Size = New System.Drawing.Size(52, 15)
        Me.lbl_Connect.TabIndex = 10
        Me.lbl_Connect.Text = "未连接"
        '
        'btn_ConnectSerialPort
        '
        Me.btn_ConnectSerialPort.Location = New System.Drawing.Point(133, 20)
        Me.btn_ConnectSerialPort.Name = "btn_ConnectSerialPort"
        Me.btn_ConnectSerialPort.Size = New System.Drawing.Size(54, 25)
        Me.btn_ConnectSerialPort.TabIndex = 8
        Me.btn_ConnectSerialPort.Text = "连接"
        Me.btn_ConnectSerialPort.UseVisualStyleBackColor = True
        '
        'combobox_PortNum
        '
        Me.combobox_PortNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_PortNum.FormattingEnabled = True
        Me.combobox_PortNum.Location = New System.Drawing.Point(65, 22)
        Me.combobox_PortNum.Name = "combobox_PortNum"
        Me.combobox_PortNum.Size = New System.Drawing.Size(61, 20)
        Me.combobox_PortNum.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "串口号"
        '
        'btn_StopCodePlay
        '
        Me.btn_StopCodePlay.BackgroundImage = CType(resources.GetObject("btn_StopCodePlay.BackgroundImage"), System.Drawing.Image)
        Me.btn_StopCodePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_StopCodePlay.Enabled = False
        Me.btn_StopCodePlay.Location = New System.Drawing.Point(261, 308)
        Me.btn_StopCodePlay.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_StopCodePlay.Name = "btn_StopCodePlay"
        Me.btn_StopCodePlay.Size = New System.Drawing.Size(57, 52)
        Me.btn_StopCodePlay.TabIndex = 5
        Me.btn_StopCodePlay.UseVisualStyleBackColor = True
        '
        'btn_PlayOrPauseCodeFile
        '
        Me.btn_PlayOrPauseCodeFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_PlayOrPauseCodeFile.Enabled = False
        Me.btn_PlayOrPauseCodeFile.ImageIndex = 0
        Me.btn_PlayOrPauseCodeFile.ImageList = Me.imglst_PlayOrPause
        Me.btn_PlayOrPauseCodeFile.Location = New System.Drawing.Point(165, 308)
        Me.btn_PlayOrPauseCodeFile.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_PlayOrPauseCodeFile.Name = "btn_PlayOrPauseCodeFile"
        Me.btn_PlayOrPauseCodeFile.Size = New System.Drawing.Size(57, 52)
        Me.btn_PlayOrPauseCodeFile.TabIndex = 3
        Me.btn_PlayOrPauseCodeFile.UseVisualStyleBackColor = True
        '
        'imglst_PlayOrPause
        '
        Me.imglst_PlayOrPause.ImageStream = CType(resources.GetObject("imglst_PlayOrPause.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst_PlayOrPause.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst_PlayOrPause.Images.SetKeyName(0, "play")
        Me.imglst_PlayOrPause.Images.SetKeyName(1, "pause")
        '
        'btn_OpenCodeFile
        '
        Me.btn_OpenCodeFile.BackgroundImage = CType(resources.GetObject("btn_OpenCodeFile.BackgroundImage"), System.Drawing.Image)
        Me.btn_OpenCodeFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_OpenCodeFile.Enabled = False
        Me.btn_OpenCodeFile.Location = New System.Drawing.Point(69, 307)
        Me.btn_OpenCodeFile.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_OpenCodeFile.Name = "btn_OpenCodeFile"
        Me.btn_OpenCodeFile.Size = New System.Drawing.Size(57, 52)
        Me.btn_OpenCodeFile.TabIndex = 2
        Me.btn_OpenCodeFile.UseVisualStyleBackColor = True
        '
        'lbl_FileName
        '
        Me.lbl_FileName.AutoSize = True
        Me.lbl_FileName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_FileName.ForeColor = System.Drawing.Color.Blue
        Me.lbl_FileName.Location = New System.Drawing.Point(17, 53)
        Me.lbl_FileName.Name = "lbl_FileName"
        Me.lbl_FileName.Size = New System.Drawing.Size(41, 12)
        Me.lbl_FileName.TabIndex = 0
        Me.lbl_FileName.Text = "文件名"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage3.Controls.Add(Me.Button17)
        Me.TabPage3.Controls.Add(Me.Button14)
        Me.TabPage3.Controls.Add(Me.Button13)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(486, 382)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "配置区"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(25, 47)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(85, 35)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "演奏速度配置"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(25, 218)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(85, 35)
        Me.Button14.TabIndex = 5
        Me.Button14.Text = "拨弦机构配置"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(25, 161)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(85, 35)
        Me.Button13.TabIndex = 4
        Me.Button13.Text = "扫弦机构配置"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(25, 104)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(85, 35)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "压弦机构配置"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.ParityReplace = CType(0, Byte)
        '
        'OpenFileDialog_Code
        '
        Me.OpenFileDialog_Code.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog_Melody
        '
        Me.OpenFileDialog_Melody.FileName = "OpenFileDialog2"
        '
        '主窗口
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 403)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "主窗口"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "电吉他机器人编曲控制软件"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_Composing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_EditNote As System.Windows.Forms.Button
    Friend WithEvents btn_DeleteNote As System.Windows.Forms.Button
    Friend WithEvents btn_AddNote As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tls_btn_New As System.Windows.Forms.ToolStripButton
    Friend WithEvents tls_ReadIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents tls_btn_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_InsertNote As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_StopCodePlay As System.Windows.Forms.Button
    Friend WithEvents btn_PlayOrPauseCodeFile As System.Windows.Forms.Button
    Friend WithEvents btn_OpenCodeFile As System.Windows.Forms.Button
    Friend WithEvents lbl_FileName As System.Windows.Forms.Label
    Friend WithEvents cmb_tempo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Speed As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Connect As System.Windows.Forms.Label
    Friend WithEvents btn_ConnectSerialPort As System.Windows.Forms.Button
    Friend WithEvents combobox_PortNum As System.Windows.Forms.ComboBox
    Friend WithEvents tls_ProduceCode As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_MechanismReset As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Code As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_SerialPortDataReceived As System.Windows.Forms.Label
    Friend WithEvents imglst_ConnectOrNot As System.Windows.Forms.ImageList
    Friend WithEvents imglst_PlayOrPause As System.Windows.Forms.ImageList
    Friend WithEvents lbl_ConnectPic As System.Windows.Forms.Label
    Friend WithEvents lbl_ReturnInformation As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_Code As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Composing As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog_Melody As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog_Melody As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog_Code As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbl_MelodyName As System.Windows.Forms.Label
    Friend WithEvents 小节 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

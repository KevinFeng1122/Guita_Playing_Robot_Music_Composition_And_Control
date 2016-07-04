<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 音符
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(音符))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_Scan = New System.Windows.Forms.TextBox
        Me.txt_poke = New System.Windows.Forms.TextBox
        Me.rdo_scan = New System.Windows.Forms.RadioButton
        Me.rdo_poke = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_SelectChord = New System.Windows.Forms.Button
        Me.txt_Chord = New System.Windows.Forms.TextBox
        Me.cmb_Value = New System.Windows.Forms.ComboBox
        Me.txt_Remark = New System.Windows.Forms.TextBox
        Me.nud_Bar = New System.Windows.Forms.NumericUpDown
        Me.btn_Ok = New System.Windows.Forms.Button
        Me.btn_Cancle = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "小节"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "和弦"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Scan)
        Me.GroupBox1.Controls.Add(Me.txt_poke)
        Me.GroupBox1.Controls.Add(Me.rdo_scan)
        Me.GroupBox1.Controls.Add(Me.rdo_poke)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "拨弦/扫弦"
        '
        'txt_Scan
        '
        Me.txt_Scan.Location = New System.Drawing.Point(95, 60)
        Me.txt_Scan.Name = "txt_Scan"
        Me.txt_Scan.Size = New System.Drawing.Size(86, 21)
        Me.txt_Scan.TabIndex = 3
        '
        'txt_poke
        '
        Me.txt_poke.Location = New System.Drawing.Point(97, 22)
        Me.txt_poke.Name = "txt_poke"
        Me.txt_poke.Size = New System.Drawing.Size(85, 21)
        Me.txt_poke.TabIndex = 2
        '
        'rdo_scan
        '
        Me.rdo_scan.AutoSize = True
        Me.rdo_scan.Location = New System.Drawing.Point(28, 60)
        Me.rdo_scan.Name = "rdo_scan"
        Me.rdo_scan.Size = New System.Drawing.Size(47, 16)
        Me.rdo_scan.TabIndex = 1
        Me.rdo_scan.TabStop = True
        Me.rdo_scan.Text = "扫弦"
        Me.rdo_scan.UseVisualStyleBackColor = True
        '
        'rdo_poke
        '
        Me.rdo_poke.AutoSize = True
        Me.rdo_poke.Location = New System.Drawing.Point(28, 27)
        Me.rdo_poke.Name = "rdo_poke"
        Me.rdo_poke.Size = New System.Drawing.Size(47, 16)
        Me.rdo_poke.TabIndex = 0
        Me.rdo_poke.TabStop = True
        Me.rdo_poke.Text = "拨弦"
        Me.rdo_poke.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "时值"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "备注"
        '
        'btn_SelectChord
        '
        Me.btn_SelectChord.Location = New System.Drawing.Point(172, 65)
        Me.btn_SelectChord.Name = "btn_SelectChord"
        Me.btn_SelectChord.Size = New System.Drawing.Size(57, 27)
        Me.btn_SelectChord.TabIndex = 6
        Me.btn_SelectChord.Text = "选择"
        Me.btn_SelectChord.UseVisualStyleBackColor = True
        '
        'txt_Chord
        '
        Me.txt_Chord.Enabled = False
        Me.txt_Chord.Location = New System.Drawing.Point(87, 71)
        Me.txt_Chord.Name = "txt_Chord"
        Me.txt_Chord.Size = New System.Drawing.Size(72, 21)
        Me.txt_Chord.TabIndex = 7
        Me.txt_Chord.TabStop = False
        '
        'cmb_Value
        '
        Me.cmb_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Value.FormattingEnabled = True
        Me.cmb_Value.Items.AddRange(New Object() {"全音符", "二分音符", "四分音符", "八分音符", "十六分音符"})
        Me.cmb_Value.Location = New System.Drawing.Point(96, 225)
        Me.cmb_Value.Name = "cmb_Value"
        Me.cmb_Value.Size = New System.Drawing.Size(95, 20)
        Me.cmb_Value.TabIndex = 8
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(93, 265)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(166, 21)
        Me.txt_Remark.TabIndex = 9
        '
        'nud_Bar
        '
        Me.nud_Bar.Location = New System.Drawing.Point(118, 29)
        Me.nud_Bar.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_Bar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Bar.Name = "nud_Bar"
        Me.nud_Bar.Size = New System.Drawing.Size(60, 21)
        Me.nud_Bar.TabIndex = 10
        Me.nud_Bar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_Ok
        '
        Me.btn_Ok.Location = New System.Drawing.Point(43, 301)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(69, 28)
        Me.btn_Ok.TabIndex = 11
        Me.btn_Ok.Text = "确认"
        Me.btn_Ok.UseVisualStyleBackColor = True
        '
        'btn_Cancle
        '
        Me.btn_Cancle.Location = New System.Drawing.Point(166, 303)
        Me.btn_Cancle.Name = "btn_Cancle"
        Me.btn_Cancle.Size = New System.Drawing.Size(68, 26)
        Me.btn_Cancle.TabIndex = 12
        Me.btn_Cancle.Text = "取消"
        Me.btn_Cancle.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "第"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "小节"
        '
        '音符
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 347)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Cancle)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.nud_Bar)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.cmb_Value)
        Me.Controls.Add(Me.txt_Chord)
        Me.Controls.Add(Me.btn_SelectChord)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "音符"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "音符"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_scan As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_poke As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_SelectChord As System.Windows.Forms.Button
    Friend WithEvents txt_Chord As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Value As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Remark As System.Windows.Forms.TextBox
    Friend WithEvents txt_poke As System.Windows.Forms.TextBox
    Friend WithEvents nud_Bar As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_Ok As System.Windows.Forms.Button
    Friend WithEvents btn_Cancle As System.Windows.Forms.Button
    Friend WithEvents txt_Scan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

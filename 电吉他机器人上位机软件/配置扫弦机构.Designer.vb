<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 配置扫弦机构
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(配置扫弦机构))
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.NumericUpDown_zhong_duo_ji = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumericUpDown_solenoid_id = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown_xiao_duo_ji = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumericUpDown_up_pw = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumericUpDown_down_pw = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.NumericUpDown_zhong_duo_ji, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_solenoid_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_xiao_duo_ji, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_up_pw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_down_pw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 29)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 29)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "及各扫线位置PW值"
        '
        'NumericUpDown_zhong_duo_ji
        '
        Me.NumericUpDown_zhong_duo_ji.Location = New System.Drawing.Point(108, 102)
        Me.NumericUpDown_zhong_duo_ji.Name = "NumericUpDown_zhong_duo_ji"
        Me.NumericUpDown_zhong_duo_ji.Size = New System.Drawing.Size(45, 21)
        Me.NumericUpDown_zhong_duo_ji.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "中型机构舵机ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 44
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(283, 43)
        Me.DataGridView1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "PW1"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "PW2"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 40
        '
        'Column3
        '
        Me.Column3.HeaderText = "PW3"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 40
        '
        'Column4
        '
        Me.Column4.HeaderText = "PW4"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 40
        '
        'Column5
        '
        Me.Column5.HeaderText = "PW5"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 40
        '
        'Column6
        '
        Me.Column6.HeaderText = "PW6"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 40
        '
        'Column7
        '
        Me.Column7.HeaderText = "PW7"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 40
        '
        'NumericUpDown_solenoid_id
        '
        Me.NumericUpDown_solenoid_id.Location = New System.Drawing.Point(89, 32)
        Me.NumericUpDown_solenoid_id.Name = "NumericUpDown_solenoid_id"
        Me.NumericUpDown_solenoid_id.Size = New System.Drawing.Size(45, 21)
        Me.NumericUpDown_solenoid_id.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "升降电磁铁ID"
        '
        'NumericUpDown_xiao_duo_ji
        '
        Me.NumericUpDown_xiao_duo_ji.Location = New System.Drawing.Point(89, 65)
        Me.NumericUpDown_xiao_duo_ji.Name = "NumericUpDown_xiao_duo_ji"
        Me.NumericUpDown_xiao_duo_ji.Size = New System.Drawing.Size(45, 21)
        Me.NumericUpDown_xiao_duo_ji.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "小型舵机ID"
        '
        'NumericUpDown_up_pw
        '
        Me.NumericUpDown_up_pw.Location = New System.Drawing.Point(235, 32)
        Me.NumericUpDown_up_pw.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown_up_pw.Name = "NumericUpDown_up_pw"
        Me.NumericUpDown_up_pw.Size = New System.Drawing.Size(45, 21)
        Me.NumericUpDown_up_pw.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "上扫弦(6→1)PW"
        '
        'NumericUpDown_down_pw
        '
        Me.NumericUpDown_down_pw.Location = New System.Drawing.Point(235, 67)
        Me.NumericUpDown_down_pw.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown_down_pw.Name = "NumericUpDown_down_pw"
        Me.NumericUpDown_down_pw.Size = New System.Drawing.Size(45, 21)
        Me.NumericUpDown_down_pw.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "下扫弦(1→6)PW"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "（注：1弦右边的位置为1，6弦左边的位置为7）"
        '
        '配置扫弦机构
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 250)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown_down_pw)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown_up_pw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown_xiao_duo_ji)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown_solenoid_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown_zhong_duo_ji)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "配置扫弦机构"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "配置扫弦机构"
        CType(Me.NumericUpDown_zhong_duo_ji, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_solenoid_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_xiao_duo_ji, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_up_pw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_down_pw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_zhong_duo_ji As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NumericUpDown_solenoid_id As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_xiao_duo_ji As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_up_pw As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_down_pw As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

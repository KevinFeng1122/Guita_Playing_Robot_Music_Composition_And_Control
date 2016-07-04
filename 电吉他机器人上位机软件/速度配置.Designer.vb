<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 速度配置
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(速度配置))
        Me.nud_small_solenoid_down_time = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.nud_small_solenoid_up_time = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.nud_big_solenoid_down_time = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.nud_big_solenoid_up_time = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.nud_small_solenoid_down_time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_small_solenoid_up_time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_big_solenoid_down_time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_big_solenoid_up_time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nud_small_solenoid_down_time
        '
        Me.nud_small_solenoid_down_time.Location = New System.Drawing.Point(144, 119)
        Me.nud_small_solenoid_down_time.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nud_small_solenoid_down_time.Name = "nud_small_solenoid_down_time"
        Me.nud_small_solenoid_down_time.Size = New System.Drawing.Size(45, 21)
        Me.nud_small_solenoid_down_time.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 12)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "小电磁铁断电响应时间"
        '
        'nud_small_solenoid_up_time
        '
        Me.nud_small_solenoid_up_time.Location = New System.Drawing.Point(144, 84)
        Me.nud_small_solenoid_up_time.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nud_small_solenoid_up_time.Name = "nud_small_solenoid_up_time"
        Me.nud_small_solenoid_up_time.Size = New System.Drawing.Size(45, 21)
        Me.nud_small_solenoid_up_time.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 12)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "小电磁铁通电响应时间"
        '
        'nud_big_solenoid_down_time
        '
        Me.nud_big_solenoid_down_time.Location = New System.Drawing.Point(144, 50)
        Me.nud_big_solenoid_down_time.Name = "nud_big_solenoid_down_time"
        Me.nud_big_solenoid_down_time.Size = New System.Drawing.Size(45, 21)
        Me.nud_big_solenoid_down_time.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 12)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "大电磁铁断电响应时间"
        '
        'nud_big_solenoid_up_time
        '
        Me.nud_big_solenoid_up_time.Location = New System.Drawing.Point(144, 17)
        Me.nud_big_solenoid_up_time.Name = "nud_big_solenoid_up_time"
        Me.nud_big_solenoid_up_time.Size = New System.Drawing.Size(45, 21)
        Me.nud_big_solenoid_up_time.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 12)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "大电磁铁通电响应时间"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 29)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 29)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '速度配置
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 195)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nud_small_solenoid_down_time)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nud_small_solenoid_up_time)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nud_big_solenoid_down_time)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nud_big_solenoid_up_time)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "速度配置"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "速度配置"
        CType(Me.nud_small_solenoid_down_time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_small_solenoid_up_time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_big_solenoid_down_time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_big_solenoid_up_time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nud_small_solenoid_down_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nud_small_solenoid_up_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nud_big_solenoid_down_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nud_big_solenoid_up_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

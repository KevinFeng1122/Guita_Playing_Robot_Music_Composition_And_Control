<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 串口通信测试
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(串口通信测试))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lbl_Connect = New System.Windows.Forms.Label
        Me.btn_ConnectSerialPort = New System.Windows.Forms.Button
        Me.combobox_PortNum = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.RtsEnable = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "发送"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 21)
        Me.TextBox1.TabIndex = 1
        '
        'lbl_Connect
        '
        Me.lbl_Connect.AutoSize = True
        Me.lbl_Connect.Font = New System.Drawing.Font("宋体", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Connect.Location = New System.Drawing.Point(239, 21)
        Me.lbl_Connect.Name = "lbl_Connect"
        Me.lbl_Connect.Size = New System.Drawing.Size(52, 15)
        Me.lbl_Connect.TabIndex = 18
        Me.lbl_Connect.Text = "未连接"
        '
        'btn_ConnectSerialPort
        '
        Me.btn_ConnectSerialPort.Location = New System.Drawing.Point(147, 15)
        Me.btn_ConnectSerialPort.Name = "btn_ConnectSerialPort"
        Me.btn_ConnectSerialPort.Size = New System.Drawing.Size(57, 27)
        Me.btn_ConnectSerialPort.TabIndex = 17
        Me.btn_ConnectSerialPort.Text = "连接"
        Me.btn_ConnectSerialPort.UseVisualStyleBackColor = True
        '
        'combobox_PortNum
        '
        Me.combobox_PortNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_PortNum.FormattingEnabled = True
        Me.combobox_PortNum.Location = New System.Drawing.Point(79, 18)
        Me.combobox_PortNum.Name = "combobox_PortNum"
        Me.combobox_PortNum.Size = New System.Drawing.Size(61, 20)
        Me.combobox_PortNum.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "串口号"
        '
        '串口通信测试
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 122)
        Me.Controls.Add(Me.lbl_Connect)
        Me.Controls.Add(Me.btn_ConnectSerialPort)
        Me.Controls.Add(Me.combobox_PortNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "串口通信测试"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "串口通信测试"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Connect As System.Windows.Forms.Label
    Friend WithEvents btn_ConnectSerialPort As System.Windows.Forms.Button
    Friend WithEvents combobox_PortNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

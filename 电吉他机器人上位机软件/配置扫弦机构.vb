Public Class 配置扫弦机构
    Dim MainForm As 主窗口
    Public Sub New(ByVal pform As Form)
        InitializeComponent()
        MainForm = pform
    End Sub

    Private Sub 配置扫弦机构_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
    End Sub

    Private Sub 配置扫弦机构_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '↓加载DataGridView1
        DataGridView1.Rows.Add("", "", "", "", "", "")
        '↓读取ini文件中的参数到NumericUpDown控件
        NumericUpDown_solenoid_id.Value = Val(GetINI(IniFilePath, "SX", "solenoid"))
        NumericUpDown_xiao_duo_ji.Value = Val(GetINI(IniFilePath, "SX", "little_motor_id"))
        NumericUpDown_up_pw.Value = Val(GetINI(IniFilePath, "SX", "little_motor_up_pw"))
        NumericUpDown_down_pw.Value = Val(GetINI(IniFilePath, "SX", "little_motor_down_pw"))
        NumericUpDown_zhong_duo_ji.Value = Val(GetINI(IniFilePath, "SX", "middle_motor_id"))
        '↓读取ini文件中的参数到DatagridView1
        Dim k As Short
        For k = 0 To 6
            DataGridView1.Rows(0).Cells(k).Value = GetINI(IniFilePath, "SX", "middle_motor_pw" & (k + 1))
        Next k
    End Sub

    Public Sub SaveConfiguration()
        '↓将DatagridView1中的数据保存到ini文件中
        Dim k As Short
        For k = 0 To 6
            WriteINI(IniFilePath, "SX", "middle_motor_pw" & (k + 1), DataGridView1.Rows(0).Cells(k).Value)
        Next k
        '↓将NumericUpDown中的数据保存到ini文件中
        WriteINI(IniFilePath, "SX", "solenoid", NumericUpDown_solenoid_id.Value.ToString)
        WriteINI(IniFilePath, "SX", "little_motor_id", NumericUpDown_xiao_duo_ji.Value.ToString)
        WriteINI(IniFilePath, "SX", "little_motor_up_pw", NumericUpDown_up_pw.Value.ToString)
        WriteINI(IniFilePath, "SX", "little_motor_down_pw", NumericUpDown_down_pw.Value.ToString)
        WriteINI(IniFilePath, "SX", "middle_motor_id", NumericUpDown_zhong_duo_ji.Value.ToString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveConfiguration()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
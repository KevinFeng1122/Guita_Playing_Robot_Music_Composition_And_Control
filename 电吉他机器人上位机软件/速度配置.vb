Public Class 速度配置
    Dim MainForm As 主窗口

    Public Sub New(ByVal pform As Form)
        InitializeComponent()
        MainForm = pform
    End Sub

    Private Sub 速度配置_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
    End Sub

    Private Sub 速度配置_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '↓读取ini文件中的参数到NumericUpDown控件
        nud_big_solenoid_up_time.Value = Val(GetINI(IniFilePath, "SD", "big_solenoid_up"))
        nud_big_solenoid_down_time.Value = Val(GetINI(IniFilePath, "SD", "big_solenoid_down"))
        nud_small_solenoid_up_time.Value = Val(GetINI(IniFilePath, "SD", "small_solenoid_up"))
        nud_small_solenoid_down_time.Value = Val(GetINI(IniFilePath, "SD", "small_solenoid_down"))
    End Sub

    Public Sub SaveConfiguration()
        '↓将NumericUpDown中的数据保存到ini文件中
        WriteINI(IniFilePath, "SD", "big_solenoid_up", nud_big_solenoid_up_time.Value.ToString)
        WriteINI(IniFilePath, "SD", "big_solenoid_down", nud_big_solenoid_down_time.Value.ToString)
        WriteINI(IniFilePath, "SD", "small_solenoid_up", nud_small_solenoid_up_time.Value.ToString)
        WriteINI(IniFilePath, "SD", "small_solenoid_down", nud_small_solenoid_down_time.Value.ToString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveConfiguration()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
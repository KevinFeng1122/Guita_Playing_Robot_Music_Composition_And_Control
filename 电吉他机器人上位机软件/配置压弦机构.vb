Public Class 配置压弦机构
    Dim MainForm As 主窗口
    Public Sub New(ByVal pform As Form)
        InitializeComponent()
        MainForm = pform
    End Sub

    Private Sub 配置压弦机构_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '↓加载DataGridView1
        DataGridView1.Rows.Add("", "", "", "", "", "")
        '↓加载DataGridView2
        DataGridView2.Rows.Add("", "", "", "", "", "")
        DataGridView2.Rows.Add("", "", "", "", "", "")
        DataGridView2.Rows.Add("", "", "", "", "", "")

        '↓读取ini文件中的参数到DatagridView
        '压弦电磁铁的参数，DataGridView2
        Dim i As Short
        Dim j As Short
        For i = 0 To 2 '行，对应着品位
            For j = 0 To 5 '列，对应着弦号
                DataGridView2.Rows(i).Cells(j).Value = GetINI(IniFilePath, "YX", "p" & (i + 1) & "x" & (j + 1))
            Next j
        Next i
        '移动舵机的参数，DataGridView1
        NumericUpDown1.Value = Val(GetINI(IniFilePath, "YX", "id"))
        Dim k As Short
        For k = 0 To 6
            DataGridView1.Rows(0).Cells(k).Value = GetINI(IniFilePath, "YX", "d" & (k + 1))
        Next k
    End Sub

    Private Sub 配置压弦机构_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
    End Sub

    Public Sub SaveConfiguration()
        '↓将DatagridView中的数据保存到ini文件中

        '压弦电磁铁的参数，DataGridView2
        Dim i As Short
        Dim j As Short
        For i = 0 To 2 '行，对应着品位
            For j = 0 To 5 '列，对应着弦号
                WriteINI(IniFilePath, "YX", "p" & (i + 1) & "x" & (j + 1), DataGridView2.Rows(i).Cells(j).Value)
            Next j
        Next i

        '移动舵机的参数，DataGridView1
        WriteINI(IniFilePath, "YX", "id", NumericUpDown1.Value.ToString)
        Dim k As Short
        For k = 0 To 6
            WriteINI(IniFilePath, "YX", "d" & (k + 1), DataGridView1.Rows(0).Cells(k).Value)
        Next k
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveConfiguration()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
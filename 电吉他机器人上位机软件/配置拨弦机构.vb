Public Class 配置拨弦机构
    Dim MainForm As 主窗口
    Public Sub New(ByVal pform As Form)
        InitializeComponent()
        MainForm = pform
    End Sub

    Private Sub 配置拨弦机构_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
    End Sub

    Private Sub 配置拨弦机构_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '↓加载DataGridView2
        DataGridView2.Rows.Add("", "", "", "", "", "")
        DataGridView2.Rows.Add("", "", "", "", "", "")
        DataGridView2.Rows.Add("", "", "", "", "", "")
        '↓读取ini文件中的参数到DatagridView2
        Dim i As Short
        Dim j As Short
        For i = 0 To 2 '行
            For j = 0 To 5 '列，对应着弦号
                Select Case i
                    Case 0 '各舵机的ID
                        DataGridView2.Rows(i).Cells(j).Value = GetINI(IniFilePath, "BX", "idx" & (j + 1))
                    Case 1 'PW1值
                        DataGridView2.Rows(i).Cells(j).Value = GetINI(IniFilePath, "BX", "p1x" & (j + 1))
                    Case 2 'PW2值
                        DataGridView2.Rows(i).Cells(j).Value = GetINI(IniFilePath, "BX", "p2x" & (j + 1))
                End Select
            Next j
        Next i
    End Sub

    Public Sub SaveConfiguration()
        '↓将DatagridView2中的数据保存到ini文件中
        Dim i As Short
        Dim j As Short
        For i = 0 To 2 '行
            For j = 0 To 5 '列，对应着弦号
                Select Case i
                    Case 0 '各舵机的ID
                        WriteINI(IniFilePath, "BX", "idx" & (j + 1), DataGridView2.Rows(i).Cells(j).Value)
                    Case 1 'PW1值
                        WriteINI(IniFilePath, "BX", "p1x" & (j + 1), DataGridView2.Rows(i).Cells(j).Value)
                    Case 2 'PW2值
                        WriteINI(IniFilePath, "BX", "p2x" & (j + 1), DataGridView2.Rows(i).Cells(j).Value)
                End Select
            Next j
        Next i
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveConfiguration()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
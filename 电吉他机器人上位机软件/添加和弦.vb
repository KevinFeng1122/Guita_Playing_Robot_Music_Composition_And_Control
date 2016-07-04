Imports System.Data.OleDb
Public Class 添加和弦
    Dim SelectChordForm As 选择和弦
    Public Sub New(ByVal pForm As Form)
        InitializeComponent() ' 此调用是 Windows 窗体设计器所必需的。
        SelectChordForm = pForm
    End Sub

    Private Sub 添加和弦_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(False, False, False, False, False, False)
        DataGridView1.Rows.Add(False, False, False, False, False, False)
        DataGridView1.Rows.Add(False, False, False, False, False, False)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        '↓检查输入的和弦名称
        If txt_chordName.Text = "" Then
            MsgBox("和弦名称不得为空")
            Exit Sub
        End If
        If HaveTheSameName(txt_chordName.Text) Then
            MsgBox("不可与已有的和弦重名！")
            Exit Sub
        End If
        Dim startChar As String = txt_chordName.Text.First
        Select Case startChar
            Case "#", "b", "A", "B", "C", "D", "E", "F", "G"
                Exit Select
            Case Else
                MsgBox("和弦名称必须以#、b、A、B、C、D、E、F、G中的一个作为开头")
                Exit Sub
        End Select

        '↓构建和弦信息字符串
        '（一定注意该字符串的所存储信息的顺序：低品-高品，6弦-1弦）
        Dim ChordInformation As String = ""
        Dim i As Short
        Dim j As Short
        For i = 0 To 2
            For j = 0 To 5
                If DataGridView1.Rows(i).Cells(j).Value = True Then
                    ChordInformation = ChordInformation & "H"
                Else
                    ChordInformation = ChordInformation & "L"
                End If
            Next
        Next

        '↓将和弦信息保存到数据库中
        Dim mySql As String = " Insert into 和弦库(和弦名称,压弦情况,最低品位,来源)" & _
                   " Values('" & txt_chordName.Text & "','" & ChordInformation & "','" & NumericUpDown1.Value.ToString & "','自定义 ')"
        Using myConnection As New OleDbConnection
            myConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            My.Application.Info.DirectoryPath & "\吉他和弦库.mdb"
            Dim myCommand As New OleDbCommand
            myCommand.CommandText = mySql
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            myConnection.Close()
        End Using

        '↓调用选择和弦窗口的函数更新内容，然后关闭本窗口
        SelectChordForm.ShowData()
        Me.Close()
    End Sub

    Private Sub btn_Cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancle.Click
        Me.Close()
    End Sub

    Private Function HaveTheSameName(ByVal name As String) As Boolean
        Dim strConnection_String As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            My.Application.Info.DirectoryPath & "\吉他和弦库.mdb"
        Dim mySql As String
        mySql = "Select * From 和弦库 Where 和弦名称 = '" & name & "'"
        Using Data_Adapter As New OleDbDataAdapter(mySql, strConnection_String)
            Dim Data_Set As New DataSet()
            Dim Data_Table As DataTable
            Data_Adapter.Fill(Data_Set, "Data")
            Data_Table = Data_Set.Tables("Data")
            If Data_Table.Rows.Count > 0 Then
                Return True
            End If
        End Using
    End Function

End Class
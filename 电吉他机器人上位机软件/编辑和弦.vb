Imports System.Data.OleDb
Public Class 编辑和弦
    Dim ChordName As String
    Dim SelectChordForm As 选择和弦
    Dim ChordInformation As String

    Public Sub New(ByVal pform As Form, ByVal name As String)
        InitializeComponent()  ' 此调用是 Windows 窗体设计器所必需的。
        SelectChordForm = pform
        ChordName = name
    End Sub

    Private Sub 编辑和弦_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_chordName.Text = ChordName

        '↓加载DataGridView
        DataGridView1.Rows.Add(False, False, False, False, False, False)
        DataGridView1.Rows.Add(False, False, False, False, False, False)
        DataGridView1.Rows.Add(False, False, False, False, False, False)

        '↓获得和弦信息字符串
        Dim Sql As String = "Select * from 和弦库 where 和弦名称 = '" & ChordName & "'"
        Dim strConnection_String As String = _
        "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\吉他和弦库.mdb"
        Using Data_Adapter As New OleDbDataAdapter(Sql, strConnection_String)
            Dim Data_Set As New DataSet()
            Dim Data_Table As DataTable
            Data_Adapter.Fill(Data_Set, "Data")
            Data_Table = Data_Set.Tables("Data")
            ChordInformation = Data_Table.Rows(0).Item(1)
            nud_Position.Value = Val(Data_Table.Rows(0).Item(2))
        End Using

        '↓在DataGridView中将信息表现出来
        Dim i As Short
        Dim j As Short
        For i = 0 To 2
            For j = 0 To 5
                If ChordInformation.ElementAt(i * 6 + j) = "H" Then
                    DataGridView1.Rows(i).Cells(j).Value = True
                Else
                    DataGridView1.Rows(i).Cells(j).Value = False
                End If
            Next j
        Next i

        '删除原有的
        Dim sqlstr_Delete As String = "Delete From 和弦库 where 和弦名称 = '" & ChordName & "' "
        Using oledcmmd As New OleDbCommand(sqlstr_Delete)
            With oledcmmd
                .Connection = New OleDbConnection(strConnection_String)
                .Connection.Open()
                .ExecuteReader()
                .Connection.Close()
            End With
        End Using
    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
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
        Dim ChordInformation2 As String = ""
        Dim i As Short
        Dim j As Short
        For i = 0 To 2
            For j = 0 To 5
                If DataGridView1.Rows(i).Cells(j).Value = True Then
                    ChordInformation2 = ChordInformation2 & "H"
                Else
                    ChordInformation2 = ChordInformation2 & "L"
                End If
            Next j
        Next i

        '↓将新的和弦信息更新到数据库中
        Using myConnection As New OleDbConnection
            myConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            My.Application.Info.DirectoryPath & "\吉他和弦库.mdb"
            Dim mySql As String = " Insert into 和弦库(和弦名称,压弦情况,最低品位,来源)" & _
                         " Values('" & txt_chordName.Text & "','" & ChordInformation2 & "','" & nud_Position.Value.ToString & "','自定义 ')"
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

    Private Sub btn_Cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancle.Click
        '↓将Load时间中删除的和弦信息保存到数据库中
        Dim mySql As String = " Insert into 和弦库(和弦名称,压弦情况,最低品位,来源)" & _
                   " Values('" & txt_chordName.Text & "','" & ChordInformation & "','" & nud_Position.Value.ToString & "','自定义 ')"
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
        Me.Close()
    End Sub

End Class
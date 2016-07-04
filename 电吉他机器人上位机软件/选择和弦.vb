Imports System.Data.OleDb
Public Class 选择和弦
    Dim NoteForm As 音符

    Public Sub New(ByVal pform As Form)
        InitializeComponent() ' 此调用是 Windows 窗体设计器所必需的。
        NoteForm = pform
    End Sub

    Private Sub 选择和弦_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Public Sub ShowData()

        '↓清除原有内容
        If ListView1.Items.Count <> 0 Then
            ListView1.Items.Clear()
        End If

        '↓添加软件自带和弦
        With ListView1
            .Items.Add("#Cm", 0)
            .Items.Add("#Dm", 1)
            .Items.Add("#F", 2)
            .Items.Add("#F7", 3)
            .Items.Add("#Fm", 4)
            .Items.Add("#Gm", 5)
            .Items.Add("A", 6)
            .Items.Add("A7", 7)
            .Items.Add("Am", 8)
            .Items.Add("B", 9)
            .Items.Add("B7", 10)
            .Items.Add("bB", 11)
            .Items.Add("Bm", 12)
            .Items.Add("C", 13)
            .Items.Add("C7", 14)
            .Items.Add("D", 15)
            .Items.Add("D7", 16)
            .Items.Add("Dm", 17)
            .Items.Add("E", 18)
            .Items.Add("E7", 19)
            .Items.Add("Em", 20)
            .Items.Add("F", 21)
            .Items.Add("G", 22)
            .Items.Add("G7", 23)
            .Items.Add("Gm", 24)
        End With

        '↓读取用户自定义的和弦
        '1:根据要求得到DataTable
        Dim Sql As String = "Select * from 和弦库 where 来源 = '自定义'"
        Dim strConnection_String As String = _
        "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\吉他和弦库.mdb"
        Using Data_Adapter As New OleDbDataAdapter(Sql, strConnection_String)
            Dim Data_Set As New DataSet()
            Dim Data_Table As DataTable
            Data_Adapter.Fill(Data_Set, "Data")
            Data_Table = Data_Set.Tables("Data")
            '2:将DataTable的内容填入listview中
            Dim i As Short
            For i = 0 To Data_Table.Rows.Count - 1
                ListView1.Items.Add(Data_Table.Rows(i).Item(0), 25)
            Next i
        End Using

        '↓进行分组
        Dim Listview_Item As ListViewItem
        Dim FirstLetter As String
        For Each Listview_Item In ListView1.Items
            FirstLetter = Microsoft.VisualBasic.Left(Listview_Item.Text, 1)
            Listview_Item.Group = ListView1.Groups("lsvGroup" & FirstLetter)
        Next
        '↓排序
        ListView1.Sorting = SortOrder.Ascending
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        SendChord()
        Me.Close()
    End Sub

    Private Sub SendChord()
        Dim myChord As String
        myChord = ListView1.SelectedItems(0).Text
        NoteForm.GiveChordName(myChord)
    End Sub

    '↓有关上下文菜单的代码

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.SelectedItems.Count = 0 Then
            编辑和弦ToolStripMenuItem.Visible = False
        Else
            If ListView1.SelectedItems(0).ImageIndex = 25 Then
                编辑和弦ToolStripMenuItem.Visible = True
            Else
                编辑和弦ToolStripMenuItem.Visible = False
            End If
        End If
    End Sub

    Private Sub 仅显示文字ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 仅显示文字ToolStripMenuItem.Click
        If 仅显示文字ToolStripMenuItem.Checked Then
            ListView1.View = View.SmallIcon
        Else
            ListView1.View = View.LargeIcon
        End If
    End Sub

    Private Sub 新增和弦ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新增和弦ToolStripMenuItem.Click
        Dim AddNewChordForm As New 添加和弦(Me)
        AddNewChordForm.ShowDialog()
    End Sub

    Private Sub 编辑和弦ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 编辑和弦ToolStripMenuItem.Click
        Dim EditChordForm As New 编辑和弦(Me, ListView1.SelectedItems(0).Text)
        EditChordForm.ShowDialog()
    End Sub
End Class
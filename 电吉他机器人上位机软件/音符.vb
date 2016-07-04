Public Class 音符

    Dim MainForm As 主窗口
    Dim FunctionNum As Short

    Public Sub New(ByRef pForm As Form, ByVal Num As Short, ByVal Title As String)
        InitializeComponent() ' 此调用是 Windows 窗体设计器所必需的。
        MainForm = pForm
        FunctionNum = Num
        Me.Text = Title
        txt_Scan.Enabled = False
        cmb_Value.SelectedIndex = 2
        If FunctionNum = NoteFormFunction.Edit Then
            ShowData()
        ElseIf FunctionNum = NoteFormFunction.Add Then
            nud_Bar.Value = 主窗口.GetNextBarNum
            txt_Chord.Text = 主窗口.GetNextChordName
        Else
            nud_Bar.Value = 主窗口.GetCurrentNoteInformation.BarNum
        End If
    End Sub

    Private Sub btn_Cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click
        '检查信息
        If Not CheckData() Then
            Exit Sub
        End If
        '通过检查后返回主窗口
        Dim BarNum As Short
        Dim Chord As String
        Dim Pluck As String
        Dim Value As String
        Dim Remark As String
        BarNum = nud_Bar.Value
        Chord = txt_Chord.Text
        If rdo_poke.Checked Then
            Pluck = "拨" & txt_poke.Text
        Else
            Pluck = "扫" & txt_Scan.Text
        End If
        Value = cmb_Value.Text
        Remark = txt_Remark.Text
        Select Case FunctionNum
            Case NoteFormFunction.Add
                主窗口.AddNoteInto_dgv_Composing(BarNum, Chord, Pluck, Value, Remark)
            Case NoteFormFunction.Insert
                主窗口.InsertNoteInto_dgv_Composing(BarNum, Chord, Pluck, Value, Remark)
            Case NoteFormFunction.Edit
                主窗口.EditNoteFrom_dgv_Composing(BarNum, Chord, Pluck, Value, Remark)
        End Select
        Me.Close()
    End Sub

    Private Sub ShowData()
        nud_Bar.Value = 主窗口.GetCurrentNoteInformation.BarNum
        txt_Chord.Text = 主窗口.GetCurrentNoteInformation.Chord

        Dim pluck As String = 主窗口.GetCurrentNoteInformation.Pluck
        Dim pluckOption As String = pluck.First
        Dim pluckNum As String = Microsoft.VisualBasic.Right(pluck, pluck.Length - 1)
        If pluckOption = "拨" Then
            rdo_poke.Checked = True
            txt_poke.Text = pluckNum
        Else
            rdo_scan.Checked = True
            txt_Scan.Text = pluckNum
        End If

        cmb_Value.Text = 主窗口.GetCurrentNoteInformation.Value
        txt_Remark.Text = 主窗口.GetCurrentNoteInformation.Remark
    End Sub

    Private Sub rdo_poke_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_poke.CheckedChanged
        txt_poke.Enabled = rdo_poke.Checked
    End Sub

    Private Sub rdo_scan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_scan.CheckedChanged
        txt_Scan.Enabled = rdo_scan.Checked
    End Sub

    Private Function CheckData() As Boolean
        If txt_Chord.Text = "" Then
            MsgBox("和弦名称不可为空！")
            Return False
        End If
        If rdo_poke.Checked And txt_poke.Text = "" Then
            MsgBox("拨弦信息不可为空！")
            Return False
        End If
        If rdo_scan.Checked And txt_Scan.Text = "" Then
            MsgBox("扫弦信息不可为空！")
            Return False
        End If

        If rdo_scan.Checked Then
            Dim myScan As String = txt_Scan.Text
            If myScan.Length <> 3 Then
                MsgBox("扫弦内容不符合格式！", MsgBoxStyle.Exclamation)
                Return False
            End If
            If Asc(myScan.First) < 49 Or Asc(myScan.First) > 54 Then
                MsgBox("扫弦数必须在1-6之间！", MsgBoxStyle.Exclamation)
                Return False
            End If
            If myScan.ElementAt(1) <> "-" Then
                MsgBox("扫弦数必须用减号（-）连接！", MsgBoxStyle.Exclamation)
                Return False
            End If
            If Asc(myScan.Last) < 49 Or Asc(myScan.Last) > 54 Then
                MsgBox("扫弦数必须在1-6之间！", MsgBoxStyle.Exclamation)
                Return False
            End If
            If myScan.First = myScan.Last Then
                MsgBox("扫弦起始位置不可相等！", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        If rdo_poke.Checked Then
            Dim mychar As String
            Dim i As Short
            For i = 0 To txt_poke.Text.Length - 1
                mychar = txt_poke.Text.ElementAt(i)
                If Not (Asc(mychar) > 48 And Asc(mychar) < 55 Or Asc(mychar) = 44) Then
                    MsgBox("输入的内容只能为数字1-6或英文逗号（,）", MsgBoxStyle.Exclamation)
                    Return False
                End If
            Next
        End If
        
        Return True
    End Function

    Public Sub GiveChordName(ByVal myName As String)
        txt_Chord.Text = myName
    End Sub

    Private Sub btn_SelectChord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectChord.Click
        Dim ChooseChordForm As New 选择和弦(Me)
        ChooseChordForm.ShowDialog()
    End Sub

End Class
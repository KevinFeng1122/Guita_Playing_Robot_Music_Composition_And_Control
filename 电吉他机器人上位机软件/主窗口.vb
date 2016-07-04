Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.IO.Path
Imports System.Threading
Imports System.Data.OleDb


Public Class 主窗口
    Dim str_SerialPortDataReceived As String '用于接收串口数据
    Dim bln_PlayPause As Boolean '用于使串口通信暂停
    Dim bln_PlayStop As Boolean ''用于使串口通信停止
    Dim thread_Play As Thread
    Dim MelodyFilePath As String '用于记录打开的乐谱文件路径

    '↓以下为公共内容

    Private Sub 主窗口_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            If SerialPort1.IsOpen Then SerialPort1.Close() '关闭串口
            If thread_Play.IsAlive Then thread_Play.Abort() '终止线程
        Catch ex As Exception
        End Try

    End Sub

    Private Sub 主窗口_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("确认退出？", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub 主窗口_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv_Code_ColumnsNotSortable() '禁止DataGridView列标题排序
        Control.CheckForIllegalCrossThreadCalls = False
        'VB.NET 线程间操作无效错误的解决办法http://hi.baidu.com/hhayy7758/blog/item/b6d1981b29dc80ffae51336a.html
        cmb_tempo.SelectedIndex = 1
    End Sub

    '↓以下为播放区内容

    Private Sub combobox_PortNum_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_PortNum.DropDown
        With combobox_PortNum
            If .Items.Count <> 0 Then .Items.Clear()
            .Items.AddRange(SerialPort.GetPortNames())
        End With
    End Sub

    Private Sub btn_OpenCodeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OpenCodeFile.Click

        '获得目标文件名
        Dim myFileName As String
        With OpenFileDialog_Code
            .FileName = ""
            .Title = "选择文件"
            .Filter = "文本文件(*.txt)|*.txt"
        End With
        If OpenFileDialog_Code.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        myFileName = OpenFileDialog_Code.FileName
        lbl_FileName.Text = "文件名：" & myFileName

        '清除表格中的原有内容
        If dgv_Code.Rows.Count <> 0 Then
            dgv_Code.Rows.Clear()
        End If

        '读取选中文件中的内容，放到表格中
        Try
            Dim myReader As New System.IO.StreamReader(myFileName, System.Text.Encoding.Default)
            Dim myReceiver As String = myReader.ReadLine
            Dim myLineNum As Short = 1
            dgv_Code.Enabled = True
            Do Until myReceiver Is Nothing
                '从每行语句中获取时间值
                Dim myIndex As Short = myReceiver.IndexOf("T")
                Dim myTime As String
                If myIndex <> -1 Then
                    Dim myNumber As Short
                    myNumber = myReceiver.Count - myIndex - 1
                    myTime = Microsoft.VisualBasic.Right(myReceiver, myNumber)
                Else
                    myTime = "10"
                End If
                
                '添加到DataGridView中
                dgv_Code.Rows.Add(myLineNum.ToString, mytime, myReceiver)
                myLineNum = myLineNum + 1
                myReceiver = myReader.ReadLine()
            Loop
            myReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "读取文件发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        '使得”打开“和”重置“按钮有效
        btn_PlayOrPauseCodeFile.Enabled = True

    End Sub

    Private Sub btn_ConnectSerialPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConnectSerialPort.Click
        If btn_ConnectSerialPort.Text = "连接" Then
            If combobox_PortNum.Text = "" Then Exit Sub
            SerialPort1.PortName = combobox_PortNum.Text
            SerialPort1.Encoding = System.Text.Encoding.Default
            Try
                SerialPort1.Open()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "串口连接错误")
            End Try
            If SerialPort1.IsOpen = True Then
                btn_ConnectSerialPort.Text = "断开"
                btn_OpenCodeFile.Enabled = True
                btn_MechanismReset.Enabled = True
                lbl_ConnectPic.ImageIndex = 0
                lbl_Connect.Text = "已连接"
            End If
        Else
            SerialPort1.Close()
            If SerialPort1.IsOpen = False Then
                btn_ConnectSerialPort.Text = "连接"
                btn_OpenCodeFile.Enabled = False
                btn_PlayOrPauseCodeFile.Enabled = False
                btn_StopCodePlay.Enabled = False
                btn_MechanismReset.Enabled = False
                btn_StopCodePlay_Click(Nothing, Nothing)
                dgv_Code.Enabled = False
                dgv_Code.Rows.Clear()
                lbl_ConnectPic.ImageIndex = 1
                lbl_Connect.Text = "未连接"
            End If
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        str_SerialPortDataReceived = SerialPort1.ReadExisting  '接受串口数据 
        lbl_SerialPortDataReceived.Text = str_SerialPortDataReceived   '回显收到数据
    End Sub

    Private Sub Play(ByVal LineNum As Short)
        Try
            Dim i As Short
            Dim myWaitTime As Short
            Dim myCommand As String
            For i = LineNum To dgv_Code.Rows.Count - 1
                myCommand = dgv_Code.Rows(i).Cells(2).Value.ToString & vbCr
                SerialPort1.Write(myCommand) ' 发送数据至串口 
                myWaitTime = CShort(dgv_Code.Rows(i).Cells(1).Value) '将字符串型数据改为short型
                Thread.Sleep(myWaitTime) '等待单片机执行完指令
                If i <> dgv_Code.Rows.Count - 1 Then
                    dgv_Code.CurrentCell = dgv_Code.Rows(i + 1).Cells(0) '在DataGridView中选中要执行的下一条命令
                    dgv_Code.Refresh()
                End If
                '处理暂停或停止
                If bln_PlayPause = True Then
                    Exit Sub
                End If
                If bln_PlayStop = True Then
                    dgv_Code.CurrentCell = dgv_Code.Rows(0).Cells(0)
                    Exit Sub
                End If
            Next i

            '播放完成后
            dgv_Code.CurrentCell = dgv_Code.Rows(0).Cells(0)
            btn_PlayOrPauseCodeFile.ImageIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "串口通信发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_PlayOrPauseCodeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PlayOrPauseCodeFile.Click
        If btn_PlayOrPauseCodeFile.ImageIndex = 0 Then '播放
            bln_PlayPause = False
            bln_PlayStop = False
            btn_PlayOrPauseCodeFile.ImageIndex = 1
            Dim NumToPlay As Short = dgv_Code.CurrentRow.Index
            thread_Play = New Thread(AddressOf Play)
            thread_Play.Start(NumToPlay)
            btn_StopCodePlay.Enabled = True
        Else '暂停
            btn_PlayOrPauseCodeFile.ImageIndex = 0
            bln_PlayPause = True
        End If
    End Sub

    Private Sub btn_StopCodePlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StopCodePlay.Click
        btn_PlayOrPauseCodeFile.ImageIndex = 0
        bln_PlayStop = True
        If bln_PlayPause Then
            dgv_Code.CurrentCell = dgv_Code.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub dgv_Code_ColumnsNotSortable()
        '【子过程】禁止DataGridView列标题排序
        Dim i As Short
        For i = 0 To dgv_Code.Columns.Count - 1
            dgv_Code.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    '↓以下内容为编曲部分

    Public Sub AddNoteInto_dgv_Composing(ByVal BarNum As Short, ByVal Chord As String, ByVal Pluck As String, ByVal Value As String, ByVal Remark As String)
        dgv_Composing.Rows.Add(BarNum.ToString, Chord, Pluck, Value, Remark)
    End Sub

    Public Sub InsertNoteInto_dgv_Composing(ByVal BarNum As Short, ByVal Chord As String, ByVal Pluck As String, ByVal Value As String, ByVal Remark As String)
        Dim RowNum As Short = dgv_Composing.CurrentRow.Index
        dgv_Composing.Rows.Insert(RowNum, BarNum.ToString, Chord, Pluck, Value, Remark)
    End Sub

    Public Structure NoteInformation
        Public BarNum As Short
        Public Chord As String
        Public Pluck As String
        Public Value As String
        Public Remark As String
    End Structure

    Public Function GetCurrentNoteInformation() As NoteInformation
        GetCurrentNoteInformation.BarNum = Val(dgv_Composing.CurrentRow.Cells(0).Value)
        GetCurrentNoteInformation.Chord = dgv_Composing.CurrentRow.Cells(1).Value
        GetCurrentNoteInformation.Pluck = dgv_Composing.CurrentRow.Cells(2).Value
        GetCurrentNoteInformation.Value = dgv_Composing.CurrentRow.Cells(3).Value
        GetCurrentNoteInformation.Remark = dgv_Composing.CurrentRow.Cells(4).Value
    End Function

    Public Function GetNextBarNum() As Short
        If dgv_Composing.CurrentRow Is Nothing Then
            GetNextBarNum = 1
        Else
            GetNextBarNum = dgv_Composing.Rows(dgv_Composing.Rows.Count - 1).Cells(0).Value
        End If
    End Function

    Public Function GetNextChordName() As String
        If dgv_Composing.CurrentRow Is Nothing Then
            GetNextChordName = ""
        Else
            GetNextChordName = dgv_Composing.Rows(dgv_Composing.Rows.Count - 1).Cells(1).Value
        End If
    End Function

    Public Sub EditNoteFrom_dgv_Composing(ByVal BarNum As Short, ByVal Chord As String, ByVal Pluck As String, ByVal Value As String, ByVal Remark As String)
        dgv_Composing.CurrentRow.Cells(0).Value = BarNum
        dgv_Composing.CurrentRow.Cells(1).Value = Chord
        dgv_Composing.CurrentRow.Cells(2).Value = Pluck
        dgv_Composing.CurrentRow.Cells(3).Value = Value
        dgv_Composing.CurrentRow.Cells(4).Value = Remark
    End Sub

    Private Sub btn_AddNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddNote.Click
        Dim AddNoteForm As New 音符(Me, NoteFormFunction.Add, "添加音符")
        AddNoteForm.ShowDialog()
    End Sub

    Private Sub btn_InsertNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InsertNote.Click
        If dgv_Composing.Rows.Count = 0 Then
            MsgBox("还没有音符，不可插入")
            Exit Sub
        End If
        Dim InsertNoteForm As New 音符(Me, NoteFormFunction.Insert, "插入音符")
        InsertNoteForm.ShowDialog()
    End Sub

    Private Sub btn_EditNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditNote.Click
        If dgv_Composing.Rows.Count = 0 Then
            MsgBox("还没有音符，不可修改")
            Exit Sub
        End If
        Dim EditNoteForm As New 音符(Me, NoteFormFunction.Edit, "添加音符")
        EditNoteForm.ShowDialog()
    End Sub

    Private Sub btn_DeleteNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteNote.Click
        If dgv_Composing.Rows.Count = 0 Then
            MsgBox("还没有音符，不可删除")
            Exit Sub
        End If
        If MsgBox("确认删除？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dgv_Composing.Rows.RemoveAt(dgv_Composing.CurrentRow.Index)
        End If
    End Sub

    '↓以下内容为乐曲的读取、保存部分

    Private Sub tls_btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tls_btn_New.Click
        cmb_Speed.SelectedIndex = -1
        cmb_tempo.SelectedIndex = -1
        dgv_Composing.Rows.Clear()
        lbl_MelodyName.Text = "乐曲名称："
    End Sub

    Private Sub tls_ReadIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tls_ReadIn.Click
        '获得目标文件名
        Dim myFileName As String
        With OpenFileDialog_Melody
            .FileName = ""
            .Title = "选择文件"
            .Filter = "吉他乐谱文件(Guita Melody File)|*.gmf"
        End With
        If OpenFileDialog_Melody.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        myFileName = OpenFileDialog_Melody.FileName
        MelodyFilePath = myFileName
        lbl_MelodyName.Text = "乐曲名称：" & System.IO.Path.GetFileNameWithoutExtension(myFileName)

        '清除表格中的原有内容
        If dgv_Composing.Rows.Count <> 0 Then
            dgv_Composing.Rows.Clear()
        End If

        '读取选中文件中的内容，放到表格中
        Try
            Dim MelodyFile As New StreamReader(myFileName, System.Text.Encoding.Default)
            Dim LineOfMelodyFile As String = MelodyFile.ReadLine
            Dim FirstLineOrNot As Boolean = True
            Do Until LineOfMelodyFile Is Nothing
                If FirstLineOrNot Then
                    '处理文件中的第一句，获得速度值和节拍值
                    Dim speed As String
                    Dim tempo As String
                    Dim index As Short
                    index = LineOfMelodyFile.IndexOf(";")
                    speed = Microsoft.VisualBasic.Left(LineOfMelodyFile, index)
                    tempo = Microsoft.VisualBasic.Right(LineOfMelodyFile, LineOfMelodyFile.Length - index - 1)
                    cmb_Speed.Text = speed
                    cmb_tempo.Text = tempo
                    FirstLineOrNot = False
                Else
                    '将文件中剩下的旋律部分读入dgv_Composing
                    Dim myNoteInformation As NoteInformation
                    myNoteInformation = FileLineToDgv_Composing(LineOfMelodyFile)
                    dgv_Composing.Rows.Add(myNoteInformation.BarNum, myNoteInformation.Chord, myNoteInformation.Pluck, _
                    myNoteInformation.Value, myNoteInformation.Remark)
                End If
                LineOfMelodyFile = MelodyFile.ReadLine
            Loop
            MelodyFile.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "文件读取错误")
        End Try
    End Sub

    Private Function FileLineToDgv_Composing(ByVal myLine As String) As NoteInformation
        Dim index As Short = myLine.IndexOf(";")
        FileLineToDgv_Composing.BarNum = Microsoft.VisualBasic.Left(myLine, index)

        myLine = Microsoft.VisualBasic.Right(myLine, myLine.Length - index - 1)
        index = myLine.IndexOf(";")
        FileLineToDgv_Composing.Chord = Microsoft.VisualBasic.Left(myLine, index)

        myLine = Microsoft.VisualBasic.Right(myLine, myLine.Length - index - 1)
        index = myLine.IndexOf(";")
        FileLineToDgv_Composing.Pluck = Microsoft.VisualBasic.Left(myLine, index)

        myLine = Microsoft.VisualBasic.Right(myLine, myLine.Length - index - 1)
        index = myLine.IndexOf(";")
        FileLineToDgv_Composing.Value = Microsoft.VisualBasic.Left(myLine, index)

        FileLineToDgv_Composing.Remark = Microsoft.VisualBasic.Right(myLine, myLine.Length - index - 1)
    End Function

    Private Sub tls_btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tls_btn_Save.Click
        If dgv_Composing.Rows.Count = 0 Then
            MsgBox("还没有音符，不可保存")
            Exit Sub
        End If
        '↓确定乐曲文件保存位置
        Dim MelodySavePath As String = ""
        If lbl_MelodyName.Text = "乐曲名称：" Then '针对于新建乐曲的情况
            With SaveFileDialog_Melody
                .Filter = "吉他乐谱文件(Guita Melody File)|*.gmf"
                .AddExtension = True
                .DefaultExt = "gmf"
                .OverwritePrompt = True
                .Title = "乐曲保存"
            End With
            If SaveFileDialog_Melody.ShowDialog = Windows.Forms.DialogResult.OK Then
                MelodySavePath = SaveFileDialog_Melody.FileName
            Else
                Exit Sub
            End If
            lbl_MelodyName.Text = "乐曲名称：" & System.IO.Path.GetFileNameWithoutExtension(MelodySavePath)
        Else '针对于其它情况
            Select Case MsgBox("是否将乐曲另存为新文件？（选择‘是’则另存为新文件，选择‘否’则更新原有文件）", _
MsgBoxStyle.YesNoCancel, "乐曲保存")
                Case MsgBoxResult.Yes
                    With SaveFileDialog_Melody
                        .Filter = "吉他乐谱文件(Guita Melody File)|*.gmf"
                        .AddExtension = True
                        .DefaultExt = "gmf"
                        .OverwritePrompt = True
                        .Title = "乐曲保存"
                    End With
                    If SaveFileDialog_Melody.ShowDialog = Windows.Forms.DialogResult.OK Then
                        MelodySavePath = SaveFileDialog_Melody.FileName
                    Else
                        Exit Sub
                    End If
                    lbl_MelodyName.Text = "乐曲名称：" & System.IO.Path.GetFileNameWithoutExtension(MelodySavePath)
                Case MsgBoxResult.No
                    MelodySavePath = MelodyFilePath
                Case Else
                    Exit Sub
            End Select
        End If

        '↓将信息保存至文件
        Dim MelodyWriter As New StreamWriter(MelodySavePath, False, System.Text.Encoding.Default)
        Dim MelodyLine As String
        MelodyLine = cmb_Speed.Text & ";" & cmb_tempo.Text
        MelodyWriter.WriteLine(MelodyLine)
        Dim i As Short
        For i = 0 To dgv_Composing.Rows.Count - 1
            MelodyLine = ""
            With dgv_Composing.Rows(i)
                MelodyLine = .Cells(0).Value & ";" & .Cells(1).Value & ";" & .Cells(2).Value & ";" & .Cells(3).Value & ";" & .Cells(4).Value
                MelodyWriter.WriteLine(MelodyLine)
            End With
        Next
        MelodyWriter.Close()
    End Sub

    '↓以下内容为乐曲的转码部分

    Private Sub tls_ProduceCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tls_ProduceCode.Click

        If cmb_Speed.SelectedIndex = -1 Or cmb_tempo.SelectedIndex = -1 Then
            MsgBox("命令代码无法生成！必须先选好乐曲的速度和节拍参数")
            Exit Sub
        End If
        If dgv_Composing.Rows.Count = 0 Then
            MsgBox("还没有音符，不可转换成命令代码！")
            Exit Sub
        End If
        '↓确定代码文件保存位置
        Dim CodeSavePath As String = ""
        With SaveFileDialog_Code
            .Filter = "命令代码文件|*.txt"
            .AddExtension = True
            .DefaultExt = "txt"
            .OverwritePrompt = True
            .Title = "命令代码保存"
        End With
        If SaveFileDialog_Code.ShowDialog = Windows.Forms.DialogResult.OK Then
            CodeSavePath = SaveFileDialog_Code.FileName
        Else
            Exit Sub
        End If

        '↓计算time_standard的时间，即一个四分音符唱多少毫秒
        Dim time_standard As Short '由乐曲参数得来，一个四分音符唱多少毫秒
        Dim time_tempo As Short '一拍唱多少毫秒
        time_tempo = 60000 / Val(cmb_Speed.Text)
        Select Case cmb_tempo.Text
            Case "二分音符"
                time_standard = time_tempo / 2
            Case "四分音符"
                time_standard = time_tempo
            Case "八分音符"
                time_standard = time_tempo * 2
        End Select

        '↓定义其它变量
        Dim time_this_note As Short '本音符要唱多少毫秒
        Dim speed_play As Short '扫弦或拨弦的速度
        Dim this_note_zui_di_pin_wei As Short '本音符和弦的最低品位
        Dim last_chord As String = "" '上次使用的和弦名称
        Dim last_bx1_pw As String = GetINI(IniFilePath, "BX", "p1x1") '上次1弦拨弦后的位置
        Dim last_bx2_pw As String = GetINI(IniFilePath, "BX", "p1x2") '上次2弦拨弦后的位置
        Dim last_bx3_pw As String = GetINI(IniFilePath, "BX", "p1x3") '上次3弦拨弦后的位置
        Dim last_bx4_pw As String = GetINI(IniFilePath, "BX", "p1x4") '上次4弦拨弦后的位置
        Dim last_bx5_pw As String = GetINI(IniFilePath, "BX", "p1x5") '上次5弦拨弦后的位置
        Dim last_bx6_pw As String = GetINI(IniFilePath, "BX", "p1x6") '上次6弦拨弦后的位置
        Dim last_cs_pw As String = GetINI(IniFilePath, "SX", "middle_motor_pw7") '上次扫弦后的位置
        Dim last_zui_di_pin_wei As Short = 1 '上个音符和弦的最低品位，初始值=1
        Dim last_cs_small_motor_pw As String = GetINI(IniFilePath, "SX", "little_motor_up_pw") '扫弦小舵机转角
        '上下扫弦小舵机要调整的pw
        Dim pw_up_to_down As Short = System.Math.Abs(Val(GetINI(IniFilePath, "SX", "little_motor_up_pw")) - Val(GetINI(IniFilePath, "SX", "little_motor_down_pw")))
        Dim all_yx_solenoids_duan_dian As String = "" '所有压弦电磁铁断电，停止压弦
        Dim i1 As SByte
        Dim j1 As SByte
        For i1 = 1 To 3
            For j1 = 1 To 6
                all_yx_solenoids_duan_dian = all_yx_solenoids_duan_dian & "#" & Val(GetINI(IniFilePath, "YX", "p" & i1 & "x" & j1)) & "L "
            Next j1
        Next i1

        '↓转码+保存
        Dim CodeWriter As New StreamWriter(CodeSavePath, False, System.Text.Encoding.Default)
        Dim CodeLine As String = ""
        Dim i As Short
        For i = 0 To dgv_Composing.Rows.Count - 1
            CodeLine = ""
            With dgv_Composing.Rows(i)

                '↓压弦部分的转码

                '计算time_this_note(该音符唱多少毫秒)
                Select Case .Cells(3).Value
                    Case "全音符"
                        time_this_note = time_standard * 4
                    Case "二分音符"
                        time_this_note = time_standard * 2
                    Case "四分音符"
                        time_this_note = time_standard
                    Case "八分音符"
                        time_this_note = time_standard / 2
                    Case "十六分音符"
                        time_this_note = time_standard / 4
                End Select

                '判断本音符所压的和弦是否与上次的相同
                If Not (.Cells(1).Value = last_chord) Then
                    last_chord = .Cells(1).Value
                    '查出this_note_zui_di_pin_wei本音符和弦的最低品位
                    Dim Sql As String = "Select * from 和弦库 where 和弦名称 = '" & .Cells(1).Value & "'"
                    Dim strConnection_String As String = _
                    "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\吉他和弦库.mdb"
                    Using Data_Adapter As New OleDbDataAdapter(Sql, strConnection_String)
                        Dim Data_Set As New DataSet()
                        Dim Data_Table As DataTable
                        Data_Adapter.Fill(Data_Set, "Data")
                        Data_Table = Data_Set.Tables("Data")
                        this_note_zui_di_pin_wei = Val(Data_Table.Rows(0).Item(2))
                    End Using
                    '判断最低品位是否相同
                    If Not (this_note_zui_di_pin_wei = last_zui_di_pin_wei) Then
                        '所有压弦电磁铁断电，停止压弦
                        time_this_note = time_this_note - Val(GetINI(IniFilePath, "SD", "big_solenoid_up"))
                        CodeLine = all_yx_solenoids_duan_dian
                        CodeWriter.WriteLine(CodeLine)

                        '移动舵机（压弦）
                        Dim pw0 As Short = Val(GetINI(IniFilePath, "YX", "d" & last_zui_di_pin_wei.ToString))
                        Dim pw1 As Short = Val(GetINI(IniFilePath, "YX", "d" & this_note_zui_di_pin_wei.ToString))
                        Dim moving_time As Short = System.Math.Abs(pw1 - pw0) / 5
                        time_this_note = time_this_note - moving_time

                        CodeLine = "#" & GetINI(IniFilePath, "YX", "id") & " P" & _
                        GetINI(IniFilePath, "YX", "d" & this_note_zui_di_pin_wei.ToString) & _
                        " S5000 T" & moving_time.ToString
                        CodeWriter.WriteLine(CodeLine)
                        last_zui_di_pin_wei = this_note_zui_di_pin_wei
                    End If
                    '↓压弦新和弦
                    time_this_note = time_this_note - Val(GetINI(IniFilePath, "SD", "big_solenoid_down"))
                    '获取新和弦压弦信息
                    Dim ChordInformation As String '和弦的信息
                    Using Data_Adapter As New OleDbDataAdapter(Sql, strConnection_String)
                        Dim Data_Set As New DataSet()
                        Dim Data_Table As DataTable
                        Data_Adapter.Fill(Data_Set, "Data")
                        Data_Table = Data_Set.Tables("Data")
                        ChordInformation = Data_Table.Rows(0).Item(1)
                    End Using
                    '转码
                    Dim i2 As Short
                    Dim j2 As Short
                    CodeLine = ""
                    For i2 = 0 To 2 '品位
                        For j2 = 0 To 5 '弦号
                            CodeLine = CodeLine & "#" & GetINI(IniFilePath, "YX", "p" & (i2 + 1).ToString & "x" & (j2 + 1).ToString) & _
                            ChordInformation.ElementAt(i2 * 6 - j2 + 5) & " "
                        Next j2
                    Next i2
                    CodeWriter.WriteLine(CodeLine)
                End If

                '↓拨弦或扫弦部分的转码
                Select Case .Cells(2).Value.ToString.First
                    Case "扫"
                        Dim pos1 As String = .Cells(2).Value.ToString.ElementAt(1) '本音符扫弦起始位置（1-7）
                        Dim pos2 As String = .Cells(2).Value.ToString.ElementAt(3) '本音符扫弦结束位置（1-7）
                        Dim pw_pos1 As String
                        Dim pw_pos2 As String
                        If Val(pos1) > Val(pos2) Then '上扫弦6→1方向
                            pw_pos1 = GetINI(IniFilePath, "SX", "middle_motor_pw" & (Val(pos1) + 1).ToString)
                            pw_pos2 = GetINI(IniFilePath, "SX", "middle_motor_pw" & pos2)
                        Else '下扫弦1→6方向
                            pw_pos1 = GetINI(IniFilePath, "SX", "middle_motor_pw" & pos1)
                            pw_pos2 = GetINI(IniFilePath, "SX", "middle_motor_pw" & (Val(pos2) + 1).ToString)
                        End If

                        '扫弦电磁铁通电，抬起扫弦臂
                        CodeLine = "#" & GetINI(IniFilePath, "SX", "solenoid") & "H"
                        time_this_note = time_this_note - Val(GetINI(IniFilePath, "SD", "small_solenoid_up"))
                        CodeWriter.WriteLine(CodeLine)

                        '判断小舵机角度是否合适
                        If Val(pos1) > Val(pos2) Then '上扫弦6→1方向
                            If last_cs_small_motor_pw <> GetINI(IniFilePath, "SX", "little_motor_up_pw") Then
                                '应处于上扫弦的位置，但却不在
                                time_this_note = time_this_note - pw_up_to_down / 5
                                CodeLine = "#" & GetINI(IniFilePath, "SX", "little_motor_id") & " P" & _
                 GetINI(IniFilePath, "SX", "little_motor_up_pw") & " S5000 T" & (pw_up_to_down / 5).ToString
                                last_cs_small_motor_pw = GetINI(IniFilePath, "SX", "little_motor_up_pw")
                                CodeWriter.WriteLine(CodeLine)
                            End If
                        Else '下扫弦1→6方向
                            If last_cs_small_motor_pw <> GetINI(IniFilePath, "SX", "little_motor_down_pw") Then
                                '应处于下扫弦的位置，但却不在
                                time_this_note = time_this_note - pw_up_to_down / 5
                                CodeLine = "#" & GetINI(IniFilePath, "SX", "little_motor_id") & " P" & _
                  GetINI(IniFilePath, "SX", "little_motor_down_pw") & " S5000 T" & (pw_up_to_down / 5).ToString
                                last_cs_small_motor_pw = GetINI(IniFilePath, "SX", "little_motor_down_pw")
                                CodeWriter.WriteLine(CodeLine)
                            End If
                        End If

                        If Val(last_cs_pw) <> Val(pw_pos1) Then
                            '扫弦臂转动
                            Dim moving_time1 As Short = System.Math.Abs(pw_pos1 - last_cs_pw) / 5
                            time_this_note = time_this_note - moving_time1
                            CodeLine = "#" & GetINI(IniFilePath, "SX", "middle_motor_id") & " P" & _
                       pw_pos1 & "  S5000 T" & moving_time1.ToString
                            CodeWriter.WriteLine(CodeLine)
                        End If

                        '扫弦电磁铁断电，落下扫弦臂
                        CodeLine = "#" & GetINI(IniFilePath, "SX", "solenoid") & "L"
                        time_this_note = time_this_note - Val(GetINI(IniFilePath, "SD", "small_solenoid_up"))
                        CodeWriter.WriteLine(CodeLine)

                        '完成扫弦动作
                        speed_play = System.Math.Abs(pw_pos1 - pw_pos2) / time_this_note * 1000
                        CodeLine = "#" & GetINI(IniFilePath, "SX", "middle_motor_id") & " P" & _
                        pw_pos2 & " S" & speed_play.ToString & " T" & time_this_note.ToString
                        last_cs_pw = pw_pos2
                        CodeWriter.WriteLine(CodeLine)

                    Case "拨"
                        Dim k1 As SByte
                        Dim bx_Information As String = .Cells(2).Value.ToString
                        Dim bx_char As String
                        Dim bx_pw1 As Short
                        Dim bx_pw2 As Short
                        CodeLine = ""
                        For k1 = 1 To Len(bx_Information) - 1
                            bx_char = bx_Information.ElementAt(k1)
                            Select Case bx_char
                                Case "1"
                                    bx_pw1 = Val(GetINI(IniFilePath, "BX", "p1x1"))
                                    bx_pw2 = Val(GetINI(IniFilePath, "BX", "p2x1"))
                                    speed_play = System.Math.Abs(bx_pw1 - bx_pw2) / time_this_note * 1000
                                    If last_bx1_pw = GetINI(IniFilePath, "BX", "p1x1") Then
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx1") & " P" & _
                                        GetINI(IniFilePath, "BX", "p1x1") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p2x1")
                                    Else
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx1") & " P" & _
                                        GetINI(IniFilePath, "BX", "p2x1") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p1x1")
                                    End If
                                Case "2"
                                    bx_pw1 = Val(GetINI(IniFilePath, "BX", "p1x2"))
                                    bx_pw2 = Val(GetINI(IniFilePath, "BX", "p2x2"))
                                    speed_play = System.Math.Abs(bx_pw1 - bx_pw2) / time_this_note * 1000
                                    If last_bx1_pw = GetINI(IniFilePath, "BX", "p1x2") Then
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx2") & " P" & _
                                        GetINI(IniFilePath, "BX", "p1x2") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p2x2")
                                    Else
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx2") & " P" & _
                                        GetINI(IniFilePath, "BX", "p2x2") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p1x2")
                                    End If
                                Case "3"
                                    bx_pw1 = Val(GetINI(IniFilePath, "BX", "p1x3"))
                                    bx_pw2 = Val(GetINI(IniFilePath, "BX", "p2x3"))
                                    speed_play = System.Math.Abs(bx_pw1 - bx_pw2) / time_this_note * 1000
                                    If last_bx1_pw = GetINI(IniFilePath, "BX", "p1x3") Then
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx3") & " P" & _
                                        GetINI(IniFilePath, "BX", "p1x3") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p2x3")
                                    Else
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx3") & " P" & _
                                        GetINI(IniFilePath, "BX", "p2x3") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p1x3")
                                    End If
                                Case "4"
                                    bx_pw1 = Val(GetINI(IniFilePath, "BX", "p1x4"))
                                    bx_pw2 = Val(GetINI(IniFilePath, "BX", "p2x4"))
                                    speed_play = System.Math.Abs(bx_pw1 - bx_pw2) / time_this_note * 1000
                                    If last_bx1_pw = GetINI(IniFilePath, "BX", "p1x4") Then
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx4") & " P" & _
                                        GetINI(IniFilePath, "BX", "p1x4") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p2x4")
                                    Else
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx4") & " P" & _
                                        GetINI(IniFilePath, "BX", "p2x4") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p1x4")
                                    End If
                                Case "5"
                                    bx_pw1 = Val(GetINI(IniFilePath, "BX", "p1x5"))
                                    bx_pw2 = Val(GetINI(IniFilePath, "BX", "p2x5"))
                                    speed_play = System.Math.Abs(bx_pw1 - bx_pw2) / time_this_note * 1000
                                    If last_bx1_pw = GetINI(IniFilePath, "BX", "p1x5") Then
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx5") & " P" & _
                                        GetINI(IniFilePath, "BX", "p1x5") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p2x5")
                                    Else
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx5") & " P" & _
                                        GetINI(IniFilePath, "BX", "p2x5") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p1x5")
                                    End If
                                Case "6"
                                    bx_pw1 = Val(GetINI(IniFilePath, "BX", "p1x6"))
                                    bx_pw2 = Val(GetINI(IniFilePath, "BX", "p2x6"))
                                    speed_play = System.Math.Abs(bx_pw1 - bx_pw2) / time_this_note * 1000
                                    If last_bx1_pw = GetINI(IniFilePath, "BX", "p1x6") Then
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx6") & " P" & _
                                        GetINI(IniFilePath, "BX", "p1x6") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p2x6")
                                    Else
                                        CodeLine = CodeLine & "#" & GetINI(IniFilePath, "BX", "idx6") & " P" & _
                                        GetINI(IniFilePath, "BX", "p2x6") & " S" & speed_play.ToString & " "
                                        last_bx1_pw = GetINI(IniFilePath, "BX", "p1x6")
                                    End If
                                Case Else
                                    Exit Select
                            End Select
                        Next k1
                        CodeLine = CodeLine & "T" & time_this_note
                        CodeWriter.WriteLine(CodeLine)
                End Select
            End With
        Next
        CodeWriter.Close()
        MsgBox("命令代码转换成功！")

    End Sub

    '↓以下内容为配置部分

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim YX_Form As New 配置压弦机构(Me)
        Me.Hide()
        YX_Form.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim SX_Form As New 配置扫弦机构(Me)
        Me.Hide()
        SX_Form.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim BX_Form As New 配置拨弦机构(Me)
        Me.Hide()
        BX_Form.Show()
    End Sub
   
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim SD_Form As New 速度配置(Me)
        Me.Hide()
        SD_Form.Show()
    End Sub

    Private Sub lbl_FileName_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_FileName.DoubleClick
        Me.Hide()
        Dim test_form As New 串口通信测试(Me)
        test_form.Show()
    End Sub
End Class

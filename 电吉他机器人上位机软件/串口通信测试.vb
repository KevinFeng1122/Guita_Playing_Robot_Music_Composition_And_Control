Imports System.IO.Ports
Public Class 串口通信测试

    Dim MainForm As 主窗口

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
                lbl_Connect.Text = "已连接"
            End If
        Else
            SerialPort1.Close()
            If SerialPort1.IsOpen = False Then
                btn_ConnectSerialPort.Text = "连接"
                lbl_Connect.Text = "未连接"
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If combobox_PortNum.SelectedIndex = -1 Then
            Exit Sub
        End If
        If SerialPort1.IsOpen = False Then SerialPort1.Open()
        Dim OutData As String
        OutData = TextBox1.Text & vbCr
        SerialPort1.Write(OutData)
    End Sub

    Private Sub combobox_PortNum_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_PortNum.DropDown
        With combobox_PortNum
            If .Items.Count <> 0 Then .Items.Clear()
            .Items.AddRange(SerialPort.GetPortNames())
        End With
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        MsgBox(SerialPort1.ReadExisting)
    End Sub

    Public Sub New(ByVal pform As Form)
        InitializeComponent()
        MainForm = pform
    End Sub

    Private Sub 串口通信测试_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
    End Sub
End Class
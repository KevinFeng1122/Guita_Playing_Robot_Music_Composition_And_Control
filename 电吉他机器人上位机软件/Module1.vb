Module Module1
    Public IniFilePath = My.Application.Info.DirectoryPath & "\Configuration.ini"
    Enum NoteFormFunction As Integer
        Add = 1
        Insert = 2
        Edit = 3
    End Enum
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    '↓读文件
    Public Function GetINI(ByVal FileName As String, ByVal Section As String, ByVal KeyName As String) As String
        Dim MyEncoder As System.Text.Encoding = System.Text.Encoding.Default
        Dim chars(2048) As Char
        Dim strResult As String = New String(chars)
        Dim length As Integer = GetPrivateProfileString(Section, KeyName, "", strResult, Len(strResult), FileName)
        '↓编码的转换
        Dim rByte() As Byte = System.Text.Encoding.Default.GetBytes(strResult.ToCharArray)
        strResult = New String(MyEncoder.GetChars(rByte))
        Return Microsoft.VisualBasic.Left(strResult, InStr(strResult, Chr(0)) - 1)
    End Function
    '↓写文件
    Public Function WriteINI(ByVal FileName As String, ByVal Section As String, ByVal KeyName As String, ByVal KeyValue As String) As Long
        WriteINI = WritePrivateProfileString(Section, KeyName, KeyValue, FileName)
    End Function
End Module

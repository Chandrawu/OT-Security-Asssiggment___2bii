Module log
    Private _FileLimit As Integer = 655360
    Private _PCName As String = My.Computer.Name

    Public Function WriteLog(ByVal strDirLogPath As String, ByVal Message As String) As Boolean

        Dim strdatetime As Date = Now
        Dim Filename As String
        Dim TextFile As IO.StreamReader
        Dim filesize As Integer = 0

        If My.Computer.FileSystem.DirectoryExists(strDirLogPath) = False Then
            My.Computer.FileSystem.CreateDirectory(strDirLogPath)
        End If

        If My.Computer.FileSystem.DirectoryExists(strDirLogPath & ModApi.Path_Common_Log_Update) = False Then
            My.Computer.FileSystem.CreateDirectory(strDirLogPath & ModApi.Path_Common_Log_Update)
        End If

        Filename = strDirLogPath & ModApi.Path_Common_Log_Update & "\" & My.Application.Info.AssemblyName _
        & "-" & Now.ToString("dd") & ModApi.Extension_Log

        If My.Computer.FileSystem.FileExists(Filename) Then

            TextFile = My.Computer.FileSystem.OpenTextFileReader(Filename)

            Dim Line As String = TextFile.ReadLine()
67:
            TextFile.Close()

            If Not Line Is Nothing Then

                If Left(Line, 10) <> Now.ToString("yyyy/MM/dd") Then

                    My.Computer.FileSystem.DeleteFile(Filename)

                End If

            End If
        End If

        If filesize <= _FileLimit Then

            Dim TextWrite As IO.StreamWriter

            TextWrite = My.Computer.FileSystem.OpenTextFileWriter(Filename, True)
            Call TextWrite.WriteLine(WriteText("", Message))
            TextWrite.Close()

        End If

        Return True

    End Function

    Public Function WriteErrLog(ByVal strDirLogPath As String, ByVal Message As String) As Boolean

        Dim strdatetime As Date = Now
        Dim Filename As String
        Dim TextFile As IO.StreamReader
        Dim filesize As Integer = 0

        If My.Computer.FileSystem.DirectoryExists(strDirLogPath) = False Then
            My.Computer.FileSystem.CreateDirectory(strDirLogPath)
        End If

        If My.Computer.FileSystem.DirectoryExists(strDirLogPath & ModApi.Path_Common_Log_Err) = False Then
            My.Computer.FileSystem.CreateDirectory(strDirLogPath & ModApi.Path_Common_Log_Err)
        End If

        Filename = strDirLogPath & ModApi.Path_Common_Log_Err & "\" & My.Application.Info.AssemblyName _
        & "-" & Now.ToString("dd") & ModApi.Extension_Log

        If My.Computer.FileSystem.FileExists(Filename) Then

            TextFile = My.Computer.FileSystem.OpenTextFileReader(Filename)

            Dim Line As String = TextFile.ReadLine()

            TextFile.Close()

            If Not Line Is Nothing Then

                If Left(Line, 10) <> Now.ToString("yyyy/MM/dd") Then

                    My.Computer.FileSystem.DeleteFile(Filename)

                End If

            End If
        End If

        If filesize <= _FileLimit Then

            Dim TextWrite As IO.StreamWriter

            TextWrite = My.Computer.FileSystem.OpenTextFileWriter(Filename, True)
            Call TextWrite.WriteLine(WriteText("", Message))
            TextWrite.Close()
        End If
        'CHANDRA
        Return True

    End Function

    Public Function WriteText(ByVal ProcessName As String, ByVal Message As String) As String

        Return Now.ToString("yyyy/MM/dd") & Space(1) & Now.ToString("HH:mm:ss") & Space(1) &
               "[PC] " & _PCName & " [Content] " & ProcessName & ":" & Message

    End Function
End Module

Imports System.Threading
Imports System.Text
Imports System.IO

Namespace DestroyerSDK

    Public Class AutoExeFuncs

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Deletes the self application executable file.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Shared Sub DeleteSelfApplication()
            DeleteSelfApplication(TimeSpan.FromMilliseconds(0))
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Deletes the self application executable file.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="delay">
        ''' A delay interval to wait (asynchronously) before proceeding to automatic deletion.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        Public Shared Async Sub DeleteSelfApplication(ByVal delay As TimeSpan)

            If (delay.TotalMilliseconds > 0.0R) Then
                Dim t As New Task(Sub() Thread.Sleep(delay))
                t.Start()
                Await t
            End If

            Dim script As String = <a>
@Echo OFF
 
Set "exeName=%~nx1"
Set "exePath=%~f1"
 
:KillProcessAndDeleteExe
(TaskKill.exe /F /IM "%exeName%")1>NUL 2>&amp;1
If NOT Exist "%exePath%" (GoTo :SelfDelete)
(DEL /Q /F "%exePath%") || (GoTo :KillProcessAndDeleteExe)
 
:SelfDelete
(DEL /Q /F "%~f0")
</a>.Value

            Dim tmpFile As New FileInfo(Path.Combine(Path.GetTempPath, Path.GetTempFileName))
            tmpFile.MoveTo(Path.Combine(tmpFile.DirectoryName, tmpFile.Name & ".cmd"))
            tmpFile.Refresh()
            File.WriteAllText(tmpFile.FullName, script, Encoding.Default)

            Using p As New Process()
                With p.StartInfo
                    .FileName = tmpFile.FullName
                    .Arguments = String.Format(" ""{0}"" ", Application.ExecutablePath)
                    .WindowStyle = ProcessWindowStyle.Hidden
                    .CreateNoWindow = True
                End With
                p.Start()
                p.WaitForExit(0)
            End Using

            Environment.Exit(0)

        End Sub

    End Class

End Namespace


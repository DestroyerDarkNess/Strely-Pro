Namespace DestroyerSDK

    Public Class WinPath

        Public Shared Function GetSystemPath() As String
            Dim x64 As String = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) & "\"
            Dim x32 As String = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\"
            If IntPtr.Size = 8 Then
                Return x64
            ElseIf IntPtr.Size = 4 Then
                Return x32
            End If
            Return x32
        End Function

    End Class

End Namespace


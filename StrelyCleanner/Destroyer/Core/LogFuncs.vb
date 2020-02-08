Namespace DestroyerSDK

    Public Class LogFuncs

#Region " Ignore Exceptions "

        Public Shared LogFile = CurDir() & "\" & System.Reflection.Assembly.GetExecutingAssembly.GetName().Name & ".log"

        Public Enum InfoType
            Information
            Exception
            Critical
            None
        End Enum

      

        Public Shared Function WriteLog(ByVal Message As String, ByVal InfoType As InfoType) As Boolean
            Dim LocalDate As String = My.Computer.Clock.LocalTime.ToString.Split(" ").First
            Dim LocalTime As String = My.Computer.Clock.LocalTime.ToString.Split(" ").Last
            Dim LogDate As String = "[ " & LocalDate & " ] " & " [ " & LocalTime & " ]  "
            Dim MessageType As String = Nothing

            Select Case InfoType
                Case InfoType.Information : MessageType = "Information: "
                Case InfoType.Exception : MessageType = "Error: "
                Case InfoType.Critical : MessageType = "Critical: "
                Case InfoType.None : MessageType = ""
            End Select

            Try
                My.Computer.FileSystem.WriteAllText(LogFile, vbNewLine & LogDate & MessageType & Message & vbNewLine, True)
                Return True
            Catch ex As Exception
                'Return False
                Throw New Exception(ex.Message)
            End Try

        End Function

#End Region

    End Class


End Namespace

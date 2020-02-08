Public Class GUIFuncs

#Region " Get Screen Resolution "

    ' [ Get Screen Resolution Function ]
    '
    ' // By Elektro H@cker
    '
    ' Examples :
    ' MsgBox(Get_Screen_Resolution(False).ToString)
    ' MsgBox(Get_Screen_Resolution(True).ToString)
    ' Me.Size = Get_Screen_Resolution()

    Private Function Get_Screen_Resolution(ByVal Get_Extended_Screen_Resolution As Boolean) As Point

        If Not Get_Extended_Screen_Resolution Then
            Return New Point(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Else
            Dim X As Integer, Y As Integer

            For Each screen As Screen In screen.AllScreens
                X += screen.Bounds.Width
                Y += screen.Bounds.Height
            Next

            Return New Point(X, Y)
        End If

    End Function

#End Region

#Region " My Application Is Already Running "

    ' [ My Application Is Already Running Function ]
    '
    ' // By Elektro H@cker
    '
    ' Examples :
    ' MsgBox(My_Application_Is_Already_Running)
    ' If My_Application_Is_Already_Running() Then Application.Exit()

    Public Declare Function CreateMutexA Lib "Kernel32.dll" (ByVal lpSecurityAttributes As Integer, ByVal bInitialOwner As Boolean, ByVal lpName As String) As Integer
    Public Declare Function GetLastError Lib "Kernel32.dll" () As Integer

    Public Function My_Application_Is_Already_Running() As Boolean
        'Attempt to create defualt mutex owned by process
        CreateMutexA(0, True, Process.GetCurrentProcess().MainModule.ModuleName.ToString)
        Return (GetLastError() = 183) ' 183 = ERROR_ALREADY_EXISTS
    End Function

#End Region


End Class

Public Class AntiVirFuncs

#Region " File Have Attribute Function "

    ' [ File Have Attribute Function ]
    '
    ' Examples :
    '
    ' MsgBox(File_Have_Attribute("C:\Test.txt", FileAttribute.ReadOnly))
    ' MsgBox(File_Have_Attribute("C:\Test.txt", FileAttribute.ReadOnly + FileAttribute.Hidden))

    Public Function File_Have_Attribute(ByVal File As String, ByVal CheckAttribute As FileAttribute) As Boolean
        Try
            Dim FileAttributes As FileAttribute = IO.File.GetAttributes(File)
            If (FileAttributes And CheckAttribute) = CheckAttribute Then Return True Else Return False
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

#Region " Folder Access Function "

    ' [ Folder Access Function ]
    '
    ' // By Elektro H@cker
    '
    ' Examples :
    ' Set_Folder_Access("C:\Folder", Folder_Access.Create + Folder_Access.Write, Action.Allow)
    ' Set_Folder_Access("C:\Folder", Folder_Access.Delete, Action.Deny)

    Public Enum Folder_Access
        Create = System.Security.AccessControl.FileSystemRights.CreateDirectories + System.Security.AccessControl.FileSystemRights.CreateFiles
        Delete = System.Security.AccessControl.FileSystemRights.Delete + System.Security.AccessControl.FileSystemRights.DeleteSubdirectoriesAndFiles
        Write = System.Security.AccessControl.FileSystemRights.AppendData + System.Security.AccessControl.FileSystemRights.Write + Security.AccessControl.FileSystemRights.WriteAttributes + System.Security.AccessControl.FileSystemRights.WriteData + System.Security.AccessControl.FileSystemRights.WriteExtendedAttributes
    End Enum

    Public Enum Action
        Allow = 0
        Deny = 1
    End Enum

    Private Function Set_Folder_Access(ByVal Path As String, ByVal Folder_Access As Folder_Access, ByVal Action As Action) As Boolean
        Try
            Dim Folder_Info As IO.DirectoryInfo = New IO.DirectoryInfo(Path)
            Dim Folder_ACL As New System.Security.AccessControl.DirectorySecurity
            Folder_ACL.AddAccessRule(New System.Security.AccessControl.FileSystemAccessRule(My.User.Name, Folder_Access, System.Security.AccessControl.InheritanceFlags.ContainerInherit Or System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, Action))
            Folder_Info.SetAccessControl(Folder_ACL)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            ' Return False
        End Try
    End Function

#End Region


#Region " Get All Files Function "

    ' [ Get All Files Function ]
    '
    ' // By Elektro H@cker
    '
    ' Examples:
    '
    ' Dim Files As Array = Get_All_Files("C:\Test", True)
    ' For Each File In Get_All_Files("C:\Test", False) : MsgBox(File) : Next

    Private Function Get_All_Files(ByVal Directory As String, Optional ByVal Recursive As Boolean = False) As Array
        If System.IO.Directory.Exists(Directory) Then
            If Not Recursive Then : Return System.IO.Directory.GetFiles(Directory, "*", IO.SearchOption.TopDirectoryOnly)
            Else : Return IO.Directory.GetFiles(Directory, "*", IO.SearchOption.AllDirectories)
            End If
        Else
            Return Nothing
        End If
    End Function

#End Region

    ' [ Block Process Functions ]
    '
    ' // By Elektro H@cker
    '
    ' Examples :
    ' BlockProcess.Block("cmd") ' Blocks a process
    ' BlockProcess.Block("firefox.exe") ' Blocks a process
    ' BlockProcess.Unblock("cmd") ' Unblocks a process
    ' BlockProcess.Unblock("firefox.exe") ' Unblocks a process
    '
    ' BlockProcess.Unblock_All() ' Reset all values and stop timer
    ' BlockProcess.Monitor_Interval = 5 * 1000
    ' BlockProcess.Show_Message_On_Error = True
    ' BlockProcess.Show_Message_On_blocking = True
    ' BlockProcess.Message_Text = "I blocked your process: "
    ' BlockProcess.Message_Title = "Block Process .:: By Elektro H@cker ::."

#Region " Block Process Class "

    Public Class BlockProcess

        Shared Blocked_APPS As New List(Of String) ' List of process names
        Shared WithEvents ProcessMon_Timer As New Timer ' App Monitor timer
        ''' <summary>
        ''' Shows a MessageBox if error occurs when blocking the app [Default: False].
        ''' </summary>
        Public Shared Show_Message_On_Error As Boolean = False
        ''' <summary>
        ''' Shows a MessageBox when app is being blocked [Default: False].
        ''' </summary>
        Public Shared Show_Message_On_blocking As Boolean = False
        ''' <summary>
        ''' Set the MessageBox On blocking Text.
        ''' </summary>
        Public Shared Message_Text As String = "Process blocked: "
        ''' <summary>
        ''' Set the MessageBox On blocking Title.
        ''' </summary>
        Public Shared Message_Title As String = "Process Blocked"
        ''' <summary>
        ''' Set the App Monitor interval in milliseconds [Default: 200].
        ''' </summary>
        Public Shared Monitor_Interval As Int64 = 200

        ''' <summary>
        ''' Add a process name to the process list.
        ''' </summary>
        Public Shared Sub Block(ByVal ProcessName As String)
            If ProcessName.ToLower.EndsWith(".exe") Then ProcessName = ProcessName.Substring(0, ProcessName.Length - 4)
            Blocked_APPS.Add(ProcessName)
            If Not ProcessMon_Timer.Enabled Then ProcessMon_Timer.Enabled = True
        End Sub

        ''' <summary>
        ''' Delete a process name from the process list.
        ''' </summary>
        Public Shared Sub Unblock(ByVal ProcessName As String)
            If ProcessName.ToLower.EndsWith(".exe") Then ProcessName = ProcessName.Substring(0, ProcessName.Length - 4)
            Blocked_APPS.Remove(ProcessName)
        End Sub

        ''' <summary>
        ''' Clear the process list and disables the App Monitor.
        ''' </summary>
        Public Shared Sub Unblock_All()
            ProcessMon_Timer.Enabled = False
            Blocked_APPS.Clear()
        End Sub

        ' Timer Tick Event
        Shared Sub ProcessMon_Timer_Tick(sender As Object, e As EventArgs) Handles ProcessMon_Timer.Tick

            For Each ProcessName In Blocked_APPS
                Dim proc() As Process = Process.GetProcessesByName(ProcessName)
                Try
                    For proc_num As Integer = 0 To proc.Length - 1
                        proc(proc_num).Kill()
                        If Show_Message_On_blocking Then
                            MessageBox.Show(Message_Text & ProcessName & ".exe", Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                        End If
                    Next
                Catch ex As Exception
                    If Show_Message_On_Error Then
                        MsgBox(ex.Message) ' One of the processes can't be killed
                    End If
                End Try
            Next

            ' Set the Timer interval if is different
            If Not sender.Interval = Monitor_Interval Then sender.Interval = Monitor_Interval

        End Sub

    End Class

#End Region

End Class

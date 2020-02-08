Public Class RegistryScan

#Region "Declarations"

    Dim key As Object

    Public Shared hklmpoliciessystem = "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System"
    Public Shared hkcupoliciessystem = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System"

    Public Shared hklmpoliciesexplorer = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"
    Public Shared hkcupoliciesexplorer = "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"

#End Region

    Public Shared Detections As New List(Of String)

    Public Shared Function Regedit_Scan_Engine1() As Boolean
        Try
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableTaskMgr", 0) = "1" Then
                Dim signature As String = "[HKLM] | Win.Anomalies.Task.M"
                ' Dim dicrectory As String = "[HKLM]"
                Detections.Add(signature)
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableTaskMgr", 0) = "1" Then
                'lstRegAVList.Items.Add("Win.Anomalies.Task.M [HKCU]")
                Dim signature As String = "[HKCU] | Win.Anomalies.Task.U"
                ' Dim dicrectory As String = "[HKCU]"
                Detections.Add(signature)
            End If

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableRegistryTools", 0) = "1" Then
                'lstRegAVList.Items.Add("Win.Anomalies.Registry [HKLM]")
                Dim signature As String = "[HKLM] | Win.Anomalies.Registry.M"
                'Dim dicrectory As String = "[HKLM]"
                Detections.Add(signature)
            End If

            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableRegistryTools", 0) = "1" Then
                'lstRegAVList.Items.Add("Win.Anomalies.Registry [HKCU]")
                Dim signature As String = "[HKCU] | Win.Anomalies.Registry.U"
                ' Dim dicrectory As String = "[HKCU]"
                Detections.Add(signature)
            End If

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "NoFolderOptions", 0) = "1" Then
                'lstRegAVList.Items.Add("Win.Anomalies.Folder [HKLM]")
                Dim signature As String = "[HKLM] | Win.Anomalies.Folder.M"
                ' Dim dicrectory As String = "[HKLM]"
                Detections.Add(signature)
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "NoFolderOptions", 0) = "1" Then
                'lstRegAVList.Items.Add("Win.Anomalies.Folder [HKCU]")
                Dim signature As String = "[HKCU] | Win.Anomalies.Folder.U"
                ' Dim dicrectory As String = "[HKCU]"
                Detections.Add(signature)
            End If

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableCMD", 0) = "1" Then
                ' lstRegAVList.Items.Add("Win.Anomalies.Cmd [HKLM]")
                Dim signature As String = "[HKLM] | Win.Anomalies.CMD.M"
                'Dim dicrectory As String = "[HKLM]"
                Detections.Add(signature)
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableCMD", 0) = "1" Then
                'lstRegAVList.Items.Add("Win.Anomalies.Cmd [HKCU]")
                Dim signature As String = "[HKCU] | Win.Anomalies.CMD.U"
                ' Dim dicrectory As String = "[HKCU]"
                Detections.Add(signature)
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Sub Regedit_Fix()
        Try

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableTaskMgr", 0) = "1" Then
                My.Computer.Registry.SetValue(hklmpoliciessystem, "DisableTaskMgr", 0)

            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableTaskMgr", 0) = "1" Then
                My.Computer.Registry.SetValue(hkcupoliciessystem, "DisableTaskMgr", 0)

            End If
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableRegistryTools", 0) = "1" Then
                My.Computer.Registry.SetValue(hklmpoliciessystem, "DisableRegistryTools", 0)

            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableRegistryTools", 0) = "1" Then
                My.Computer.Registry.SetValue(hkcupoliciessystem, "DisableRegistryTools", 0)

            End If
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "NoFolderOptions", 0) = "1" Then
                My.Computer.Registry.SetValue(hklmpoliciessystem, "NoFolderOptions", 0)

            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "NoFolderOptions", 0) = "1" Then
                My.Computer.Registry.SetValue(hkcupoliciessystem, "NoFolderOptions", 0)

            End If
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableCMD", 0) = "1" Then
                My.Computer.Registry.SetValue(hklmpoliciessystem, "DisableCMD", 0)

            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableCMD", 0) = "1" Then
                My.Computer.Registry.SetValue(hkcupoliciessystem, "DisableCMD", 0)

            End If
        Catch ex As Exception

        End Try
    End Sub


End Class

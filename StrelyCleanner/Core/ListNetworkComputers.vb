Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Collections
Imports System.Windows.Forms

Namespace ListNetworkComputers
#Region "NetworkBrowser CLASS"
    Public NotInheritable Class NetworkBrowser
#Region "Dll Imports"

        'declare the Netapi32 : NetServerEnum method import
        ' must be null
        ' null for login domain
        <DllImport("Netapi32", CharSet:=CharSet.Auto, SetLastError:=True), SuppressUnmanagedCodeSecurityAttribute> _
        Public Shared Function NetServerEnum(ServerNane As String, dwLevel As Integer, ByRef pBuf As IntPtr, dwPrefMaxLen As Integer, ByRef dwEntriesRead As Integer, ByRef dwTotalEntries As Integer, _
        dwServerType As Integer, domain As String, ByRef dwResumeHandle As Integer) As Integer
        End Function

        'declare the Netapi32 : NetApiBufferFree method import

        ''' <summary>
        ''' Netapi32.dll : The NetApiBufferFree function frees 
        ''' the memory that the NetApiBufferAllocate function allocates. 
        ''' Call NetApiBufferFree to free
        ''' the memory that other network 
        ''' management functions return.
        ''' </summary>
        <DllImport("Netapi32", SetLastError:=True), SuppressUnmanagedCodeSecurityAttribute> _
        Public Shared Function NetApiBufferFree(pBuf As IntPtr) As Integer
        End Function

        'create a _SERVER_INFO_100 STRUCTURE
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure _SERVER_INFO_100
            Friend sv100_platform_id As Integer
            <MarshalAs(UnmanagedType.LPWStr)> _
            Friend sv100_name As String
        End Structure
#End Region
#Region "Public Constructor"
        ''' <SUMMARY>
        ''' Constructor, simply creates a new NetworkBrowser object
        ''' </SUMMARY>

        Public Sub New()
        End Sub
#End Region
#Region "Public Methods"
        ''' <summary>
        ''' Uses the DllImport : NetServerEnum
        ''' with all its required parameters
        ''' (see http://msdn.microsoft.com/library/default.asp?
        '''      url=/library/en-us/netmgmt/netmgmt/netserverenum.asp
        ''' for full details or method signature) to
        ''' retrieve a list of domain SV_TYPE_WORKSTATION
        ''' and SV_TYPE_SERVER PC's
        ''' </summary>
        ''' <returns>Arraylist that represents
        ''' all the SV_TYPE_WORKSTATION and SV_TYPE_SERVER
        ''' PC's in the Domain</returns>
        Public Shared Function getNetworkComputers() As ArrayList
            'local fields
            Dim networkComputers As New ArrayList()
            Const MAX_PREFERRED_LENGTH As Integer = -1
            Dim SV_TYPE_WORKSTATION As Integer = 1
            Dim SV_TYPE_SERVER As Integer = 2
            Dim buffer As IntPtr = IntPtr.Zero
            Dim tmpBuffer As IntPtr = IntPtr.Zero
            Dim entriesRead As Integer = 0
            Dim totalEntries As Integer = 0
            Dim resHandle As Integer = 0
            Dim sizeofINFO As Integer = Marshal.SizeOf(GetType(_SERVER_INFO_100))


            Try
                'call the DllImport : NetServerEnum 
                'with all its required parameters
                'see http://msdn.microsoft.com/library/
                'default.asp?url=/library/en-us/netmgmt/netmgmt/netserverenum.asp
                'for full details of method signature
                Dim ret As Integer = NetServerEnum(Nothing, 100, buffer, MAX_PREFERRED_LENGTH, entriesRead, totalEntries, _
                    SV_TYPE_WORKSTATION Or SV_TYPE_SERVER, Nothing, resHandle)
                'if the returned with a NERR_Success 
                '(C++ term), =0 for C#
                If ret = 0 Then
                    'loop through all SV_TYPE_WORKSTATION 
                    'and SV_TYPE_SERVER PC's
                    For i As Integer = 0 To totalEntries - 1
                        'get pointer to, Pointer to the 
                        'buffer that received the data from
                        'the call to NetServerEnum. 
                        'Must ensure to use correct size of 
                        'STRUCTURE to ensure correct 
                        'location in memory is pointed to
                        tmpBuffer = New IntPtr(CInt(buffer) + (i * sizeofINFO))
                        'Have now got a pointer to the list 
                        'of SV_TYPE_WORKSTATION and 
                        'SV_TYPE_SERVER PC's, which is unmanaged memory
                        'Needs to Marshal data from an 
                        'unmanaged block of memory to a 
                        'managed object, again using 
                        'STRUCTURE to ensure the correct data
                        'is marshalled 
                        Dim svrInfo As _SERVER_INFO_100 = CType(Marshal.PtrToStructure(tmpBuffer, GetType(_SERVER_INFO_100)), _SERVER_INFO_100)

                        'add the PC names to the ArrayList
                        networkComputers.Add(svrInfo.sv100_name)
                    Next
                End If
            Catch ex As Exception
                ' MessageBox.Show("Problem with acessing " + "network computers in NetworkBrowser " + vbCr & vbLf & vbCr & vbLf & vbCr & vbLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return Nothing
            Finally
                'The NetApiBufferFree function frees 
                'the memory that the 
                'NetApiBufferAllocate function allocates
                NetApiBufferFree(buffer)
            End Try
            'return entries found
            Return networkComputers

        End Function
#End Region
    End Class
#End Region
End Namespace
Module modSysCleaner

    Public DetailItem() As clsDetailItem
    Public Enum myType
        Registry = 0
        SysFile = 1
        Startup = 2
        Service = 3
    End Enum
    Public Structure sCurrentItem
        Dim myType As MyType
        Dim ID As Integer
        Dim Type As String
        Dim Location As String
        Dim Item As String
    End Structure

    Public CurrentItem As sCurrentItem

    Public curID As Integer

End Module

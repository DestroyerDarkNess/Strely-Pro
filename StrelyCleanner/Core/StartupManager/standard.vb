Option Explicit On

Module standard

    'Returns the application's path
    Public Function AppPath() As String
        AppPath = Mid(GetPath(Windows.Forms.Application.ExecutablePath), 1, (Len(GetPath(Windows.Forms.Application.ExecutablePath)) - 1))
    End Function

    'Deletes a file if it exists
    Public Function fDestroy(ByVal sPath As String, ByVal sFileName As String) As Boolean

        sFileName = sPath & "\" & sFileName

        On Error GoTo FAILURE


        If FileExists(sFileName) Then Kill(sFileName)

        Return True

        Exit Function

FAILURE:
        Return False
    End Function

    'Return JUST the path from a string containing path+filename
    Public Function GetPath(ByVal FullPath As String) As String
        Dim sChar As String
        Dim X As Integer

        'Takes in a Path and Filename string and returns only the filename

        FullPath = Trim(FullPath)

        If Len(FullPath) = 0 Then
            GetPath = ""
            Exit Function
        End If


        X = Len(FullPath)
        sChar = ""

        Do Until sChar = "\" Or X = 0

            sChar = Mid(FullPath, X, 1)
            X = X - 1

        Loop

        If X > 0 Then X = X + 1



        GetPath = Mid(FullPath, 1, X)

    End Function

    'Centers a form
    Public Sub CenterForm(ByVal FormIn As Form)

        FormIn.Top = ((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - FormIn.Height) / 65)
        FormIn.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - FormIn.Width) / 2

    End Sub

    'Returns JUST the filename from a string containing path+filename (ext optional)
    Public Function GetFileName(ByVal FullPath As String, Optional ByVal NoExt As String = "") As String
        Dim sChar As String
        Dim X As Integer

        'Takes in a Path and Filename string and returns only the filename

        FullPath = Trim(FullPath)

        If Len(FullPath) = 0 Then
            GetFileName = ""
            Exit Function
        End If


        X = Len(FullPath)
        sChar = ""

        Do Until sChar = "\" Or X = 0

            sChar = Mid(FullPath, X, 1)
            X = X - 1

        Loop

        If X > 0 Then X = X + 1

        If NoExt = "NoXT" Then
            GetFileName = Mid(Right(FullPath, (Len(FullPath) - X)), 1, (Len(Trim(Right(FullPath, (Len(FullPath) - X)))) - 4))
        Else
            GetFileName = Right(FullPath, (Len(FullPath) - X))
        End If


        NoExt = ""

    End Function

    'Returns TRUE if a file exists
    Public Function FileExists(ByVal FilePath As String) As Boolean
        Dim FileName As String
        Dim TargetFile As String

        'Returns True if the file specified exists, False if not

        FileName = ""


        On Error GoTo NoFiles

        TargetFile = GetFileName(FilePath) 'Requires GetFileName function

        '
        'ChDir (FilePath)
        FileName = Dir(FilePath)

        If UCase(FileName) = UCase(TargetFile) Then
            FileExists = True
        Else
            FileExists = False
        End If



        Exit Function
NoFiles:

        FileExists = False

    End Function

    'Returns TRUE if a directory exists
    Public Function DirExists(ByVal FilePath As String) As Boolean
        Dim FileName As String
        Dim TargetFile As String

        'Returns True if the directory specified exists, False if not

        FileName = ""


        On Error GoTo NoFiles

        TargetFile = GetFileName(FilePath) 'Requires GetFileName function

        '
        'ChDir (FilePath)
        FileName = Dir(FilePath, vbDirectory)

        If UCase(FileName) = UCase(TargetFile) Then
            DirExists = True
        Else
            DirExists = False
        End If



        Exit Function
NoFiles:

        DirExists = False

    End Function

    'Finds a group of files and returns them in the array FileNames
    Public Sub FindFiles(ByVal Ext As String, ByVal FilePath As String, ByRef FileNames() As String)
        Dim FileName As String
        Dim X As Integer


        FilePath = Trim(FilePath)
        'If Right(FilePath, 1) = "\" Then
        '    FilePath = Mid(FilePath, 1, (Len(FilePath) - 1))
        'End If

        X = 0
        'load in files


        On Error GoTo NoFiles
        ChDrive(Mid(FilePath, 1, 3))
        ChDir(FilePath)

        FileName = Dir(Ext)

        Do

            'THIS IS WHERE FILE IS FOUND IF THERE ARE ANY


            FileNames(X) = FileName
            X = X + 1

            FileName = Dir()
        Loop Until FileName = ""



        Exit Sub
NoFiles:
        'Do Nothing
    End Sub

    'Pads a string either left or right with given character
    Public Function PadString(ByVal sString As String, ByVal dTotChars As Double, ByVal sFillChar As String, ByVal sLeft As Boolean) As String
        Dim dLen As Double
        Dim dFillLen As Double

        dLen = Len(Trim(sString))

        If dLen < dTotChars Then

            dFillLen = dTotChars - dLen

            If sLeft = True Then
                PadString = Microsoft.VisualBasic.Strings.StrDup(CInt(dFillLen), sFillChar) & Trim(sString)
            Else
                PadString = Trim(sString) & Microsoft.VisualBasic.Strings.StrDup(CInt(dFillLen), sFillChar)
            End If
        Else


            PadString = sString

        End If




    End Function

    Public Sub RegDLL(ByVal DLLName As String, Optional ByVal DLLPath As String = "APPLICATION")
        If DLLPath = "APPLICATION" Then DLLPath = AppPath()
        Shell(DLLPath & "\regsvr32.exe " & DLLName & " /s")
    End Sub

    'Public Function StringToByte(ByRef szString As String) As Byte()
    '    If szString.Length = 0 Then Exit Function
    '    Dim i As Integer
    '    Dim btRet(szString.Length - 1) As Byte
    '    For i = 0 To szString.Length - 1
    '        btRet(i) = Asc(szString.Chars(i))
    '    Next
    '    Return btRet
    'End Function

    'Public Function ByteToString(ByRef btBytes() As Byte) As String
    '    Dim szRet As String
    '    Dim i As Integer
    '    For i = LBound(btBytes) To UBound(btBytes)
    '        szRet += Chr(btBytes(i))
    '    Next
    '    Return szRet
    'End Function

End Module

Imports StrelyCleanner.BinaryCheck
Imports StrelyCleanner.OpenAssembly
Imports StrelyCleanner.DataBasesWrapper

Public Class NetAnalysis

    Public Shared Scan1 As String = String.Empty
    Public Shared Detection1 As String = String.Empty

    Public Shared Scan2 As String = String.Empty
    Public Shared Detection2 As String = String.Empty

    Public Shared Function NetScan(ByVal Archive As String) As Boolean
        Scan1 = String.Empty
        Scan2 = String.Empty
        ' //////////////////////////////////////////////////////////// Scan Imports 

        Dim BoolScan1 As Boolean = Nothing
        Dim Porcent1 As Integer = 0
        '/////////////////////////////////
        Dim MImports As String = GetDataA()
        Dim StrImports As String = GetDatA()
        '/////////////////////////////////
        Dim Importaciones As String = GetImports(Archive)
        '/////////////////////////////////
        Dim AssImports As String = Importaciones
        Dim Item As String() = AssImports.Split("|")

        '/////////////////////////////////

        Dim StrItem As String() = StrImports.Split("|")
        Dim ItemM As String() = MImports.Split("|")

        For Each Texti As String In Item
            If Not Texti = "" Then
                For Each Mi As String In ItemM
                    If Texti = Mi Then
                        Detection1 = Mi
                        BoolScan1 = True
                        Porcent1 += 1
                        If Scan1 = String.Empty Then
                            Scan1 = Texti
                        Else
                            Scan1 = Scan1 & vbNewLine & Texti
                        End If
                    Else
                        For Each strI As String In StrItem
                            If Texti.Contains(strI) = True Then
                                Detection1 = strI
                                BoolScan1 = True
                                Porcent1 += 1
                                If Scan1 = String.Empty Then
                                    Scan1 = strI

                                Else
                                    Scan1 = Scan1 & vbNewLine & strI
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next

        If BoolScan1 = Nothing Then
            BoolScan1 = False
        End If


        ' //////////////////////////////////////////////////////////// Scan Modules 

        Dim BoolScan2 As Boolean = Nothing
        Dim Porcent2 As Integer = 0
        '/////////////////////////////////
        Dim cClases As String = GetDataB()
        Dim SAs As String() = cClases.Split("|")
        '/////////////////////////////////
        Dim SimbolsClases As String = GetDatB()
        Dim SimbolsC As String() = SimbolsClases.Split(",")
        '/////////////////////////////////
        Dim Clases As String = GetNameModules(Archive)
        Dim ItemC As String() = Clases.Split("|")

        '/////////////////////////////////

        For Each Texti As String In ItemC
            If Not Texti = "" Then
                For Each Mi As String In SAs
                    If Texti.Contains(Mi) = True Then
                        Detection2 = Mi
                        BoolScan2 = True
                        Porcent2 += 1
                        If Scan2 = String.Empty Then
                            Scan2 = Texti
                        Else
                            Scan2 = Scan1 & vbNewLine & Texti
                        End If
                    Else
                        For Each strI As String In SimbolsC
                            If Texti.Contains(strI) = True Then
                                Detection2 = strI
                                MsgBox(strI & "    " & Texti)
                                BoolScan2 = True
                                Porcent2 += 1
                                If Scan2 = String.Empty Then
                                    Scan2 = strI
                                Else
                                    Scan2 = Scan1 & vbNewLine & strI
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next

        If BoolScan2 = Nothing Then
            BoolScan2 = False
        End If

        Return BoolScan2

    End Function




End Class

Public Class Processos

    Public Shared Icons As New ImageList
    Public Shared Function ConversorDeTamanho(ByVal namee As Integer) As String
        Dim MemBitSize As String = namee
        Select Case CDec(MemBitSize)
            Case 0 To CDec(999.999)
                MemBitSize = Format(CInt(CDec(MemBitSize)), "###,###,###,###,##0 Bytes")
            Case 1000 To CDec(999999.999)
                MemBitSize = Format(CInt(CDec(MemBitSize) / 1024), "###,###,###,##0 KB")
            Case 1000000 To CDec(999999999.999)
                MemBitSize = FormatNumber(CDec(MemBitSize) / 1048576, 2) & " MB"
            Case Is >= 1000000000
                MemBitSize = FormatNumber(CDec(MemBitSize) / 1024 / 1024 / 1024, 2) & " GB"
        End Select
        ConversorDeTamanho = MemBitSize
    End Function



    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean






    Public Shared Function AddToListView(ByVal list As ListView, ByVal optimize As Boolean) As Boolean

        For Each P As Process In Process.GetProcesses
            Dim PName As String, PTitle As String, memoria As String, memoria2 As String, PIcon As Icon
            Dim PID As Integer = 0
            Try
                PID = P.Id
            Catch ex As Exception
                'PName = "N/E"
            End Try
            Try
                PName = P.ProcessName
            Catch ex As Exception
                PName = "N/E"
            End Try
            Try
                PTitle = P.MainWindowTitle
            Catch ex As Exception
                PTitle = "N/E"
            End Try

            Try
                memoria = ConversorDeTamanho(P.WorkingSet64)
                memoria2 = memoria
            Catch ex As Exception
                memoria = "N/E"
                memoria2 = memoria
            End Try


            Try
                PIcon = Icon.ExtractAssociatedIcon(P.MainModule.FileName)

                Icons.Images.Add(list.SmallImageList.Images.Count, PIcon.ToBitmap())
            Catch ex As Exception
                PIcon = Nothing
            End Try

            Dim PImageIndex As Int32 = 0

            If Not PIcon Is Nothing Then
                PImageIndex = list.SmallImageList.Images.Count - 1
            Else
                PImageIndex = 0
            End If

            list.Items.Add(
            New ListViewItem(
            New String() {
            PID, PName, PTitle, memoria, memoria2
            }, PImageIndex
            )
            )

        Next


        If (optimize) Then
            For l As Integer = 0 To list.Items.Count - 1
                Try
                    Dim Proc As Process = Process.GetProcessById(CInt(list.Items(l).Text))

                    SetProcessWorkingSetSize(Proc.Handle, -1, -1)


                    Proc = Process.GetProcessById(Proc.Id)
                    list.Items(l).SubItems(4).Text = ConversorDeTamanho(Proc.WorkingSet64)

                    If list.Items(l).SubItems(4).Text.Contains("MB") Then
                        list.Items(l).BackColor = Color.FromArgb(255, 192, 192)
                    End If

                    If list.Items(l).SubItems(4).Text.Contains("KB") Then
                        list.Items(l).BackColor = Color.FromArgb(255, 255, 192)
                    End If
                    If list.Items(l).SubItems(4).Text.Contains("GB") Then
                        list.Items(l).BackColor = Color.Red
                    End If
                    If list.Items(l).SubItems(4).Text.Contains("Bytes") Then
                        list.Items(l).BackColor = Color.FromArgb(192, 255, 192)
                    End If
                    If list.Items(l).SubItems(4).Text.Contains("0 N/E") Then
                        list.Items(l).BackColor = Color.FromArgb(192, 255, 255)
                    End If
                Catch ex As Exception

                End Try

            Next
        Else
            For l As Integer = 0 To list.Items.Count - 1

                Try

                    If list.Items(l).SubItems(4).Text.Contains("MB") Then
                        list.Items(l).BackColor = Color.FromArgb(255, 192, 192)
                    End If

                    If list.Items(l).SubItems(4).Text.Contains("KB") Then
                        list.Items(l).BackColor = Color.FromArgb(255, 255, 192)
                    End If
                    If list.Items(l).SubItems(4).Text.Contains("GB") Then
                        list.Items(l).BackColor = Color.Red
                    End If
                    If list.Items(l).SubItems(4).Text.Contains("Bytes") Then
                        list.Items(l).BackColor = Color.FromArgb(192, 255, 192)
                    End If
                    If list.Items(l).SubItems(4).Text.Contains("0 N/E") Then
                        list.Items(l).BackColor = Color.FromArgb(192, 255, 255)
                    End If
                Catch ex As Exception
    
                End Try
            Next
        End If
        Return True
    End Function





End Class

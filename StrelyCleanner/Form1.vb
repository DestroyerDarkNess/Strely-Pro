Imports System.Runtime.InteropServices
Imports System.Management
Imports System.Threading
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.ComponentModel
Imports System.IO
Imports StrelyCleanner.SystemInformation
Imports StrelyCleanner.BoosterOptimizer
Imports StrelyCleanner.Protections
Imports StrelyCleanner.RegistryScan
Imports StrelyCleanner.FileDirSearcher
Imports StrelyCleanner.BinaryCheck
Imports StrelyCleanner.NetAnalysis
Imports StrelyCleanner.CARO.malware_naming_scheme
Imports StrelyCleanner.DestroyerSDK.LogFuncs
Imports StrelyCleanner.DestroyerSDK.WinPath
Imports StrelyCleanner.Protections.AntiDumpv3
Imports System.Net.Sockets

Public Class Form1

    Public WithEvents Noticoicon As NotifyIcon = New NotifyIcon

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Noticoicon.Visible = False
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Computer.FileSystem.FileExists(LogFile) = True Then
            My.Computer.FileSystem.DeleteFile(LogFile)
        End If

        Try : AddHandler Application.ThreadException, AddressOf Application_Exception_Handler _
                : Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, False) _
                : Catch : End Try

        Main1()
        HomeStart()
        InicoBoos()
        LoadItems()
        IniciateAds()
    End Sub

    Private Sub Application_Exception_Handler(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
        ' Here you can manage the exceptions:
        Dim ex As Exception = CType(e.Exception, Exception)
        WriteLog(ex.Message, InfoType.Exception)
        ' MsgBox(ex.Message)
        ' ...Or leave empty to ignore it.
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'AntiDump.StartProtection()
        ' TextBox2.Text = GetProcessModules(TextBox1.Text)

        '  MsgBox(FilesFolderDialog.Getoption().ToString)

     
        '[12, 13, 15, 17, 21, 23, 25, 27, 31, 32, 35, 37]

        ' Dim int32List As New List(Of String)

        ' int32List = myClientMachineIP.Distinct(EqualityComparer(Of Integer).Default).ToArray


        '  Me.BackColor = Color.Red
        '  Dim Patha As String = Application.StartupPath
        '  Dim ExeFile As Byte() = System.IO.File.ReadAllBytes(Patha & "\" & "Picker.exe")
        '  RunPE_ish.FUDMemoryExecute(ExeFile)
    End Sub

#Region " PositionForm function "

    Function CenterForm(ByVal Form_to_Center As Form, ByVal Form_Location As Point) As Point
        Dim FormLocation As New Point
        FormLocation.X = (Me.Left + (Me.Width - Form_to_Center.Width) / 2) ' set the X coordinates.
        FormLocation.Y = (Me.Top + (Me.Height - Form_to_Center.Height) / 2) ' set the Y coordinates.
        Return FormLocation ' return the Location to the Form it was called from.
    End Function

#End Region

#Region " Form Movement "

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As EventArgs) Handles Label1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As EventArgs) Handles Label3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As EventArgs) Handles PictureBox2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label7_MouseMove(sender As Object, e As EventArgs) Handles Label7.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

#Region " Usb Detector "

    Friend WithEvents DriveMon As New DriveWatcher

    Private Sub DriveMon_DriveStatusChanged(ByVal sender As Object, ByVal e As DriveWatcher.DriveStatusChangedEventArgs) _
   Handles DriveMon.DriveStatusChanged

        Select Case e.DeviceEvent

            Case DriveWatcher.DeviceEvents.Arrival
                Dim sb As New StringBuilder
                Dim sb1 As New StringBuilder
                ' sb.AppendLine("New drive connected...'")
                ' sb.AppendLine(String.Format("Type......: {0}", e.DriveInfo.DriveType.ToString))
                ' sb.AppendLine(String.Format("Label.....: {0}", e.DriveInfo.VolumeLabel))
                sb1.AppendLine(String.Format("Name......: {0}", e.DriveInfo.Name & vbNewLine))
                sb.AppendLine(String.Format("{0}", e.DriveInfo.RootDirectory))
                ' sb.AppendLine(String.Format("FileSystem: {0}", e.DriveInfo.DriveFormat))
                sb1.AppendLine(String.Format("Size......: {0} GB", (e.DriveInfo.TotalSize / (1024 ^ 3)).ToString("n1")))
                ' sb.AppendLine(String.Format("Free space: {0} GB", (e.DriveInfo.AvailableFreeSpace / (1024 ^ 3)).ToString("n1")))
                ' ListBox1.Items.Add(sb.ToString)

                ' Notify(Notify_Info.Info, sb.ToString, sb1.ToString, Color.Red)
                MsgBox("hola")
                Dim a As USBNotification = New USBNotification

                FormNotificacion(a)

            Case DriveWatcher.DeviceEvents.RemoveComplete
                ' Dim sb As New StringBuilder
                ' sb.AppendLine("Drive disconnected...'")
                ' sb.AppendLine(String.Format("Name: {0}", e.DriveInfo.Name))
                ' sb.AppendLine(String.Format("Root: {0}", e.DriveInfo.RootDirectory))
                ' ListBox1.Items.Add(sb.ToString)

        End Select

    End Sub

    ''' <summary>
    ''' Noticicaciones By **AINCRAD**
    ''' Para usarlos
    ''' FormNotificacion(NOMBRE DE SU FORMULARIO a mostrar)
    ''' </summary>
    ''' 
    Private Sub FormNotificacion(ByVal formulario As Control)
        Dim fh As Control = TryCast(formulario, Control)
        ' fh.ShowInTaskbar = False
        fh.Show()
        fh.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 1) - (formulario.Width / 1)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 1) - (formulario.Height / 1)))
    End Sub

#End Region

#Region " HOME "

    Public Sub HomeStart()
        Label2.Text = GetComputerInformation()
        Dim FirewallE As String = GetFirewall()
        Dim Antivir As String = GetAntiVirus()
        If FirewallE = "" Then
            lbl_Firewall.Text = "Firewall : [DANGER] You Do Not Own Registered Firewall."
            lbl_Firewall.ForeColor = Color.Red
        Else
            lbl_Firewall.Text = "Firewall : " & FirewallE
            lbl_Firewall.ForeColor = Color.Lime
        End If
        If Antivir = "" Then
            lbl_Antivirus.Text = "AntiVirus : [DANGER] You Do Not Own Registered AntiVirus."
            lbl_Antivirus.ForeColor = Color.Red
        Else
            lbl_Antivirus.Text = "AntiVirus : " & Antivir
            lbl_Antivirus.ForeColor = Color.Lime
        End If

    End Sub

#End Region

#Region " Bosster "

    Private Sub KILLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KILLToolStripMenuItem.Click
        Dim ItemIndex As Integer = Nothing
        Dim PIDv As Integer = Nothing
        Dim PText As String = String.Empty
        Dim PCaption As String = String.Empty
        Dim aProcess As System.Diagnostics.Process
        Try
            ItemIndex = AnimaExperimentalListView1.SelectedIndex
            PIDv = Integer.Parse(AnimaExperimentalListView1.Items(ItemIndex).Text)
            PText = AnimaExperimentalListView1.Items(ItemIndex).SubItems(1).Text
            PCaption = AnimaExperimentalListView1.Items(ItemIndex).SubItems(2).Text
        Catch ex As Exception
            WriteLog(ex.Message, InfoType.Exception)
        End Try
        Try
            aProcess = System.Diagnostics.Process.GetProcessById(PIDv)
            aProcess.Kill()
            AnimaExperimentalListView1.RemoveItem(ItemIndex)
        Catch ex As Exception
            WriteLog(ex.Message & vbTab & "Process Killer Error: " & PText & "(" & PCaption & ")", InfoType.Exception)
        End Try
    End Sub

    Public Sub InicoBoos()
        StartScanProcessAsyc()
        InicioGrapt()
        ' GetARPTablr()
    End Sub

#Region " Grap "

    Dim MIARRAY As ArrayList
    Dim MIX As Integer
    Dim MIRANDOM As Random
    Dim NUEVO As Integer
    Dim TEXTO As Integer = 5
    Dim FUENTE As Font
    Dim DIBUJO As Graphics
    Dim VALOR As Integer
    Dim RECTANGULO As Rectangle

    Public Sub InicioGrapt()
        Me.DoubleBuffered = True

        MIARRAY = New ArrayList

        For I = 0 To 59
            MIARRAY.Add(0)
        Next

        DIBUJO = PictureBox1.CreateGraphics
        DIBUJO.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        FUENTE = New Font("VERDANA", TEXTO, FontStyle.Bold)
        Timer1.Interval = 500
        Timer1.Start()
    End Sub

    Public Sub DrawGrgphic(ByVal ValuePoint As Integer, ByVal LineColor As Color)
        Dim Trazo = New Pen(LineColor, 2)
        MIRANDOM = New Random
        NUEVO = MIRANDOM.Next(0, 200)

        MIARRAY.Add(ValuePoint)

        If MIARRAY.Count > 60 Then
            MIARRAY.RemoveAt(0)
            PictureBox1.Refresh()
            DIBUJO.DrawLine(Pens.Gray, 0, CInt(PictureBox1.Height / 3), PictureBox1.Width, CInt(PictureBox1.Height / 3)) 'ESCALA MAXIMO
            DIBUJO.DrawLine(Pens.Gray, 0, CInt(PictureBox1.Height * 2 / 3), PictureBox1.Width, CInt(PictureBox1.Height * 2 / 3)) 'ESCALA MINIMO
        End If

        MIX = 0

        For I = 0 To MIARRAY.Count - 2
            VALOR = MIARRAY(I)

            '  If CheckBoxBARRAS.Checked Then 'DIBUJA BARRAS
            ' RECTANGULO = New Rectangle(MIX, PictureBox1.Height - VALOR - TEXTO, 3, VALOR) 'RECTANGULO DE LA GRAFICA DE BARRAS
            ' DIBUJO.FillRectangle(Brushes.Blue, RECTANGULO)
            '  End If
            'If CheckBoxLINEAS.Checked Then 'DIBUJA LINEAS
            DIBUJO.DrawLine(Trazo, MIX, PictureBox1.Height - VALOR - TEXTO, MIX + 10, PictureBox1.Height - MIARRAY(I + 1) - TEXTO)
            ' End If
            '  If CheckBoxTEXTO.Checked Then 'ESCRIBE EL VALOR
            'DIBUJO.DrawString(VALOR, FUENTE, Brushes.Red, MIX - TEXTO, PictureBox1.Height - VALOR - TEXTO * 2)
            '  End If

            MIX += 10
        Next
    End Sub


#End Region

    Dim SleepT As Integer = 0
    Dim RamPorcent As Integer = 0
    Dim cpuPorcent As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Cpuval As Integer = pc_CPU.NextValue - cpuPorcent
        Dim Ramval As Integer = pc_RAM.NextValue - (RamPorcent - GetRandom(1, 9))
        pb_CPU.Value = Cpuval
        pb_RAM.Value = Ramval
        lbl_cpu.Text = pb_CPU.Value - cpuPorcent & "%"
        lbl_ram.Text = pb_RAM.Value - RamPorcent & "%"

        Dim CPURAM As Integer = Cpuval + Ramval

        If CPURAM > 150 Then
            AnimaProgressBar1.BackColor = Color.Red
            AnimaProgressBar1.BorderColors = Color.Red
            DrawGrgphic(CPURAM, Color.Red)
        ElseIf CPURAM < 150 And CPURAM > 80 Then
            AnimaProgressBar1.BackColor = Color.Yellow
            AnimaProgressBar1.BorderColors = Color.Yellow
            DrawGrgphic(CPURAM, Color.Yellow)
        ElseIf CPURAM < 80 Then
            AnimaProgressBar1.BackColor = Color.Lime
            AnimaProgressBar1.BorderColors = Color.Lime
            DrawGrgphic(CPURAM, Color.Lime)
        End If
       AnimaProgressBar1.Value = CPURAM
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SleepT += 1
        If SleepT = 1000 Then
            RamPorcent = 0
            cpuPorcent = 0
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub AscButton_Big2_Click(sender As Object, e As EventArgs) Handles AscButton_Big2.Click
        If AscButton_Big2.Text = "Show" Then
            AscButton_Big2.Text = "Hide"
            Panel4.AutoScroll = True
            Panel4.Size = New Size(889, 477)
        ElseIf AscButton_Big2.Text = "Hide" Then
            AscButton_Big2.Text = "Show"
            Panel4.AutoScroll = False
            Panel4.Size = New Size(652, 25)
        End If
    End Sub

    Public Function CalculateYsize() As Integer
        Dim ItemsN As Integer = AnimaExperimentalListView1.Items.Count
        Dim SizeN As Integer = ItemsN * 25
        If SizeN < 450 Then
            SizeN = 450
        End If
        Return SizeN
    End Function

    Public Sub OPInizialice()
        Dim RamOp As Boolean = RamOptimize()
        If RamOp = True Then
            RamPorcent = 10
            cpuPorcent = 10
        Else
            MsgBox("Error")
        End If
        If Not AscSwitch1.Checked = True Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub AscSwitch1_CheckedChanged(sender As Object) Handles AscSwitch1.CheckedChanged
        OPInizialice()
    End Sub

    Private Sub AscButton_Big1_Click(sender As Object, e As EventArgs) Handles AscButton_Big1.Click
        OPInizialice()
    End Sub

    Dim act As New Action(
    Sub()
        Dim FirsScan As Boolean = False
        If FirsScan = False Then
            GoTo scanS
            FirsScan = True
        End If
        Dim ContadorS As Integer = 0
        Do While True
            ContadorS += 1
            If ContadorS = 100 Then
ScanS:
                Dim lwProcs As New ListView
                lwProcs.Columns.Add("ID")
                lwProcs.Columns.Add("Process")
                lwProcs.Columns.Add("Caption")
                lwProcs.Columns.Add("Memory")
                lwProcs.Columns.Add("Diferencial")
                Processos.Icons.Images.Add(0, imgIcons.Images(0))
                Dim resultado As Boolean = Processos.AddToListView(lwProcs, True)
                If resultado = True Then
                    AnimaExperimentalListView1.Clear()
                    For Each item As ListViewItem In lwProcs.Items
                        ' AnimaExperimentalListView1.Items.
                        Me.Invoke(Sub() Display(item))
                    Next
                    Me.Invoke(Sub()
                                  If AscButton_Big2.Text = "Hide" Then
                                      AnimaExperimentalListView1.Size = New Size(725, CalculateYsize)
                                  End If
                              End Sub)
                End If
                ContadorS = 0
            End If
        Loop
    End Sub)

    Public Sub Display(ByVal item As ListViewItem)
        AnimaExperimentalListView1.Add(item)
    End Sub

    Public Sub StartScanProcessAsyc()
        Dim tsk As New Task(act, TaskCreationOptions.LongRunning)
        tsk.Start()
    End Sub

#End Region

#Region " Glass "

    Private Declare Sub DwmEnableBlurBehindWindow Lib "dwmapi.dll" ( _
   ByVal hwnd As IntPtr, _
   ByRef blurBehind As DWM_BLURBEHIND)

    Private Declare Function GetConsoleWindow Lib "Kernel32.dll" () As IntPtr

    Private Structure DWM_BLURBEHIND
        Public dwFlags As DwmBlurBehindDwFlags
        Public fEnable As Boolean
        Public hRgnBlur As IntPtr
        Public fTransitionOnMaximized As Boolean
    End Structure

    Private Enum DwmBlurBehindDwFlags
        DWM_BB_ENABLE = &H1
        DWM_BB_BLURREGION = &H2
        DWM_BB_TRANSITIONONMAXIMIZED = &H4
    End Enum

    Public Sub Main1()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        DwmEnableBlurBehindWindow(GetConsoleWindow, New DWM_BLURBEHIND With {.dwFlags = DwmBlurBehindDwFlags.DWM_BB_ENABLE, .fEnable = True})
    End Sub

#End Region

#Region " Startup Manager "

    Dim nextY As Integer = 1

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadItems()
    End Sub

    Private Sub LoadItems()
        curID = 0
        nextY = 1
        panItems.Controls.Clear()

        If chkRegistry.Checked = True Then GetRegistryItems()
        If chkStartup.Checked = True Then GetStartup()
        If chkSystemFiles.Checked = True Then GetSysFile()
        If chkProcesses.Checked = True Then GetServices()
    End Sub

#Region "CleanerR"

    Private Function GetRegistryItems() As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim RegKeys(14) As String
        RegKeys(0) = "Run"
        RegKeys(1) = "RunOnce"
        RegKeys(2) = "RunOnceEx"
        RegKeys(3) = "RunServices"

        For Y = 9 To 12
            RegKeys(Y) = RegKeys(Y - 9)
            RegKeys(Y) = ".DEFAULT\Software\Microsoft\Windows\CurrentVersion\" & RegKeys(Y)
        Next
        For Y = 4 To 7
            RegKeys(Y) = RegKeys(Y - 4)
            RegKeys(Y) = "Software\Microsoft\Windows\CurrentVersion\" & RegKeys(Y)
        Next

        For Y = 0 To 3
            RegKeys(Y) = "SOFTWARE\Microsoft\Windows\CurrentVersion\" & RegKeys(Y)
        Next



        For Y = 0 To 3
            Try
                If Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RegKeys(Y)).GetValueNames.Length > 0 Then
                    For X = 0 To (Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RegKeys(Y)).GetValueNames.Length - 1)
                        Try
                            AddItem(modSysCleaner.myType.Registry, "LM:" & RegKeys(Y), Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RegKeys(Y)).GetValueNames(X))                             '(Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RegKeys(Y)).GetValueNames(X)))
                        Catch
                        End Try
                    Next
                End If
            Catch
            End Try
        Next Y


        For Y = 4 To 7
            Try
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(Y)).GetValueNames.Length > 0 Then
                    For X = 0 To (Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(Y)).GetValueNames.Length - 1)
                        Try
                            AddItem(modSysCleaner.myType.Registry, "CU:" & RegKeys(Y), Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(Y)).GetValueNames(X))                              '(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(Y)).GetValueNames(X)))
                        Catch
                        End Try
                    Next
                End If
            Catch
            End Try
        Next Y

        RegKeys(8) = "Software\Microsoft\Windows NT\CurrentVersion\Windows"
        Try
            If Trim(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(8)).GetValue("load")) <> "" Then AddItem(modSysCleaner.myType.Registry, "CU:" & RegKeys(8) & "\load", Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(8)).GetValueNames("load"))
        Catch
        End Try

        For Y = 9 To 12
            Try
                If Microsoft.Win32.Registry.Users.OpenSubKey(RegKeys(Y)).GetValueNames.Length > 0 Then
                    For X = 0 To (Microsoft.Win32.Registry.Users.OpenSubKey(RegKeys(Y)).GetValueNames.Length - 1)
                        Try
                            AddItem(modSysCleaner.myType.Registry, "U:" & RegKeys(Y), Microsoft.Win32.Registry.Users.OpenSubKey(RegKeys(Y)).GetValueNames(X))                             '(Microsoft.Win32.Registry.Users.OpenSubKey(RegKeys(Y)).GetValueNames(X)))
                        Catch
                        End Try
                    Next
                End If
            Catch
            End Try
        Next Y

        RegKeys(13) = ".DEFAULT\Software\Microsoft\Windows NT\CurrentVersion\Windows"
        Try
            If Trim(Microsoft.Win32.Registry.Users.OpenSubKey(RegKeys(13)).GetValue("load")) <> "" Then AddItem(modSysCleaner.myType.Registry, "CU:" & RegKeys(8) & "\load", Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKeys(13)).GetValue("load"))
        Catch
        End Try



    End Function

    Private Function GetServices() As Integer
        Dim X As Integer
        Dim SvsToCheck(11) As String
        SvsToCheck(0) = "Internet Connection Firewall (ICF) / Internet Connection Sharing (ICS)"
        SvsToCheck(1) = "Messenger"
        SvsToCheck(2) = "Telnet"
        SvsToCheck(3) = "Help and Support"
        SvsToCheck(4) = "Task Scheduler"
        SvsToCheck(5) = "Terminal Services"
        SvsToCheck(6) = "System Restore Service"
        SvsToCheck(7) = "Themes"
        SvsToCheck(8) = "Event Log"
        SvsToCheck(9) = "Adobe LM Service"
        SvsToCheck(10) = "Alias Wavefront Help Server"

    End Function

    Private Function GetStartup() As Integer
        Dim FileNames(100) As String
        Dim CurUser As String
        Dim AllUsers As String
        Dim X As Integer

        'Get the current user so we know which path to go into...
        CurUser = System.Environment.UserName

        FindFiles("*", System.Environment.GetFolderPath(Environment.SpecialFolder.Startup), FileNames)
        For X = 0 To (FileNames.Length - 1)
            If FileNames(X) = "" Then Exit For
            AddItem(modSysCleaner.myType.Startup, System.Environment.GetFolderPath(Environment.SpecialFolder.Startup), FileNames(X))
        Next

        AllUsers = Replace(System.Environment.GetFolderPath(Environment.SpecialFolder.Startup), CurUser, "All Users", 1, , CompareMethod.Binary)
        FindFiles("*", AllUsers, FileNames)
        For X = 0 To (FileNames.Length - 1)
            If FileNames(X) = "" Then Exit For
            AddItem(modSysCleaner.myType.Startup, AllUsers, FileNames(X))
        Next
    End Function

    Private Function GetSysFile() As Integer
        Dim sysFileWin As String
        Dim sysFileDrive As String
        Dim fileName As String
        Dim fileNum As Integer
        Dim aLine As String


        sysFileWin = GetOsDir(System.Environment.SystemDirectory, sysFileDrive)

        'First check Autoexec.bat...
        fileNum = FreeFile()
        fileName = sysFileDrive & "autoexec.bat"

        Microsoft.VisualBasic.FileOpen(fileNum, fileName, OpenMode.Input)
        Do While Not EOF(fileNum)
            Microsoft.VisualBasic.Input(fileNum, aLine)

            If InStr(aLine, ".exe", CompareMethod.Binary) Or InStr(aLine, ".bat", CompareMethod.Binary) Or InStr(aLine, ".lnk", CompareMethod.Binary) Or InStr(aLine, ".vbs", CompareMethod.Binary) Or InStr(aLine, ".htm", CompareMethod.Binary) Or InStr(aLine, ".html", CompareMethod.Binary) Or InStr(aLine, ".msi", CompareMethod.Binary) Or InStr(aLine, "load", CompareMethod.Binary) Or InStr(aLine, "run", CompareMethod.Binary) Or InStr(aLine, ".msc", CompareMethod.Binary) Then
                AddItem(modSysCleaner.myType.SysFile, fileName, aLine)
            End If
        Loop
        Microsoft.VisualBasic.FileClose(fileNum)

        'second check config.sys...
        fileNum = FreeFile()
        fileName = sysFileDrive & "config.sys"

        Microsoft.VisualBasic.FileOpen(fileNum, fileName, OpenMode.Input)
        Do While Not EOF(fileNum)
            Microsoft.VisualBasic.Input(fileNum, aLine)

            If InStr(aLine, ".exe", CompareMethod.Binary) Or InStr(aLine, ".bat", CompareMethod.Binary) Or InStr(aLine, ".lnk", CompareMethod.Binary) Or InStr(aLine, ".vbs", CompareMethod.Binary) Or InStr(aLine, ".htm", CompareMethod.Binary) Or InStr(aLine, ".html", CompareMethod.Binary) Or InStr(aLine, ".msi", CompareMethod.Binary) Or InStr(aLine, "load", CompareMethod.Binary) Or InStr(aLine, "run", CompareMethod.Binary) Or InStr(aLine, ".msc", CompareMethod.Binary) Then
                AddItem(modSysCleaner.myType.SysFile, fileName, aLine)
            End If
        Loop
        Microsoft.VisualBasic.FileClose(fileNum)


        'Now, System.INI
        fileNum = FreeFile()
        fileName = sysFileWin & "system.ini"

        Microsoft.VisualBasic.FileOpen(fileNum, fileName, OpenMode.Input)
        Do While Not EOF(fileNum)
            Microsoft.VisualBasic.Input(fileNum, aLine)

            If InStr(aLine, ".exe", CompareMethod.Binary) Or InStr(aLine, ".bat", CompareMethod.Binary) Or InStr(aLine, ".lnk", CompareMethod.Binary) Or InStr(aLine, ".vbs", CompareMethod.Binary) Or InStr(aLine, ".htm", CompareMethod.Binary) Or InStr(aLine, ".html", CompareMethod.Binary) Or InStr(aLine, ".msi", CompareMethod.Binary) Or InStr(aLine, "load", CompareMethod.Binary) Or InStr(aLine, "run", CompareMethod.Binary) Or InStr(aLine, ".msc", CompareMethod.Binary) Then
                AddItem(modSysCleaner.myType.SysFile, fileName, aLine)
            End If
        Loop
        Microsoft.VisualBasic.FileClose(fileNum)

        'finnally, win.INI
        fileNum = FreeFile()
        fileName = sysFileWin & "win.ini"

        Microsoft.VisualBasic.FileOpen(fileNum, fileName, OpenMode.Input)
        Do While Not EOF(fileNum)
            Microsoft.VisualBasic.Input(fileNum, aLine)

            If InStr(aLine, ".exe", CompareMethod.Binary) Or InStr(aLine, ".bat", CompareMethod.Binary) Or InStr(aLine, ".lnk", CompareMethod.Binary) Or InStr(aLine, ".vbs", CompareMethod.Binary) Or InStr(aLine, ".htm", CompareMethod.Binary) Or InStr(aLine, ".html", CompareMethod.Binary) Or InStr(aLine, ".msi", CompareMethod.Binary) Or InStr(aLine, "load", CompareMethod.Binary) Or InStr(aLine, "run", CompareMethod.Binary) Or InStr(aLine, ".dll", CompareMethod.Binary) Then
                AddItem(modSysCleaner.myType.SysFile, fileName, aLine)
            End If
        Loop
        Microsoft.VisualBasic.FileClose(fileNum)



    End Function

    Private Function GetOsDir(ByVal PathIn As String, ByRef OsDrive As String) As String
        Dim StopLen As Integer
        Dim OneChar As Char = "*"

        StopLen = 0
        Do Until OneChar = "\"
            StopLen += 1
            OneChar = Mid(PathIn, StopLen, 1)
        Loop

        OsDrive = Mid(PathIn, 1, StopLen)
        OneChar = "*"

        Do Until OneChar = "\"
            StopLen += 1
            OneChar = Mid(PathIn, StopLen, 1)
        Loop

        Return Mid(PathIn, 1, StopLen)

    End Function

    Private Sub AddItem(ByVal itemType As myType, ByVal sLocation As String, ByVal sItem As String)
        Dim I As Integer
        Const detailItemHeight As Integer = 14
        Const spaceBetweenItems As Integer = 3


        'ADD A DETAIL RECORD
        ReDim Preserve DetailItem((curID + 1))
        I = curID
        DetailItem(I) = New clsDetailItem

        DetailItem(I).SetBounds(0, nextY, panItems.Width - 20, detailItemHeight)
        'alternating color...
        If I Mod 2 = 0 Then
            DetailItem(I).BackColor = System.Drawing.Color.White
            DetailItem(I).textForeColor = System.Drawing.Color.Black
        Else
            DetailItem(I).BackColor = System.Drawing.Color.Azure
            DetailItem(I).textForeColor = System.Drawing.Color.Black
        End If
        DetailItem(I).BorderStyle = BorderStyle.None

        panItems.Controls.Add(DetailItem(I))

        DetailItem(I).Controls.Add(DetailItem(I).lblID)
        DetailItem(I).Controls.Add(DetailItem(I).lblType)
        DetailItem(I).Controls.Add(DetailItem(I).lblLocation)
        DetailItem(I).Controls.Add(DetailItem(I).lblItem)

        'FILL WITH DATA
        DetailItem(I).ID = I
        DetailItem(I).lblID.Text = (I + 1).ToString
        DetailItem(I).itemType = itemType
        DetailItem(I).lblLocation.Text = sLocation
        DetailItem(I).fullItem = sItem
        DetailItem(I).lblItem.Text = GetFileName(sItem)


        AddHandler DetailItem(I).Click, AddressOf DetailItem_click
        AddHandler DetailItem(I).lblID.Click, AddressOf DetailItem_click
        AddHandler DetailItem(I).lblType.Click, AddressOf DetailItem_click
        AddHandler DetailItem(I).lblLocation.Click, AddressOf DetailItem_click
        AddHandler DetailItem(I).lblItem.Click, AddressOf DetailItem_click


        nextY += detailItemHeight + spaceBetweenItems
        curID += 1

    End Sub

    Private Sub DetailItem_click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With CurrentItem
            lblID.Text = (.ID + 1).ToString
            lblType.ForeColor = GetTypeColor(.myType)
            lblType.Text = .Type
            lblLocation.Text = .Location
            lblItem.Text = .Item


            GetDetailOnItem()


            ' btnDestroy.Text = "Destroy Item"

            If .myType = modSysCleaner.myType.SysFile Then
                ' btnDestroy.Visible = False
            Else
                ' btnDestroy.Visible = True
            End If

            If .myType = modSysCleaner.myType.Service Then
                ' btnDestroy.Text = "Stop Service"
            End If

            If .myType = modSysCleaner.myType.Registry Then
                ' btnDestroy.Text = "Destroy Key"
            End If


        End With

        panItemDetail.Visible = True
        Filtro()
    End Sub
    Private Sub GetDetailOnItem()
        Dim MainKey As String = Mid(CurrentItem.Location, 1, InStr(CurrentItem.Location, ":", CompareMethod.Binary))
        Dim SubKey As String = Mid(CurrentItem.Location, InStr(CurrentItem.Location, ":", CompareMethod.Binary) + 1)


        Select Case CurrentItem.myType
            Case modSysCleaner.myType.Registry

                Select Case MainKey
                    Case "CU:"
                        lblItem.Text = (Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString)
                    Case "LM:"
                        'MsgBox("SUBKEY: " & SubKey & vbCrLf & "MAINKEY: " & MainKey & vbCrLf & "CURITEM: " & CurrentItem.Item)
                        lblItem.Text = (Microsoft.Win32.Registry.LocalMachine.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString)
                    Case "U:"
                        lblItem.Text = (Microsoft.Win32.Registry.Users.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString)

                End Select

        End Select

    End Sub

    Private Sub Filtro()
        On Error Resume Next

        exeIcon.Image = Nothing

        Dim path As String = lblItem.Text
        Dim i As Integer = path.IndexOf("""")

        Dim resultado As String = path.Substring(i + 1, path.IndexOf("""", i + 1) - i - 1)

        Dim result1 As String = resultado.Split(New String() {" /"}, StringSplitOptions.RemoveEmptyEntries)(0)
        Dim result2 As String = result1.Split(New String() {" -"}, StringSplitOptions.RemoveEmptyEntries)(0)
        exeIcon.Image = Icon.ExtractAssociatedIcon(result2).ToBitmap

        Dim s As String = lblItem.Text
        Dim result As String = s.Split(New String() {" /"}, StringSplitOptions.RemoveEmptyEntries)(0)
        Dim result3 As String = result.Split(New String() {" -"}, StringSplitOptions.RemoveEmptyEntries)(0)
        exeIcon.Image = Icon.ExtractAssociatedIcon(result3).ToBitmap
    End Sub

    Private Function GetTypeColor(ByVal typeIn As myType) As System.Drawing.Color
        Select Case typeIn
            Case modSysCleaner.myType.Service
                Return System.Drawing.Color.DarkBlue
            Case modSysCleaner.myType.Registry
                Return System.Drawing.Color.DarkRed
            Case modSysCleaner.myType.Startup
                Return System.Drawing.Color.DarkGreen
            Case modSysCleaner.myType.SysFile
                Return System.Drawing.Color.DarkGoldenrod
        End Select
    End Function

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadItems()
        panItemDetail.Visible = False
    End Sub

    Private Sub btnDestroy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestroy.Click
        Try
            Dim MainKey As String = Mid(CurrentItem.Location, 1, InStr(CurrentItem.Location, ":", CompareMethod.Binary))
            Dim SubKey As String = Mid(CurrentItem.Location, InStr(CurrentItem.Location, ":", CompareMethod.Binary) + 1)
            Dim RC As Integer
            Dim TempReg

            Select Case CurrentItem.myType
                Case modSysCleaner.myType.Registry
                    Select Case MainKey
                        Case "CU:"
                            RC = MsgBox("Are you sure you want to delete registry value: " & SubKey & "\" & CurrentItem.Item & "?", MsgBoxStyle.YesNo, "Confirm Registry Delete")
                            If RC = vbYes Then
                                TempReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKey, True)
                                TempReg.deletevalue(CurrentItem.Item)
                                TempReg.close()
                                GoTo CloseOut
                            End If

                        Case "LM:"
                            RC = MsgBox("Are you sure you want to delete registry value: " & SubKey & "\" & CurrentItem.Item & "?", MsgBoxStyle.YesNo, "Confirm Registry Delete")
                            If RC = vbYes Then
                                TempReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(SubKey, True)
                                TempReg.deletevalue(CurrentItem.Item)
                                TempReg.close()
                                GoTo CloseOut
                            End If
                        Case "U:"
                            RC = MsgBox("Are you sure you want to delete registry value: " & SubKey & "\" & CurrentItem.Item & "?", MsgBoxStyle.YesNo, "Confirm Registry Delete")
                            If RC = vbYes Then
                                TempReg = Microsoft.Win32.Registry.Users.OpenSubKey(SubKey, True)
                                TempReg.deletevalue(CurrentItem.Item)
                                TempReg.close()
                                GoTo CloseOut
                            End If
                    End Select
                Case modSysCleaner.myType.Startup
                    RC = MsgBox("Are you sure you want to delete startup item: " & CurrentItem.Item & "?", MsgBoxStyle.YesNo, "Confirm File Delete")
                    If RC = vbYes Then
                        Try
                            Kill(CurrentItem.Location & "\" & CurrentItem.Item)
                        Catch
                            MsgBox("Failed to delete: " & CurrentItem.Item & ", file may be in use!")
                        End Try
                        GoTo CloseOut
                    End If

                Case modSysCleaner.myType.SysFile
                    'If ClearLineFromFile() Then GoTo CloseOut

                Case modSysCleaner.myType.Service


            End Select

            Exit Sub
CloseOut:
            panItemDetail.Visible = False
            LoadItems()
        Catch ex As Exception
            WriteLog(ex.Message, InfoType.Exception)
        End Try
    End Sub
    Private Function ClearLineFromFile() As Boolean
        Dim OldFileNum, NewFileNum As Integer
        Dim OldFileName, NewFileName As String
        Dim aLine As String



        OldFileName = CurrentItem.Location
        NewFileName = GetPath(OldFileName) & "1" & GetFileName(OldFileName)

        OldFileNum = FreeFile()
        FileOpen(OldFileNum, OldFileName, OpenMode.Input)
        NewFileNum = FreeFile()
        FileOpen(NewFileNum, NewFileName, OpenMode.Random)
        Do While Not EOF(OldFileNum)
            Input(OldFileNum, aLine)
            If InStr(aLine, CurrentItem.Item, CompareMethod.Binary) Then
            Else
                'aLine = aLine & Chr(13)
                FilePut(NewFileNum, aLine)

            End If
        Loop
        FileClose(OldFileNum)
        FileClose(NewFileNum)

        Try
            Kill(OldFileName)
        Catch ex As Exception
            MsgBox("Cannot destroy line from: " & OldFileName)
            Return False
            Exit Function
        End Try

        Try
            FileCopy(NewFileName, OldFileName)
        Catch ex As Exception
            MsgBox("Cannot destroy line from: " & OldFileName)
            Return False
            Exit Function
        End Try

        Try
            Kill(NewFileName)
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorer.Click
        Dim MainKey As String = Mid(CurrentItem.Location, 1, InStr(CurrentItem.Location, ":", CompareMethod.Binary))
        Dim SubKey As String = Mid(CurrentItem.Location, InStr(CurrentItem.Location, ":", CompareMethod.Binary) + 1)
        Dim RC As Integer
        Dim TempReg

        Select Case CurrentItem.myType
            Case modSysCleaner.myType.Registry
                Select Case MainKey
                    Case "CU:"
                        ExploreFile(GetPath(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString))
                        ' Shell("explorer " & GetPath(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString), AppWinStyle.NormalFocus)
                    Case "LM:"
                        ExploreFile(GetPath(Microsoft.Win32.Registry.LocalMachine.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString))
                    Case "U:"
                        ExploreFile(GetPath(Microsoft.Win32.Registry.Users.OpenSubKey(SubKey).GetValue(CurrentItem.Item, CurrentItem.Item).ToString))
                End Select
            Case modSysCleaner.myType.Startup
                ExploreFile(GetPath(CurrentItem.Location & "\" & CurrentItem.Item))
            Case modSysCleaner.myType.SysFile
                ExploreFile(CurrentItem.Location)
            Case modSysCleaner.myType.Service
                Try
                    Shell((System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\Com\comexp.msc"), AppWinStyle.NormalFocus)
                Catch
                    MsgBox("Cannot open service window, goto ADMINISTRATIVE TOOLS - COMPONENT SERVICES)")
                End Try
                'MsgBox(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\Com\comexp.msc")
        End Select

        Exit Sub

    End Sub

    Public Function ExploreFile(ByVal filePath As String) As Boolean
        Try
            If Not System.IO.File.Exists(filePath) Then
                'Return False
            End If

            filePath = System.IO.Path.GetFullPath(filePath)
            System.Diagnostics.Process.Start("explorer.exe", String.Format("/select,""{0}""", filePath))
            Return True
        Catch ex As Exception
            Shell("explorer " & filePath, AppWinStyle.NormalFocus)
        End Try
    End Function

    Private Sub chkProcesses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProcesses.Click, chkRegistry.Click, chkStartup.Click, chkSystemFiles.Click
        panItemDetail.Visible = False
        LoadItems()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panItemDetail.Visible = False
        LoadItems()
    End Sub

#End Region

#End Region

#Region " ARP Inspector "

    Public Const ERROR_SUCCESS As Integer = 0
    Public Const ERROR_INSUFFICIENT_BUFFER As Integer = 122

    <DllImport("IpHlpApi.dll")>
    Private Shared Function GetIpNetTable(pIpNetTable As IntPtr, <MarshalAs(UnmanagedType.U4)> ByRef pdwSize As Integer, bOrder As Boolean) As <MarshalAs(UnmanagedType.U4)> Integer
    End Function

    Public Structure MIB_IPNETROW

        <MarshalAs(UnmanagedType.U4)>
        Public dwIndex As UInteger
        <MarshalAs(UnmanagedType.U4)>
        Public dwPhysAddrLen As UInteger
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)>
        Public bPhysAddr() As Byte
        <MarshalAs(UnmanagedType.U4)>
        Public dwAddr As UInteger
        <MarshalAs(UnmanagedType.U4)>
        Public dwType As DWTYPES

    End Structure

    Public Enum DWTYPES As UInteger
        <MarshalAs(UnmanagedType.U4)>
        Other = 1
        <MarshalAs(UnmanagedType.U4)>
        Invalid = 2
        <MarshalAs(UnmanagedType.U4)>
        Dynamic = 3
        <MarshalAs(UnmanagedType.U4)>
        [Static] = 4
    End Enum

    Public Sub GetARPTablr()

        Dim bytesNeeded As Integer = 0

        Dim result As Integer = GetIpNetTable(IntPtr.Zero, bytesNeeded, False)

        If result <> ERROR_INSUFFICIENT_BUFFER Then

            Throw New Win32Exception(result)
        End If


        Dim buffer As IntPtr = IntPtr.Zero


        Try

            buffer = Marshal.AllocCoTaskMem(bytesNeeded)


            result = GetIpNetTable(buffer, bytesNeeded, False)

            If result <> ERROR_SUCCESS Then

                Throw New Win32Exception(result)
            End If


            Dim entries As Integer = Marshal.ReadInt32(buffer)

            Dim currentBuffer As New IntPtr(buffer.ToInt64() + Marshal.SizeOf(GetType(Integer)))


            Dim table As MIB_IPNETROW() = New MIB_IPNETROW(entries - 1) {}

            For index As Integer = 0 To entries - 1

                table(index) = DirectCast(Marshal.PtrToStructure(New IntPtr(currentBuffer.ToInt64() + (index * Marshal.SizeOf(GetType(MIB_IPNETROW)))), GetType(MIB_IPNETROW)), MIB_IPNETROW)
            Next
            ThirteenTextBox1.Text = ""
            ThirteenTextBox1.Text = "" & vbNewLine ' "ARP Inspect .......................................... Beta Test " & vbNewLine

            For index As Integer = 0 To entries - 1
                If table(index).dwType <> DWTYPES.Invalid And table(index).dwType <> DWTYPES.Other Then

                    Dim AddLineText As String = String.Empty
                    Dim CheckPp As Boolean = False
                    Dim TypeN As String = table(index).dwType.ToString
                    Dim ip As New IPAddress(table(index).dwAddr)
                    Dim mac As New PhysicalAddress(table(index).bPhysAddr)
                    Dim PingS As String = String.Empty

                    If PingCheckBox2.Checked = True Then
                        PingS = Ping(ip.ToString())
                    Else
                        PingS = String.Empty
                    End If
                    
                    If table(index).dwType = DWTYPES.Dynamic Then
                        If DynamicCheckBox2.Checked = True Then
                            AddLineText = TypeN & vbTab & vbTab & "IP: " + ip.ToString() & vbTab & vbTab & "MAC: " & MACtoString(mac)
                            CheckPp = True
                        End If
                    ElseIf table(index).dwType = DWTYPES.Static Then
                        If StaticCheckBox1.Checked = True Then
                            AddLineText = TypeN & vbTab & vbTab & "IP: " + ip.ToString() & vbTab & vbTab & "MAC: " & MACtoString(mac)
                            CheckPp = True
                        End If
                    ElseIf table(index).dwType = DWTYPES.Other Then
                        AddLineText = TypeN & vbTab & vbTab & "IP: " + ip.ToString() & vbTab & vbTab & "MAC: " & MACtoString(mac)
                        CheckPp = True
                    End If

                    If Not PingS = String.Empty Then
                        AddLineText = AddLineText & vbTab & vbTab & "Ping: " & PingS
                    End If

                    If CheckPp = True Then
                        ThirteenTextBox1.Text += AddLineText & vbNewLine
                    End If

                    AddLineText = String.Empty
                    CheckPp = False
                End If

            Next

        Finally
            Marshal.FreeCoTaskMem(buffer)
            '  Marshal.FreeHGlobal(rowptr)
        End Try
    End Sub

    Private Sub BoosterButton1_Click(sender As Object, e As EventArgs) Handles BoosterButton1.Click
        ThirteenTextBox1.Text = ""
        Select Case AnimaExperimentalControlBox1.SelectedIndex
            Case 0
                ThirteenTextBox1.Text = AdapterReport()
            Case 1
                GetARPTablr()
            Case 2
                CmdScanner()
            Case 3
                ThirteenTextBox1.Text = GetNet()
         End Select
    End Sub

    Private Sub NetworkTimer_Tick(sender As Object, e As EventArgs) Handles NetworkTimer.Tick
        Select Case AnimaExperimentalControlBox1.SelectedIndex
            Case 0
                ControlsManaget(False)
            Case 1
                ControlsManaget(True)
            Case 2
                ControlsManaget(False)
            Case 3
                ControlsManaget(False)
        End Select
    End Sub

    Public Sub ControlsManaget(ByVal VisibleL As Boolean)
        Panel6.Visible = VisibleL
        Panel8.Visible = VisibleL
    End Sub

    Public Shared Function MACtoString(mac As PhysicalAddress, Optional Capital As Boolean = True) As String
        If Capital Then ' In capital Letters
            Return String.Join(":", (From z As Byte In mac.GetAddressBytes Select z.ToString("X2")).ToArray())
        Else
            Return String.Join(":", (From z As Byte In mac.GetAddressBytes Select z.ToString("x2")).ToArray())
        End If
    End Function

    Public Function GetNet() As String
        Dim DevicesC As Integer = 0
        Dim addlineText As String = String.Empty
        Dim Devices As ArrayList = ListNetworkComputers.NetworkBrowser.getNetworkComputers
        For Each ItemD In Devices
            addlineText += ItemD.ToString & vbNewLine
            DevicesC += 1
        Next
        addlineText += vbNewLine & vbNewLine & vbNewLine
        addlineText += "Totals Devices : " & DevicesC
        Return addlineText
    End Function

    Private Sub CmdScanner()
        Dim p As New Process
        With p.StartInfo
            .FileName = "arp"
            .Arguments = "-a"
            .UseShellExecute = False
            .RedirectStandardOutput = True
            .CreateNoWindow = True
        End With
        p.Start()
        ThirteenTextBox1.Text = p.StandardOutput.ReadToEnd
    End Sub

    Private Function AdapterReport() As String
        Dim addlineText As String = String.Empty
        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        For Each adapter In adapters
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
            addlineText += "Description: " & adapter.Description & vbNewLine
            addlineText += "DNS suffix: " & properties.DnsSuffix & vbNewLine
            addlineText += "DNS enabled: " & properties.IsDnsEnabled.ToString & vbNewLine
            addlineText += "Dynamically configured DNS: " & properties.IsDynamicDnsEnabled.ToString & vbNewLine
            addlineText += vbNewLine
        Next adapter
        Return addlineText
    End Function

#Region " Ping "

    ' [ Ping Function ]
    '
    ' Examples :
    ' MsgBox(Ping("www.google.com"))
    ' MsgBox(Ping("www.google.com", 500))
    ' MsgBox(Ping("www.google.com", 500, New Byte(128) {}, False))
    ' MsgBox(Ping("www.google.com", 500, System.Text.Encoding.ASCII.GetBytes("Hello"), True))
    ' For X As Int32 = 1 To 10 : If Not Ping("www.google.com", 1000) Then : MsgBox("Ping try " & X & " failed") : End If : Next : MsgBox("Ping successfully")

    Public Function Ping(ByVal Address As String, _
                           Optional ByVal TimeOut As Int64 = 200, _
                           Optional ByVal BufferData As Byte() = Nothing, _
                           Optional ByVal FragmentData As Boolean = False, _
                           Optional ByVal TimeToLive As Int64 = 128) As Boolean

        Dim PingSender As New System.Net.NetworkInformation.Ping()
        Dim PingOptions As New System.Net.NetworkInformation.PingOptions()

        If FragmentData Then PingOptions.DontFragment = False Else PingOptions.DontFragment = True
        If BufferData Is Nothing Then BufferData = New Byte(31) {} ' Sets a BufferSize of 32 Bytes
        PingOptions.Ttl = TimeToLive

        Dim Reply As System.Net.NetworkInformation.PingReply = PingSender.Send(Address, TimeOut, BufferData, PingOptions)

        If Reply.Status = System.Net.NetworkInformation.IPStatus.Success Then
            ' MsgBox("Address: " & Reply.Address.ToString)
            ' MsgBox("RoundTrip time: " & Reply.RoundtripTime)
            ' MsgBox("Time to live: " & Reply.Options.Ttl)
            ' MsgBox("Buffer size: " & Reply.Buffer.Length)
            Return True
        Else
            Return False
        End If

    End Function

#End Region

#Region " Help Section "

    Public Sub Help()

        Dim Help As String = <a><![CDATA[   
 
[+] Syntax:
 
    Program.exe [FILE] [SWITCHES]
 
[+] Switches:
 
    /Switch1   | Description.    (Default Value: X)
    /Switch2   | Description. 
    /? (or) -? | Show this help.
 
[+] Switch value Syntax:
 
    /Switch1   (ms)
    /Switch2   (X,Y)
 
[+] Usage examples:
 
    Program.exe "C:\File.txt" /Switch1
    (Short explanation)
 
]]></a>.Value

    End Sub

#End Region

#End Region

#Region " Notify Minimixe "

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Noticoicon.Visible = True
            Noticoicon.Text = "Strely Pro | Multi-Tools"
            Noticoicon.Icon = My.Resources.nexusae0_unnamed_15
            Noticoicon.ShowBalloonTip(10000, "Strely Pro", "Software version 1.3.0" + vbCrLf + "Herramienta para Mantenimiento de tu PC/Laptop", ToolTipIcon.None)
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub Noticoicon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Noticoicon.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Noticoicon.Visible = False
        Timer5.Enabled = True
    End Sub

#End Region

#Region " Ads "

    Dim client As New WebClient
    Dim WithEvents CLIEN As New WebClient
    Dim temp As String = Path.GetTempPath()

    Dim ADS As Boolean = False

    Public Sub IniciateAds()
        DownloadStringAsyc("https://www.dropbox.com/s/9pn3tfcr29l35h5/Ads.txt?dl=1")
        Try
            Dim pcb As PictureBox = Me.PictureBoxAds
            Dim gif As New GIF(My.Resources.ads1) '"C:\File.gif"

            Do Until gif.EndOfFrames ' Iterate frames until the end of frame count.
                If ADS = True Then
                    Exit Sub
                Else
                    ' Free previous Bitmap object.
                    If (pcb.Image IsNot Nothing) Then
                        pcb.Image.Dispose()
                        pcb.Image = Nothing
                    End If

                    pcb.Image = gif.NextFrame()
                    'Thread.Sleep(60) ' Simulate a FPS thingy.
                    Application.DoEvents()

                    If (gif.EndOfFrames) Then
                        ' Set active frame to 0 for infinite loop:
                        gif.ActiveFrameIndex = 0
                    End If
                End If
            Loop
        Catch ex As Exception
            Me.PictureBoxAds.Image = My.Resources.ads1 '"C:\File.gif"
        End Try
    End Sub

    Private Sub CLIEN_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles CLIEN.DownloadFileCompleted
        Me.PictureBoxAds.Image = System.Drawing.Image.FromFile(temp & "ads.jpg")
    End Sub

#Region " Funcs String "

    Private Sub DownloadStringAsyc(ByVal url As String)
        Dim WebClient = New WebClient
        AddHandler WebClient.DownloadStringCompleted, AddressOf webClient_DownloadStringCompleted
        WebClient.DownloadStringAsync(New Uri(url))
    End Sub

    Private Sub webClient_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            Dim Url As String = e.Result
            If Not Url = "none" Then
                ADS = True
                CLIEN.DownloadFileAsync(New Uri(Url), temp & "ads.jpg")
            End If
        Catch ex As Exception
            WriteLog(ex.Message, InfoType.Exception)
        End Try
    End Sub

#End Region

#End Region

#Region " Trash "

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove

    End Sub
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove

    End Sub
    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove

    End Sub
    Private Sub Label7_MouseMove(sender As Object, e As MouseEventArgs) Handles Label7.MouseMove

    End Sub

#End Region

#Region " Antivirus "

    Public GeneralResult As New List(Of String)

    Dim DetectionsCount As Integer = 0
    Dim Local_X As Integer = 20
    Dim Local_Y As Integer = 8

    '###########################################################

    Dim StartupResult As Boolean = False
    Dim RegeditResult As Boolean = False
    Dim AppDataResult As Boolean = False

    Dim CustomResult As Boolean = False

    Dim USBResult As Boolean = False

    Dim FinalizeAntivir As Boolean = False

    Dim Progress As Integer = 0

    Public Sub RestoreSett()
        CleanVirusPanel.Size = New Size(737, 0)
        StartupResult = False
        RegeditResult = False
        AppDataResult = False
        FinalizeAntivir = False
        GenerateListBool = False
        CustomResult = False
        USBResult = False
        Progress = 0
        DetectionsCount = 0
        Local_X = 20
        Local_Y = 8
        Progress1.Value = 0
        Progress2.Value = 0
        Progress3.Value = 0
        Progress4.Value = 0
        StatusLabel.Text = "Scanning..."
        Timestamp.Text = "Calculated..."
        PanelBoxVir.Controls.Clear()
        GeneralResult.Clear()
        StartupEngine.Clear()
        RegeditEngine.Clear()
        AppDataEngine.Clear()
        USBScannerEngine.Clear()
        CustomScannerEngine.Clear()
        Bouton1.Visible = False
        PanelBoxVir.Visible = False
    End Sub

    Private Sub AnimaButton1_Click(sender As Object, e As EventArgs) Handles AnimaButton1.Click
        RestoreSett()
        CleanVirusPanel.Size = New Size(737, 468)
        Label12.Text = "Quick Scan"
        TimerScan.Enabled = True
        Execution_Start()
        Dim tskAntivir As New Task(ScanAsyc, TaskCreationOptions.LongRunning)
        tskAntivir.Start()
    End Sub

    Public Filedir As String()

    Private Sub AnimaButton2_Click(sender As Object, e As EventArgs) Handles AnimaButton2.Click
        FilesFolderDialog.ShowDialog()
        Dim Dirty As String = FilesFolderDialog.SelectedPath
        If Not Dirty = "" Then
            Filedir = {Dirty}
            RestoreSett()
            CleanVirusPanel.Size = New Size(737, 468)
            Label12.Text = "Custom Scan"
            TimerScan.Enabled = True
            Execution_Start()
            Dim tskAntivir As New Task(ScanAsyc, TaskCreationOptions.LongRunning)
            tskAntivir.Start()
        End If
    End Sub

    Public Sub StartCustom()
        If VistaFolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Ahsa As String() = {VistaFolderBrowserDialog1.SelectedPath}
            Filedir = Ahsa
            RestoreSett()
            CleanVirusPanel.Size = New Size(737, 468)
            Label12.Text = "Custom Scan"
            TimerScan.Enabled = True
            Execution_Start()
            Dim tskAntivir As New Task(ScanAsyc, TaskCreationOptions.LongRunning)
            tskAntivir.Start()
        End If
    End Sub

    Public Function IsFolder(ByVal path As String) As Boolean
        Return ((File.GetAttributes(path) And FileAttributes.Directory) = FileAttributes.Directory)
    End Function

    Dim GenerateListBool As Boolean = False

    Private Sub TimerScan_Tick(sender As Object, e As EventArgs) Handles TimerScan.Tick
        Progress += 1
        If Label12.Text = "Quick Scan" Then

            If StartupResult = True Then

                If Not Progress1.Value = 100 Then
                    ' Progress += 1
                    Progress1.Value += 20
                Else
                    StatusLabel.Text = "Startup Scanned Successfully!"
                End If

            End If

            If RegeditResult = True Then
                If Not Progress2.Value = 100 Then
                    ' Progress += 1
                    Progress2.Value += 20
                Else
                    StatusLabel.Text = "Startup_Regedit Scanned Successfully!"
                End If
            End If

            If AppDataResult = True Then
                If Not Progress3.Value = 100 Then
                    ' Progress += 1
                    Progress3.Value += 20
                Else
                    StatusLabel.Text = "Misc Folders Scanned Successfully!"
                End If
            End If

            If FinalizeAntivir = True Then
                If GenerateListBool = False Then
                    GenericList()
                    GenerateListBool = True
                End If
            End If

            If Progress1.Value = 100 Then
                If Progress2.Value = 100 Then
                    If Progress3.Value = 100 Then
                        If Progress4.Value = 100 Then
                            StatusLabel.Text = "Number of threats found : " & PanelBoxVir.Controls.Count
                            Execution_End()
                            TimerScan.Enabled = False
                        Else
                            Progress4.Value += 10
                        End If

                    End If
                End If
            End If

        ElseIf Label12.Text = "Custom Scan" Then

            If CustomResult = True Then

                If Not Progress1.Value = 100 Then
                    ' Progress += 1
                    Progress1.Value += 20
                Else
                    StatusLabel.Text = "Reading Bytes()"
                End If

                If Not Progress2.Value = 100 Then
                    ' Progress += 1
                    Progress2.Value += 20
                Else
                    StatusLabel.Text = "Running Analysis Engine"
                End If

                If Not Progress3.Value = 100 Then
                    ' Progress += 1
                    Progress3.Value += 20
                Else
                    StatusLabel.Text = "Analyzing Files"
                End If

                If FinalizeAntivir = True Then
                    If GenerateListBool = False Then
                        GenericList()
                        GenerateListBool = True
                    End If
                End If
               

            End If

            ElseIf Label12.Text = "USB Scan" Then

            If USBResult = True Then

                If Not Progress1.Value = 100 Then
                    ' Progress += 1
                    Progress1.Value += 20
                Else
                    StatusLabel.Text = "Analyzing Files and Folders"
                End If

                If Not Progress2.Value = 100 Then
                    ' Progress += 1
                    Progress2.Value += 20
                Else
                    StatusLabel.Text = "Running Analysis Engine"
                End If

                If Not Progress3.Value = 100 Then
                    ' Progress += 1
                    Progress3.Value += 20
                Else
                    StatusLabel.Text = "Running Signature Detector."
                End If


                If FinalizeAntivir = True Then
                    If GenerateListBool = False Then
                        GenericList()
                        GenerateListBool = True
                    End If
                End If



            End If

                If Progress1.Value = 100 Then
                    If Progress2.Value = 100 Then
                        If Progress3.Value = 100 Then
                            If Progress4.Value = 100 Then
                                StatusLabel.Text = "Number of threats found : " & PanelBoxVir.Controls.Count
                                Execution_End()
                                TimerScan.Enabled = False
                            Else
                                Progress4.Value += 10
                            End If
                        End If
                    End If
                End If

        End If


    End Sub

    Public Sub GenericList()
        If GeneralResult.Count > 0 Then
            For Each Result As String In GeneralResult

                Dim VirusDescompositer As String() = Result.Split("|")
                Dim InfoImage As DetectionControl.InfoType
                If VirusDescompositer(2) = "H" Then
                    InfoImage = DetectionControl.InfoType.High
                ElseIf VirusDescompositer(2) = "M" Then
                    InfoImage = DetectionControl.InfoType.Medium
                ElseIf VirusDescompositer(2) = "N" Then
                    InfoImage = DetectionControl.InfoType.None
                End If
                AddtoPanelBox(VirusDescompositer(0), "File : " & Path.GetFileName(VirusDescompositer(0)), VirusDescompositer(1), InfoImage)
            Next
            PanelBoxVir.Visible = True
            Bouton1.Visible = True
        Else
            StatusLabel.Text = "No Threats Found."
        End If
    End Sub

    Dim ScanAsyc As New Action(
   Sub()
       Try
           If Label12.Text = "Quick Scan" Then
               StartupResult = StartupAnalize()
               If StartupResult = True Then
                   If StartupEngine.Count > 0 Then
                       For Each Result As String In StartupEngine
                           GeneralResult.Add(Result)
                       Next
                   End If
               End If

               RegeditResult = RegeditAnalize()
               If RegeditResult = True Then
                   If RegeditEngine.Count > 0 Then
                       For Each Result As String In RegeditEngine
                           GeneralResult.Add(Result)
                       Next
                   End If
               End If

               AppDataResult = AppDataAnalize()
               If AppDataResult = True Then
                   If AppDataEngine.Count > 0 Then
                       For Each Result As String In AppDataEngine
                           GeneralResult.Add(Result)
                       Next
                   End If
               End If

               FinalizeAntivir = True

           ElseIf Label12.Text = "Custom Scan" Then

               CustomResult = CustomScannerStart(Filedir, SearchOption.AllDirectories)

               If CustomResult = True Then
                   If CustomScannerEngine.Count > 0 Then

                       For Each Result As String In CustomScannerEngine
                           GeneralResult.Add(Result)
                       Next
                   End If
               End If

               FinalizeAntivir = True

           ElseIf Label12.Text = "USB Scan" Then

               USBResult = USBScannerStart(Filedir(0))

               If USBResult = True Then
                   If USBScannerEngine.Count > 0 Then

                       For Each Result As String In USBScannerEngine
                           GeneralResult.Add(Result)
                       Next
                   End If
               End If

               FinalizeAntivir = True

           End If

       Catch ex As Exception
           WriteLog(ex.Message, InfoType.Exception)
       End Try
   End Sub)

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        RestoreSett()
    End Sub

    Public Sub AddtoPanelBox(ByVal Dir As String, ByVal Name As String, ByVal SigNature As String, ByVal Risk As DetectionControl.InfoType)
        Dim ControlA As DetectionControl = New DetectionControl
        PanelBoxVir.Controls.Add(ControlA)
        PanelBoxVir.AutoScroll = True
        PanelBoxVir.VerticalScroll.Visible = True
        'ControlA.Size = New Size(571, 25)

        ControlA.Anchor = (AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top)

        ControlA.VirusDir = Dir
        ControlA.VirusName = Name
        ControlA.VirSignature = SigNature
        ControlA.VirInfoType = Risk

        ControlA.Location = New Point(Local_X, Local_Y)
        Local_Y += 30
        DetectionsCount += 1

    End Sub

#Region " Startup Folder "

    Public StartupEngine As New List(Of String)

    Public Function StartupAnalize() As Boolean
        Dim StartupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

        Dim files As IEnumerable(Of FileInfo) = FileDirSearcher.GetFiles(dirPath:=StartupFolder,
                                                                 searchOption:=SearchOption.TopDirectoryOnly,
                                                                 fileNamePatterns:={"*"},
                                                                 fileExtPatterns:={"*.*"},
                                                                 ignoreCase:=True,
                                                                 throwOnError:=True)
        For Each File In files
            Dim FileP As String = File.FullName
            Dim CheckAssem As Boolean = IsNetAssembly(FileP)
            Dim FormatFile As String = Path.GetExtension(FileP)

            If FormatFile = ".lnk" Then
                Dim FileLink As String = GetLnkTarget(FileP)
                Dim SharePartion As String() = FileLink.Split("|")
                Dim CompleteFile As String = SharePartion(0)
                Dim ExeFileP As String = Path.GetFileName(CompleteFile)

                If ExeFileP = "cmd.exe" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")

                ElseIf ExeFileP = "wscript.exe" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                ElseIf Path.GetExtension(ExeFileP) = ".cmd" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                    StartupEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
                ElseIf Path.GetExtension(ExeFileP) = ".bat" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                    StartupEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
                ElseIf Path.GetExtension(ExeFileP) = ".vbs" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                    StartupEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
                ElseIf Path.GetExtension(ExeFileP) = ".js" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.JS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                    StartupEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Virus, Platforms.JS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                ElseIf Path.GetExtension(ExeFileP) = ".wsf" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                    StartupEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                ElseIf Path.GetExtension(ExeFileP) = ".ps1" Then
                    StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.SH, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                    StartupEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Virus, Platforms.SH, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

                ElseIf IsNetAssembly(SharePartion(0)) = True Then
                    Dim scan As Boolean = NetScan(SharePartion(0))
                    If scan = True Then
                        StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "H")
                        ' StartupEngine.Add(SharePartion(0) & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.Unde, Suffixes.gen) & "|" & "H")

                        Dim DetectFamily As String = String.Empty
                        If Not NetAnalysis.Detection1 = String.Empty Then
                            DetectFamily = NetAnalysis.Detection1
                        ElseIf Not NetAnalysis.Detection2 = String.Empty Then
                            DetectFamily = NetAnalysis.Detection2
                        End If

                        If DetectFamily = String.Empty Then
                            StartupEngine.Add(SharePartion(0) & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                        Else
                            StartupEngine.Add(SharePartion(0) & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen, DetectFamily) & "|" & "H")
                        End If

                    End If
                End If

            ElseIf FormatFile = ".cmd" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
            ElseIf FormatFile = ".bat" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
            ElseIf FormatFile = ".vbs" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
            ElseIf FormatFile = ".js" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.JS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
            ElseIf FormatFile = ".wsf" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
            ElseIf FormatFile = ".ps1" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.SH, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
            ElseIf FormatFile = ".hta" Then
                StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.HTA, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

            Else

                If CheckAssem = True Then
                    Dim scan As Boolean = NetScan(FileP)
                    If scan = True Then
                        Dim DetectFamily As String = String.Empty
                        If Not NetAnalysis.Detection1 = String.Empty Then
                            DetectFamily = NetAnalysis.Detection1
                        ElseIf Not NetAnalysis.Detection2 = String.Empty Then
                            DetectFamily = NetAnalysis.Detection2
                        End If

                        If DetectFamily = String.Empty Then
                            StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                        Else
                            StartupEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen, DetectFamily) & "|" & "H")
                        End If
                    End If
                End If

            End If
        Next

        Return True
    End Function

#End Region

#Region " Regedit "

    Public RegeditEngine As New List(Of String)

    Public Function RegeditAnalize() As Boolean
        On Error Resume Next
        Dim RegeditRootStartupDir As New List(Of String)
        RegeditRootStartupDir.AddRange({"HKCU", "HKLM"})

        Dim RegeditStartupDir As New List(Of String)
        RegeditStartupDir.AddRange({"Software\Microsoft\Windows\CurrentVersion\Run\", _
                                    "Software\Microsoft\Windows\CurrentVersion\RunOnce\", _
                                    "Software\Microsoft\Windows\CurrentVersion\RunServices\", _
                                    "Software\Microsoft\Windows\CurrentVersion\RunServicesOnce\", _
                                    "Software\Microsoft\Windows NT\CurrentVersion\Windows\"})


        Dim ScriptEnterpeter As New List(Of String)
        ScriptEnterpeter.AddRange({"wscript", "cmd", "powershell"})

        For Each RootKey As String In RegeditRootStartupDir

            For Each subKey As String In RegeditStartupDir

                For Each ExeLoaderScript As String In ScriptEnterpeter

                    Dim regInfoValueDataCol As IEnumerable(Of RegEdit.Reginfo) =
   RegEdit.FindValueData(rootKeyName:=RootKey,
                                 subKeyPath:=subKey,
                                 valueData:=ExeLoaderScript,
                                 matchFullData:=False,
                                 ignoreCase:=True,
                                 searchOption:=IO.SearchOption.TopDirectoryOnly)

                    For Each reg As RegEdit.RegInfo In regInfoValueDataCol

                        Dim ExePath As String = GetPath(reg.ValueData.ToString)

                        If Not LCase(ExePath) = LCase(GetSystemPath()) Then
                            Dim DirRkey As String = reg.RootKeyName & "\" & reg.SubKeyPath & "\" & reg.ValueName
                            If Not reg.ValueData.ToString.Contains("pif") Then
                                If Not DirRkey = "" Then
                                    RegeditEngine.Add(DirRkey & "|" & GenerateFormat(Type.Virus, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.remnants) & "|" & "M")
                                    RegeditEngine = RegeditEngine.Distinct.ToList
                                End If
                            End If
                        End If
                    Next reg
                Next
            Next
        Next

        Return True
    End Function

#End Region

#Region " AppData Folder "

    Public AppDataEngine As New List(Of String)

    Public Function AppDataAnalize() As Boolean
        Dim AppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

        Dim files As IEnumerable(Of FileInfo) = FileDirSearcher.GetFiles(dirPath:=AppDataFolder,
                                                                 searchOption:=SearchOption.TopDirectoryOnly,
                                                                 fileNamePatterns:={"*"},
                                                                 fileExtPatterns:={"*.bat", "*.cmd", "*.vbs", "*.wsf", "*.ps1", "*.js", "*.hta", "*.exe"},
                                                                 ignoreCase:=True,
                                                                 throwOnError:=True)
        For Each File In files
            Dim FileP As String = File.FullName
            Dim Extension As String = LCase(Path.GetExtension(FileP))

            If Not LCase(FileP).Contains("minecraft") Then

                Select Case Extension
                    Case ".exe" : GoTo EXE
                    Case ".vbs" : GoTo VBS
                    Case ".wsf" : GoTo VBS
                    Case ".bat" : GoTo BAT
                    Case ".cmd" : GoTo BAT
                    Case ".js" : GoTo JS
                    Case ".ps1" : GoTo JS
                    Case ".hta" : GoTo HTA
                End Select

                Return False

EXE:
                If IsNetAssembly(FileP) = True Then
                    Dim scan As Boolean = NetScan(FileP)
                    If scan = True Then
                        Dim DetectFamily As String = String.Empty
                        If Not NetAnalysis.Detection1 = String.Empty Then
                            DetectFamily = NetAnalysis.Detection1
                        ElseIf Not NetAnalysis.Detection2 = String.Empty Then
                            DetectFamily = NetAnalysis.Detection2
                        End If

                        If DetectFamily = String.Empty Then
                            AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                        Else
                            AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen, DetectFamily) & "|" & "H")
                        End If
                    End If
                End If

                GoTo NextFile

VBS:
                AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

                GoTo NextFile
BAT:
                AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

                GoTo NextFile
JS:
                AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.JS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

                GoTo NextFile
PS1:
                AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.SH, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

                GoTo NextFile
HTA:
                AppDataEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.HTA, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

                GoTo NextFile
            End If

NextFile:

        Next

        Return True

    End Function

#End Region

#Region " Functions "

    Public Function GetLnkTarget(ByVal lnkPath As String) As String
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(lnkPath)
        Return Shortcut.TargetPath.ToString & "|" & Shortcut.Arguments
    End Function


    Public Function KillProcess(ByVal Proc As String) As Boolean
        Dim ProcCount As Integer = 0

        For Each process As Process In process.GetProcessesByName(Proc)
            process.Kill()
            ProcCount += 1
        Next

        If ProcCount > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function GetFileAssociation(ByVal ext As String) As String
        Try
            Dim RegKey As Microsoft.Win32.RegistryKey
            RegKey = My.Computer.Registry.ClassesRoot.OpenSubKey(ext, False)
            If RegKey Is Nothing Then Return "-1"
            RegKey = My.Computer.Registry.ClassesRoot.OpenSubKey(RegKey.GetValue(Nothing).ToString & "\shell\open\command")
            Dim result As String = RegKey.GetValue(Nothing).ToString
            Dim exefile As String = Split(result, ".exe")(0) & ".exe"
            Return exefile
        Catch ex As Exception
            Return "-1"
        End Try
    End Function

    Public Function GenerateRegeditFormat(ByVal Str As String(), ByVal reformed As String) As String
        Str(0) = reformed
        Dim value As String = String.Join("\", Str)
        Return Path.GetDirectoryName(value)
    End Function

#Region " Code Execution Time "

    ' [ Code Execution Time ]
    '
    ' Examples :
    ' Execution_Start() : Threading.Thread.Sleep(500) : Execution_End()

    Dim Execution_Watcher As New Stopwatch

    Private Sub Execution_Start()
        If Execution_Watcher.IsRunning Then Execution_Watcher.Restart()
        Execution_Watcher.Start()
    End Sub

    Private Sub Execution_End()
        If Execution_Watcher.IsRunning Then
            Timestamp.Text = Execution_Watcher.Elapsed.Hours & "h" & _
                            ":" & Execution_Watcher.Elapsed.Minutes & "m" & _
                            ":" & Execution_Watcher.Elapsed.Seconds & "s" & _
                            ":" & Execution_Watcher.Elapsed.Milliseconds & "ms"
            Execution_Watcher.Reset()
        Else


        End If
    End Sub

    Private Sub Execution_End1()
        If Execution_Watcher.IsRunning Then
            MessageBox.Show("Execution watcher finished:" & vbNewLine & vbNewLine & _
                            "[H:M:S:MS]" & vbNewLine & _
                            Execution_Watcher.Elapsed.Hours & _
                            ":" & Execution_Watcher.Elapsed.Minutes & _
                            ":" & Execution_Watcher.Elapsed.Seconds & _
                            ":" & Execution_Watcher.Elapsed.Milliseconds & _
                            vbNewLine & _
                            vbNewLine & _
                            "Total H: " & Execution_Watcher.Elapsed.TotalHours & vbNewLine & vbNewLine & _
                            "Total M: " & Execution_Watcher.Elapsed.TotalMinutes & vbNewLine & vbNewLine & _
                            "Total S: " & Execution_Watcher.Elapsed.TotalSeconds & vbNewLine & vbNewLine & _
                            "Total MS: " & Execution_Watcher.ElapsedMilliseconds & vbNewLine, _
                            "Code execution time", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information, _
                            MessageBoxDefaultButton.Button1)
            Execution_Watcher.Reset()
        Else
            MessageBox.Show("Execution watcher never started.", _
                            "Code execution time", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error, _
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub

#End Region

#End Region

#End Region

#Region " QuikScanner "

    Private Sub Bouton1_Click(sender As Object, e As EventArgs) Handles Bouton1.Click
        Try
            If Label12.Text = "Quick Scan" Then
                Dim CleanResult As Boolean = CleanAntivir()
            ElseIf Label12.Text = "Custom Scan" Then
                Dim CleanResult As Boolean = CleanCustomAntivir()
            ElseIf Label12.Text = "USB Scan" Then
                Dim CleanResult As Boolean = CleanCustomAntivir()
            End If
        Catch ex As Exception
            WriteLog(ex.Message, InfoType.Exception)
        End Try
    End Sub


    Public Function CleanCustomAntivir() As Boolean
        Dim Process_List As New List(Of String)

        Process_List.AddRange({"cmd", "wscript", "powershell"})

        For Each Process_Item As String In Process_List
            Dim Kp As Boolean = KillProcess(Process_Item)
        Next

        For Each childControl In PanelBoxVir.Controls
            Dim controlnumber As Integer = 0
            If TypeOf childControl Is DetectionControl Then
                Dim DeleteCheck As Boolean = childControl.DeleteCheckbox()
                Dim VirDir As String = childControl.VirPath()

                If DeleteCheck = True Then
                    ' PanelBoxVir.Controls.RemoveAt(controlnumber)
                    childControl.VisibleC = False
                    Dim ProcessVir As String = Path.GetFileName(VirDir)

                    If My.Computer.FileSystem.FileExists(VirDir) = True Then
                        Dim Kp As Boolean = KillProcess(ProcessVir)
                        My.Computer.FileSystem.DeleteFile(VirDir)
                    End If

                End If

            End If

            controlnumber += 1
        Next

        Return True
    End Function

    Public Function CleanAntivir() As Boolean
        On Error Resume Next

        Dim Process_List As New List(Of String)

        Process_List.AddRange({"cmd", "wscript", "powershell"})

        For Each Process_Item As String In Process_List
            Dim Kp As Boolean = KillProcess(Process_Item)
        Next


        For Each childControl In PanelBoxVir.Controls
            Dim controlnumber As Integer = 0
            If TypeOf childControl Is DetectionControl Then
                Dim DeleteCheck As Boolean = childControl.DeleteCheckbox()
                Dim VirDir As String = childControl.VirPath()
                If DeleteCheck = True Then
                    Dim AnalicePath As String() = VirDir.Split("\")
                    Dim Fname As String = Path.GetFileName(VirDir)
                    childControl.VisibleC = False
                    'antes
                    'If AnalicePath(0) = "HKEY_CURRENT_USER" Then
                    'GoTo RegeditHKCU
                    'ElseIf AnalicePath(0) = "HKEY_LOCAL_MACHINE" Then
                    '     GoTo RegeditHKLM
                    'End If

                    'Ahora

                    Select Case AnalicePath(0)
                        Case "HKEY_CURRENT_USER" : GoTo RegeditHKCU
                        Case "HKEY_LOCAL_MACHINE" : GoTo RegeditHKLM
                        Case Else
                            GoTo File
                    End Select

File:
                    Dim Extension As String = Path.GetExtension(Fname)
                    If Extension = ".exe" Then
                        KillProcess(Fname)
                    Else
                        Dim GetProgram As String() = GetFileAssociation(Extension).Split(" ")
                        If Not GetProgram(0) = "-1" Then
                            KillProcess(Path.GetFileNameWithoutExtension(GetProgram(0)))
                        End If
                    End If

                    If My.Computer.FileSystem.FileExists(VirDir) = True Then
                        My.Computer.FileSystem.DeleteFile(VirDir)
                    End If

                    GoTo Jump

RegeditHKCU:

                    RegEdit.DeleteValue(fullKeyPath:=GenerateRegeditFormat(AnalicePath, "HKCU"),
                                        valueName:=Fname,
                                        throwOnMissingValue:=True)
                    GoTo Jump
RegeditHKLM:
                    RegEdit.DeleteValue(fullKeyPath:=GenerateRegeditFormat(AnalicePath, "HKLM"),
                                        valueName:=Fname,
                                        throwOnMissingValue:=True)

                    GoTo Jump
Jump:

                    ' PanelBoxVir.Controls.RemoveAt(controlnumber)
                    ' controlnumber += 1
                End If
            End If
        Next

        Return True
    End Function


#End Region

#Region " CustomScanner "

    Public CustomScannerEngine As New List(Of String)

    Public Function CustomScannerStart(ByVal Filedir As String(), ByVal SOption As SearchOption) As Boolean
        If Filedir.Count > 0 Then

            For Each FileorFolder As String In Filedir
                Dim Check As Boolean = IsFolder(FileorFolder)

                If Check = True Then

                    Dim files As IEnumerable(Of FileInfo) = FileDirSearcher.GetFiles(dirPath:=FileorFolder,
                                                                         searchOption:=SearchOption.AllDirectories,
                                                                         fileNamePatterns:={"*"},
                                                                         fileExtPatterns:={"*.bat", "*.cmd", "*.vbs", "*.wsf", "*.ps1", "*.js", "*.hta", "*.exe"},
                                                                         ignoreCase:=True,
                                                                         throwOnError:=True)

                    For Each File In files
                        Dim FileP As String = File.FullName
                        Dim ScanFiles As Boolean = CustomScannerAnalize(FileP)

                    Next


                Else

                    Dim ScanFile As Boolean = CustomScannerAnalize(FileorFolder)

                End If

            Next
            Return True
        End If
        Return False
    End Function

    Public Function CustomScannerAnalize(ByVal DirPath As String) As Boolean

        Dim FileP As String = DirPath 'File.FullName

        Dim Extension As String = LCase(Path.GetExtension(FileP))

        Select Case Extension
            Case ".exe" : GoTo EXE
            Case ".vbs" : GoTo VBS
            Case ".wsf" : GoTo VBS
            Case ".bat" : GoTo BAT
            Case ".cmd" : GoTo BAT
            Case ".js" : GoTo JS
            Case ".ps1" : GoTo JS
            Case ".hta" : GoTo HTA
        End Select

        Return False


EXE:
        If IsNetAssembly(FileP) = True Then
            Dim scan As Boolean = NetScan(FileP)
            If scan = True Then
                Dim DetectFamily As String = String.Empty
                If Not NetAnalysis.Detection1 = String.Empty Then
                    DetectFamily = NetAnalysis.Detection1
                ElseIf Not NetAnalysis.Detection2 = String.Empty Then
                    DetectFamily = NetAnalysis.Detection2
                End If

                If DetectFamily = String.Empty Then
                    CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                Else
                    CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen, DetectFamily) & "|" & "H")
                End If
            End If
        End If

        GoTo NextFile

VBS:
        CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
BAT:
        CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
JS:
        CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.JS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
PS1:
        CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.SH, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
HTA:
        CustomScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.HTA, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile


NextFile:

        Return True
    End Function

#End Region

#Region " USB Scan "

    Public USBScannerEngine As New List(Of String)

    Public Function USBScannerStart(ByVal Filedir As String) As Boolean
        On Error Resume Next

        Dim Process_List As New List(Of String)

        Process_List.AddRange({"cmd", "wscript", "powershell"})

        For Each Process_Item As String In Process_List
            Dim Kp As Boolean = KillProcess(Process_Item)
        Next

        Dim dirs As IEnumerable(Of DirectoryInfo) = FileDirSearcher.GetDirs(dirPath:=Filedir,
                                                                    searchOption:=SearchOption.AllDirectories)
        For Each Folder In dirs
            Dim FolderP As String = Folder.FullName
            Dim folderName As String = Folder.Name
            If Not folderName = "System Volume Information" Then
                If (IO.File.GetAttributes(FolderP) And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then
                    IO.File.SetAttributes(FolderP, IO.FileAttributes.Normal)
                End If
            End If
        Next

        Dim files As IEnumerable(Of FileInfo) = FileDirSearcher.GetFiles(dirPath:=Filedir,
                                                             searchOption:=SearchOption.AllDirectories)


        For Each File In files

            Dim FileP As String = File.FullName

            If (IO.File.GetAttributes(FileP) And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then
                Attrib(FileP, FileAttributes.Normal)
            End If

            Dim ScanFiles As Boolean = UsbScanner(FileP)

        Next

        Return True

    End Function

    Public Function UsbScanner(ByVal DirPath As String) As Boolean
        On Error Resume Next
        Dim FileP As String = DirPath

        Dim Extension As String = LCase(Path.GetExtension(FileP))

        Select Case Extension
            Case ".exe" : GoTo EXE
            Case ".vbs" : GoTo VBS
            Case ".wsf" : GoTo VBS
            Case ".bat" : GoTo BAT
            Case ".cmd" : GoTo BAT
            Case ".js" : GoTo JS
            Case ".ps1" : GoTo JS
            Case ".hta" : GoTo HTA
            Case ".lnk" : GoTo LNKUSB
            Case Else
                GoTo NextFile
        End Select

        Return False

LNKUSB:

        Dim FileLink As String = GetLnkTarget(FileP)
        Dim SharePartion As String() = FileLink.Split("|")
        Dim CompleteFile As String = SharePartion(0)
        Dim ExeFileP As String = Path.GetFileName(CompleteFile)

        If ExeFileP = "cmd.exe" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.Win, Family.NewPhotoDay, VariantL.D, Suffixes.lnk) & "|" & "M")
        ElseIf ExeFileP = "wscript.exe" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.Win, Family.NewPhotoDay, VariantL.D, Suffixes.lnk) & "|" & "M")
        ElseIf Path.GetExtension(ExeFileP) = ".cmd" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.Win, Family.NewPhotoDay, VariantL.D, Suffixes.lnk) & "|" & "M")
            USBScannerEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
        ElseIf Path.GetExtension(ExeFileP) = ".bat" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "M")
            USBScannerEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
        ElseIf Path.GetExtension(ExeFileP) = ".vbs" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "M")
            USBScannerEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
        ElseIf Path.GetExtension(ExeFileP) = ".js" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.JS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "M")
            USBScannerEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Virus, Platforms.JS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
        ElseIf Path.GetExtension(ExeFileP) = ".wsf" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "M")
            USBScannerEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Virus, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")
        ElseIf Path.GetExtension(ExeFileP) = ".ps1" Then
            USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.SH, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "M")
            USBScannerEngine.Add(CompleteFile & "|" & GenerateFormat(Type.Virus, Platforms.SH, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "M")

        ElseIf IsNetAssembly(SharePartion(0)) = True Then
            Dim scan As Boolean = NetScan(SharePartion(0))
            If scan = True Then
                USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.lnk) & "|" & "M")

                Dim DetectFamily As String = String.Empty
                If Not NetAnalysis.Detection1 = String.Empty Then
                    DetectFamily = NetAnalysis.Detection1
                ElseIf Not NetAnalysis.Detection2 = String.Empty Then
                    DetectFamily = NetAnalysis.Detection2
                End If

                If DetectFamily = String.Empty Then
                    USBScannerEngine.Add(SharePartion(0) & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                Else
                    USBScannerEngine.Add(SharePartion(0) & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen, DetectFamily) & "|" & "H")
                End If
            End If
        End If

EXE:
        If IsNetAssembly(FileP) = True Then
            Dim scan As Boolean = NetScan(FileP)
            If scan = True Then
                Dim DetectFamily As String = String.Empty
                If Not NetAnalysis.Detection1 = String.Empty Then
                    DetectFamily = NetAnalysis.Detection1
                ElseIf Not NetAnalysis.Detection2 = String.Empty Then
                    DetectFamily = NetAnalysis.Detection2
                End If

                If DetectFamily = String.Empty Then
                    USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")
                Else
                    USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Virus, Platforms.Win32, Family.Inde, VariantL.U, Suffixes.gen, DetectFamily) & "|" & "H")
                End If
            End If
        End If

        GoTo NextFile

VBS:
        USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.VBS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
BAT:
        USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.WinBAT, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
JS:
        USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.JS, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
PS1:
        USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.SH, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile
HTA:
        USBScannerEngine.Add(FileP & "|" & GenerateFormat(Type.Suspect, Platforms.HTA, Family.Inde, VariantL.U, Suffixes.gen) & "|" & "H")

        GoTo NextFile

NextFile:

        Return True
    End Function

    Private Function Attrib(ByVal File As String, ByVal Attributes As System.IO.FileAttributes)
        If IO.File.Exists(File) Then
            Try
                FileSystem.SetAttr(File, Attributes)
                Return True ' File was modified OK
            Catch ex As Exception
                ' MsgBox(ex.Message)
                Return False ' File can't be modified maybe because User Permissions
            End Try
        Else
            Return Nothing ' File doesn't exist
        End If
    End Function

    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click
        USBDialog.ShowDialog()
        Dim Dirty As String = USBDialog.SelectedPath
        If Not Dirty = "" Then
            Filedir = {Dirty}
            RestoreSett()
            CleanVirusPanel.Size = New Size(737, 468)
            Label12.Text = "USB Scan"
            TimerScan.Enabled = True
            Execution_Start()
            Dim tskAntivir As New Task(ScanAsyc, TaskCreationOptions.LongRunning)
            tskAntivir.Start()
        End If
    End Sub

#End Region

#Region " Antivir Contextmenu "

    Private Sub SelectALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectALLToolStripMenuItem.Click
        SelectALL()
    End Sub

    Private Sub OpenInFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInFolderToolStripMenuItem.Click
        OpenThread()
    End Sub

    Public Sub SelectALL()
        For Each childControl In PanelBoxVir.Controls
            Dim controlnumber As Integer = 0
            If TypeOf childControl Is DetectionControl Then
                childControl.CheckedBox() = True
            End If
        Next
    End Sub

    Public Sub OpenThread()
        For Each childControl In PanelBoxVir.Controls
            Dim controlnumber As Integer = 0
            If TypeOf childControl Is DetectionControl Then
                If childControl.CheckedBox() = True Then
                    Dim DirPath As String = childControl.VirusDir()
                    If (IO.File.GetAttributes(DirPath) And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then
                        Attrib(DirPath, FileAttributes.Normal)
                    End If
                    ExploreFile(DirPath)
                End If
            End If
        Next
    End Sub

#End Region

#Region " About "

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/sharer/sharer.php?u=http%3A%2F%2Ftoolslib.net%2Fdownloads%2Fviewdownload%2F548-strely%2F")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        System.Diagnostics.Process.Start("https://twitter.com/intent/tweet?text=http%3A%2F%2Ftoolslib.net%2Fdownloads%2Fviewdownload%2F548-strely%2F")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        System.Diagnostics.Process.Start("https://plus.google.com/share?url=http%3A%2F%2Ftoolslib.net%2Fdownloads%2Fviewdownload%2F548-strely%2F")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        System.Diagnostics.Process.Start("https://www.paypal.me/SalvadorKrilewski")
    End Sub

#End Region


End Class


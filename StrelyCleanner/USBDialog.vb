Imports System.IO

Public Class USBDialog

    Dim _FileDir As String = String.Empty

    Private Sub USBDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Form1.CenterForm(Me, Me.Location)
        BoosterComboBox1.Items.Clear()
        StartUSB()
    End Sub

    Public Sub StartUSB()
        On Error Resume Next
        Dim ListA As String()
        For Each USBorHdd In Environment.GetLogicalDrives
            'check if drive can be used
            If New DriveInfo(USBorHdd).IsReady = True Then
                'we wont scan cd/dvd as most of them are Readonly
                If Not New DriveInfo(USBorHdd).DriveType = DriveType.CDRom Then

                    Dim DriveLabel As String = USBorHdd + New DriveInfo(USBorHdd).VolumeLabel
                   
                    If DetectDevice(DriveLabel) = True Then
                         BoosterComboBox1.Items.Add(DriveLabel)
                    End If

                End If
            End If
        Next

        If BoosterComboBox1.Items.Count > 0 Then
            BoosterComboBox1.SelectedItem = BoosterComboBox1.Items.Item(0)
        End If

    End Sub

    Public Shared Function DetectDevice(ByVal DeviceName As String) As Boolean
        Try
            ' See if the desired device shows up in the device manager.'
            Dim info As Management.ManagementObject
            Dim search As System.Management.ManagementObjectSearcher
            Dim Name As String
            search = New System.Management.ManagementObjectSearcher("SELECT * From Win32_PnPEntity")
            For Each info In search.Get()
                ' Go through each device detected.'
                Name = CType(info("Caption"), String) ' Get the name of the device.'
                If InStr(Name, DeviceName, CompareMethod.Text) > 0 Then
                    Return True
                End If
            Next
        Catch ex As Exception
        End Try
        'We did not find the device we were looking for'
        Return False
    End Function

    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click
        _FileDir = BoosterComboBox1.SelectedItem.ToString
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ThirteenButton2_Click(sender As Object, e As EventArgs) Handles ThirteenButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public ReadOnly Property SelectedPath As String
        Get
            Return _FileDir
        End Get
    End Property


End Class
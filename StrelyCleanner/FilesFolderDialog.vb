Public Class FilesFolderDialog

    Dim _FileDir As String = String.Empty

    Private Sub FilesFolderDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Form1.centerForm(Me, Me.Location)
        _FileDir = String.Empty
    End Sub

    Private Sub FilesFolderDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BoosterComboBox1.SelectedItem = BoosterComboBox1.Items.Item(0)
        BoosterComboBox2.SelectedItem = BoosterComboBox2.Items.Item(0)
    End Sub

    Private Sub XylosButton1_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim ShowR As String = BoosterComboBox1.SelectedItem.ToString

        If ShowR = "Folder(s)" Then
            If VistaFolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                _FileDir = VistaFolderBrowserDialog1.SelectedPath
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        ElseIf ShowR = "File(s)" Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                _FileDir = OpenFileDialog1.FileName
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Function Getoption() As System.IO.SearchOption
        Dim ShowR As String = BoosterComboBox1.SelectedItem.ToString
        If ShowR = "TopDirectoryOnly" Then
            Return IO.SearchOption.TopDirectoryOnly
        ElseIf ShowR = "AllDirectories" Then
            Return IO.SearchOption.AllDirectories
        End If
    End Function

    Private Sub XylosButton2_Click(sender As Object, e As EventArgs) Handles XylosButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public ReadOnly Property SelectedPath As String
        Get
            Return _FileDir
        End Get
    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ShowR As String = BoosterComboBox1.SelectedItem.ToString
        If ShowR = "File(s)" Then
            Me.Size = New Size(225, 78)
            BoosterComboBox2.Visible = False
            Label2.Visible = False
        ElseIf ShowR = "Folder(s)" Then
            Me.Size = New Size(225, 119)
            BoosterComboBox2.Visible = True
            Label2.Visible = True
        End If
    End Sub

End Class
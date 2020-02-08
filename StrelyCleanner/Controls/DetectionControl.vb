Public Class DetectionControl

#Region " Properties "

    Private _VirusDir As String = String.Empty
    Public Property VirusDir() As String
        Get
            Return _VirusDir
        End Get
        Set(ByVal value As String)
            _VirusDir = value
        End Set
    End Property

    Private _VirusName As String = String.Empty
    Public Property VirusName() As String
        Get
            Return _VirusName
        End Get
        Set(ByVal value As String)
            _VirusName = value
        End Set
    End Property

    Private _VirSignature As String = String.Empty
    Public Property VirSignature() As String
        Get
            Return _VirSignature
        End Get
        Set(ByVal value As String)
            _VirSignature = value
        End Set
    End Property

    Public Enum InfoType
        High
        Medium
        None
    End Enum

    Private _VirInfoType As InfoType
    Public Property VirInfoType() As InfoType
        Get
            Return _VirInfoType
        End Get
        Set(ByVal value As InfoType)
            _VirInfoType = value
        End Set
    End Property

    Public Function VirusDelete() As Boolean
        Return ThirteenCheckBox1.Checked
    End Function

#End Region

#Region " Funcs "

    Public Function DeleteCheckbox() As Boolean
        Return ThirteenCheckBox1.Checked
    End Function

    Public Function VirPath() As String
        Return DirLabel.Text
    End Function

#End Region

    Private Sub DetectionControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        DirLabel.Text = _VirusDir
        Namelbl.Text = _VirusName
        Siglbl.Text = _VirSignature

       
        ForceControlBLock()
    End Sub

    Private Sub ForceControlBLock()
        Me.Size = New Size(571, 25)
        ThirteenCheckBox1.Size = New Size(18, 17)
        ThirteenCheckBox1.Location = New Point(3, 4)
        Panel1.Size = New Size(543, 21)
        Panel1.Location = New Point(27, 2)
        Namelbl.Size = New Size(35, 13)
        Namelbl.Location = New Point(3, 0)
        Siglbl.Size = New Size(52, 13)
        Siglbl.Location = New Point(200, 0)
        ' PictureBox1.Size = New Size(101, 17)
        ' PictureBox1.Location = New Point(437, 2)
        Namelbl.Font = New Font("Microsoft Sans Serif", 9)
        Siglbl.Font = New Font("Microsoft Sans Serif", 9, _
                   FontStyle.Bold)

    End Sub

    Dim CargaC As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not _VirusDir = "" Then
            If DirLabel.Text = "" Then
                DirLabel.Text = _VirusDir
                CargaC += 1
            End If
        End If
        If Not _VirusName = "" Then
            If Namelbl.Text = "" Then
                Namelbl.Text = _VirSignature
                CargaC += 1
            End If
        End If
        If Not _VirSignature = "" Then
            If Siglbl.Text = "" Then
                Siglbl.Text = _VirusName
                CargaC += 1
            End If
        End If
        Select Case _VirInfoType
            Case InfoType.High : PictureBox1.Image = My.Resources.hrisk : Siglbl.ForeColor = Color.FromArgb(247, 41, 41)
            Case InfoType.Medium : PictureBox1.Image = My.Resources.Mrisk : Siglbl.ForeColor = Color.FromArgb(255, 148, 0)
            Case InfoType.None : PictureBox1.Image = My.Resources.Nrisk : Siglbl.ForeColor = Color.FromArgb(0, 206, 132)
        End Select
        BoosterToolTip1.SetToolTip(Namelbl, DirLabel.Text)
        If CargaC >= 3 Then
            Timer1.Enabled = False
        End If
    End Sub


End Class

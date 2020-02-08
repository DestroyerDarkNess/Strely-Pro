Public Class clsDetailItem
    Inherits Windows.Forms.PictureBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label

    Dim labelForeColor As System.Drawing.Color
    Dim myItemType As myType
    Dim myID As Integer
    Dim myFullItem As String

    Dim holdMyBackColor As System.Drawing.Color
    Dim holdMyForeColor As System.Drawing.Color



    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub InitializeComponent()
        Dim defaFont As New System.Drawing.Font("verdana", 7, FontStyle.Bold)
        Dim labelY As Integer = 0         '"Franklin Gothic Medium"
        Dim labelX As Integer = 8
        Const labelHeight As Integer = 14
        Const spcBetweenLbls As Integer = 7
        Dim brdStyle As Long = BorderStyle.None
        'Dim labelForeColor As System.Drawing.Color = System.Drawing.Color.White
        'Dim labelBackColor As System.Drawing.Color = System.Drawing.Color.White



        Me.lblID = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.lblLocation = New System.Windows.Forms.Label
        Me.lblItem = New System.Windows.Forms.Label
        '
        'lblID
        '
        Me.lblID.SetBounds(labelX, labelY, 20, labelHeight)
        Me.lblID.Name = "lblID"
        Me.lblID.TabIndex = 0
        Me.lblID.Text = ""
        Me.lblID.BorderStyle = brdStyle
        Me.lblID.Font = defaFont
        Me.lblID.ForeColor = labelForeColor
        labelX += (lblID.Width + spcBetweenLbls)
        '
        'lblType
        '
        Me.lblType.SetBounds(labelX, labelY, 70, labelHeight)
        Me.lblType.Name = "lblType"
        Me.lblType.TabIndex = 0
        Me.lblType.Text = ""
        Me.lblType.BorderStyle = brdStyle
        Me.lblType.Font = defaFont
        Me.lblType.ForeColor = labelForeColor
        labelX += (lblType.Width + spcBetweenLbls)
        '
        'lblLocation
        '
        Me.lblLocation.SetBounds(labelX, labelY, 350, labelHeight)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.TabIndex = 0
        Me.lblLocation.Text = ""
        Me.lblLocation.BorderStyle = brdStyle
        Me.lblLocation.Font = defaFont
        Me.lblLocation.ForeColor = labelForeColor
        labelX += (lblLocation.Width + spcBetweenLbls)
        '
        'lblItem
        '
        Me.lblItem.SetBounds(labelX, labelY, 145, labelHeight)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = ""
        Me.lblItem.BorderStyle = brdStyle
        Me.lblItem.Font = defaFont
        Me.lblItem.ForeColor = labelForeColor

    End Sub

    Public Property textForeColor() As System.Drawing.Color
        Get
            Return labelForeColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            labelForeColor = Value
            lblID.ForeColor = Value
            lblLocation.ForeColor = Value
            lblType.ForeColor = Value
            lblItem.ForeColor = Value
        End Set
    End Property

    Public Property itemType()
        Get
            Return myItemType
        End Get
        Set(ByVal Value)
            myItemType = Value
            Select Case myItemType
                Case myType.Registry
                    Me.textForeColor = System.Drawing.Color.DarkRed
                    Me.lblType.Text = "REGISTRY"
                Case myType.SysFile
                    Me.textForeColor = System.Drawing.Color.DarkGoldenrod
                    Me.lblType.Text = "SYSFILE"
                Case myType.Startup
                    Me.textForeColor = System.Drawing.Color.DarkGreen
                    Me.lblType.Text = "STARTUP"
                Case myType.Service
                    Me.textForeColor = System.Drawing.Color.DarkBlue
                    Me.lblType.Text = "SERVICE"
            End Select
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return myID
        End Get
        Set(ByVal Value As Integer)
            myID = Value
        End Set
    End Property
    Public Property fullItem() As String
        Get
            Return myFullItem
        End Get
        Set(ByVal Value As String)
            myFullItem = Value
        End Set
    End Property


    Private Sub clsDetailItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter, lblID.MouseEnter, lblItem.MouseEnter, lblLocation.MouseEnter, lblType.MouseEnter

        holdMyBackColor = Me.BackColor
        holdMyForeColor = lblID.ForeColor
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.textForeColor = System.Drawing.Color.White
        Me.Cursor = System.Windows.Forms.Cursors.Hand

    End Sub


    Private Sub clsDetailItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave, lblID.MouseLeave, lblItem.MouseLeave, lblLocation.MouseLeave, lblType.MouseLeave
        Me.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        ' Me.BackColor = holdMyBackColor
        Me.textForeColor = holdMyForeColor
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub



    Private Sub clsDetailItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, lblID.Click, lblItem.Click, lblLocation.Click, lblType.Click
        With CurrentItem
            .myType = Me.myItemType
            .ID = myID
            .Type = lblType.Text
            .Location = lblLocation.Text
            .Item = lblItem.Text
        End With
    End Sub
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetectionControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Siglbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.DirLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ThirteenCheckBox1 = New StrelyCleanner.ThirteenCheckBox()
        Me.BoosterToolTip1 = New StrelyCleanner.BoosterToolTip()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(571, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Siglbl)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Namelbl)
        Me.Panel1.Location = New System.Drawing.Point(27, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 21)
        Me.Panel1.TabIndex = 2
        '
        'Siglbl
        '
        Me.Siglbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Siglbl.AutoSize = True
        Me.Siglbl.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siglbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Siglbl.Location = New System.Drawing.Point(248, 1)
        Me.Siglbl.Name = "Siglbl"
        Me.Siglbl.Size = New System.Drawing.Size(61, 13)
        Me.Siglbl.TabIndex = 1
        Me.Siglbl.Text = "Signature"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(481, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 21)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Namelbl
        '
        Me.Namelbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Location = New System.Drawing.Point(4, 1)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(35, 13)
        Me.Namelbl.TabIndex = 0
        Me.Namelbl.Text = "Name"
        '
        'DirLabel
        '
        Me.DirLabel.AutoSize = True
        Me.DirLabel.Location = New System.Drawing.Point(11, 6)
        Me.DirLabel.Name = "DirLabel"
        Me.DirLabel.Size = New System.Drawing.Size(10, 13)
        Me.DirLabel.TabIndex = 0
        Me.DirLabel.Text = "."
        Me.DirLabel.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ThirteenCheckBox1
        '
        Me.ThirteenCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ThirteenCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenCheckBox1.Checked = False
        Me.ThirteenCheckBox1.ColorScheme = StrelyCleanner.ThirteenCheckBox.ColorSchemes.Light
        Me.ThirteenCheckBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox1.Location = New System.Drawing.Point(3, 4)
        Me.ThirteenCheckBox1.Name = "ThirteenCheckBox1"
        Me.ThirteenCheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.ThirteenCheckBox1.TabIndex = 0
        '
        'BoosterToolTip1
        '
        Me.BoosterToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BoosterToolTip1.OwnerDraw = True
        '
        'DetectionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ThirteenCheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DirLabel)
        Me.Name = "DetectionControl"
        Me.Size = New System.Drawing.Size(571, 25)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ThirteenCheckBox1 As StrelyCleanner.ThirteenCheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Siglbl As System.Windows.Forms.Label
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents DirLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BoosterToolTip1 As StrelyCleanner.BoosterToolTip

End Class

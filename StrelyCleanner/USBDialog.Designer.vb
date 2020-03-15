<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USBDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ThirteenButton2 = New StrelyCleanner.ThirteenButton()
        Me.ThirteenButton1 = New StrelyCleanner.ThirteenButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BoosterComboBox1 = New StrelyCleanner.BoosterComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 97)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(12, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 15)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Drive :"
        '
        'ThirteenButton2
        '
        Me.ThirteenButton2.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton2.ColorScheme = StrelyCleanner.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ThirteenButton2.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton2.Location = New System.Drawing.Point(141, 43)
        Me.ThirteenButton2.Name = "ThirteenButton2"
        Me.ThirteenButton2.Size = New System.Drawing.Size(64, 30)
        Me.ThirteenButton2.TabIndex = 19
        Me.ThirteenButton2.Text = "Cancel"
        Me.ThirteenButton2.UseVisualStyleBackColor = False
        '
        'ThirteenButton1
        '
        Me.ThirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton1.ColorScheme = StrelyCleanner.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ThirteenButton1.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton1.Location = New System.Drawing.Point(211, 43)
        Me.ThirteenButton1.Name = "ThirteenButton1"
        Me.ThirteenButton1.Size = New System.Drawing.Size(64, 30)
        Me.ThirteenButton1.TabIndex = 18
        Me.ThirteenButton1.Text = "OK"
        Me.ThirteenButton1.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(12, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(164, 15)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Select your Device to Analyze."
        '
        'BoosterComboBox1
        '
        Me.BoosterComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BoosterComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BoosterComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoosterComboBox1.FormattingEnabled = True
        Me.BoosterComboBox1.ItemHeight = 20
        Me.BoosterComboBox1.Location = New System.Drawing.Point(67, 10)
        Me.BoosterComboBox1.Name = "BoosterComboBox1"
        Me.BoosterComboBox1.Size = New System.Drawing.Size(208, 26)
        Me.BoosterComboBox1.TabIndex = 22
        '
        'USBDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(287, 97)
        Me.Controls.Add(Me.BoosterComboBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ThirteenButton2)
        Me.Controls.Add(Me.ThirteenButton1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "USBDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "USBDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ThirteenButton1 As StrelyCleanner.ThirteenButton
    Friend WithEvents ThirteenButton2 As StrelyCleanner.ThirteenButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BoosterComboBox1 As StrelyCleanner.BoosterComboBox
End Class

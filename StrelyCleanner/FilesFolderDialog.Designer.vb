<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilesFolderDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VistaFolderBrowserDialog1 = New Ookii.Dialogs.VistaFolderBrowserDialog()
        Me.OpenFileDialog1 = New Ookii.Dialogs.VistaOpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OK = New StrelyCleanner.XylosButton()
        Me.XylosButton2 = New StrelyCleanner.XylosButton()
        Me.BoosterComboBox2 = New StrelyCleanner.BoosterComboBox()
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
        Me.Button1.Size = New System.Drawing.Size(225, 119)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Item :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Option:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = Nothing
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.ShowReadOnly = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.EnabledCalc = True
        Me.OK.Location = New System.Drawing.Point(154, 87)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(60, 23)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'XylosButton2
        '
        Me.XylosButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XylosButton2.EnabledCalc = True
        Me.XylosButton2.Location = New System.Drawing.Point(88, 87)
        Me.XylosButton2.Name = "XylosButton2"
        Me.XylosButton2.Size = New System.Drawing.Size(60, 23)
        Me.XylosButton2.TabIndex = 6
        Me.XylosButton2.Text = "Cancel"
        '
        'BoosterComboBox2
        '
        Me.BoosterComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BoosterComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BoosterComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoosterComboBox2.FormattingEnabled = True
        Me.BoosterComboBox2.ItemHeight = 20
        Me.BoosterComboBox2.Items.AddRange(New Object() {"TopDirectoryOnly", "AllDirectories"})
        Me.BoosterComboBox2.Location = New System.Drawing.Point(90, 54)
        Me.BoosterComboBox2.Name = "BoosterComboBox2"
        Me.BoosterComboBox2.Size = New System.Drawing.Size(124, 26)
        Me.BoosterComboBox2.TabIndex = 5
        '
        'BoosterComboBox1
        '
        Me.BoosterComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BoosterComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BoosterComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoosterComboBox1.FormattingEnabled = True
        Me.BoosterComboBox1.ItemHeight = 20
        Me.BoosterComboBox1.Items.AddRange(New Object() {"Folder(s)", "File(s)"})
        Me.BoosterComboBox1.Location = New System.Drawing.Point(90, 12)
        Me.BoosterComboBox1.Name = "BoosterComboBox1"
        Me.BoosterComboBox1.Size = New System.Drawing.Size(124, 26)
        Me.BoosterComboBox1.TabIndex = 2
        '
        'FilesFolderDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(225, 119)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.XylosButton2)
        Me.Controls.Add(Me.BoosterComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BoosterComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FilesFolderDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FilesFolderDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OK As StrelyCleanner.XylosButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoosterComboBox1 As StrelyCleanner.BoosterComboBox
    Friend WithEvents BoosterComboBox2 As StrelyCleanner.BoosterComboBox
    Friend WithEvents VistaFolderBrowserDialog1 As Ookii.Dialogs.VistaFolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As Ookii.Dialogs.VistaOpenFileDialog
    Friend WithEvents XylosButton2 As StrelyCleanner.XylosButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USBNotification
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
        Me.AscButton_Big1 = New StrelyCleanner.ascButton_Big()
        Me.SuspendLayout()
        '
        'AscButton_Big1
        '
        Me.AscButton_Big1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AscButton_Big1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscButton_Big1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.AscButton_Big1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AscButton_Big1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AscButton_Big1.Image = Nothing
        Me.AscButton_Big1.Location = New System.Drawing.Point(0, 0)
        Me.AscButton_Big1.Name = "AscButton_Big1"
        Me.AscButton_Big1.Size = New System.Drawing.Size(284, 96)
        Me.AscButton_Big1.TabIndex = 0
        '
        'USBNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AscButton_Big1)
        Me.Name = "USBNotification"
        Me.Size = New System.Drawing.Size(284, 96)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AscButton_Big1 As StrelyCleanner.ascButton_Big

End Class

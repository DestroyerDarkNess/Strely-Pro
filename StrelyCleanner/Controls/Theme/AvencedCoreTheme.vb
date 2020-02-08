Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Module Drawing

    Public Function RoundRect(ByVal rect As Rectangle, ByVal slope As Integer) As GraphicsPath
        Dim gp As GraphicsPath = New GraphicsPath()
        Dim arcWidth As Integer = slope * 2
        gp.AddArc(New Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90)
        gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90)
        gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 0, 90)
        gp.AddArc(New Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90)
        gp.CloseAllFigures()
        Return gp
    End Function

End Module

Module Prevent

    Public Sub Prevent(ByVal g As Graphics, ByVal w As Integer, ByVal h As Integer)
        Dim txt As String = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String("VGhlbWUlMjBjcmVhdGVkJTIwYnklMjBIYXdrJTIwSEY=")).Replace("%20", " ")
        Dim txtSize As SizeF = g.MeasureString(txt, New Font("Arial", 8))
        g.DrawString(txt, New Font("Arial", 8), New SolidBrush(Color.FromArgb(125, 125, 125)), New Point(w - txtSize.Width - 6, h - txtSize.Height - 4))
    End Sub

End Module

Class ascThemeContainer
    Inherits ContainerControl

    Private moveHeight As Integer = 38
    Private formCanMove As Boolean = False
    Private mouseX, mouseY As Integer
    Private overExit, overMin As Boolean

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Dock = DockStyle.Fill
        Font = New Font("Arial", 12, FontStyle.Bold Or FontStyle.Italic)
        BackColor = Color.FromArgb(15, 15, 15)
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        FindForm.FormBorderStyle = FormBorderStyle.None
        If FindForm.TransparencyKey = Nothing Then FindForm.TransparencyKey = Color.Fuchsia
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics
        G.Clear(FindForm.TransparencyKey)

        Dim slope As Integer = 8

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim mainPath As GraphicsPath = RoundRect(mainRect, slope)
        G.FillPath(New SolidBrush(BackColor), mainPath)
        G.DrawPath(New Pen(Color.FromArgb(5, 135, 250)), mainPath)
        G.FillPath(New SolidBrush(Color.FromArgb(5, 135, 250)), RoundRect(New Rectangle(0, 0, Width - 1, moveHeight - slope), slope))
        G.FillRectangle(New SolidBrush(Color.FromArgb(5, 135, 250)), New Rectangle(0, moveHeight - (slope * 2), Width - 1, slope * 2))
        G.DrawLine(New Pen(Color.FromArgb(60, 60, 60)), New Point(1, moveHeight), New Point(Width - 2, moveHeight))
        G.SmoothingMode = SmoothingMode.HighQuality
        '32, 36, 39 ' 41; 45; 49
        Dim textX As Integer = 6
        Dim textY As Integer = (moveHeight / 2) - (G.MeasureString(Text, Font).Height / 2) + 1
        Dim textSize As SizeF = G.MeasureString(Text, Font)
        Dim textRect As New Rectangle(textX, textY, textSize.Width, textSize.Height)
        Dim textBrush As New LinearGradientBrush(textRect, Color.White, Color.White, 90.0F)
        G.DrawString(Text, Font, textBrush, New Point(textX, textY))

        If overExit Then
            G.DrawString("r", New Font("Marlett", 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(25, 100, 140)), New Point(Width - 27, 11))
        Else
            G.DrawString("r", New Font("Marlett", 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(187, 187, 187)), New Point(Width - 27, 11))
        End If
        If overMin Then
            G.DrawString("0", New Font("Marlett", 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(25, 100, 140)), New Point(Width - 47, 10))
        Else
            G.DrawString("0", New Font("Marlett", 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(187, 187, 187)), New Point(Width - 47, 10))
        End If

        If DesignMode Then Prevent.Prevent(G, Width, Height)

    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)

        If formCanMove = True Then
            FindForm.Location = MousePosition - New Point(mouseX, mouseY)
        End If

        If e.Y > 11 AndAlso e.Y < 24 Then
            If e.X > Width - 23 AndAlso e.X < Width - 10 Then overExit = True Else overExit = False
            If e.X > Width - 44 AndAlso e.X < Width - 31 Then overMin = True Else overMin = False
        Else
            overExit = False
            overMin = False
        End If

        Invalidate()

    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        mouseX = e.X
        mouseY = e.Y

        If e.Y <= moveHeight AndAlso overExit = False AndAlso overMin = False Then formCanMove = True

        If overExit Then
            FindForm.Close()
        ElseIf overMin Then
            FindForm.WindowState = FormWindowState.Minimized
            overExit = False
            overMin = False
        Else
            Focus()
        End If

        Invalidate()

    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        formCanMove = False
    End Sub

End Class

Class ascButton
    Inherits Control

    Private _glowColor As Color
    Public Property GlowColor As Color
        Get
            Return _glowColor
        End Get
        Set(ByVal value As Color)
            _glowColor = value
            Invalidate()
        End Set
    End Property

    Enum State
        None
        Over
        Down
    End Enum

    Private MouseState As State

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Size = New Size(100, 40)
        Font = New Font("Arial", 11)
        Cursor = Cursors.Hand
        BackColor = Color.FromArgb(5, 30, 70)
        ForeColor = Color.FromArgb(195, 230, 255)
        GlowColor = Color.FromArgb(40, 95, 210)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim slope As Integer = 5

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim mainPath As GraphicsPath = RoundRect(mainRect, slope)
        G.FillPath(New LinearGradientBrush(mainRect, BackColor, Color.FromArgb(25, Color.Black), 90.0F), mainPath)
        G.DrawPath(New Pen(Color.FromArgb(BackColor.R / 2, BackColor.G / 2, BackColor.B / 2)), mainPath)

        Dim glow As Integer
        If MouseState = State.Over Then
            glow = 200
        ElseIf MouseState = State.Down Then
            glow = 255
        Else
            glow = 100
        End If
        G.DrawPath(New Pen(Color.FromArgb(glow, _glowColor)), mainPath)

        Dim textX As Integer = ((Width - 1) / 2) - (G.MeasureString(Text, Font).Width / 2)
        Dim textY As Integer = ((Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
        G.DrawString(Text, Font, New SolidBrush(ForeColor), New Point(textX, textY))

    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        MouseState = State.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        MouseState = State.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        MouseState = State.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        MouseState = State.Down
        Invalidate()
    End Sub

End Class

Class ascButton_Big
    Inherits Control

    Private _glowColor As Color
    Public Property GlowColor As Color
        Get
            Return _glowColor
        End Get
        Set(ByVal value As Color)
            _glowColor = value
            Invalidate()
        End Set
    End Property

    Private _image As Image
    Public Property Image As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
            Invalidate()
        End Set
    End Property

    Enum State
        None
        Over
        Down
    End Enum

    Private MouseState As State

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Size = New Size(160, 60)
        Font = New Font("Arial", 11)
        Cursor = Cursors.Hand
        ForeColor = Color.FromArgb(5, 125, 250)
        GlowColor = Color.FromArgb(60, 150, 250)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim BackgroundColor As Brush = New SolidBrush(Color.FromArgb(32, 36, 39))

        G.FillRectangle(BackgroundColor, mainRect)
        G.DrawRectangle(New Pen(Color.FromArgb(30, 45, 60)), mainRect)

        Dim hCB As New ColorBlend(4)
        hCB.Colors(0) = Color.FromArgb(30, 45, 60)
        hCB.Colors(1) = _glowColor
        hCB.Colors(2) = _glowColor
        hCB.Colors(3) = hCB.Colors(0)
        hCB.Positions = New Single() {0.0, 0.35, 0.65, 1.0}
        Dim borderBrush As New LinearGradientBrush(mainRect, Color.FromArgb(32, 36, 39), Color.FromArgb(32, 36, 39), 0.0F)
        borderBrush.InterpolationColors = hCB
        G.DrawLine(New Pen(borderBrush), New Point(0, 0), New Point(Width - 1, 0))
        G.DrawLine(New Pen(borderBrush), New Point(0, Height - 1), New Point(Width - 1, Height - 1))

        Dim glow As Integer
        If MouseState = State.Over Then
            glow = 20
        ElseIf MouseState = State.Down Then
            glow = 30
        Else
            glow = 0
        End If
        G.FillRectangle(New SolidBrush(Color.FromArgb(glow, Color.WhiteSmoke)), mainRect)
        G.DrawRectangle(New Pen(Color.FromArgb(glow, _glowColor)), mainRect)

        Dim textX As Integer
        Dim textY As Integer = ((Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
        If Image IsNot Nothing Then
            Dim imageWidth As Integer = Me.Height - 24, imageHeight As Integer = Me.Height - 24
            Dim imageX As Integer = ((Me.Width - 1) / 2) - ((imageWidth + 4 + G.MeasureString(Text, Font).Width) / 2)
            Dim imageY As Integer = ((Me.Height - 1) / 2) - (imageHeight / 2)
            G.DrawImage(_image, imageX, imageY, imageWidth, imageHeight)
            textX = imageX + imageWidth + 4
        Else
            textX = ((Width - 1) / 2) - (G.MeasureString(Text, Font).Width / 2)
        End If
        G.DrawString(Text, Font, New SolidBrush(ForeColor), New Point(textX, textY))

    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        MouseState = State.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        MouseState = State.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        MouseState = State.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        MouseState = State.Down
        Invalidate()
    End Sub

End Class

Class ascTabControl
    Inherits TabControl

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                 ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        ItemSize = New Size(0, 34)
        Padding = New Size(24, 0)
        Font = New Font("Arial", 12)
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim FontColor As New Color

        For i = 0 To TabCount - 1

            Dim mainRect As Rectangle = GetTabRect(i)

            If i = SelectedIndex Then
                FontColor = Color.FromArgb(80, 170, 245)
                G.DrawLine(New Pen(Color.FromArgb(5, 135, 250)), New Point(mainRect.X - 2, mainRect.Height - 1), New Point(mainRect.X + mainRect.Width - 2, mainRect.Height - 1))
                G.DrawLine(New Pen(Color.FromArgb(25, 100, 140)), New Point(mainRect.X - 2, mainRect.Height), New Point(mainRect.X + mainRect.Width - 2, mainRect.Height))
            Else
                FontColor = Color.FromArgb(160, 160, 160)
                G.DrawLine(New Pen(Color.FromArgb(30, 55, 85)), New Point(mainRect.X - 2, mainRect.Height - 1), New Point(mainRect.X + mainRect.Width - 2, mainRect.Height - 1))
                G.DrawLine(New Pen(Color.FromArgb(30, 55, 85)), New Point(mainRect.X - 2, mainRect.Height), New Point(mainRect.X + mainRect.Width - 2, mainRect.Height))
            End If

            If i <> 0 Then
                G.DrawLine(New Pen(Color.FromArgb(30, 90, 125)), New Point(mainRect.X - 4, mainRect.Height - 7), New Point(mainRect.X + 4, mainRect.Y + 6))
            End If

            Dim titleX As Integer = (mainRect.Location.X + mainRect.Width / 2) - (G.MeasureString(TabPages(i).Text, Font).Width / 2)
            Dim titleY As Integer = (mainRect.Location.Y + mainRect.Height / 2) - (G.MeasureString(TabPages(i).Text, Font).Height / 2)
            G.DrawString(TabPages(i).Text, Font, New SolidBrush(FontColor), New Point(titleX, titleY))

            Try : TabPages(i).BackColor = Parent.BackColor : Catch : End Try

        Next

    End Sub

End Class

Class ascProgressBar
    Inherits Control

    Private _Maximum As Integer = 100
    Public Property Maximum As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal v As Integer)
            If v < 1 Then v = 1
            If v < _Value Then _Value = v
            _Maximum = v
            Invalidate()
        End Set
    End Property

    Private _Value As Integer
    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(ByVal v As Integer)
            If v > _Maximum Then v = Maximum
            _Value = v
            Invalidate()
        End Set
    End Property

    Private _percent As Integer
    Public ReadOnly Property Percent As Integer
        Get
            Return _percent
        End Get
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Size = New Size(200, 40)
        Font = New Font("Arial", 11)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim slope As Integer = 3
        _percent = (_Value / _Maximum) * 100

        Dim midY As Integer = ((Height - 1) / 2)
        Dim mainRect As New Rectangle(12, midY - 4, Width - 25, 7)
        Dim mainPath As GraphicsPath = RoundRect(mainRect, slope)
        Dim barBrush As New LinearGradientBrush(mainRect, Color.FromArgb(32, 32, 32), Color.FromArgb(45, 45, 45), 90.0F)
        G.FillPath(barBrush, mainPath)

        Dim barRect As New Rectangle(12, midY - 4, CInt(((Width / _Maximum) * _Value) - ((_percent - 1) / 4)), 7)
        If barRect.Width > 0 Then
            Dim barHorizontal As New LinearGradientBrush(barRect, Color.FromArgb(5, 80, 140), Color.FromArgb(45, 180, 200), 0.0F)
            G.FillPath(barHorizontal, RoundRect(barRect, slope))

            Dim vertCB As New ColorBlend(5)
            vertCB.Colors(0) = Color.Transparent
            vertCB.Colors(1) = Color.Transparent
            vertCB.Colors(2) = Color.FromArgb(0, 150, 220)
            vertCB.Colors(3) = Color.Transparent
            vertCB.Colors(4) = Color.Transparent
            vertCB.Positions = New Single() {0.0, 0.4, 0.5, 0.6, 1.0}
            Dim barVertical As New LinearGradientBrush(barRect, Color.Black, Color.Black, 90.0F)
            barVertical.InterpolationColors = vertCB
            G.FillPath(barVertical, RoundRect(barRect, slope))
        End If

        If _Value > 0 Then
            Dim bubbleRect As New Rectangle(barRect.Width - 3, 0, midY * 2 - 3, midY * 2)
            Dim bubblePath As GraphicsPath = RoundRect(bubbleRect, midY)
            Dim bubbleBrush As New PathGradientBrush(bubblePath)
            bubbleBrush.CenterColor = Color.FromArgb(230, 245, 255)
            bubbleBrush.SurroundColors = {Color.Transparent}
            G.FillPath(bubbleBrush, bubblePath)
        End If

    End Sub
End Class

<DefaultEvent("CheckedChanged")> Class ascCheckBox
    Inherits Control

    Event CheckedChanged(ByVal sender As Object)

    Private _checked As Boolean
    Public Property Checked() As Boolean
        Get
            Return _checked
        End Get
        Set(ByVal value As Boolean)
            _checked = value
            Invalidate()
        End Set
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Size = New Size(120, 17)
        Font = New Font("Arial", 9)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Height = 17

        Dim boxRect As New Rectangle(1, 1, Height - 3, Height - 3)
        G.DrawEllipse(New Pen(Color.FromArgb(30, 140, 240), 2), boxRect)

        Dim textY As Integer = ((Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
        G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(160, 160, 160)), New Point((Height - 1) + 4, textY))

        If _checked Then G.DrawString("a", New Font("Marlett", 17), New SolidBrush(Color.FromArgb(120, 180, 255)), New Point(-3, -5))

    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        If _checked Then
            _checked = False
        Else
            _checked = True
        End If

        RaiseEvent CheckedChanged(Me)
        Invalidate()

    End Sub

End Class

<DefaultEvent("CheckedChanged")> Class ascSwitch
    Inherits Control

    Event CheckedChanged(ByVal sender As Object)

    Private _checked As Boolean
    Public Property Checked() As Boolean
        Get
            Return _checked
        End Get
        Set(ByVal value As Boolean)
            _checked = value
            Invalidate()
        End Set
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Size = New Size(40, 17)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim slope As Integer = (Height - 1) / 2
        Height = 17

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim mainPath As GraphicsPath = RoundRect(mainRect, slope)

        If _checked Then
            Dim bgBrush As New LinearGradientBrush(mainRect, Color.FromArgb(10, 30, 50), Color.FromArgb(5, 80, 140), 90.0F)
            G.FillPath(bgBrush, mainPath)
            Dim switchRect As New Rectangle(Width - 14, 3, 10, 10)
            Dim switchBrush As New LinearGradientBrush(switchRect, Color.FromArgb(100, 220, 250), Color.FromArgb(15, 150, 220), 90.0F)
            G.FillEllipse(switchBrush, switchRect)
            Dim textY As Integer = ((Height - 1) / 2) - (G.MeasureString("On", New Font("Arial", 8)).Height / 2) + 1
            G.DrawString("On", New Font("Arial", 8), New SolidBrush(Color.FromArgb(180, 180, 180)), New Point(5, textY))
            G.DrawPath(New Pen(Color.FromArgb(5, 80, 140)), mainPath)
        Else
            Dim bgBrush As New LinearGradientBrush(mainRect, Color.FromArgb(40, 40, 40), Color.FromArgb(80, 80, 80), 90.0F)
            G.FillPath(bgBrush, mainPath)
            Dim switchRect As New Rectangle(3, 3, 10, 10)
            Dim switchBrush As New LinearGradientBrush(switchRect, Color.FromArgb(150, 150, 150), Color.FromArgb(120, 120, 120), 90.0F)
            G.FillEllipse(switchBrush, switchRect)
            Dim textY As Integer = ((Height - 1) / 2) - (G.MeasureString("Off", New Font("Arial", 8)).Height / 2) + 1
            G.DrawString("Off", New Font("Arial", 8), New SolidBrush(Color.FromArgb(180, 180, 180)), New Point(15, textY))
            G.DrawPath(New Pen(Color.FromArgb(80, 80, 80)), mainPath)
        End If

    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        If _checked Then
            _checked = False
        Else
            _checked = True
        End If

        RaiseEvent CheckedChanged(Me)
        Invalidate()

    End Sub

End Class
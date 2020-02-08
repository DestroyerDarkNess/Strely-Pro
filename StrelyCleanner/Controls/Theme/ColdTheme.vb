'<------------------>
'Author: WithCreative
'Created: 12.12.2017
'Updated: 13.12.2017
'Category: Game Hacking
'Description: Cold Hack D3D9 Menu UI
'<------------------>

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Reflection
Imports System.ComponentModel

Public Enum MouseState As Byte
    None = 0
    Hover = 1
    Down = 2
    Block = 3
End Enum
Module Functions
    Function CenterText(Text As String, Font As Font, Width As Integer, Height As Integer) As Point
        Dim W As Integer = (Width / 2) - (TextRenderer.MeasureText(Text, Font).Width / 2)
        Dim H As Integer = (Height / 2) - (TextRenderer.MeasureText(Text, Font).Height / 2)
        Dim P As New Point(W, H)
        Return P
    End Function
    Function LeftText(Text As String, Font As Font, Width As Integer, Height As Integer) As Point
        Dim W As Integer = 3
        Dim H As Integer = (Height / 2) - (TextRenderer.MeasureText(Text, Font).Height / 2)
        Dim P As New Point(W, H - 2)
        Return P
    End Function
    Function DrawGradient(Width As Integer, Height As Integer, Optional State As MouseState = MouseState.None) As LinearGradientBrush
        Dim myBrush As LinearGradientBrush
        If State = MouseState.None Then
            myBrush = New LinearGradientBrush(New Point(0, Height), New Point(Width, Height), Color.FromArgb(255, 202, 18), Color.FromArgb(210, 160, 39))
        ElseIf State = MouseState.Hover Then
            myBrush = New LinearGradientBrush(New Point(0, Height), New Point(Width, Height), Color.FromArgb(220, 255, 202, 18), Color.FromArgb(220, 210, 160, 39))
        ElseIf State = MouseState.Down Then
            myBrush = New LinearGradientBrush(New Point(0, Height), New Point(Width, Height), Color.FromArgb(210, 160, 39), Color.FromArgb(255, 202, 18))
        Else
            myBrush = New LinearGradientBrush(New Point(0, Height), New Point(Width, Height), Color.FromArgb(255, 202, 18), Color.FromArgb(210, 160, 39))
        End If
        myBrush.RotateTransform(90)
        Return myBrush
    End Function
End Module
Class ColdForm
    Inherits ContainerControl
    Dim Down As Boolean = False
    Dim MoveHeight As Integer = 30
    Dim MousePoint As New Point(0, 0)

    Protected Overrides Sub OnCreateControl()
        ParentForm.FormBorderStyle = FormBorderStyle.None
        ParentForm.AllowTransparency = True
        ParentForm.TransparencyKey = Color.Fuchsia
        Dock = DockStyle.Fill
        Invalidate()
    End Sub
#Region "MouseStates"
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width, MoveHeight).Contains(e.Location) Then
            Down = True
            MousePoint = e.Location
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Down = False
    End Sub
    Protected Overrides Sub OnMouseMove(e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Down Then
            Parent.Location = MousePosition - MousePoint
        End If
    End Sub
#End Region
    Public mFont As New Font("Segoe UI", 10)
    Sub New()
        Me.Font = mFont
    End Sub
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Using g = e.Graphics
            'Form Background and Topbar
            g.Clear(Color.White)
            g.FillRectangle(DrawGradient(50, Height), New Rectangle(New Point(0, 0), New Size(Width, 25)))
            g.FillRectangle(New SolidBrush(Color.FromArgb(218, 218, 218)), New Rectangle(0, 25, Width, Height - 25))
            g.DrawString(Me.Text, mFont, New SolidBrush(Color.FromArgb(0, 0, 0)), LeftText(Me.Text, mFont, Width, MoveHeight))
            'Border
            g.DrawLine(Pens.Black, New Point(Width, 25), New Point(0, 25)) 'Topbar bottom
            g.DrawLine(Pens.Black, New Point(Width, 0), New Point(0, 0)) 'Form Top
            g.DrawLine(Pens.Black, New Point(0, Height), New Point(0, 0)) 'Form Left
            g.DrawLine(Pens.Black, New Point(Width - 1, 0), New Point(Width - 1, Height)) 'Form Right
            g.DrawLine(Pens.Black, New Point(Width, Height - 1), New Point(0, Height - 1)) 'Form Bottom
        End Using
    End Sub
    Protected Overrides Sub OnSizeChanged(e As System.EventArgs)
        MyBase.OnSizeChanged(e)
        MyBase.Refresh()
    End Sub
    Protected Overrides Sub OnEnter(e As System.EventArgs)
        MyBase.OnLocationChanged(e)
    End Sub
End Class
Class ColdButton
    Inherits Control
    Dim Down As Boolean = False
    Dim MoveHeight As Integer = 30
    Dim MousePoint As New Point(0, 0)
#Region "MouseStates"
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        isMousePress = True
        Me.Refresh()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        isMousePress = False
        Me.Refresh()
    End Sub
#End Region
    Protected Overrides Sub OnCreateControl()
        Dock = DockStyle.None
        Invalidate()
    End Sub
    Private mFont As New Font("Segoe UI", 10)
    Sub New()
        BackColor = Color.FromArgb(51, 51, 51)
        Width = 100
        Height = 30
        Me.Font = mFont
    End Sub
    Dim isMouseEnter As Boolean = False
    Dim isMousePress As Boolean = False
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Using g = e.Graphics
            g.Clear(Color.White)
            If Not isMouseEnter And Not isMousePress Then
                g.FillRectangle(DrawGradient(Me.Height, Me.Width), New Rectangle(New Point(0, 0), New Size(Me.Width, Me.Height)))
            ElseIf isMousePress Then
                g.FillRectangle(DrawGradient(Me.Height, Me.Width, MouseState.Down), New Rectangle(New Point(0, 0), New Size(Me.Width, Me.Height)))
            Else
                g.FillRectangle(DrawGradient(Me.Height, Me.Width, MouseState.Hover), New Rectangle(New Point(0, 0), New Size(Me.Width, Me.Height)))
            End If
            g.DrawLine(Pens.Black, New Point(0, 0), New Point(Me.Width, 0)) 'Top
            g.DrawLine(Pens.Black, New Point(0, Me.Height), New Point(0, 0)) 'Left
            g.DrawLine(Pens.Black, New Point(Width - 1, 0), New Point(Width - 1, Me.Height)) 'Right
            g.DrawLine(Pens.Black, New Point(0, Me.Height - 1), New Point(Me.Width, Me.Height - 1)) 'Bottom
            g.DrawString(Me.Text, Me.Font, Brushes.Black, New Point(CenterText(Me.Text, Me.Font, Me.Width, Me.Height)))
        End Using
    End Sub
    Protected Overrides Sub OnMouseEnter(e As System.EventArgs)
        isMouseEnter = True
        MyBase.OnMouseEnter(e)
        Me.Refresh()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As System.EventArgs)
        isMouseEnter = False
        isMousePress = False
        MyBase.OnMouseEnter(e)
        Me.Refresh()
    End Sub
    Protected Overrides Sub OnSizeChanged(e As System.EventArgs)
        MyBase.OnSizeChanged(e)
        MyBase.Refresh()
    End Sub
End Class
Class ColdTabControl
    Inherits TabControl
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                 ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        ItemSize = New Size(0, 30)
        Font = New Font("Segoe UI", 8)
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        Dim borderPen As New Pen(Color.FromArgb(0, 0, 0))
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Color.FromArgb(218, 218, 218))
        Dim fillRect As New Rectangle(2, ItemSize.Height + 2, Width - 6, Height - ItemSize.Height - 3)
        G.FillRectangle(New SolidBrush(Color.FromArgb(218, 218, 218)), fillRect)
        G.DrawRectangle(borderPen, fillRect)
        Dim FontColor As New Color
        For i = 0 To TabCount - 1
            Dim mainRect As Rectangle = GetTabRect(i)
            mainRect.Height = mainRect.Height - 6
            mainRect.Width = mainRect.Width - 5
            If i = SelectedIndex Then
                G.FillRectangle(DrawGradient(mainRect.Height + 5, 0), mainRect)
                G.DrawRectangle(borderPen, mainRect)
                FontColor = Color.FromArgb(0, 0, 0)
            Else
                G.FillRectangle(New SolidBrush(Color.FromArgb(218, 218, 218)), mainRect)
                G.DrawRectangle(borderPen, mainRect)
                FontColor = Color.FromArgb(0, 0, 0)
            End If
            Dim titleX As Integer = (mainRect.Location.X + mainRect.Width / 2) - (G.MeasureString(TabPages(i).Text, Font).Width / 2)
            Dim titleY As Integer = (mainRect.Location.Y + mainRect.Height / 2) - (G.MeasureString(TabPages(i).Text, Font).Height / 2)
            G.DrawString(TabPages(i).Text, Font, New SolidBrush(FontColor), New Point(titleX, titleY))
            Try : TabPages(i).BackColor = Color.FromArgb(218, 218, 218) : Catch : End Try
        Next
    End Sub
End Class
<DefaultEvent("CheckedChanged")> Class ColdCheckBox
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
        Size = New Size(140, 20)
        Font = New Font("Segoe UI", 8)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        'Variable
        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)
        'Shape and Colors
        Dim box As New Rectangle(0, 0, Height, Height - 1)
        G.FillRectangle(DrawGradient(box.Height + 5, 0), box)
        G.DrawRectangle(New Pen(Color.FromArgb(218, 218, 218)), box)
        box.Width = 15
        box.Height = 15
        'Border
        G.DrawLine(Pens.Black, New Point(0, 0), New Point(box.Width, 0)) 'Top
        G.DrawLine(Pens.Black, New Point(0, 0), New Point(0, box.Height)) 'Left
        G.DrawLine(Pens.Black, New Point(box.Width, 0), New Point(box.Width, box.Height)) 'Right
        G.DrawLine(Pens.Black, New Point(0, box.Height), New Point(box.Width, box.Height)) 'Bottom
        'Inside
        Dim markPen As New Pen(Color.FromArgb(218, 218, 218))
        Dim lightMarkPen As New Pen(Color.FromArgb(0, 0, 0))
        If _checked Then G.DrawString("a", New Font("Marlett", 13), Brushes.Black, New Point(-3, -1.2))
        'Text
        Dim textY As Integer = (Height / 2) - (G.MeasureString(Text, Font).Height / 2)
        G.DrawString(Text, Font, Brushes.Black, New Point(24, textY + 1))
        Me.Size = New Size(28 + G.MeasureString(Text, Font).Width, 16)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If _checked Then
                _checked = False
            Else
                _checked = True
            End If
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End If
    End Sub
End Class
Class ColdComboBox
    Inherits ComboBox

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font("Segoe UI", 7)

    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        DropDownStyle = ComboBoxStyle.DropDownList
        DoubleBuffered = True
        ItemHeight = 20

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        G.FillRectangle(New SolidBrush(Color.FromArgb(246, 246, 246)), mainRect)
        G.DrawRectangle(New Pen(Color.FromArgb(246, 246, 246)), mainRect)

        Dim triangle As Point() = New Point() {New Point(Width - 14, 16), New Point(Width - 18, 10), New Point(Width - 10, 10)}
        G.FillPolygon(Brushes.Black, triangle)
        'Border
        G.DrawLine(Pens.Black, New Point(0, 0), New Point(Width, 0)) 'Top
        G.DrawLine(Pens.Black, New Point(0, 0), New Point(0, Height)) 'Left
        G.DrawLine(Pens.Black, New Point(Width - 25, 0), New Point(Width - 25, Height)) 'Left
        G.DrawLine(Pens.Black, New Point(Width - 1, 0), New Point(Width - 1, Height)) 'Right
        G.DrawLine(Pens.Black, New Point(0, Height - 1), New Point(Width, Height - 1)) 'Top
        Try
            If Items.Count > 0 Then
                If Not SelectedIndex = -1 Then
                    Dim textX As Integer = 6
                    Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Items(SelectedIndex), Font).Height / 2) + 1
                    G.DrawString(Items(SelectedIndex), Font, Brushes.Black, New Point(textX, textY))
                Else
                    Dim textX As Integer = 6
                    Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Items(0), Font).Height / 2) + 1
                    G.DrawString(Items(0), Font, Brushes.Black, New Point(textX, textY))
                End If
            End If
        Catch : End Try

    End Sub

    Sub replaceItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()

        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality

        Dim rect As New Rectangle(e.Bounds.X - 1, e.Bounds.Y - 1, e.Bounds.Width + 1, e.Bounds.Height + 1)

        Try
            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                G.FillRectangle(New SolidBrush(Color.FromArgb(245, 246, 246, 246)), rect)
                G.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, Brushes.Black, New Rectangle(e.Bounds.X + 6, e.Bounds.Y + 3, e.Bounds.Width, e.Bounds.Height))
                G.DrawRectangle(New Pen(Color.FromArgb(20, 160, 230)), rect)
            Else
                G.FillRectangle(New SolidBrush(Color.FromArgb(246, 246, 246)), rect)
                G.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, Brushes.Black, New Rectangle(e.Bounds.X + 6, e.Bounds.Y + 3, e.Bounds.Width, e.Bounds.Height))
                G.DrawRectangle(New Pen(Color.FromArgb(246, 246, 246)), rect)
            End If

        Catch : End Try

    End Sub

    Protected Overrides Sub OnSelectedItemChanged(ByVal e As System.EventArgs)
        MyBase.OnSelectedItemChanged(e)
        Invalidate()
    End Sub
End Class
<DefaultEvent("CheckedChanged")> Class ColdRadioButton
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
        Size = New Size(140, 20)
        Font = New Font("Segoe UI", 8)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)
        Dim box As New Rectangle(0, 0, Height - 5, Height - 5)
        G.FillEllipse(New SolidBrush(Color.FromArgb(235, 235, 235)), box)
        G.DrawEllipse(New Pen(Color.FromArgb(0, 0, 0)), box)
        If _checked Then
            Dim innerMark As New Rectangle(1, 1, Height - 7, Height - 7)
            G.FillEllipse(DrawGradient(20, 5, MouseState.None), innerMark)
        End If
        Dim textY As Integer = (Height / 2) - (G.MeasureString(Text, Font).Height / 2)
        G.DrawString(Text, Font, Brushes.Black, New Point(20, textY - 1))
        Me.Size = New Size(26 + G.MeasureString(Text, Font).Width, 18)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            For Each C As Control In Parent.Controls
                If C IsNot Me AndAlso TypeOf C Is ColdRadioButton Then
                    DirectCast(C, ColdRadioButton).Checked = False
                End If
            Next
            If Not _checked Then
                _checked = True
            End If
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End If
    End Sub
End Class
Class ColdGroupBox
    Inherits GroupBox
    Sub New()
        BackColor = Color.FromArgb(218, 218, 218)
    End Sub
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Using g = e.Graphics
            g.Clear(Color.FromArgb(218, 218, 218))
            g.DrawLine(Pens.Black, New Point(0, 0), New Point(0, 0))
            Dim border As New Rectangle(New Point(0, 0), New Size(Width - 1, Height - 1))
            Dim topBar As New Rectangle(New Point(0, 0), New Size(Width, 25))
            g.FillRectangle(DrawGradient(40, 25), topBar)
            g.DrawRectangle(Pens.Black, border)
            g.DrawString(Text, Font, Brushes.Black, CenterText(Text, Font, Width, 25))
            g.DrawLine(Pens.Black, New Point(0, 25), New Point(Width, 25))
        End Using
    End Sub
End Class
Class ColdLabel
    Inherits Control
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Using g = e.Graphics
            g.Clear(Color.FromArgb(216, 216, 216))
            g.DrawString(Text, Font, Brushes.Black, New Point(0, 0))
            Me.Height = g.MeasureString(Text, Font, Width).Height
            Me.Width = g.MeasureString(Text, Font, Width).Width
        End Using
    End Sub
End Class
<DefaultEvent("TextChanged")> Class ColdTextBox
    Inherits TextBox
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
    End Sub
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        BorderStyle = BorderStyle.FixedSingle
        BackColor = Color.FromArgb(245, 245, 245)
        Margin = New Padding(5, 0, 0, 0)
    End Sub
End Class
Class ColdProgressBar
    Inherits Control
    Private _Maximum As Integer = 100
    Private _ShowPercant As Boolean = True
    Private _Minimum As Integer = 0
    Public Property ShowPercant As Boolean
        Get
            Return _ShowPercant
        End Get
        Set(value As Boolean)
            _ShowPercant = value
            Invalidate()
        End Set
    End Property
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
    Public Property Minimum As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal v As Integer)
            If Not v > -1 Then v = 0
            If v > _Maximum Then v = _Maximum - 1
            _Minimum = v
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
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Size = New Size(100, 24)
        Maximum = 100
        Minimum = 0
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)
        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        G.FillRectangle(New SolidBrush(Color.FromArgb(240, 240, 240)), mainRect)
        G.DrawRectangle(Pens.Black, mainRect)
        Dim barRect As New Rectangle(0, 0, CInt(((Width / _Maximum) * _Value) - 1), Height - 1)
        G.FillRectangle(DrawGradient(Height, CInt(((Width / _Maximum) * _Value) - 1)), barRect)
        Dim percent As Single = (_Value / _Maximum) * 100
        Dim txt As String = Text & " " & CStr(percent) & "%"
        If ShowPercant Then
            G.DrawString(txt, Font, Brushes.Black, LeftText(Text, Font, Width, Height / 2 + 2))
        End If
    End Sub
End Class
' Strafe Theme.
' Made by AeroRev9.
' uid=2203026

Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Module Helpers2

    Public Enum MouseState2 As Byte
        None = 0
        Over = 1
        Down = 2
    End Enum

    Public Enum RoundingStyle As Byte
        All = 0
        Top = 1
        Bottom = 2
        Left = 3
        Right = 4
        TopRight = 5
        BottomRight = 6
    End Enum

    Public Sub CenterString(G As Graphics, T As String, F As Font, C As Color, R As Rectangle)
        Dim TS As SizeF = G.MeasureString(T, F)

        Using B As New SolidBrush(C)
            G.DrawString(T, F, B, New Point(R.X + R.Width / 2 - (TS.Width / 2), R.Y + R.Height / 2 - (TS.Height / 2)))
        End Using
    End Sub

    Public Function ColorFromHex2(Hex As String) As Color
        Return Color.FromArgb(Long.Parse(String.Format("FFFFFFFFFF{0}", Hex.Substring(1)), Globalization.NumberStyles.HexNumber))
    End Function

    Public Function FullRectangle(S As Size, Subtract As Boolean) As Rectangle

        If Subtract Then
            Return New Rectangle(0, 0, S.Width - 1, S.Height - 1)
        Else
            Return New Rectangle(0, 0, S.Width, S.Height)
        End If

    End Function

    Public Function RoundRect2(ByVal Rect As Rectangle, ByVal Rounding As Integer, Optional ByVal Style As RoundingStyle = RoundingStyle.All) As GraphicsPath

        Dim GP As New GraphicsPath()
        Dim AW As Integer = Rounding * 2

        GP.StartFigure()

        If Rounding = 0 Then
            GP.AddRectangle(Rect)
            GP.CloseAllFigures()
            Return GP
        End If

        Select Case Style
            Case RoundingStyle.All
                GP.AddArc(New Rectangle(Rect.X, Rect.Y, AW, AW), -180, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
                GP.AddArc(New Rectangle(Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 90, 90)
            Case RoundingStyle.Top
                GP.AddArc(New Rectangle(Rect.X, Rect.Y, AW, AW), -180, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddLine(New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y + Rect.Height))
            Case RoundingStyle.Bottom
                GP.AddLine(New Point(Rect.X, Rect.Y), New Point(Rect.X + Rect.Width, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
                GP.AddArc(New Rectangle(Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 90, 90)
            Case RoundingStyle.Left
                GP.AddArc(New Rectangle(Rect.X, Rect.Y, AW, AW), -180, 90)
                GP.AddLine(New Point(Rect.X + Rect.Width, Rect.Y), New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height))
                GP.AddArc(New Rectangle(Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 90, 90)
            Case RoundingStyle.Right
                GP.AddLine(New Point(Rect.X, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
            Case RoundingStyle.TopRight
                GP.AddLine(New Point(Rect.X, Rect.Y + 1), New Point(Rect.X, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddLine(New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height - 1), New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height))
                GP.AddLine(New Point(Rect.X + 1, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y + Rect.Height))
            Case RoundingStyle.BottomRight
                GP.AddLine(New Point(Rect.X, Rect.Y + 1), New Point(Rect.X, Rect.Y))
                GP.AddLine(New Point(Rect.X + Rect.Width - 1, Rect.Y), New Point(Rect.X + Rect.Width, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
                GP.AddLine(New Point(Rect.X + 1, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y + Rect.Height))
        End Select

        GP.CloseAllFigures()

        Return GP

    End Function

End Module

Namespace Base

    Public MustInherit Class LeftTabControl
        Inherits TabControl

        Public BaseRect As Rectangle
        Public OverRect As Rectangle
        Public ItemWidth As Integer = 180

        Private _OverIndex As Integer = -1

        Public ReadOnly Property Hovering As Boolean
            Get
                Return Not OverIndex = -1
            End Get
        End Property

        Public Property OverIndex As Integer
            Get
                Return _OverIndex
            End Get
            Set(value As Integer)
                _OverIndex = value

                If Not _OverIndex = -1 Then
                    OverRect = New Rectangle(GetTabRect(OverIndex).X, GetTabRect(OverIndex).Y, GetTabRect(OverIndex).Width, GetTabRect(OverIndex).Height)
                End If

                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            SetStyle(ControlStyles.UserPaint, True)
        End Sub

        Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            e.Control.BackColor = Color.White
            e.Control.ForeColor = ColorFromHex2("#72778D")
            e.Control.Font = New Font("Segoe UI", 9)
        End Sub

        Sub New()
            DoubleBuffered = True
            Alignment = TabAlignment.Left
            ItemSize = New Size(40, ItemWidth)
            SizeMode = TabSizeMode.Fixed
            Font = New Font("Segoe UI", 9)
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)

            For I As Integer = 0 To TabPages.Count - 1
                If GetTabRect(I).Contains(e.Location) And Not SelectedIndex = I Then
                    OverIndex = I
                    Exit For
                Else
                    OverIndex = -1
                End If
            Next

            MyBase.OnMouseMove(e)

        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            OverIndex = -1
        End Sub

    End Class

    Public MustInherit Class TopTabControl
        Inherits TabControl

        Public BaseRect As Rectangle
        Public OverRect As Rectangle
        Public ItemWidth As Integer = 20

        Private _OverIndex As Integer = -1

        Public ReadOnly Property Hovering As Boolean
            Get
                Return Not OverIndex = -1
            End Get
        End Property

        Public Property OverIndex As Integer
            Get
                Return _OverIndex
            End Get
            Set(value As Integer)
                _OverIndex = value

                If Not _OverIndex = -1 Then
                    OverRect = New Rectangle(GetTabRect(OverIndex).X, GetTabRect(OverIndex).Y, GetTabRect(OverIndex).Width, GetTabRect(OverIndex).Height)
                End If

                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            SetStyle(ControlStyles.UserPaint, True)
        End Sub

        Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            e.Control.BackColor = Color.White
            e.Control.ForeColor = ColorFromHex2("#72778D")
            e.Control.Font = New Font("Segoe UI", 9)
        End Sub

        Sub New()
            DoubleBuffered = True
            Alignment = TabAlignment.Top
            ItemSize = New Size(15, 15)
            SizeMode = TabSizeMode.Fixed
            Font = New Font("Segoe UI", 9)
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)

            For I As Integer = 0 To TabPages.Count - 1
                If GetTabRect(I).Contains(e.Location) And Not SelectedIndex = I Then
                    OverIndex = I
                    Exit For
                Else
                    OverIndex = -1
                End If
            Next

            MyBase.OnMouseMove(e)

        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            OverIndex = -1
        End Sub

    End Class

    Public MustInherit Class CheckControl
        Inherits Control

        Public Event CheckedChanged(sender As Object, e As EventArgs)
        Public State As MouseState2

        Private IsEnabled As Boolean
        Private IsChecked As Boolean

        Public Shadows Property Enabled As Boolean
            Get
                Return EnabledCalc
            End Get
            Set(value As Boolean)
                IsEnabled = value

                If Enabled Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If

                Invalidate()
            End Set
        End Property

        <DisplayName("Enabled")>
        Public Property EnabledCalc As Boolean
            Get
                Return IsEnabled
            End Get
            Set(value As Boolean)
                Enabled = value
                Invalidate()
            End Set
        End Property

        Public Property Checked As Boolean
            Get
                Return IsChecked
            End Get
            Set(value As Boolean)
                IsChecked = value
                Invalidate()
            End Set
        End Property

        Sub New()
            Enabled = True
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState2.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState2.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState2.Over : Invalidate()

            If Enabled Then
                Checked = Not Checked
                RaiseEvent CheckedChanged(Me, e)
            End If

        End Sub

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState2.Down : Invalidate()
        End Sub

    End Class

    Public MustInherit Class RadioButtonBase
        Inherits Control

        Public Event CheckedChanged(sender As Object, e As EventArgs)
        Public State As MouseState2

        Private IsEnabled As Boolean
        Private IsChecked As Boolean

        Public Shadows Property Enabled As Boolean
            Get
                Return EnabledCalc
            End Get
            Set(value As Boolean)
                IsEnabled = value

                If Enabled Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If

                Invalidate()
            End Set
        End Property

        <DisplayName("Enabled")>
        Public Property EnabledCalc As Boolean
            Get
                Return IsEnabled
            End Get
            Set(value As Boolean)
                Enabled = value
                Invalidate()
            End Set
        End Property

        Public Property Checked As Boolean
            Get
                Return IsChecked
            End Get
            Set(value As Boolean)
                IsChecked = value
                Invalidate()
            End Set
        End Property

        Sub New()
            Enabled = True
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState2.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState2.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState2.Over : Invalidate()

            If Enabled Then

                If Not Checked Then

                    For Each C As Control In Parent.Controls
                        If TypeOf C Is RadioButtonBase Then
                            DirectCast(C, RadioButtonBase).Checked = False
                        End If
                    Next

                End If

                Checked = True
                RaiseEvent CheckedChanged(Me, e)
            End If

        End Sub

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState2.Down : Invalidate()
        End Sub

    End Class

    Public MustInherit Class ButtonBase
        Inherits Control

        Public Shadows Event Click(sender As Object, e As EventArgs)

        Public State As MouseState2
        Private IsEnabled As Boolean

        Public Shadows Property Enabled As Boolean
            Get
                Return EnabledCalc
            End Get
            Set(value As Boolean)
                IsEnabled = value

                If Enabled Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If

                Invalidate()
            End Set
        End Property

        <DisplayName("Enabled")>
        Public Property EnabledCalc As Boolean
            Get
                Return IsEnabled
            End Get
            Set(value As Boolean)
                Enabled = value
                Invalidate()
            End Set
        End Property

        Sub New()
            DoubleBuffered = True
            Enabled = True
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState2.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState2.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState2.Over : Invalidate()

            If Enabled Then
                RaiseEvent Click(Me, e)
            End If

        End Sub

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState2.Down : Invalidate()
        End Sub

    End Class

End Namespace

Public Class StrafeTabControl
    Inherits Base.LeftTabControl

    Private G As Graphics
    Private B64Arrow As String = "iVBORw0KGgoAAAANSUhEUgAAAAoAAAAKCAQAAAAnOwc2AAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QA/4ePzL8AAAAHdElNRQffDAEGGjYp6p3OAAAAgklEQVQI122OwQnCQBRE319jmvBgS3rwJFpYKjCxBfsRPCWgSfZPcD1sCArO3AYe80wY6cYY93dtA28AFISflFS3q2QeHAfP81lJzbBukU0QGVEh/KikS18+iYbnFsIPSqpGegv8yw9e9+Ur48vRdSg73KYvpaZblGyWj757aDPLfwAb/2J7O2+WigAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNS0xMi0wMVQwNjoyNjo1NC0wNTowMCb0KyoAAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTUtMTItMDFUMDY6MjY6NTQtMDU6MDBXqZOWAAAAAElFTkSuQmCC"

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        G.Clear(ColorFromHex2("#2E3243"))

        For I As Integer = 0 To TabPages.Count - 1

            BaseRect = GetTabRect(I)

            If SelectedIndex = I Then

                Using Background As New SolidBrush(ColorFromHex2("#272938")), TextColor As New SolidBrush(ColorFromHex2("#E4E4E5")), TextFont As New Font("Segoe UI semibold", 9)
                    G.FillRectangle(Background, BaseRect.X - 6, BaseRect.Y + 1, BaseRect.Width + 9, BaseRect.Height - 1)
                    G.DrawString(TabPages(I).Text, TextFont, TextColor, New Point(BaseRect.X + 55, BaseRect.Y + 11))
                End Using

                Using RectBack As New SolidBrush(ColorFromHex2("#2E3243")), RectBorder As New Pen(ColorFromHex2("#232532")), LeftArrow As Image = Image.FromStream(New IO.MemoryStream(Convert.FromBase64String(B64Arrow)))
                    G.FillPath(RectBack, RoundRect2(New Rectangle(BaseRect.X + 148, BaseRect.Y + 11, 17, 17), 3))
                    G.DrawPath(RectBorder, RoundRect2(New Rectangle(BaseRect.X + 148, BaseRect.Y + 11, 17, 17), 3))
                    G.DrawImage(LeftArrow, New Point(BaseRect.X + 153, BaseRect.Y + 15))
                End Using

            Else

                Using TextColor As New SolidBrush(ColorFromHex2("#848AA0")), TextFont As New Font("Segoe UI semibold", 9)
                    G.DrawString(TabPages(I).Text, TextFont, TextColor, New Point(BaseRect.X + 55, BaseRect.Y + 11))
                End Using

            End If

            If Not String.IsNullOrEmpty(TabPages(I).Tag) Then

                Try
                    Using Border As New Pen(ColorFromHex2(TabPages(I).Tag)) With {
               .Width = 3}
                        G.DrawPath(Border, RoundRect2(New Rectangle(BaseRect.X + 35, BaseRect.Y + 15, 9, 9), 2))
                    End Using
                Catch
                End Try

            End If

        Next

        MyBase.OnPaint(e)
    End Sub

End Class

Public Class StrafeSelector
    Inherits Base.TopTabControl

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        G.Clear(Parent.BackColor)

        For I As Integer = 0 To TabPages.Count - 1

            BaseRect = GetTabRect(I)

            If SelectedIndex = I Then

                If String.IsNullOrEmpty(TabPages(I).Tag) Then

                    Using DefColor As New SolidBrush(ColorFromHex2("#40B1D0")) ', DefBorder As New Pen(ColorFromHex("#3CA3C3"))
                        G.FillEllipse(DefColor, New Rectangle(BaseRect.X + 5, BaseRect.Y + 5, 9, 9))
                    End Using

                ElseIf TabPages(I).Tag.ToString.Length = 7 Then

                    Using DefColor As New SolidBrush(ColorFromHex2(TabPages(I).Tag))
                        G.FillEllipse(DefColor, New Rectangle(BaseRect.X + 5, BaseRect.Y + 5, 9, 9))
                    End Using

                End If

            Else

                Using DefColor As New SolidBrush(ColorFromHex2("#C8C8C8")), DefBorder As New Pen(ColorFromHex2("#C3C3C3"))
                    G.FillEllipse(DefColor, New Rectangle(BaseRect.X + 5, BaseRect.Y + 5, 9, 9))
                    G.DrawEllipse(DefBorder, New Rectangle(BaseRect.X + 5, BaseRect.Y + 5, 9, 9))
                End Using

            End If

            If Hovering Then
                Cursor = Cursors.Hand
            Else
                Cursor = Cursors.Default
            End If

        Next

        MyBase.OnPaint(e)
    End Sub

End Class

Public Class StrafeOnOffBox
    Inherits Base.CheckControl

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        If Enabled Then

            If Not Checked Then

                Using Background As New SolidBrush(ColorFromHex2("#C8C8C8")), Border As New Pen(ColorFromHex2("#C3C3C3")), SquareBorder As New Pen(ColorFromHex2("#C3C3C3"))
                    G.FillRectangle(Background, HelpersXylos.FullRectangle(Size, True))
                    G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))

                    G.FillRectangle(Brushes.White, New Rectangle(3, 3, 16, Height - 7))
                    G.DrawRectangle(SquareBorder, New Rectangle(3, 3, 16, Height - 7))
                End Using

            Else

                Using Background As New SolidBrush(ColorFromHex2("#40B1D0")), Border As New Pen(ColorFromHex2("#3CA3C3")), SquareBorder As New Pen(ColorFromHex2("#3CA3C3"))
                    G.FillRectangle(Background, HelpersXylos.FullRectangle(Size, True))
                    G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))

                    G.FillRectangle(Brushes.White, New Rectangle(Width - 20, 3, 16, Height - 7))
                    G.DrawRectangle(SquareBorder, New Rectangle(Width - 20, 3, 16, Height - 7))
                End Using

            End If

        Else

            If Not Checked Then

                Using Background As New SolidBrush(ColorFromHex2("#E8E8E8")), Border As New Pen(ColorFromHex2("#DEDEDE")), SquareBorder As New Pen(ColorFromHex2("#E0E0E0"))
                    G.FillRectangle(Background, HelpersXylos.FullRectangle(Size, True))
                    G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))

                    G.FillRectangle(Brushes.White, New Rectangle(3, 3, 16, Height - 7))
                    G.DrawRectangle(SquareBorder, New Rectangle(3, 3, 16, Height - 7))
                End Using

            Else

                Using Background As New SolidBrush(ColorFromHex2("#A0C4CE")), Border As New Pen(ColorFromHex2("#9FC1CB")), SquareBorder As New Pen(ColorFromHex2("#9FC1CB"))
                    G.FillRectangle(Background, HelpersXylos.FullRectangle(Size, True))
                    G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))

                    G.FillRectangle(Brushes.White, New Rectangle(Width - 20, 3, 16, Height - 7))
                    G.DrawRectangle(SquareBorder, New Rectangle(Width - 20, 3, 16, Height - 7))
                End Using

            End If

        End If

        MyBase.OnPaint(e)
    End Sub

End Class

Public Class StrafeCheckBox
    Inherits Base.CheckControl

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        If Enabled Then

            Using Border As New Pen(ColorFromHex2("#C8C8C8")), TextColor As New SolidBrush(ColorFromHex2("#72778D")), TextFont As New Font("Segoe UI", 9)
                G.DrawRectangle(Border, New Rectangle(0, 0, 16, 16))
                G.DrawString(Text, TextFont, TextColor, New Point(22, 0))
            End Using

            If Checked Then

                Using Check As New SolidBrush(ColorFromHex2("#40B1D0")), CheckBorder As New Pen(ColorFromHex2("#3CA3C3"))
                    G.FillRectangle(Check, New Rectangle(3, 3, 10, 10))
                    G.DrawRectangle(CheckBorder, New Rectangle(3, 3, 10, 10))
                End Using

            End If

        Else

            Using Border As New Pen(ColorFromHex2("#E8E8E8")), TextColor As New SolidBrush(ColorFromHex2("#B8BDC9")), TextFont As New Font("Segoe UI", 9)
                G.DrawRectangle(Border, New Rectangle(0, 0, 16, 16))
                G.DrawString(Text, TextFont, TextColor, New Point(22, 0))
            End Using

            If Checked Then

                Using Check As New SolidBrush(ColorFromHex2("#A0C4CE")), CheckBorder As New Pen(ColorFromHex2("#9FC1CB"))
                    G.FillRectangle(Check, New Rectangle(3, 3, 10, 10))
                    G.DrawRectangle(CheckBorder, New Rectangle(3, 3, 10, 10))
                End Using

            End If

        End If

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(Width, 17)
    End Sub

End Class

Public Class StrafeRadioButton
    Inherits Base.RadioButtonBase

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        If Enabled Then

            Using Border As New Pen(ColorFromHex2("#C8C8C8")), TextColor As New SolidBrush(ColorFromHex2("#72778D")), TextFont As New Font("Segoe UI", 9)
                G.DrawEllipse(Border, New Rectangle(0, 0, 16, 16))
                G.DrawString(Text, TextFont, TextColor, New Point(22, 0))
            End Using

            If Checked Then

                Using Check As New SolidBrush(ColorFromHex2("#40B1D0")), CheckBorder As New Pen(ColorFromHex2("#3CA3C3"))
                    G.FillEllipse(Check, New Rectangle(3, 3, 10, 10))
                    G.DrawEllipse(CheckBorder, New Rectangle(3, 3, 10, 10))
                End Using

            End If

        Else

            Using Border As New Pen(ColorFromHex2("#E8E8E8")), TextColor As New SolidBrush(ColorFromHex2("#B8BDC9")), TextFont As New Font("Segoe UI", 9)
                G.DrawEllipse(Border, New Rectangle(0, 0, 16, 16))
                G.DrawString(Text, TextFont, TextColor, New Point(22, 0))
            End Using

            If Checked Then

                Using Check As New SolidBrush(ColorFromHex2("#A0C4CE")), CheckBorder As New Pen(ColorFromHex2("#9FC1CB"))
                    G.FillEllipse(Check, New Rectangle(3, 3, 10, 10))
                    G.DrawEllipse(CheckBorder, New Rectangle(3, 3, 10, 10))
                End Using

            End If

        End If

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(Width, 17)
    End Sub

End Class

Public Class StrafeHeader
    Inherits Control

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        G.Clear(Parent.BackColor)

        Using TextColor As New SolidBrush(ColorFromHex2("#4E5260")), TextFont As New Font("Segoe UI semibold", 15)
            G.DrawString(Text, TextFont, TextColor, New Point(0, 0))
        End Using

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(Width, 32)
    End Sub

End Class

Public Class StrafeSeparator
    Inherits Control

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        G.Clear(Parent.BackColor)

        Using SepColor As New Pen(ColorFromHex2("#ECEFF3"))
            G.DrawLine(SepColor, 0, 0, Width, 0)
        End Using

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(Width, 6)
    End Sub

End Class

Public Class StrafeCircular
    Inherits Control

    Private G As Graphics
    Private ProgressAngle As Single
    Private RemainderAngle As Single

    Private _Progress As Single
    Private _Max As Single = 100
    Private _Min As Single = 0

    Public Property ShowMax As Boolean

    Public Property Progress As Single
        Get
            Return _Progress
        End Get
        Set(value As Single)
            Select Case value
                Case Is > Max
                    value = Max
                    Invalidate()

                Case Is < Min
                    value = Min
                    Invalidate()
            End Select
            _Progress = value
            Invalidate()
        End Set
    End Property

    Public Property Max As Single
        Get
            Return _Max
        End Get
        Set(value As Single)
            Select Case value
                Case Is < _Progress
                    _Progress = value
            End Select
            _Max = value
            Invalidate()
        End Set
    End Property

    Public Property Min As Single
        Get
            Return _Min
        End Get
        Set(value As Single)
            Select Case value
                Case Is > _Progress
                    _Progress = value
            End Select
            _Min = value
            Invalidate()
        End Set
    End Property

    Private _arrowColor As Color = Color.FromArgb(51, 51, 51)

    <Category("Colors")>
    Public Property ArrowColor As Color
        Get
            Return _arrowColor
        End Get
        Set(ByVal value As Color)
            _arrowColor = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        ProgressAngle = 360 / Max * Progress
        RemainderAngle = 360 - ProgressAngle

        Using ProgressColor As New Pen(_arrowColor, 4), Background As New Pen(ColorFromHex2("#E8E8E8"), 4)
            G.DrawArc(ProgressColor, New Rectangle(2, 2, Width - 5, Height - 5), -90, ProgressAngle)
            G.DrawArc(Background, New Rectangle(2, 2, Width - 5, Height - 5), ProgressAngle - 90, RemainderAngle)
        End Using

        Using TextFont As New Font("Segoe UI", 9, FontStyle.Bold), TextColor As New SolidBrush(ColorFromHex2("#4E5260"))
            HelpersXylos.CenterString(G, Progress, TextFont, TextColor.Color, New Rectangle(1, 1, Width, Height + 1))
        End Using

        If ShowMax Then

            Using TextFont As New Font("Segoe UI", 7, FontStyle.Bold), TextColor As New SolidBrush(ColorFromHex2("#B8BDC9"))
                HelpersXylos.CenterString(G, Max, TextFont, TextColor.Color, New Rectangle(0, 11, Width, Height + 1))
            End Using

        End If

        MyBase.OnPaint(e)

    End Sub

End Class

Public Class StrafeProgressBar
    Inherits Control

    Private G As Graphics

    Private _Val As Integer = 0
    Private _Min As Integer = 0
    Private _Max As Integer = 100

    Public Property Value As Integer
        Get
            Return _Val
        End Get
        Set(value As Integer)
            _Val = value
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Integer
        Get
            Return _Min
        End Get
        Set(value As Integer)
            _Min = value
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return _Max
        End Get
        Set(value As Integer)
            _Max = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
        Maximum = 100
        Minimum = 0
        Value = 0
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        G.Clear(Parent.BackColor)

        Using Border As New Pen(ColorFromHex2("#D0D5D9"))
            G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
        End Using

        Using Background As New SolidBrush(ColorFromHex2("#40B1D0")), DefBackground As New SolidBrush(ColorFromHex2("#E8E8E8"))
            G.FillRectangle(DefBackground, HelpersXylos.FullRectangle(Size, True))
            G.FillRectangle(Background, New Rectangle(0, 0, Value / Maximum * Width - 1, Height - 1))
        End Using

        MyBase.OnPaint(e)

    End Sub

End Class

Public Class StrafeButton
    Inherits Base.ButtonBase

    Private G As Graphics

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        G.Clear(Parent.BackColor)

        If Enabled Then

            Select Case State

                Case MouseState2.None

                    Using Border As New Pen(ColorFromHex2("#C8C8C8"))
                        G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
                    End Using

                Case MouseState2.Over

                    Using Background As New SolidBrush(ColorFromHex2("#F0F0F0")), Border As New Pen(ColorFromHex2("#C8C8C8"))
                        G.FillRectangle(Background, HelpersXylos.FullRectangle(Size, True))
                        G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
                    End Using

                Case MouseState2.Down

                    Using Background As New SolidBrush(ColorFromHex2("#E6E6E6")), Border As New Pen(ColorFromHex2("#C8C8C8"))
                        G.FillRectangle(Background, HelpersXylos.FullRectangle(Size, True))
                        G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
                    End Using

            End Select

            Using TextFont As New Font("Segoe UI", 9), TextColor As New SolidBrush(ColorFromHex2("#72778D"))
                HelpersXylos.CenterString(G, Text, TextFont, TextColor.Color, HelpersXylos.FullRectangle(Size, False))
            End Using

        Else

            Using Border As New Pen(ColorFromHex2("#E8E8E8"))
                G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
            End Using

            Using TextFont As New Font("Segoe UI", 9), TextColor As New SolidBrush(ColorFromHex2("#B8BDC9"))
                HelpersXylos.CenterString(G, Text, TextFont, TextColor.Color, HelpersXylos.FullRectangle(Size, False))
            End Using

        End If


        MyBase.OnPaint(e)
    End Sub

End Class

Public Class StrafeNumericUpDown
    Inherits Control

    Public Event ValueChanged(sender As Object, e As EventArgs)

    Private G As Graphics
    Private IsEnabled As Boolean
    Public Property UpDownStep As Integer = 1

    Private _Value As Integer
    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(value As Integer)
            Select Case value
                Case Is > Max
                    value = Max
                    Invalidate()

                Case Is < Min
                    value = Min
                    Invalidate()
            End Select
            _Value = value
            Invalidate()
            RaiseEvent ValueChanged(Me, EventArgs.Empty)
        End Set
    End Property

    Private _Max As Integer = 100
    Public Property Max As Integer
        Get
            Return _Max
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < _Value
                    _Value = value
            End Select
            _Max = value
            Invalidate()
        End Set
    End Property

    Private _Min As Integer
    Public Property Min As Integer
        Get
            Return _Min
        End Get
        Set(value As Integer)
            Select Case value
                Case Is > _Value
                    _Value = value
            End Select
            _Min = value
            Invalidate()
        End Set
    End Property

    Public Shadows Property Enabled As Boolean
        Get
            Return EnabledCalc
        End Get
        Set(value As Boolean)
            IsEnabled = value
            Invalidate()
        End Set
    End Property

    <DisplayName("Enabled")>
    Public Property EnabledCalc As Boolean
        Get
            Return IsEnabled
        End Get
        Set(value As Boolean)
            Enabled = value
            Invalidate()
        End Set
    End Property

    Sub New()
        Enabled = True
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        If Enabled Then

            Using Border As New Pen(ColorFromHex2("#C8C8C8"))
                G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
                G.DrawRectangle(Border, New Rectangle(Width - 20, 4, 15, 18))
            End Using

            Using TextColor As New SolidBrush(ColorFromHex2("#424E5A")), TextFont As New Font("Segoe UI", 10)
                HelpersXylos.CenterString(G, Value, TextFont, TextColor.Color, New Rectangle(-10, 0, Width, Height))
            End Using

            Using SignColor As New SolidBrush(ColorFromHex2("#72778D")), SignFont As New Font("Marlett", 10)
                G.DrawString("t", SignFont, SignColor, New Point(Width - 20, 4))
                G.DrawString("u", SignFont, SignColor, New Point(Width - 20, 10))
            End Using

        Else

            Using Border As New Pen(ColorFromHex2("#E6E6E6"))
                G.DrawRectangle(Border, HelpersXylos.FullRectangle(Size, True))
                G.DrawRectangle(Border, New Rectangle(Width - 20, 4, 15, 18))
            End Using

            Using TextColor As New SolidBrush(ColorFromHex2("#A6B2BE")), TextFont As New Font("Segoe UI", 10)
                HelpersXylos.CenterString(G, Value, TextFont, TextColor.Color, New Rectangle(-10, 0, Width, Height))
            End Using

            Using SignColor As New SolidBrush(ColorFromHex2("#BAC6D2")), SignFont As New Font("Marlett", 10)
                G.DrawString("t", SignFont, SignColor, New Point(Width - 20, 4))
                G.DrawString("u", SignFont, SignColor, New Point(Width - 20, 10))
            End Using

        End If

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)

        If Enabled Then

            If e.X > Width - 20 And e.Y < 10 Then
                Value += UpDownStep
            ElseIf e.X > Width - 20 And e.Y > 10 Then
                Value -= UpDownStep
            End If

        End If

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        If Enabled Then

            If e.X > Width - 20 And e.Y < 10 Then
                Cursor = Cursors.Hand
            ElseIf e.X > Width - 20 And e.Y > 10 Then
                Cursor = Cursors.Hand
            Else
                Cursor = Cursors.Default
            End If

        End If

    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(Width, 27)
    End Sub

End Class
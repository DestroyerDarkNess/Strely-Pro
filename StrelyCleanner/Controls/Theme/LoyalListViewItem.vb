Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class LoyalListViewItem
    Private _subItems As List(Of LoyalListViewSubItem) = New List(Of LoyalListViewSubItem)()

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Property SubItems As List(Of LoyalListViewSubItem)
        Get
            Return _subItems
        End Get
        Set(ByVal value As List(Of LoyalListViewSubItem))
            _subItems = value
        End Set
    End Property

    Protected uniqueId As Guid

    Public Sub New()
        uniqueId = Guid.NewGuid()
    End Sub

    Public Sub New(ByVal text As String)
        uniqueId = Guid.NewGuid()
        text = text
    End Sub

    Public Sub New(ByVal text As String, ByVal subitems As List(Of LoyalListViewSubItem))
        uniqueId = Guid.NewGuid()
        text = text
        subitems = subitems
    End Sub

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If obj.[GetType]() = GetType(LoyalListViewItem) Then Return ((CType(obj, LoyalListViewItem)).uniqueId = uniqueId)
        Return False
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    Public Property Text As String

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class

Public Class LoyalListViewSubItem
    Public Property Text As String

    Public Overrides Function ToString() As String
        Return Text
    End Function

    Public Sub New()
    End Sub

    Public Sub New(ByVal text As String)
        text = text
    End Sub
End Class

Public Class LoyalListViewColumnHeader
    Public Sub New()
    End Sub

    Public Sub New(ByVal text As String)
        text = text
    End Sub

    Public Sub New(ByVal text As String, ByVal width As Integer)
        text = text
        _width = width
    End Sub

    Public Property Text As String
    Private _width As Integer = 60

    Public Property Width As Integer
        Get
            Return _width
        End Get
        Set(ByVal value As Integer)
            _width = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class

<DefaultEvent("Scroll")>
Class LoyalScrollBar
    Inherits Control

    Public Delegate Sub ScrollEventHandler(ByVal sender As Object)
    Public Event Scroll As ScrollEventHandler
    Private buttonSize As Integer = 16
    Private thumbSize As Integer = 24
    Private TSA As Rectangle
    Private BSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private _showThumb As Boolean
    Private _thumbDown As Boolean
    Private I1 As Integer
    Private _minimum As Integer

    Public Property Minimum As Integer
        Get
            Return _minimum
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then Throw New Exception("Property value is not valid.")
            _minimum = value
            If value > _value Then _value = value
            If value > _maximum Then _maximum = value
            InvalidateLayout()
        End Set
    End Property

    Private _maximum As Integer = 100

    Public Property Maximum As Integer
        Get
            Return _maximum
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then value = 1
            _maximum = value
            If value < _value Then _value = value
            If value < _minimum Then _minimum = value
            InvalidateLayout()
        End Set
    End Property

    Private _value As Integer

    Public Property Value As Integer
        Get
            If Not _showThumb Then Return _minimum
            Return _value
        End Get
        Set(ByVal value As Integer)
            If value = _value Then Return
            If value > _maximum OrElse value < _minimum Then Throw New Exception("Property value is not valid.")
            _value = value
            InvalidatePosition()
            ' If Scroll IsNot Nothing Then
            '  Scroll.Invoke(Me)
            ' End If


        End Set
    End Property

    Public ReadOnly Property Percent As Double
        Get
            If Not _showThumb Then Return 0
            Return GetProgress()
        End Get
    End Property

    Private _smallChange As Integer = 1

    Public Property SmallChange As Integer
        Get
            Return _smallChange
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then Throw New Exception("Property value is not valid.")
            _smallChange = value
        End Set
    End Property

    Private _largeChange As Integer = 10

    Public Property LargeChange As Integer
        Get
            Return _largeChange
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then Throw New Exception("Property value is not valid.")
            _largeChange = value
        End Set
    End Property

    Private _backColor As Color = Color.FromArgb(31, 31, 31)

    <Category("Colors")>
    Public Overrides Property BackColor As Color
        Get
            Return _backColor
        End Get
        Set(ByVal value As Color)
            _backColor = value
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

    Private _scrollColor As Color = Color.FromArgb(41, 41, 41)

    <Category("Colors")>
    Public Property ScrollColor As Color
        Get
            Return _scrollColor
        End Get
        Set(ByVal value As Color)
            _scrollColor = value
            Invalidate()
        End Set
    End Property

    Private _borderColor As Color = Color.FromArgb(18, 18, 18)

    <Category("Colors")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    Private Sub InvalidateLayout()
        TSA = New Rectangle(0, 0, Width, buttonSize)
        BSA = New Rectangle(0, Height - buttonSize, Width, buttonSize)
        Shaft = New Rectangle(0, TSA.Bottom + 1, Width, Height - (buttonSize * 2) - 1)
        _showThumb = ((_maximum - _minimum) > Shaft.Height)
        If _showThumb Then Thumb = New Rectangle(1, 0, Width - 3, thumbSize)
        ' If Scroll IsNot Nothing Then Scroll.Invoke(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.Y = System.Convert.ToInt32(GetProgress() * (Shaft.Height - thumbSize)) + TSA.Height
        Invalidate()
    End Sub

    Private Function GetProgress() As Double
        Return (_value - _minimum) / CDbl((_maximum - _minimum))
    End Function

    Private Function DrawArrow(ByVal x As Integer, ByVal y As Integer, ByVal flip As Boolean) As GraphicsPath
        Dim gp As GraphicsPath = New GraphicsPath()
        Dim W As Integer = 9
        Dim H As Integer = 5

        If flip Then
            gp.AddLine(x + 1, y, x + W + 1, y)
            gp.AddLine(x + W, y, x + H, y + H - 1)
        Else
            gp.AddLine(x, y + H, x + W, y + H)
            gp.AddLine(x + W, y + H, x + H, y)
        End If

        gp.CloseFigure()
        Return gp
    End Function

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        InvalidateLayout()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left AndAlso _showThumb Then

            If TSA.Contains(e.Location) Then
                I1 = _value - _smallChange
            ElseIf BSA.Contains(e.Location) Then
                I1 = _value + _smallChange
            ElseIf Thumb.Contains(e.Location) Then
                _thumbDown = True
                MyBase.OnMouseDown(e)
                Return
            ElseIf e.Y < Thumb.Y Then
                I1 = _value - _largeChange
            Else
                I1 = _value + _largeChange
            End If

            _value = Math.Min(Math.Max(I1, _minimum), _maximum)
            InvalidatePosition()
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If _thumbDown AndAlso _showThumb Then
            Dim ThumbPosition As Integer = e.Y - TSA.Height - (thumbSize / 2)
            Dim ThumbBounds As Integer = Shaft.Height - thumbSize
            I1 = System.Convert.ToInt32((ThumbPosition / CDbl(ThumbBounds)) * (_maximum - _minimum)) + _minimum
            _value = Math.Min(Math.Max(I1, _minimum), _maximum)
            InvalidatePosition()
        End If

        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        _thumbDown = False
        MyBase.OnMouseUp(e)
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.Selectable, False)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Width = 19
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics

        If True Then
            g.Clear(_backColor)
            Dim gp1 As GraphicsPath = DrawArrow(4, 6, False)
            Dim gp2 As GraphicsPath = DrawArrow(4, Height - 10, True)
            g.FillPath(New SolidBrush(_arrowColor), gp1)
            g.FillPath(New SolidBrush(_arrowColor), gp2)

            If _showThumb Then
                g.FillRectangle(New SolidBrush(_scrollColor), Thumb)
                g.DrawRectangle(New Pen(_borderColor), Thumb)
                Dim y As Integer
                Dim ly As Integer = Thumb.Y + (Thumb.Height / 2) - 3

                For i As Integer = 0 To 3 - 1
                    y = ly + (i * 3)
                    g.DrawLine(New Pen(_borderColor), Thumb.X + 5, y, Thumb.Right - 5, y)
                Next
            End If

            g.DrawRectangle(New Pen(_borderColor), 0, 0, Width - 1, Height - 1)
            g.FillRectangle(New SolidBrush(Parent.BackColor), Width - 1, Height - 1, 1, 1)
            g.FillRectangle(New SolidBrush(Parent.BackColor), Width - 1, 0, 1, 1)
        End If
    End Sub
End Class

Class LoyalListView
    Inherits Control

    Private _columnOffsets As Integer()
    Private _VS As LoyalScrollBar
    Private _down As Boolean = False
    Private _itemHeight As Integer = 24
    Private _items As List(Of LoyalListViewItem) = New List(Of LoyalListViewItem)()

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("Content")>
    Public Property Items As LoyalListViewItem()
        Get
            Return _items.ToArray()
        End Get
        Set(ByVal value As LoyalListViewItem())
            _items = New List(Of LoyalListViewItem)(value)
            InvalidateScroll()
        End Set
    End Property

    Private _selectedItems As List(Of LoyalListViewItem) = New List(Of LoyalListViewItem)()

    <Category("Content")>
    Public ReadOnly Property SelectedItems As LoyalListViewItem()
        Get
            Return _selectedItems.ToArray()
        End Get
    End Property

    Private _columns As List(Of LoyalListViewColumnHeader) = New List(Of LoyalListViewColumnHeader)()

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("Content")>
    Public Property Columns As LoyalListViewColumnHeader()
        Get
            Return _columns.ToArray()
        End Get
        Set(ByVal value As LoyalListViewColumnHeader())
            _columns = New List(Of LoyalListViewColumnHeader)(value)
            InvalidateColumns()
        End Set
    End Property

    Private _multiSelect As Boolean = True

    Public Property Multiselect As Boolean
        Get
            Return _multiSelect
        End Get
        Set(ByVal value As Boolean)
            _multiSelect = value
            If _selectedItems.Count > 1 Then _selectedItems.RemoveRange(1, _selectedItems.Count)
            Invalidate()
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            _itemHeight = Convert.ToInt32(Graphics.FromHwnd(Handle).MeasureString("@", Font).Height) + 6

            If _VS IsNot Nothing Then
                _VS.SmallChange = _itemHeight
                _VS.LargeChange = _itemHeight
            End If

            MyBase.Font = value
            InvalidateLayout()
        End Set
    End Property

    Private _headerColor As Color = Color.FromArgb(102, 51, 153)

    <Category("Colors")>
    Public Property HeaderColor As Color
        Get
            Return _headerColor
        End Get
        Set(ByVal value As Color)
            _headerColor = value
            _VS.ScrollColor = _headerColor
            _VS.ArrowColor = _headerColor
            Invalidate()
        End Set
    End Property

    Private _backColor As Color = Color.FromArgb(40, 40, 40)

    <Category("Colors")>
    Public Overrides Property BackColor As Color
        Get
            Return _backColor
        End Get
        Set(ByVal value As Color)
            _backColor = value
            Invalidate()
        End Set
    End Property

    Private _borderColor As Color = Color.FromArgb(18, 18, 18)

    <Category("Colors")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            _VS.BorderColor = _borderColor
            Invalidate()
        End Set
    End Property

    Private _itemColor As Color = Color.FromArgb(50, 50, 50)

    <Category("Colors")>
    Public Property ItemColor As Color
        Get
            Return _itemColor
        End Get
        Set(ByVal value As Color)
            _itemColor = value
            Invalidate()
        End Set
    End Property

    Private _selectedItemColor As Color = Color.FromArgb(65, 65, 65)

    <Category("Colors")>
    Public Property SelectedItemColor As Color
        Get
            Return _selectedItemColor
        End Get
        Set(ByVal value As Color)
            _selectedItemColor = value
            Invalidate()
        End Set
    End Property

    Private _scrollBarBackColor As Color = Color.FromArgb(31, 31, 31)

    <Category("Colors")>
    Public Property ScrollBarBackColor As Color
        Get
            Return _scrollBarBackColor
        End Get
        Set(ByVal value As Color)
            _scrollBarBackColor = value
            _VS.BackColor = _scrollBarBackColor
            Invalidate()
        End Set
    End Property

    Private _foreColor As Color = Color.White

    <Category("Colors")>
    Public Overrides Property ForeColor As Color
        Get
            Return _foreColor
        End Get
        Set(ByVal value As Color)
            _foreColor = value
            Invalidate()
        End Set
    End Property

    Private Sub InvalidateScroll()
        _VS.Maximum = (_items.Count * 24)
        Invalidate()
    End Sub

    Private Sub InvalidateColumns()
        Dim width As Integer = 3
        _columnOffsets = New Integer(_columns.Count - 1) {}

        For i As Integer = 0 To _columns.Count - 1
            _columnOffsets(i) = width
            width += Columns(i).Width
        Next

        Invalidate()
    End Sub

    Private Sub InvalidateLayout()
        _VS.Location = New Point(Width - _VS.Width, 0)
        _VS.Size = New Size(19, Height)
        InvalidateScroll()
    End Sub

    Private Sub HandleScroll(ByVal sender As Object)
        Invalidate()
    End Sub

    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        _VS = New LoyalScrollBar()
        _VS.LargeChange = _itemHeight
        _VS.SmallChange = _itemHeight
        AddHandler _VS.Scroll, AddressOf HandleScroll
        '_VS.MouseDown += AddressOf _VS_MouseDown
        '_VS.MouseMove += AddressOf _VS_MouseMove
        ' _VS.MouseUp += AddressOf _VS_MouseUp
        _VS.ScrollColor = _headerColor
        _VS.BorderColor = _borderColor
        _VS.ArrowColor = _headerColor
        _VS.BackColor = _scrollBarBackColor
        Size = New Size(150, 75)
        Font = New Font("Segoe UI", 8.25F)
        Controls.Add(_VS)
        InvalidateLayout()
    End Sub

    Private Sub _VS_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        _down = False
    End Sub

    Private Sub _VS_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If _down Then Invalidate()
    End Sub

    Private Sub _VS_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        _down = True
        Focus()
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        ' Dim move As Integer = -((e.Delta * SystemInformation.MouseWheelScrollLines / 120) * (24 / 2))
        ' Dim value As Integer = Math.Max(Math.Min(_VS.Value + move, _VS.Maximum), _VS.Minimum)
        ' _VS.Value = value
       ' MyBase.OnMouseWheel(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Focus()

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim offset As Integer = Convert.ToInt32(_VS.Percent * (_VS.Maximum - (Height - (24 * 2))))
            Dim index As Integer = ((e.Y + offset - 24) / 24)
            If index > _items.Count - 1 Then index = -1

            If index > -1 Then

                If ModifierKeys = Keys.Control AndAlso _multiSelect Then

                    If _selectedItems.Contains(_items(index)) Then
                        _selectedItems.Remove(_items(index))
                    Else
                        _selectedItems.Add(_items(index))
                    End If
                Else
                    _selectedItems.Clear()
                    _selectedItems.Add(_items(index))
                End If
            End If

            Invalidate()
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        InvalidateLayout()
        MyBase.OnSizeChanged(e)
    End Sub

    Public Sub AddItem(ByVal text As String, ByVal subitems As String())
        Dim items As List(Of LoyalListViewSubItem) = New List(Of LoyalListViewSubItem)()

        For Each item As String In subitems
            Dim si As LoyalListViewSubItem = New LoyalListViewSubItem(item)
            items.Add(si)
        Next

        Dim lvi As LoyalListViewItem = New LoyalListViewItem(text, items)
        _items.Add(lvi)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItemAt(ByVal index As Integer)
        _items.RemoveAt(index)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItem(ByVal lvi As LoyalListViewItem)
        _items.Remove(lvi)
        InvalidateScroll()
    End Sub

    Public Sub RemoveItems(ByVal lvis As LoyalListViewItem())
        For Each lvi As LoyalListViewItem In lvis
            _items.Remove(lvi)
        Next

        InvalidateScroll()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.Clear(_backColor)
        Dim startIndex As Integer
        Dim offset As Integer = Convert.ToInt32(_VS.Percent * (_VS.Maximum - (Height - (_itemHeight * 2))))

        If offset = 0 Then
            startIndex = 0
        Else
            startIndex = (offset / _itemHeight)
        End If

        Dim endIndex As Integer = Math.Min(startIndex + (Height / _itemHeight), _items.Count)

        For i As Integer = startIndex To endIndex - 1
            Dim ci As LoyalListViewItem = _items(i)
            Dim r As Rectangle = New Rectangle(0, 24 + (i * 24) - offset, Width, 24)
            Dim h As Integer = Convert.ToInt32(g.MeasureString(ci.Text, Font).Height)
            Dim y As Integer = r.Y + Convert.ToInt32((24 / 2) - (h / 2))

            If _selectedItems.Contains(ci) Then
                g.FillRectangle(New SolidBrush(_selectedItemColor), r)
            Else
                g.FillRectangle(New SolidBrush(_itemColor), r)
            End If

            g.DrawRectangle(New Pen(_borderColor), r)

            If _columns.Count > 0 Then
                r.Width = _columns(0).Width
                g.SetClip(r)
            End If

            g.DrawString(ci.Text, Font, New SolidBrush(_foreColor), 4, y + 1)

            If ci.SubItems.Count > 0 Then

                For i2 As Integer = 0 To Math.Min(ci.SubItems.Count, _columns.Count) - 1
                    Dim x As Integer = _columnOffsets(i2 + 1)
                    r.X = x
                    r.Width = _columns(i2).Width
                    g.SetClip(r)
                    g.DrawString(ci.SubItems(i2).Text, Font, New SolidBrush(_foreColor), x + 1, y + 1)
                Next
            End If

            g.ResetClip()
        Next

        Dim r2 As Rectangle = New Rectangle(0, 0, Width, 24)
        g.FillRectangle(New SolidBrush(_headerColor), r2)
        Dim lh As Integer = Math.Min(_VS.Maximum + _itemHeight - offset + 2, Height)
        Dim cc As LoyalListViewColumnHeader

        For i As Integer = 0 To _columns.Count - 1
            cc = _columns(i)
            Dim h As Integer = Convert.ToInt32(g.MeasureString(cc.Text, Font).Height)
            Dim y As Integer = Convert.ToInt32((24 / 2) - (h / 2))
            Dim x As Integer = _columnOffsets(i)
            g.DrawString(cc.Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), New SolidBrush(_foreColor), x + 1, y + 1)
            g.DrawLine(New Pen(_borderColor), x - 3, 0, x - 3, lh)
        Next

        g.DrawRectangle(New Pen(_borderColor), 0, 0, Width - 1, Height - 1)
        g.DrawLine(New Pen(Color.FromArgb(30, Color.White)), 0, 1, Width, 1)
        g.DrawLine(New Pen(Color.FromArgb(70, Color.Black)), 0, 23, Width, 23)
        g.DrawLine(New Pen(_borderColor), 0, 24, Width, 24)
        g.FillRectangle(New SolidBrush(_backColor), Width - 19, 0, Width, Height)
        g.FillRectangle(New SolidBrush(Parent.BackColor), 0, 0, 1, 1)
        g.FillRectangle(New SolidBrush(Parent.BackColor), 0, Height - 1, 1, 1)
    End Sub
End Class

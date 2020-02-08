' ***********************************************************************
' Author   : Elektro
' Modified : 02-April-2017
' ***********************************************************************

#Region " Public Members Summary "

#Region " Constructors "

' New(String)
' New(FileInfo)
' New(Image)

#End Region

#Region " Properties "

' Image As Image
' FrameCount As Integer
' Frames(Integer) As Bitmap
' ActiveFrame As Bitmap
' ActiveFrameIndex As Integer
' EndOfFrames As Boolean

#End Region

#Region " Functions "

' NextFrame() As Bitmap
' GetFrames() As List(Of Bitmap)

#End Region

#End Region

#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

#End Region

#Region " GIF "

''' ----------------------------------------------------------------------------------------------------
''' <summary>
''' Represents a GIF image.
''' </summary>
''' ----------------------------------------------------------------------------------------------------
Public Class GIF

#Region " Properties "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets the GIF image.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <value>
    ''' The GIF image.
    ''' </value>
    ''' ----------------------------------------------------------------------------------------------------
    Public Shared Image As Image

    Public Shared FrameCount As Integer


    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets the frame at the specified index.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <value>
    ''' The frame index.
    ''' </value>
    ''' ----------------------------------------------------------------------------------------------------
    Default Public Overridable ReadOnly Property Frames(ByVal index As Integer) As Bitmap
        <DebuggerStepperBoundary>
        Get
            Using img As Image = DirectCast(Me.Image.Clone(), Image)
                img.SelectActiveFrame(FrameDimension.Time, index)
                Return New Bitmap(img) ' Deep copy of the frame (only the frame).
            End Using
        End Get
    End Property

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets the active frame.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <value>
    ''' The active frame.
    ''' </value>
    ''' ----------------------------------------------------------------------------------------------------
    Public Overridable ReadOnly Property ActiveFrame As Bitmap
        <DebuggerStepperBoundary>
        Get
            Return New Bitmap(Me.Image) ' Deep copy of the frame (only the frame).
        End Get
    End Property

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets the index in the frame count of the current active frame.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <value>
    ''' The index in the frame count of the current active frame.
    ''' </value>
    ''' ----------------------------------------------------------------------------------------------------
    Public Property ActiveFrameIndex As Integer
        <DebuggerStepThrough>
        Get
            Return Me.activeFrameIndexB
        End Get
        <DebuggerStepperBoundary>
        Set(ByVal value As Integer)
            If (value <> Me.activeFrameIndexB) Then
                Me.Image.SelectActiveFrame(FrameDimension.Time, value)
                Me.activeFrameIndexB = value
                Me.eof = (value = Me.FrameCount)
            End If
        End Set
    End Property
    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' ( Backing Field )
    ''' The index in the frame count of the current active frame.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Private activeFrameIndexB As Integer

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets a value indicating whether the frame count is at EOF, 
    ''' this means there is no more frames to advance in the GIF image.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <value>
    ''' <see langword="True"/> if there is no more frames to advance in the GIF image; otherwise, <see langword="False"/>.
    ''' </value>
    ''' ----------------------------------------------------------------------------------------------------
    Public ReadOnly Property EndOfFrames As Boolean
        <DebuggerStepThrough>
        Get
            Return Me.eof
        End Get
    End Property
    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' ( Backing Field )
    ''' A value indicating whether the frame count is at EOF, 
    ''' this means there is no more frames to advance in the GIF image.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Private eof As Boolean

#End Region

#Region " Constructors "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Prevents a default instance of the <see cref="GIF"/> class from being created.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerNonUserCode>
    Private Sub New()
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Initializes a new instance of the <see cref="GIF"/> class.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="filepath">
    ''' The filepath.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    Public Sub New(ByVal filepath As String)

        Me.New(Image.FromFile(filepath))

    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Initializes a new instance of the <see cref="GIF"/> class.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="file">
    ''' The image file.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    Public Sub New(ByVal file As FileInfo)

        Me.New(Image.FromFile(file.FullName))

    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Initializes a new instance of the <see cref="GIF"/> class.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="img">
    ''' The image.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    Public Sub New(ByVal img As Image)

        Me.Image = img
        Me.FrameCount = Me.Image.GetFrameCount(FrameDimension.Time)

    End Sub

#End Region

#Region " Public Methods "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Advances one position in the frame count and returns the next frame.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <returns>
    ''' The next frame.
    ''' </returns>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    Public Overridable Function NextFrame() As Bitmap

        If (Me.eof) Then
            Throw New IndexOutOfRangeException()

        Else
            Dim frame As Bitmap = Me.Frames(Me.activeFrameIndexB)
            Me.activeFrameIndexB += 1
            Me.eof = (Me.activeFrameIndexB >= Me.FrameCount)
            Return frame

        End If

    End Function

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets a <see cref="List(Of Bitmap)"/> containing all the frames in the image.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <returns>
    ''' A <see cref="List(Of Bitmap)"/> containing all the frames in the image.
    ''' </returns>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    Public Overridable Function GetFrames() As List(Of Bitmap)

        Using img As Image = DirectCast(Me.Image.Clone(), Image)
            Return GetFramesFromImage(img)
        End Using

    End Function

#End Region

#Region " Private Methods "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets a <see cref="List(Of Bitmap)"/> containing all the frames in the source GIF image.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="img">
    ''' The source <see cref="Image"/>.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <returns>
    ''' The resulting percentage difference value between the two specified images.
    ''' </returns>
    ''' ----------------------------------------------------------------------------------------------------
    Private Shared Function GetFramesFromImage(ByVal img As Image) As List(Of Bitmap)

        Dim imgs As New List(Of Bitmap)
        Dim frameCount As Integer = img.GetFrameCount(FrameDimension.Time)

        For i As Integer = 0 To (frameCount - 1)
            img.SelectActiveFrame(FrameDimension.Time, i)
            imgs.Add(New Bitmap(img)) ' Deep copy of the frame (only the frame).
        Next

        Return imgs

    End Function

#End Region

End Class

#End Region
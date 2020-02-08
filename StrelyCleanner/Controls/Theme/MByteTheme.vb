Imports System.Drawing.Drawing2D

Module MalwarePB

    Public Enum ProgressType As Byte
        Min = 0
        Progressing = 1
        Max = 2
    End Enum

    Public Function CodeToImage(ByVal Code As String) As Image
        Return Image.FromStream(New System.IO.MemoryStream(Convert.FromBase64String(Code)))
    End Function

    Public Function GetBase64StringIcon(ByVal prog As ProgressType) As String

        If prog = ProgressType.Min Then
            Return "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAC6UlEQVRYhc3XMYhcVRQG4G8fi4QtQrCw2iJVsNxiiAbLrFtYBES49XaSTrPFZguLaLFJsatdSGd9QQSRhWw2lYjJMoQtxUK2WCwsJKQIIjJY3PNmxsmbmTtCWH8YuPe8c89/5tz7zv3fkkrknC9gHdexhsu4GI9f4BQneIyjlNKfNXGXKohXsYVNXKrM9zm+xl5K6ew/JZBzXsZt7GBl7NFL9PEL/gjbm7iCXofvLu6mlP6uTiD+9Te4GqYBDvAAhymlv6asewMb+BgfoIlHx/ioqxqvJJBzfhuPsBqmPm6mlPpdpNOQc+7hvlIVOMP7KaWfx/2aiUWrE+T7uLYoOcSaaxFDxHwUHEMMKxB7/qNR2bdSSvumIOf8Lr6I6WcppSczfG9hL6bHeK89E+MVuD1Gvj+H/C08VF7LdTwMWyciVhvvanAZJhBl2QlbH9vTggVuGPUAMb4xZ812xIaddivaCmwpr89AOXCdr8wEYY1tiIh5MzhWglMTHW4z/A4qD1xXl5vb+SL2QUw3c84XGmUP2w73oIKcUQOaZ+tCy3EJ643S2yld67AyyO+Vti4cBhdcb5SLBfrTOlwHfqu0vYLgaLd5rVFuNUpvr8WpcphaDMJWi5brcmN0emv3UFy144SntdfvBNfFZqbbbJxMGS+ERhETlCt1EfwwZVyDlutFY1TKKwsG+U7Z+0GMF0HLddoYla8X93kVUkq/4g7uxLgKwdFe0SfLiob7RGmPG/h+gSQ+r/Udw4aRanrc4EjRcBQl87rRcjzH0RLknL9UqjDAOzX3Qc55Bd/G9MOU0stZ/rGmh6fK4f8qpfRp+xruKe2xwf0QJ/OwppRzw6ibziJfViRaE1x7YiLE4m749nCvIoHJTjgP94wO324rUMcb0V1FLsGtkFGz8Aw5fs9mOUasNt5xcGFCFYdK+cm/Rel2hUCZRrys/POW/EwRuUN5fu6y/P/3YTIW7Pw+zSYSOZ+P045EXsvn+T/nYyK/KE7IRwAAAABJRU5ErkJggg=="
        ElseIf prog = ProgressType.Progressing Then
            '            Return "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAADLklEQVRYhbXXX2gdRRgF8F8uFwnS
            'h5ItUXwQkT5YkFJs0bL+K5SoSCnkQYUFRUUsiFJ8EvGhD7UUK6WCIBTqgwrrH0QQxBZstIIuWFSC
            'FAkFawghiHRLCSWESwg+zK5s996bbMK952mZmf3OmW9mznwzoiGSLGrjIUzgPtyNrWhhEbOYxg84
            'n8b5cpO4Iw2It+E1vIQ7Guq9jo/xbhrn85sSkGRRC6/gqDDTzWAZJ3AsjfNOYwFJFm3Fp3hik8R1
            '/I7JNM7n1hWQZNE4pnDvgMhLzGMijfOZvgKKmf+InQMmL7GAB9M4ny0bWhXyFj4ZIjlhE3+dZNFo
            '2dCudL6MAw0DreIS/sA1bCmC78G2df7diSN4k2IJitT/hbF1fp7HKaRpnP9T7yyy+AgO46BKhmvo
            'YEca51fKDLzag/xXYUblD8dwYi2DSeN8FRdwIcmiffgId/YYegvewKGRQvXfPQbuwDuFiMk0zi/2
            'I+6H4kSdFZyzjiXc1ioIeqns4Cns3gw5pHH+Lx4XbLqOW3GgjX1rBOiga61LJFl0jzCBUaxgBheL
            'pShjXE2y6FnheNf3xP42djeYTJ34fmEzxj26Z5MsOo4zpZA0zn9KsuhLPF0bu6uFuzZI/hx+7kOu
            'iHcaZ5Ms2lJpf7/X2JaNXzSTbvaPfngMnxebHDLBM6po9zuna+EZfNNw7JOKtBfL8Wd9QFsoJnrh
            'VJJFN/r0LQtu2GQCh/BZ8V3n6rSFI7JHNw42CN4Ee5MsaqdxviKclirmWvhtQET9MCrcFbC91jfd
            'wvdDFrCCpSSLtus2vKmW4PmzQxRwuTC0F2rtS/i2VezO00MUcC7JojGhvqziizTOF8td/AGuDoF8
            'FR/ipJv9poPjFMcojfNFvDUEAV9hL56vtb+Xxvnl/wUUOINzAyS/gV90L+8loSJCd1E6Jtxag6iI
            'p4s4VdtewMNpnF/pKaAQcTu+G5CIKhawv16Wd1lpUes9ivMDJJ8WyvGZekdPL0/j/JpQyRzW/65o
            'gmW8jQeqb4EqmjxOx/E6XsR4Q+LycXqy13NsQwIqQtpCyT2BXcLzfEzI4nXMCamesoHn+X9QwPJf
            '/5GEeQAAAABJRU5ErkJggg=="

            Return "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAADDElEQVRYhbWXT0hVQRTGf0qIiIQ0Ei5cRFQLkwyLFgMlBUEFgWiWDBUUCekmiooiQlpIBdE/KioSWtgsKoogahNEUIOFi1rkIlqkSEQ4IhEiEtJirjrMm2vvXV/f6t0zc873vbnnnnOmhIxQRqwB9gHdWtqJrHFKszoC5cBx4LMyYkfWICVZnJQRFUAz8MAzPwSOamm//xcByogaYD/QCjQCiyLbxoHTwF0t7XRRBCgjKoFzQBfu2PPBW+CAlvbrvzbG/oVP3gg8ApbnSTyDH0BeiZmahMqILcCbAsmHgZ1a2jY/F5QRVQUJUEasBZ4BlZHlUeAW0O3Z/gCXgdVa2udBrF3AkDJCxrhyciDJ8E/AimBpEpcL17W0E8qIDcB7oB/o1NJ+jMQ6DNzE/dERoEFLO+bvieXA2Qj5KLBdSzvg2caBTlIyXhnRlZDPoBboSXxmURI4VQNDQIVnngKatLT9EbGpUEbU4U7If41TwEot7fCMIcyBvQE5QE+h5ABa2kHgTGAuAzp8QyigNXgeAy4VSu7hNu7d+2iOClBGlAEbgs1PFtJotLRTgA7MdcqIJTkCgGW4I/LxLiv5PDFKgVUxAdUR5/D4siAWY5ZrIe24KPAFjEbWa4vAEYsxy+UL+Iardj42FkFAU8T2JUdAkrHh996StONMSL6s3YF50C/HYQ48DZ6rgBNZBeBmiPAVPPYfQgF9wO/Adiqtk82HpKP2BOYpoDdVQHI0VwOnMmBTCkmpMuKgMmJ9YG8EXpJb1u/5fSBHQILzzCXJNG7QvBAhr8cNLL0k37UyolwZcRJXfGoClxFye0N8Jkxm/tfAES1tX7BWgWvZx5irnDeS3y3EC9oksDnW1FKHUmXEYi3tr8C2DdfjCxnTJoA2Le2L2GJeY7kyYilwDWgvgBhcbdmjpf2QtiHfUlxKfD5MwyRuRmyYjxwKvBkpI9qBK+QmGLjBdABXS+5raX/mE7Pgq1kyYl8EDjF3gh2AzjI7ZLobJkIkcAeoB7ZqaV9liZO5HWtpDbAOdxfMPDX9Ba4m4yf9OQ8TAAAAAElFTkSuQmCC"
        Else
            Return "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAC5ElEQVRYhbXXTYgcRRjG8d80yxJCkJCWsIJgCB70IkEDYkdCcJWIJ0E82DEEQTSKiDGnCB4kfoEYEBUxF9FDiV4UDx78FrS8LDKoiEgMS/QQAg2yhGVZluChunEy6Z3pncw+l6G6uuf/9Ftdb71vT0eVMZ/F3bgHt2I3tmEVyziPBXyNL0JRLXf5314H8E4cx6PY0dHvEj7Aa6Gozk1koIz5DJ7B87imI3hYKziFk6GoVjobKGM+h4+wf0LwsPp4IBTV2bEGypjvxpfSGk9TF3AwFFV/XQP1ev+0CfBBE3cMRiIbgGf4cBPhsBOflDHfcoUBPIW7NhHe6Ba80Ax6UMZ8B/7C9ilBLuJPKV+0aRU3h6I620Tg2BThcAi34bCUE4Y1ixPQq/f735ibEvx0KKrHm0EZ8+fwUst9y7guw51ThJ+RsmYD3yJFoU1bcV+G+SnBL+GRUFQXB66dxE0jnpnPsHdKBk6FovqhGZQxL6RUPkp7Mlw/Bfjv0pnRwLfifcyMeW5XJq3F1WgNR4YOm1dwY4dnZzJp7cbpM9yAT1vmXg5FtdAMypgfkJJaJ2XSkTlK30gn2Tk8iI8H5n6WPrQGvg3vuTzDjtJahn/G3PRHKKo1qH8PIdTGjzRztV7Hro5wWMykMmqUjpYxf7IZ1MDD0tH6W3O9jPm9UtW0EfV7Zcz34/sxN17CE6GoTrdNljHfjl9tfEc9lCFKBeUoZXinjPlj68y/OQF8GZ9ndUhb32wdE0cHL5Yxvx8PbxAOIRTVUvO1voF/O5p4u4z5szV8Du9OAF+VcsX/JVkZ86drI121IIV9koPs1VBUJ7h8v74l7fmu2jshvG+4ImpUF6U/6pZGJ9F57GstSiEU1QWp9TqzSfCDw73BFSkzFNUi9uG7KcL70pv/MjzRmrPrSMxL1U1bTddVK3gRt7d1RXRvTo9JafbajuCrb05bjMzigPSN7JEamKaSXsKiFOpv8VXX9vw/9LbblYIHwywAAAAASUVORK5CYII="
        End If

    End Function

End Module

Public Class Progress
    Inherits Control

    Private _Val As Integer = 0
    Private _Min As Integer = 0
    Private _Max As Integer = 100

    Public Property HideLoading As Boolean = False

    Public Property Value As Integer
        Get
            Return _Val
        End Get
        Set(ByVal value As Integer)
            _Val = value
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Integer
        Get
            Return _Min
        End Get
        Set(ByVal value As Integer)
            _Min = value
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return _Max
        End Get
        Set(ByVal value As Integer)
            _Max = value
            Invalidate()
        End Set
    End Property


    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality

        MyBase.OnPaint(e)

        G.Clear(Parent.BackColor)

        If Not HideLoading Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(180, 180, 180)), New Rectangle(31, 13, Width - 1, 3))
        End If

        If Value = Minimum Then
            G.DrawImage(CodeToImage(GetBase64StringIcon(ProgressType.Min)), New Point(0, 0))

            If Not HideLoading Then
                G.FillRectangle(New SolidBrush(Color.FromArgb(180, 180, 180)), New Rectangle(31, 13, CInt(Value / Maximum * Width - 32), 3))
            End If

        ElseIf Not Value = Maximum And Not Value = Minimum Then
            G.DrawImage(CodeToImage(GetBase64StringIcon(ProgressType.Progressing)), New Point(0, 0))

            If Not HideLoading Then
                G.FillRectangle(New SolidBrush(Color.FromArgb(90, 198, 19)), New Rectangle(31, 13, CInt(Value / Maximum * Width - 32), 3))
            End If

        ElseIf Value >= Maximum Then
            G.DrawImage(CodeToImage(GetBase64StringIcon(ProgressType.Max)), New Point(0, 0))

            If Not HideLoading Then
                G.FillRectangle(New SolidBrush(Color.FromArgb(90, 198, 19)), New Rectangle(31, 13, CInt(Value / Maximum * Width - 32), 3))
            End If

        End If

    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        Size = New Point(Width, 32)
    End Sub

End Class
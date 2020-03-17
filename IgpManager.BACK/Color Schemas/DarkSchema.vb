Option Strict On
Imports System.Drawing

Public Class DarkSchema
    Inherits ColorSchemaManager

    Private oResMgr As System.Resources.ResourceManager

    Public Sub New()
        oResMgr = New System.Resources.ResourceManager("eboc.BACK.ColorSchemas", Me.GetType().Assembly())
    End Sub

    Public Overrides ReadOnly Property Background() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(50, 50, 50)
        End Get
    End Property

    Public Overrides ReadOnly Property Foreground() As System.Drawing.Color
        Get
            Return Drawing.Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property BackgroundFocused() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(70, 70, 70)
        End Get
    End Property

    Public Overrides ReadOnly Property HeaderBackground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(104, 104, 104)
        End Get
    End Property

    Public Overrides ReadOnly Property HeaderForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightBackground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(132, 159, 180)
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightBackgroundOff() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(102, 119, 140)
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightForegroundOff() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property FlatBorder() As Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property ScrollbarColor() As System.Drawing.Color
        Get
            Return Drawing.Color.DarkGray
        End Get
    End Property

    Public Overrides ReadOnly Property FocusCellBackground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(152, 185, 210)
        End Get
    End Property

    Public Overrides ReadOnly Property FocusCellForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property SeatsCursorColor() As System.Drawing.Color
        Get
            Return Drawing.Color.WhiteSmoke
        End Get
    End Property

    Public Overrides ReadOnly Property MenuSelected() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(145, 105, 112)
        End Get
    End Property

    Public Overrides Function GetImage(ByVal sId As String) As System.Drawing.Image
        Return DirectCast(oResMgr.GetObject("DRK_" & sId), Image)
    End Function

    Public Overrides ReadOnly Property MenuForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(217, 217, 217)
        End Get
    End Property

End Class

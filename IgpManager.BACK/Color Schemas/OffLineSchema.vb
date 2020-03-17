Option Strict On
Imports System.Drawing

Public Class OffLineSchema
    Inherits ColorSchemaManager

    Private oResMgr As System.Resources.ResourceManager

    Public Sub New()
        oResMgr = New System.Resources.ResourceManager("eboc.BACK.ColorSchemas", Me.GetType().Assembly())
    End Sub

    Public Overrides ReadOnly Property Background() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(252, 249, 242)  ' (255, 254, 249)
        End Get
    End Property

    Public Overrides ReadOnly Property Foreground() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property BackgroundFocused() As Drawing.Color
        Get
            Return Drawing.Color.FromKnownColor(Drawing.KnownColor.White)   '.FromArgb(247, 247, 239)
        End Get
    End Property

    Public Overrides ReadOnly Property HeaderBackground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(233, 229, 217)
        End Get
    End Property

    Public Overrides ReadOnly Property HeaderForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightBackground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(255, 240, 194)
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightBackgroundOff() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(255, 247, 216)
        End Get
    End Property

    Public Overrides ReadOnly Property HighlightForegroundOff() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property FlatBorder() As Drawing.Color
        Get
            Return Drawing.Color.FromArgb(221, 217, 205)
        End Get
    End Property

    Public Overrides ReadOnly Property ScrollbarColor() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(233, 229, 217)
        End Get
    End Property

    Public Overrides ReadOnly Property FocusCellBackground() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(255, 247, 216)
        End Get
    End Property

    Public Overrides ReadOnly Property FocusCellForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property SeatsCursorColor() As System.Drawing.Color
        Get
            Return Drawing.Color.Gray
        End Get
    End Property

    Public Overrides ReadOnly Property MenuSelected() As System.Drawing.Color
        Get
            Return Drawing.Color.FromArgb(255, 240, 194)
        End Get
    End Property

    Public Overrides Function GetImage(ByVal sId As String) As System.Drawing.Image
        Return DirectCast(oResMgr.GetObject("OFF_" & sId), Image)
    End Function

    Public Overrides ReadOnly Property MenuForeground() As System.Drawing.Color
        Get
            Return Drawing.Color.Black
        End Get
    End Property
End Class

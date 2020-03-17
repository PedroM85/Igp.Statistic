Public MustInherit Class ColorSchemaManager

    Public MustOverride ReadOnly Property Background() As Drawing.Color
    Public MustOverride ReadOnly Property Foreground() As Drawing.Color
    Public MustOverride ReadOnly Property MenuForeground() As Drawing.Color
    Public MustOverride ReadOnly Property BackgroundFocused() As Drawing.Color
    Public MustOverride ReadOnly Property HeaderBackground() As Drawing.Color
    Public MustOverride ReadOnly Property HeaderForeground() As Drawing.Color
    Public MustOverride ReadOnly Property HighlightBackground() As Drawing.Color
    Public MustOverride ReadOnly Property HighlightForeground() As Drawing.Color
    Public MustOverride ReadOnly Property HighlightBackgroundOff() As Drawing.Color
    Public MustOverride ReadOnly Property HighlightForegroundOff() As Drawing.Color
    Public MustOverride ReadOnly Property FlatBorder() As Drawing.Color
    Public MustOverride ReadOnly Property ScrollbarColor() As Drawing.Color
    Public MustOverride ReadOnly Property FocusCellBackground() As Drawing.Color
    Public MustOverride ReadOnly Property FocusCellForeground() As Drawing.Color
    Public MustOverride ReadOnly Property SeatsCursorColor() As Drawing.Color
    Public MustOverride ReadOnly Property MenuSelected() As Drawing.Color
    Public MustOverride Function GetImage(ByVal sId As String) As Drawing.Image

End Class

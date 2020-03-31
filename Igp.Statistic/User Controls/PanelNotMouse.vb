Public Class PanelNotMouse
    Inherits System.Windows.Forms.Panel

    Private Sub PanelNotMouse_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        '21-12-11 Deshabilito para Transbank
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

End Class

Public Class WindowsFramework
    Inherits Igp.AccessController.FrameworkBase

    Public Sub New()
        MyBase.New(AccessController.SysModule.IgpManager)
    End Sub

End Class

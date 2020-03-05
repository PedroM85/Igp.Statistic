Public Class WindowsFramework
    Inherits Igp.AccessControl.FrameworkBase

    Public Sub New()
        MyBase.New(AccessControl.SysModule.IgpManager)
    End Sub

End Class

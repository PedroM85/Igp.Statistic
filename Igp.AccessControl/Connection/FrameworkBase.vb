Public Class FrameworkBase
    Inherits POSFramework
    Implements IFrameworkBase

    Public Sub New(ByVal sysmodule As SysModule, ByVal LogonInfoPath As String)
        MyBase.New(sysmodule)

        mConnInfo = New ConnectionInfo(LogonInfoPath)

    End Sub

    Public Sub New(ByVal sysmodule As SysModule)
        MyBase.New(sysmodule)

        mConnInfo = New ConnectionInfo
    End Sub
    Public Function GetConnectionString(Optional connected As Boolean = True) As String Implements IFrameworkBase.GetConnectionString
        Return mConnInfo.OLEDBConnectionString("IgpManager")
    End Function
End Class

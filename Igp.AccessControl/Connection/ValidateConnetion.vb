Public Enum SysModule As Integer
    none
    IpgManager = 1
End Enum


Public MustInherit Class ValidateConnetion

    Protected mSysModuleValue As SysModule
    'Public Sub New(ByVal sysmodule As SysModule)
    '    Me.New(sysmodule)
    'End Sub
    Public Sub New(ByVal sysmodule As SysModule)
        mSysModuleValue = sysmodule
    End Sub
    Public Function InitConnection(ByVal smod As SysModule) As Boolean
        Dim retVal As Boolean

        Try
            smod = ValidateConnetion.SysModule
        Catch ex As Exception

        End Try
    End Function
End Class

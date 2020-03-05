Public Enum SysModule As Integer
    none
    IgpManager = 1
End Enum


Public MustInherit Class POSFramework
    Protected mConnInfo As ConnectionInfo
    Protected mConn As IDbConnection



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
            If smod = SysModule.IgpManager Then
                ConectarDB()
                DesconectarDB()
                '    mConn = New SqlClient.SqlConnection(mConnInfo.SQLConnectionString)
                'Else
                '    mConn = New OleDb.OleDbConnection(mConnInfo.OLEDBConnectionString)
            End If

            'mConn.Open()


            retVal = True

        Catch ex As Exception

            retVal = False
        End Try

        Return retVal
    End Function
End Class

Public Class EnvironmentObjects

    Private Shared oConnection As IDbConnection
    Private Shared oTxIconMgr As System.Resources.ResourceManager
    Private Shared mGlobalResources As Igp.GlobalResourcesEngine.ResourceLoader


    Public Shared Property TransactionIconManager() As System.Resources.ResourceManager
        Get
            Return oTxIconMgr
        End Get
        Set(ByVal Value As System.Resources.ResourceManager)
            oTxIconMgr = Value
        End Set
    End Property

    Public Shared Property Connection() As IDbConnection
        Get
            Return oConnection
        End Get
        Set(ByVal Value As IDbConnection)
            If TypeOf (Value) Is Data.SqlClient.SqlConnection Then
                Igp.DataAccessFactory.DALObjects.ProviderType = DataAccessFactory.DALObjects.DataProviderType.SqlClient
            Else
                Igp.DataAccessFactory.DALObjects.ProviderType = DataAccessFactory.DALObjects.DataProviderType.OleDb
            End If
            oConnection = Value
        End Set
    End Property

    Public Shared Property GlobalResources() As Igp.GlobalResourcesEngine.ResourceLoader
        Get
            Return mGlobalResources
        End Get
        Set(ByVal Value As Igp.GlobalResourcesEngine.ResourceLoader)
            mGlobalResources = Value
        End Set
    End Property

End Class

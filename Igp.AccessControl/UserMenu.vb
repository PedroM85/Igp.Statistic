Imports Igp.DataAccessFactory

<CLSCompliant(True)>
Public Class UserMenu

    Private oConn As IDbConnection

    Private nMenuId As Integer
    Private sDescription As String
    Private oMenuItems As UserMenuItemCollection
    ' Private _ResLoader As ewave.GlobalResourcesEngine.ResourceLoader

    Public WriteOnly Property Connection() As IDbConnection
        Set(ByVal Value As IDbConnection)
            oConn = Value
        End Set
    End Property

    Public Property Id() As String
        Get
            Return Str(nMenuId)
        End Get
        Set(ByVal Value As String)
            nMenuId = CInt(Value)
        End Set
    End Property

    Public Property Description() As String
        Get
            Return sDescription
        End Get
        Set(ByVal Value As String)
            sDescription = Value
        End Set
    End Property

    Public ReadOnly Property MenuItems() As UserMenuItemCollection
        Get
            If oMenuItems Is Nothing Then
                oMenuItems = New UserMenuItemCollection
            End If
            Return oMenuItems
        End Get
    End Property

    Public Sub FillMenu(Optional ByVal oItemCollection As UserMenuItemCollection = Nothing, Optional ByVal nParentId As Integer = -1)
        Dim oRd As IDataReader
        Dim cmd As IDbCommand = oConn.CreateCommand()
        Dim oItem As UserMenuItem
        Dim oPrm As IDataParameter


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SEC_MenuItems"

        oPrm = DAHelper.CreateParameter(cmd, "Menu", DbType.Int32)
        oPrm.Value = nMenuId
        cmd.Parameters.Add(oPrm)

        If nParentId <> -1 Then
            oPrm = DAHelper.CreateParameter(cmd, "Parent", DbType.Int32)
            oPrm.Value = nParentId
            cmd.Parameters.Add(oPrm)
        End If

        If oItemCollection Is Nothing Then oItemCollection = MenuItems

        oRd = cmd.ExecuteReader()

        Do While oRd.Read
            oItem = New UserMenuItem

            oItem.Id = oRd.GetInt32(oRd.GetOrdinal("MIT_Id"))

            If Not oRd.IsDBNull(oRd.GetOrdinal("MIT_Name")) Then
                oItem.Name = oRd.GetString(oRd.GetOrdinal("MIT_Name"))
            Else
                oItem.Name = ""
            End If

            If Not oRd.IsDBNull(oRd.GetOrdinal("MIT_Description")) Then
                oItem.Description = oRd.GetString(oRd.GetOrdinal("MIT_Description"))
            Else
                oItem.Description = ""
            End If

            oItem.IsFolder = oRd.GetBoolean(oRd.GetOrdinal("MIT_IsContainer"))

            oItem.ShowInHome = oRd.GetBoolean(oRd.GetOrdinal("MIT_ShowInHome"))

            If Not oRd.IsDBNull(oRd.GetOrdinal("TRA_Id")) Then
                oItem.Transaction = oRd.GetString(oRd.GetOrdinal("TRA_Id"))
            End If

            oItem.Resource = oRd.GetString(oRd.GetOrdinal("MIT_Resource"))

            oItemCollection.Add(oItem)
        Loop

        oRd.Close()

        For Each oItem In oItemCollection
            FillMenu(oItem.MenuItems, oItem.Id)
        Next

    End Sub

    Public Sub FillSuperUserMenu(Optional ByVal oItemCollection As UserMenuItemCollection = Nothing)

        Dim oRd As IDataReader
        Dim oCmd As IDbCommand = oConn.CreateCommand()
        Dim oItem As UserMenuItem

        oCmd.CommandType = CommandType.Text
        oCmd.CommandText = "SELECT MIT_Id = 0, MIT_MIT_Id = 0,  TRA_Id + '  ' + TRA_Name AS MIT_Name, TRA_Description AS MIT_Description,0 AS MIT_IsContainer,1 AS MIT_ShowInHome ,0 AS MIT_Order ,'Generic' AS MIT_Resource,TRA_Id,TRA_Name,TRA_Description FROM SYS_Transaction ORDER BY MIT_Name"

        If oItemCollection Is Nothing Then
            oItemCollection = MenuItems
            oItemCollection.Add(New UserMenuItem(0, "Transacciones", "Listado de transacciones", True, False, "", "Folder"))
        End If

        oRd = oCmd.ExecuteReader()

        Do While oRd.Read
            oItem = New UserMenuItem

            oItem.Id = oRd.GetInt32(oRd.GetOrdinal("MIT_Id"))

            If Not oRd.IsDBNull(oRd.GetOrdinal("MIT_Name")) Then
                oItem.Name = oRd.GetString(oRd.GetOrdinal("MIT_Name"))
            Else
                oItem.Name = ""
            End If

            If Not oRd.IsDBNull(oRd.GetOrdinal("MIT_Description")) Then
                oItem.Description = oRd.GetString(oRd.GetOrdinal("MIT_Description"))
            Else
                oItem.Description = ""
            End If

            oItem.IsFolder = False

            oItem.ShowInHome = False

            If Not oRd.IsDBNull(oRd.GetOrdinal("TRA_Id")) Then
                oItem.Transaction = oRd.GetString(oRd.GetOrdinal("TRA_Id"))
            End If

            oItem.Resource = oRd.GetString(oRd.GetOrdinal("MIT_Resource"))
            oItemCollection.Item(0).MenuItems.Add(oItem)

        Loop

        oRd.Close()

    End Sub

    Public Sub ClearMenuItems()
        oMenuItems = Nothing
    End Sub

End Class

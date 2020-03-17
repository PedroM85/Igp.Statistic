Imports Igp.DataAccessFactory

<CLSCompliant(True)>
Public Class SessionManager

    Public Enum ModuleEnum
        Manager = 1
        ebocPOS = 3
        ecomPOS = 4
        ebocATM = 5
        ecomATM = 8
        stockcontroller = 9
    End Enum

    Private mConn As IDbConnection

    Public Sub New(ByVal oConnection As IDbConnection)
        mConn = oConnection
    End Sub

    Public Function OpenSession(ByVal userId As String, ByVal terminalId As String, ByVal eModule As ModuleEnum, ByVal siteId As String) As Integer
        Dim cmd As IDbCommand = mConn.CreateCommand
        Dim prm As IDataParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_OpenSession"

        prm = DAHelper.CreateParameter(cmd, "TerminalId", DbType.StringFixedLength, 5)
        prm.Value = terminalId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "UserId", DbType.StringFixedLength, 20)
        prm.Value = userId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "ModuleId", DbType.Int32, 4)
        prm.Value = eModule
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32, 4)
        prm.Direction = ParameterDirection.Output
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "ModifiedBy", DbType.StringFixedLength, 20)
        prm.Value = userId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "ReadOnly", DbType.Boolean)
        prm.Value = False
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
        ' revisar
        Dim SessionID As IDataParameter = CType(cmd.Parameters.Item("SessionId"), IDataParameter)
        Return CType(SessionID.Value, Integer)
    End Function

    Public Sub ReOpenSession(ByVal nSessionId As Integer, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        Dim prm As IDataParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_ReOpenSession"

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = nSessionId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub CloseSession(ByVal nSessionId As Integer, ByVal sUserId As String, ByVal siteId As String)

        Dim cmd As IDbCommand = mConn.CreateCommand

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_CloseSession"

        Dim prm As IDataParameter

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = nSessionId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "ClosedByUserId", DbType.String, 20) '[AMI110305]
        prm.Value = sUserId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Function GetCurrentSession(ByVal sUserId As String, ByVal sTerminalId As String, ByVal eModule As ModuleEnum, ByVal siteId As String) As Integer

        Dim cmd As IDbCommand = mConn.CreateCommand
        Dim prm As IDataParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_HasUserSessionOpened"

        prm = DAHelper.CreateParameter(cmd, "UserId", DbType.StringFixedLength, 20)
        prm.Value = sUserId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "ModuleId", DbType.Int32)
        prm.Value = eModule
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Direction = ParameterDirection.Output
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "TerminalId", DbType.StringFixedLength, 5)
        prm.Direction = ParameterDirection.Output
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()

        Dim paramTerminalId As IDataParameter = CType(cmd.Parameters("TerminalId"), IDataParameter)

        If paramTerminalId.Value Is DBNull.Value Then
            Return -1
        ElseIf CType(paramTerminalId.Value, String).Trim = sTerminalId.Trim Then
            Dim paramSessionId As IDataParameter = CType(cmd.Parameters("SessionId"), IDataParameter)
            Return CInt(paramSessionId.Value)
        Else
            Return -1
        End If

    End Function

    Public Sub CleanReservesLocked(ByVal session As Integer, ByVal siteId As String)

        Dim cmd As IDbCommand = mConn.CreateCommand
        Dim prm As IDataParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "MNT_CleanReservesLocked"

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = session
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()

    End Sub

    Public Sub GetUserSession(ByVal sUserId As String, ByVal eModule As ModuleEnum, ByRef sTerminalId As String, ByRef nSessionId As Integer, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        Dim prm As IDataParameter
        Dim rd As IDataReader

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_HasUserSessionOpened"

        prm = DAHelper.CreateParameter(cmd, "UserId", DbType.StringFixedLength, 20)
        prm.Value = sUserId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "ModuleId", DbType.Int32)
        prm.Value = eModule
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Direction = ParameterDirection.Output
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "TerminalId", DbType.StringFixedLength, 5)
        prm.Direction = ParameterDirection.Output
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        rd = cmd.ExecuteReader

        If rd.Read Then
            nSessionId = rd.GetInt32(rd.GetOrdinal("SSS_Id"))
            sTerminalId = rd.GetString(rd.GetOrdinal("SSS_TRM_Id"))
        Else
            nSessionId = -1
            sTerminalId = ""
        End If
        rd.Close()
    End Sub

    Public Function IsSessionOpened(ByVal nSessionId As Integer, ByVal siteId As String) As Boolean
        Dim cmd As IDbCommand = mConn.CreateCommand

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_IsSessionOpened"

        Dim prm As IDataParameter

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = nSessionId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "Opened", DbType.Boolean)
        prm.Direction = ParameterDirection.Output
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
        Dim paramOpened As IDataParameter = CType(cmd.Parameters("Opened"), IDataParameter)
        Return CType(paramOpened.Value, Boolean)
    End Function

    Public Sub SetupInitialBase(ByVal nSessionId As Integer, ByVal nAmount As Decimal, ByVal userId As String, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_SetupInitialBase"
        Dim oPrm As IDataParameter

        oPrm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        oPrm.Value = nSessionId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "Amount", DbType.Decimal)
        oPrm.Value = nAmount
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "SiteId", DbType.String, 10)
        oPrm.Value = siteId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "ModifiedBy", DbType.String, 20)
        oPrm.Value = userId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "ReadOnly", DbType.Boolean)
        oPrm.Value = False
        cmd.Parameters.Add(oPrm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub WithdrawInitialBase(ByVal nSessionId As Integer, ByVal userId As String, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_WithdrawInitialBase"

        Dim oPrm As IDataParameter

        oPrm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        oPrm.Value = nSessionId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "SiteId", DbType.String, 10)
        oPrm.Value = siteId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "ModifiedBy", DbType.String, 20)
        oPrm.Value = userId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "ReadOnly", DbType.Boolean)
        oPrm.Value = False
        cmd.Parameters.Add(oPrm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub RegisterSession(ByVal nSessionId As Integer, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SCTRL_RegisterSession"

        Dim prm As IDataParameter

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = nSessionId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub DeRegisterSession(ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SCTRL_RegisterSession"

        Dim prm As IDataParameter

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = DBNull.Value
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub BeginPause(ByVal nSessionId As Integer, ByVal userId As String, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_BeginPause"

        Dim oPrm As IDataParameter

        oPrm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        oPrm.Value = nSessionId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "SiteId", DbType.String, 10)
        oPrm.Value = siteId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "ModifiedBy", DbType.String, 20)
        oPrm.Value = userId
        cmd.Parameters.Add(oPrm)

        oPrm = DAHelper.CreateParameter(cmd, "ReadOnly", DbType.Boolean)
        oPrm.Value = False
        cmd.Parameters.Add(oPrm)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub EndPause(ByVal nSessionId As Integer, ByVal siteId As String)
        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SSS_EndPause"

        Dim prm As IDataParameter

        prm = DAHelper.CreateParameter(cmd, "SessionId", DbType.Int32)
        prm.Value = nSessionId
        cmd.Parameters.Add(prm)

        prm = DAHelper.CreateParameter(cmd, "SiteId", DbType.StringFixedLength, 10)
        prm.Value = siteId
        cmd.Parameters.Add(prm)

        cmd.ExecuteNonQuery()
    End Sub

End Class

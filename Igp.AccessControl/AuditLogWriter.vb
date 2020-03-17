Imports Igp.DataAccessFactory
Imports Igp.EventLog
Imports System.ComponentModel

<CLSCompliant(True)>
Public Class AuditLogWriter

#Region " Constants & variables "

    Public Enum EventType As Int16
        LoginSucceded = 1
        LoginFailed = 2
        Logout = 3
        SaleTransaction = 4
        RefundTransaction = 5
        ReservationTransaction = 6
        Authorisation = 7
        PasswordChange = 8
        DayOpened = 9
        DayClosed = 10
        SaleTransactionInterruption = 11
        RefundTransactionInterruption = 12
        PerformanceCancelled = 13
        ForcedLogout = 14
        ReservationCancelled = 15
        SalesDayRestore = 16
        SessionReOpened = 17
        ManualSales = 18
        PrintingError = 19
        RemotePrint = 20
        PrintStatus = 21
        MobilePrint = 22
        VoucherReportPrint = 101
    End Enum

    Private mConnection As IDbConnection
    Private mCommand As IDbCommand
    Private mSiteId As String
    Private mEventViewer As EventViewer
    Private WithEvents mEventViewerWriter As BackgroundWorker


#End Region

#Region " Constructors "

    Public Sub New(ByVal connection As IDbConnection, ByVal siteId As String)
        'Dim dbPar As IDbDataParameter
        'Me.mConnection = connection
        'Me.mSiteId = siteId

        ''If CType(mConnection, Object).GetType() Is GetType(System.Data.SqlClient.SqlConnection) Then
        ''    DALObjects.ProviderType = DALObjects.DataProviderType.SqlClient
        ''Else
        ''    DALObjects.ProviderType = DALObjects.DataProviderType.OleDb
        ''End If

        'mCommand = mConnection.CreateCommand
        'With mCommand
        '    .CommandType = CommandType.StoredProcedure
        '    .CommandText = "AUD_AuditEvent"
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "EventTypeId", DbType.Int16))
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "UserId", DbType.StringFixedLength))
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "TerminalId", DbType.StringFixedLength))
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "Reference", DbType.String))
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "SiteId", DbType.String))
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "ModifiedBy", DbType.String))
        '    .Parameters.Add(DAHelper.CreateParameter(mCommand, "ReadOnly", False))
        '    dbPar = DAHelper.CreateParameter(mCommand, "AEV_Id", DbType.Int32)
        '    dbPar.Direction = ParameterDirection.Output
        '    .Parameters.Add(dbPar)
        'End With

        'Dim comm As IDbCommand = mConnection.CreateCommand
        'comm.CommandText = "SELECT PAR_StringValue FROM SYS_Parameter WHERE PAR_Id = 'AUDITEVENT'"
        'If comm.ExecuteScalar.ToString = "S" Then
        '    Dim pars As String() = mConnection.ConnectionString.Split(";"c)
        '    Dim machineName As String = String.Empty
        '    Dim indexOf As Int32
        '    For Each par As String In pars
        '        If par.ToLower().StartsWith("data source") Then
        '            indexOf = par.IndexOf("=") + 1
        '            machineName = par.Substring(indexOf, par.Length - indexOf)
        '            Exit For
        '        End If
        '    Next

        '    indexOf = machineName.IndexOf("\")
        '    If indexOf > -1 Then
        '        machineName = machineName.Substring(0, indexOf)
        '    End If
        '    mEventViewer = New EventViewer("Audit Log", machineName)

        'End If

    End Sub

#End Region

#Region " Methods "


    Public Sub AddEntry(ByVal eventType As EventType, ByVal user As String, ByVal terminal As String, ByVal reference As String)
        AddEntry(eventType, user, terminal, reference, Nothing)
    End Sub

    Public Sub AddEntry(ByVal eventType As EventType, ByVal user As String, ByVal terminal As String, ByVal reference As String, ByVal tx As IDbTransaction)

        With mCommand
            CType(.Parameters("EventTypeId"), IDataParameter).Value = DirectCast(eventType, Int16)
            CType(.Parameters("UserId"), IDataParameter).Value = user
            CType(.Parameters("TerminalId"), IDataParameter).Value = terminal
            CType(.Parameters("Reference"), IDataParameter).Value = IIf(reference = "", DBNull.Value, reference)
            CType(.Parameters("SiteId"), IDataParameter).Value = mSiteId
            CType(.Parameters("ModifiedBy"), IDataParameter).Value = user
            If tx IsNot Nothing Then .Transaction = tx
            .ExecuteNonQuery()
        End With
        Try
            If mEventViewer IsNot Nothing Then
                mEventViewerWriter = New BackgroundWorker()
                mEventViewerWriter.RunWorkerAsync(New EventInfo(eventType, user, terminal, reference, Int32.Parse(CType(mCommand.Parameters("AEV_Id"), IDataParameter).Value.ToString())))
            End If
        Catch
        End Try

    End Sub

    Public Function GetAuditEntriesCountByType(ByVal eventType As EventType, Optional ByVal Reference As String = "") As Integer
        Dim cmd As IDbCommand = mConnection.CreateCommand

        cmd.CommandType = CommandType.Text

        cmd.CommandText = String.Format("SELECT count(*) as cantidad FROM AUD_Event WHERE AEV_AET_Id = {0} ", DirectCast(eventType, Int16))
        If Reference <> "" Then
            cmd.CommandText += " and AEV_Reference='" + Reference + "'"
        End If
        Dim rtn As Integer = 0
        Try
            rtn = CType(cmd.ExecuteScalar(), Integer)
        Catch ex As Exception

        End Try

        Return rtn

    End Function

    Private Function GetEntryType(ByVal eventType As EventType) As EventLogEntryType
        Select Case eventType
            Case EventType.LoginSucceded, EventType.Logout, EventType.SaleTransaction, EventType.RefundTransaction, EventType.ReservationTransaction, EventType.Authorisation, EventType.PasswordChange, EventType.DayOpened, EventType.DayClosed, EventType.SalesDayRestore, EventType.SessionReOpened, EventType.ManualSales, EventType.RemotePrint, EventType.PrintStatus
                Return EventLogEntryType.Information
            Case EventType.LoginFailed, EventType.SaleTransactionInterruption, EventType.RefundTransactionInterruption, EventType.PerformanceCancelled, EventType.ForcedLogout, EventType.ReservationCancelled
                Return EventLogEntryType.Warning
            Case EventType.PrintingError
                Return EventLogEntryType.Error
            Case Else
                Return EventLogEntryType.Information
        End Select
    End Function

#End Region

    Private Sub mEventViewerWriter_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles mEventViewerWriter.DoWork
        Dim info As EventInfo = DirectCast(e.Argument, EventInfo)

        mEventViewer.WriteEntry(String.Format(" EventType={0}{4} UserId={1}{4} TerminalId={2}{4} Reference={3}{4}", info.EventType, info.User, info.Terminal, info.Reference, ChrW(13)), GetEntryType(info.EventType), info.Id)
    End Sub


    Structure EventInfo
        Public Sub New(ByVal eventType As EventType, ByVal user As String, ByVal terminal As String, ByVal reference As String, ByVal id As Int32)
            Me.EventType = eventType
            Me.User = user
            Me.Terminal = terminal
            Me.Reference = reference
            Me.Id = id
        End Sub
        Dim EventType As EventType
        Dim User As String
        Dim Terminal As String
        Dim Reference As String
        Dim Id As Int32
    End Structure
End Class

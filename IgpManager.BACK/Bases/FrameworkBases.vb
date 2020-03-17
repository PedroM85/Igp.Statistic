Imports Microsoft.Win32
Imports Igp.AccessController
'Imports ewave.TicketDesigner
'Imports ewave.TicketPrinter
'Imports ewave.FiscalPrinter
'Imports ewave.CardAuthorizationInterfaces
Imports System.Reflection
Imports System.IO
'Imports ewave.MemberClientUtilities
Imports System.Collections.Generic
Imports Igp.POSResources.CommonManagers

Public Enum SalesMode
    CinemaMode
    EntertainmentMode
End Enum

Public MustInherit Class FrameworkBase
    Inherits Igp.POSResources.POSFramework
    Implements IFrameworkBase


#Region " Instance variables "
    'Private mHallsInfo As Dictionary(Of String, HallInfo)
    Private mColorSchema As ColorSchemaManager

    'Protected mTickets As TicketLayoutsManager



    'Protected mPOSMgr As POSManager
    Protected WithEvents mCommMgr As CommunicationManager
    ' Protected mImageCache As ImageCache

    'Private oMsgPopup As MsgPopup


    'Resources
    Private mResMgr As System.Resources.ResourceManager
    Private mTxIconMgr As System.Resources.ResourceManager

    ' Private mCustDisplay As CustomerDisplayManager

#End Region

#Region " Methods "

    Public Sub New(ByVal sysModule As Igp.POSResources.SysModule, ByVal LogonInfoPath As String)
        MyBase.New(sysModule)

        mResMgr = New System.Resources.ResourceManager("ewave.Bitmaps", Me.GetType().Assembly())
        mTxIconMgr = New System.Resources.ResourceManager("ewave.TransactionIcons", Me.GetType().Assembly())
        mConnInfo = New ConnectionInfo(LogonInfoPath)
    End Sub

    Public Sub New(ByVal sysModule As Igp.POSResources.SysModule)
        MyBase.New(sysModule)

        mResMgr = New System.Resources.ResourceManager("ewave.Bitmaps", Me.GetType().Assembly())
        mTxIconMgr = New System.Resources.ResourceManager("ewave.TransactionIcons", Me.GetType().Assembly())
        mConnInfo = New ConnectionInfo()
    End Sub

    'Public Sub LoadHallsInfo() Implements IFrameworkBase.LoadHallsInfo
    '    Dim cmd As OleDb.OleDbCommand = mConn.CreateCommand
    '    Dim rd As OleDb.OleDbDataReader
    '    Dim hallInfo As HallInfo

    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = "SLS_GetHallsInfo"
    '    rd = cmd.ExecuteReader

    '    mHallsInfo = New Dictionary(Of String, HallInfo)

    '    Do While rd.Read
    '        hallInfo = New HallInfo(rd.GetString(rd.GetOrdinal("SIT_Id")).TrimEnd(), rd.GetString(rd.GetOrdinal("HAL_Id")).TrimEnd())
    '        With hallInfo
    '            .HallName = rd.GetString(rd.GetOrdinal("HAL_Name"))
    '            .ExternalCode = rd.GetString(rd.GetOrdinal("HAL_ExternalCode"))
    '            .Company = rd.GetString(rd.GetOrdinal("CMP_Name"))
    '            .CompanyFiscalCode = rd.GetString(rd.GetOrdinal("CMP_FiscalCode"))
    '            If rd.IsDBNull(rd.GetOrdinal("CMP_ExternalCode")) Then
    '                .CompanyExternalCode = String.Empty
    '            Else
    '                .CompanyExternalCode = rd.GetString(rd.GetOrdinal("CMP_ExternalCode"))
    '            End If
    '            .SiteName = rd.GetString(rd.GetOrdinal("SIT_Name"))
    '            If rd.IsDBNull(rd.GetOrdinal("SIT_Address1")) Then
    '                .SiteAddress = String.Empty
    '            Else
    '                .SiteAddress = rd.GetString(rd.GetOrdinal("SIT_Address1"))
    '            End If
    '        End With

    '        mHallsInfo.Add(hallInfo.Key, hallInfo)
    '    Loop
    '    rd.Close()
    'End Sub


    'Public Function InitConnection() As Boolean
    '    Dim retVal As Boolean
    '    Dim offCinfo As ConnectionInfo = New ConnectionInfo()

    '    If OfflineManager.IsTransferDataInstalled Then

    '        If offCinfo.GetConnectionInfo("Offline") Then
    '            OfflineManager.ConnString = offCinfo.SQLConnectionString
    '        Else
    '            Throw New SystemException("No se encontró la información de la conexión offline en el archivo de conexión")
    '        End If
    '    End If

    '    Try
    '        mConn = New OleDb.OleDbConnection(GetConnectionString)
    '        mConn.Open()
    '        mConnected = True
    '        retVal = True
    '    Catch ex As Exception
    '        If OfflineManager.IsTransferDataInstalled Then
    '            mConn = New OleDb.OleDbConnection(offCinfo.OLEDBConnectionString)
    '            mConn.Open()
    '            mConnected = False
    '            'reemplazo el conninfo
    '            mConnInfo = offCinfo
    '            retVal = True
    '        Else
    '            retVal = False
    '        End If
    '    End Try

    '    Dim oCmd As OleDb.OleDbCommand = mConn.CreateCommand
    '    oCmd.CommandType = CommandType.StoredProcedure
    '    oCmd.CommandText = "MNT_SetupConnection"
    '    oCmd.ExecuteNonQuery()

    '    Return retVal
    'End Function

    Public Function Init(ByRef OutErrorMessage As String) As Boolean Implements IFrameworkBase.Init
        Try
            mParams = New Parameters(mConn)

            Dim oSecMgr As New SecurityManager(mConn)
            Try
                Igp.Tools.OperatingSystem.SetDateTime(oSecMgr.GetServerDateTime)
            Catch ex As Exception
                OutErrorMessage = ex.ToString
            End Try
            mConnInfo.SPID = oSecMgr.GetSPID

            SetColorSchema()

            LoadWorkingParameters()

            GetTerminalProperties()

            mAudit = New AuditLogWriter(mConn, mTerminalSiteId)

            'SetSatelliteDlls()

            SetupLocalizationInfo()

            'mTickets = New TicketLayoutsManager
            'mTickets.Load(mConn)

            'LoadHallsInfo()

            'InitCardReader()
            'InitCustDisplay()

            'mImageCache = New ImageCache
            'mImageCache.Load()

            'mCommMgr = New CommunicationManager(CommunicationManager.ModuleEnum.Manager)
            'mCommMgr.Start()

            'If mConnected Then
            'inicializar autorizador de  tarjetas
            'Sin conexión alternativa, el parámetro va en blanco
            ' InitializeCreditCardAuthorizator("")
            'End If

            'OfflineManager.SetParameters(Parameters)


            Return True
        Catch ex As Exception
            OutErrorMessage = ex.ToString
            Return False
        End Try
    End Function


    'Public Sub InitCustDisplay() Implements IFrameworkBase.InitCustDisplay
    '    Dim custDisplay As ewave.CustDisplay.CustomerDisplayController
    '    custDisplay = ewave.CustDisplay.CustomerDisplayFactory.GetController(mCustDisplayCode)
    '    custDisplay.Open(mCustDisplayPar)

    '    Dim custDispMgr As New CustomerDisplayManager(mConn)
    '    custDispMgr.Init(custDisplay)
    '    mCustDisplay = custDispMgr
    'End Sub

    'Private Sub SetSatelliteDlls() Implements IFrameworkBase.SetSatelliteDlls
    '    ewave.TicketDesigner.EnvironmentObjects.Connection = mConn
    '    ewave.TicketDesigner.EnvironmentObjects.GlobalResources = EnvironmentObjects.Fwk.GlobalResources

    '    ewave.TerminalConfig.EnvironmentObjects.Connection = mConn
    '    ewave.TerminalConfig.EnvironmentObjects.GlobalResources = EnvironmentObjects.Fwk.GlobalResources

    '    'ewave.HallLayoutDesigner.EnvironmentObjects.Connection = oConn
    '    ewave.HallLayoutDesigner.EnvironmentObjects.GlobalResources = EnvironmentObjects.Fwk.GlobalResources
    'End Sub

    Protected Friend Function GetConnectionString(Optional ByVal connected As Boolean = True) As String Implements IFrameworkBase.GetConnectionString
        Return mConnInfo.OLEDBConnectionString("Manager")
    End Function

    Public Sub CleanOldLogins() Implements IFrameworkBase.CleanOldLogins
        Dim oSecMgr As New SecurityManager(mConn)
        Try
            oSecMgr.CleanOldLogins(mSysModuleValue, mTerminalId, EnvironmentObjects.Fwk.TerminalSiteId, EnvironmentObjects.Fwk.User.Id)
        Catch
        End Try

    End Sub

    Public Function HasLicensesFree() As Boolean Implements IFrameworkBase.HasLicensesFree
        Dim secMgr As New SecurityManager(mConn)
        Return secMgr.HasLicensesFree(mSysModuleValue, EnvironmentObjects.Fwk.TerminalSiteId)
    End Function

    Function RegisterLogin(ByVal user As User) As Boolean Implements IFrameworkBase.RegisterLogin
        Try
            Dim sec As New SecurityManager(mConn)
            sec.RegisterLogin(user, mTerminalId, mSysModuleValue, IgpManager.BACK.EnvironmentObjects.Fwk.TerminalSiteId)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub PingServer() Implements IFrameworkBase.PingServer
        Try
            Dim connPingServer As OleDb.OleDbConnection
            connPingServer = New OleDb.OleDbConnection(GetConnectionString(mConnected))
            Try
                connPingServer.Open()
                Dim sec As New SecurityManager(connPingServer)
                sec.PingServer(mConnInfo.SPID)
            Finally
                connPingServer.Close()
            End Try

        Catch oEx As Exception
            mLogFile.LogEvent(oEx.Message)
        End Try
    End Sub

    Public Sub RegisterLogout() Implements IFrameworkBase.RegisterLogout
        Dim sec As New SecurityManager(mConn)
        sec.RegisterLogout(EnvironmentObjects.Fwk.TerminalSiteId, EnvironmentObjects.Fwk.User.Id)
        'Modificado FS (Agregue llamada a Funcion)
        ' Dim off As New OffLine()
        'off.SetHallsPerTerminal()

        'If OfflineManager.Available AndAlso mConnected Then
        '    'Modificado FS (Transfiere los datos que quedan antes de salir)
        '    Dim iTransfer As Integer = 2
        '    Do While iTransfer = 2
        '        iTransfer = off.TransferData()
        '    Loop

        '    'Modificado FS (Agregue llamada a Funcion)
        '    off.DeleteOfflineHallsPerTerminal()
        'End If

    End Sub


    Public Overrides Sub LoadOrOpenSession() Implements IFrameworkBase.LoadOrOpenSession
        Dim sesMgr As New SessionManager(EnvironmentObjects.Fwk.OleDBConnection)
        mSessionId(mWorkingSiteId) = sesMgr.GetCurrentSession(mUser.Id, mTerminalId, SessionManager.ModuleEnum.ebocPOS, mWorkingSiteId)

        mNewSession = False
        Dim sessId As Int32 = mSessionId(mWorkingSiteId)
        If sessId = -1 Then
            EnvironmentObjects.Fwk.SessionId(mWorkingSiteId) = sesMgr.OpenSession(mUser.Id, mTerminalId, SessionManager.ModuleEnum.ebocPOS, mWorkingSiteId)
            mNewSession = True
        Else
            'Si hay sesión, limpiar reservas bloqueadas.
            sesMgr.CleanReservesLocked(mSessionId(mWorkingSiteId), mWorkingSiteId)
        End If

        If sessId > 0 Then
            sesMgr.RegisterSession(mSessionId(mWorkingSiteId), mWorkingSiteId)
        End If

        'Modificado FS (Agregue Funcion)
        'If OfflineManager.Available Then
        '    If mConnected Then
        '        If sessId > 0 Then
        '            Dim off As New OffLine()
        '            off.SetHallsPerTerminal()
        '        End If

        '    Else
        '        'Si no esta conectado pide autorizacion para entrar en modo offline
        '        Me.HideMessagePopup()
        '        If Not AskForAuthorisation(mParams.GetValue("AUTHOFFLVL")) Then
        '            Throw New Exception("Falló la autorización para entrar en modo offline")
        '        End If
        '    End If
        'End If

    End Sub


    Public Function IsSessionOpened() As Boolean Implements IFrameworkBase.IsSessionOpened
        Dim sid
        Try
            sid = mSessionId(mTerminalSiteId)
        Catch ex As Exception
            sid = -1
        End Try

        Dim sesMgr As New SessionManager(EnvironmentObjects.Fwk.OleDBConnection)
        Return sesMgr.IsSessionOpened(sid, mTerminalSiteId)
    End Function


    Public Sub ChangeWorkingSite(ByVal siteId As String) Implements IFrameworkBase.ChangeWorkingSite
        If mWorkingSiteId <> siteId Then
            Dim prevSite = mWorkingSiteId
            mWorkingSiteId = siteId
            Try
                LoadOrOpenSession()
            Catch ex As Exception
                mWorkingSiteId = prevSite
                Throw ex
            End Try
        End If
    End Sub

    Public Sub SetColorSchema() Implements IFrameworkBase.SetColorSchema
        If mConnected Then
            'Select Case mParams.GetString("BOCCOLORS")
            Select Case "Dark"
                Case "DARK"
                    mColorSchema = New DarkSchema
                Case "LIGHT"
                    mColorSchema = New LightSchema
                Case Else
                    mColorSchema = New DarkSchema
            End Select
        Else
            mColorSchema = New OffLineSchema
        End If
    End Sub



#End Region

#Region " Overridable Methods "


    Public Function GetResource(ByVal sId As String) As Object Implements IFrameworkBase.GetResource
        Return mResMgr.GetObject(sId)
    End Function

    Public Function GetTransactionIcon(ByVal sId As String) As Object Implements IFrameworkBase.GetTransactionIcon
        Return mTxIconMgr.GetObject(sId)
    End Function

    'Public Sub InitializeTranslatedResources() Implements IFrameworkBase.InitializeTranslatedResources
    '    EnvironmentObjects.Fwk.GlobalResources.InitializeEngine(GetConnectionString(mConnected), "")
    'End Sub

#End Region

#Region " Abstract Methods "

    Public MustOverride Function CheckIfPasswordMustBeChanged() As Boolean Implements IFrameworkBase.CheckIfPasswordMustBeChanged
    Public MustOverride Sub HideMessagePopup() Implements IFrameworkBase.HideMessagePopup
    Public MustOverride Function AskForAuthorisation(ByVal nAuthLevelRequested As Integer) As Boolean Implements IFrameworkBase.AskForAuthorisation
    Public MustOverride Function UserHasSecurityLevelFromParameter(ByVal Paramstr As String) As Boolean
    Public MustOverride Function CheckUserSecLevelAndAsk(ByVal ParamStr As String) As Boolean
    'Public MustOverride Function InitPrinters() As Boolean
    Protected MustOverride Sub ShowMessage(ByVal Message As String) Implements IFrameworkBase.ShowMessage

    Public MustOverride Sub NewInstantMessage() Implements IFrameworkBase.NewInstantMessage
    Public MustOverride Sub NewDeposit() Implements IFrameworkBase.NewDeposit
    Public MustOverride Function GetAmountFromCalculator() As Double Implements IFrameworkBase.GetAmountFromCalculator
    Public MustOverride Sub ExecuteCalculator() Implements IFrameworkBase.ExecuteCalculator

#End Region

#Region " Properties "


    'Public ReadOnly Property TicketManager() As TicketLayoutsManager Implements IFrameworkBase.TicketManager
    '    Get
    '        Return mTickets
    '    End Get
    'End Property

    Public ReadOnly Property CommunicationManager() As CommunicationManager Implements IFrameworkBase.CommunicationManager
        Get
            Return mCommMgr
        End Get
    End Property

    'Public ReadOnly Property POSManager() As POSManager
    '    Get
    '        Return mPOSMgr
    '    End Get
    'End Property

    'Public ReadOnly Property ImageCache() As ImageCache Implements IFrameworkBase.ImageCache
    '    Get
    '        Return mImageCache
    '    End Get
    'End Property


    'Public Property TransferingSQL2() As Boolean
    '    Set(ByVal p_bTransferingSQL As Boolean)
    '        mTransferingSQL = p_bTransferingSQL
    '    End Set
    '    Get
    '        Return mTransferingSQL
    '    End Get
    'End Property

    Public ReadOnly Property TransactionIconManager() As System.Resources.ResourceManager Implements IFrameworkBase.TransactionIconManager
        Get
            Return mTxIconMgr
        End Get
    End Property

    Public ReadOnly Property ResourceManager() As System.Resources.ResourceManager Implements IFrameworkBase.ResourceManager
        Get
            Return mResMgr
        End Get
    End Property


    'Public ReadOnly Property HallInfo(ByVal siteId As String, ByVal hallId As String) As HallInfo Implements IFrameworkBase.HallInfo
    '    Get
    '        Return mHallsInfo.Item(siteId.TrimEnd() + "_" + hallId.TrimEnd())
    '    End Get
    'End Property


    Public ReadOnly Property ColorSchema() As ColorSchemaManager Implements IFrameworkBase.ColorSchema
        Get
            Return mColorSchema
        End Get
    End Property

    'Public ReadOnly Property CustDisplay() As CustomerDisplayManager Implements IFrameworkBase.CustDisplay
    '    Get
    '        Return mCustDisplay
    '    End Get
    'End Property


#End Region

#Region " Event handlers "

    Public Sub oCommMgr_InstantMessageArrived(ByVal sMessage As String) Handles mCommMgr.InstantMessageArrived

        'POSMessageBox.Show(sMessage)

        ShowMessage(sMessage)


        'Application.DoEvents()
        'If Not IsNothing(oMsgPopup) Then oMsgPopup.Dispose()
        'oMsgPopup = New MsgPopup
        'With oMsgPopup
        '    .lblMessage.Text = sMessage
        '    .Show()
        'End With
        'Application.DoEvents()

    End Sub

    Private Sub oCommMgr_ShutdownRequest() Handles mCommMgr.ShutdownRequest
        oCommMgr_InstantMessageArrived("El sistema debe cerrar la aplicación. Por favor, termine la transacción actual.")
        'POSMessageBox.Show("El sistema debe cerrar la aplicación. Por favor, termine la transacción actual.", "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'oMainMenuForm.TryShutdownNow()
        mCloseASAP = True
    End Sub

    Private Sub oCommMgr_Refresh() Handles mCommMgr.Refresh
        ShowMessage("Refresh")
        'POSMessageBox.Show("Refresh", "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function GetParameterYesNo(ByVal ParamName As String, Optional ByVal defaultValue As Boolean = False) As Boolean
        Try
            Dim rsp As String = Parameters.GetValue(ParamName).Chars(0)

            Return rsp.ToUpper() = "Y" Or rsp = "S"
        Catch
            Return defaultValue
        End Try


    End Function

#End Region


End Class

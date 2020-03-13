Imports Microsoft.Win32
Imports System.Collections.Generic

Public Enum ewSysModule As Integer
    'Sincronizar con posframework hasta que los unifiquemos
    none
    IgpManager = 1
    mgr_cons = 2
    ebocPOS = 3
    ecom = 4
    ATM = 5
    ebocWS = 6
    corporate = 7
    Totem = 8
    StockController = 9
End Enum

Public Class EWFramework


#Region " Events "

    Public Event MustClose()
    Public Event InstantMessageArrived(ByVal Message As String)

#End Region

#Region " Inner Classes "

    Public Class LoginResult
        Public DialogOk As Boolean
        Public LoginResponse As String
        Public Logged As Boolean
        Sub New()
            DialogOk = False
            LoginResponse = ""
            Logged = False

        End Sub

    End Class

    Public Class SalesDateInfo
        Public SalesDateId As Date
        Public OpeningDate As Date
        Public BocSessionsOpened As Int32
        Public ComSessionsOpened As Int32
        Public UsersLoggedOn As Int32
        Public TrainingMode As Boolean
    End Class

    Public Class Site
        Private mId As String
        Private mName As String

        Public Sub New(ByVal id As String, ByVal name As String)
            mId = id
            mName = name
        End Sub

        Public Property Id() As String
            Get
                Return mId
            End Get
            Set(ByVal value As String)
                mId = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return mName
            End Get
            Set(ByVal value As String)
                mName = value
            End Set
        End Property

    End Class

#End Region

#Region " Instance variables "

    Protected mConnInfo As Igp.AccessControl.ConnectionInfo
    Protected mConn As OleDb.OleDbConnection
    Protected mResMgr As System.Resources.ResourceManager
    Protected mTxIconMgr As System.Resources.ResourceManager
    'Protected mTranslatedResources As ewave.GlobalResourcesEngine.ResourceLoader
    'Protected mAudit As AccessController.AuditLogWriter
    'Protected mLockMgr As AccessController.LockManager
    Protected mParams As AccessControl.Parameters
    Protected WithEvents mCommMgr As AccessControl.CommunicationManager
    Protected mTerminalId As String
    Protected mConnectionName As String
    Protected mShutdownForced As Boolean = False
    'Protected mUser As ewave.AccessController.User
    Protected mLastAction As Date
    Protected mSiteId As String
    Protected mPiloto As Integer
    Protected mTypeModule As AccessControl.CommunicationManager.ModuleEnum
    Protected mNewSession As Boolean
    Protected mAuthorizatorTerminalParameters As String

    ' Dim mUserSites As New List(Of Site)


#End Region

#Region " Methods "
    Private mClientGUID As String

    Property ClientGuid() As String
        Get
            If mClientGUID = String.Empty Then
                mClientGUID = System.Guid.NewGuid.ToString()
            End If
            Return mClientGUID
        End Get
        Set(ByVal value As String)
            mClientGUID = value
        End Set
    End Property

    Public Sub New(ByVal ResourcesFilePrefix As String)

        mResMgr = New System.Resources.ResourceManager(ResourcesFilePrefix + "Bitmaps", Me.GetType().Assembly())
        mTxIconMgr = New System.Resources.ResourceManager(ResourcesFilePrefix + "TransactionIcons", Me.GetType().Assembly())
        'mTranslatedResources = New ewave.GlobalResourcesEngine.ResourceLoader

    End Sub

    Public Sub New()
        Me.New("")
    End Sub

    Public Overridable Function MainModuleId() As Integer
        Return ewSysModule.IgpManager
    End Function

    'Public Overridable Sub CleanOldLogins()
    '    Dim oSecMgr As New AccessControl.SecurityManager(mConn)
    '    oSecMgr.CleanOldLogins(MainModuleId(), mTerminalId, mSiteId, mUser.Id)
    'End Sub

    'Public Overridable Function HasLicensesFree() As Boolean
    '    Dim oSecMgr As New AccessControl.SecurityManager(mConn)
    '    Return oSecMgr.HasLicensesFree(MainModuleId(), SiteId)

    'End Function

    Public Function InitConnection() As Boolean
        Try

            mConn = New OleDb.OleDbConnection(GetConnectionString)


            mConn.Open()

            Dim oSecMgr As New AccessControl.SecurityManager(mConn)
            mConnInfo.SPID = oSecMgr.GetSPID

            Dim oCmd As OleDb.OleDbCommand = mConn.CreateCommand
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = "MNT_SetupConnection"
            oCmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Overridable Function Init() As Boolean
        Try
            Dim oSecMgr As New AccessControl.SecurityManager(mConn)
            Try
                'ewave.Tools.OperatingSystem.SetDateTime(oSecMgr.GetServerDateTime)
            Catch

            End Try


            mParams = New AccessControl.Parameters(mConn)
            mSiteId = mParams.GetValue("SITEID").TrimEnd().ToUpper()
            mPiloto = mParams.GetValue("nPiloto").ToString
            'mLockMgr = New AccessControl.LockManager(mConn)
            'mAudit = New AccessControl.AuditLogWriter(mConn, mSiteId)
            'LoadLanguage()
            SetupLocalizationInfo()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    'Public Sub LoadUserSites()
    '    Dim cmd As OleDb.OleDbCommand = mConn.CreateCommand

    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = "USI_GetSitesByUser"
    '    cmd.Parameters.Add("UserId", OleDb.OleDbType.Char, 20).Value = mUser.Id
    '    cmd.Parameters.Add("TerminalId", OleDb.OleDbType.Char, 10).Value = mTerminalId

    '    Dim dr As OleDb.OleDbDataReader
    '    dr = cmd.ExecuteReader

    '    mUserSites = New List(Of Site)()

    '    Do While dr.Read()
    '        mUserSites.Add(New Site(dr.GetString(dr.GetOrdinal("SIT_Id")).TrimEnd().ToUpper(), dr.GetString(dr.GetOrdinal("SIT_Name")).TrimEnd()))
    '    Loop

    '    dr.Close()
    'End Sub
    'Public Sub InitCommunicationManager()
    '    mCommMgr = New AccessControl.CommunicationManager(AccessControl.CommunicationManager.ModuleEnum.Manager)
    '    mCommMgr.Start()
    'End Sub

    Public Sub GetPrinterParameters(ByRef sPrinter As String, ByRef sConnection As String, ByRef sParameters As String, ByRef sWindowsPrinter As String)
        Dim oCmd As OleDb.OleDbCommand = mConn.CreateCommand

        oCmd.CommandType = CommandType.StoredProcedure
        oCmd.CommandText = "TRM_GetTerminal"
        oCmd.Parameters.Add("TerminalId", OleDb.OleDbType.Char, 5).Value = mTerminalId

        Dim dr As OleDb.OleDbDataReader
        dr = oCmd.ExecuteReader

        If dr.Read() Then

            If Not dr.IsDBNull(dr.GetOrdinal("TRM_Printer")) Then
                sPrinter = CStr(dr("TRM_Printer"))
            End If
            If Not dr.IsDBNull(dr.GetOrdinal("TRM_PrinterConnectionType")) Then
                sConnection = CStr(dr("TRM_PrinterConnectionType"))
            End If
            If Not dr.IsDBNull(dr.GetOrdinal("TRM_PrinterConnectionParameters")) Then
                sParameters = CStr(dr("TRM_PrinterConnectionParameters"))
            End If

            'Parámetros extra del autorizador
            If Not dr.IsDBNull(dr.GetOrdinal("TRM_AUT_Pars")) Then
                mAuthorizatorTerminalParameters = CStr(dr("TRM_AUT_Pars")).TrimEnd
            End If

            If Not dr.IsDBNull(dr.GetOrdinal("TRM_WinDriverPrinterName")) Then
                sWindowsPrinter = CStr(dr("TRM_WinDriverPrinterName"))
            Else
                sWindowsPrinter = ""
            End If

        End If

        dr.Close()
    End Sub

    Public Function GetConnectionString() As String
        Return String.Format("Provider=SQLOLEDB.1;Password={3};Persist Security Info=True;User ID={2};Initial Catalog={1};Data Source={0};Application Name=ewave", mConnInfo.Server, mConnInfo.Database, mConnInfo.UserId, mConnInfo.Password)
    End Function

    Private Sub SetupLocalizationInfo()
        Dim oCulture As New System.Globalization.CultureInfo("")
        Dim oNumberFormat As New System.Globalization.NumberFormatInfo
        Dim oDateFormat As New System.Globalization.DateTimeFormatInfo
        Dim oAbbrDays As String() = {"Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb"}
        Dim oDays As String() = {"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado"}
        Dim oAbbrMonths As String() = {"Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic", ""}
        Dim oMonths As String() = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", ""}
        Dim nSize() As Integer = {0}

        With oNumberFormat
            .CurrencyDecimalDigits = mParams.GetValue("NUMDEC")
            .CurrencyDecimalSeparator = mParams.GetValue("DECSEP")
            .CurrencyGroupSeparator = " "
            .CurrencyGroupSizes = nSize
            .CurrencyNegativePattern = 1
            .CurrencyPositivePattern = 0
            .CurrencySymbol = mParams.GetValue("CURRSYM")
            .NumberDecimalDigits = mParams.GetValue("NUMDEC")
            .NumberDecimalSeparator() = mParams.GetValue("DECSEP")
            .NumberGroupSeparator = " "
            .NumberGroupSizes = nSize
            .NumberNegativePattern = 1
        End With

        With oDateFormat
            .AbbreviatedDayNames = oAbbrDays
            .AbbreviatedMonthNames = oAbbrMonths
            .DayNames = oDays
            .MonthNames = oMonths
            .ShortDatePattern = "dd/MM/yyyy"
            .LongDatePattern = "dddd, dd \de MMMM \de yyyy"
            .ShortTimePattern = IIf(mParams.GetValue("TIMEAMPM") = "S", "h:mm tt", "HH:mm")
            .LongTimePattern = IIf(mParams.GetValue("TIMEAMPM") = "S", "h:mm:ss tt", "HH:mm:ss")
        End With

        oCulture.NumberFormat = oNumberFormat
        oCulture.DateTimeFormat = oDateFormat

        System.Threading.Thread.CurrentThread.CurrentCulture = oCulture
    End Sub

    'Public Sub GetTerminalId()
    '    sTerminalId = ewave.TerminalConfig.DataLayer.GetTerminalInRegistry
    'End Sub

    'Public Function RegisterLogin(ByVal oUser As AccessController.User) As Boolean
    '    Return RegisterLogin(oUser, True)
    'End Function

    'Public Function RegisterLogin(ByVal oUser As AccessController.User, ByVal loadUserSites As Boolean) As Boolean
    '    Try
    '        Dim oSec As New AccessController.SecurityManager(mConn)
    '        oSec.RegisterLogin(oUser, mTerminalId, MainModuleId(), mSiteId)
    '        If loadUserSites Then Me.LoadUserSites()
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Public Sub PingServer()

    '    Try
    '        Dim oConnectionPingServer As New OleDb.OleDbConnection(GetConnectionString)
    '        Try
    '            oConnectionPingServer.Open()
    '            Dim oSec As New AccessController.SecurityManager(oConnectionPingServer)

    '            oSec.PingServer(mConnInfo.SPID)

    '        Finally
    '            oConnectionPingServer.Close()
    '        End Try

    '    Catch oEx As Exception
    '        'oApp.LogFile.LogEvent(oEx.Message)
    '    End Try

    'End Sub

    'Public Sub RegisterLogout()
    '    If Not mUser Is Nothing Then
    '        Dim oSec As New AccessController.SecurityManager(mConn)
    '        oSec.RegisterLogout(mSiteId, mUser.Id)

    '        AuditLogWriter.AddEntry(AccessController.AuditLogWriter.EventType.Logout, mUser.Id, mTerminalId, "")
    '    End If
    'End Sub

    Public Sub ExitFW()
        'If Not mCommMgr Is Nothing Then mCommMgr.Stop()
        If Not mConn Is Nothing Then
            mConn.Close()
            mConn.Dispose()
        End If

    End Sub

    'Public Overridable Sub LoginUser(Optional ByVal UserName As String = Nothing, Optional ByVal Password As String = Nothing)
    '    Dim sec As AccessController.SecurityManager = New AccessController.SecurityManager(mConn)
    '    Dim loginDlg As ewave.Common.Login

    '    'si tengo user y pass pruebo loguearme directo
    '    If Not UserName Is Nothing AndAlso Not Password Is Nothing Then
    '        mUser = sec.Login(UserName, Password)
    '    End If

    '    'oRetUser es nothing si no se logueo o fallo
    '    If mUser Is Nothing Then
    '        loginDlg = New ewave.Common.Login(mTerminalId, sec, mConn)

    '        If Not UserName Is Nothing Then
    '            loginDlg.txtUser.Text = UserName
    '        End If

    '        loginDlg.ShowDialog()
    '        mUser = loginDlg.User
    '    End If
    'End Sub

    'Public Function CheckAuthLevel(ByVal ParamLevel As String) As Boolean
    '    Dim lvl As Integer
    '    'Try
    '    '    lvl = Parameters.GetValue(ParamLevel)
    '    'Catch ex As Exception
    '    '    lvl = 0
    '    'End Try
    '    lvl = Parameters.GetValue(ParamLevel)
    '    Return CurrentUser.SecurityLevel.Id <= lvl
    'End Function

    'Public Function CheckAndRaiseAuthLevel(ByVal ParamLevel As String, Optional ByVal ShowError As Boolean = False) As Boolean
    '    Dim Msg_Authorized As String = GlobalResources.GetString("Msg_reprintvoucher", "No posee el nivel de autorización necesario para esta operación.")
    '    Dim rtn As Boolean = False
    '    If CheckAuthLevel(ParamLevel) Then
    '        rtn = True
    '    Else
    '        Dim lr As LoginResult = FormAuthorization(Parameters.GetValue(ParamLevel))
    '        rtn = lr.Logged
    '        If Not lr.Logged Then
    '            If lr.DialogOk And ShowError Then
    '                EWMessageBox.Show(Msg_Authorized, lr.LoginResponse, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If
    '    End If
    '    Return rtn
    'End Function

    'Public Function AskForAuthorisation(ByVal nAuthLevelRequested As Integer) As Boolean
    '    Return FormAuthorization(nAuthLevelRequested).Logged
    'End Function

    'Public Function FormAuthorization(ByVal nAuthLevelRequested As Integer) As LoginResult
    '    Dim lr As New LoginResult

    '    Dim oSec As AccessController.SecurityManager = New AccessController.SecurityManager(mConn)
    '    Dim oAuth As New ewave.Common.AuthorizationForm

    '    lr.DialogOk = oAuth.ShowDialog() = DialogResult.OK
    '    If lr.DialogOk Then

    '        lr.LoginResponse = oSec.HasAuthorisationBy(mUser.Id, nAuthLevelRequested, oAuth.txtUser.Text, oAuth.txtPassword.Text)
    '        If lr.LoginResponse = "OK" Then
    '            Me.AuditLogWriter.AddEntry(AccessController.AuditLogWriter.EventType.Authorisation, mUser.Id, mTerminalId, oAuth.txtUser.Text)
    '            lr.Logged = True
    '        Else
    '            lr.Logged = False
    '        End If
    '    Else
    '        lr.LoginResponse = "Usuario cancela"
    '        lr.Logged = False

    '    End If
    '    Return lr

    'End Function


    Public Function GetResource(ByVal sId As String) As Object
        Return mResMgr.GetObject(sId)
    End Function

    Public Function GetTransactionIcon(ByVal sId As String) As Object
        Return mTxIconMgr.GetObject(sId)
    End Function

    Public Function GetConnectionInfo() As Boolean
        Dim sArgs As String()
        Dim sName As String = String.Empty
        Dim nI As Integer

        mConnInfo = New AccessControl.ConnectionInfo

        sArgs = Environment.GetCommandLineArgs


        For nI = 0 To sArgs.Length - 1
            If sArgs(nI).Substring(1, 2) = "ls" Then
                sName = sArgs(nI).Substring(4)
                Exit For
            End If
        Next

        Return mConnInfo.GetConnectionInfo(sName)
    End Function

    'Public Overridable Function CheckIfTerminalRegistered() As Boolean
    '    Dim bTermOk As Boolean

    '    mTerminalId = ewave.TerminalConfig.DataLayer.GetTerminalInRegistry()

    '    If mTerminalId = "" Then
    '        Dim oTermConfig As New ewave.Common.TerminalConfigDialog

    '        If oTermConfig.ShowDialog() = DialogResult.OK Then
    '            mTerminalId = ewave.TerminalConfig.DataLayer.GetTerminalInRegistry()
    '            bTermOk = True
    '        Else
    '            bTermOk = False
    '        End If

    '    Else
    '        bTermOk = True
    '    End If

    '    Return bTermOk
    'End Function

    Public Function IsSalesDateOpened() As Boolean
        Try
            Dim oCmd As OleDb.OleDbCommand = mConn.CreateCommand
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = "SSS_IsSalesDateOpened"

            Dim oPrm As OleDb.OleDbParameter = oCmd.Parameters.Add("@Opened", OleDb.OleDbType.Boolean)
            oPrm.Direction = ParameterDirection.Output

            oCmd.ExecuteNonQuery()

            Return oPrm.Value <> 0
        Catch ex As Exception
            Return False
        End Try
    End Function


    'Public Sub GetSystemLanguageInfo(ByRef AssemblyName As String)

    '    Dim idLang As String = CStr(Me.Parameters.GetValue("LANGUAGE"))
    '    Dim cmd As New OleDb.OleDbCommand("LNG_Get", Me.Connection)
    '    Dim dr As OleDb.OleDbDataReader

    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@LanguageId", idLang))

    '    dr = cmd.ExecuteReader

    '    If dr.Read Then
    '        If Not dr.IsDBNull(dr.GetOrdinal("LNG_ResourceAssemblyNameMGR")) Then
    '            AssemblyName = dr("LNG_ResourceAssemblyNameMGR")
    '        End If

    '    End If
    '    dr.Close()

    'End Sub

    'Public Sub InitializeTranslatedResources()
    '    'TODO: El lenguage debería inicializarse despues del usuario
    '    'para poder cargar lenguage por usuario
    '    mTranslatedResources.InitializeEngine(Me.mConnInfo.OLEDBConnectionString, "") ' Me.m_User.Id) '  = New ewave.GlobalResourcesEngine.ResourceLoader(AssemblyName)
    'End Sub

    'Public Overloads Sub LoadLanguage(ByVal AssemblyName As String)
    '    oTranslatedResources = New ewave.GlobalResourcesEngine.ResourceLoader(AssemblyName)
    'End Sub

    ' [AMI140405] Obtiene el día de ventas (ej: si se cierra al día siguiente a las 9:00, la hora 07:00 corresponde al día anterior)
    'Public Function GetSalesDate2() As String

    '    Dim oCmd As Data.OleDb.OleDbCommand = Me.Connection.CreateCommand
    '    Dim OReader As Data.OleDb.OleDbDataReader
    '    Dim sActualDateTime As String
    '    Dim sSalesDate As String

    '    sActualDateTime = Today.Now.ToString("yyyy-MM-dd HH:mm:ss")

    '    Try
    '        oCmd.CommandType = CommandType.Text
    '        oCmd.CommandText = "SELECT dbo.GetSalesDateIdFromDateTime ({ ts '" & sActualDateTime & "' })"

    '        OReader = oCmd.ExecuteReader()
    '        OReader.Read()
    '        sSalesDate = OReader.GetDateTime(0).ToString
    '        Return sSalesDate

    '    Catch ex As Exception
    '        EWMessageBox.Show(ex.Message, , MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return Today.Date.ToString
    '    Finally
    '        OReader.Close()
    '    End Try

    'End Function

    ' [AMI210405]
    'Public Function CheckIfPasswordMustBeChanged() As Boolean

    '    Dim oCmd As Data.OleDb.OleDbCommand = Me.Connection.CreateCommand

    '    If mUser.PasswordExpired = True OrElse mUser.InitialChangePassword = True Then
    '        Try

    '            Dim oPassword As New ewave.Common.EWChangePassword(mTerminalId, mUser)
    '            oPassword.UserId = mUser.Id

    '            If oPassword.ShowDialog = DialogResult.Cancel Then
    '                Return False
    '            End If

    '            oCmd.CommandType = CommandType.StoredProcedure
    '            oCmd.CommandText = "USR_UpdatePasswordExpiryDate"

    '            oCmd.Parameters.Add("@USR_Id", OleDb.OleDbType.Char, 20).Value = mUser.Id
    '            oCmd.Parameters.Add("@USR_PasswordExpiryDate", OleDb.OleDbType.Date).Value = Today.AddDays(Me.Parameters.GetValue("PWDEXPIRE"))
    '            oCmd.Parameters.Add("@USR_InitialChange", OleDb.OleDbType.Boolean).Value = False

    '            oCmd.ExecuteNonQuery()

    '            Return True
    '        Catch oEx As Exception
    '            EWMessageBox.Show(oEx.Message, , MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return False
    '        Finally
    '            oCmd.Dispose()
    '        End Try
    '    Else
    '        Return True
    '    End If

    'End Function

    Public Function GetDateValue() As Date

        Dim oCmd As OleDb.OleDbCommand = mConn.CreateCommand

        oCmd.CommandType = CommandType.StoredProcedure
        oCmd.CommandText = "SDT_GetOpenedSalesDate"
        oCmd.Parameters.Add(New OleDb.OleDbParameter("@SalesDateId", OleDb.OleDbType.DBTimeStamp)).Direction = ParameterDirection.Output
        oCmd.Parameters.Add(New OleDb.OleDbParameter("@SiteId", OleDb.OleDbType.Char, 10)).Value = EnvironmentObjects.Framework.SiteId

        Try
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw (ex)
        End Try

        If oCmd.Parameters("@SalesDateId").Value Is DBNull.Value Then
            Return Date.Today
        Else
            Return CDate(oCmd.Parameters("@SalesDateId").Value)
        End If

    End Function

#End Region

#Region " Properties "
    Public ReadOnly Property TransactionIconManager() As System.Resources.ResourceManager
        Get
            Return mTxIconMgr
        End Get
    End Property

    Public ReadOnly Property ConnectionName() As String
        Get
            Return mConnectionName
        End Get
    End Property

    Public ReadOnly Property ConnectionInfo() As AccessControl.ConnectionInfo
        Get
            Return mConnInfo
        End Get
    End Property

    Public ReadOnly Property Connection() As OleDb.OleDbConnection
        Get
            Return mConn
        End Get
    End Property

    Public ReadOnly Property ResourceManager() As System.Resources.ResourceManager
        Get
            Return mResMgr
        End Get
    End Property

    'Public ReadOnly Property LayoutDataPath() As String
    '    Get
    '        Dim oDI As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Application.ExecutablePath).Parent
    '        Dim sLayoutPath As String = oDI.FullName & "\LayoutData"
    '        Dim oLayoutDI As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(sLayoutPath)
    '        If Not oLayoutDI.Exists Then
    '            oDI.CreateSubdirectory("LayoutData")
    '        End If
    '        Return oLayoutDI.FullName
    '    End Get
    'End Property

    Public ReadOnly Property TerminalId() As String
        Get
            Return mTerminalId
        End Get
    End Property

    'Public ReadOnly Property AuditLogWriter() As AccessController.AuditLogWriter
    '    Get
    '        Return mAudit
    '    End Get
    'End Property

    'Public ReadOnly Property LockManager() As AccessController.LockManager
    '    Get
    '        Return mLockMgr
    '    End Get
    'End Property

    Public ReadOnly Property Parameters() As AccessControl.Parameters
        Get
            Return mParams
        End Get
    End Property

    Public ReadOnly Property CommunicationManager() As AccessControl.CommunicationManager
        Get
            Return mCommMgr
        End Get
    End Property

    Public ReadOnly Property ShutdownForced() As Boolean
        Get
            Return mShutdownForced
        End Get
    End Property

    'Public ReadOnly Property GlobalResources() As ewave.GlobalResourcesEngine.ResourceLoader
    '    Get
    '        Return mTranslatedResources
    '    End Get
    'End Property

    'Public ReadOnly Property CurrentUser() As ewave.AccessController.User
    '    Get
    '        Return mUser
    '    End Get
    'End Property

    Public Property LastAction() As Date
        Get
            Return mLastAction
        End Get
        Set(ByVal value As Date)
            mLastAction = value
        End Set
    End Property

    Public Property SiteId() As String
        Get
            Return mSiteId
        End Get
        Set(ByVal value As String)
            mSiteId = value.TrimEnd().ToUpper()
        End Set
    End Property

    Public Property TypeModule() As AccessControl.CommunicationManager.ModuleEnum
        Get
            Return mTypeModule
        End Get
        Set(ByVal value As AccessControl.CommunicationManager.ModuleEnum)
            mTypeModule = value
        End Set
    End Property

    'Public ReadOnly Property UserSites() As List(Of Site)
    '    Get
    '        Return mUserSites
    '    End Get
    'End Property

    'Public ReadOnly Property SelectedSite() As Site
    '    Get
    '        Dim selSiteId As String = mSiteId.TrimEnd().ToUpper()
    '        For Each s As Site In mUserSites
    '            If s.Id = selSiteId Then
    '                Return s
    '            End If
    '        Next
    '        Return Nothing
    '    End Get
    'End Property



#End Region

#Region " Event handlers "

    'Private Sub oConn_StateChange(ByVal sender As Object, ByVal e As System.Data.StateChangeEventArgs) Handles oConn.StateChange
    '    If e.CurrentState = ConnectionState.Closed Then
    '        '            EWMessageBox.Show("Conexión a la base de datos cerrada abruptamente. La aplicación se cerrará inmediatamente.", "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        '            Application.Exit()
    '    End If
    'End Sub

    Private Sub oCommMgr_InstantMessageArrived(ByVal sMessage As String) Handles mCommMgr.InstantMessageArrived
        'EWMessageBox.Show(_MainForm, sMessage, Me.TranslatedResources.GetString("MGR.FrameWork.oCommMgr_InstantMessageArrived.Msg1", "e-wave Instant Message"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        RaiseEvent InstantMessageArrived(sMessage)
    End Sub

    Private Sub oCommMgr_ShutdownRequest() Handles mCommMgr.ShutdownRequest
        mShutdownForced = True
        '_MainForm.Close()
        RaiseEvent MustClose()
    End Sub

#End Region

End Class

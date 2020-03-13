Imports Microsoft.Win32
Imports igp.AccessController
'Imports ewave.TicketPrinter
'Imports ewave.FiscalPrinter
'Imports ewave.CardAuthorizationInterfaces
Imports System.Reflection
Imports System.IO
'Imports ewave.MemberClientUtilities
'Imports ewave.CardReader
Imports System.Collections.Specialized
Imports ewave.POSResources.CommonClasses
Imports ewave.POSResources.CommonManagers

'OJALDRE QUE ESTOS NUMEROS TIENEN QUE COINCIDIR CON LA TABLA SYS_MODULE
Public Enum SysModule As Integer
    none
    IgpManager = 1
    'mgr_gral = 1
    'mgr_cons = 2
    'ebocPOS = 3
    'ecom = 4
    'ATM = 5
    'ebocWS = 6
    'corporate = 7
    'Totem = 8
    'StockController = 9
End Enum

Public Enum EcomTransactionType
    Sales
    CreditRefund
    Hospitality
    Refund
    RemoteSales
End Enum

Public MustInherit Class POSFramework
    Implements IPOSFramework

#Region " Instance variables "

    'Private mHallsInfo As Dictionary(Of String, HallInfo)
    'Private mColorSchema As ColorSchemaManager

    Protected mPOSCode As String = Nothing

    Protected mConnInfo As ConnectionInfo
    Protected mConn As IDbConnection

    Protected mTerminalId As String
    Protected mSessionId As New System.Collections.Generic.Dictionary(Of String, Integer)
    Protected mCloseASAP As Boolean = False
    Protected mNewSession As Boolean

    'Protected mAudit As AuditLogWriter
    Protected mParams As Parameters

    'Printers
    'Protected mPrinter As PrinterController
    'Protected WithEvents mFiscalPrinter As FiscalPrinterController
    Protected mPrintCinemaTicketWithFP As Boolean = False
    Protected mHaveFiscalPrinter As Boolean = False


    Protected mLogFile As ewave.EventLog.LogFile
    Protected mUser As ewave.AccessController.User

    Protected mCreditCardAuthorizator As AuthorizatorBase
    Protected mSysModuleValue As SysModule

    Protected mLastAction As Date = Now

    Protected mTerminalSiteId As String
    Protected mWorkingSiteId As String

    Dim mCmLineArgs As StringDictionary


    'Membership
    Protected mMbrClient As ewave.MemberInterfaces.IMemberManagement
    Protected mMbrPointCli As ewave.MemberInterfaces.IPointManagement
    Protected mMbrWalletCli As ewave.MemberInterfaces.IWalletManagement
    Protected mMbrWalletCli_2 As ewave.MemberInterfaces.IWalletManagement_2
    Protected mMbrUserCli As ewave.MemberInterfaces.IUserManagement

    Protected mGlobalResources As ewave.GlobalResourcesEngine.ResourceLoader

    'Propiedades de la terminal
    Protected mTicketPrinterCode As String = String.Empty
    Protected mTicketPrinterConnection As String = String.Empty
    Protected mTicketPrinterParameters As String = String.Empty
    Protected mFiscalPrinterCode As String = String.Empty
    Protected mFiscalPrinterConnection As String = String.Empty
    Protected mFiscalPrinterParameters As String = String.Empty
    Protected mWindowsPrinter As String = String.Empty

    Protected mCardReaderType As String = "NUL"
    Protected mCardReaderParameters As String = String.Empty
    Protected mAuthorizatorTerminalParameters As String = String.Empty
    Private mCardReader As ewave.CardReader.CardReaderBase

    Protected mMembershipCardReaderType As String = "NUL"
    Protected mMembershipCardReaderParameters As String = String.Empty
    Private mMembershipCardReader As ewave.CardReader.CardReaderBase


    Protected mCustDisplayCode As String = String.Empty
    Protected mCustDisplayPar As String = String.Empty

    Dim mUserSites As New List(Of Site)

    'Offline
    Protected mConnected As Boolean


    'Argumentos de linea de comando
    Private mCmLineUserName As String
    Private mCmLinePassword As String

#End Region

#Region " Methods "

    Public Sub New(ByVal sysModule As ewave.POSResources.SysModule, ByVal terminalSiteId As String)
        Me.New(sysModule)
        mTerminalSiteId = terminalSiteId
    End Sub

    Public Sub New(ByVal sysModule As SysModule)
        mSysModuleValue = sysModule
        mGlobalResources = New ewave.GlobalResourcesEngine.ResourceLoader

    End Sub


    Public Sub LoadWorkingParameters() Implements IPOSFramework.LoadWorkingParameters


    End Sub


    Public Overridable Function InitPrinters() As Boolean Implements IPOSFramework.InitPrinters
        If mParams.GetString("TRAINMODE") = "S" Then
            mPrinter = New ewave.TicketPrinter.NullPrinterController
            mFiscalPrinter = New ewave.FiscalPrinter.NullFiscalPrinterController
            Return True
        Else

            '**** IMPRESORA DE ENTRADAS *****
            If mSysModuleValue <> SysModule.ecom Then
                mPrinter = ewave.TicketPrinter.PrinterControllerFactory.GetPrinterController(mTicketPrinterCode)

                Select Case mTicketPrinterConnection
                    Case "S"
                        mPrinter.ConnectionType = ewave.TicketPrinter.PrinterController.PrinterConnectionType.Serial
                    Case "P"
                        mPrinter.ConnectionType = ewave.TicketPrinter.PrinterController.PrinterConnectionType.Parallel
                    Case "U"
                        mPrinter.ConnectionType = ewave.TicketPrinter.PrinterController.PrinterConnectionType.USB
                    Case Else
                End Select

                mPrinter.ConnectionParameters = mTicketPrinterParameters

                If mWindowsPrinter.Length > 0 Then
                    Dim PS As New Drawing.Printing.PrinterSettings
                    PS.PrinterName = mWindowsPrinter
                    mPrinter.DefaultPrinterSetting = PS
                End If

            End If




            '*** IMPRESORA FISCAL ***
            mFiscalPrinter = ewave.FiscalPrinter.PrinterControllerFactory.GetPrinterController(mFiscalPrinterCode)

            Select Case mFiscalPrinterConnection
                Case "S"
                    mFiscalPrinter.ConnectionType = ewave.FiscalPrinter.FiscalPrinterController.PrinterConnectionType.Serial
                Case "P"
                    mFiscalPrinter.ConnectionType = ewave.FiscalPrinter.FiscalPrinterController.PrinterConnectionType.Parallel
                Case "U"
                    mFiscalPrinter.ConnectionType = ewave.FiscalPrinter.FiscalPrinterController.PrinterConnectionType.USB
                Case "W"
                    mFiscalPrinter.ConnectionType = ewave.FiscalPrinter.FiscalPrinterController.PrinterConnectionType.URI
                Case Else
            End Select

            mFiscalPrinter.ConnectionParameters = mFiscalPrinterParameters


            'PARAMETROS DE IMPR FISCAL
            If Not TypeOf (mFiscalPrinter) Is ewave.FiscalPrinter.NullFiscalPrinterController Then
                mHaveFiscalPrinter = True

                mFiscalPrinter.PrintItemFormat = DirectCast(System.Enum.Parse(GetType(ewave.FiscalPrinter.FiscalPrinterController.PrintItemFormatType), mParams.GetString("FPITFORMAT"), True), ewave.FiscalPrinter.FiscalPrinterController.PrintItemFormatType)

                mFiscalPrinter.DefaultBarCodeType = DirectCast(System.Enum.Parse(GetType(ewave.FiscalPrinter.FiscalPrinterController.BarCodeType), mParams.GetString("FPBARCODE"), True), ewave.FiscalPrinter.FiscalPrinterController.BarCodeType)
                mFiscalPrinter.DefaultFont = DirectCast(System.Enum.Parse(GetType(ewave.FiscalPrinter.FiscalPrinterController.FontType), mParams.GetString("FPFONT"), True), ewave.FiscalPrinter.FiscalPrinterController.FontType)

                If Not mParams.GetString("FPHEADER") Is Nothing Then
                    mFiscalPrinter.Header = mParams.GetString("FPHEADER").Split(",")
                End If

                If Not mParams.GetString("FPGREETING") Is Nothing Then
                    mFiscalPrinter.Greeting = mParams.GetString("FPGREETING").Split(",")
                End If

                mFiscalPrinter.Terminal = mTerminalId
            Else
                'sin impresora fiscal
                mHaveFiscalPrinter = False
            End If

            'Usar impresora fiscal para tickets
            If mTicketPrinterCode = "FISC" AndAlso Not TypeOf (mFiscalPrinter) Is ewave.FiscalPrinter.NullFiscalPrinterController Then
                mPrintCinemaTicketWithFP = True
            Else
                mPrintCinemaTicketWithFP = False
            End If
        End If

        Return True
    End Function

    Private Class AuthConnData
        Public AuthClassName As String
        Public AuthDll As String
        Public Arguments As Hashtable
    End Class

    Private Function ProcessAuthConnString(ByVal ArgsStr As String,
                                           ByVal TermSettings As String,
                                           ByVal DBSettings As String) As AuthConnData

        Dim rtn As New AuthConnData
        Dim ccauthcfg As String

        If Not String.IsNullOrEmpty(ArgsStr) Then
            ccauthcfg = ArgsStr
        Else
            ccauthcfg = DBSettings
        End If
        If Not String.IsNullOrEmpty(TermSettings) Then
            If TermSettings.StartsWith("+|") Then
                ccauthcfg = ccauthcfg + TermSettings.Substring(1)
            Else
                ccauthcfg = TermSettings
            End If
        End If

        mLogFile.LogEvent("Initializing Credit Card Authorizator with parameters " + ccauthcfg)

        Dim pars As String() = ccauthcfg.Split("|"c)
        If ccauthcfg IsNot Nothing Then
            If pars.Length > 1 Then
                rtn.AuthClassName = pars(1)
                If Path.IsPathRooted(pars(0)) Then
                    rtn.AuthDll = pars(0)
                Else
                    Dim curDir As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                    If Not curDir.EndsWith("\") Then
                        curDir = curDir + "\"
                    End If
                    rtn.AuthDll = curDir + pars(0)
                End If

                If pars.GetUpperBound(0) > 1 Then
                    rtn.Arguments = New Hashtable
                    Dim parValue As String()
                    For i As Int32 = 2 To pars.GetUpperBound(0)
                        parValue = pars(i).Split("="c)
                        If parValue.GetUpperBound(0) = 1 Then
                            If rtn.Arguments.ContainsKey(parValue(0)) Then
                                rtn.Arguments(parValue(0)) = parValue(1)
                            Else
                                rtn.Arguments.Add(parValue(0), parValue(1))
                            End If
                        End If
                    Next
                End If
            End If
        End If
        Return rtn
    End Function


    Public Sub InitializeCreditCardAuthorizator(ByVal AuthorizatorAltConnectionString As String) Implements IPOSFramework.InitializeCreditCardAuthorizator

        Try
            mLogFile.LogEvent("Initializing Credit Card Authorizator")

            Dim mauthdata As AuthConnData = ProcessAuthConnString(AuthorizatorAltConnectionString,
                                                                  mAuthorizatorTerminalParameters,
                                                                  mParams.GetString("CCAUTH"))


            mCreditCardAuthorizator = AuthorizatorBuilder.BuildAuthorizator(mauthdata.AuthDll, mauthdata.AuthClassName)
            If mauthdata.Arguments IsNot Nothing Then
                mCreditCardAuthorizator.Parameters = mauthdata.Arguments
            End If


            mCreditCardAuthorizator.Initialize(Parameters.GetString("SITEID").TrimEnd)
            mLogFile.LogEvent(String.Format("Credit Card Authorizator '{0}' initialized ok. Type: {1}",
                                            mCreditCardAuthorizator.AuthorizatorName,
                                            mCreditCardAuthorizator.GetType.ToString()))

        Catch ex As Exception
            mLogFile.LogExcepton(ex)
        End Try

    End Sub

    Public Sub InitializeMemberShipClient() Implements IPOSFramework.InitializeMemberShipClient

        Dim mbrCfg As String = Parameters.GetString("MBRCONFIG")

        If Not mbrCfg Is Nothing AndAlso mbrCfg.TrimEnd.Length > 0 Then

            Try

                Dim pars As String() = mbrCfg.Split("|"c)

                mMbrClient = MemberClientFactory.GetIMemberManagement(pars(0))
                If mMbrClient Is Nothing Then
                    Throw New Exception("No se pudo inicializar el sistema de membership con id " + pars(0))
                Else
                    If mMbrClient.HasPointManagement Then mMbrPointCli = MemberClientFactory.GetIPointManagement(pars(0))
                    If mMbrClient.HasWalletManagement Then mMbrWalletCli = MemberClientFactory.GetIWalletManagement(pars(0))

                    If mMbrClient.HasWalletManagement And (pars(0) = "Fielopolis") Then mMbrWalletCli_2 = MemberClientFactory.GetIWalletManagement_2(pars(0))
                    If mMbrClient.HasUserManagement Then mMbrUserCli = MemberClientFactory.GetIUserManagement(pars(0))


                    'parametros
                    If pars.GetUpperBound(0) > 0 Then
                        Dim Key As String
                        Dim Value As String
                        For i As Int32 = 1 To pars.GetUpperBound(0)
                            Key = Mid(pars(i), 1, InStr(pars(i), "=") - 1)
                            Value = Mid(pars(i), InStr(pars(i), "=") + 1)
                            If Key <> "" Then
                                If mMbrClient.Common.Parameters.ContainsKey(Key) Then
                                    mMbrClient.Common.Parameters(Key) = Value
                                End If
                            End If
                        Next
                    End If

                    'Parametros comunes
                    mMbrClient.Common.SiteId = mTerminalSiteId
                    mMbrClient.Common.TerminalId = mTerminalId
                    mMbrClient.Common.OleDBConnectionString = mConnInfo.OLEDBConnectionString
                    mMbrClient.Common.ModuleId = Convert.ToInt32(mSysModuleValue)
                    'si se llama desde otras aplicaciones el mUser no está seteado
                    If mUser IsNot Nothing Then mMbrClient.Common.UserId = mUser.Id

                    mMbrClient.Initialize()

                    If mMbrClient.HasPointManagement Then mMbrPointCli.Initialize(mMbrClient)
                    If mMbrClient.HasWalletManagement Then
                        If Not mMbrWalletCli_2 Is Nothing Then
                            mMbrWalletCli_2.Initialize(mMbrClient)
                        End If
                        mMbrWalletCli.Initialize(mMbrClient)
                    End If
                    If mMbrClient.HasUserManagement Then mMbrUserCli.Initialize(mMbrClient)

                    'Card reader
                    InitMembershipCardReader()


                    mLogFile.LogEvent(String.Format("** MemberShip Client '{0}' initialized OK - Version: {1} **", pars(0), mMbrClient.GetVersion()))
                End If

            Catch ex As Exception
                mLogFile.LogEvent(String.Format("** ERROR: Couldn't initialize Membership client: {0} **", ex.ToString))
                Throw ex
            End Try

        Else
            mLogFile.LogEvent(String.Format("** WARNING: No membership client was configured. **"))
            mMbrClient = Nothing
        End If
    End Sub

    Public Sub SetupLocalizationInfo() Implements IPOSFramework.SetupLocalizationInfo
        Dim culture As New System.Globalization.CultureInfo("")
        Dim numberFormat As New System.Globalization.NumberFormatInfo
        Dim dateFormat As New System.Globalization.DateTimeFormatInfo
        Dim abbrDays As String() = {"Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb"}
        Dim days As String() = {"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado"}
        Dim abbrMonths As String() = {"Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic", ""}
        Dim months As String() = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", ""}
        Dim size() As Integer = {0}

        With numberFormat
            .CurrencyDecimalDigits = mParams.GetInteger("NUMDEC")
            .CurrencyDecimalSeparator = mParams.GetString("DECSEP")
            .CurrencyGroupSeparator = " "
            .CurrencyGroupSizes = size
            .CurrencyNegativePattern = 1
            .CurrencyPositivePattern = 0
            .CurrencySymbol = mParams.GetString("CURRSYM")
            .NumberDecimalDigits = mParams.GetInteger("NUMDEC")
            .NumberDecimalSeparator() = mParams.GetString("DECSEP")
            .NumberGroupSeparator = " "
            .NumberGroupSizes = size
            .NumberNegativePattern = 1
        End With

        With dateFormat
            .AbbreviatedDayNames = abbrDays
            .AbbreviatedMonthNames = abbrMonths
            .DayNames = days
            .MonthNames = months
            .ShortDatePattern = "dd/MM/yyyy"
            .LongDatePattern = "dddd, dd \de MMMM \de yyyy"
            .ShortTimePattern = IIf(mParams.GetString("TIMEAMPM") = "S", "h:mm tt", "HH:mm").ToString()
            .LongTimePattern = IIf(mParams.GetString("TIMEAMPM") = "S", "h:mm:ss tt", "HH:mm:ss").ToString()
        End With

        culture.NumberFormat = numberFormat
        culture.DateTimeFormat = dateFormat

        System.Threading.Thread.CurrentThread.CurrentCulture = culture
    End Sub

    Public Sub ReadRegistry() Implements IPOSFramework.ReadRegistry
        Try
            Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\ewave")

            If key Is Nothing Then
                mTerminalId = ""
            Else
                mTerminalId = key.GetValue("TerminalId", "").ToString()
                key.Close()
            End If
        Catch oEx As Exception
        End Try
    End Sub

    Public Function CheckTrial() As Boolean Implements IPOSFramework.CheckTrial
        Dim key() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}

        Dim iv() As Byte = {65, 110, 68, 26, 69, 178, 200, 219}

        Dim aux As String
        Dim dte As DateTime
        Dim days As Integer

        Try
            Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\ewave", True)
            aux = ewave.Tools.ProtectData.DecryptData(regKey.GetValue("InstallDate", String.Empty).ToString(), key, iv)
            days = Int32.Parse(ewave.Tools.ProtectData.DecryptData(regKey.GetValue("TrialDays", "0").ToString(), key, iv))
            regKey.Close()

            Dim arr() As String = aux.Split("-"c)

            dte = New DateTime(Int32.Parse(arr(0)), Int32.Parse(arr(1)), Int32.Parse(arr(2))).AddDays(days)

            Return Date.Now.Date < dte
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function PrevInstance() As Boolean Implements IPOSFramework.PrevInstance
        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ExitFW() Implements IPOSFramework.ExitFW
        If Not mConn Is Nothing AndAlso mConn.State <> ConnectionState.Closed Then
            mConn.Close()
        End If
    End Sub

    Public Overridable Function CheckIfTerminalRegistered() As Boolean Implements IPOSFramework.CheckIfTerminalRegistered
        mTerminalId = ewave.TerminalConfig.DataLayer.GetTerminalInRegistry()

        Return mTerminalId <> ""
    End Function

    Public Sub StartLog(ByVal LogFilePath As String) Implements IPOSFramework.StartLog
        mLogFile = New ewave.EventLog.LogFile(LogFilePath, mSysModuleValue.ToString())
        mLogFile.BeginLog()
    End Sub

    Public Function HasVoucherValidator() As Boolean Implements IPOSFramework.HasVoucherValidator
        Dim par As String = mParams.GetString("VVLOCATION")
        Return (Not par Is Nothing AndAlso par.Length > 0)
    End Function


    Public Sub GetTerminalProperties() Implements IPOSFramework.GetTerminalProperties
        Dim cmd As IDbCommand = mConn.CreateCommand

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "TRM_GetTerminal"
        Dim par As IDataParameter = cmd.CreateParameter
        par.ParameterName = "TerminalId"
        par.DbType = DbType.StringFixedLength
        par.Value = mTerminalId
        cmd.Parameters.Add(par)
        'cmd.Parameters.Add("TerminalId", OleDb.OleDbType.Char, 5).Value = mFwk.TerminalId
        'cmd.Parameters.Add("SiteId", OleDb.OleDbType.Char, 10).Value = EnvironmentObjects.Fwk.SiteId

        Dim dr As IDataReader = Nothing

        Try
            dr = cmd.ExecuteReader

            If dr.Read() Then
                'impresoras
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_Printer")) Then
                    mTicketPrinterCode = CStr(dr("TRM_Printer")).TrimEnd
                End If
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_PrinterConnectionType")) Then
                    mTicketPrinterConnection = CStr(dr("TRM_PrinterConnectionType"))
                End If
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_PrinterConnectionParameters")) Then
                    mTicketPrinterParameters = CStr(dr("TRM_PrinterConnectionParameters")).TrimEnd
                End If

                If Not dr.IsDBNull(dr.GetOrdinal("TRM_FiscalPrinter")) Then
                    mFiscalPrinterCode = CStr(dr("TRM_FiscalPrinter")).TrimEnd
                End If
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_FiscalPrinterConnectionType")) Then
                    mFiscalPrinterConnection = CStr(dr("TRM_FiscalPrinterConnectionType"))
                End If
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_FiscalPrinterConnectionParameters")) Then
                    mFiscalPrinterParameters = CStr(dr("TRM_FiscalPrinterConnectionParameters")).TrimEnd
                End If

                If Not dr.IsDBNull(dr.GetOrdinal("TRM_WinDriverPrinterName")) Then
                    mWindowsPrinter = CStr(dr("TRM_WinDriverPrinterName")).TrimEnd
                End If

                'lectores de tarjetas
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_CCR_Id")) Then
                    mCardReaderType = CStr(dr("CCR_Type")).TrimEnd
                    If Not dr.IsDBNull(dr.GetOrdinal("TRM_CCR_Pars")) Then
                        mCardReaderParameters = CStr(dr("TRM_CCR_Pars")).TrimEnd
                    End If
                End If

                If Not dr.IsDBNull(dr.GetOrdinal("TRM_MBR_CCR_Id")) Then
                    mMembershipCardReaderType = CStr(dr("MBR_CCR_Type")).TrimEnd
                    If Not dr.IsDBNull(dr.GetOrdinal("TRM_MBR_CCR_Pars")) Then
                        mMembershipCardReaderParameters = CStr(dr("TRM_MBR_CCR_Pars")).TrimEnd
                    End If
                End If

                'Parámetros extra del autorizador
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_AUT_Pars")) Then
                    mAuthorizatorTerminalParameters = CStr(dr("TRM_AUT_Pars")).TrimEnd
                End If

                'Customer Display
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_CustDisplay")) Then
                    mCustDisplayCode = CStr(dr("TRM_CustDisplay")).TrimEnd
                End If

                If Not dr.IsDBNull(dr.GetOrdinal("TRM_CustDisplayParameters")) Then
                    mCustDisplayPar = CStr(dr("TRM_CustDisplayParameters")).TrimEnd
                End If

                'POSCode
                If Not dr.IsDBNull(dr.GetOrdinal("TRM_POSCode")) Then
                    mPOSCode = CStr(dr("TRM_POSCode")).TrimEnd
                End If

                mTerminalSiteId = dr.GetString(dr.GetOrdinal("TRM_SIT_Id")).TrimEnd()
                mWorkingSiteId = mTerminalSiteId

            End If


        Catch ex As Exception
            Throw ex
        Finally
            If dr IsNot Nothing Then dr.Close()
        End Try

    End Sub

    Public Sub InitCardReader() Implements IPOSFramework.InitCardReader

        mCardReader = ewave.CardReader.CardReaderBuilder.GetCardReader(mCardReaderType)


        If mCardReaderParameters IsNot Nothing Then
            If mCardReaderParameters.StartsWith("+|") Then
                'Por ahora no hay que hacer ningún merge, así que se descarta
                mCardReaderParameters = mCardReaderParameters.Substring(1)
            End If
        End If

        If mCardReaderParameters.Length > 0 Then
            Dim par As String() = mCardReaderParameters.Split(" "c)
            Dim parVal As String()
            Dim HashT As New Hashtable
            For Each st As String In par
                parVal = st.Split("="c)
                If parVal.GetLength(0) = 2 Then
                    HashT.Add(parVal(0), parVal(1))
                ElseIf parVal.GetLength(0) = 3 Then
                    'quiere decir que el valor es '='
                    HashT.Add(parVal(0), "=")
                End If
            Next
            '2 min de timeout
            mCardReader.Initialize(HashT, 120)

        End If
    End Sub

    Public Sub InitMembershipCardReader() Implements IPOSFramework.InitMembershipCardReader

        mMembershipCardReader = ewave.CardReader.CardReaderBuilder.GetCardReader(mMembershipCardReaderType)

        If mMembershipCardReaderParameters.Length > 0 Then
            Dim par As String() = mMembershipCardReaderParameters.Split(" "c)
            Dim parVal As String()
            Dim HashT As New Hashtable
            For Each st As String In par
                parVal = st.Split("="c)
                If parVal.GetLength(0) = 2 Then
                    HashT.Add(parVal(0), parVal(1))
                ElseIf parVal.GetLength(0) = 3 Then
                    'quiere decir que el valor es '='
                    HashT.Add(parVal(0), "=")
                End If
            Next
            '2 min de timeout
            mMembershipCardReader.Initialize(HashT, 120)

        End If
    End Sub

    Public Function GetTransactionNumber() As Integer Implements IPOSFramework.GetTransactionNumber

        Dim cmd As IDbCommand = mConn.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "TRN_GetTransactionNumber"

        Dim par As IDataParameter = cmd.CreateParameter
        par.ParameterName = "TransactionNumber"
        par.DbType = DbType.Int32
        par.Direction = ParameterDirection.Output

        cmd.Parameters.Add(par)
        cmd.ExecuteNonQuery()

        Return Convert.ToInt32(par.Value)

    End Function

    Public Sub LoadUserSites() Implements IPOSFramework.LoadUserSites

        If mUser Is Nothing Then
            Throw New Exception("Current user is null, can´t load user sites.")
        End If

        Dim cmd As OleDb.OleDbCommand = mConn.CreateCommand

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "USI_GetSitesByUser"
        cmd.Parameters.Add("UserId", OleDb.OleDbType.Char, 20).Value = mUser.Id
        cmd.Parameters.Add("TerminalId", OleDb.OleDbType.Char, 10).Value = mTerminalId

        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader

        mUserSites = New List(Of Site)()

        Do While dr.Read()
            mUserSites.Add(New Site(dr.GetString(dr.GetOrdinal("SIT_Id")).TrimEnd(), dr.GetString(dr.GetOrdinal("SIT_Name")).TrimEnd()))
        Loop

        dr.Close()
    End Sub

    Public Sub GetCommandLineArgs() Implements IPOSFramework.GetCommandLineArgs
        Dim Args() As String = Environment.GetCommandLineArgs
        Dim KeyValue() As String

        For Each Arg As String In Args
            'argumentos con valor
            If Arg.IndexOf("="c) > -1 Then
                KeyValue = Arg.Split("=")
                Select Case KeyValue(0).ToLower
                    Case "usr"
                        If KeyValue(1).Trim.Length > 0 Then
                            mCmLineUserName = KeyValue(1)
                        End If
                    Case "pwd"
                        If KeyValue(1).Trim.Length > 0 Then
                            mCmLinePassword = KeyValue(1)
                        End If
                End Select
            Else
                'argumentos simples
                If Arg = "/Sync" Then
                    OfflineManager.SyncOnly = True
                End If
            End If
        Next
    End Sub

    Public Overridable Sub ReOpenConnection()
        LogFile.LogEvent("ReOpenConnection")

        If mConn.State = ConnectionState.Broken Or mConn.State = ConnectionState.Closed Then
            mConn.Open()
        End If

    End Sub

    Public Overridable Sub ShowException(ByVal Ex As Exception)
        'xxxx()
    End Sub

    Public Overridable Sub PopMessage(ByVal Message As String, ByVal caption As String, ByVal iconError As Boolean)

    End Sub

    Public Overridable Function PopAskMessage(ByVal Message As String, ByVal caption As String) As Boolean
        Return False
    End Function

    Public Overridable Sub LoadOrOpenSession()
        Dim oSessionMgr As New SessionManager(SqlConnection)

        mSessionId(TerminalSiteId) = oSessionMgr.GetCurrentSession(mUser.Id, mTerminalId, SessionManager.ModuleEnum.ecomPOS, TerminalSiteId)

        mNewSession = False
        If mSessionId(TerminalSiteId) = -1 Then
            SessionId(TerminalSiteId) = oSessionMgr.OpenSession(mUser.Id, mTerminalId, SessionManager.ModuleEnum.ecomPOS, mTerminalSiteId)
            mNewSession = True
        End If

        If mSessionId(TerminalSiteId) <> -1 Then
            oSessionMgr.RegisterSession(mSessionId(TerminalSiteId), mTerminalSiteId)
        End If
    End Sub

    Public MustOverride Sub ShowWorkingDialog(ByVal message As String)
    Public MustOverride Sub HideWorkingDialog(ByVal ShouldClose As Boolean)

    Public Function InitConnection(ByVal smod As SysModule, ByVal useOffline As Boolean) As Boolean Implements IPOSFramework.InitConnection
        Dim retVal As Boolean
        Dim offCinfo As ConnectionInfo = Nothing

        If useOffline AndAlso OfflineManager.IsTransferDataInstalled Then
            offCinfo = New ConnectionInfo()
            If offCinfo.GetConnectionInfo("Offline") Then
                OfflineManager.ConnString = offCinfo.SQLConnectionString
            Else
                Throw New SystemException("No se encontró la información de la conexión offline en el archivo de conexión")
            End If
        End If

        Try
            If smod = POSResources.SysModule.ecom Then
                mConn = New SqlClient.SqlConnection(mConnInfo.SQLConnectionString)
            Else
                mConn = New OleDb.OleDbConnection(mConnInfo.OLEDBConnectionString)
            End If
            mConn.Open()

            Dim oCmd As IDbCommand = mConn.CreateCommand
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = "MNT_SetupConnection"
            oCmd.ExecuteNonQuery()

            mConnected = True
            retVal = True
        Catch ex As Exception
            If useOffline AndAlso OfflineManager.IsTransferDataInstalled Then
                mConn = New OleDb.OleDbConnection(offCinfo.OLEDBConnectionString)
                mConn.Open()
                mConnected = False
                'reemplazo el conninfo
                mConnInfo = offCinfo
                retVal = True
            Else
                retVal = False
            End If
        End Try


        Return retVal

    End Function

    Public Function CheckAndReopenConnection() As Boolean Implements IPOSFramework.CheckAndReopenConnection
        Dim retVal As Boolean = False

        If mConn Is Nothing Then Return False

        If (mConn.State = ConnectionState.Broken OrElse mConn.State = ConnectionState.Closed) Then
            Try
                mConn.Close()
                mConn.Open()
                retVal = True
            Catch ex As Exception
                retVal = False
            End Try
        Else
            retVal = True
        End If


        Return retVal
    End Function

#End Region

#Region " Properties "

    Public Property IDBConnection() As IDbConnection Implements IPOSFramework.IDBConnection
        Get
            Return mConn
        End Get
        Set(ByVal Value As IDbConnection)
            mConn = Value
        End Set
    End Property

    Public Property SqlConnection() As SqlClient.SqlConnection Implements IPOSFramework.SqlConnection
        Get
            Return DirectCast(mConn, SqlClient.SqlConnection)
        End Get
        Set(ByVal Value As SqlClient.SqlConnection)
            mConn = Value
        End Set
    End Property

    Public Property OleDBConnection() As OleDb.OleDbConnection Implements IPOSFramework.OleDBConnection
        Get
            Return DirectCast(mConn, OleDb.OleDbConnection)
        End Get
        Set(ByVal Value As OleDb.OleDbConnection)
            mConn = Value
        End Set
    End Property

    Public ReadOnly Property TerminalId() As String Implements IPOSFramework.TerminalId
        Get
            Return mTerminalId
        End Get
    End Property

    Public Property User() As ewave.AccessController.User Implements IPOSFramework.User
        Get
            Return mUser
        End Get
        Set(ByVal Value As ewave.AccessController.User)
            mUser = Value
        End Set
    End Property

    Public Property SessionId(ByVal SiteId As String) As Integer Implements IPOSFramework.SessionId
        Get
            If mSessionId.ContainsKey(SiteId) Then
                Return mSessionId(SiteId)
            Else
                Return -1
            End If

        End Get
        Set(ByVal Value As Integer)
            If mSessionId.ContainsKey(SiteId) Then
                mSessionId(SiteId) = Value
            Else
                mSessionId.Add(SiteId, Value)
            End If
        End Set
    End Property

    Public Property CloseAsSoonAsPossible() As Boolean Implements IPOSFramework.CloseAsSoonAsPossible
        Get
            Return mCloseASAP
        End Get
        Set(ByVal Value As Boolean)
            mCloseASAP = Value
        End Set
    End Property

    Public ReadOnly Property NewSession() As Boolean Implements IPOSFramework.NewSession
        Get
            Return mNewSession
        End Get
    End Property

    Public Property Parameters() As Parameters Implements IPOSFramework.Parameters
        Get
            Return mParams
        End Get
        Set(ByVal Value As Parameters)

            mParams = Value

            If (Value IsNot Nothing) Then
                LoadWorkingParameters()
            End If

        End Set
    End Property

    Public ReadOnly Property AuditLogWriter() As AuditLogWriter Implements IPOSFramework.AuditLogWriter
        Get
            Return mAudit
        End Get
    End Property

    Public ReadOnly Property Printer() As PrinterController Implements IPOSFramework.Printer
        Get
            Return mPrinter
        End Get
    End Property

    Public ReadOnly Property FiscalPrinter() As FiscalPrinterController Implements IPOSFramework.FiscalPrinter
        Get
            Return mFiscalPrinter
        End Get
    End Property

    Public Property LogFile() As ewave.EventLog.LogFile Implements IPOSFramework.LogFile
        Get
            Return mLogFile
        End Get
        Set(ByVal Value As ewave.EventLog.LogFile)
            mLogFile = Value
        End Set
    End Property

    Public ReadOnly Property CreditCardAuthorizator() As AuthorizatorBase Implements IPOSFramework.CreditCardAuthorizator
        Get
            Return mCreditCardAuthorizator
        End Get
    End Property

    Public Property MemberShipClient() As ewave.MemberInterfaces.IMemberManagement Implements IPOSFramework.MemberShipClient
        Get
            Return mMbrClient
        End Get
        Set(ByVal value As ewave.MemberInterfaces.IMemberManagement)
            mMbrClient = value
        End Set
    End Property

    Public Property MemberShipPointClient() As ewave.MemberInterfaces.IPointManagement Implements IPOSFramework.MemberShipPointClient
        Get
            Return mMbrPointCli
        End Get
        Set(ByVal value As ewave.MemberInterfaces.IPointManagement)
            mMbrPointCli = value
        End Set
    End Property

    Public Property MemberShipWalletClient_2() As ewave.MemberInterfaces.IWalletManagement_2 Implements IPOSFramework.MemberShipWalletClient_2
        Get
            Return mMbrWalletCli_2
        End Get
        Set(ByVal value As ewave.MemberInterfaces.IWalletManagement_2)
            mMbrWalletCli_2 = value
        End Set
    End Property

    Public Property MemberShipWalletClient() As ewave.MemberInterfaces.IWalletManagement Implements IPOSFramework.MemberShipWalletClient
        Get
            Return mMbrWalletCli
        End Get
        Set(ByVal value As ewave.MemberInterfaces.IWalletManagement)
            mMbrWalletCli = value
        End Set
    End Property

    Public Property MemberShipUserClient() As ewave.MemberInterfaces.IUserManagement Implements IPOSFramework.MemberShipUserClient
        Get
            Return mMbrUserCli
        End Get
        Set(ByVal value As ewave.MemberInterfaces.IUserManagement)
            mMbrUserCli = value
        End Set
    End Property

    Public Property LastAction() As Date Implements IPOSFramework.LastAction
        Get
            Return mLastAction
        End Get
        Set(ByVal value As Date)
            mLastAction = value
        End Set
    End Property

    Public Property WorkingSiteId() As String Implements IPOSFramework.WorkingSiteId
        Get
            Return mWorkingSiteId
        End Get
        Set(ByVal value As String)
            mWorkingSiteId = value
        End Set
    End Property

    Public ReadOnly Property TerminalSiteId() As String Implements IPOSFramework.TerminalSiteId
        Get
            Return mTerminalSiteId
        End Get
    End Property

    Public ReadOnly Property TerminalSite() As Site Implements IPOSFramework.TerminalSite
        Get
            For Each s As Site In mUserSites
                If s.Id = mTerminalSiteId Then
                    Return s
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property SystemUserId() As String Implements IPOSFramework.SystemUserId
        Get
            Return "system"
        End Get
    End Property

    Public ReadOnly Property GlobalResources() As ewave.GlobalResourcesEngine.ResourceLoader Implements IPOSFramework.GlobalResources
        Get
            Return mGlobalResources
        End Get
    End Property

    Public ReadOnly Property POSCode() As String Implements IPOSFramework.POSCode
        Get
            Return mPOSCode
        End Get
    End Property

    Public ReadOnly Property HaveFiscalPrinter() As Boolean Implements IPOSFramework.HaveFiscalPrinter
        Get
            Return mHaveFiscalPrinter
        End Get
    End Property

    Public ReadOnly Property PrintCinemaTicketWithFiscalPrinter() As Boolean Implements IPOSFramework.PrintCinemaTicketWithFiscalPrinter
        Get
            Return mPrintCinemaTicketWithFP
        End Get
    End Property

    Public ReadOnly Property CardReader() As CardReaderBase Implements IPOSFramework.CardReader
        Get
            Return mCardReader
        End Get
    End Property

    Public ReadOnly Property MembershipCardReader() As CardReaderBase Implements IPOSFramework.MembershipCardReader
        Get
            Return mMembershipCardReader
        End Get
    End Property

    Public ReadOnly Property ConnInfo() As ConnectionInfo Implements IPOSFramework.ConnInfo
        Get
            Return mConnInfo
        End Get
    End Property

    Public ReadOnly Property CommandLineArgs() As StringDictionary Implements IPOSFramework.CommandLineArgs
        Get
            If mCmLineArgs Is Nothing Then
                mCmLineArgs = New StringDictionary()
                Dim Args() As String = Environment.GetCommandLineArgs
                Dim KeyValue() As String
                For Each Arg As String In Args
                    'argumentos con valor (ej: usr=mike)
                    If Arg.IndexOf("="c) > -1 Then
                        KeyValue = Arg.Split("=")
                        mCmLineArgs.Add(KeyValue(0), KeyValue(1))
                    Else
                        'argumentos simples (eh: /sync o sync)
                        mCmLineArgs.Add(Arg, String.Empty)
                    End If
                Next
            End If
            Return mCmLineArgs
        End Get
    End Property

    Public ReadOnly Property UserSites() As List(Of Site) Implements IPOSFramework.UserSites
        Get
            Return mUserSites
        End Get
    End Property

    Public ReadOnly Property SysModule() As SysModule Implements IPOSFramework.SysModule
        Get
            Return mSysModuleValue
        End Get
    End Property

    Public Property Connected() As Boolean Implements IPOSFramework.Connected
        Get
            Return mConnected
        End Get
        Set(ByVal value As Boolean)
            mConnected = value
        End Set
    End Property


    Public ReadOnly Property CmLineUserName() As String Implements IPOSFramework.CmLineUserName
        Get
            Return mCmLineUserName
        End Get
    End Property

    Public ReadOnly Property CmLinePass() As String Implements IPOSFramework.CmLinePass
        Get
            Return mCmLinePassword
        End Get
    End Property

#End Region


    'Public Event FpReqData(ByRef req As FiscalPrinter.DataRequest)
    'Private Sub mFiscalPrinter_RequestData(ByRef req As FiscalPrinter.DataRequest) Handles mFiscalPrinter.RequestData
    '    RaiseEvent FpReqData(req)
    'End Sub

#Region "Quadion methods for web atm"

    Public Function GetConnectionInfo() As Boolean Implements IPOSFramework.GetConnectionInfo
        Dim args As String()
        Dim name As String = String.Empty
        Dim nI As Integer

        args = Environment.GetCommandLineArgs

        For nI = 0 To args.Length - 1
            If (args(nI).Length >= 3) Then
                If args(nI).Substring(1, 2) = "ls" Then
                    If (args(nI).Length >= 5) Then
                        name = args(nI).Substring(4)
                        Exit For
                    End If
                End If
            End If
        Next

        If mConnInfo Is Nothing Then mConnInfo = New ConnectionInfo()

        Return mConnInfo.GetConnectionInfo(name)
    End Function

#End Region

End Class


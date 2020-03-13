Imports igp.AccessController
'Imports ewave.CardAuthorizationInterfaces
'Imports ewave.CardReader
'Imports ewave.EventLog
'Imports ewave.FiscalPrinter
'Imports ewave.GlobalResourcesEngine
'Imports ewave.MemberInterfaces
'Imports ewave.POSResources.CommonClasses
'Imports ewave.TicketPrinter
Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Interface IPOSFramework
    Property IDBConnection() As IDbConnection

    Property SqlConnection() As SqlConnection

    Property OleDBConnection() As OleDbConnection

    ReadOnly Property TerminalId() As String

    'Property User() As User

    Property SessionId(ByVal SiteId As String) As Integer

    Property CloseAsSoonAsPossible() As Boolean

    ReadOnly Property NewSession() As Boolean

    Property Parameters() As Parameters

    'ReadOnly Property AuditLogWriter() As AuditLogWriter

    'ReadOnly Property Printer() As PrinterController

    'ReadOnly Property FiscalPrinter() As FiscalPrinterController

    'Property LogFile() As LogFile

    'ReadOnly Property CreditCardAuthorizator() As AuthorizatorBase

    'Property MemberShipClient() As IMemberManagement

    'Property MemberShipPointClient() As IPointManagement

    'Property MemberShipWalletClient() As IWalletManagement

    'Property MemberShipWalletClient_2() As IWalletManagement_2

    'Property MemberShipUserClient() As IUserManagement

    Property LastAction() As DateTime

    Property WorkingSiteId() As String

    ReadOnly Property TerminalSiteId() As String

    'ReadOnly Property TerminalSite() As Site

    ReadOnly Property SystemUserId() As String

    'ReadOnly Property GlobalResources() As ResourceLoader

    ReadOnly Property POSCode() As String

    ReadOnly Property HaveFiscalPrinter() As Boolean

    ReadOnly Property PrintCinemaTicketWithFiscalPrinter() As Boolean

    'ReadOnly Property CardReader() As CardReaderBase

    'ReadOnly Property MembershipCardReader() As CardReaderBase

    ReadOnly Property ConnInfo() As ConnectionInfo

    ReadOnly Property CommandLineArgs() As StringDictionary

    'ReadOnly Property UserSites() As List(Of Site)

    ReadOnly Property SysModule() As SysModule

    Property Connected() As Boolean

    ReadOnly Property CmLineUserName() As String

    ReadOnly Property CmLinePass() As String

    Sub LoadWorkingParameters()

    Function InitPrinters() As Boolean

    Sub InitializeCreditCardAuthorizator(ByVal AuthorizatorAltConnectionString As String)

    Sub InitializeMemberShipClient()

    Sub SetupLocalizationInfo()

    Sub ReadRegistry()

    Function CheckTrial() As Boolean

    Function PrevInstance() As Boolean

    Sub ExitFW()

    Function GetConnectionInfo() As Boolean

    Function CheckIfTerminalRegistered() As Boolean

    Sub StartLog(ByVal LogFilePath As String)

    Function HasVoucherValidator() As Boolean

    Sub GetTerminalProperties()

    Sub InitCardReader()

    Sub InitMembershipCardReader()

    Function GetTransactionNumber() As Integer

    Sub LoadUserSites()

    Sub GetCommandLineArgs()

    Function InitConnection(ByVal smod As SysModule, ByVal useOffline As Boolean) As Boolean

    Function CheckAndReopenConnection() As Boolean
End Interface
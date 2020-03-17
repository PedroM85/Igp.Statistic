Imports Igp.AccessController
Imports Igp.POSResources
Imports System
Imports System.Resources

Public Interface IFrameworkBase
    Inherits IPOSFramework

    ' ReadOnly Property TicketManager() As TicketLayoutsManager

    ReadOnly Property CommunicationManager() As CommunicationManager

    'ReadOnly Property ImageCache() As ImageCache

    ReadOnly Property TransactionIconManager() As ResourceManager

    ReadOnly Property ResourceManager() As ResourceManager

    'ReadOnly Property HallInfo(ByVal siteId As String, ByVal hallId As String) As HallInfo

    ReadOnly Property ColorSchema() As ColorSchemaManager

    'ReadOnly Property CustDisplay() As CustomerDisplayManager

    'Sub LoadHallsInfo()

    Function Init(ByRef OutErrorMessage As String) As Boolean

    'Sub InitCustDisplay()

    ' Sub SetSatelliteDlls()

    Function GetConnectionString(Optional ByVal connected As Boolean = True) As String

    Sub CleanOldLogins()

    Function HasLicensesFree() As Boolean

    Function RegisterLogin(ByVal user As User) As Boolean

    Sub PingServer()

    Sub RegisterLogout()

    Sub LoadOrOpenSession()

    Function IsSessionOpened() As Boolean

    Sub ChangeWorkingSite(ByVal siteId As String)

    Function GetResource(ByVal sId As String) As Object

    Function GetTransactionIcon(ByVal sId As String) As Object

    ' Sub InitializeTranslatedResources()

    Function CheckIfPasswordMustBeChanged() As Boolean

    Sub HideMessagePopup()

    Function AskForAuthorisation(ByVal nAuthLevelRequested As Integer) As Boolean

    Sub ShowMessage(ByVal Message As String)

    Sub NewInstantMessage()

    Sub NewDeposit()

    Function GetAmountFromCalculator() As Double

    Sub ExecuteCalculator()

    Sub SetColorSchema()

    'Function InitializeProperties(ByRef OutErrorMessage As String, ByVal AuthorizatorAltConnectionString As String) As Boolean
End Interface

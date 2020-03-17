Imports System.ComponentModel

<CLSCompliant(True)>
Public Class UserMenuItem

    Private nId As Integer
    Private sName As String
    Private sDescription As String
    Private bIsFolder As Boolean
    Private bInHome As Boolean
    Private sTransId As String
    Private sResource As String
    Private oMenuItems As UserMenuItemCollection

    Public ReadOnly Property MenuItems() As UserMenuItemCollection
        Get
            If oMenuItems Is Nothing Then
                oMenuItems = New UserMenuItemCollection()
            End If
            Return oMenuItems
        End Get
    End Property

    Public Property Resource() As String
        Get
            Return sResource
        End Get
        Set(ByVal Value As String)
            sResource = Value
        End Set
    End Property

    Public Property Transaction() As String
        Get
            Return sTransId
        End Get
        Set(ByVal Value As String)
            sTransId = Value
        End Set
    End Property

    Public Property IsFolder() As Boolean
        Get
            Return bIsFolder
        End Get
        Set(ByVal Value As Boolean)
            bIsFolder = Value
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

    Public Property Name() As String
        Get
            Return sName
        End Get
        Set(ByVal Value As String)
            sName = Value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return nId
        End Get
        Set(ByVal Value As Integer)
            nId = Value
        End Set
    End Property

    Public Property ShowInHome() As Boolean
        Get
            Return bInHome
        End Get
        Set(ByVal Value As Boolean)
            bInHome = Value
        End Set
    End Property

    Public ReadOnly Property Key() As String
        Get
            Return String.Format(IIf(bIsFolder, "F|{0}", "I|{0}").ToString(), nId)
        End Get
    End Property

    Public Sub New()
        nId = -1
    End Sub


    Public Sub New(ByVal Id As Integer, ByVal Name As String, ByVal Description As String)
        nId = Id
        sDescription = Description
        sName = Name
    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Name As String, ByVal Description As String, ByVal IsFolder As Boolean, ByVal InHome As Boolean, ByVal TransactionId As String, ByVal Resource As String)
        nId = Id
        sDescription = Description
        sName = Name

        bIsFolder = IsFolder
        bInHome = InHome
        sTransId = TransactionId
        sResource = Resource
    End Sub

End Class

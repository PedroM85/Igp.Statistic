<Serializable> Public Class ConnectionInfo

    Private sName As String
    Private sServer As String
    Private sDatabase As String
    Private sUser As String
    Private sPassowrd As String
    Private lDefault As Boolean

    Public Property Name() As String
        Get
            Return sName
        End Get
        Set(value As String)
            sName = value
        End Set
    End Property

    Public Property Server() As String
        Get
            Return sServer
        End Get
        Set(value As String)
            sServer = value
        End Set
    End Property

    Public Property Database() As String
        Get
            Return sDatabase
        End Get
        Set(value As String)
            sDatabase = value
        End Set
    End Property

    Public Property User() As String
        Get
            Return sUser
        End Get
        Set(value As String)
            sUser = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return sPassowrd
        End Get
        Set(value As String)
            sPassowrd = value
        End Set
    End Property

    Public Property DefaultConnection() As Boolean
        Get
            Return lDefault
        End Get
        Set(value As Boolean)
            lDefault = value
        End Set
    End Property
End Class

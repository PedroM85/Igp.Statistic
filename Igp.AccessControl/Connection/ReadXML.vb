<CLSCompliant(True)>
Public Class ConnectionInfo

#Region " Instance Variables "

    Private sName As String
    Private sServer As String
    Private sDatabase As String
    Private sUserId As String
    Private sPassword As String
    Private sFileName As String
    Private nSPID As Integer

#End Region

#Region " Protect Data Bytes "

    Private bKey() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private bIV() As Byte = {65, 110, 68, 26, 69, 178, 200, 219}

#End Region

#Region " Methods "

    Public Sub New(ByVal LogonInfoPath As String)
        sFileName = LogonInfoPath & "\IgpManager.xml"
    End Sub
    Public Sub New()
        Me.New(Windows.Forms.Application.StartupPath)
    End Sub
    Public Overloads Function GetConnectionInfo(ByVal sName As String) As Boolean
        Return ReadLogonInfoXML(sName)
    End Function

    Public Overloads Function GetConnectionInfo() As Boolean
        Return GetConnectionInfo("")
    End Function

    Private Function ReadLogonInfoXML(ByVal sFindName As String) As Boolean
        Dim oXML As Xml.XmlDocument = New Xml.XmlDocument
        Dim oElmnt As Xml.XmlElement
        Dim sXPath As String

        Try


            oXML.Load(sFileName)





                If sFindName = String.Empty Then
                sXPath = "//ConnectionInfo[@Default='True']"
            Else
                sXPath = String.Format("//ConnectionInfo[@Name='{0}']", sFindName)
            End If

            oElmnt = CType(oXML.SelectSingleNode(sXPath), Xml.XmlElement)

            If Not oElmnt Is Nothing Then
                With oElmnt
                    'Modificado FS
                    If .GetAttribute("Server") = vbNullString Then
                        sName = .GetAttribute("Name")
                        sDatabase = System.Windows.Forms.Application.StartupPath & "\" & .GetAttribute("Database")
                        sUserId = .GetAttribute("User")
                        'sPassword = ewave.Tools.ProtectData.DecryptData(.GetAttribute("Password"), bKey, bIV)
                        sPassword = .GetAttribute("Password")
                    Else
                        sName = .GetAttribute("Name")
                        sServer = .GetAttribute("Server")
                        sDatabase = .GetAttribute("Database")
                        sUserId = .GetAttribute("User")
                        'sPassword = ewave.Tools.ProtectData.DecryptData(.GetAttribute("Password"), bKey, bIV)
                        sPassword = .GetAttribute("Password")
                    End If
                End With
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub TestConnectionInfo(ByVal sFindName As String)
        'obtengo la cadena de conexion
        If System.IO.File.Exists(sFileName) Then
            If GetConnectionInfo(sFindName) Then
                If TestConnection(SQLConnectionString) Then
                    Return
                Else
                    Throw New Exception("Database connection failed")
                End If
            Else
                Throw New Exception("Could not read LogonInfo")
            End If
        Else
            Throw New Exception("Could not find LogonInfo ")
        End If
    End Sub

    Public Sub TestConnectionInfo()

        'obtengo la cadena de conexion
        If System.IO.File.Exists(sFileName) Then
            If GetConnectionInfo() Then
                If TestConnection(SQLConnectionString) Then
                    Return
                Else
                    Throw New Exception("Database connection failed")
                End If
            Else
                Throw New Exception("Could not read LogonInfo")
            End If
        Else
            Throw New Exception("Could not find LogonInfo ")
        End If
    End Sub

    Private Function TestConnection(ByVal ConnectionString As String) As Boolean
        Dim cnn As New SqlClient.SqlConnection(ConnectionString)
        Try
            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cnn.Close()
            cnn.Dispose()
        End Try
    End Function

#End Region

#Region " Properties "

    Public ReadOnly Property Name() As String
        Get
            Return sName
        End Get
    End Property

    Public ReadOnly Property Server() As String
        Get
            Return sServer
        End Get
    End Property

    Public ReadOnly Property Database() As String
        Get
            Return sDatabase
        End Get
    End Property

    Public ReadOnly Property UserId() As String
        Get
            Return sUserId
        End Get
    End Property

    Public ReadOnly Property Password() As String
        Get
            Return sPassword
        End Get
    End Property

    Public ReadOnly Property OLEDBConnectionString(Optional ByVal AppName As String = Nothing, Optional ByVal AlternativeDB As String = Nothing) As String
        Get
            If AppName Is Nothing Then
                AppName = "Ewave"
            End If
            If AlternativeDB Is Nothing Then
                AlternativeDB = sDatabase
            End If
            Return String.Format("Provider=SQLOLEDB.1;Password={3};Persist Security Info=True;User ID={2};Initial Catalog={1};Data Source={0};Application Name={4}", New String() {sServer, AlternativeDB, sUserId, sPassword, AppName})
        End Get
    End Property

    Public ReadOnly Property SQLConnectionString(Optional ByVal AppName As String = Nothing, Optional ByVal AlternativeDB As String = Nothing) As String
        Get
            If AppName Is Nothing Then
                AppName = "Ewave"
            End If
            If AlternativeDB Is Nothing Then
                AlternativeDB = sDatabase
            End If
            Return String.Format("Persist Security Info=False;Integrated Security=False;database={1};server={0};Connect Timeout=30;User Id={2};Pwd={3};Application Name={4}", New String() {sServer, AlternativeDB, sUserId, sPassword, AppName})
        End Get
    End Property

    Public Property SPID() As Integer
        Get
            Return nSPID
        End Get
        Set(ByVal value As Integer)
            nSPID = value
        End Set
    End Property

#End Region

End Class

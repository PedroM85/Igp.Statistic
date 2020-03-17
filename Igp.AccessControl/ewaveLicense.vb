Option Strict On
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO
Imports System.Security
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Collections.Generic

<Serializable()>
Public Class ewaveLicense
    Implements ICloneable

    <Serializable()>
    Public Class ewaveModule
        Implements ICloneable
        'Implements IXmlSerializable

        'Public Function GetSchema() As System.Xml.Schema.XmlSchema Implements IXmlSerializable.GetSchema
        '    Throw New NotImplementedException()
        'End Function

        'Public Sub ReadXml(ByVal reader As XmlReader) Implements IXmlSerializable.ReadXml
        '    Throw New NotImplementedException()
        'End Sub


        'Public Sub WriteXml(ByVal writer As XmlWriter) Implements IXmlSerializable.WriteXml
        '    Throw New NotImplementedException()
        'End Sub

        Private mModuleId As Integer
        Public Property ModuleId() As Integer
            Get
                Return mModuleId
            End Get
            Set(ByVal value As Integer)
                mModuleId = value
            End Set
        End Property
        Private mMaxLics As Integer
        Public Property MaxLics() As Integer
            Get
                Return mMaxLics
            End Get
            Set(ByVal value As Integer)
                mMaxLics = value
            End Set
        End Property
        Sub New(ByVal aModuleId As Integer, ByVal aMaxLics As Integer)
            ModuleId = aModuleId
            MaxLics = aMaxLics
        End Sub
        Sub New()
            ModuleId = -1
            MaxLics = -1
        End Sub
        Public Function Clone() As Object Implements ICloneable.Clone

            Dim rtn As ewaveModule = Nothing


            Dim bf As BinaryFormatter = New BinaryFormatter()
            Dim memStream As MemoryStream = New MemoryStream()
            bf.Serialize(memStream, Me)
            memStream.Flush()
            memStream.Position = 0
            rtn = (CType(bf.Deserialize(memStream), ewaveModule))
            Return rtn

            'Dim rtn As New ewaveModule
            'rtn.ModuleId = ModuleId
            'rtn.MaxLics = MaxLics
            'Return rtn
        End Function
    End Class

#Region "Properties"
    Private mClientId As String
    Public Property ClientId() As String
        Get
            Return mClientId
        End Get
        Set(ByVal value As String)
            mClientId = value
        End Set
    End Property

    Private mSiteid As String
    Public Property SiteId() As String
        Get
            Return mSiteid
        End Get
        Set(ByVal value As String)
            mSiteid = value
        End Set
    End Property

    Private mLicenseId As String = Guid.NewGuid().ToString("B")
    Public Property LicenseId() As String
        Get
            Return mLicenseId
        End Get
        Set(ByVal value As String)
            mLicenseId = value
        End Set
    End Property

    Private mLicenseeName As String
    Public Property LicenseeName() As String
        Get
            Return mLicenseeName
        End Get
        Set(ByVal value As String)
            mLicenseeName = value
        End Set
    End Property

    Private mExpiryDate As Date
    Public Property ExpiryDate() As Date
        Get
            Return mExpiryDate
        End Get
        Set(ByVal value As Date)
            mExpiryDate = value
        End Set
    End Property

    Private mCreationDate As Date
    Public Property CreationDate() As Date
        Get
            Return mCreationDate
        End Get
        Set(ByVal value As Date)
            mCreationDate = value
        End Set
    End Property

    Private mHallsQuantity As Integer = 99
    Public Property HallsQuantity() As Integer
        Get
            Return mHallsQuantity
        End Get
        Set(ByVal value As Integer)
            mHallsQuantity = value
        End Set
    End Property

    Private mModules As List(Of ewaveModule)
    Public Property Modules() As List(Of ewaveModule)
        Get
            Return mModules
        End Get
        Set(ByVal value As List(Of ewaveModule))
            mModules = value
        End Set
    End Property
#End Region

    Public Function addModule(ByVal ModuleId As Integer, ByVal MaxLics As Integer) As ewaveModule
        Dim rtn As New ewaveModule(ModuleId, MaxLics)
        Modules.Add(rtn)
        Return rtn
    End Function

    Public Function MaxLics(ByVal ModuleId As Integer) As Integer
        Dim rtn As Integer = 0
        For Each ewm As ewaveModule In Modules
            If ewm.ModuleId = ModuleId Then
                rtn = ewm.MaxLics
                Exit For
            End If
        Next
        Return rtn
    End Function

    <NonSerialized()> Private Crypto As Rijndael

    Sub New()
        LicenseeName = ""
        SiteId = ""
        Modules = New List(Of ewaveModule)
        CreationDate = Now
        ExpiryDate = Now.AddYears(99)
        Crypto = InitKeys()
    End Sub

    Private Shared Function InitKeys() As Rijndael
        Dim rtn As Rijndael = Rijndael.Create()

        Dim thek As String = "wqPHv6NTNx2WFbax"
        thek = "yDIRCwJN0f4BUyZtvFY" + thek
        Dim ivk As String = "jP90txo9td5"
        thek += "OFqZJQLI="
        ivk += "5Fp9pUVmChw=="
        rtn.Key = Convert.FromBase64String(thek)
        rtn.IV = Convert.FromBase64String(ivk)

        Return rtn
    End Function

#Region "Importers"
    Public Shared Function fromXmlString(ByVal xmlString As String) As ewaveLicense
        'Return New ewaveLicenseItem(xmlString)
        Dim xs As New XmlSerializer(GetType(ewaveLicense))
        Dim ns As New XmlSerializerNamespaces()
        ns.Add("", "")

        Dim settings As New XmlWriterSettings()
        settings.OmitXmlDeclaration = True
        'settings.Indent = True
        Dim ms As New MemoryStream()
        Dim sw As New StreamWriter(ms)
        sw.Write(xmlString)
        sw.Flush()
        ms.Position = 0

        Return CType(xs.Deserialize(ms), ewaveLicense)
    End Function

    Public Shared Function fromXmlEncripted(ByVal encryptedString As String) As ewaveLicense
        Dim mycrypto As Rijndael = ewaveLicense.InitKeys
        Dim encb As Byte() = Convert.FromBase64String(encryptedString)
        Dim xmlstring As String = ewaveLicense.DecryptStringFromBytes(encb, mycrypto)
        Return ewaveLicense.fromXmlString(xmlstring)
    End Function

    Public Sub loadDataSource(ByVal DataRow As Data.DataRowView)
        mClientId = CType(DataRow.Row("SIT_CLI_Id"), String).Trim
        SiteId = CType(DataRow("SIT_SiteId"), String).Trim
        If Not IsDBNull(DataRow("SIT_HallQuantity")) Then

            HallsQuantity = Convert.ToInt32(DataRow("SIT_HallQuantity"))
        End If
    End Sub

    Public Shared Function fromDataSource(ByVal DataRow As Data.DataRowView) As ewaveLicense
        Dim rtn As New ewaveLicense
        rtn.loadDataSource(DataRow)
        Return rtn
    End Function
#End Region

    Sub New(ByVal Xml As String)
        Dim cpy As ewaveLicense = fromXmlString(Xml)
        Me.LicenseeName = cpy.LicenseeName
        Me.SiteId = cpy.SiteId
        Me.ExpiryDate = cpy.ExpiryDate
        If cpy.Modules IsNot Nothing Then
            Modules = New List(Of ewaveModule)
            For Each ewm As ewaveModule In cpy.Modules
                Modules.Add(ewm)
            Next
        End If

        InitKeys()
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        'Dim rtn As New ewaveLicense
        'rtn.LicenseeName = Me.LicenseeName
        'rtn.SiteId = Me.SiteId
        'rtn.HallsQuantity = Me.HallsQuantity
        'rtn.ExpiryDate = Me.ExpiryDate

        'If Modules IsNot Nothing Then
        '    rtn.Modules = New List(Of ewaveModule)
        '    For Each ewm As ewaveModule In Modules
        '        Dim newm As ewaveModule = CType(ewm.Clone, ewaveModule)
        '        rtn.Modules.Add(newm)
        '    Next
        'End If
        'Return rtn


        Dim rtn As ewaveLicense = Nothing

        Dim bf As BinaryFormatter = New BinaryFormatter()
        Dim memStream As MemoryStream = New MemoryStream()
        bf.Serialize(memStream, Me)
        memStream.Flush()
        memStream.Position = 0
        rtn = (CType(bf.Deserialize(memStream), ewaveLicense))
        Return rtn

    End Function

#Region "Exporters"
    Public Function ToXML() As String
        Dim xs As New XmlSerializer(GetType(ewaveLicense))
        Dim ns As New XmlSerializerNamespaces()
        ns.Add("", "")

        Dim settings As New XmlWriterSettings()
        settings.OmitXmlDeclaration = True

        settings.Indent = True

        Using ms As New MemoryStream(),
            sw As XmlWriter = XmlWriter.Create(ms, settings),
            sr As New StreamReader(ms)
            xs.Serialize(sw, Me, ns)
            ms.Position = 0
            Return sr.ReadToEnd()
        End Using
    End Function

    Public Shared Function DecryptStringFromBytes(ByVal cipherText() As Byte, ByVal sea As Rijndael) As String
        If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
            Throw New ArgumentNullException("cipherText")
        End If

        Dim plaintext As String = Nothing
        Dim decryptor As ICryptoTransform = sea.CreateDecryptor(sea.Key, sea.IV)

        Using msDecrypt As New MemoryStream(cipherText)
            Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                Using srDecrypt As New StreamReader(csDecrypt)
                    plaintext = srDecrypt.ReadToEnd()
                End Using
            End Using
        End Using
        Return plaintext
    End Function
#End Region

    Public Overloads Function DecryptData(ByVal encryptedString As String) As String
        Dim encb As Byte() = Convert.FromBase64String(encryptedString)
        Return DecryptData(encb)
    End Function

    Public Overloads Function DecryptData(ByVal encryptedBytes As Byte()) As String
        Return DecryptStringFromBytes(encryptedBytes, Crypto)
    End Function



End Class

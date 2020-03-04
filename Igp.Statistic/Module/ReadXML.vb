Imports System.IO
Imports System.Xml

Public Class ReadXML

    Public Function GetlogonSets() As Collection
        Dim oCol As Collection = New Collection
        Dim oXml As XmlDocument = New XmlDocument
        Dim nodX As XmlNode
        Dim oCI As ConnectionInfo


        If Not File.Exists(Application.StartupPath & "\IgpManager.xml") Then
            CreateXMLFile()

        End If

        Try
            oXml.Load(Application.StartupPath & "\IgpManager.xml")

        Catch ex As Exception
            oXml = CreateXMLFile()
        End Try

        For Each nodX In oXml.FirstChild.ChildNodes
            oCI = New ConnectionInfo

            oCI.Database = nodX.Attributes("Database").Value
            oCI.DefaultConnection = nodX.Attributes("Default").Value
            oCI.Name = nodX.Attributes("Name").Value
            oCI.Password = nodX.Attributes("Password").Value
            oCI.Server = nodX.Attributes("Server").Value
            oCI.User = nodX.Attributes("User").Value

            oCol.Add(oCI)
        Next

        Return oCol
    End Function

    Public Sub AddConnection(ByVal sName As String, ByVal sServer As String, ByVal sDatabase As String, ByVal sUser As String, ByVal sPassword As String, ByVal lDefault As Boolean)
        Dim oXML As XmlDocument = New XmlDocument
        Dim nodX As XmlNode
        Dim oElmnt As XmlElement

        oXML.Load(Application.StartupPath & "\IgpManager.xml")

        Dim oElemntFamily As XmlElement = Nothing
        nodX = oXML.SelectSingleNode("//LogonSets")

        If Not (nodX Is Nothing) Then
            If TypeOf nodX Is XmlElement Then
                oElemntFamily = CType(nodX, XmlElement)
            End If


            oElmnt = InsertNode(oXML, oElemntFamily, "ConnectionInfo")

            oElmnt.SetAttribute("Name", sName)
            oElmnt.SetAttribute("Server", sServer)
            oElmnt.SetAttribute("Database", sDatabase)
            oElmnt.SetAttribute("User", sUser)
            oElmnt.SetAttribute("Password", sPassword)

            If lDefault Then
                UnMarkDefaultAttrib(oXML)
            End If

            oElmnt.SetAttribute("Default", lDefault)

            oXML.Save(Application.StartupPath & "\IgpManager.xml")

        End If

    End Sub

    Public Sub EditConnectionInfo(ByVal sOriginalName As String, ByVal connectioninfo As ConnectionInfo)
        Dim oXML As XmlDocument = New XmlDocument
        'Dim nodX As XmlNode
        Dim oElmnt As XmlElement
        Dim sXPath As String

        oXML.Load(Application.StartupPath & "\IgpManager.xml")

        sXPath = String.Format("//ConnectionInfo[@Name='{0}']", sOriginalName)

        oElmnt = CType(oXML.SelectSingleNode(sXPath), XmlElement)

        oElmnt.SetAttribute("Name", connectioninfo.Name)
        oElmnt.SetAttribute("Server", connectioninfo.Server)
        oElmnt.SetAttribute("Database", connectioninfo.Database)
        oElmnt.SetAttribute("User", connectioninfo.User)
        oElmnt.SetAttribute("Password", connectioninfo.Password)

        If connectioninfo.DefaultConnection Then
            UnMarkDefaultAttrib(oXML)
        End If

        oElmnt.SetAttribute("Default", connectioninfo.DefaultConnection)

        oXML.Save(Application.StartupPath & "\IgpManager.xml")

    End Sub

    Public Sub DeleteConnectionInfo(ByVal connectioninfo As ConnectionInfo)
        Dim oXML As XmlDocument = New XmlDocument
        'Dim nodX As XmlNode
        Dim sXPath As String


        oXML.Load(Application.StartupPath & "\IgpManager.xml")

        sXPath = String.Format("//ConnectionInfo[@Name='{0}']", connectioninfo.Name)

        oXML.SelectSingleNode("//LogonSets").RemoveChild(oXML.SelectSingleNode(sXPath))

        oXML.Save(Application.StartupPath & "\IgpManager.xml")
    End Sub

    Public Function GetDefaultConnection() As String
        Dim oXML As XmlDocument = New XmlDocument
        Dim oElmnt As XmlElement
        Dim sXPath As String

        oXML.Load(Application.StartupPath & "\IgpManager.xml")

        sXPath = "//ConnectionInfo[@Default='True']"

        oElmnt = CType(oXML.SelectSingleNode(sXPath), XmlElement)

        If Not oElmnt Is Nothing Then
            Return oElmnt.GetAttribute("Name")
        Else
            Return String.Empty
        End If

    End Function

    Public Function NameExist(ByVal sName As String) As Boolean
        Dim oXML As XmlDocument = New XmlDocument
        Dim oElmnt As XmlElement
        Dim sXPath As String

        oXML.Load(Application.StartupPath & "\IgpManager.xml")

        sXPath = String.Format("//ConnectionInfo[@Name='{0}']", sName)

        oElmnt = CType(oXML.SelectSingleNode(sXPath), XmlElement)

        Return Not oElmnt Is Nothing

    End Function




    Private Sub UnMarkDefaultAttrib(ByVal oXML As XmlDocument)
        Dim nodX As XmlNode

        For Each nodX In oXML.FirstChild.ChildNodes
            CType(nodX, XmlElement).SetAttribute("Default", False)
        Next

    End Sub

    Private Function InsertNode(ByVal oXML As XmlDocument, ByVal nodX As XmlNode, ByVal sTag As String) As XmlElement
        Dim nodXTemp As XmlNode

        nodXTemp = oXML.CreateElement(sTag)

        nodX.AppendChild(nodXTemp)

        Return CType(nodXTemp, XmlElement)
    End Function

    Private Function CreateXMLFile() As XmlDocument
        Dim oXML As XmlDocument = New XmlDocument
        'Dim nodX As XmlNode


        oXML.AppendChild(oXML.CreateNode(XmlNodeType.Element, "LogonSets", ""))

        oXML.Save(Application.StartupPath & "\IgpManager.xml")

        Return oXML
    End Function


    Private bKey() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}

    'Private bKey() As Byte = {99, 104, 111, 114, 105, 122, 48, 109, 111, 114, 99, 105, 108, 108, 97, 109, 111, 108, 108, 101, 106, 97, 33, 33}

    Private bIV() As Byte = {65, 110, 68, 26, 69, 178, 200, 219}


    Friend ReadOnly Property ProtectDataKey() As Byte()
        Get
            Return bKey
        End Get
    End Property

    Friend ReadOnly Property ProtectDataIV() As Byte()
        Get
            Return bIV
        End Get
    End Property

End Class

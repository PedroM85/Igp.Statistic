Imports System.Net
Imports System.Net.Sockets

<CLSCompliant(True)>
Public Class CommunicationManager

#Region " Constants, instance variables & events declaration "

    Private Const RECV_BUFFER_SIZE As Integer = 1024
    Private Const MANAGER_LISTEN_PORT As Integer = 12000
    Private Const POS_LISTEN_PORT As Integer = 12001
    Private Const ECOM_POS_LISTEN_PORT As Integer = 12002

    Public Enum ModuleEnum
        Manager
        POS
        EcomPOS
        EcallManager
        Corporate
    End Enum

    'Private oSocket As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
    'Private oListeningPoint As IPEndPoint
    'Private oRecvEndPoint As IPEndPoint
    'Private oInBuf(RECV_BUFFER_SIZE) As Byte

    Public Event InstantMessageArrived(ByVal sMessage As String)
    Public Event Refresh()
    Public Event ShutdownRequest()

#End Region

#Region " Methods "

    Public Sub New(ByVal eModule As ModuleEnum)
        Dim nPort As Integer

        Select Case eModule
            Case ModuleEnum.POS : nPort = POS_LISTEN_PORT
            Case ModuleEnum.Manager : nPort = MANAGER_LISTEN_PORT
            Case ModuleEnum.EcomPOS : nPort = ECOM_POS_LISTEN_PORT
        End Select
        'oListeningPoint = New IPEndPoint(IPAddress.Any, nPort)
    End Sub

    'Public Sub Start()
    '    oRecvEndPoint = New IPEndPoint(IPAddress.Any, 0)

    '    oSocket.Bind(oListeningPoint)
    '    oSocket.BeginReceiveFrom(oInBuf, 0, RECV_BUFFER_SIZE, SocketFlags.None, CType(oRecvEndPoint, System.Net.EndPoint), New AsyncCallback(AddressOf AsyncRead), Nothing)
    'End Sub

    'Public Sub [Stop]()
    '    oSocket.Close()
    'End Sub

    Public Sub SendInstantMessage(ByVal eModule As ModuleEnum, ByVal sIP As String, ByVal sMessage As String)
        If sMessage.Length > 200 Then
            sMessage = sMessage.Substring(0, 200)
        End If
        Send(eModule, sIP, "MSG|" & sMessage)
    End Sub

    Public Sub SendDataRefresh(ByVal eModule As ModuleEnum, ByVal sIP As String)
        Send(eModule, sIP, "REF|")
    End Sub

    Public Sub SendShutdown(ByVal eModule As ModuleEnum, ByVal sIP As String)
        Send(eModule, sIP, "SHD|")
    End Sub

    Private Sub Send(ByVal eModule As ModuleEnum, ByVal sIP As String, ByVal sData As String)
        Dim nPort As Integer

        Select Case eModule
            Case ModuleEnum.POS : nPort = POS_LISTEN_PORT
            Case ModuleEnum.Manager : nPort = MANAGER_LISTEN_PORT
            Case ModuleEnum.EcomPOS : nPort = ECOM_POS_LISTEN_PORT
        End Select

        Dim bOutBuf() As Byte = System.Text.Encoding.ASCII.GetBytes(sData)
        Dim oEndPoint As New IPEndPoint(System.Net.IPAddress.Parse(sIP), nPort)
        'oSocket.SendTo(bOutBuf, oEndPoint)
    End Sub

    'Private Sub AsyncRead(ByVal ar As IAsyncResult)
    '    Dim oSenderEndPoint As New IPEndPoint(IPAddress.Any, 0)
    '    Dim nRead As Integer
    '    Try
    '        oRecvEndPoint = New IPEndPoint(IPAddress.Any, 0)
    '        nRead = oSocket.EndReceiveFrom(ar, CType(oSenderEndPoint, System.Net.EndPoint))
    '        oSocket.BeginReceiveFrom(oInBuf, 0, RECV_BUFFER_SIZE, SocketFlags.None, CType(oRecvEndPoint, System.Net.EndPoint), New AsyncCallback(AddressOf AsyncRead), Nothing)

    '        If nRead > 0 Then
    '            Dim sData As String = System.Text.Encoding.ASCII.GetString(oInBuf, 0, nRead)

    '            If sData.Length >= 4 Then
    '                Dim oMsg() As String = sData.Split(Convert.ToChar("|"))

    '                Select Case oMsg(0)
    '                    Case "MSG"
    '                        RaiseEvent InstantMessageArrived(oMsg(1))
    '                    Case "SHD"
    '                        RaiseEvent ShutdownRequest()
    '                    Case "REF"
    '                        RaiseEvent Refresh()
    '                End Select
    '            End If
    '        Else
    '            ' "Error!!!"
    '        End If
    '    Catch oEx As Exception

    '    End Try
    'End Sub

#End Region

End Class

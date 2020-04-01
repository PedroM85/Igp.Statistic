Imports System.Data.SqlClient
Imports Igp.AccessController
Public Class TempoDs
    Private cnPubs As SqlConnection
    Private daPubs As SqlDataAdapter
    Private cmdSelPubInfo As SqlCommand
    Private dsPubs As DataSet

    Public Sub New()

        ObtenerbyActive()

    End Sub

    Public Sub ObtenerbyActive()
        ConectarDB()


        cmdSelPubInfo = New SqlCommand()
        cmdSelPubInfo.Connection = Conn
        cmdSelPubInfo.CommandType = CommandType.StoredProcedure
        cmdSelPubInfo.CommandText = "SYS_SelectaTempoactive"


        ' DataApapter
        daPubs = New SqlDataAdapter()
        daPubs.SelectCommand = cmdSelPubInfo

        'Dataset
        dsPubs = New DataSet()

        'DesconectarDB()

    End Sub
    Public Function GetPubInfo() As DataSet

        daPubs.Fill(dsPubs)
        Return dsPubs
    End Function

    'Public Shared Function ObtenerClientes() As dsTemporada
    'Dim _DsClientes As New dsTemporada()
    ''Using cn As OleDbConnection = Conexion.Conectar("NorthwindConnectionString")
    ''cn.Open()
    'ConectarDB()

    'Dim cmd As SqlCommand

    'cmd = New SqlCommand("SYS_SelectallTempo", Conn)
    'cmd.CommandType = CommandType.StoredProcedure

    'Dim da As New SqlDataAdapter(cmd)

    'da.Fill(_DsClientes, "Temporadas")


    'Return _DsClientes

    'Dim _DsClientes As New dsTemporada()
    '    'Using cn As OleDbConnection = Conexion.Conectar("NorthwindConnectionString")
    '    ConectarDB()

    '    Using cmd As SqlCommand = Conn.CreateCommand()
    '        cmd.CommandText = "SELECT id, nPiloto, IdNacion FROM SYS_Piloto"
    '        Dim da As New SqlDataAdapter(cmd)
    '        da.Fill(_DsClientes)
    '    End Using
    '    'End Using
    '    Return _DsClientes
    'End Function
End Class

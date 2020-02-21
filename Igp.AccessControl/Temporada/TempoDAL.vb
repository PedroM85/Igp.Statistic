Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl.Conexion
Imports Igp.AccessControl
Imports System.Data.SqlClient
Imports System.Transactions

Public NotInheritable Class TempoDAL
    Inherits Conexion

    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"
    Public Shared Function ObtenerTodos() As List(Of TempoEntity)

        Dim Tempo As New List(Of TempoEntity)()

        'Try
        '    conectar()

        '    Dim cmd As New SqlCommand("SYS_SelectallTempo", RutaSQL)
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim rdr As SqlDataReader = cmd.ExecuteReader()


        '    While rdr.Read()
        '        Tempo.Add(ConvertirTempo(rdr, False))
        '    End While

        '    desconectar()

        '    Return Tempo
        'Catch ex As Exception

        'End Try




        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_SelectallTempo", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            While rdr.Read()
                Tempo.Add(ConvertirTempo(rdr, False))
            End While

            conn.Close()
        End Using

        Return Tempo


    End Function

    Public Shared Function ObtenerById(ByVal idTempo As Integer) As TempoEntity

        Dim Tempo As TempoEntity = Nothing

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_ObtenerTempobyID", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@id", idTempo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Tempo = ConvertirTempo(reader, True)
            End If

        End Using

        Return Tempo

    End Function
    Public Shared Function ObtenerbyActive() As List(Of TempoEntity)

        Dim Tempo As New List(Of TempoEntity)()

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_SelectaTempoactive", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            While rdr.Read()
                Tempo.Add(ConvertirTempo(rdr, False))
            End While

            conn.Close()
        End Using

        Return Tempo


    End Function

    Private Shared Function ConvertirTempo(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As TempoEntity

        Dim Tempo As New TempoEntity()
        Dim chance As Byte

        Tempo.Idtempo = Convert.ToInt32(reader("idTem")).ToString.Trim
        Tempo.Descripcion = Convert.ToString(reader("Temporada")).Trim
        chance = Convert.ToString(reader("isactive")).Trim


        If chance = "0" Then
            Tempo.isactive = "Inactivo"
        Else
            Tempo.isactive = "Activo"
        End If

        Return Tempo

    End Function

    Public Shared Function Save(Tempo As TempoEntity) As TempoEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '
            If Existe(Tempo.Idtempo) Then
                Actualizar(Tempo)
            ElseIf (Tempo.Idtempo) Then
                AgregarNuevo(Tempo)
            Else
                borrar(Tempo)

            End If


            scope.Complete()
        End Using

        Return Tempo

    End Function


    Public Shared Function Existe(idTempo As Integer) As Boolean
        Using conn As New SqlConnection(coruta)
            conn.Open()
            Dim cmd As SqlCommand


            cmd = New SqlCommand("SYS_ExisteTempo", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@id", idTempo)

            Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If resultado = 0 Then
                Return False
            Else
                Return True
            End If
        End Using

    End Function

    Private Shared Function AgregarNuevo(Tempo As TempoEntity) As TempoEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_InsertTempo", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@Tempo", Tempo.Descripcion)
            cmd.Parameters.AddWithValue("@isactive", Tempo.isactive)
            '
            ' se recupera el id generado por la tabla
            '
            Tempo.Idtempo = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return Tempo
    End Function

    Private Shared Function Actualizar(Tempo As TempoEntity) As TempoEntity
        Using conn As New SqlConnection(coruta)

            conn.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_UpdateTempo", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@Tempo", Tempo.Descripcion)
            cmd.Parameters.AddWithValue("@isactive", Tempo.isactive)
            cmd.Parameters.AddWithValue("@id", Tempo.Idtempo)

            cmd.ExecuteNonQuery()
        End Using

        Return Tempo
    End Function

    Private Shared Function borrar(Tempo As TempoEntity) As TempoEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_DeleteTempo", conn)
            cmd.CommandType = CommandType.StoredProcedure



            cmd.Parameters.AddWithValue("@id", Tempo.Idtempo)

            cmd.ExecuteNonQuery()
        End Using

        Return Tempo
    End Function


End Class


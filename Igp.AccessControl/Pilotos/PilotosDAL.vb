Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.SqlClient
Imports Igp.AccessControl.Entidades
Imports System.Data
Imports System.Transactions
Public NotInheritable Class PilotosDAL
    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"
    Public Shared Function ObtenerTodos() As List(Of PilotoEntity)

        Dim lista As New List(Of PilotoEntity)()

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_SelectallPilotos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()
                lista.Add(ConvertirPiloto(rdr, False))
            End While

            conn.Close()
        End Using
        Return lista

    End Function

    Public Shared Function ObtenerById(ByVal idEmpleado As Integer) As PilotoEntity

        Dim Piloto As PilotoEntity = Nothing

        Using conn As New SqlConnection(coruta)
            conn.Open()


            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_ObtenerPilotobyID", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id", idEmpleado)

            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()
                Piloto = (ConvertirPiloto(rdr, True))
            End While

            conn.Close()



        End Using

        Return Piloto

    End Function

    Private Shared Function ConvertirPiloto(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As PilotoEntity

        Dim Piloto As New PilotoEntity()

        Piloto.id = Convert.ToInt32(reader("id"))
        Piloto.nombre = Convert.ToString(reader("nPiloto"))
        Piloto.nacion = Convert.ToString(reader("idNacion"))

        'If reader("bPiloto") IsNot DBNull.Value Then
        '    Piloto.imagen = DirectCast(reader("bPiloto"), Byte())
        'End If

        'If cargarRelaciones Then
        '    Piloto.nacion = EstudiosDAL.ObtenerAsignadoEmpleado(Piloto.IdEmpleado)
        'End If

        Return Piloto

    End Function

    Public Shared Function Save(Piloto As PilotoEntity) As PilotoEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '
            If Existe(Piloto.id) Then
                Actualizar(Piloto)
            Else
                AgregarNuevo(Piloto)
            End If

            '
            ' graba los estudios relacionado con el empleado, 
            ' se eliminan las opciones existentes
            ' y se ingresan la nueva seleccion del usuario
            '
            'PilotosDAL.EliminarPorEmpleado(Piloto)

            'For Each estudio As EstudioEntity In empleado.Estudios
            '    EstudiosDAL.RelacionarConEmpleado(empleado, estudio)
            'Next


            scope.Complete()
        End Using

        Return Piloto

    End Function

    Public Shared Function Existe(id As Integer) As Boolean
        Using conn As New SqlConnection(coruta)
            conn.Open()


            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_ExistePiloto", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@id", id)

            Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If resultado = 0 Then
                Return False
            Else
                Return True
            End If
        End Using

    End Function

    Private Shared Function Actualizar(Piloto As PilotoEntity) As PilotoEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()


            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_UpdatePiloto", conn)
            cmd.CommandType = CommandType.StoredProcedure



            cmd.Parameters.AddWithValue("@id", Piloto.id)
            cmd.Parameters.AddWithValue("@nPiloto", Piloto.nombre)

            'cmd.Parameters.AddWithValue("@naPiloto", Piloto.nacion)

            'Dim imageParam As SqlParameter = cmd.Parameters.Add("@bPiloto", System.Data.SqlDbType.Image)
            'imageParam.Value = Piloto.imagen



            cmd.ExecuteNonQuery()
        End Using

        Return Piloto
    End Function

    Private Shared Function AgregarNuevo(Piloto As PilotoEntity) As PilotoEntity

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_InsertPiloto", conn)
            cmd.CommandType = CommandType.StoredProcedure

            'Dim query As String = "INSERT INTO Empleados (Nombre, Apellido, FechaNacimiento, EstadoCivil, Imagen) " &
            '                        "VALUES (@Nombre, @Apellido, @FechaNacimiento, @EstadoCivil, @Imagen); " &
            '                        "SELECT SCOPE_IDENTITY()"


            cmd.Parameters.AddWithValue("@nPiloto", Piloto.nombre)


            'Dim imageParam As SqlParameter = cmd.Parameters.Add("@bPiloto", System.Data.SqlDbType.Image)
            'imageParam.Value = Piloto.imagen

            '
            ' se recupera el id generado por la tabla
            '
            Piloto.id = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return Piloto
    End Function

End Class

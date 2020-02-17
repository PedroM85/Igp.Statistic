Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl.RutaSQL
Imports System.Data.SqlClient
Imports System.Transactions
Public NotInheritable Class NacionDAL

    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"
    Public Shared Function ObtenerTodos() As List(Of NacionEntity)

        Dim lista As New List(Of NacionEntity)()

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_SelectallNaciones", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            While rdr.Read()
                lista.Add(ConvertirNacion(rdr, False))
            End While

            conn.Close()
        End Using

        Return lista


    End Function
    Public Shared Function ObtenerById(ByVal idEmpleado As Integer) As NacionEntity

        Dim nacion As NacionEntity = Nothing

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_ObtenerNacionbyID", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@id", idEmpleado)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                nacion = ConvertirNacion(reader, True)
            End If

        End Using

        Return nacion

    End Function
    Private Shared Function ConvertirNacion(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As NacionEntity

        Dim Nacion As New NacionEntity()

        Nacion.IdNacion = Convert.ToInt32(reader("id")).ToString.Trim
        Nacion.Descripcion = Convert.ToString(reader("idNacion")).Trim


        Return Nacion

    End Function

    Public Shared Function Save(nacion As NacionEntity) As NacionEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '
            If Existe(nacion.IdNacion) Then
                Actualizar(nacion)
            Else
                AgregarNuevo(nacion)
            End If


            scope.Complete()
        End Using

        Return nacion

    End Function


    Public Shared Function Existe(idEmpleado As Integer) As Boolean
        Using conn As New SqlConnection(coruta)
            conn.Open()


            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_ExisteNacion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@id", idEmpleado)

            Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If resultado = 0 Then
                Return False
            Else
                Return True
            End If
        End Using

    End Function

    Private Shared Function AgregarNuevo(nacion As NacionEntity) As NacionEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_InsertNacion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@idNacion", nacion.Descripcion)

            'Dim imageParam As SqlParameter = cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.Image)
            'imageParam.Value = empleado.Imagen

            '
            ' se recupera el id generado por la tabla
            '
            nacion.IdNacion = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return nacion
    End Function

    Private Shared Function Actualizar(nacion As NacionEntity) As NacionEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_UpdateNacion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@nPiloto", nacion.Descripcion)


            cmd.Parameters.AddWithValue("@id", nacion.IdNacion)

            cmd.ExecuteNonQuery()
        End Using

        Return nacion
    End Function

    Public Shared Function delete(nacion As NacionEntity) As NacionEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '
            If Existe(nacion.IdNacion) Then
                borrar(nacion)
            Else
                MsgBox("No hay datos que eliminar")

            End If

            '
            ' graba los estudios relacionado con el empleado, 
            ' se eliminan las opciones existentes
            ' y se ingresan la nueva seleccion del usuario
            '
            'EstudiosDAL.EliminarPorEmpleado(empleado)

            'For Each estudio As EstudioEntity In empleado.Estudios
            'EstudiosDAL.RelacionarConEmpleado(empleado, estudio)
            'Next


            scope.Complete()
        End Using

        Return nacion
    End Function

    Private Shared Function borrar(nacion As NacionEntity) As NacionEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_DeleteNacion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            'cmd.Parameters.AddWithValue("@nPiloto", empleado.Nombre)
            'cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido)
            'cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento)
            'cmd.Parameters.AddWithValue("@idNacion", empleado.EstadoCivil)

            'Dim imageParam As SqlParameter = cmd.Parameters.Add("@Imagen", System.Data.SqlDbType.Image)
            'imageParam.Value = empleado.Imagen

            cmd.Parameters.AddWithValue("@id", nacion.IdNacion)

            cmd.ExecuteNonQuery()
        End Using

        Return nacion
    End Function

End Class

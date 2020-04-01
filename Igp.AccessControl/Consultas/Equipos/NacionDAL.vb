Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessController
Imports System.Data.SqlClient
Imports System.Transactions
Public NotInheritable Class NacionDAL


    Public Shared Function ObtenerTodos() As List(Of NacionEntity)


        Dim lista As New List(Of NacionEntity)()

        'Using conn As New SqlConnection(ConectarDB())
        ConectarDB()
        'Conn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_SelectallNaciones", conn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim rdr As SqlDataReader = cmd.ExecuteReader()


        While rdr.Read()
            lista.Add(ConvertirNacion(rdr, False))
        End While

        DesconectarDB()
        ' End Using

        Return lista


    End Function
    Public Shared Function ObtenerById(ByVal idEmpleado As Integer) As NacionEntity

        Dim nacion As NacionEntity = Nothing

        'Using conn As New SqlConnection(coruta)
        ConectarDB()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ObtenerNacionbyID", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", idEmpleado)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            nacion = ConvertirNacion(reader, True)
        End If

        'End Using
        DesconectarDB()
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

        ConectarDB()



        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ExisteNacion", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", idEmpleado)

        Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If resultado = 0 Then
            Return False
        Else
            Return True
            End If

        DesconectarDB()

    End Function

    Private Shared Function AgregarNuevo(nacion As NacionEntity) As NacionEntity
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ExisteNacionBy", Conn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@id", nacion.Descripcion)

        Dim valor As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If valor = 0 Then

            cmd = New SqlCommand("SYS_InsertNacion", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@idNacion", nacion.Descripcion)

            nacion.IdNacion = Convert.ToInt32(cmd.ExecuteScalar())
        Else

            MsgBox("El equipo que desea agregar ya se encuentra registrado: " & nacion.Descripcion)

        End If


        DesconectarDB()

        Return nacion
    End Function

    Private Shared Function Actualizar(nacion As NacionEntity) As NacionEntity
        ConectarDB()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_UpdateNacion", conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@idNacion", nacion.Descripcion)


        cmd.Parameters.AddWithValue("@id", nacion.IdNacion)
        cmd.ExecuteNonQuery()

        DesconectarDB()

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


            scope.Complete()
        End Using

        Return nacion
    End Function

    Private Shared Function borrar(nacion As NacionEntity) As NacionEntity
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_DeleteNacion", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", nacion.IdNacion)

        cmd.ExecuteNonQuery()

        DesconectarDB()

        Return nacion

    End Function

End Class

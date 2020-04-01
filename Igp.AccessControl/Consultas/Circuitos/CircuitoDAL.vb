Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessController
Imports System.Data.SqlClient
Imports System.Transactions

Public NotInheritable Class CircuitoDAL


    Public Shared Function ObtenerTodos() As List(Of CircuitoEntity)

        Dim lista As New List(Of CircuitoEntity)()

        ConectarDB()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_SelectallCircuito", Conn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim rdr As SqlDataReader = cmd.ExecuteReader()


        While rdr.Read()
            lista.Add(ConvertirCircuito(rdr, False))
        End While

        DesconectarDB()


        Return lista


    End Function
    Public Shared Function ObtenerById(ByVal idCircuito As Integer) As CircuitoEntity

        Dim Circuito As CircuitoEntity = Nothing

        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ObtenerCircuitobyID", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", idCircuito)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Circuito = ConvertirCircuito(reader, True)
        End If

        DesconectarDB()

        Return Circuito

    End Function
    Private Shared Function ConvertirCircuito(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As CircuitoEntity

        Dim Circuito As New CircuitoEntity()

        Circuito.Id = Convert.ToInt32(reader("ID")).ToString.Trim
        Circuito.Circuito = Convert.ToString(reader("nCircuito")).Trim


        Return Circuito

    End Function

    Public Shared Function Save(Circuito As CircuitoEntity) As CircuitoEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos Circuito
            '
            If Existe(Circuito.Id) Then
                Actualizar(Circuito)
            Else
                AgregarNuevo(Circuito)
            End If


            scope.Complete()
        End Using

        Return Circuito

    End Function


    Public Shared Function Existe(idCircuito As Integer) As Boolean
        ConectarDB()



        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ExisteCircuito", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", idCircuito)

        Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If resultado = 0 Then
            Return False
        Else
            Return True
        End If

        DesconectarDB()


    End Function

    Private Shared Function AgregarNuevo(Circuito As CircuitoEntity) As CircuitoEntity
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_InsertCircuito", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@nCircuito", Circuito.Circuito)



        '
        ' se recupera el id generado por la tabla
        '
        Circuito.Id = Convert.ToInt32(cmd.ExecuteScalar())

        DesconectarDB()

        Return Circuito
    End Function

    Private Shared Function Actualizar(Circuito As CircuitoEntity) As CircuitoEntity
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_UpdateCircuito", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@nCircuito", Circuito.Circuito)


        cmd.Parameters.AddWithValue("@id", Circuito.Id)

        cmd.ExecuteNonQuery()


        DesconectarDB()

        Return Circuito
    End Function

    Public Shared Function delete(Circuito As CircuitoEntity) As CircuitoEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '
            If Existe(Circuito.Id) Then
                borrar(Circuito)
            Else
                MsgBox("No hay datos que eliminar")

            End If


            scope.Complete()
        End Using

        Return Circuito
    End Function

    Private Shared Function borrar(Circuito As CircuitoEntity) As CircuitoEntity
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_DeleteCircuito", Conn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@id", Circuito.Id)

        cmd.ExecuteNonQuery()


        DesconectarDB()

        Return Circuito
    End Function

End Class

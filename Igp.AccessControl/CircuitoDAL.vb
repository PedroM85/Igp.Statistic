Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl.RutaSQL
Imports System.Data.SqlClient
Imports System.Transactions

Public NotInheritable Class CircuitoDAL
    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"

    Public Shared Function ObtenerTodos() As List(Of CircuitoEntity)

        Dim lista As New List(Of CircuitoEntity)()

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_SelectallCircuito", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            While rdr.Read()
                lista.Add(ConvertirCircuito(rdr, False))
            End While

            conn.Close()
        End Using

        Return lista


    End Function

    Private Shared Function ConvertirCircuito(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As CircuitoEntity

        Dim Circuito As New CircuitoEntity()

        Circuito.Id = Convert.ToInt32(reader("ID")).ToString.Trim
        Circuito.Circuito = Convert.ToString(reader("nCircuito")).Trim


        Return Circuito

    End Function
End Class

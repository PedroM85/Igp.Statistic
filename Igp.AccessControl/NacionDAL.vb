Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl.RutaSQL
Imports System.Data.SqlClient
Public NotInheritable Class NacionDAL

    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"
    Public Shared Function ObtenerTodos() As List(Of NacionEntity)

        Dim lista As New List(Of NacionEntity)()

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_ObtenerNaciones", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            While rdr.Read()
                lista.Add(ConvertirNacion(rdr, False))
            End While

            conn.Close()





        End Using

        Return lista


    End Function

    Private Shared Function ConvertirNacion(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As NacionEntity

        Dim Nacion As New NacionEntity()

        Nacion.IdNacion = Convert.ToInt32(reader("id"))
        Nacion.Descripcion = Convert.ToString(reader("Nacion"))


        Return Nacion

    End Function
End Class

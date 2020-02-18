Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl.RutaSQL
Imports System.Data.SqlClient
Imports System.Transactions
Public NotInheritable Class ConfigDAL
    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"
    Public Shared Function ObtenerTodos() As List(Of ConfigEntity)

        Dim lista As New List(Of ConfigEntity)()

        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("SYS_SelectallConfig", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            While rdr.Read()
                lista.Add(ConvertirConfig(rdr, False))
            End While

            conn.Close()
        End Using

        Return lista


    End Function


    Private Shared Function ConvertirConfig(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As ConfigEntity

        Dim Config As New ConfigEntity()

        Config.Id = Convert.ToString(reader("PAR_id")).Trim
        Config.Descripcion = Convert.ToString(reader("PAR_Descripcion")).Trim

        Config.type = Convert.ToString(reader("PAR_Type")).Trim

        Select Case Config.type
            Case "N"
                Config.Valor = Convert.ToString(reader("PAR_Numeric")).Trim
            Case "S"
                Config.Valor = Convert.ToString(reader("PAR_String")).Trim
        End Select





        Return Config

    End Function
End Class

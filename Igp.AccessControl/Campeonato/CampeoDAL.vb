Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades

Imports System.Data.SqlClient
Imports System.Transactions
Public NotInheritable Class CampeoDAL
    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"

    'Public Shared Function ObtenerByTempoCircui(ByVal idTemporada As String, ByVal idCircuito As String) As CampeoEntity
    Public Shared Function ObtenerByTempoCircui() As List(Of CampeoEntity)

        CampeoEntit
        'Dim Campeo As CampeoEntity = Nothing
        Dim Campeo As New List(Of CampeoEntity)()



        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("REP_CampeobyTempoCircui", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@idTemporada", "Temporada 29")
            cmd.Parameters.AddWithValue("@idTemporada", "Temporada 29")
            cmd.Parameters.AddWithValue("@idCircuito", "Austria")

            Dim reader As SqlDataReader = cmd.ExecuteReader()



            While reader.Read()
                'Campeo = (ConvertirCampeo(reader, True))
                Campeo.Add(ConvertirCampeo(reader, True))
            End While


            conn.Close()
        End Using

        Return Campeo


    End Function

    Private Shared Function ConvertirCampeo(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As CampeoEntity

        Dim Campeo As New CampeoEntity()


        Campeo.id = Convert.ToInt32(reader("id")).ToString.Trim
        Campeo.Temporada = Convert.ToString(reader("Temporada")).Trim
        Campeo.Circuito = Convert.ToString(reader("nCircuito")).Trim
        Campeo.Piloto = Convert.ToString(reader("nPiloto")).Trim
        Campeo.Posllegada = Convert.ToInt32(reader("Posllegada")).ToString.Trim
        Campeo.Puntos = Convert.ToInt32(reader("ptsCantidad")).ToString.Trim


        Return Campeo

    End Function
End Class

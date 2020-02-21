Imports System.Data.SqlClient
Imports System.Configuration
Public Class Conexion

    Public RutaSQL As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa")

    Public Sub conectar()
        Try
            RutaSQL.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            If RutaSQL.State = ConnectionState.Open Then
                RutaSQL.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

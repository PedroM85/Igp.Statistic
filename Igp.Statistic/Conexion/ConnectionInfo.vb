Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Public Class ConnectionString

    Public cn As SqlConnection

    'Public ReadOnly cs As String = "Data Source=DEV4\EXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"

    Sub New()
        Try
            cn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa")
            cn.Open()
            Dim Conexion As String = "Estamos Conectado"



        Catch ex As Exception
            MsgBox("No estamos Conectados: " + ex.ToString)
        End Try
    End Sub


End Class
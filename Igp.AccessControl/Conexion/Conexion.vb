Imports System.Data.SqlClient
Imports System.Configuration

Public Module Conexion

    Public oConn As New ConnectionInfo
    Public Conn As New SqlConnection


    Public Function ConectarDB() As Boolean
        Dim retval As Boolean
        Conn.Close()

        Try
            oConn.GetConnectionInfo()
            Conn.ConnectionString = "Server = '" & oConn.Server & "';  " _
                                         & "Database = '" & oConn.Database & "'; " _
                                         & "user id = '" & oConn.UserId & "'; " _
                                         & "password = '" & oConn.Password & "'"

            Conn.Open()

            Return True
        Catch exsql As SqlException

            Select Case exsql.Number
                Case 40
                    Throw New Exception("Database connection failed 40")
                Case 2
                    Throw New Exception("Database connection failed 20")
                Case Else
                    MsgBox("The system failed to establish a connection ," + vbLf + "Database Settings ", MsgBoxStyle.Information, "IgpManager")
                    ' Return False
            End Select

            Return False

        End Try

        Return retval
    End Function
    Public Sub DesconectarDB()
        Try
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                Conn.Dispose()
            End If
        Catch ex As Exception
            MsgBox("The system failed to closing a connection", MsgBoxStyle.Information, "Database Settings " + ex.Message)
        End Try
    End Sub
End Module

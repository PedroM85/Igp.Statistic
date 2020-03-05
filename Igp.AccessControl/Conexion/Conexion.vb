Imports System.Data.SqlClient
Imports System.Configuration

Public Module Conexion

    Public oConn As New ConnectionInfo
    Public Conn As New SqlConnection


    Public Sub ConectarDB()

        Conn.Close()

        Try
            oConn.GetConnectionInfo()
            Conn.ConnectionString = "Server = '" & oConn.Server & "';  " _
                                         & "Database = '" & oConn.Database & "'; " _
                                         & "user id = '" & oConn.UserId & "'; " _
                                         & "password = '" & oConn.Password & "'"

            Conn.Open()


        Catch ex As Exception
            Select Case ex.Message
                Case "Login failed for user 'sa'."
                    Throw New Exception("Database connection failed")

                Case Else
                    MsgBox("The system failed to establish a connection," + vbLf + "Database Settings " + ex.Message, MsgBoxStyle.Information, "IgpManager")

            End Select

        End Try


    End Sub
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

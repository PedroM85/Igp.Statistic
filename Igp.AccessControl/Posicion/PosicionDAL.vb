Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessControl.Entidades
Imports System.Data.SqlClient
Imports System.Transactions

Public Class PosicionDAL
    Const coruta As String = "Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa"



    Public Shared Function Save(Posicion As PosicionEntity) As PosicionEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '



            If Existe(Posicion.Circuito, Posicion.Piloto, Posicion.Temporada, Posicion.llegada, Posicion.exite) Then
                'Actualizar(Posicion)

                'MsgBox("El registro que desea agregar ya esta en la base de datos: " & Posicion.exite.Trim)

            Else
                AgregarNuevo(Posicion)
            End If


            scope.Complete()
        End Using

        Return Posicion

    End Function

    Public Shared Function Existe(idCircuito As Integer, idpiloto As Integer, idTemporada As Integer, Posllegada As Integer, exite As String) As Boolean
        Using conn As New SqlConnection(coruta)
            conn.Open()


            Dim cmd As SqlCommand
            'cmd = New SqlCommand("SYS_ExisteinPosicion", conn)
            cmd = New SqlCommand("SYS_ExistePosicion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@idCircuito", idCircuito)
            cmd.Parameters.AddWithValue("@idPiloto", idpiloto)
            cmd.Parameters.AddWithValue("@idTemporada", idTemporada)
            cmd.Parameters.AddWithValue("@Posllegada", Posllegada)


            Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If resultado = 0 Then


                cmd = New SqlCommand("SYS_ExistePosicion1", conn)
                cmd.CommandType = CommandType.StoredProcedure


                cmd.Parameters.AddWithValue("@idCircuito", idCircuito)
                'cmd.Parameters.AddWithValue("@idPiloto", idpiloto)
                cmd.Parameters.AddWithValue("@idTemporada", idTemporada)
                cmd.Parameters.AddWithValue("@Posllegada", Posllegada)

                Dim Resultado1 As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If Resultado1 = 0 Then

                    cmd = New SqlCommand("SYS_ExistePosicion2", conn)
                    cmd.CommandType = CommandType.StoredProcedure


                    cmd.Parameters.AddWithValue("@idCircuito", idCircuito)
                    cmd.Parameters.AddWithValue("@idPiloto", idpiloto)
                    cmd.Parameters.AddWithValue("@idTemporada", idTemporada)
                    'cmd.Parameters.AddWithValue("@Posllegada", Posllegada)

                    Dim Resultado2 As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If Resultado2 = 0 Then
                        Return False
                    Else
                        MsgBox("El registro que desea agregar ya esta en la base de datos: " & exite.Trim)
                        Return True
                    End If


                Else
                        MsgBox("La posición de llegada: " & Posllegada & ", ya esta en uso en la base de datos")
                    Return True
                End If

                'Return False

            Else

                MsgBox("El registro que desea agregar ya esta en la base de datos: " & exite.Trim)
                Return True

            End If




        End Using

    End Function
    Private Shared Function AgregarNuevo(Posicion As PosicionEntity) As PosicionEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("ADD_InsertPosicion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@idTemporada", Posicion.Temporada)
            cmd.Parameters.AddWithValue("@idCircuito", Posicion.Circuito)
            cmd.Parameters.AddWithValue("@idPiloto", Posicion.Piloto)
            cmd.Parameters.AddWithValue("@idllegada", Posicion.llegada)
            cmd.Parameters.AddWithValue("@Pllegada", Posicion.Ptsllegada)



            Posicion.id = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return Posicion
    End Function

    Private Shared Function Actualizar(Posicion As PosicionEntity) As PosicionEntity
        Using conn As New SqlConnection(coruta)
            conn.Open()

            Dim cmd As SqlCommand
            cmd = New SqlCommand("ADD_UpdatePosicion", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@idTemporada", Posicion.Temporada)
            cmd.Parameters.AddWithValue("@idCirciuito", Posicion.Circuito)
            cmd.Parameters.AddWithValue("@idPiloto", Posicion.Piloto)
            cmd.Parameters.AddWithValue("@idllegada", Posicion.llegada)

            cmd.Parameters.AddWithValue("@id", Posicion.Id)
            cmd.ExecuteNonQuery()
        End Using

        Return Posicion
    End Function
End Class

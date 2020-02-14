Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Module modConeccion
    Private cn As SqlConnection
    Private da As SqlDataAdapter
    Private dt As DataTable
    Private cm As SqlCommand
    Private dr As SqlDataReader

    Public Enum TipoProcesamiento
        NonQuery = 1
        Scalar = 2
        DataTable = 3
    End Enum


    Public Sub GeneraCadena(ByVal cServidor As String, ByVal cBase As String, ByVal cUsuario As String, ByVal cPassword As String)
        cn = New SqlConnection("Server=" & cServidor & ";Database=" & cBase & ";Uid=" & cUsuario & ";Pwd=" & cPassword & ";")

    End Sub

    Public Sub Conectar()
        GeneraCadena("PEDROM-PC\SQLEXPRESS", "IgpManager", "sa", "pedro1985")
        cn.Open()
    End Sub

    Public Sub Desconectar()
        cn.Close()
        'cn.Dispose()
    End Sub

    Public Function EjecutarConsulta(ByVal cConsulta As String, ByVal cTipoProceso As TipoProcesamiento, Optional ByVal bAlerta As Boolean = True) As Object
        Try
            Conectar()
            If cTipoProceso = TipoProcesamiento.NonQuery Then
                cm = New SqlCommand(cConsulta, cn)
                cm.ExecuteNonQuery()
                Return True
            ElseIf cTipoProceso = TipoProcesamiento.Scalar Then
                cm = New SqlCommand(cConsulta, cn)
                Return cm.ExecuteScalar()
            ElseIf cTipoProceso = TipoProcesamiento.DataTable Then
                da = New SqlDataAdapter(cConsulta, cn)
                dt = New DataTable()
                da.Fill(dt)
                Return dt
            Else
                Throw New Exception("Tipo de procesamiento no válido")
            End If
        Catch ex As Exception
            If bAlerta = True Then
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function EjecutarProcedure(ByVal cNombreProcedure As String, ByVal pParametros() As SqlParameter, ByVal cTipoProceso As TipoProcesamiento, Optional ByVal bAlerta As Boolean = True) As Object
        Try
            Conectar()
            Dim cm As New SqlCommand
            cm = New SqlCommand(cNombreProcedure, cn)
            cm.CommandType = CommandType.StoredProcedure
            cm.Parameters.AddRange(pParametros)

            If cTipoProceso = TipoProcesamiento.NonQuery Then
                cm.ExecuteNonQuery()
                Return True
            ElseIf cTipoProceso = TipoProcesamiento.Scalar Then
                Return cm.ExecuteScalar
            ElseIf cTipoProceso = TipoProcesamiento.DataTable Then
                da = New SqlDataAdapter(cm)
                dt = New DataTable()
                da.Fill(dt)
                Return dt
            Else
                Throw New Exception("Tipo de procesamiento no válido")
            End If
        Catch ex As Exception
            If bAlerta = True Then
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function
End Module
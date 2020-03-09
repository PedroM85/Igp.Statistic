Imports System.Data.SqlClient
Public Class Parameters
    Inherits Hashtable

    Private oConn As IDbConnection


    Public Sub New()
        MyBase.New
        refresh()
    End Sub


    Public Sub refresh()
        ConectarDB()

        Dim oCmd As IDbCommand = conn.CreateCommand
        'Dim cmd As SqlCommand
        Dim sId As String
        Dim oValue As Object = Nothing

        oCmd = New SqlCommand("CON_GetParameters", conn)
        oCmd.CommandType = CommandType.StoredProcedure

        Dim oRd As IDataReader

        oRd = oCmd.ExecuteReader()
        Try
            Do While oRd.Read
                sId = oRd.GetString(oRd.GetOrdinal("PAR_Idv")).Trim
                Select Case oRd.GetString(oRd.GetOrdinal("PAR_Type"))
                    Case "N"
                        If oRd.IsDBNull(oRd.GetOrdinal("PAR_Numeric")) Then
                            oValue = Nothing
                        Else
                            oValue = oRd.GetDecimal(oRd.GetOrdinal("PAR_Numeric"))
                        End If
                    Case "S"
                        If oRd.IsDBNull(oRd.GetOrdinal("PAR_String")) Then
                            oValue = Nothing
                        Else
                            oValue = oRd.GetString(oRd.GetOrdinal("PAR_String"))
                        End If
                End Select
                Item(sId) = oValue
            Loop
        Catch ex As Exception
            MsgBox("Error Cargando la configuracion :" + ex.Message)
        End Try

        DesconectarDB()

    End Sub

    Public Function GetValue(ByVal sParameterId As String) As Object
        If ContainsKey(sParameterId) Then
            'If oParams.ContainsKey(sParameterId) Then
            'Return oParams.Item(sParameterId)
            Return Item(sParameterId)
        Else
            Dim oValue As Object = RetrieveValue(sParameterId)
            If oValue Is Nothing Then
                Throw New ArgumentException(String.Format("Couldn't find '{0}' in system parameter collection", sParameterId))
            Else
                Return oValue
            End If
        End If
    End Function

    Private Function RetrieveValue(ByVal sParameterId As String) As Object
        Dim oValue As Object = Nothing

        If oConn.State = ConnectionState.Open Then
            Dim oCmd As IDbCommand = oConn.CreateCommand
            Dim oRd As IDataReader
            'Dim oPrm As IDataParameter

            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = "PAR_GetParameter"

            'oPrm = DAHelper.CreateParameter(oCmd, "ParameterId", DbType.StringFixedLength, 10)
            'oPrm.Value = sParameterId
            'oCmd.Parameters.Add(oPrm)

            oRd = oCmd.ExecuteReader()

            Do While oRd.Read
                Select Case oRd.GetString(oRd.GetOrdinal("PAR_Type"))
                    Case "N"
                        oValue = oRd.GetDecimal(oRd.GetOrdinal("PAR_NumericValue"))
                    Case "S"
                        '15-1-08 - Si el string esta null devuelvo un Empty para evitar errores por Nothing
                        If oRd.IsDBNull(oRd.GetOrdinal("PAR_StringValue")) Then
                            oValue = String.Empty
                        Else
                            oValue = oRd.GetString(oRd.GetOrdinal("PAR_StringValue"))
                        End If
                    Case "D"
                        oValue = oRd.GetDateTime(oRd.GetOrdinal("PAR_DateTimeValue"))
                End Select
            Loop

            oRd.Close()
        End If

        Return oValue
    End Function
End Class

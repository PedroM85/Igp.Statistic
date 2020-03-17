
Namespace CommonManagers
    Public Class SerialNumberManagerConcessions

        Private mConn As IDbConnection
        Private mPrefix As String

        Public Sub New(ByVal connection As IDbConnection, ByVal prefix As String)
            mConn = connection
            mPrefix = prefix
        End Sub

        Public Function GetSerialNumber() As String

            Dim number As String = GetSerialNumber_Sequential.ToString
            Return mPrefix & "000000000".Substring(0, 9 - number.Length) & number

        End Function

        Public Function GetSerialNumberNC() As String

            Dim number As String = GetSerialNumberNC_Sequential.ToString
            Return mPrefix & "000000000".Substring(0, 9 - number.Length) & number

        End Function

        Private Function GetSerialNumber_Sequential() As Integer

            Dim command As IDbCommand = mConn.CreateCommand

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "SRN_GetSerialNumber_Sequential"

            Dim par As IDataParameter = command.CreateParameter
            par.ParameterName = "SerialNumber"
            par.DbType = DbType.Int32
            par.Direction = ParameterDirection.Output

            command.Parameters.Add(par)
            command.ExecuteNonQuery()

            Return Convert.ToInt32(par.Value)

        End Function

        Private Function GetSerialNumberNC_Sequential() As Integer

            Dim command As IDbCommand = mConn.CreateCommand

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "SRN_GetSerialNumberNC_Sequential"

            Dim par As IDataParameter = command.CreateParameter
            par.ParameterName = "SerialNumberNC"
            par.DbType = DbType.Int32
            par.Direction = ParameterDirection.Output

            command.Parameters.Add(par)
            command.ExecuteNonQuery()

            Return Convert.ToInt32(par.Value)

        End Function

    End Class

End Namespace


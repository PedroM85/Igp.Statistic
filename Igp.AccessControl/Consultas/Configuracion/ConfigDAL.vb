Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Igp.AccessController
Imports Igp.AccessControl.Entidades
Imports System.Data.SqlClient
Imports System.Transactions
Public NotInheritable Class ConfigDAL

    Dim TypeV As String = Nothing
    Public Shared Function ObtenerTodos() As List(Of ConfigEntity)

        Dim lista As New List(Of ConfigEntity)()

        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_SelectallConfig", Conn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim rdr As SqlDataReader = cmd.ExecuteReader()


        While rdr.Read()
                lista.Add(ConvertirConfig(rdr, False))
        End While

        DesconectarDB()

        Return lista


    End Function

    Public Shared Function ObtenerById(ByVal idConfig As Integer) As ConfigEntity

        Dim Config As ConfigEntity = Nothing

        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ObtenerConfigbyID", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", idConfig)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Config = ConvertirConfig(reader, True)
        End If

        DesconectarDB()

        Return Config

    End Function

    Private Shared Function ConvertirConfig(ByVal reader As IDataReader, ByVal cargarRelaciones As Boolean) As ConfigEntity

        Dim Config As New ConfigEntity()

        Config.id = Convert.ToInt32(reader("PAR_id")).ToString.Trim
        Config.Idv = Convert.ToString(reader("PAR_idv")).ToString.Trim
        Config.Descripcion = Convert.ToString(reader("PAR_Descripcion")).Trim

        Config.type = Convert.ToString(reader("PAR_Type")).Trim


        Select Case Config.type
            Case "N"
                Config.Valor = Convert.ToString(reader("PAR_NumericValue")).Trim
            Case "S"
                Config.Valor = Convert.ToString(reader("PAR_StringValue")).Trim
        End Select



        Return Config

    End Function

    Public Shared Function Save(config As ConfigEntity) As ConfigEntity
        Using scope As New TransactionScope()
            '
            ' Graba datos empleado
            '
            If Existe(config.Id) Then
                Actualizar(config)
            End If


            scope.Complete()
        End Using

        Return config

    End Function


    Public Shared Function Existe(idConfig As Integer) As Boolean
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_ExisteConfig", Conn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.AddWithValue("@id", idConfig)

        Dim resultado As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If resultado = 0 Then
            Return False
        Else
            Return True
        End If

        DesconectarDB()

    End Function


    Private Shared Function Actualizar(config As ConfigEntity) As ConfigEntity
        ConectarDB()


        Dim cmd As SqlCommand
        cmd = New SqlCommand("SYS_UpdateConfig", Conn)
        cmd.CommandType = CommandType.StoredProcedure




        Select Case config.type
            Case "N"
                cmd.Parameters.AddWithValue("@PAR_Numeric", config.Valor)
                cmd.Parameters.AddWithValue("@PAR_String", DBNull.Value)
            Case "S"
                cmd.Parameters.AddWithValue("@PAR_Numeric", DBNull.Value)
                cmd.Parameters.AddWithValue("PAR_String", config.Valor)
        End Select
        cmd.Parameters.AddWithValue("@PAR_type", config.type)

        cmd.Parameters.AddWithValue("@id", config.id)

        cmd.ExecuteNonQuery()

        DesconectarDB()

        Return config
    End Function

End Class

Public Class ResourceLoader

#Region " Instance Variables "

    'Dim _ResourceManager As Resources.ResourceManager

    'Dim _ResourceAssemblyName As String
    'Dim _ResourceFileName As String

    ''Flag para indicar que se usará siempre el string default 
    ''(que es el segundo parametro de los get)
    Dim mInitialized As Boolean = False
    Dim mOleDBConnString As String
    Dim mUserId As String

#End Region

#Region " Methods "

    Public Sub InitializeEngine(ByVal OleDBConnString As String, ByVal UserId As String)

        mOleDBConnString = OleDBConnString
        mUserId = UserId

        If mOleDBConnString Is Nothing OrElse mUserId Is Nothing Then
            Throw New Exception("ResourceLoader is not initialized correctly")
        Else
            mInitialized = True
        End If
    End Sub

    'Public Sub New(ByVal ResourceAssemblyName As String, Optional ByVal TXTResourceFileName As String = "")
    '    SwitchLanguage(ResourceAssemblyName, TXTResourceFileName)
    'End Sub

    'Public Sub SwitchLanguage(ByVal ResourceAssemblyName As String, Optional ByVal TXTResourceFileName As String = "")
    '    _ResourceAssemblyName = ResourceAssemblyName
    '    If TXTResourceFileName.Trim.Length > 0 Then
    '        _ResourceFileName = TXTResourceFileName
    '    Else
    '        _ResourceFileName = ResourceAssemblyName + ".txt"
    '    End If

    '    'subo el flag por las dudas que algo falle
    '    _UsingTXTDefaultLanguage = True

    '    If Not _ResourceAssemblyName Is Nothing AndAlso Not _ResourceFileName Is Nothing Then
    '        If _ResourceAssemblyName.Trim.Length > 0 AndAlso _ResourceFileName.Trim.Length > 0 Then

    '            Try
    '                ' Gets a reference to a different assembly (satellite).
    '                Dim resAssembly As System.Reflection.Assembly
    '                resAssembly = System.Reflection.Assembly.Load(ResourceAssemblyName)

    '                ' Creates the txt ResourceManager.
    '                _ResourceManager = New _
    '                   System.Resources.ResourceManager(_ResourceFileName, resAssembly)

    '                'todo bien, bajo el flag
    '                _UsingTXTDefaultLanguage = False

    '            Catch ex As Exception

    '            End Try
    '        End If
    '    End If

    'End Sub
#End Region

#Region " Private Methods "

    Private Function GetDBString(ByVal pAssembly As String, ByVal pNamespace As String, ByVal pClass As String, ByVal Key As String, ByVal DefValue As String) As String
        If pNamespace Is Nothing Then
            pNamespace = ""
        End If

        Dim cnx As New OleDb.OleDbConnection(mOleDBConnString)
        Dim cmd As OleDb.OleDbCommand = cnx.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "TRL_GetValue"
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Assembly", OleDb.OleDbType.Char, 60)).Value = pAssembly
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Namespace", OleDb.OleDbType.Char, 60)).Value = pNamespace
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Class", OleDb.OleDbType.Char, 60)).Value = pClass
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Key", OleDb.OleDbType.Char, 60)).Value = Key
        'TODO: Para traer traduccion por usuario
        cmd.Parameters.Add(New OleDb.OleDbParameter("@UserId", OleDb.OleDbType.Char, 10)).Value = ""
        Dim par As New OleDb.OleDbParameter("@Value", OleDb.OleDbType.VarChar, 512)
        par.Direction = ParameterDirection.InputOutput
        par.Value = DefValue
        cmd.Parameters.Add(par)

        Try
            cnx.Open()

            'Pablo 19/10: Falta ver el store TRL_GetValue de la base de access.
            'Capturo el error que se produce en modo offline.
            Try
                cmd.ExecuteNonQuery()
                Return Convert.ToString(cmd.Parameters("@Value").Value)
            Catch
                Return DefValue
            End Try

        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
            cnx.Dispose()
        End Try


    End Function

#End Region

#Region " Properties "

    ReadOnly Property GetString(ByVal Key As String, ByVal DefaultValue As String) As String
        Get
            If mInitialized Then
                Try

                    Dim st As New Diagnostics.StackTrace(False)
                    Dim sf As Diagnostics.StackFrame = st.GetFrame(1)

                    Dim method As Reflection.MethodBase = sf.GetMethod

                    Return GetDBString(method.ReflectedType.Assembly.GetName.Name, method.ReflectedType.Namespace, method.ReflectedType.Name, Key, DefaultValue)

                Catch ex As Exception
                    Throw ex
                End Try
            Else
                Return DefaultValue
            End If

        End Get
    End Property

    'Property UseDefaultString() As Boolean
    '    Get
    '        Return _UsingTXTDefaultLanguage
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        _UsingTXTDefaultLanguage = Value
    '    End Set
    'End Property

    'ReadOnly Property CurrentAssemblyName() As String
    '    Get
    '        Return _ResourceAssemblyName
    '    End Get
    'End Property

    'ReadOnly Property CurrentTxtName() As String
    '    Get
    '        Return _ResourceFileName
    '        Dim _BMPResourceFileName As String
    '    End Get
    'End Property

    'ReadOnly Property TXTResourceManager() As Resources.ResourceManager
    '    Get
    '        Return _ResourceManager

    '    End Get
    'End Property
#End Region

End Class

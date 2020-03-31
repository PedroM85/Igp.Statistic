'[AMI150205] Genera y administra el archivo Log (Eventos)
' NO SE RECOMIENDA UN ARCHIVO LOG QUE SUPERE EN TAMAÑO _
' EL 33% DEL ESTABLECIDO PARA EL HISTÓRICO.

Imports System.IO

Public Class LogFile

#Region " Instance variables "
    Const Separator As String = "---------------------------------"

    Public Enum DateTimeInfo
        DontPrintDateTime = 0
        PrintCurrentDate = 1
        PrintCurrentTime = 2
        PrintCurrentDateTime = 3
    End Enum

    Dim mLogIsActive As Boolean = False
    Dim mActiveKBLimit As Int32 ' Log activo
    'Dim mPassiveKBLimit As Int32 ' Log histórico
    Dim mBackupMode As Byte
    Dim mPath As String

    Dim mActiveLogFileName As String
    'Dim mPassiveLogFileName As String

    Dim mLogFile As FileStream
    Dim mLogStream As StreamWriter

    Dim mPrintDateTimeOption As DateTimeInfo = DateTimeInfo.PrintCurrentDateTime
    Dim mPrintOriginOption As Boolean = True

#End Region

#Region " Methods "

    Public Sub New(ByVal Path As String, ByVal ApplicationName As String, Optional ByVal MaxKbLogFile As Int32 = 500)
        Me.Path = Path
        Me.ApplicationName = ApplicationName
        Me.ActiveKBLimit = MaxKbLogFile
        DoBackup()
    End Sub

    Private Function MustBackup() As Boolean
        If File.Exists(mPath & mActiveLogFileName) Then
            Dim LogFile As New FileInfo(mPath & mActiveLogFileName)
            Return (LogFile.Length / 1024) > mActiveKBLimit
        Else
            CreateNewLogFile()
            Return False
        End If
    End Function
    Private Sub DoBackup()
        If MustBackup() Then
            File.Copy(mPath & mActiveLogFileName, mPath & mActiveLogFileName & ".bak", True)
            CreateNewLogFile()
        End If
    End Sub

    Private Sub CreateNewLogFile()
        Dim str As IO.FileStream = File.Create(mPath & mActiveLogFileName)
        str.Close()
    End Sub

    Private Sub CheckAndBackup()
        If MustBackup() Then
            EndLog()
            DoBackup()
            BeginLog()
        End If
    End Sub

#End Region

#Region " Log events " ' Acciones para escribir en el archivo

    Public Sub LogEvent(ByVal Message As String)
        If mLogIsActive = True Then
            Message = GetDateTimeInfo() & GetOrigin() & Message
            CheckAndBackup()
            If Not mLogStream Is Nothing Then
                Try
                    mLogStream.WriteLine(Message)
                    mLogStream.Flush()
                Catch
                    'es un log, si no se puede escribir que no moleste
                End Try

            End If
        End If
    End Sub

    Public Sub LogExcepton(ByVal ex As Exception)
        LogEvent("**EXCEPTION** " + ex.ToString)
    End Sub

    Public Sub BeginLog()
        If mLogIsActive = True Then
            Try
                OpenLogFile()

                mLogStream.WriteLine(Separator)
            Catch
                mLogIsActive = False
            End Try

        End If
    End Sub

    Public Sub EndLog()
        If mLogIsActive = True Then
            'mLogStream.WriteLine(Separator)
            CloseLogFile()
        End If
    End Sub

    Private Sub OpenLogFile()
        mLogFile = New FileStream(mPath & mActiveLogFileName, FileMode.Append)
        mLogStream = New StreamWriter(mLogFile)
    End Sub

    Private Sub CloseLogFile()
        Try
            If Not mLogStream Is Nothing Then
                mLogStream.Close()
            End If
            If Not mLogFile Is Nothing Then
                mLogFile.Close()
            End If

        Catch
        Finally

            mLogStream = Nothing
            mLogFile = Nothing
        End Try

    End Sub


    Private Function GetOrigin() As String
        If Me.mPrintOriginOption = True Then
            Dim st As New Diagnostics.StackTrace(False)
            Dim sf As Diagnostics.StackFrame = st.GetFrame(2)
            Dim method As Reflection.MethodBase = sf.GetMethod

            Return String.Format("[{0}.{1}] ", method.DeclaringType.Name, method.Name)
        Else
            Return String.Empty
        End If

    End Function

    Private Function GetDateTimeInfo() As String
        Dim ret As String
        Select Case mPrintDateTimeOption

            Case DateTimeInfo.PrintCurrentDateTime ' Default
                ret = Date.Today.ToShortDateString + " " + Now.ToString("HH:mm:ss") + " " ' .ToString("dd-MM-yyyy") & " " & Now.ToString("HH:mm:ss") + " "
            Case DateTimeInfo.PrintCurrentDate
                ret = Date.Today.ToShortDateString + " " 'Date.Today.ToString("dd-MM-yyyy") + " "
            Case DateTimeInfo.PrintCurrentTime
                ret = Now.ToString("HH:mm:ss") + " " 'Now.ToString("HH:mm:ss") + " "
            Case Else
                ret = String.Empty
        End Select
        Return ret
    End Function

#End Region

#Region " Properties "

    Public Property ActiveKBLimit() As Int32
        Get
            Return mActiveKBLimit
        End Get
        Set(ByVal Value As Int32)
            If Value >= 0 Then
                mActiveKBLimit = Value
            End If
        End Set
    End Property

    'Public Property PassiveKBLimit() As Int32
    '    Get
    '        Return mPassiveKBLimit
    '    End Get
    '    Set(ByVal Value As Int32)
    '        If Value >= 0 Then
    '            mPassiveKBLimit = Value
    '            If mPassiveKBLimit < mActiveKBLimit Then
    '                mActiveKBLimit = Value
    '            End If
    '        End If
    '    End Set
    'End Property

    Public Property Path() As String
        Get
            Return mPath
        End Get
        Set(ByVal Value As String)
            Try
                If Value.Substring(Value.Length - 1, 1) = "\" Then
                    mPath = Value
                Else
                    mPath = Value & "\"
                End If
                If Not Directory.Exists(mPath) Then
                    mPath = ""
                    mLogIsActive = False
                Else
                    mLogIsActive = True
                End If
            Catch oEx As Exception
                mLogIsActive = False
            End Try
        End Set
    End Property

    Public WriteOnly Property ApplicationName() As String
        Set(ByVal Value As String)
            mActiveLogFileName = Value & ".log"
        End Set
    End Property

    Public Property PrintDateTimeOption() As DateTimeInfo
        Get
            Return mPrintDateTimeOption
        End Get
        Set(ByVal Value As DateTimeInfo)
            mPrintDateTimeOption = Value
        End Set
    End Property

    Public Property PrintOriginOption() As Boolean
        Get
            Return mPrintOriginOption
        End Get
        Set(ByVal Value As Boolean)
            mPrintOriginOption = Value
        End Set
    End Property

#End Region

End Class

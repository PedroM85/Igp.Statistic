Imports System.Diagnostics.EventLog

Public Class EventViewer

    Private mEventLog As Diagnostics.EventLog
    Const LOGNAME As String = "unelca 3000"

    Public Sub New(ByVal source As String, ByVal machineName As String)

        If Not SourceExists(source, machineName) Then
            Dim eventSourceCreationData As New EventSourceCreationData(source, LOGNAME)
            eventSourceCreationData.MachineName = machineName
            CreateEventSource(eventSourceCreationData)
        End If

        mEventLog = New Diagnostics.EventLog
        mEventLog.MachineName = machineName
        mEventLog.Source = source

    End Sub

    Public Sub WriteEntry(ByVal message As String, ByVal entryType As EventLogEntryType, ByVal eventID As Integer)
        mEventLog.WriteEntry(message, entryType, eventID)
    End Sub

End Class

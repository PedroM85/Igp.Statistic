Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReporteTemporada
    Dim report As ReportClass

    Public Sub New(_report As ReportClass)
        InitializeComponent()
        report = _report
    End Sub

    Private Sub frmReporteTemporada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = report
    End Sub
End Class
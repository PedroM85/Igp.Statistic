Imports Igp.AccessControl

Public Class TemporadaReporte

    Public Shared Function ObtenerReporteTemporada() As ReporteTemporada
        Dim reporte As New ReporteTemporada
        Dim temporada As dsTemporada = TempoDs.ObtenerClientes()
        reporte.SetDataSource(temporada)
        Return reporte
    End Function
End Class

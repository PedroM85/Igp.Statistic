Imports System.Windows.Forms.DataVisualization.Charting
Public Class frmDashboard
    Sub llenarchart()
        Chart1.Series(0).ChartType = SeriesChartType.FastLine
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True

        Chart1.Series(0).Points.AddY(0.0)
        Chart1.Series(0).Points.AddY(0.0)
        Chart1.Series(0).Points.AddY(0.0)

        Chart1.Series(0).Points(0).LegendText = "Saldo"
        Chart1.Series(0).Points(1).LegendText = "Cancelado"
        Chart1.Series(0).Points(2).LegendText = "Cancelado"

        Chart1.Series(0).Label = "#VAL{C}"

        TxtMontodeCredito.Text = 100.ToString
        TxtCancelado.Text = 35.8.ToString
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub CambioValores(sender As System.Object, e As System.EventArgs) Handles TxtMontodeCredito.TextChanged, TxtCancelado.TextChanged
        Dim monto As Decimal
        Dim cancelado As Decimal

        If Decimal.TryParse(TxtMontodeCredito.Text, monto) And monto > 0 And Decimal.TryParse(TxtCancelado.Text, cancelado) And Not cancelado > monto Then
            'Chart1.Series(0).Points(0).SetValueY(monto - cancelado)
            'Chart1.Series(0).Points(1).SetValueY(cancelado)
            Chart1.Series(0).Points(1).SetValueY(18)
            Chart1.Series(0).Points(0).SetValueY(30)
            Chart1.Series(0).Points(2).SetValueY(15)
            Chart1.Series.Invalidate()
        End If
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarchart()
    End Sub
End Class
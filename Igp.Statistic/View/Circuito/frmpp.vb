Public Class frmpp

    Friend WithEvents ucCircuito As Igp.Common.ucCircuito
    Private Sub frmpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Igp.Common.EnvironmentObjects.Framework.Connection = oApp.ole

    End Sub
End Class
Public Class Form1

    Public conn As New ConnectionString

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.pnlContener.Controls.Count > 0 Then Me.pnlContener.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.pnlContener.Controls.Add(fh)
        Me.pnlContener.Tag = fh
        fh.Show()

    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        AbrirFormEnPanel(New frmDashboard)
    End Sub

    Private Sub BtnPiloto_Click(sender As Object, e As EventArgs) Handles BtnPiloto.Click
        AbrirFormEnPanel(New frmPiloto)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

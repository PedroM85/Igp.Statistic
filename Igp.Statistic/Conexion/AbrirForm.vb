Module AbrirForm
    Public Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        Dim oApp As New Form1

        If oApp.pnlContener.Controls.Count > 0 Then oApp.pnlContener.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        oApp.pnlContener.Controls.Add(fh)
        oApp.pnlContener.Tag = fh
        fh.Show()

    End Sub
End Module

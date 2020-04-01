Public Class ucCircuito
    Inherits System.Windows.Forms.UserControl

    Private llenado As New dsCircuito
    Dim paralgo As New dlCircuito

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadGlobalCaptions()

    End Sub




    Private Sub ucCircuito_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dgv.DataBindings = paralgo.fillParameters(llenado)
    End Sub

    Public Sub LoadGlobalCaptions()

    End Sub
End Class

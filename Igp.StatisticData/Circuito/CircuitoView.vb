Public Class CircuitoView
    Inherits System.Windows.Forms.UserControl


    Private dsCircuito As New CircuitoDataSet
    Dim oParConfigurationLayer As New CircuitoDataLayer

    Public Sub New()
        MyBase.New
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CircuitoView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadgried
    End Sub

    Public Sub loadgried()
        oParConfigurationLayer.fillCircuito(dsCircuito)
        dgvCircuitos.DataSource = dsCircuito.SYS_Circuito
    End Sub
End Class

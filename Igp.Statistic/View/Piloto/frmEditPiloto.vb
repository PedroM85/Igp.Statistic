Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl
Public Class frmEditPiloto

    Private _idEmpleado As Nullable(Of Integer) = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(id As Integer)
        Me.New()
        _idEmpleado = id
    End Sub
    Private Sub CargarNacion()

        cboNacion.DisplayMember = "Descripcion"
        cboNacion.ValueMember = "idNacion"
        cboNacion.DataSource = NacionDAL.ObtenerTodos()

    End Sub

    Private Sub frmEditPiloto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNacion()
        txtnombre.SelectAll()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim Piloto As New PilotoEntity() With {
          .id = _idEmpleado.GetValueOrDefault(),
          .nombre = txtnombre.Text,
          .nacion = Convert.ToInt16(cboNacion.SelectedValue)
          }

        MsgBox(Piloto.id)

        PilotosDAL.Save(Piloto)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Close()
    End Sub
End Class
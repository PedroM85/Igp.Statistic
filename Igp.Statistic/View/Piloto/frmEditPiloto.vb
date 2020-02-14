Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl
Imports System.Windows.Forms
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

        If _idEmpleado.HasValue Then
            Dim Piloto As PilotoEntity = PilotosDAL.ObtenerById(_idEmpleado.Value)

            _idEmpleado = Piloto.id
            txtnombre.Text = Piloto.nombre
            cboNacion.Text = Piloto.nacion

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim Piloto As New PilotoEntity() With {
          .id = _idEmpleado.GetValueOrDefault(),
          .nombre = txtnombre.Text,
          .nacion = Convert.ToInt16(cboNacion.SelectedValue)
          }

        '.id = _idEmpleado.GetValueOrDefault(),

        MsgBox(Piloto.id)

        PilotosDAL.Save(Piloto)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Close()
    End Sub
End Class
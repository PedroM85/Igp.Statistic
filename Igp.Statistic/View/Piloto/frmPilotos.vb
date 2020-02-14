Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Public Class frmPilotos
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub frmPilotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarListaPilotos()


    End Sub


    Private Sub CargarListaPilotos()
        dgvPilotos.AutoGenerateColumns = False
        'dgvPilotos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvPilotos.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPilotos.Columns(0).Width = 50
        dgvPilotos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvPilotos.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPilotos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPilotos.Columns(1).Width = 205



        dgvPilotos.DataSource = PilotosDAL.ObtenerTodos

        For Each row As DataGridViewRow In dgvPilotos.Rows
            'se asigna el alto de la fila para poder ver la imagen correctamente
            row.Height = 120

            'se recupera la entidad que es asignada como dato
            Dim Piloto As PilotoEntity = TryCast(row.DataBoundItem, PilotoEntity)

            'If Piloto.imagen Is Nothing Then
            '    row.Cells("Imagen").Value = ImageHelper.ObtenerImagenNoDisponible()
            'Else
            '    row.Cells("Imagen").Value = ImageHelper.ByteArrayToImage(Piloto.imagen)
            'End If
        Next

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmEditPiloto

        frm.ShowDialog()
    End Sub


    Private Sub dgvPilotos_CellContentDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

        Dim idPiloto As Integer = Convert.ToInt32(dgvPilotos.Rows(e.RowIndex).Cells("id").Value)

        Dim frmeditar As New frmEditPiloto(idPiloto)
        AddHandler frmeditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditPiloto_FormClosing)

        frmEditPiloto.txtid.Text = dgvPilotos.CurrentRow.Cells(0).Value.ToString
        frmEditPiloto.txtnombre.Text = dgvPilotos.CurrentRow.Cells(1).Value.ToString

        frmEditPiloto.ShowDialog()

    End Sub

    Private Sub frmEditPiloto_FormClosing(sender As Object, e As FormClosingEventArgs)
        '
        ' al cerrarse el form de edicion se ingresa a este evento 
        ' para actualizar la informacion del listado
        '

        Dim frmEdit As frmEditPiloto = TryCast(sender, frmEditPiloto)

        If frmEdit.DialogResult = DialogResult.OK Then
            CargarListaPilotos()
        End If

    End Sub

End Class
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.Helpers
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl



Partial Public Class frmPiloto_OLD
    Inherits Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Dim frm As frmEditPiloto = New frmEditPiloto
    Private Sub frmPiloto_Load(sender As Object, e As EventArgs)

        'conn.CargarAllPiloto(dtgPiloto)
        CargarListaEmpleados()


    End Sub
    Private Sub CargarListaEmpleados()
        dtgPiloto.AutoGenerateColumns = False
        dtgPiloto.DataSource = PilotosDAL.ObtenerTodos

        For Each row As DataGridViewRow In dtgPiloto.Rows
            'se asigna el alto de la fila para poder ver la imagen correctamente
            row.Height = 120

            'se recupera la entidad que es asignada como dato
            Dim Piloto As PilotoEntity = TryCast(row.DataBoundItem, PilotoEntity)

            If Piloto.imagen Is Nothing Then
                row.Cells("Imagen").Value = ImageHelper.ObtenerImagenNoDisponible()
            Else
                row.Cells("Imagen").Value = ImageHelper.ByteArrayToImage(Piloto.imagen)
            End If
        Next

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Dim frmEditPiloto As New frmEditPiloto_OLD()
        AddHandler frmEditPiloto.FormClosing, New FormClosingEventHandler(AddressOf frmEditPiloto_FormClosing)

        frmEditPiloto.ShowDialog()
    End Sub

    Private Sub frmEditPiloto_FormClosing(sender As Object, e As FormClosingEventArgs)

        Dim frmEditPiloto As frmEditPiloto_OLD = TryCast(sender, frmEditPiloto_OLD)
        If frmEditPiloto.DialogResult = DialogResult.OK Then
            CargarListaEmpleados()
        End If
    End Sub
    Private Sub dtgPiloto_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

        'frm.lblID.Text = dtgPiloto.CurrentRow.Cells(0).Value.ToString.Trim
        'frm.lblidP.Text = dtgPiloto.CurrentRow.Cells(1).Value.ToString.Trim
        'frm.txtNombre.Text = dtgPiloto.CurrentRow.Cells(2).Value.ToString.Trim
        'frm.txtNacionalidad.Text = dtgPiloto.CurrentRow.Cells(3).Value.ToString.Trim
        'If dtgPiloto.CurrentRow.Cells(4).Value IsNot DBNull.Value Then
        '    frm.picImagenEmpleado.Image = Image.FromFile(dtgPiloto.CurrentRow.Cells(4).Value)
        'Else

        'End If

        'frm.ShowDialog()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class
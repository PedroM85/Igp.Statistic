Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.Helpers
Imports Igp.AccessControl.Entidades
Partial Public Class frmTemporada
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmTemporada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaTemp()

    End Sub

    Private Sub CargarListaTemp()
        dgvTemporada.AutoGenerateColumns = False
        dgvTemporada.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        dgvTemporada.DataSource = TempoDAL.ObtenerTodos

        For Each row As DataGridViewRow In dgvTemporada.Rows
            'se asigna el alto de la fila para poder ver la imagen correctamente
            'row.Height = 120

            'se recupera la entidad que es asignada como dato
            Dim empleado As EmpleadoEntity = TryCast(row.DataBoundItem, EmpleadoEntity)

            'If empleado.Imagen Is Nothing Then
            '	row.Cells("Imagen").Value = ImageHelper.ObtenerImagenNoDisponible()
            'Else
            '	row.Cells("Imagen").Value = ImageHelper.ByteArrayToImage(empleado.Imagen)
            'End If
        Next
    End Sub


    Private Sub dgvTemporada_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTemporada.CellContentDoubleClick
        Try
            'Dim IdEmpleado As Integer = Convert.ToInt32(dgvNacion.Rows(e.RowIndex).Cells("IdEmpleado").Value) IdNacion
            Dim idTempo As Integer = Convert.ToInt32(dgvTemporada.Rows(e.RowIndex).Cells("Id").Value)
            '
            ' al pasarle un id de empleado este lo cargara para su edicion
            '
            Dim frmEditar As New frmeditTempo(idTempo)
            AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)

            frmEditar.ShowDialog()
        Catch ex As Exception
            MsgBox("Seleccion del Datagridview: " + ex.ToString)
        End Try
    End Sub


    Private Sub frmEditar_FormClosing(sender As Object, e As FormClosingEventArgs)
        '
        ' al cerrarse el form de edicion se ingresa a este evento 
        ' para actualizar la informacion del listado
        '

        Dim frmEdit As frmeditTempo = TryCast(sender, frmeditTempo)

        If frmEdit.DialogResult = DialogResult.OK Then
            CargarListaTemp()
        End If

    End Sub

    Private Sub btnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpleado.Click
        ' sino se le pasa un id ,el formulario entrara en modo alta
        '
        Dim frmEditar As New frmeditTempo()
        AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)


        frmEditar.ShowDialog()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmCircuito
    Inherits Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub frmCircuito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaListaCircuito
    End Sub

    Private Sub CargaListaCircuito()
        dgvCircuitos.AutoGenerateColumns = False
        dgvCircuitos.DataSource = CircuitoDAL.ObtenerTodos


        For Each row As DataGridViewRow In dgvCircuitos.Rows
            Dim nacion As CircuitoEntity = TryCast(row.DataBoundItem, CircuitoEntity)
        Next
    End Sub

    Private Sub dgvCircuitos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCircuitos.CellContentClick

        'Dim IdEmpleado As Integer = Convert.ToInt32(dgvNacion.Rows(e.RowIndex).Cells("IdEmpleado").Value) IdNacion
        Dim IdCircuito As Integer = Convert.ToInt32(dgvCircuitos.Rows(e.RowIndex).Cells("id").Value)
            '
            ' al pasarle un id de empleado este lo cargara para su edicion
            '
            Dim frmEditar As New frmEditCircuito(IdCircuito)
            AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)

            frmEditar.ShowDialog()

    End Sub

    Private Sub frmEditar_FormClosing(sender As Object, e As FormClosingEventArgs)
        '
        ' al cerrarse el form de edicion se ingresa a este evento 
        ' para actualizar la informacion del listado
        '

        Dim frmEdit As frmEditCircuito = TryCast(sender, frmEditCircuito)

        If frmEdit.DialogResult = DialogResult.OK Then
            CargaListaCircuito()
        End If

    End Sub
    Private Sub btnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpleado.Click
        ' sino se le pasa un id ,el formulario entrara en modo alta
        '
        Dim frmEditar As New frmEditCircuito()
        AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)


        frmEditar.ShowDialog()
    End Sub
End Class
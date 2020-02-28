Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmNacion
    Inherits Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub frmNacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaNacion
    End Sub

    Private Sub CargarListaNacion()
        dgvNacion.AutoGenerateColumns = False
        dgvNacion.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        dgvNacion.DataSource = NacionDAL.ObtenerTodos

        For Each row As DataGridViewRow In dgvNacion.Rows
            Dim nacion As NacionEntity = TryCast(row.DataBoundItem, NacionEntity)
        Next
    End Sub

    Private Sub dgvNacion_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNacion.CellContentDoubleClick
        Try
            'Dim IdEmpleado As Integer = Convert.ToInt32(dgvNacion.Rows(e.RowIndex).Cells("IdEmpleado").Value) IdNacion
            Dim IdEmpleado As Integer = Convert.ToInt32(dgvNacion.Rows(e.RowIndex).Cells("id").Value)
            '
            ' al pasarle un id de empleado este lo cargara para su edicion
            '
            Dim frmEditar As New frmEditNacion(IdEmpleado)
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

        Dim frmEdit As frmEditNacion = TryCast(sender, frmEditNacion)

        If frmEdit.DialogResult = DialogResult.OK Then
            CargarListaNacion()
        End If

    End Sub

    Private Sub btnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpleado.Click
        ' sino se le pasa un id ,el formulario entrara en modo alta
        '
        Dim frmEditar As New frmEditNacion()
        AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)


        frmEditar.ShowDialog()
    End Sub


End Class
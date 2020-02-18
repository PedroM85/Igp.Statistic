Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmConfiguracion
    Inherits Form

    Private pruebalago As New ConfigDAL
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarListaConfig()
        dgvConfiguracion_cellbegininit()
    End Sub

    Private Sub CargarListaConfig()
        dgvConfiguracion.DataSource = ConfigDAL.ObtenerTodos

        For Each row As DataGridViewRow In dgvConfiguracion.Rows
            Dim Config As ConfigEntity = TryCast(row.DataBoundItem, ConfigEntity)
        Next


    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        dgvconfiguracion_cellbendedit(False)

        Try
            'Dim IdEmpleado As Integer = Convert.ToInt32(dgvNacion.Rows(e.RowIndex).Cells("IdEmpleado").Value) IdNacion
            Dim IdEmpleado As Integer = 1 'Convert.ToInt32(dgvConfiguracion.Rows(e.RowIndex).Cells("ID").value)
            '
            ' al pasarle un id de empleado este lo cargara para su edicion
            '
            Dim frmEditar As New frmEditConfig(IdEmpleado)
            AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)

            frmEditar.ShowDialog()
        Catch ex As Exception
            MsgBox("Seleccion del Datagridview: " + ex.ToString)
        End Try

    End Sub

    Dim temp As String
    Private Sub dgvConfiguracion_cellbegininit()
        temp = dgvConfiguracion.Cell(3).Value.ToString
    End Sub

    Private Sub dgvconfiguracion_cellbendedit(cambio As Boolean)

        Dim algo As String = dgvConfiguracion.Currents.Cell(3).Value.ToString


        If algo = temp Then
            cambio = False
        Else
            cambio = True
        End If

    End Sub

    Private Sub frmEditar_FormClosing(sender As Object, e As FormClosingEventArgs)
        '
        ' al cerrarse el form de edicion se ingresa a este evento 
        ' para actualizar la informacion del listado
        '

        Dim frmEdit As frmEditNacion = TryCast(sender, frmEditNacion)

        If frmEdit.DialogResult = DialogResult.OK Then
            CargarListaConfig()
        End If

    End Sub
End Class
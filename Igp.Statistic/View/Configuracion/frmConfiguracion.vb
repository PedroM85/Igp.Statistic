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


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarListaConfig()

    End Sub

    Private Sub CargarListaConfig()
        dgvConfiguracion.AutoGenerateColumns = False
        dgvConfiguracion.DataSource = ConfigDAL.ObtenerTodos

        For Each row As DataGridViewRow In dgvConfiguracion.Rows
            Dim Config As ConfigEntity = TryCast(row.DataBoundItem, ConfigEntity)
        Next


    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub



    Private Sub frmEditar_FormClosing(sender As Object, e As FormClosingEventArgs)
        '
        ' al cerrarse el form de edicion se ingresa a este evento 
        ' para actualizar la informacion del listado
        '

        Dim frmEdit As frmEditConfig = TryCast(sender, frmEditConfig)

        If frmEdit.DialogResult = DialogResult.OK Then
            CargarListaConfig()
        End If

    End Sub

    Private Sub dgvConfiguracion_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConfiguracion.CellContentDoubleClick

        'Dim IdEmpleado As Integer = Convert.ToInt32(dgvNacion.Rows(e.RowIndex).Cells("IdEmpleado").Value) IdNacion
        Dim IdConfig As Integer = Convert.ToInt32(dgvConfiguracion.Rows(e.RowIndex).Cells("ida").Value)
        '
        ' al pasarle un id de empleado este lo cargara para su edicion
        '
        Dim frmEditar As New frmEditConfig(IdConfig)
            AddHandler frmEditar.FormClosing, New FormClosingEventHandler(AddressOf frmEditar_FormClosing)

            frmEditar.ShowDialog()

    End Sub
End Class
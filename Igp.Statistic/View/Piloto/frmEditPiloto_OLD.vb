Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports Igp.Helpers
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl.Entidades
Imports Igp.AccessControl



Partial Public Class frmEditPiloto_OLD
    Inherits Form


    Private _idEmpleado As Nullable(Of Integer) = Nothing


    Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "Archivo JPG|*.jpg"

        If fileDialog.ShowDialog() = DialogResult.OK Then
            picImagenEmpleado.Image = Image.FromFile(fileDialog.FileName)
        End If

    End Sub
    Private Sub CargarNacion()

        cboNacion.DisplayMember = "Descripcion"
        cboNacion.ValueMember = "idNacion"
        cboNacion.DataSource = NacionDAL.ObtenerTodos()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ' al cerrarse el form de edicion se ingresa a este evento 
        ' para actualizar la informacion del listado
        '

        'Dim frmEdit As EditarEmpleado = TryCast(sender, EditarEmpleado)

        'If frmEdit.DialogResult = DialogResult.OK Then
        '    CargarListaEmpleados()
        'End If
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Piloto As New PilotoEntity() With {
            .id = _idEmpleado.GetValueOrDefault(),
            .nombre = txtNombre.Text,
            .nacion = Convert.ToInt16(cboNacion.SelectedValue),
            .imagen = ImageHelper.ImageToByteArray(picImagenEmpleado.Image)
            }



        PilotosDAL.Save(Piloto)

        Me.DialogResult = DialogResult.OK
        Me.Close()


    End Sub

    Private Sub frmEditPiloto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarNacion()
        'por defecto se carga una imagen de no disponible
        picImagenEmpleado.Image = ImageHelper.ObtenerImagenNoDisponible()
    End Sub


End Class
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
        CargarListaTemp

    End Sub

    Private Sub CargarListaTemp()
        dgvTemporada.AutoGenerateColumns = False
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
End Class
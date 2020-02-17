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
End Class
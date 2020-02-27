Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmCampeonato
    Inherits Form


    Private _idTemporada As String = String.Empty
    Private _idCircuito As String = String.Empty



    Public Sub New(idCircuito As String, idTemporada As String)
        Me.New()
        _idTemporada = idTemporada
        _idCircuito = idCircuito
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaListaCircuito()
        CargaListaTempo()
    End Sub

    Private Sub CargaListaTempo()
        cboTemporada.DisplayMember = "Descripcion"
        cboTemporada.ValueMember = "Idtempo"
        cboTemporada.DataSource = TempoDAL.ObtenerbyActive()
    End Sub

    Private Sub CargaListaCircuito()
        cboCircuito.DisplayMember = "Circuito"
        cboCircuito.ValueMember = "ID"
        cboCircuito.DataSource = CircuitoDAL.ObtenerTodos()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '_idTemporada = cboTemporada.SelectedValue
        '_idCircuito = cboCircuito.SelectedValue
        Try
            If _idTemporada.ToString Then


                Dim Campeo As CampeoEntity = CampeoDAL.ObtenerByTempoCircui(_idTemporada, _idCircuito)

                _idTemporada = nacion.IdNacion
                txtNacion.Text = nacion.Descripcion
                'txtApellido.Text = empleado.Apellido
                'dtpFechaNacimiento.Value = empleado.FechaNacimiento

                'cbEstadoCivil.SelectedValue = Convert.ToInt32(empleado.Apellido)


            End If
        Catch ex As Exception
            MsgBox("Funcion EditNacion_load: " + ex.ToString)
        End Try
        CargarBusqueda()
    End Sub

    Private Sub CargarBusqueda()
        dgvData.AutoGenerateColumns = False
        dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
        dgvData.DataSource = CampeoDAL.ObtenerByTempoCircui()

        For Each row As DataGridViewRow In dgvData.Rows
            Dim Campeo As CampeoEntity = TryCast(row.DataBoundItem, CampeoEntity)
        Next
    End Sub

    Private Sub cboTemporada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTemporada.SelectedIndexChanged

        'Dim _idTemporada As String = String.Empty

        If (cboTemporada.SelectedIndex <> -1) Then
            _idTemporada = cboTemporada.Text
        End If

        cboTemporada.Text = _idTemporada
    End Sub

    Private Sub cboCircuito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCircuito.SelectedIndexChanged
        If (cboCircuito.SelectedIndex <> -1) Then
            _idCircuito = cboCircuito.Text
        End If

        cboCircuito.Text = _idCircuito
    End Sub
End Class
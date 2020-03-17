'Imports System.Collections.Generic
'Imports System.ComponentModel
'Imports System.Data
'Imports System.Drawing
'Imports System.Linq
'Imports System.Text
'Imports System.Windows.Forms
'Imports Igp.AccessControl
'Imports Igp.AccessControl.Entidades
'Partial Public Class frmCampeonato
'    Inherits Form

'    Private _idTemporada As String = String.Empty
'    Private _idCircuito As String = String.Empty



'    Public Sub New(idCircuito As String, idTemporada As String)
'        Me.New()
'        _idTemporada = idTemporada
'        _idCircuito = idCircuito
'    End Sub
'    Public Sub New()

'        ' This call is required by the designer.
'        InitializeComponent()

'        ' Add any initialization after the InitializeComponent() call.

'    End Sub

'    Private Sub frmCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        CargaListaCircuito()
'        CargaListaTempo()
'        'contar_filas()
'    End Sub

'    Private Sub CargaListaTempo()
'        cboTemporada.DisplayMember = "Descripcion"
'        cboTemporada.ValueMember = "Idtempo"
'        cboTemporada.DataSource = TempoDAL.ObtenerbyActive()

'    End Sub

'    Private Sub CargaListaCircuito()
'        cboCircuito.DisplayMember = "Circuito"
'        cboCircuito.ValueMember = "ID"
'        cboCircuito.DataSource = CircuitoDAL.ObtenerTodos()
'    End Sub

'    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
'        If String.IsNullOrEmpty(cboTemporada.Text) Then

'            ErrorProvider.SetError(cboTemporada, "No hay informacion de temporada Activa")
'        Else
'            If String.IsNullOrEmpty(cboCircuito.Text) Then



'                ErrorProvider.SetError(cboCircuito, "No hay informacion de circuitos")

'            Else

'                CargarBusqueda()
'            End If
'        End If

'    End Sub

'    Private Sub CargarBusqueda()
'        For j As Integer = 0 To dgvData.ColumnCount - 1
'            With dgvData
'                .AutoGenerateColumns = False
'                .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
'                .Columns(j).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                .Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                .DataSource = CampeoDAL.ObtenerByTempoCircui(_idTemporada, _idCircuito)
'            End With

'            For Each row As DataGridViewRow In dgvData.Rows
'                Dim Campeo As CampeoEntity = TryCast(row.DataBoundItem, CampeoEntity)
'            Next
'            'contar_filas()
'        Next


'    End Sub

'    Private Sub cboTemporada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTemporada.SelectedIndexChanged

'        'Dim _idTemporada As String = String.Empty

'        If (cboTemporada.SelectedIndex <> -1) Then
'            _idTemporada = cboTemporada.Text
'        End If

'        cboTemporada.Text = _idTemporada
'    End Sub

'    Private Sub cboCircuito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCircuito.SelectedIndexChanged
'        If (cboCircuito.SelectedIndex <> -1) Then
'            _idCircuito = cboCircuito.Text
'        End If

'        cboCircuito.Text = _idCircuito
'    End Sub

'    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
'        Me.Close()
'    End Sub
'    'Sub contar_filas()

'    '    Dim filas As Integer = Me.dgvData.RowCount
'    '    If filas = 0 Then
'    '        lblContarFilas.Text = "[ " & filas & " Regitro cargado de " & AppPar.npiloto & "]"
'    '    ElseIf filas = 1 Then
'    '        lblContarFilas.Text = "[ " & filas & " Regitro cargado  de " & AppPar.npiloto & "]"
'    '    Else
'    '        lblContarFilas.Text = "[ " & filas & " Regitros cargados de " & AppPar.npiloto & "]"
'    '    End If
'    'End Sub


'End Class
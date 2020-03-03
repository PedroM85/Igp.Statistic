﻿Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmPosicion
    Inherits Form
    '    Dim npiloto As Integer = oAppPAR.GetValue("NPILOTO")

    Private _idPosicion As Nullable(Of Integer) = Nothing
    Private _idCircuito As Nullable(Of Integer) = Nothing
    Private _id As Nullable(Of Integer) = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(id As Integer, idPosicion As Integer, idCircuito As Integer)
        Me.New()
        _id = id
        _idPosicion = idPosicion
        _idCircuito = idCircuito
    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub frmPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dgvPosicion
            .AutoGenerateColumns = False
            .AllowUserToAddRows = False
        End With
        CargaListaTempo()
        CargaListaPiloto()
        CargaListaCircuito()
        contar_filas()
        ' Me.dgvPosicion.ContextMenuStrip = Me.cmsMenu

    End Sub

    Private Sub CargaListaTempo()
        cboTempo.DisplayMember = "Descripcion"
        cboTempo.ValueMember = "Idtempo"
        cboTempo.DataSource = TempoDAL.ObtenerbyActive()
    End Sub

    Private Sub CargaListaPiloto()
        cboPiloto.DisplayMember = "Nombre"
        cboPiloto.ValueMember = "id"
        cboPiloto.DataSource = PilotosDAL.ObtenerTodos()
    End Sub

    Private Sub CargaListaCircuito()
        cboCircuito.DisplayMember = "Circuito"
        cboCircuito.ValueMember = "ID"
        cboCircuito.DataSource = CircuitoDAL.ObtenerTodos()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPuesto.KeyDown
        Dim Punto As Integer

        Select Case e.KeyData
                Case Keys.Enter
                Try
                    Dim dgvDatos As DataGridViewRow = Me.dgvPosicion.CurrentRow

                    If String.IsNullOrEmpty(txtPuesto.Text) Then
                        MessageBox.Show("No ingreso puesto de llegada")
                        Me.txtPuesto.SelectAll()
                    ElseIf txtPuesto.Text > AppPar.npiloto Then
                        MessageBox.Show("El puesto ingresado supera la grilla!")
                        Me.txtPuesto.SelectAll()
                    ElseIf txtPuesto.Text = 0 Then
                        MessageBox.Show("No puede haber puesto 0")
                        Me.txtPuesto.SelectAll()
                    Else

                        If ExisteEnPiloto(cboPiloto.Text) Then
                            Return
                        End If

                        If ExisteEnLista(txtPuesto.Text) Then
                            Return
                        End If



                        Select Case txtPuesto.Text
                            Case "1"
                                Punto = Convert.ToInt32(25)
                            Case "2"
                                Punto = Convert.ToInt32(18)
                            Case "3"
                                Punto = Convert.ToInt32(15)
                            Case "4"
                                Punto = Convert.ToInt32(12)
                            Case "5"
                                Punto = Convert.ToInt32(10)
                            Case "6"
                                Punto = Convert.ToInt32(8)
                            Case "7"
                                Punto = Convert.ToInt32(6)
                            Case "8"
                                Punto = Convert.ToInt32(4)
                            Case "9"
                                Punto = Convert.ToInt32(2)
                            Case "10"
                                Punto = Convert.ToInt32(1)
                            Case > "11"
                                Punto = Convert.ToInt32(0)
                        End Select




                        Dim row As String() = New String() {cboTempo.Text, cboTempo.SelectedValue, cboCircuito.Text, cboCircuito.SelectedValue, cboPiloto.Text, cboPiloto.SelectedValue, txtPuesto.Text, txtPuesto.Text, Punto}

                        dgvPosicion.Rows.Add(row)


                        cboPiloto.Focus()
                        contar_filas()

                        With dgvPosicion
                            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                        End With
                    End If

                Catch ex As Exception

                End Try
            End Select


    End Sub

    Private Sub txtPuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuesto.KeyPress

        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Function ExisteEnLista(ByVal rol As String) As Boolean

        Dim existe As Boolean = False

        For Each row As DataGridViewRow In dgvPosicion.Rows
            Dim verificar As String = Convert.ToString(row.Cells("Puesto").Value)
            If rol = verificar Then
                MessageBox.Show("El Puesto N° : " + rol + ", Ya se encuentra ingresado.")
                txtPuesto.SelectAll()
                existe = True
            End If
        Next

        Return existe

    End Function
    Private Function ExisteEnPiloto(ByVal rol As String) As Boolean

        Dim existe As Boolean = False

        For Each row As DataGridViewRow In dgvPosicion.Rows
            Dim verificar As String = Convert.ToString(row.Cells("Nombre").Value)
            If rol = verificar Then
                MessageBox.Show("El Piloto : " + rol.Trim + ", Ya se encuentra ingresado.")
                txtPuesto.SelectAll()
                existe = True
            End If
        Next

        Return existe

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim posicion As New PosicionEntity()

        'Dim func As New PosicionDAL
        Try
            For j As Integer = 0 To dgvPosicion.Rows.Count - 1
                posicion.id = _id.GetValueOrDefault()
                posicion.Temporada = Convert.ToInt32(dgvPosicion.Rows(j).Cells(1).Value)
                posicion.Circuito = Convert.ToInt32(dgvPosicion.Rows(j).Cells(3).Value)
                posicion.Piloto = Convert.ToInt32(dgvPosicion.Rows(j).Cells(5).Value)
                posicion.exite = Convert.ToString(dgvPosicion.Rows(j).Cells(4).Value)
                posicion.llegada = Convert.ToInt32(dgvPosicion.Rows(j).Cells(7).Value)
                posicion.Ptsllegada = Convert.ToInt32(dgvPosicion.Rows(j).Cells(8).Value)

                PosicionDAL.Save(posicion)
                contar_filas
            Next



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If Me.DialogResult = DialogResult.OK Then
            Me.Close()
        Else


            Me.Close()
        End If

    End Sub
    Sub contar_filas()

        Dim filas As Integer = Me.dgvPosicion.RowCount
        If filas = 0 Then
            lblContarFilas.Text = "[ " & filas & " Regitro cargado de " & AppPar.npiloto & "]"
        ElseIf filas = 1 Then
            lblContarFilas.Text = "[ " & filas & " Regitro cargado  de " & AppPar.npiloto & "]"
        Else
            lblContarFilas.Text = "[ " & filas & " Regitros cargados de " & AppPar.npiloto & "]"
        End If
    End Sub

    Private Sub dgvPosicion_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPosicion.KeyDown
        Try
            Dim li_index As Integer
            If e.KeyCode = Keys.Delete Then
                e.Handled = True
                li_index = CType(sender, DataGridView).CurrentRow.Index
                If MessageBox.Show("Deseas Eliminar", "Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    dgvPosicion.Rows.RemoveAt(li_index)
                    contar_filas()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
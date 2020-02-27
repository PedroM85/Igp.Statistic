Imports System.Collections.Generic
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
    Dim npiloto As Integer = oAppPAR.GetValue("NPILOTO")

    Private _idPosicion As Nullable(Of Integer) = Nothing
    Private _idCircuito As Nullable(Of Integer) = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(idPosicion As Integer, idCircuito As Integer)
        Me.New()
        _idPosicion = idPosicion
        _idCircuito = idCircuito
    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub frmPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaListaTempo()
        CargaListaPiloto()
        CargaListaCircuito()

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
                    ElseIf txtPuesto.Text > npiloto Then
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
                                Punto = 25
                            Case "2"
                                Punto = 18
                            Case "3"
                                Punto = 15
                            Case "4"
                                Punto = 12
                            Case "5"
                                Punto = 10
                            Case "6"
                                Punto = 8
                            Case "7"
                                Punto = 6
                            Case "8"
                                Punto = 4
                            Case "9"
                                Punto = 2
                            Case "10"
                                Punto = 1
                            Case > "11"
                                Punto = 0
                        End Select



                        Dim row As String() = New String() {cboTempo.Text, cboTempo.SelectedValue, cboCircuito.Text, cboCircuito.SelectedValue, cboPiloto.Text, cboPiloto.SelectedValue, txtPuesto.Text, txtPuesto.Text, Punto}

                        dgvPosicion.Rows.Add(row)
                        cboPiloto.Focus()
                        'txtPuesto.SelectAll()
                        With dgvPosicion
                            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
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
                MessageBox.Show("El Puesto N° : " + rol + ", " + "Ya se encuentra ingresado.")
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
                MessageBox.Show("El Piloto : " + rol.Trim + ", " + "Ya se encuentra ingresado.")
                txtPuesto.SelectAll()
                existe = True
            End If
        Next

        Return existe

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim posicion As New PosicionEntity
        'Dim func As New PosicionDAL
        Try
            For j As Integer = 0 To dgvPosicion.Rows.Count - 2
                posicion.id = _idPosicion.GetValueOrDefault()
                posicion.Temporada = Convert.ToString(dgvPosicion.Rows(j).Cells(1).Value)
                posicion.Circuito = Convert.ToInt32(dgvPosicion.Rows(j).Cells(3).Value)
                posicion.Piloto = Convert.ToString(dgvPosicion.Rows(j).Cells(5).Value)
                posicion.llegada = Convert.ToInt32(dgvPosicion.Rows(j).Cells(7).Value)

                PosicionDAL.Save(posicion)
            Next



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
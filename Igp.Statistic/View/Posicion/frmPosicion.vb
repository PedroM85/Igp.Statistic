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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub frmPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaListaTempo
        CargaListaPiloto
        CargaListaCircuito

    End Sub

    Private Sub CargaListaTempo()
        cboTempo.DisplayMember = "Descripcion"
        cboTempo.ValueMember = "idNacion"
        cboTempo.DataSource = TempoDAL.ObtenerbyActive()
    End Sub

    Private Sub CargaListaPiloto()
        cboPiloto.DisplayMember = "Nombre"
        cboPiloto.ValueMember = "idNacion"
        cboPiloto.DataSource = PilotosDAL.ObtenerTodos()
    End Sub

    Private Sub CargaListaCircuito()
        cboCircuito.DisplayMember = "Circuito"
        cboCircuito.ValueMember = "idNacion"
        cboCircuito.DataSource = CircuitoDAL.ObtenerTodos()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPuesto.KeyDown
        Dim Configu As New ConfigEntity
        Dim nPilotos As String

        ConfigDAL.PARCONFIG()
        nPilotos = ConfigDAL.PARCONFIG
        nPilotos = Configu.Valor
        Select Case e.KeyData
            Case Keys.Enter

                Try
                    Dim dgvDatos As DataGridViewRow = Me.dgvPosicion1.CurrentRow

                    If String.IsNullOrEmpty(txtPuesto.Text) Then
                        MessageBox.Show("No ingreso puesto de llegada")
                        Me.txtPuesto.Focus()
                    ElseIf txtPuesto.Text >= 33 Then
                        MessageBox.Show("El puesto ingresado supera la grilla!")
                        Me.txtPuesto.Focus()
                    ElseIf txtPuesto.Text = 0 Then
                        MessageBox.Show("No puede haber puesto 0")
                        Me.txtPuesto.Focus()
                    Else

                        Dim Punto As Integer
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

                        If ExisteEnLista(txtPuesto.Text) Then
                            Return
                        End If

                        Dim row As String() = New String() {cboTempo.Text, cboCircuito.Text, cboPiloto.Text, txtPuesto.Text, Punto}

                        dgvPosicion1.Rows.Add(row)
                    End If
                Catch ex As Exception

                End Try
        End Select
    End Sub

    Private Function ExisteEnLista(ByVal rol As String) As Boolean

        Dim existe As Boolean = False

        For Each row As DataGridViewRow In dgvPosicion1.Rows
            Dim verificar As String = Convert.ToString(row.Cells("Puesto").Value)
            If rol = verificar Then
                MessageBox.Show("El Puesto Ingresado N° : " + rol + "  " + "Ya se encuentra ingresado  :" + verificar)
                existe = True
            End If
        Next

        Return existe

    End Function
End Class
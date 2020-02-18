Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmEditCircuito
    Inherits Form

    Private _idCircuito As Nullable(Of Integer) = Nothing
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(idCircuito As Integer)
        Me.New()
        _idCircuito = idCircuito
    End Sub

    Private Sub frmEditCircuito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _idCircuito.HasValue Then


                Dim Circuito As CircuitoEntity = CircuitoDAL.ObtenerById(_idCircuito.Value)

                _idCircuito = Circuito.Id
                txtCircuito.Text = Circuito.Circuito
                'txtApellido.Text = empleado.Apellido
                'dtpFechaNacimiento.Value = empleado.FechaNacimiento

                'cbEstadoCivil.SelectedValue = Convert.ToInt32(empleado.Apellido)


            End If
        Catch ex As Exception
            MsgBox("Funcion EditCircuito_load: " + ex.ToString)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Circuito As New CircuitoEntity() With
        {
        .Id = _idCircuito.GetValueOrDefault,
        .Circuito = txtCircuito.Text
        }

        CircuitoDAL.Save(Circuito)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
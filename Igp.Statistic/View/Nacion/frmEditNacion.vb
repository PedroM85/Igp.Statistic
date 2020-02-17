Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmEditNacion
    Inherits Form

	Private _idEmpleado As Nullable(Of Integer) = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(idEmpleado As Integer)
		Me.New()
		_idEmpleado = idEmpleado
	End Sub

	Private Sub frmEditNacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			If _idEmpleado.HasValue Then


				Dim nacion As NacionEntity = NacionDAL.ObtenerById(_idEmpleado.Value)

				_idEmpleado = nacion.IdNacion
				txtNacion.Text = nacion.Descripcion
				'txtApellido.Text = empleado.Apellido
				'dtpFechaNacimiento.Value = empleado.FechaNacimiento

				'cbEstadoCivil.SelectedValue = Convert.ToInt32(empleado.Apellido)


			End If
		Catch ex As Exception
			MsgBox("Funcion EditNacion_load: " + ex.ToString)
		End Try

	End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		Dim nacion As New NacionEntity() With
		{
		.IdNacion = _idEmpleado.GetValueOrDefault,
		.Descripcion = txtNacion.Text
		}

		NacionDAL.Save(nacion)

		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Me.Close()
	End Sub

	Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

		Dim nacion As New NacionEntity() With {
												 .IdNacion = _idEmpleado.GetValueOrDefault(),
												 .Descripcion = txtNacion.Text
												}

		NacionDAL.delete(nacion)
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub
End Class
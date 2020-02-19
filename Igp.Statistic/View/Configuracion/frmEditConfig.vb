Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades
Partial Public Class frmEditConfig
    Inherits Form

	Private _idConfig As Nullable(Of Integer) = Nothing
	Dim TypeV As String = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(IdConfig As Integer)
		Me.New()
		_idConfig = IdConfig
	End Sub

	Private Sub frmEditConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load


		If _idConfig.HasValue Then



			Dim Config As ConfigEntity = ConfigDAL.ObtenerById(_idConfig.Value)

			'_idConfig = Config.Idv
			txtIdv.Text = Config.Idv
			txtDescripcion.Text = Config.Descripcion
			txtValue.Text = Config.Valor
			TypeV = Config.type
			'txtApellido.Text = empleado.Apellido
			'dtpFechaNacimiento.Value = empleado.FechaNacimiento

			'cbEstadoCivil.SelectedValue = Convert.ToInt32(empleado.Apellido)


		End If

	End Sub

	Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Me.Close()
	End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		Dim Config As New ConfigEntity() With
		{
		.id = _idConfig.GetValueOrDefault,
		.Valor = txtValue.Text,
		.type = TypeV
		}

		ConfigDAL.Save(Config)

		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub
End Class
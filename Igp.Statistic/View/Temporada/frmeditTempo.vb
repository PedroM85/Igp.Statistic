'Imports System.Collections.Generic
'Imports System.ComponentModel
'Imports System.Data
'Imports System.Drawing
'Imports System.Linq
'Imports System.Text
'Imports System.Windows.Forms
'Imports Igp.AccessController

'Partial Public Class frmeditTempo
'    Inherits Form

'	Private _idTempo As Nullable(Of Integer) = Nothing

'	Public Sub New()
'		InitializeComponent()
'	End Sub

'	Public Sub New(idTempo As Integer)
'		Me.New()
'		_idTempo = idTempo
'	End Sub

'	Private Sub frmeditTempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'		txtTempo.Select()

'		Try
'			If _idTempo.HasValue Then

'				Dim change As String
'				Dim Tempo As TempoEntity = TempoDAL.ObtenerById(_idTempo.Value)

'				_idTempo = Tempo.Idtempo
'				txtTempo.Text = Tempo.Descripcion
'				change = Tempo.isactive

'				If change = "Inactivo" Then
'					ckbIsActive.Checked = False
'				Else
'					ckbIsActive.Checked = True
'				End If
'				'ckbIsActive.Checked = Tempo.isactive
'				'txtApellido.Text = empleado.Apellido
'				'dtpFechaNacimiento.Value = empleado.FechaNacimiento

'				'cbEstadoCivil.SelectedValue = Convert.ToInt32(empleado.Apellido)


'			End If
'		Catch ex As Exception
'			MsgBox("Este error debe ir en log")
'			MsgBox("Funcion EditNacion_load: " + ex.ToString)

'		Finally
'			'DesconectarDB()
'			'MessageBox.Show("Hemos tenido problemas con la consulta ", "IgpManager", MessageBoxButtons.OK, MessageBoxIcon.Error)


'		End Try
'	End Sub

'	Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
'		Me.Close()
'	End Sub

'	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

'		If String.IsNullOrEmpty(txtTempo.Text) Then

'			ErrorProvider.SetError(txtTempo, "El campo esta vacio")
'		Else


'			Dim Check As Integer
'			If ckbIsActive.Checked = True Then
'				Check = 1
'			Else
'				Check = 0
'			End If

'			Dim Tempo As New TempoEntity() With
'			{
'		.Idtempo = _idTempo.GetValueOrDefault,
'		.Descripcion = txtTempo.Text,
'		 .isactive = Check
'		}

'			TempoDAL.Save(Tempo)

'			Me.DialogResult = DialogResult.OK
'			Me.Close()
'		End If
'	End Sub
'End Class
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades

Public Partial Class EditarEmpleado
    Inherits Form

    Private _idEmpleado As Nullable(Of Integer) = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(idEmpleado As Integer)
		Me.New()
		_idEmpleado = idEmpleado
	End Sub

    Private Sub EditarEmpleado_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        txtNombre.Select()
        txtNombre.Focus()
        CargarEstadoCivil()
        'CargarEstudio()



        '
        ' se carga la informacion del empleado que se quiere editar
        '
        If _idEmpleado.HasValue Then
            Dim empleado As EmpleadoEntity = EmpleadosDAL.ObtenerById(_idEmpleado.Value)

            _idEmpleado = empleado.IdEmpleado
            txtNombre.Text = empleado.Nombre
            'txtApellido.Text = empleado.Apellido
            'dtpFechaNacimiento.Value = empleado.FechaNacimiento

            cbEstadoCivil.SelectedValue = Convert.ToInt32(empleado.Apellido)



            '
            ' Se obtienen los estudios del empleado
            '

            'AsignarEstudios(empleado)
        End If



    End Sub

    Private Sub CargarEstadoCivil()

        cbEstadoCivil.DisplayMember = "Descripcion"
        cbEstadoCivil.ValueMember = "idNacion"
        cbEstadoCivil.DataSource = NacionDAL.ObtenerTodos()

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrEmpty(txtNombre.Text.Trim) Then
            ErrorProvider.SetError(txtNombre, "El campo esta vacio")

        Else


            '
            ' Se crea la entidad
            '
            Dim empleado As New EmpleadoEntity() With {
                                                   .IdEmpleado = _idEmpleado.GetValueOrDefault(),
                                                   .Nombre = txtNombre.Text,
                                                   .EstadoCivil = Convert.ToInt16(cbEstadoCivil.SelectedValue)
                                                  }



            EmpleadosDAL.Save(empleado)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click

        Dim empleado As New EmpleadoEntity() With {
                                                   .IdEmpleado = _idEmpleado.GetValueOrDefault(),
                                                   .Nombre = txtNombre.Text,
                                                   .EstadoCivil = Convert.ToInt16(cbEstadoCivil.SelectedValue)
                                                  }

        EmpleadosDAL.delete(empleado)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Private Sub EditarEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnGuardar_Click(sender, e)
        End Select
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCircuito
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtCircuito = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(190, 135)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 23)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(277, 135)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(103, 135)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 23)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(84, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Circuito:"
        '
        'txtCircuito
        '
        Me.txtCircuito.Location = New System.Drawing.Point(134, 62)
        Me.txtCircuito.Name = "txtCircuito"
        Me.txtCircuito.Size = New System.Drawing.Size(201, 20)
        Me.txtCircuito.TabIndex = 18
        '
        'frmEditCircuito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 218)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtCircuito)
        Me.Name = "frmEditCircuito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editor de Circuitos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnEliminar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents label2 As Label
    Private WithEvents txtCircuito As TextBox
End Class

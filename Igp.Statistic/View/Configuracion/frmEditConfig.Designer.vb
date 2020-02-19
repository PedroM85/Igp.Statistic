<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditConfig
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
        Me.txtIdv = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIdv
        '
        Me.txtIdv.Location = New System.Drawing.Point(150, 61)
        Me.txtIdv.Name = "txtIdv"
        Me.txtIdv.ReadOnly = True
        Me.txtIdv.Size = New System.Drawing.Size(98, 20)
        Me.txtIdv.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(150, 87)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(346, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(150, 113)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(206, 20)
        Me.txtValue.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(415, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(328, 196)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 23)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(78, 68)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Parametro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Valor:"
        '
        'frmEditConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 255)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdv)
        Me.Name = "frmEditConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEditConfig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdv As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtValue As TextBox
    Private WithEvents btnCancelar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label3 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPiloto_OLD
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.picImagenEmpleado = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePic = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblidP = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNacion = New System.Windows.Forms.ComboBox()
        CType(Me.picImagenEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(273, 108)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(159, 20)
        Me.txtNombre.TabIndex = 0
        '
        'picImagenEmpleado
        '
        Me.picImagenEmpleado.Location = New System.Drawing.Point(465, 69)
        Me.picImagenEmpleado.Name = "picImagenEmpleado"
        Me.picImagenEmpleado.Size = New System.Drawing.Size(63, 45)
        Me.picImagenEmpleado.TabIndex = 2
        Me.picImagenEmpleado.TabStop = False
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.Location = New System.Drawing.Point(462, 120)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePic.TabIndex = 3
        Me.btnBrowsePic.Text = "Button1"
        Me.btnBrowsePic.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(270, 76)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "Label1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(273, 264)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(365, 264)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblidP
        '
        Me.lblidP.AutoSize = True
        Me.lblidP.Location = New System.Drawing.Point(315, 76)
        Me.lblidP.Name = "lblidP"
        Me.lblidP.Size = New System.Drawing.Size(39, 13)
        Me.lblidP.TabIndex = 7
        Me.lblidP.Text = "Label1"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(599, 28)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Editar Piloto"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboNacion)
        Me.GroupBox1.Controls.Add(Me.btnBrowsePic)
        Me.GroupBox1.Controls.Add(Me.picImagenEmpleado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 308)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cboNacion
        '
        Me.cboNacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNacion.FormattingEnabled = True
        Me.cboNacion.Location = New System.Drawing.Point(261, 94)
        Me.cboNacion.Name = "cboNacion"
        Me.cboNacion.Size = New System.Drawing.Size(159, 21)
        Me.cboNacion.TabIndex = 4
        '
        'frmEditPiloto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 360)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblidP)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditPiloto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEditPiloto"
        CType(Me.picImagenEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents picImagenEmpleado As PictureBox
    Friend WithEvents btnBrowsePic As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblID As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblidP As Label
    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboNacion As ComboBox
End Class

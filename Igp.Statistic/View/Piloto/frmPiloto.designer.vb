Partial Class frmPiloto
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiloto))
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleado, Me.NombreCompleto, Me.Equipo})
        Me.dgvEmpleados.Location = New System.Drawing.Point(152, 71)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(347, 391)
        Me.dgvEmpleados.TabIndex = 0
        AddHandler Me.dgvEmpleados.CellContentDoubleClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.dgvEmpleados_CellContentDoubleClick)
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "IdEmpleado"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'NombreCompleto
        '
        Me.NombreCompleto.DataPropertyName = "Nombre"
        Me.NombreCompleto.HeaderText = "Nombre Completo"
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        Me.NombreCompleto.Width = 200
        '
        'Equipo
        '
        Me.Equipo.DataPropertyName = "Apellido"
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.ReadOnly = True
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnNuevoEmpleado.FlatAppearance.BorderSize = 0
        Me.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(645, 71)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(111, 31)
        Me.btnNuevoEmpleado.TabIndex = 2
        Me.btnNuevoEmpleado.Text = "Nuevo"
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = True
        AddHandler Me.btnNuevoEmpleado.Click, New System.EventHandler(AddressOf Me.btnNuevoEmpleado_Click)
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHelp.Location = New System.Drawing.Point(190, 53)
        Me.lblHelp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(270, 15)
        Me.lblHelp.TabIndex = 15
        Me.lblHelp.Text = "Doble Click en una celda para seleccionar piloto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PILOTOS"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(5, 9)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 13
        Me.BtnCerrarForm.TabStop = False
        '
        'frmPiloto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 484)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.btnNuevoEmpleado)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPiloto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Empleados"
        AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmListaEmpleados_Load)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private dgvEmpleados As System.Windows.Forms.DataGridView
    Private btnNuevoEmpleado As System.Windows.Forms.Button
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Equipo As DataGridViewTextBoxColumn
    Public WithEvents lblHelp As Label
    Private WithEvents Label1 As Label
    Friend WithEvents BtnCerrarForm As PictureBox
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPosicion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPosicion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblContarFilas = New System.Windows.Forms.Label()
        Me.dgvPosicion = New System.Windows.Forms.DataGridView()
        Me.Temporada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Circuito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CirNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LleNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puntos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.cboPiloto = New System.Windows.Forms.ComboBox()
        Me.cboCircuito = New System.Windows.Forms.ComboBox()
        Me.cboTempo = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Posiciones"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(2, 9)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 20
        Me.BtnCerrarForm.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblContarFilas)
        Me.GroupBox1.Controls.Add(Me.dgvPosicion)
        Me.GroupBox1.Controls.Add(Me.txtPuesto)
        Me.GroupBox1.Controls.Add(Me.cboPiloto)
        Me.GroupBox1.Controls.Add(Me.cboCircuito)
        Me.GroupBox1.Controls.Add(Me.cboTempo)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 331)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblContarFilas
        '
        Me.lblContarFilas.AutoSize = True
        Me.lblContarFilas.ForeColor = System.Drawing.Color.DarkRed
        Me.lblContarFilas.Location = New System.Drawing.Point(420, 291)
        Me.lblContarFilas.Name = "lblContarFilas"
        Me.lblContarFilas.Size = New System.Drawing.Size(137, 13)
        Me.lblContarFilas.TabIndex = 5
        Me.lblContarFilas.Text = "[ ?? Regitro cargado de ??]"
        '
        'dgvPosicion
        '
        Me.dgvPosicion.AllowUserToAddRows = False
        Me.dgvPosicion.AllowUserToDeleteRows = False
        Me.dgvPosicion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.dgvPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosicion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Temporada, Me.TemNum, Me.Circuito, Me.CirNum, Me.Nombre, Me.NomNum, Me.Puesto, Me.LleNum, Me.Puntos})
        Me.dgvPosicion.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPosicion.Location = New System.Drawing.Point(6, 58)
        Me.dgvPosicion.Name = "dgvPosicion"
        Me.dgvPosicion.ReadOnly = True
        Me.dgvPosicion.Size = New System.Drawing.Size(575, 230)
        Me.dgvPosicion.TabIndex = 4
        '
        'Temporada
        '
        Me.Temporada.HeaderText = "Temporada"
        Me.Temporada.Name = "Temporada"
        Me.Temporada.ReadOnly = True
        '
        'TemNum
        '
        Me.TemNum.HeaderText = "Column1"
        Me.TemNum.Name = "TemNum"
        Me.TemNum.ReadOnly = True
        Me.TemNum.Visible = False
        '
        'Circuito
        '
        Me.Circuito.HeaderText = "Circuito"
        Me.Circuito.Name = "Circuito"
        Me.Circuito.ReadOnly = True
        '
        'CirNum
        '
        Me.CirNum.HeaderText = "Column1"
        Me.CirNum.Name = "CirNum"
        Me.CirNum.ReadOnly = True
        Me.CirNum.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'NomNum
        '
        Me.NomNum.HeaderText = "Column1"
        Me.NomNum.Name = "NomNum"
        Me.NomNum.ReadOnly = True
        Me.NomNum.Visible = False
        '
        'Puesto
        '
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        Me.Puesto.ReadOnly = True
        '
        'LleNum
        '
        Me.LleNum.HeaderText = "Column1"
        Me.LleNum.Name = "LleNum"
        Me.LleNum.ReadOnly = True
        Me.LleNum.Visible = False
        '
        'Puntos
        '
        Me.Puntos.HeaderText = "Puntos"
        Me.Puntos.Name = "Puntos"
        Me.Puntos.ReadOnly = True
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(457, 32)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPuesto.TabIndex = 3
        '
        'cboPiloto
        '
        Me.cboPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiloto.FormattingEnabled = True
        Me.cboPiloto.Location = New System.Drawing.Point(330, 32)
        Me.cboPiloto.Name = "cboPiloto"
        Me.cboPiloto.Size = New System.Drawing.Size(121, 21)
        Me.cboPiloto.TabIndex = 2
        '
        'cboCircuito
        '
        Me.cboCircuito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCircuito.FormattingEnabled = True
        Me.cboCircuito.Location = New System.Drawing.Point(203, 32)
        Me.cboCircuito.Name = "cboCircuito"
        Me.cboCircuito.Size = New System.Drawing.Size(121, 21)
        Me.cboCircuito.TabIndex = 1
        '
        'cboTempo
        '
        Me.cboTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTempo.FormattingEnabled = True
        Me.cboTempo.Location = New System.Drawing.Point(76, 32)
        Me.cboTempo.Name = "cboTempo"
        Me.cboTempo.Size = New System.Drawing.Size(121, 21)
        Me.cboTempo.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(502, 400)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 23)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEliminar})
        Me.cmsMenu.Name = "ContextMenuStrip1"
        Me.cmsMenu.Size = New System.Drawing.Size(118, 26)
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.Size = New System.Drawing.Size(117, 22)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'frmPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 449)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Name = "frmPosicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPosicion"
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPosicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPiloto As ComboBox
    Friend WithEvents cboCircuito As ComboBox
    Friend WithEvents cboTempo As ComboBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents dgvPosicion As DataGridView
    Private WithEvents btnGuardar As Button
    Friend WithEvents Temporada As DataGridViewTextBoxColumn
    Friend WithEvents TemNum As DataGridViewTextBoxColumn
    Friend WithEvents Circuito As DataGridViewTextBoxColumn
    Friend WithEvents CirNum As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents NomNum As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents LleNum As DataGridViewTextBoxColumn
    Friend WithEvents Puntos As DataGridViewTextBoxColumn
    Friend WithEvents cmsMenu As ContextMenuStrip
    Friend WithEvents tsmEliminar As ToolStripMenuItem
    Friend WithEvents lblContarFilas As Label
End Class

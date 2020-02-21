<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPosicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPosicion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPosicion1 = New System.Windows.Forms.DataGridView()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.cboPiloto = New System.Windows.Forms.ComboBox()
        Me.cboCircuito = New System.Windows.Forms.ComboBox()
        Me.cboTempo = New System.Windows.Forms.ComboBox()
        Me.dgvPosicion = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temporada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Circuito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puntos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPosicion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.dgvPosicion)
        Me.GroupBox1.Controls.Add(Me.dgvPosicion1)
        Me.GroupBox1.Controls.Add(Me.txtPuesto)
        Me.GroupBox1.Controls.Add(Me.cboPiloto)
        Me.GroupBox1.Controls.Add(Me.cboCircuito)
        Me.GroupBox1.Controls.Add(Me.cboTempo)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 357)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgvPosicion1
        '
        Me.dgvPosicion1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosicion1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Temporada, Me.Circuito, Me.Nombre, Me.Puesto, Me.Puntos})
        Me.dgvPosicion1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPosicion1.Location = New System.Drawing.Point(85, 174)
        Me.dgvPosicion1.Name = "dgvPosicion1"
        Me.dgvPosicion1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPosicion1.Size = New System.Drawing.Size(652, 230)
        Me.dgvPosicion1.TabIndex = 4
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(387, 31)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPuesto.TabIndex = 3
        '
        'cboPiloto
        '
        Me.cboPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiloto.FormattingEnabled = True
        Me.cboPiloto.Location = New System.Drawing.Point(260, 31)
        Me.cboPiloto.Name = "cboPiloto"
        Me.cboPiloto.Size = New System.Drawing.Size(121, 21)
        Me.cboPiloto.TabIndex = 2
        '
        'cboCircuito
        '
        Me.cboCircuito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCircuito.FormattingEnabled = True
        Me.cboCircuito.Location = New System.Drawing.Point(133, 31)
        Me.cboCircuito.Name = "cboCircuito"
        Me.cboCircuito.Size = New System.Drawing.Size(121, 21)
        Me.cboCircuito.TabIndex = 1
        '
        'cboTempo
        '
        Me.cboTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTempo.FormattingEnabled = True
        Me.cboTempo.Location = New System.Drawing.Point(6, 31)
        Me.cboTempo.Name = "cboTempo"
        Me.cboTempo.Size = New System.Drawing.Size(121, 21)
        Me.cboTempo.TabIndex = 0
        '
        'dgvPosicion
        '
        Me.dgvPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosicion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvPosicion.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPosicion.Location = New System.Drawing.Point(56, 76)
        Me.dgvPosicion.Name = "dgvPosicion"
        Me.dgvPosicion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPosicion.Size = New System.Drawing.Size(652, 81)
        Me.dgvPosicion.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "123"
        Me.Column1.Name = "Column1"
        '
        'Temporada
        '
        Me.Temporada.HeaderText = "Temporada"
        Me.Temporada.Name = "Temporada"
        '
        'Circuito
        '
        Me.Circuito.HeaderText = "Circuito"
        Me.Circuito.Name = "Circuito"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Puesto
        '
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        '
        'Puntos
        '
        Me.Puntos.HeaderText = "Puntos"
        Me.Puntos.Name = "Puntos"
        '
        'frmPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Name = "frmPosicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPosicion"
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPosicion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPosicion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvPosicion1 As DataGridView
    Friend WithEvents dgvPosicion As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Temporada As DataGridViewTextBoxColumn
    Friend WithEvents Circuito As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Puntos As DataGridViewTextBoxColumn
End Class

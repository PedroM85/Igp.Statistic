<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampeonato
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCampeonato))
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temporada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Circuito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Piloto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Llegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puntos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboTemporada = New System.Windows.Forms.ComboBox()
        Me.cboCircuito = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblContarFilas = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Temporada, Me.Circuito, Me.Piloto, Me.Llegada, Me.Puntos})
        Me.dgvData.Location = New System.Drawing.Point(12, 150)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(661, 310)
        Me.dgvData.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "id"
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Temporada
        '
        Me.Temporada.DataPropertyName = "Temporada"
        Me.Temporada.HeaderText = "Temporada"
        Me.Temporada.Name = "Temporada"
        Me.Temporada.ReadOnly = True
        '
        'Circuito
        '
        Me.Circuito.DataPropertyName = "Circuito"
        Me.Circuito.HeaderText = "Circuito"
        Me.Circuito.Name = "Circuito"
        Me.Circuito.ReadOnly = True
        '
        'Piloto
        '
        Me.Piloto.DataPropertyName = "Piloto"
        Me.Piloto.HeaderText = "Piloto"
        Me.Piloto.Name = "Piloto"
        Me.Piloto.ReadOnly = True
        '
        'Llegada
        '
        Me.Llegada.DataPropertyName = "Posllegada"
        Me.Llegada.HeaderText = "Llegada"
        Me.Llegada.Name = "Llegada"
        Me.Llegada.ReadOnly = True
        '
        'Puntos
        '
        Me.Puntos.DataPropertyName = "Puntos"
        Me.Puntos.HeaderText = "Puntos"
        Me.Puntos.Name = "Puntos"
        Me.Puntos.ReadOnly = True
        '
        'cboTemporada
        '
        Me.cboTemporada.FormattingEnabled = True
        Me.cboTemporada.Location = New System.Drawing.Point(102, 50)
        Me.cboTemporada.Name = "cboTemporada"
        Me.cboTemporada.Size = New System.Drawing.Size(149, 21)
        Me.cboTemporada.TabIndex = 1
        '
        'cboCircuito
        '
        Me.cboCircuito.FormattingEnabled = True
        Me.cboCircuito.Location = New System.Drawing.Point(102, 77)
        Me.cboCircuito.Name = "cboCircuito"
        Me.cboCircuito.Size = New System.Drawing.Size(149, 21)
        Me.cboCircuito.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Temporada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Circuito:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Campeonato"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(10, 9)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 22
        Me.BtnCerrarForm.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(170, 104)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 23)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblContarFilas
        '
        Me.lblContarFilas.AutoSize = True
        Me.lblContarFilas.ForeColor = System.Drawing.Color.DarkRed
        Me.lblContarFilas.Location = New System.Drawing.Point(525, 463)
        Me.lblContarFilas.Name = "lblContarFilas"
        Me.lblContarFilas.Size = New System.Drawing.Size(137, 13)
        Me.lblContarFilas.TabIndex = 25
        Me.lblContarFilas.Text = "[ ?? Regitro cargado de ??]"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.lblContarFilas)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCircuito)
        Me.Controls.Add(Me.cboTemporada)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "frmCampeonato"
        Me.Text = "frmCampeonato"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cboTemporada As ComboBox
    Friend WithEvents cboCircuito As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Private WithEvents btnSearch As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Temporada As DataGridViewTextBoxColumn
    Friend WithEvents Circuito As DataGridViewTextBoxColumn
    Friend WithEvents Piloto As DataGridViewTextBoxColumn
    Friend WithEvents Llegada As DataGridViewTextBoxColumn
    Friend WithEvents Puntos As DataGridViewTextBoxColumn
    Friend WithEvents lblContarFilas As Label
    Friend WithEvents ErrorProvider As ErrorProvider
End Class

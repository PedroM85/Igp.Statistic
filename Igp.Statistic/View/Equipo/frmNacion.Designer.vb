<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNacion))
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.dgvNacion = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblContarFilas = New System.Windows.Forms.Label()
        CType(Me.dgvNacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHelp.Location = New System.Drawing.Point(311, 22)
        Me.lblHelp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(240, 15)
        Me.lblHelp.TabIndex = 20
        Me.lblHelp.Text = "Doble Click en una celda para seleccionar "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "EQUIPOS"
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnNuevoEmpleado.FlatAppearance.BorderSize = 0
        Me.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(468, 330)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(111, 31)
        Me.btnNuevoEmpleado.TabIndex = 17
        Me.btnNuevoEmpleado.Text = "Nuevo"
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = True
        '
        'dgvNacion
        '
        Me.dgvNacion.AllowUserToAddRows = False
        Me.dgvNacion.AllowUserToDeleteRows = False
        Me.dgvNacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.dgvNacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nacion})
        Me.dgvNacion.Location = New System.Drawing.Point(314, 40)
        Me.dgvNacion.Name = "dgvNacion"
        Me.dgvNacion.ReadOnly = True
        Me.dgvNacion.Size = New System.Drawing.Size(265, 257)
        Me.dgvNacion.TabIndex = 16
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdNacion"
        Me.Id.HeaderText = "IdEmpleado"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 30
        '
        'Nacion
        '
        Me.Nacion.DataPropertyName = "Descripcion"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Nacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.Nacion.HeaderText = "Nombre"
        Me.Nacion.Name = "Nacion"
        Me.Nacion.ReadOnly = True
        Me.Nacion.Width = 200
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(3, 4)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 18
        Me.BtnCerrarForm.TabStop = False
        '
        'lblContarFilas
        '
        Me.lblContarFilas.AutoSize = True
        Me.lblContarFilas.ForeColor = System.Drawing.Color.DarkRed
        Me.lblContarFilas.Location = New System.Drawing.Point(442, 300)
        Me.lblContarFilas.Name = "lblContarFilas"
        Me.lblContarFilas.Size = New System.Drawing.Size(137, 13)
        Me.lblContarFilas.TabIndex = 26
        Me.lblContarFilas.Text = "[ ?? Regitro cargado de ??]"
        '
        'frmNacion
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 446)
        Me.Controls.Add(Me.lblContarFilas)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.btnNuevoEmpleado)
        Me.Controls.Add(Me.dgvNacion)
        Me.Name = "frmNacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvNacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents lblHelp As Label
    Private WithEvents Label1 As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Private WithEvents btnNuevoEmpleado As Button
    Private WithEvents dgvNacion As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nacion As DataGridViewTextBoxColumn
    Friend WithEvents lblContarFilas As Label
End Class

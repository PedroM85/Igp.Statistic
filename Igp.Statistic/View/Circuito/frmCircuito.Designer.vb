﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCircuito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCircuito))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.dgvCircuitos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CircuitoDataSet1 = New Igp.StatisticData.CircuitoDataSet()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCircuitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircuitoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CIRCUITOS"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(3, 9)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 20
        Me.BtnCerrarForm.TabStop = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHelp.Location = New System.Drawing.Point(180, 29)
        Me.lblHelp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(240, 15)
        Me.lblHelp.TabIndex = 24
        Me.lblHelp.Text = "Doble Click en una celda para seleccionar "
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnNuevoEmpleado.FlatAppearance.BorderSize = 0
        Me.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(537, 47)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(111, 31)
        Me.btnNuevoEmpleado.TabIndex = 23
        Me.btnNuevoEmpleado.Text = "Nuevo"
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = True
        '
        'dgvCircuitos
        '
        Me.dgvCircuitos.AllowUserToAddRows = False
        Me.dgvCircuitos.AllowUserToDeleteRows = False
        Me.dgvCircuitos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCircuitos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCircuitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCircuitos.Location = New System.Drawing.Point(183, 47)
        Me.dgvCircuitos.Name = "dgvCircuitos"
        Me.dgvCircuitos.ReadOnly = True
        Me.dgvCircuitos.Size = New System.Drawing.Size(228, 391)
        Me.dgvCircuitos.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(537, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 31)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CircuitoDataSet1
        '
        Me.CircuitoDataSet1.DataSetName = "DataSet1"
        Me.CircuitoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCircuito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnNuevoEmpleado)
        Me.Controls.Add(Me.dgvCircuitos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Name = "frmCircuito"
        Me.Text = "frmCircuito"
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCircuitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircuitoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Public WithEvents lblHelp As Label
    Private WithEvents btnNuevoEmpleado As Button
    Private WithEvents dgvCircuitos As DataGridView
    Private WithEvents Button1 As Button
    Friend WithEvents CircuitoDataSet1 As StatisticData.CircuitoDataSet
End Class

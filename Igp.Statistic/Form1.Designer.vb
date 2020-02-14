<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnPiloto = New System.Windows.Forms.Button()
        Me.btnDashBoard = New System.Windows.Forms.Button()
        Me.pnlContener = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSConexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2.SuspendLayout()
        Me.pnlContener.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 59)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.BtnPiloto)
        Me.Panel2.Controls.Add(Me.btnDashBoard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 493)
        Me.Panel2.TabIndex = 1
        '
        'BtnPiloto
        '
        Me.BtnPiloto.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPiloto.FlatAppearance.BorderSize = 0
        Me.BtnPiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPiloto.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPiloto.ForeColor = System.Drawing.Color.White
        Me.BtnPiloto.Location = New System.Drawing.Point(0, 40)
        Me.BtnPiloto.Name = "BtnPiloto"
        Me.BtnPiloto.Size = New System.Drawing.Size(130, 40)
        Me.BtnPiloto.TabIndex = 1
        Me.BtnPiloto.Text = "Piloto"
        Me.BtnPiloto.UseVisualStyleBackColor = True
        '
        'btnDashBoard
        '
        Me.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashBoard.FlatAppearance.BorderSize = 0
        Me.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashBoard.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashBoard.ForeColor = System.Drawing.Color.White
        Me.btnDashBoard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashBoard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.Size = New System.Drawing.Size(130, 40)
        Me.btnDashBoard.TabIndex = 0
        Me.btnDashBoard.Text = "Dashboard"
        Me.btnDashBoard.UseVisualStyleBackColor = True
        '
        'pnlContener
        '
        Me.pnlContener.Controls.Add(Me.StatusStrip1)
        Me.pnlContener.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContener.Location = New System.Drawing.Point(130, 59)
        Me.pnlContener.Name = "pnlContener"
        Me.pnlContener.Size = New System.Drawing.Size(722, 493)
        Me.pnlContener.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSConexion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 471)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(722, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSConexion
        '
        Me.TSSConexion.Name = "TSSConexion"
        Me.TSSConexion.Size = New System.Drawing.Size(119, 17)
        Me.TSSConexion.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 552)
        Me.Controls.Add(Me.pnlContener)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.pnlContener.ResumeLayout(False)
        Me.pnlContener.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDashBoard As Button
    Friend WithEvents pnlContener As Panel
    Friend WithEvents BtnPiloto As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSConexion As ToolStripStatusLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnPiloto = New System.Windows.Forms.Button()
        Me.btnNacion = New System.Windows.Forms.Button()
        Me.btnCircuito = New System.Windows.Forms.Button()
        Me.btnCampeonato = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1024, 551)
        Me.PanelContenedor.TabIndex = 1
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.PanelFormularios.Controls.Add(Me.LOGO)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(200, 32)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(824, 519)
        Me.PanelFormularios.TabIndex = 2
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.Transparent
        Me.LOGO.Image = CType(resources.GetObject("LOGO.Image"), System.Drawing.Image)
        Me.LOGO.Location = New System.Drawing.Point(135, 79)
        Me.LOGO.Margin = New System.Windows.Forms.Padding(2)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(550, 314)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 0
        Me.LOGO.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Black
        Me.PanelMenu.Controls.Add(Me.btnConfiguracion)
        Me.PanelMenu.Controls.Add(Me.btnPiloto)
        Me.PanelMenu.Controls.Add(Me.btnNacion)
        Me.PanelMenu.Controls.Add(Me.btnCircuito)
        Me.PanelMenu.Controls.Add(Me.btnCampeonato)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 32)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 519)
        Me.PanelMenu.TabIndex = 1
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfiguracion.Location = New System.Drawing.Point(0, 320)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(200, 45)
        Me.btnConfiguracion.TabIndex = 9
        Me.btnConfiguracion.Text = "Configuracion"
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnPiloto
        '
        Me.btnPiloto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPiloto.FlatAppearance.BorderSize = 0
        Me.btnPiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPiloto.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPiloto.Location = New System.Drawing.Point(0, 275)
        Me.btnPiloto.Name = "btnPiloto"
        Me.btnPiloto.Size = New System.Drawing.Size(200, 45)
        Me.btnPiloto.TabIndex = 8
        Me.btnPiloto.Text = "Pilotos"
        Me.btnPiloto.UseVisualStyleBackColor = True
        '
        'btnNacion
        '
        Me.btnNacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNacion.FlatAppearance.BorderSize = 0
        Me.btnNacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNacion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNacion.Location = New System.Drawing.Point(0, 230)
        Me.btnNacion.Name = "btnNacion"
        Me.btnNacion.Size = New System.Drawing.Size(200, 45)
        Me.btnNacion.TabIndex = 7
        Me.btnNacion.Text = "Naciones"
        Me.btnNacion.UseVisualStyleBackColor = True
        '
        'btnCircuito
        '
        Me.btnCircuito.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCircuito.FlatAppearance.BorderSize = 0
        Me.btnCircuito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCircuito.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCircuito.Location = New System.Drawing.Point(0, 185)
        Me.btnCircuito.Name = "btnCircuito"
        Me.btnCircuito.Size = New System.Drawing.Size(200, 45)
        Me.btnCircuito.TabIndex = 6
        Me.btnCircuito.Text = "Circuitos"
        Me.btnCircuito.UseVisualStyleBackColor = True
        '
        'btnCampeonato
        '
        Me.btnCampeonato.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCampeonato.FlatAppearance.BorderSize = 0
        Me.btnCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCampeonato.ForeColor = System.Drawing.Color.White
        Me.btnCampeonato.Location = New System.Drawing.Point(0, 140)
        Me.btnCampeonato.Name = "btnCampeonato"
        Me.btnCampeonato.Size = New System.Drawing.Size(200, 45)
        Me.btnCampeonato.TabIndex = 5
        Me.btnCampeonato.Text = "Campeonato"
        Me.btnCampeonato.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.Igp.Statistic.My.Resources.Resources.Button3_Image
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 95)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 45)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 95)
        Me.Panel1.TabIndex = 3
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1024, 32)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(977, 10)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(949, 10)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(977, 10)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1003, 10)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 551)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "None"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents btnPiloto As Button
    Friend WithEvents btnNacion As Button
    Friend WithEvents btnCircuito As Button
    Friend WithEvents btnCampeonato As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainLogon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainLogon))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblDefault = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstConnections = New System.Windows.Forms.ListBox()
        Me.cmLogonPad = New System.Windows.Forms.ContextMenu()
        Me.mnuOpen = New System.Windows.Forms.MenuItem()
        Me.mnuClose = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoginEcom = New System.Windows.Forms.Button()
        Me.btnLoginPOS = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(488, 186)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 24)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "&Eliminar"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(488, 154)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 24)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "E&ditar..."
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(488, 122)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(72, 24)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "&Nuevo..."
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Enabled = False
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(6, 0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(118, 24)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "e-wave Manager"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblDefault
        '
        Me.lblDefault.AutoSize = True
        Me.lblDefault.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblDefault.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblDefault.Location = New System.Drawing.Point(343, 274)
        Me.lblDefault.Name = "lblDefault"
        Me.lblDefault.Size = New System.Drawing.Size(56, 13)
        Me.lblDefault.TabIndex = 17
        Me.lblDefault.Text = "XXXXXXX"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(231, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Predeterminada:"
        '
        'lstConnections
        '
        Me.lstConnections.BackColor = System.Drawing.Color.White
        Me.lstConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstConnections.ForeColor = System.Drawing.Color.Black
        Me.lstConnections.Location = New System.Drawing.Point(231, 122)
        Me.lstConnections.Name = "lstConnections"
        Me.lstConnections.Size = New System.Drawing.Size(250, 145)
        Me.lstConnections.TabIndex = 11
        '
        'cmLogonPad
        '
        Me.cmLogonPad.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.mnuClose})
        '
        'mnuOpen
        '
        Me.mnuOpen.DefaultItem = True
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Abrir"
        '
        'mnuClose
        '
        Me.mnuClose.Index = 1
        Me.mnuClose.Text = "&Cerrar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLoginEcom)
        Me.Panel1.Controls.Add(Me.btnLoginPOS)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Location = New System.Drawing.Point(227, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 30)
        Me.Panel1.TabIndex = 18
        '
        'btnLoginEcom
        '
        Me.btnLoginEcom.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginEcom.Enabled = False
        Me.btnLoginEcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginEcom.ForeColor = System.Drawing.Color.Black
        Me.btnLoginEcom.Image = CType(resources.GetObject("btnLoginEcom.Image"), System.Drawing.Image)
        Me.btnLoginEcom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginEcom.Location = New System.Drawing.Point(240, 0)
        Me.btnLoginEcom.Name = "btnLoginEcom"
        Me.btnLoginEcom.Size = New System.Drawing.Size(94, 24)
        Me.btnLoginEcom.TabIndex = 6
        Me.btnLoginEcom.Text = "      e-com POS"
        Me.btnLoginEcom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginEcom.UseVisualStyleBackColor = False
        '
        'btnLoginPOS
        '
        Me.btnLoginPOS.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginPOS.Enabled = False
        Me.btnLoginPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginPOS.ForeColor = System.Drawing.Color.Black
        Me.btnLoginPOS.Image = CType(resources.GetObject("btnLoginPOS.Image"), System.Drawing.Image)
        Me.btnLoginPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginPOS.Location = New System.Drawing.Point(138, 0)
        Me.btnLoginPOS.Name = "btnLoginPOS"
        Me.btnLoginPOS.Size = New System.Drawing.Size(94, 24)
        Me.btnLoginPOS.TabIndex = 5
        Me.btnLoginPOS.Text = "      e-boc POS"
        Me.btnLoginPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginPOS.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(488, 242)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Cerrar"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmMainLogon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblDefault)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstConnections)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmMainLogon"
        Me.Text = "frmMainLogon"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblDefault As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstConnections As ListBox
    Friend WithEvents cmLogonPad As ContextMenu
    Friend WithEvents mnuOpen As MenuItem
    Friend WithEvents mnuClose As MenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLoginEcom As Button
    Friend WithEvents btnLoginPOS As Button
    Friend WithEvents btnClose As Button
End Class

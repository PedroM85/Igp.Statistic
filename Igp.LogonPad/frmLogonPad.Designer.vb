<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogonPad
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
        Me.lblError = New System.Windows.Forms.Label()
        Me.chkDefault = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.IndianRed
        Me.lblError.Location = New System.Drawing.Point(12, 182)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 26
        '
        'chkDefault
        '
        Me.chkDefault.BackColor = System.Drawing.Color.Transparent
        Me.chkDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDefault.Location = New System.Drawing.Point(204, 42)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(168, 16)
        Me.chkDefault.TabIndex = 25
        Me.chkDefault.Text = "Predeterminada"
        Me.chkDefault.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(220, 202)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 24)
        Me.btnOk.TabIndex = 21
        Me.btnOk.Text = "&Aceptar"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(300, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "&Cancelar"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.Color.White
        Me.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatabase.ForeColor = System.Drawing.Color.Black
        Me.txtDatabase.Location = New System.Drawing.Point(204, 98)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(168, 20)
        Me.txtDatabase.TabIndex = 16
        '
        'lblDatabase
        '
        Me.lblDatabase.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabase.Location = New System.Drawing.Point(204, 74)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(88, 16)
        Me.lblDatabase.TabIndex = 24
        Me.lblDatabase.Text = "Base de datos:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(204, 154)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(168, 20)
        Me.txtPassword.TabIndex = 19
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Location = New System.Drawing.Point(204, 130)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(88, 16)
        Me.lblPassword.TabIndex = 23
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.Location = New System.Drawing.Point(12, 154)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(168, 20)
        Me.txtUser.TabIndex = 18
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Location = New System.Drawing.Point(12, 130)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 16)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "Usuario:"
        '
        'txtServer
        '
        Me.txtServer.BackColor = System.Drawing.Color.White
        Me.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServer.ForeColor = System.Drawing.Color.Black
        Me.txtServer.Location = New System.Drawing.Point(12, 98)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(168, 20)
        Me.txtServer.TabIndex = 15
        '
        'lblServer
        '
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.lblServer.Location = New System.Drawing.Point(12, 74)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(88, 16)
        Me.lblServer.TabIndex = 17
        Me.lblServer.Text = "Servidor:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(12, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 20)
        Me.txtName.TabIndex = 13
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(12, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 16)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Nombre:"
        '
        'frmLogonPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(381, 241)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmLogonPad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLogonPad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents chkDefault As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents lblServer As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
End Class

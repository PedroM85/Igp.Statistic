Public Class PasswordChange
    Inherits Igp.Statistic.BaseDialog

    Private sUserId As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'SetColorSchema()

        LoadGlobalCaptions()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents pnlNewPassword As System.Windows.Forms.Panel
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentPassword As System.Windows.Forms.Label
    Friend WithEvents lblCaptionKeys As System.Windows.Forms.Label
    Friend WithEvents lblESC As System.Windows.Forms.Label
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblConfirmPassword = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox
        Me.lblCurrentPassword = New System.Windows.Forms.Label
        Me.pnlNewPassword = New System.Windows.Forms.Panel
        Me.lblCaptionKeys = New System.Windows.Forms.Label
        Me.lblESC = New System.Windows.Forms.Label
        Me.lblEnter = New System.Windows.Forms.Label
        Me.pnlNewPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRightTop
        '
        Me.pnlRightTop.Location = New System.Drawing.Point(271, 0)
        Me.pnlRightTop.Name = "pnlRightTop"
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.Name = "pnlLeftTop"
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Name = "pnlMiddleTop"
        Me.pnlMiddleTop.Size = New System.Drawing.Size(164, 55)
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Location = New System.Drawing.Point(271, 47)
        Me.pnlRightMiddle.Name = "pnlRightMiddle"
        Me.pnlRightMiddle.Size = New System.Drawing.Size(105, 81)
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Name = "pnlLeftMiddle"
        Me.pnlLeftMiddle.Size = New System.Drawing.Size(107, 89)
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Location = New System.Drawing.Point(107, 146)
        Me.pnlMiddleBottom.Name = "pnlMiddleBottom"
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(164, 54)
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Location = New System.Drawing.Point(271, 125)
        Me.pnlRightBottom.Name = "pnlRightBottom"
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 150)
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AutoSize = False
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Location = New System.Drawing.Point(144, 24)
        Me.txtConfirmPassword.MaxLength = 20
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(135, 22)
        Me.txtConfirmPassword.TabIndex = 1
        Me.txtConfirmPassword.Text = ""
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = False
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(144, 0)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(135, 21)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Text = ""
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.Location = New System.Drawing.Point(0, 24)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(144, 22)
        Me.lblConfirmPassword.TabIndex = 32
        Me.lblConfirmPassword.Text = "Confirmar contraseña:"
        Me.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(24, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(120, 21)
        Me.lblPassword.TabIndex = 31
        Me.lblPassword.Text = "Nueva contraseña:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.AutoSize = False
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        Me.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentPassword.Location = New System.Drawing.Point(160, 56)
        Me.txtCurrentPassword.MaxLength = 20
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(135, 21)
        Me.txtCurrentPassword.TabIndex = 1
        Me.txtCurrentPassword.Text = ""
        Me.txtCurrentPassword.Visible = False
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPassword.Location = New System.Drawing.Point(40, 56)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(120, 21)
        Me.lblCurrentPassword.TabIndex = 34
        Me.lblCurrentPassword.Text = "Contraseña:"
        Me.lblCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrentPassword.Visible = False
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.pnlNewPassword.Controls.Add(Me.txtConfirmPassword)
        Me.pnlNewPassword.Controls.Add(Me.lblPassword)
        Me.pnlNewPassword.Controls.Add(Me.lblConfirmPassword)
        Me.pnlNewPassword.Controls.Add(Me.txtPassword)
        Me.pnlNewPassword.Location = New System.Drawing.Point(16, 88)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(280, 48)
        Me.pnlNewPassword.TabIndex = 2
        '
        'lblCaptionKeys
        '
        Me.lblCaptionKeys.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaptionKeys.BackColor = System.Drawing.Color.FromArgb(CType(104, Byte), CType(104, Byte), CType(104, Byte))
        Me.lblCaptionKeys.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionKeys.Location = New System.Drawing.Point(16, 24)
        Me.lblCaptionKeys.Name = "lblCaptionKeys"
        Me.lblCaptionKeys.Size = New System.Drawing.Size(344, 24)
        Me.lblCaptionKeys.TabIndex = 48
        Me.lblCaptionKeys.Text = "Contraseña"
        Me.lblCaptionKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblESC
        '
        Me.lblESC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblESC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESC.Location = New System.Drawing.Point(40, 168)
        Me.lblESC.Name = "lblESC"
        Me.lblESC.Size = New System.Drawing.Size(296, 16)
        Me.lblESC.TabIndex = 56
        Me.lblESC.Text = "ESC - Sale"
        Me.lblESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnter
        '
        Me.lblEnter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(40, 144)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(296, 16)
        Me.lblEnter.TabIndex = 55
        Me.lblEnter.Text = "ENTER - Confirma"
        Me.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordChange
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(49, Byte), CType(49, Byte), CType(47, Byte))
        Me.ClientSize = New System.Drawing.Size(376, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlNewPassword)
        Me.Controls.Add(Me.lblESC)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblCaptionKeys)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.lblCurrentPassword)
        Me.KeyPreview = True
        Me.Name = "PasswordChange"
        Me.ShowInTaskbar = False
        Me.Text = "Cambio de contraseña"
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.lblCurrentPassword, 0)
        Me.Controls.SetChildIndex(Me.txtCurrentPassword, 0)
        Me.Controls.SetChildIndex(Me.lblCaptionKeys, 0)
        Me.Controls.SetChildIndex(Me.lblEnter, 0)
        Me.Controls.SetChildIndex(Me.lblESC, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlNewPassword, 0)
        Me.pnlNewPassword.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variables "

    Dim mRejectSamePassword As Boolean = False

#End Region

#Region " Constructors "

    Public Sub New(ByVal RejectSamePassword As Boolean, Optional ByVal UserChangePassword As Boolean = False)
        Me.New()
        If RejectSamePassword = True Then
            Me.RejectSamePassword = True
        End If

        If UserChangePassword = True Then
            pnlNewPassword.Enabled = False
            lblCurrentPassword.Visible = True
            txtCurrentPassword.Visible = True
            txtCurrentPassword.Focus()
        End If

    End Sub

#End Region

#Region " Aesthetic methods "

    'Private Sub SetColorSchema()
    '    With oApp.ColorSchema
    '        Me.BackColor = .Background
    '        Me.ForeColor = .Foreground

    '        lblCaptionKeys.BackColor = .HeaderBackground
    '        lblCaptionKeys.ForeColor = .HeaderForeground
    '        txtCurrentPassword.BackColor = .Background
    '        txtPassword.BackColor = .Background
    '        txtConfirmPassword.BackColor = .Background

    '        lblCurrentPassword.BackColor = .Background
    '        lblCurrentPassword.ForeColor = .Foreground
    '        lblPassword.BackColor = .Background
    '        lblPassword.ForeColor = .Foreground
    '        lblConfirmPassword.BackColor = .Background
    '        lblConfirmPassword.ForeColor = .Foreground

    '    End With
    'End Sub

#End Region

#Region " Event Handler "

    Private Sub txtConfirmPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Return Then
            CheckAndSave()
        End If
    End Sub

    Private Sub PasswordChange_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtCurrentPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurrentPassword.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            If oApp.User.EncryptPassword(txtCurrentPassword.Text) = oApp.User.Password Then
                lblCurrentPassword.Enabled = False
                txtCurrentPassword.Enabled = False
                pnlNewPassword.Enabled = True
                txtPassword.Focus()
            Else
                POSMessageBox.Show(IgpManager.BACK.EnvironmentObjects.Msg_Incorrect_Pass, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            e.Handled = True
        ElseIf e.KeyChar = ControlChars.NullChar Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtCurrentPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentPassword.GotFocus
        txtCurrentPassword.BackColor = oApp.ColorSchema.FocusCellBackground
    End Sub

    Private Sub txtCurrentPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentPassword.LostFocus
        txtCurrentPassword.BackColor = oApp.ColorSchema.Background
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.BackColor = oApp.ColorSchema.FocusCellBackground
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        txtPassword.BackColor = oApp.ColorSchema.Background
    End Sub

    Private Sub txtConfirmPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.GotFocus
        txtConfirmPassword.BackColor = oApp.ColorSchema.FocusCellBackground
    End Sub

    Private Sub txtConfirmPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.LostFocus
        txtConfirmPassword.BackColor = oApp.ColorSchema.Background
    End Sub

    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    '    Me.Dispose()
    'End Sub

#End Region

#Region " Methods "

    Private Sub PasswordChange_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.Focus()
    End Sub

    Private Sub CheckAndSave()

        Dim oSecMgr As New Igp.AccessController.SecurityManager(oApp.OleDBConnection)

        If txtPassword.Text <> txtConfirmPassword.Text Then
            POSMessageBox.Show(Me, Msg_Pass_Not_Match, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Me.RejectSamePassword Then
                ' Verifica que el nuevo password sea diferente al anterior

                If oApp.User.EncryptPassword(txtPassword.Text) = oApp.User.Password Then
                    POSMessageBox.Show(Msg_Pass_Must_Dif, , MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            Else

            End If

            If txtPassword.Text = String.Empty Then
                POSMessageBox.Show(Msg_Error2, , MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Select()
                Exit Sub
            End If

            If txtPassword.Text.Length < Convert.ToSingle(oApp.Parameters("PWDCHARMIN")) Then
                POSMessageBox.Show(Msg_Error3 & Space(1) & Convert.ToSingle(oApp.Parameters("PWDCHARMIN")).ToString & Space(1) & Msg_Error4, , MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Select()
                Exit Sub
            End If

            If oApp.Parameters("PWDCOMPLEX") = "complex" Then
                If Not oSecMgr.IsComplexPassword(txtPassword.Text) Then
                    POSMessageBox.Show(Msg_Error5, , MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Select()
                    Exit Sub
                End If
            End If

            If oSecMgr.IsRepeatPassword(sUserId, oSecMgr.EncryptData(sUserId & txtPassword.Text)) Then
                POSMessageBox.Show(Msg_Error6, , MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Select()
                Exit Sub
            End If

        Try
            oSecMgr.ChangePassword(oApp.User.Id, txtPassword.Text)
                oApp.AuditLogWriter.AddEntry(Igp.AccessController.AuditLogWriter.EventType.PasswordChange, oApp.User.Id, oApp.TerminalId, sUserId)
                oApp.User.Password = txtPassword.Text ' Actualiza el password

            POSMessageBox.Show(Me, Msg_Success, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Close()
        Catch oEx As Exception
            POSMessageBox.Show(Me, Msg_Error, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End If

    End Sub

#End Region

#Region " Properties "

    Public WriteOnly Property UserId() As String
        Set(ByVal Value As String)
            sUserId = Value
        End Set
    End Property

    Private Property RejectSamePassword() As Boolean
        Get
            Return mRejectSamePassword
        End Get
        Set(ByVal Value As Boolean)
            mRejectSamePassword = Value
        End Set
    End Property

#End Region

#Region " GlobalResourcesLoader "

    Dim Msg_Pass_Not_Match As String
    Dim Msg_Pass_Must_Dif As String
    Dim Msg_Success As String
    Dim Msg_Error As String
    Dim Msg_Error2 As String
    Dim Msg_Error3 As String
    Dim Msg_Error4 As String
    Dim Msg_Error5 As String
    Dim Msg_Error6 As String

    Private Sub LoadGlobalCaptions()

        Msg_Pass_Not_Match = oApp.GlobalResources.GetString("Msg_Pass_Not_Match", "La contraseña ingresada no coincide.")
        Msg_Pass_Must_Dif = oApp.GlobalResources.GetString("Msg_Pass_Must_Dif", "La nueva contraseña debe ser distinta a la actual.")
        Msg_Success = oApp.GlobalResources.GetString("Msg_Success", "La contraseña fue cambiada con éxito.")
        Msg_Error = oApp.GlobalResources.GetString("Msg_Error", "Error al cambiar la contraseña.")
        Msg_Error2 = oApp.GlobalResources.GetString("Msg_Error2", "El campo no puede estar en blanco. Debe indicar un valor.")
        Msg_Error3 = oApp.GlobalResources.GetString("Msg_Error3", "La contraseña debe contener al menos")
        Msg_Error4 = oApp.GlobalResources.GetString("Msg_Error4", "caracteres")
        Msg_Error5 = oApp.GlobalResources.GetString("Msg_Error5", "La contraseña debe contener letras y números.")
        Msg_Error6 = oApp.GlobalResources.GetString("Msg_Error6", "La contraseña ingresada ya fue utilizada anteriormente.")

        Me.lblConfirmPassword.Text = oApp.GlobalResources.GetString("lblConfirmPassword.Text", Me.lblConfirmPassword.Text)
        Me.lblPassword.Text = oApp.GlobalResources.GetString("lblPassword.Text", Me.lblPassword.Text)
        Me.lblCurrentPassword.Text = oApp.GlobalResources.GetString("lblCurrentPassword.Text", Me.lblCurrentPassword.Text)
        Me.lblCaptionKeys.Text = oApp.GlobalResources.GetString("lblCaptionKeys.Text", Me.lblCaptionKeys.Text)
        Me.lblESC.Text = oApp.GlobalResources.GetString("lblESC.Text", Me.lblESC.Text)
        Me.lblEnter.Text = oApp.GlobalResources.GetString("lblEnter.Text", Me.lblEnter.Text)
        Me.Text = oApp.GlobalResources.GetString("Text", Me.Text)

    End Sub

#End Region

End Class

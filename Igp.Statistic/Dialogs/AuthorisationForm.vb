Option Strict On

Public Class AuthorisationForm
    Inherits Igp.Statistic.BaseDialog

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        SetColorSchema()
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
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblCaptionKeys As System.Windows.Forms.Label
    Friend WithEvents lblESC As System.Windows.Forms.Label
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblCaptionKeys = New System.Windows.Forms.Label
        Me.lblESC = New System.Windows.Forms.Label
        Me.lblEnter = New System.Windows.Forms.Label
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
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Location = New System.Drawing.Point(107, 130)
        Me.pnlMiddleBottom.Name = "pnlMiddleBottom"
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(164, 54)
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Location = New System.Drawing.Point(271, 47)
        Me.pnlRightMiddle.Name = "pnlRightMiddle"
        Me.pnlRightMiddle.Size = New System.Drawing.Size(105, 65)
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 134)
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Location = New System.Drawing.Point(271, 109)
        Me.pnlRightBottom.Name = "pnlRightBottom"
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Name = "pnlMiddleTop"
        Me.pnlMiddleTop.Size = New System.Drawing.Size(164, 55)
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Name = "pnlLeftMiddle"
        Me.pnlLeftMiddle.Size = New System.Drawing.Size(107, 73)
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = False
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(144, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(144, 21)
        Me.txtPassword.TabIndex = 14
        Me.txtPassword.Text = ""
        '
        'txtUser
        '
        Me.txtUser.AutoSize = False
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(144, 56)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(144, 21)
        Me.txtUser.TabIndex = 13
        Me.txtUser.Text = ""
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Location = New System.Drawing.Point(48, 88)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(88, 21)
        Me.lblPassword.TabIndex = 16
        Me.lblPassword.Text = "Contraseña:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Location = New System.Drawing.Point(48, 56)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 21)
        Me.lblUser.TabIndex = 15
        Me.lblUser.Text = "Usuario:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.lblCaptionKeys.TabIndex = 47
        Me.lblCaptionKeys.Text = " Autorización"
        Me.lblCaptionKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblESC
        '
        Me.lblESC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblESC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESC.Location = New System.Drawing.Point(40, 144)
        Me.lblESC.Name = "lblESC"
        Me.lblESC.Size = New System.Drawing.Size(296, 16)
        Me.lblESC.TabIndex = 54
        Me.lblESC.Text = "ESC -"
        Me.lblESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnter
        '
        Me.lblEnter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(40, 120)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(296, 16)
        Me.lblEnter.TabIndex = 53
        Me.lblEnter.Text = "ENTER -"
        Me.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AuthorisationForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(376, 184)
        Me.Controls.Add(Me.lblESC)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblCaptionKeys)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "AuthorisationForm"
        Me.ShowInTaskbar = False
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.lblUser, 0)
        Me.Controls.SetChildIndex(Me.lblPassword, 0)
        Me.Controls.SetChildIndex(Me.txtUser, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.lblCaptionKeys, 0)
        Me.Controls.SetChildIndex(Me.lblEnter, 0)
        Me.Controls.SetChildIndex(Me.lblESC, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Aesthetic methods "

    Private Sub SetColorSchema()
        With oApp.ColorSchema
            Me.BackColor = .Background
            Me.ForeColor = .Foreground

            lblCaptionKeys.BackColor = .HeaderBackground
            lblCaptionKeys.ForeColor = .HeaderForeground
            txtUser.BackColor = .HighlightBackgroundOff
            txtUser.ForeColor = .Foreground
            txtPassword.BackColor = .HighlightBackgroundOff
            txtPassword.ForeColor = .Foreground
        End With
    End Sub

#End Region

#Region " Event handlers "

    Private Sub txtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtPassword.Select()
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Close()
            DialogResult = DialogResult.OK
        ElseIf e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Up Then
            txtUser.Select()
        End If
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        txtPassword.BackColor = oApp.ColorSchema.HighlightBackground
        lblEnter.Text = "ENTER - " + Msg_Accept
        lblESC.Text = "ESC - " + Msg_EnterUser
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        txtPassword.BackColor = oApp.ColorSchema.HighlightBackgroundOff
    End Sub

    Private Sub txtUser_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Enter
        txtUser.BackColor = oApp.ColorSchema.HighlightBackground
        lblEnter.Text = "ENTER - " + Msg_EnterPass
        lblESC.Text = "ESC - " + Msg_Cancel
    End Sub

    Private Sub txtUser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Leave
        txtUser.BackColor = oApp.ColorSchema.HighlightBackgroundOff
    End Sub

#End Region

#Region " GlobalResourcesLoader "
    Dim Msg_Accept As String
    Dim Msg_EnterUser As String
    Dim Msg_EnterPass As String
    Dim Msg_Cancel As String

    Private Sub LoadGlobalCaptions()
        Msg_Accept = oApp.GlobalResources.GetString("Msg_Accept", "Acepta la autorización")
        Msg_EnterUser = oApp.GlobalResources.GetString("Msg_EnterUser", "Ingresar usuario")
        Msg_EnterPass = oApp.GlobalResources.GetString("Msg_EnterPass", "Ingresar password")
        Msg_Cancel = oApp.GlobalResources.GetString("Msg_Cancel", "Cancela la autorización")

        Me.lblPassword.Text = oApp.GlobalResources.GetString("lblPassword.Text", Me.lblPassword.Text)
        Me.lblUser.Text = oApp.GlobalResources.GetString("lblUser.Text", Me.lblUser.Text)
        Me.lblCaptionKeys.Text = oApp.GlobalResources.GetString("lblCaptionKeys.Text", Me.lblCaptionKeys.Text)

    End Sub

#End Region

End Class

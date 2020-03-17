Public Class POSMessageBox
    Inherits Igp.Statistic.BaseDialog

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'SetColorSchema()
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
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents picQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents picInformation As System.Windows.Forms.PictureBox
    Friend WithEvents picExclamation As System.Windows.Forms.PictureBox
    Friend WithEvents picError As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblInfo = New System.Windows.Forms.Label
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.picQuestion = New System.Windows.Forms.PictureBox
        Me.picInformation = New System.Windows.Forms.PictureBox
        Me.picExclamation = New System.Windows.Forms.PictureBox
        Me.picError = New System.Windows.Forms.PictureBox
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExclamation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.ForeColor = System.Drawing.Color.White
        '
        'pnlRightTop
        '
        Me.pnlRightTop.ForeColor = System.Drawing.Color.White
        Me.pnlRightTop.Location = New System.Drawing.Point(359, 0)
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.ForeColor = System.Drawing.Color.White
        Me.pnlMiddleTop.Size = New System.Drawing.Size(252, 55)
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.ForeColor = System.Drawing.Color.White
        Me.pnlMiddleBottom.Location = New System.Drawing.Point(107, 107)
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(252, 54)
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.ForeColor = System.Drawing.Color.White
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 111)
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.ForeColor = System.Drawing.Color.White
        Me.pnlRightBottom.Location = New System.Drawing.Point(359, 86)
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.ForeColor = System.Drawing.Color.White
        Me.pnlLeftMiddle.Size = New System.Drawing.Size(107, 50)
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.ForeColor = System.Drawing.Color.White
        Me.pnlRightMiddle.Location = New System.Drawing.Point(359, 47)
        Me.pnlRightMiddle.Size = New System.Drawing.Size(105, 42)
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Location = New System.Drawing.Point(88, 30)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(304, 66)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "???"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Location = New System.Drawing.Point(152, 110)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(80, 22)
        Me.btn1.TabIndex = 9
        Me.btn1.Text = "1???"
        Me.btn1.UseVisualStyleBackColor = False
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Location = New System.Drawing.Point(248, 110)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(80, 22)
        Me.btn2.TabIndex = 10
        Me.btn2.Text = "2???"
        Me.btn2.UseVisualStyleBackColor = False
        Me.btn2.Visible = False
        '
        'picQuestion
        '
        Me.picQuestion.BackColor = System.Drawing.Color.Transparent
        Me.picQuestion.Location = New System.Drawing.Point(32, 48)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(32, 32)
        Me.picQuestion.TabIndex = 11
        Me.picQuestion.TabStop = False
        Me.picQuestion.Visible = False
        '
        'picInformation
        '
        Me.picInformation.BackColor = System.Drawing.Color.Transparent
        Me.picInformation.Location = New System.Drawing.Point(32, 48)
        Me.picInformation.Name = "picInformation"
        Me.picInformation.Size = New System.Drawing.Size(32, 32)
        Me.picInformation.TabIndex = 12
        Me.picInformation.TabStop = False
        Me.picInformation.Visible = False
        '
        'picExclamation
        '
        Me.picExclamation.BackColor = System.Drawing.Color.Transparent
        Me.picExclamation.Location = New System.Drawing.Point(32, 48)
        Me.picExclamation.Name = "picExclamation"
        Me.picExclamation.Size = New System.Drawing.Size(32, 32)
        Me.picExclamation.TabIndex = 13
        Me.picExclamation.TabStop = False
        Me.picExclamation.Visible = False
        '
        'picError
        '
        Me.picError.BackColor = System.Drawing.Color.Transparent
        Me.picError.Location = New System.Drawing.Point(32, 48)
        Me.picError.Name = "picError"
        Me.picError.Size = New System.Drawing.Size(32, 32)
        Me.picError.TabIndex = 14
        Me.picError.TabStop = False
        Me.picError.Visible = False
        '
        'POSMessageBox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(464, 161)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.picInformation)
        Me.Controls.Add(Me.picExclamation)
        Me.Controls.Add(Me.picError)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "POSMessageBox"
        Me.ShowInTaskbar = False
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.lblInfo, 0)
        Me.Controls.SetChildIndex(Me.btn1, 0)
        Me.Controls.SetChildIndex(Me.btn2, 0)
        Me.Controls.SetChildIndex(Me.picError, 0)
        Me.Controls.SetChildIndex(Me.picExclamation, 0)
        Me.Controls.SetChildIndex(Me.picInformation, 0)
        Me.Controls.SetChildIndex(Me.picQuestion, 0)
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExclamation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Enumerations "

    Public Enum Position
        Top
        Center
        Bottom
    End Enum

#End Region

#Region " Aesthetic methods "

    'Private Sub SetColorSchema()
    '    If Not oApp Is Nothing _
    '        AndAlso Not oApp.ColorSchema Is Nothing Then
    '        With oApp.ColorSchema
    '            Me.ForeColor = .Foreground

    '            picError.Image = .GetImage("IconError")
    '            picExclamation.Image = .GetImage("IconExclam")
    '            picInformation.Image = .GetImage("IconInfo")
    '            picQuestion.Image = .GetImage("IconQuestion")
    '        End With
    '    End If
    'End Sub

#End Region

#Region " Methods "

    Public Overloads Shared Function Show(ByVal owner As IWin32Window, _
                                          ByVal text As String, _
                                          Optional ByVal caption As String = "", _
                                          Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
                                          Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.None, _
                                          Optional ByVal defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1, _
                                          Optional ByVal position As Position = Position.Center) As DialogResult
        Dim oForm As New POSMessageBox
        Dim oResult As DialogResult

        oForm.lblInfo.Text = text

        'Dim TR As ewave.GlobalResourcesEngine.ResourceLoader
        'If oApp.TranslatedResources Is Nothing Then
        '    TR = New ewave.GlobalResourcesEngine.ResourceLoader("", "")
        'Else
        '    TR = oApp.TranslatedResources
        'End If

        Select Case buttons
            Case MessageBoxButtons.OK
                ' Boton de Aceptar
                oForm.btn1.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_OK 'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_OK", "OK")
                oForm.btn1.DialogResult = System.Windows.Forms.DialogResult.OK
                oForm.btn1.Location = New Point(200, 110)
                oForm.btn1.Visible = True
                'oForm.AcceptButton = oForm.btn1
                'oForm.CancelButton = oForm.btn2
                oForm.btn2.Visible = False
            Case MessageBoxButtons.OKCancel
                ' Boton de Aceptar
                oForm.btn1.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_OK 'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_OK", "OK")
                oForm.btn1.DialogResult = System.Windows.Forms.DialogResult.OK
                oForm.btn1.Visible = True
                'oForm.AcceptButton = oForm.btn1
                ' Boton de Cancelar
                oForm.btn2.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_CANCEL  'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_CANCEL", "Cancel")
                oForm.btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel
                oForm.btn2.Visible = True
                'oForm.CancelButton = oForm.btn2
            Case MessageBoxButtons.YesNo
                ' Boton de Si
                oForm.btn1.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_YES  'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_YES", "Yes")
                oForm.btn1.DialogResult = System.Windows.Forms.DialogResult.Yes
                oForm.btn1.Visible = True
                'oForm.AcceptButton = Nothing
                ' Boton de No
                oForm.btn2.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_NO  'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_NO", "No")
                oForm.btn2.DialogResult = System.Windows.Forms.DialogResult.No
                oForm.btn2.Visible = True
                'oForm.CancelButton = Nothing
            Case MessageBoxButtons.RetryCancel
                ' Boton de Reintentar
                oForm.btn1.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_RETRY  'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_RETRY", "Retry")
                oForm.btn1.DialogResult = System.Windows.Forms.DialogResult.Retry
                oForm.btn1.Visible = True
                'oForm.AcceptButton = Nothing
                ' Boton de Cancelar
                oForm.btn2.Text = IgpManager.BACK.EnvironmentObjects.BUTTON_CANCEL  'oApp.TranslatedResources.GetString("GlobalCaptionsConstants.BUTTON_CANCEL", "Cancel")
                oForm.btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel
                oForm.btn2.Visible = True
                'oForm.CancelButton = oForm.btn2
        End Select

        Select Case defaultButton
            Case MessageBoxDefaultButton.Button1
                'oForm.AcceptButton = oForm.btn1
                oForm.btn1.Select()
            Case MessageBoxDefaultButton.Button2
                'oForm.AcceptButton = oForm.btn2
                oForm.btn2.Select()
        End Select

        Select Case icon
            Case MessageBoxIcon.Error
                oForm.picError.Visible = True
            Case MessageBoxIcon.Exclamation
                oForm.picExclamation.Visible = True
            Case MessageBoxIcon.Information
                oForm.picInformation.Visible = True
            Case MessageBoxIcon.Question
                oForm.picQuestion.Visible = True
        End Select

        oForm.StartPosition = FormStartPosition.Manual

        oForm.Top = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - oForm.Height) \ 2
        oForm.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - oForm.Width) \ 2

        Select Case position
            Case position.Center
            Case position.Bottom
                oForm.Top += 180
            Case position.Top
                oForm.Top -= 200
        End Select

        oResult = oForm.ShowDialog(owner)

        oForm.Dispose()

        Return oResult
    End Function

    Public Overloads Shared Function Show(ByVal text As String, _
                                          Optional ByVal caption As String = "", _
                                          Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
                                          Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.None, _
                                          Optional ByVal defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1, _
                                          Optional ByVal position As Position = Position.Center) As DialogResult
        Return Show(Nothing, text, caption, buttons, icon, defaultButton, position)
    End Function

#End Region

End Class

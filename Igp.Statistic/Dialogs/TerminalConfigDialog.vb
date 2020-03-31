Public Class TerminalConfigDialog
    Inherits Igp.Statistic.BaseDialog

    Friend WithEvents ctlConfig2 As Igp.TerminalConfig.ConfigControl

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
    Friend WithEvents lblCaptionKeys As System.Windows.Forms.Label
    'Friend WithEvents ctlConfig As ewave.TerminalConfig.ConfigControl
    Friend WithEvents lblESC As System.Windows.Forms.Label
    Protected WithEvents pnlCentral As PanelNotMouse
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    'Friend WithEvents ConfigControl1 As ewave.TerminalConfig.ConfigControl
    'Friend WithEvents ConfigControl2 As ewave.TerminalConfig.ConfigControl

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCaptionKeys = New System.Windows.Forms.Label
        Me.lblESC = New System.Windows.Forms.Label
        Me.lblEnter = New System.Windows.Forms.Label
        Me.pnlCentral = New PanelNotMouse
        Me.SuspendLayout()
        '
        'pnlRightTop
        '
        Me.pnlRightTop.Location = New System.Drawing.Point(375, 0)
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Size = New System.Drawing.Size(268, 55)
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Location = New System.Drawing.Point(107, 394)
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(268, 54)
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 398)
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Location = New System.Drawing.Point(375, 373)
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Size = New System.Drawing.Size(107, 337)
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Location = New System.Drawing.Point(375, 47)
        Me.pnlRightMiddle.Size = New System.Drawing.Size(105, 329)
        '
        'lblCaptionKeys
        '
        Me.lblCaptionKeys.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaptionKeys.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.lblCaptionKeys.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionKeys.Location = New System.Drawing.Point(16, 24)
        Me.lblCaptionKeys.Name = "lblCaptionKeys"
        Me.lblCaptionKeys.Size = New System.Drawing.Size(448, 24)
        Me.lblCaptionKeys.TabIndex = 47
        Me.lblCaptionKeys.Text = " Configuración de la terminal"
        Me.lblCaptionKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCaptionKeys.UseMnemonic = False
        '
        'lblESC
        '
        Me.lblESC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblESC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESC.Location = New System.Drawing.Point(120, 416)
        Me.lblESC.Name = "lblESC"
        Me.lblESC.Size = New System.Drawing.Size(240, 16)
        Me.lblESC.TabIndex = 56
        Me.lblESC.Text = "ESC - Cancela"
        Me.lblESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnter
        '
        Me.lblEnter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(120, 392)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(240, 16)
        Me.lblEnter.TabIndex = 55
        Me.lblEnter.Text = "ENTER - Acepta"
        Me.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_sarasa
        '
        Me.pnlCentral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCentral.BackColor = System.Drawing.Color.Transparent
        Me.pnlCentral.Location = New System.Drawing.Point(113, 61)
        Me.pnlCentral.Name = "Panel_sarasa"
        Me.pnlCentral.Size = New System.Drawing.Size(256, 327)
        Me.pnlCentral.TabIndex = 57
        '
        'TerminalConfigDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(480, 448)
        Me.Controls.Add(Me.lblESC)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblCaptionKeys)
        Me.Controls.Add(Me.pnlCentral)
        Me.KeyPreview = True
        Me.Name = "TerminalConfigDialog"
        Me.ShowInTaskbar = False
        Me.Controls.SetChildIndex(Me.pnlCentral, 0)
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.lblCaptionKeys, 0)
        Me.Controls.SetChildIndex(Me.lblEnter, 0)
        Me.Controls.SetChildIndex(Me.lblESC, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Aesthetic methods "

    Private Sub SetColorSchema()
        'cuando carga el TC porque no encuentra la clave en el        'registro no hay ColorSchema definido  (dcofre 3/10/2005)
        Try
            With oApp.ColorSchema
                Me.BackColor = .Background
                Me.ForeColor = .Foreground

                lblCaptionKeys.BackColor = .HeaderBackground
                lblCaptionKeys.ForeColor = .HeaderForeground

            End With
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region " Event handlers "

    'Private Sub ctlConfig_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctlConfig1.Resize
    '    Me.Height = ctlConfig.Height + 120
    'End Sub

    Private Sub TerminalConfigDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Igp.TerminalConfig.EnvironmentObjects.Connection = oApp.OleDBConnection
        Igp.TerminalConfig.EnvironmentObjects.GlobalResources = New Igp.GlobalResourcesEngine.ResourceLoader
        ctlConfig2 = New Igp.TerminalConfig.ConfigControl
        With ctlConfig2
            .DataLayer = New Igp.TerminalConfig.DataLayer(oApp.OleDBConnection)
            .TerminalId = oApp.TerminalId
            .LoadGlobalCaptions()
            .BackColor = Me.BackColor
            .ForeColor = Me.ForeColor
            .Location = New System.Drawing.Point(30, 55)
            .Size = New System.Drawing.Size(420, 325)
        End With

        Me.Controls.Add(ctlConfig2)
        ctlConfig2.BringToFront()

    End Sub

    Private Sub TerminalConfigDialog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then

            ctlConfig2.SaveData()
            ctlConfig2 = Nothing
            DialogResult = DialogResult.OK
        ElseIf e.KeyCode = Keys.Escape Then
            ctlConfig2 = Nothing
            DialogResult = DialogResult.Cancel
        End If
    End Sub

#End Region

#Region " GlobalResourcesLoader "

    Private Sub LoadGlobalCaptions()

        Me.lblCaptionKeys.Text = oApp.GlobalResources.GetString("lblCaptionKeys.Text", Me.lblCaptionKeys.Text)
        Me.lblESC.Text = oApp.GlobalResources.GetString("lblESC.Text", Me.lblESC.Text)
        Me.lblEnter.Text = oApp.GlobalResources.GetString("lblEnter.Text", Me.lblEnter.Text)

    End Sub

#End Region

End Class

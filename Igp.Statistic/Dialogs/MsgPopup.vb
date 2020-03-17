Public Class MsgPopup
    Inherits BaseDialog

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.Name = "pnlLeftTop"
        '
        'pnlRightTop
        '
        Me.pnlRightTop.Name = "pnlRightTop"
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Name = "pnlMiddleTop"
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Name = "pnlRightMiddle"
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Name = "pnlLeftMiddle"
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Name = "pnlMiddleBottom"
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Name = "pnlRightBottom"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label2.Location = New System.Drawing.Point(8, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Presione Alt+Q para cerrar esta ventana"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mensaje:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(50, Byte), CType(50, Byte), CType(50, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(24, 32)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(264, 96)
        Me.lblMessage.TabIndex = 18
        '
        'MsgPopup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(50, Byte), CType(50, Byte), CType(50, Byte))
        Me.ClientSize = New System.Drawing.Size(306, 158)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.Name = "MsgPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MsgPopup"
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblMessage, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MsgPopup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt And e.KeyCode = Keys.Q Then

            Me.Close()

        End If
    End Sub

#Region " GlobalResourcesLoader "

    Private Sub LoadGlobalCaptions()
        '  Label2.Text = oApp.GlobalResources.GetString("Label2.Text", Label2.Text)
        ' Label3.Text = oApp.GlobalResources.GetString("Label3.Text", Label3.Text)
    End Sub

#End Region

End Class

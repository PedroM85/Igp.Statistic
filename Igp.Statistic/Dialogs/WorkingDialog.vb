Public Class WorkingDialog
    Inherits Igp.Statistic.BaseDialog

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        LoadGlobalCaptions()
        SetColorSchema()

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
    Private WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Name = "pnlMiddleBottom"
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(274, 54)
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Location = New System.Drawing.Point(381, 83)
        Me.pnlRightBottom.Name = "pnlRightBottom"
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Name = "pnlLeftMiddle"
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Location = New System.Drawing.Point(381, 47)
        Me.pnlRightMiddle.Name = "pnlRightMiddle"
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.Name = "pnlLeftTop"
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Name = "pnlMiddleTop"
        Me.pnlMiddleTop.Size = New System.Drawing.Size(274, 55)
        '
        'pnlRightTop
        '
        Me.pnlRightTop.Location = New System.Drawing.Point(381, 0)
        Me.pnlRightTop.Name = "pnlRightTop"
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(67, 19)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(352, 120)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.Text = "Un momento por favor..."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkingDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(486, 158)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "WorkingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.lblMessage, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " GlobalResourcesLoader "

    Private Sub LoadGlobalCaptions()

        ' Me.lblMessage.Text = oApp.TranslatedResources.GetString("EBOC.WorkingDialog.LoadGlobalCaptions.lblMessage.Text", Me.lblMessage.Text)

    End Sub

#End Region

#Region " Aesthetic methods "

    Private Sub SetColorSchema()
        If Not DesignMode AndAlso Not oApp Is Nothing _
            AndAlso Not oApp.ColorSchema Is Nothing Then
            With oApp.ColorSchema
                'Me.BackColor = .Background
                'Me.ForeColor = .Foreground
                Me.lblMessage.ForeColor = .Foreground
            End With
        End If
    End Sub

#End Region


    Friend Property Message() As String
        Get
            Return Me.lblMessage.Text
        End Get
        Set(ByVal Value As String)
            Me.lblMessage.Text = Value
            Me.Refresh()
        End Set
    End Property

    Friend Overloads Sub Show(ByVal MessageToDisplay As String)
        Me.Message = MessageToDisplay
        MyBase.Show()
    End Sub

End Class

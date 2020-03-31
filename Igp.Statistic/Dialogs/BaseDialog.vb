Public Class BaseDialog
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Try
            SetColorSchema()
        Catch ex As Exception

        End Try

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
    Protected WithEvents pnlLeftTop As Windows.Forms.Panel
    Protected WithEvents pnlRightTop As Windows.Forms.Panel
    Protected WithEvents pnlMiddleTop As Windows.Forms.Panel
    Protected WithEvents pnlMiddleBottom As Windows.Forms.Panel
    Protected WithEvents pnlLeftBottom As Windows.Forms.Panel
    Protected WithEvents pnlRightBottom As Windows.Forms.Panel
    Protected WithEvents pnlLeftMiddle As Windows.Forms.Panel
    Protected WithEvents pnlRightMiddle As Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pnlLeftTop = New System.Windows.Forms.Panel
        Me.pnlRightTop = New System.Windows.Forms.Panel
        Me.pnlMiddleTop = New System.Windows.Forms.Panel
        Me.pnlMiddleBottom = New System.Windows.Forms.Panel
        Me.pnlLeftBottom = New System.Windows.Forms.Panel
        Me.pnlRightBottom = New System.Windows.Forms.Panel
        Me.pnlLeftMiddle = New System.Windows.Forms.Panel
        Me.pnlRightMiddle = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlLeftTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftTop.Name = "pnlLeftTop"
        Me.pnlLeftTop.Size = New System.Drawing.Size(107, 61)
        Me.pnlLeftTop.TabIndex = 0
        '
        'pnlRightTop
        '
        Me.pnlRightTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRightTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlRightTop.Location = New System.Drawing.Point(201, 0)
        Me.pnlRightTop.Name = "pnlRightTop"
        Me.pnlRightTop.Size = New System.Drawing.Size(105, 47)
        Me.pnlRightTop.TabIndex = 1
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMiddleTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlMiddleTop.Location = New System.Drawing.Point(107, 0)
        Me.pnlMiddleTop.Name = "pnlMiddleTop"
        Me.pnlMiddleTop.Size = New System.Drawing.Size(94, 55)
        Me.pnlMiddleTop.TabIndex = 2
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMiddleBottom.BackColor = System.Drawing.Color.Transparent
        Me.pnlMiddleBottom.Location = New System.Drawing.Point(107, 104)
        Me.pnlMiddleBottom.Name = "pnlMiddleBottom"
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(94, 54)
        Me.pnlMiddleBottom.TabIndex = 5
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLeftBottom.BackColor = System.Drawing.Color.Transparent
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 108)
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        Me.pnlLeftBottom.Size = New System.Drawing.Size(107, 50)
        Me.pnlLeftBottom.TabIndex = 3
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRightBottom.BackColor = System.Drawing.Color.Transparent
        Me.pnlRightBottom.Location = New System.Drawing.Point(201, 83)
        Me.pnlRightBottom.Name = "pnlRightBottom"
        Me.pnlRightBottom.Size = New System.Drawing.Size(105, 75)
        Me.pnlRightBottom.TabIndex = 4
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLeftMiddle.BackColor = System.Drawing.Color.Transparent
        Me.pnlLeftMiddle.Location = New System.Drawing.Point(0, 61)
        Me.pnlLeftMiddle.Name = "pnlLeftMiddle"
        Me.pnlLeftMiddle.Size = New System.Drawing.Size(107, 47)
        Me.pnlLeftMiddle.TabIndex = 6
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRightMiddle.BackColor = System.Drawing.Color.Transparent
        Me.pnlRightMiddle.Location = New System.Drawing.Point(201, 47)
        Me.pnlRightMiddle.Name = "pnlRightMiddle"
        Me.pnlRightMiddle.Size = New System.Drawing.Size(105, 39)
        Me.pnlRightMiddle.TabIndex = 7
        '
        'BaseDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(306, 158)
        Me.Controls.Add(Me.pnlLeftMiddle)
        Me.Controls.Add(Me.pnlRightMiddle)
        Me.Controls.Add(Me.pnlMiddleBottom)
        Me.Controls.Add(Me.pnlLeftBottom)
        Me.Controls.Add(Me.pnlRightBottom)
        Me.Controls.Add(Me.pnlMiddleTop)
        Me.Controls.Add(Me.pnlLeftTop)
        Me.Controls.Add(Me.pnlRightTop)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(306, 158)
        Me.Name = "BaseDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaseDialog"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Aesthetic methods "

    Private Sub SetColorSchema()
        If Not DesignMode AndAlso Not oApp Is Nothing _
            AndAlso Not oApp.ColorSchema Is Nothing Then
            With oApp.ColorSchema
                Me.BackColor = .Background
                Me.ForeColor = .Foreground

                If oApp.Connected Then
                    pnlLeftTop.BackgroundImage = .GetImage("DialogTopLeft")
                    pnlMiddleTop.BackgroundImage = .GetImage("DialogTopCenter")
                    pnlRightTop.BackgroundImage = .GetImage("DialogTopRight")
                    pnlLeftMiddle.BackgroundImage = .GetImage("DialogCenterLeft")
                    pnlRightMiddle.BackgroundImage = .GetImage("DialogCenterRight")
                    pnlLeftBottom.BackgroundImage = .GetImage("DialogBottomLeft")
                    pnlMiddleBottom.BackgroundImage = .GetImage("DialogBottomCenter")
                    pnlRightBottom.BackgroundImage = .GetImage("DialogBottomRight")
                Else
                    Me.FormBorderStyle = FormBorderStyle.FixedDialog
                    Me.ControlBox = False
                    Me.Text = ""
                    Me.MinimizeBox = False
                    Me.MaximizeBox = False
                End If
            End With
        End If
    End Sub

#End Region

#Region " Catch MouseMoveEvent"

    Private Sub BaseDialog_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        oApp.LastAction = Now
    End Sub

    Private Sub BaseDialog_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlLeftTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlLeftTop.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlLeftMiddle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlLeftMiddle.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlLeftBottom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlLeftBottom.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlMiddleTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMiddleTop.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlMiddleBottom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMiddleBottom.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlRightTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlRightTop.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlRightMiddle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlRightMiddle.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

    Private Sub pnlRightBottom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlRightBottom.MouseMove
        'Cursor.Position = Me.PointToScreen(New Point(0, 0))
        'Cursor.Position = New Point(0, 0)
        oApp.LastAction = Now
    End Sub

#End Region

End Class

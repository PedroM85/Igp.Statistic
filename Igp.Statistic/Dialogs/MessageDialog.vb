Public Class MessageDialog
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
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblCaptionKeys As System.Windows.Forms.Label
    Friend WithEvents lblDest As System.Windows.Forms.Label
    Friend WithEvents lblESC As System.Windows.Forms.Label
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    'Friend WithEvents jgxUsers As JanusGridEX_NotMouse
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        'Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.lblBase = New System.Windows.Forms.Label
        Me.lblDest = New System.Windows.Forms.Label
        Me.lblCaptionKeys = New System.Windows.Forms.Label
        Me.lblESC = New System.Windows.Forms.Label
        Me.lblEnter = New System.Windows.Forms.Label
        'Me.jgxUsers = New JanusGridEX_NotMouse
        'CType(Me.jgxUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 326)
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        '
        'pnlMiddleTop
        '
        Me.pnlMiddleTop.Name = "pnlMiddleTop"
        Me.pnlMiddleTop.Size = New System.Drawing.Size(284, 55)
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Location = New System.Drawing.Point(391, 301)
        Me.pnlRightBottom.Name = "pnlRightBottom"
        '
        'pnlLeftMiddle
        '
        Me.pnlLeftMiddle.Name = "pnlLeftMiddle"
        Me.pnlLeftMiddle.Size = New System.Drawing.Size(107, 265)
        '
        'pnlRightMiddle
        '
        Me.pnlRightMiddle.Location = New System.Drawing.Point(391, 47)
        Me.pnlRightMiddle.Name = "pnlRightMiddle"
        Me.pnlRightMiddle.Size = New System.Drawing.Size(105, 257)
        '
        'pnlRightTop
        '
        Me.pnlRightTop.Location = New System.Drawing.Point(391, 0)
        Me.pnlRightTop.Name = "pnlRightTop"
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.Name = "pnlLeftTop"
        '
        'pnlMiddleBottom
        '
        Me.pnlMiddleBottom.Location = New System.Drawing.Point(107, 322)
        Me.pnlMiddleBottom.Name = "pnlMiddleBottom"
        Me.pnlMiddleBottom.Size = New System.Drawing.Size(284, 54)
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.AutoSize = False
        Me.txtMessage.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.White
        Me.txtMessage.Location = New System.Drawing.Point(120, 224)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(352, 104)
        Me.txtMessage.TabIndex = 1
        Me.txtMessage.Text = ""
        '
        'lblBase
        '
        Me.lblBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBase.Location = New System.Drawing.Point(16, 224)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(96, 19)
        Me.lblBase.TabIndex = 9
        Me.lblBase.Text = "Mensaje:"
        Me.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDest
        '
        Me.lblDest.Location = New System.Drawing.Point(16, 57)
        Me.lblDest.Name = "lblDest"
        Me.lblDest.Size = New System.Drawing.Size(96, 19)
        Me.lblDest.TabIndex = 10
        Me.lblDest.Text = "Destinatarios:"
        Me.lblDest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaptionKeys
        '
        Me.lblCaptionKeys.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaptionKeys.BackColor = System.Drawing.Color.FromArgb(CType(104, Byte), CType(104, Byte), CType(104, Byte))
        Me.lblCaptionKeys.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionKeys.Location = New System.Drawing.Point(16, 24)
        Me.lblCaptionKeys.Name = "lblCaptionKeys"
        Me.lblCaptionKeys.Size = New System.Drawing.Size(464, 24)
        Me.lblCaptionKeys.TabIndex = 45
        Me.lblCaptionKeys.Text = " Enviar un mensaje instantáneo"
        Me.lblCaptionKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblESC
        '
        Me.lblESC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblESC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESC.Location = New System.Drawing.Point(264, 338)
        Me.lblESC.Name = "lblESC"
        Me.lblESC.Size = New System.Drawing.Size(208, 16)
        Me.lblESC.TabIndex = 46
        Me.lblESC.Text = "ESC - "
        Me.lblESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnter
        '
        Me.lblEnter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(56, 338)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(208, 16)
        Me.lblEnter.TabIndex = 47
        Me.lblEnter.Text = "ENTER - "
        Me.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'jgxUsers

        'Me.jgxUsers.AcceptsEscape = False
        'Me.jgxUsers.AllowColumnDrag = False
        'Me.jgxUsers.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        'Me.jgxUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        '            Or System.Windows.Forms.AnchorStyles.Left) _
        '            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'Me.jgxUsers.AutomaticSort = False
        'Me.jgxUsers.BackColor = System.Drawing.Color.FromArgb(CType(50, Byte), CType(50, Byte), CType(50, Byte))
        'Me.jgxUsers.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        'Me.jgxUsers.CellToolTip = Janus.Windows.GridEX.CellToolTip.NoToolTip
        'Me.jgxUsers.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        'Me.jgxUsers.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.FlatBorderless
        'Me.jgxUsers.ControlStyle.ControlColor = System.Drawing.Color.DarkGray
        'Me.jgxUsers.ControlStyle.ControlTextColor = System.Drawing.Color.White
        'Me.jgxUsers.ControlStyle.HoverBaseColor = System.Drawing.Color.IndianRed
        'Me.jgxUsers.ControlStyle.HoverBlendColor = System.Drawing.Color.White
        'Me.jgxUsers.ControlStyle.ScrollBarColor = System.Drawing.Color.DarkGray
        'Me.jgxUsers.ControlStyle.WindowColor = System.Drawing.Color.White
        'Me.jgxUsers.ControlStyle.WindowTextColor = System.Drawing.Color.White
        'Me.jgxUsers.Cursor = System.Windows.Forms.Cursors.Default
        'GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Data""><Allow" & _
        '"Size>False</AllowSize><AllowSort>False</AllowSort><Caption>Data</Caption><DataMe" & _
        '"mber>Data</DataMember><Key>Data</Key><Position>0</Position><Selectable>False</Se" & _
        '"lectable><Width>332</Width></Column0><Column1 ID=""Selected""><AllowSize>False</Al" & _
        '"lowSize><AllowSort>False</AllowSort><DataMember>Selected</DataMember><Key>Select" & _
        '"ed</Key><Position>1</Position><Selectable>False</Selectable><Visible>False</Visi" & _
        '"ble></Column1></Columns><FormatConditions Collection=""true""><Condition0 ID=""Sele" & _
        '"cted""><ColIndex>1</ColIndex><FormatStyle><FontBold>True</FontBold></FormatStyle>" & _
        '"<Value1>True</Value1><Key>Selected</Key></Condition0></FormatConditions><GroupCo" & _
        '"ndition ID="""" /></RootTable></GridEXLayoutData>"
        'Me.jgxUsers.DesignTimeLayout = GridEXLayout1
        'Me.jgxUsers.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        'Me.jgxUsers.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        'Me.jgxUsers.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False
        'Me.jgxUsers.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(152, Byte), CType(185, Byte), CType(210, Byte))
        'Me.jgxUsers.FocusCellFormatStyle.ForeColor = System.Drawing.Color.White
        'Me.jgxUsers.Font = New System.Drawing.Font("Tahoma", 9.75!)
        'Me.jgxUsers.GridLineColor = System.Drawing.Color.FromArgb(CType(104, Byte), CType(104, Byte), CType(104, Byte))
        'Me.jgxUsers.GridLines = Janus.Windows.GridEX.GridLines.Horizontal
        'Me.jgxUsers.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        'Me.jgxUsers.GroupByBoxVisible = False
        'Me.jgxUsers.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        'Me.jgxUsers.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(104, Byte), CType(104, Byte), CType(104, Byte))
        'Me.jgxUsers.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
        'Me.jgxUsers.HeaderFormatStyle.ForeColor = System.Drawing.Color.White
        'Me.jgxUsers.Location = New System.Drawing.Point(120, 56)
        'Me.jgxUsers.Name = "jgxUsers"
        'Me.jgxUsers.RowFormatStyle.BackColor = System.Drawing.Color.Empty
        'Me.jgxUsers.RowFormatStyle.ForeColor = System.Drawing.Color.White
        'Me.jgxUsers.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        'Me.jgxUsers.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(132, Byte), CType(159, Byte), CType(180, Byte))
        'Me.jgxUsers.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        'Me.jgxUsers.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(119, Byte), CType(140, Byte))
        'Me.jgxUsers.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.Black
        'Me.jgxUsers.Size = New System.Drawing.Size(352, 160)
        'Me.jgxUsers.TabIndex = 0
        'Me.jgxUsers.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        'Me.jgxUsers.TabStop = False
        'Me.jgxUsers.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        'Me.jgxUsers.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        'Me.jgxUsers.UpdateOnLeave = False
        '
        'MessageDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(496, 376)
        ' Me.Controls.Add(Me.jgxUsers)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblESC)
        Me.Controls.Add(Me.lblCaptionKeys)
        Me.Controls.Add(Me.lblDest)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtMessage)
        Me.Name = "MessageDialog"
        Me.ShowInTaskbar = False
        Me.Controls.SetChildIndex(Me.pnlRightTop, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftTop, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleTop, 0)
        Me.Controls.SetChildIndex(Me.pnlRightBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlMiddleBottom, 0)
        Me.Controls.SetChildIndex(Me.pnlRightMiddle, 0)
        Me.Controls.SetChildIndex(Me.pnlLeftMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtMessage, 0)
        Me.Controls.SetChildIndex(Me.lblBase, 0)
        Me.Controls.SetChildIndex(Me.lblDest, 0)
        Me.Controls.SetChildIndex(Me.lblCaptionKeys, 0)
        Me.Controls.SetChildIndex(Me.lblESC, 0)
        Me.Controls.SetChildIndex(Me.lblEnter, 0)
        'Me.Controls.SetChildIndex(Me.jgxUsers, 0)
        'CType(Me.jgxUsers, System.ComponentModel.ISupportInitialize).EndInit()
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
            'jgxUsers.BackColor = .Background
            'jgxUsers.ForeColor = .Foreground
            'jgxUsers.FlatBorderColor = .FlatBorder
            'jgxUsers.GridLineColor = .HeaderBackground
            'jgxUsers.RowFormatStyle.ForeColor = .Foreground
            'jgxUsers.FocusCellFormatStyle.BackColor = .FocusCellBackground
            'jgxUsers.FocusCellFormatStyle.ForeColor = .FocusCellForeground
            'jgxUsers.HeaderFormatStyle.BackColor = .HeaderBackground
            'jgxUsers.HeaderFormatStyle.ForeColor = .HeaderForeground
            'jgxUsers.SelectedFormatStyle.BackColor = .HighlightBackground
            'jgxUsers.SelectedFormatStyle.ForeColor = .HighlightForeground
            'jgxUsers.SelectedInactiveFormatStyle.BackColor = .HighlightBackgroundOff
            'jgxUsers.SelectedInactiveFormatStyle.ForeColor = .HighlightForegroundOff
            'jgxUsers.ControlStyle.ScrollBarColor = .ScrollbarColor
            txtMessage.BackColor = .HighlightBackgroundOff
            txtMessage.ForeColor = .Foreground
        End With
    End Sub

#End Region

#Region " Methods "

    Private Function GetUsersOnline() As Collection
        Dim oCmd As OleDb.OleDbCommand = oApp.OleDBConnection.CreateCommand
        Dim oRd As OleDb.OleDbDataReader
        Dim oUsers As Collection
        Dim oUser As User

        With oCmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GQY_UsersPerTerminal"
            oRd = .ExecuteReader
        End With

        oUsers = New Collection
        Do While oRd.Read
            If Not oRd.IsDBNull(oRd.GetOrdinal("USR_Id")) Then
                oUser = New User
                With oUser
                    .Name = oRd.GetString(oRd.GetOrdinal("USR_Name"))
                    .Module = IIf(oRd.IsDBNull(oRd.GetOrdinal("ULO_SSS_Id")), "Manager", "POS")
                    .IP = oRd.GetString(oRd.GetOrdinal("ULO_IP"))
                End With
                oUsers.Add(oUser)
            End If
        Loop
        oRd.Close()

        Return oUsers
    End Function

    Private Sub SendMessage()
        ' Dim oRow As Janus.Windows.GridEX.GridEXRow
        Dim sMsg As String

        sMsg = "De: " & oApp.User.LastName & ", " & oApp.User.FirstName & vbCrLf & txtMessage.Text
        'For Each oRow In jgxUsers.GetRows
        '    If oRow.DataRow.Selected Then
        '        oApp.CommunicationManager.SendInstantMessage(IIf(oRow.DataRow.Module = "POS", ewave.AccessController.CommunicationManager.ModuleEnum.POS, ewave.AccessController.CommunicationManager.ModuleEnum.Manager), oRow.DataRow.IP, sMsg)
        '    End If
        'Next
    End Sub

#End Region

#Region " Event handlers "

    Private Sub MessageDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oUsers As Collection = GetUsersOnline()

        'jgxUsers.SetDataBinding(oUsers, "")
        ' jgxUsers.Select()
    End Sub

    'Private Sub jgxUsers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jgxUsers.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Escape
    '            Close()
    '        Case Keys.Enter
    '            txtMessage.Select()
    '        Case Keys.Add
    '            jgxUsers.GetRow.DataRow.Selected = True
    '            jgxUsers.Refresh()
    '        Case Keys.Subtract
    '            jgxUsers.GetRow.DataRow.Selected = False
    '            jgxUsers.Refresh()
    '    End Select
    'End Sub

    Private Sub txtMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                'jgxUsers.Select()
            Case Keys.Enter
                SendMessage()
                Close()
        End Select
    End Sub

    Private Sub txtMessage_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.Enter
        txtMessage.BackColor = oApp.ColorSchema.HighlightBackground
        lblEnter.Text = "ENTER - " + Msg_Send
        lblESC.Text = "ESC - " + Msg_Select_Users
    End Sub

    Private Sub txtMessage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.Leave
        txtMessage.BackColor = oApp.ColorSchema.HighlightBackgroundOff
    End Sub

    'Private Sub jgxUsers_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles jgxUsers.Enter
    '    jgxUsers.BackColor = oApp.ColorSchema.BackgroundFocused

    '    lblEnter.Text = "ENTER - " + Msg_Accept_Users
    '    lblESC.Text = "ESC - " + Msg_Cancel
    'End Sub

    'Private Sub jgxUsers_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles jgxUsers.Leave
    '    jgxUsers.BackColor = oApp.ColorSchema.Background
    'End Sub

#End Region

#Region " Classes "

    Private Class User

        Private sName As String
        Private sModule As String
        Private sIP As String
        Private bSelected As Boolean = False

        Public WriteOnly Property Name() As String
            Set(ByVal Value As String)
                sName = Value
            End Set
        End Property

        Public Property [Module]() As String
            Get
                Return sModule
            End Get
            Set(ByVal Value As String)
                sModule = Value
            End Set
        End Property

        Public ReadOnly Property Data() As String
            Get
                Return sName & " (" & sModule & ")"
            End Get
        End Property

        Public Property IP() As String
            Get
                Return sIP
            End Get
            Set(ByVal Value As String)
                sIP = Value
            End Set
        End Property

        Public Property Selected() As Boolean
            Get
                Return bSelected
            End Get
            Set(ByVal Value As Boolean)
                bSelected = Value
            End Set
        End Property

    End Class

#End Region

#Region " GlobalResourcesLoader "
    Dim Msg_Send As String
    Dim Msg_Select_Users As String
    Dim Msg_Accept_Users As String
    Dim Msg_Cancel As String

    Private Sub LoadGlobalCaptions()
        Msg_Send = oApp.GlobalResources.GetString("Msg_Send", "Envía el mensaje")
        Msg_Select_Users = oApp.GlobalResources.GetString("Msg_Select_Users", "Selecciona destinatarios")
        Msg_Accept_Users = oApp.GlobalResources.GetString("Msg_Accept_Users", "Acepta destinatarios")
        Msg_Cancel = oApp.GlobalResources.GetString("Msg_Cancel", "Cancela el mensaje")

        Me.lblBase.Text = oApp.GlobalResources.GetString("lblBase.Text", Me.lblBase.Text)
        Me.lblDest.Text = oApp.GlobalResources.GetString("lblDest.Text", Me.lblDest.Text)
        Me.lblCaptionKeys.Text = oApp.GlobalResources.GetString("lblCaptionKeys.Text", Me.lblCaptionKeys.Text)

    End Sub

#End Region

End Class

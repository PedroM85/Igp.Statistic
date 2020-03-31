Imports System.Windows.Forms
Imports System.Drawing

Friend Class FlatControl
    Inherits System.Windows.Forms.NativeWindow

#Region " Unmanaged Code "

    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> _
    Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    Private Declare Function GetWindowRect Lib "user32.dll" (ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Integer
    Private Declare Function GetClientRect Lib "user32.dll" (ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Integer
    Private Declare Function GetDC Lib "user32.dll" (ByVal hWnd As IntPtr) As IntPtr
    Private Declare Function ReleaseDC Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal hdc As IntPtr) As Integer
    Private Declare Function GetFocus Lib "user32.dll" () As IntPtr
    Private Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    Private Declare Function IsWindowEnabled Lib "user32.dll" (ByVal hWnd As IntPtr) As Integer
    Private Declare Auto Function GetWindowLong Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    Private Declare Unicode Function SetWindowTheme Lib "uxtheme.dll" (ByVal hWnd As IntPtr, <System.Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.LPWStr)> ByVal pszSubAppName As String, <System.Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.LPWStr)> ByVal pszSubIdList As String) As Integer

    Private Const WM_COMMAND As Integer = &H111
    Private Const WM_PAINT As Integer = &HF
    Private Const WM_SETFOCUS As Integer = &H7
    Private Const WM_KILLFOCUS As Integer = &H8
    Private Const WM_MOUSEACTIVATE As Integer = &H21
    Private Const WM_MOUSEMOVE As Integer = &H200

    Private Const CBN_DROPDOWN As Integer = 7
    Private Const CBN_CLOSEUP As Integer = 8
    Private Const CB_GETDROPPEDSTATE As Integer = &H157

    Private Const GWL_EXSTYLE As Integer = (-20)
    Private Const WS_EX_RIGHT As Integer = &H1000
    Private Const WS_EX_LEFTSCROLLBAR As Integer = &H4000

#End Region

#Region " Enumerations "

    ''' <summary>
    ''' Specifies the Flat Styles that the control can be drawn
    ''' with.
    ''' </summary>
    Public Enum FlatControlStyle As Integer
        ''' <summary>
        ''' Draw in the Office 9 style.
        ''' </summary>
        FlatStyleOffice9
        ''' <summary>
        ''' Draw in the Office XP style.
        ''' </summary>
        FlatStyleOffice10
        ''' <summary>
        ''' Draw in the Office 2003 style (not implemented yet).
        ''' </summary>
        FlatStyleOffice11
    End Enum

    Private Enum DrawStyle As Integer
        FC_DRAWNORMAL
        FC_DRAWRAISED
        FC_DRAWPRESSED
    End Enum

#End Region

#Region " Member Variables "

    ''' <summary>
    ''' An object which subclasses the text box within the 
    ''' combo box.
    ''' </summary>
    Private m_flatComboTextBox As FlatComboTextBox = Nothing
    Private m_flatComboParent As FlatComboParent = Nothing
    Private WithEvents mouseOverTimer As Timer = Nothing
    Private mouseOver As Boolean = False
    Private m_style As FlatControlStyle = FlatControlStyle.FlatStyleOffice10

#End Region

#Region " Properties "

    Public Property Style() As FlatControlStyle
        Get
            Style = Me.m_style
        End Get
        Set(ByVal Value As FlatControlStyle)
            Me.m_style = Value
        End Set
    End Property

#End Region

#Region " Methods "

    ''' <summary>
    ''' Attaches this class to a Combo Box.
    ''' </summary>
    ''' <param name="comboBox">The Combo Box to attach to and make
    ''' flat.</param>
    Public Sub Attach(ByVal comboBox As System.Windows.Forms.Control)
        Me.AssignHandle(comboBox.Handle)
        RemoveTheme(Me.Handle)
        m_flatComboTextBox = New FlatComboTextBox
        m_flatComboTextBox.Attach(comboBox, Me)
        m_flatComboParent = New FlatComboParent
        m_flatComboParent.Attach(comboBox, Me)
        Me.mouseOverTimer = New Timer
        mouseOverTimer.Enabled = False
        mouseOverTimer.Interval = 10
    End Sub

    ''' <summary>
    ''' Calls the base WndProc for the control and
    ''' responds to events allowing the control to be
    ''' drawn with a flat style.
    ''' </summary>
    ''' <param name="m">WndProc Message.</param>
    Protected Overrides Sub WndProc(ByRef m As Message)

        ' Call the base Window Procedure:
        MyBase.WndProc(m)

        ' Process messages we need to overpaint
        ' for:
        Select Case (m.Msg)
            Case WM_PAINT
                OnPaint()
            Case WM_SETFOCUS
                OnSetFocus()
            Case WM_KILLFOCUS
                OnKillFocus()
            Case WM_MOUSEMOVE
                OnMouseMove()
        End Select

    End Sub

    ''' <summary>
    ''' Called by the FlatComboTextBox class when focus or mouse
    ''' move events occur in the internal text box of the combo
    ''' box.
    ''' </summary>
    ''' <param name="msg">Windows message code.</param>
    Protected Sub TextBoxNotify(ByVal msg As Integer)

        Select Case (msg)
            Case WM_SETFOCUS
                OnSetFocus()
            Case WM_KILLFOCUS
                OnKillFocus()
            Case WM_MOUSEMOVE
                OnMouseMove()
            Case Else
                Debug.Assert(False, "Incorrect message passed from TextBox: " + msg)
        End Select

    End Sub

    ''' <summary>
    ''' Called by the FlatComboParent class when the combo box 
    ''' is closed up.
    ''' </summary>
    Protected Sub ParentNotify()
        OnPaint()
    End Sub

    Private Sub OnSetFocus()
        OnPaint(True, False)
        OnTimer(False)
    End Sub

    Private Sub OnKillFocus()
        OnPaint(False, False)
    End Sub

    Private Sub OnMouseMove()
        If Not (Me.mouseOver) Then
            Dim down As Boolean = DroppedDown()
            Dim focusHandle As IntPtr = GetFocus()
            Dim focus As Boolean = (Me.Handle.Equals(focusHandle) Or _
                m_flatComboTextBox.Handle.Equals(focusHandle) Or _
                down)
            If Not (focus) Then
                OnPaint(True, False)
                Me.mouseOver = True
                mouseOverTimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub OnPaint()
        Dim down As Boolean = DroppedDown()
        Dim focusHandle As IntPtr = GetFocus()
        Dim focus As Boolean = (Me.Handle.Equals(focusHandle) Or _
            m_flatComboTextBox.Handle.Equals(focusHandle) Or _
            down)
        OnPaint(focus, down)
        If (focus) Then
            OnTimer(False)
        End If
    End Sub

    Private Sub OnPaint( _
        ByVal focus As Boolean, _
        ByVal down As Boolean _
        )

        If (focus) Then
            Dim clrTopLeft As Color
            Dim clrBottomRight As Color

            If (Me.Style = FlatControlStyle.FlatStyleOffice9) Then
                clrTopLeft = Color.FromKnownColor(KnownColor.ControlDark)
                clrBottomRight = Color.FromKnownColor(KnownColor.ControlLight)
            Else
                clrTopLeft = Color.FromKnownColor(KnownColor.Highlight)
                clrBottomRight = Color.FromKnownColor(KnownColor.Highlight)
            End If

            If (down) Then
                Draw(DrawStyle.FC_DRAWPRESSED, clrTopLeft, clrBottomRight)
            Else
                Draw(DrawStyle.FC_DRAWRAISED, clrTopLeft, clrBottomRight)
            End If

        Else
            If (Me.Style = FlatControlStyle.FlatStyleOffice9) Then
                Draw(DrawStyle.FC_DRAWNORMAL, _
                 Color.FromKnownColor(KnownColor.Control), _
                 Color.FromKnownColor(KnownColor.Control))
            Else
                Draw(DrawStyle.FC_DRAWNORMAL, _
                 Color.FromKnownColor(KnownColor.Window), _
                 Color.FromKnownColor(KnownColor.Window))
            End If
        End If

    End Sub


    Private Sub Draw( _
        ByVal drawStyle As DrawStyle, _
        ByVal clrTopLeft As Color, _
        ByVal clrBottomRight As Color _
        )

        Dim rcClient As RECT = New RECT
        Dim rcItem As Rectangle
        Dim rcWork As Rectangle
        Dim rcButton As Rectangle
        Dim hDC As IntPtr = IntPtr.Zero
        Dim focusHandle As IntPtr = IntPtr.Zero

        Dim enabled As Boolean = (IsWindowEnabled(Me.Handle) <> 0)
        Dim RightToLeft As Boolean = (IsRightToLeft(Me.Handle))

        GetClientRect(Me.Handle, rcClient)

        rcItem = New Rectangle(rcClient.left, rcClient.top, _
            rcClient.right - rcClient.left, rcClient.bottom - rcClient.top)

        hDC = GetDC(Me.Handle)
        Dim gfx As Graphics = Graphics.FromHdc(hDC)

        If Not (enabled) Then
            If (Me.m_style = FlatControlStyle.FlatStyleOffice9) Then
                Draw3DRect(gfx, rcItem, _
                    Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Control))
            Else
                Draw3DRect(gfx, rcItem, _
                    Color.FromKnownColor(KnownColor.ControlDark), Color.FromKnownColor(KnownColor.ControlDark))
            End If
            rcItem.Inflate(-1, -1)

            If (Me.m_style = FlatControlStyle.FlatStyleOffice9) Then
                Draw3DRect(gfx, rcItem, _
                  Color.FromKnownColor(KnownColor.ControlLight), Color.FromKnownColor(KnownColor.ControlLight))
            Else
                Draw3DRect(gfx, rcItem, _
                  Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Control))
            End If

        Else
            Draw3DRect(gfx, rcItem, clrTopLeft, clrBottomRight)
            rcItem.Inflate(-1, -1)

            If (Me.m_style = FlatControlStyle.FlatStyleOffice9) Then
                Draw3DRect(gfx, rcItem, _
                  Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Control))
            Else
                Draw3DRect(gfx, rcItem, _
                  Color.FromKnownColor(KnownColor.Window), Color.FromKnownColor(KnownColor.Window))
            End If
        End If


        If (Me.m_style = FlatControlStyle.FlatStyleOffice9) Then
            ' Cover up dark 3D shadow on drop arrow.
            rcButton = New Rectangle(rcItem.Location, rcItem.Size)
            rcButton.Inflate(-1, -1)
            If Not (RightToLeft) Then
                rcButton.X = rcButton.X + rcButton.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth()
            End If
            rcButton.Width = System.Windows.Forms.SystemInformation.HorizontalScrollBarThumbWidth()
            Draw3DRect(gfx, rcButton, _
                Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Control))

            ' Cover up normal 3D shadow on drop arrow.
            rcButton.Inflate(-1, -1)
            Draw3DRect(gfx, rcButton, _
                Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Control))

            If (enabled) Then
                Select Case (drawStyle)
                    Case drawStyle.FC_DRAWNORMAL
                        rcButton.Y -= 1
                        rcButton.Height += 1
                        Draw3DRect(gfx, rcButton, _
                            Color.FromKnownColor(KnownColor.ControlLight), Color.FromKnownColor(KnownColor.ControlLight))
                        rcButton.X -= 1
                        rcButton.Height = 0
                        Draw3DRect(gfx, rcButton, _
                            Color.FromKnownColor(KnownColor.Window), Color.Black)

                    Case drawStyle.FC_DRAWRAISED
                        rcButton.Y -= 1
                        rcButton.Height += 1
                        rcButton.Width += 1
                        Draw3DRect(gfx, rcButton, _
                            Color.FromKnownColor(KnownColor.ControlLight), Color.FromKnownColor(KnownColor.ControlDark))

                    Case drawStyle.FC_DRAWPRESSED
                        rcButton.X -= 1
                        rcButton.Y -= 2
                        rcButton.Offset(1, 1)
                        Draw3DRect(gfx, rcButton, _
                            Color.FromKnownColor(KnownColor.ControlDark), Color.FromKnownColor(KnownColor.ControlLight))
                End Select
            End If

        Else

            If Not (enabled) Then
                rcButton = New Rectangle(rcItem.Location, rcItem.Size)
                If (RightToLeft) Then
                    rcButton.Width = SystemInformation.VerticalScrollBarWidth() + 3
                Else
                    rcButton.X = rcButton.X + rcButton.Width - 1 - SystemInformation.VerticalScrollBarWidth()
                    rcButton.Width = SystemInformation.VerticalScrollBarWidth()
                End If
                gfx.FillRectangle( _
                  SystemBrushes.Control, rcButton)

                DrawComboDropDownGlyph(gfx, rcButton, Color.FromKnownColor(KnownColor.ControlDark))

            Else
                rcButton = New Rectangle(rcItem.Location, rcItem.Size)
                If Not (RightToLeft) Then
                    rcButton.X = rcButton.X + rcButton.Width - SystemInformation.VerticalScrollBarWidth()
                End If
                rcButton.Width = SystemInformation.VerticalScrollBarWidth()

                Dim brushColor As Color
                If ((drawStyle = drawStyle.FC_DRAWNORMAL) And Not (clrTopLeft.Equals(Color.FromKnownColor(KnownColor.ControlDark)))) Then
                    brushColor = Color.FromKnownColor(KnownColor.Control)
                ElseIf (drawStyle = drawStyle.FC_DRAWPRESSED) Then
                    brushColor = VSNetPressedColor()
                Else
                    brushColor = VSNetSelectionColor()
                End If

                Dim br As Brush = New SolidBrush(brushColor)
                gfx.FillRectangle(br, rcButton)
                br.Dispose()

                rcWork = New Rectangle(rcButton.Location, rcButton.Size)
                If (RightToLeft) Then
                    rcWork.X = rcWork.X + rcWork.Width
                Else
                    rcWork.X = rcButton.X
                End If
                rcWork.Width = 0

                If ((drawStyle = drawStyle.FC_DRAWNORMAL) And Not (clrTopLeft.Equals(Color.FromKnownColor(KnownColor.ControlLight)))) Then
                    Draw3DRect(gfx, rcWork, _
                       Color.FromKnownColor(KnownColor.Window), Color.FromKnownColor(KnownColor.Window))
                Else
                    Draw3DRect(gfx, rcWork, _
                        Color.FromKnownColor(KnownColor.Highlight), Color.FromKnownColor(KnownColor.Highlight))
                End If

                If (RightToLeft) Then
                    rcWork.X += 1
                Else
                    rcWork.X -= 1
                End If
                Draw3DRect(gfx, rcWork, _
                    Color.FromKnownColor(KnownColor.Window), Color.FromKnownColor(KnownColor.Window))

                DrawComboDropDownGlyph(gfx, rcButton, Color.FromKnownColor(KnownColor.WindowText))

            End If

        End If

        gfx.Dispose()
        ReleaseDC(Me.Handle, hDC)

    End Sub


    Private Sub Draw3DRect( _
        ByVal gfx As Graphics, _
        ByVal rcItem As Rectangle, _
        ByVal topLeftColor As Color, _
        ByVal bottomRightColor As Color _
         )

        Dim thePen As Pen = New Pen(topLeftColor, 1)
        gfx.DrawLine(thePen, rcItem.X, rcItem.Y + rcItem.Height - 1, _
         rcItem.X, rcItem.Y)
        gfx.DrawLine(thePen, rcItem.X, rcItem.Y, _
            rcItem.X + rcItem.Width - 1, rcItem.Y)
        thePen.Dispose()

        If (rcItem.Width <> 0) Then
            thePen = New Pen(bottomRightColor, 1)
            gfx.DrawLine(thePen, rcItem.X + rcItem.Width - 1, rcItem.Y, _
                 rcItem.X + rcItem.Width - 1, rcItem.Top + rcItem.Height - 1)
            gfx.DrawLine(thePen, rcItem.X + rcItem.Width - 1, rcItem.Top + rcItem.Height - 1, _
                rcItem.X, rcItem.Top + rcItem.Height - 1)
            thePen.Dispose()
        End If
    End Sub

    Private Sub DrawComboDropDownGlyph( _
        ByVal gfx As Graphics, _
        ByVal rcButton As Rectangle, _
        ByVal theColor As Color _
        )

        Dim xC As Integer = rcButton.X + (rcButton.Width / 2)
        Dim yC As Integer = rcButton.Y + (rcButton.Height / 2)

        Dim thePen As Pen = New Pen(theColor, 1)

        gfx.DrawLine(thePen, xC - 2, yC - 1, xC + 2, yC - 1)
        gfx.DrawLine(thePen, xC - 1, yC, xC + 1, yC)
        gfx.DrawLine(thePen, xC, yC - 1, xC, yC + 1)

        thePen.Dispose()

    End Sub

    Private Sub OnTimer(ByVal checkMouse As Boolean)

        Dim over As Boolean = False

        If (checkMouse) Then
            over = True
            Dim pt As Point = Cursor.Position()
            Dim rcItem As RECT = New RECT
            GetWindowRect(Me.Handle, rcItem)
            If ((pt.X < rcItem.left) Or (pt.X > rcItem.right)) Then
                over = False
            Else
                If ((pt.Y < rcItem.top) Or (pt.Y > rcItem.bottom)) Then
                    over = False
                End If
            End If
        End If

        If Not (over) Then
            mouseOverTimer.Enabled = False
            Me.mouseOver = False
        End If

    End Sub


    Private Function DroppedDown() As Boolean
        Dim ret As Boolean = False
        ret = (SendMessage( _
            Me.Handle, CB_GETDROPPEDSTATE, IntPtr.Zero, IntPtr.Zero) <> 0)
        DroppedDown = ret
    End Function


    '''
    ''' Constructs a new instance of Me object.
    '''
    Public Sub New()
        ' Intentionally blank
    End Sub

#End Region

#Region " FlatComboParent class "

    ''' <summary>
    ''' Internal class to perform subclassing on a
    ''' Combo Box's parent.  This is used to detect
    ''' drop-down events.
    ''' </summary>
    Private Class FlatComboParent
        Inherits NativeWindow

#Region " Unmanaged Code "

        Private Declare Function GetParent Lib "user32.dll" (ByVal hWnd As IntPtr) As IntPtr

#End Region

#Region " Member Variables "

        Private owner As FlatControl = Nothing
        Private parentHandle As IntPtr = IntPtr.Zero

#End Region

#Region " Methods "

        ''' <summary>
        ''' Attaches Me class to a Combo Box.
        ''' </summary>
        ''' <param name="comboBox">The Combo Box to attach to and make
        ''' flat.</param>
        Public Sub Attach( _
            ByVal comboBox As System.Windows.Forms.Control, _
            ByVal owner As FlatControl _
            )

            Me.owner = owner
            Dim handle As IntPtr = comboBox.Handle
            Me.parentHandle = GetParent(handle)
            Me.AssignHandle(Me.parentHandle)

        End Sub

        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

            If (m.Msg = WM_COMMAND) Then
                If (m.LParam.Equals(owner.Handle)) Then
                    Dim notifyType As Integer = m.WParam.ToInt32()
                    notifyType = notifyType / &H10000
                    If (notifyType = CBN_CLOSEUP) Then
                        owner.ParentNotify()
                    End If
                End If
            End If
            MyBase.WndProc(m)

        End Sub

        ''' <summary>
        ''' Constructs a new instance of Me class.
        ''' </summary>
        Public Sub New()
            ' Intentionally blank
        End Sub

#End Region

    End Class

#End Region

#Region " FlatComboTextBox class "

    ''' <summary>
    ''' Internal class to perform subclassing on the text
    ''' box within the Combo Box.
    ''' </summary>
    Private Class FlatComboTextBox
        Inherits NativeWindow

#Region " Unmanaged Code "

        Private Declare Function GetWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal wCmd As Integer) As IntPtr
        Private Const GW_CHILD As Integer = 5

#End Region

#Region " Member Variables "

        Private textBoxHandle As IntPtr = IntPtr.Zero
        Private owner As FlatControl = Nothing

#End Region

#Region " Methods "

        ''' <summary>
        ''' Attaches Me class to a Combo Box.
        ''' </summary>
        ''' <param name="comboBox">The Combo Box to attach to and make
        ''' flat.</param>
        Public Sub Attach( _
            ByVal comboBox As System.Windows.Forms.Control, _
            ByVal owner As FlatControl _
            )

            Me.owner = owner
            Dim handle As IntPtr = comboBox.Handle
            Me.textBoxHandle = GetWindow(handle, GW_CHILD)
            Me.AssignHandle(Me.textBoxHandle)

        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)

            MyBase.WndProc(m)
            Select Case (m.Msg)
                Case WM_SETFOCUS
                    owner.TextBoxNotify(WM_SETFOCUS)
                Case WM_KILLFOCUS
                    owner.TextBoxNotify(WM_KILLFOCUS)
                Case WM_MOUSEMOVE
                    owner.TextBoxNotify(WM_MOUSEMOVE)
            End Select

        End Sub

        ''' <summary>
        ''' Constructs a new instance of Me class.
        ''' </summary>
        Public Sub New()
            ' Intentionally blank
        End Sub

#End Region

    End Class

#End Region

#Region " Utility Methods "

    Private Sub RemoveTheme(ByVal handle As IntPtr)

        Dim isXp As Boolean = False
        If (System.Environment.Version.Major > 5) Then
            isXp = True
        ElseIf ((System.Environment.Version.Major = 5) And (System.Environment.Version.Minor >= 1)) Then
            isXp = True
        End If
        If (isXp) Then
            SetWindowTheme(handle, " ", " ")
        End If

    End Sub

    Private Function IsRightToLeft(ByVal handle As IntPtr) As Boolean

        Dim style As Integer = 0
        Dim ret As Boolean = False
        style = GetWindowLong(handle, GWL_EXSTYLE)
        ret = (((style And WS_EX_RIGHT) = WS_EX_RIGHT) Or _
            ((style And WS_EX_LEFTSCROLLBAR) = WS_EX_LEFTSCROLLBAR))
        IsRightToLeft = ret

    End Function

    Private Function BlendColor(ByVal colorFrom As Color, ByVal colorTo As Color, ByVal alpha As Integer) As Color

        BlendColor = Color.FromArgb( _
            ((colorFrom.R * alpha) / 255) + ((colorTo.R * (255 - alpha)) / 255), _
            ((colorFrom.G * alpha) / 255) + ((colorTo.G * (255 - alpha)) / 255), _
            ((colorFrom.B * alpha) / 255) + ((colorTo.B * (255 - alpha)) / 255) _
            )

    End Function

    Private Function VSNetControlColor() As Color
        VSNetControlColor = BlendColor( _
            Color.FromKnownColor(KnownColor.Control), _
            VSNetBackgroundColor(), _
            195)
    End Function

    Private Function VSNetBackgroundColor() As Color
        VSNetBackgroundColor = BlendColor( _
         Color.FromKnownColor(KnownColor.Window), _
         Color.FromKnownColor(KnownColor.Control), _
         220)
    End Function

    Private Function VSNetCheckedColor() As Color
        VSNetCheckedColor = BlendColor( _
            Color.FromKnownColor(KnownColor.Highlight), _
            Color.FromKnownColor(KnownColor.Window), _
            30)
    End Function

    Private Function VSNetBorderColor() As Color
        VSNetBorderColor = Color.FromKnownColor(KnownColor.Highlight)
    End Function

    Private Function VSNetSelectionColor() As Color
        VSNetSelectionColor = BlendColor( _
            Color.FromKnownColor(KnownColor.Highlight), _
            Color.FromKnownColor(KnownColor.Window), _
            70)
    End Function

    Private Function VSNetPressedColor() As Color
        VSNetPressedColor = BlendColor( _
         Color.FromKnownColor(KnownColor.Highlight), _
         VSNetSelectionColor(), _
         70)
    End Function

#End Region

#Region " Event handlers "

    Private Sub mouseOverTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles mouseOverTimer.Tick
        OnTimer(True)
        If Not (Me.mouseOver) Then
            OnPaint(False, False)
        End If
    End Sub

#End Region

End Class

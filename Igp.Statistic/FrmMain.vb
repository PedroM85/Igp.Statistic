Imports System.Runtime.InteropServices



Public Class FrmMain
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10


    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub



    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboard.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmDashboard)()
    End Sub

    Private Sub btnPiloto_Click(sender As Object, e As EventArgs) Handles btnPiloto.Click
        btnPiloto.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmPiloto)()
    End Sub

    Private Sub btnCircuito_Click(sender As Object, e As EventArgs) Handles btnCircuito.Click
        btnCircuito.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmCircuito)()
    End Sub

    Private Sub btnNacion_Click(sender As Object, e As EventArgs) Handles btnNacion.Click
        btnNacion.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmNacion)()
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        btnConfiguracion.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmConfiguracion)()
    End Sub

    Private Sub btnTemporada_Click(sender As Object, e As EventArgs) Handles btnTemporada.Click
        btnTemporada.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmTemporada)()
    End Sub

    Private Sub btnPosicion_Click(sender As Object, e As EventArgs) Handles btnPosicion.Click
        btnPosicion.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmPosicion)()
    End Sub

    Private Sub btnCampeonato_Click(sender As Object, e As EventArgs) Handles btnCampeonato.Click
        btnCampeonato.BackColor = Color.FromArgb(122, 181, 66)
        AbrirFormEnPanel(Of frmCampeonato)()
    End Sub




#End Region

    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    'METODO/EVENTO AL CERRAR FORMS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("frmDashboard") Is Nothing) Then
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmCampeonato") Is Nothing) Then
            btnCampeonato.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmCircuito") Is Nothing) Then
            btnCircuito.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmNacion") Is Nothing) Then
            btnNacion.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmPiloto") Is Nothing) Then
            btnPiloto.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmConfiguracion") Is Nothing) Then
            btnConfiguracion.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmTemporada") Is Nothing) Then
            btnTemporada.BackColor = Color.FromArgb(0, 0, 0)
        End If
        If (Application.OpenForms("frmPosicion") Is Nothing) Then
            btnPosicion.BackColor = Color.FromArgb(0, 0, 0)
        End If


    End Sub


    Private Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F12 Then
            frmMainLogon.Show()
        End If
    End Sub
End Class
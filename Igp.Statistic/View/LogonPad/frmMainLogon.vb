Public Class frmMainLogon
    Inherits Form

    Public Sub New()
        MyBase.New
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Dim OlogonSetsCol As Collection

    Private Sub Initialize()
        Dim oManager As ReadXML = New ReadXML
        Dim oCI As ConnectionInfo

        OlogonSetsCol = oManager.GetLogonSets

        lstConnections.DisplayMember = "Name"
        lstConnections.ValueMember = "Name"

        For Each oCI In OlogonSetsCol
            lstConnections.Items.Add(oCI)
        Next

        lblDefault.Text = oManager.GetDefaultConnection

        If lblDefault.Text = String.Empty Then
            lblDefault.Text = "No Definido"
        End If
    End Sub

    Private Sub OpenConnectionSetForm(ByVal connectioninfo As ConnectionInfo)
        Dim oConnSetForm As frmLogonPad = New frmLogonPad
        Dim lNew As Boolean
        Dim nI As Integer
        Dim oManager As ReadXML = New ReadXML

        oConnSetForm.ConnectionInfo = connectioninfo

        lNew = connectioninfo Is Nothing

        If oConnSetForm.ShowDialog(Me) = DialogResult.OK Then
            If lNew Then
                lstConnections.SelectedIndex = lstConnections.Items.Add(oConnSetForm.ConnectionInfo)
            Else
                nI = lstConnections.SelectedIndex
                lstConnections.Items.Remove(oConnSetForm.ConnectionInfo)
                lstConnections.Items.Insert(nI, oConnSetForm.ConnectionInfo)
                lstConnections.SelectedIndex = nI
            End If

            lblDefault.Text = oManager.GetDefaultConnection

            If lblDefault.Text = String.Empty Then
                lblDefault.Text = "No Definido."
            End If
        Else
            If lstConnections.Items.Count > 0 Then
                lstConnections.SelectedIndex = 0
                lstConnections.Focus()
                EnableButtons()
            End If
        End If

        lstConnections.Select()
        EnableButtons()
    End Sub

    Private Sub DeleteConnectionInfo()
        Dim oManager As ReadXML = New ReadXML

        oManager.DeleteConnectionInfo(lstConnections.SelectedItem)

        lstConnections.Items.Remove(lstConnections.SelectedItem)

        If lstConnections.Items.Count > 0 Then
            lstConnections.SelectedIndex = 0
        End If

        EnableButtons()
    End Sub

    Private Sub EnableButtons()
        btnEdit.Enabled = Not lstConnections.SelectedItem Is Nothing
        btnDelete.Enabled = btnEdit.Enabled
        btnLogin.Enabled = btnEdit.Enabled
        btnLoginPOS.Enabled = btnEdit.Enabled
        btnLoginEcom.Enabled = btnEdit.Enabled
    End Sub

    Private Sub HideLogonPad()
        Me.Close()

        'me.Hide 
        'Dim oBallon As NotifyBalloon = New NotifyBalloon

        'oBallon.ShowBalloon(niLogonPad, "Mensaje de Logon Pad", "La aplicación continua ejecutandose." & vbCrLf & "Para utilizarla haga clic con el botón secundario y presione 'Abrir'", 0, NotifyBalloon.NotifyStyle.Info)
    End Sub

    Private Sub btnLoginEcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginEcom.Click
        'LaunchEcom()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialize()
        If lstConnections.Items.Count > 0 Then
            lstConnections.SelectedIndex = 0
            lstConnections.Select()
            EnableButtons()
        Else
            btnNew.Select()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        OpenConnectionSetForm(Nothing)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        OpenConnectionSetForm(lstConnections.SelectedItem)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteConnectionInfo()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        HideLogonPad()
    End Sub

    Private Sub niLogonPad_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'LaunchManager()
    End Sub


    Private Sub btnLoginPOS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoginPOS.Click
        'LaunchPOS()
    End Sub

    Private Sub MainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(59, 95, 127), 4), New Rectangle(0, 0, Me.Width, Me.Height))
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Me.Show()
    End Sub

    Private Sub mnuClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Me.Close()

    End Sub

    Private Sub lstConnections_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstConnections.Click
        EnableButtons()
    End Sub

    Private Sub lstConnections_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstConnections.MouseDown
        If e.Clicks = 2 And e.Button = MouseButtons.Left Then
            Dim nI As Integer = lstConnections.IndexFromPoint(e.X, e.Y)

            If nI <> -1 Then
                lstConnections.SelectedIndex = nI
                'LaunchManager()
            End If
        End If
    End Sub
End Class
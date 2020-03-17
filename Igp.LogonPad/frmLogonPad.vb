'Public Class frmLogonPad
'    Inherits Form

'    Private oConnInfo As ConnectionInfo
'    Private sOriginalName As String

'    Public Sub New()

'        ' This call is required by the designer.
'        InitializeComponent()

'        ' Add any initialization after the InitializeComponent() call.

'    End Sub


'    Public Property ConnectionInfo() As ConnectionInfo
'        Get
'            Return oConnInfo
'        End Get
'        Set(value As ConnectionInfo)
'            oConnInfo = value
'        End Set
'    End Property

'    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
'        Dim oManager As ReadXML = New ReadXML
'        Dim lisNew As Boolean = False

'        If IsOk() Then
'            If oConnInfo Is Nothing Then
'                oConnInfo = New ConnectionInfo
'                lisNew = True
'            End If

'            With oConnInfo
'                .Database = txtDatabase.Text
'                .DefaultConnection = chkDefault.Checked
'                .Name = txtName.Text
'                .Password = txtPassword.Text
'                .Server = txtServer.Text
'                .User = txtUser.Text

'            End With

'            If lisNew Then
'                oManager.AddConnection(txtName.Text, txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text, chkDefault.Checked)
'            Else
'                oManager.EditConnectionInfo(sOriginalName, oConnInfo)
'            End If

'            Me.DialogResult = DialogResult.OK
'        End If

'    End Sub

'    Private Sub ConnectionSetForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim oManager As New ReadXML

'        If Not oConnInfo Is Nothing Then
'            With oConnInfo
'                sOriginalName = .Name
'                txtName.Text = .Name
'                txtServer.Text = .Server
'                txtDatabase.Text = .Database
'                txtUser.Text = .User
'                txtPassword.Text = .Password
'                chkDefault.Checked = .DefaultConnection
'            End With
'        End If

'        oManager = Nothing
'    End Sub

'    Private Sub ConnectionSetForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

'        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(59, 95, 127), 4), New Rectangle(0, 0, Me.Width, Me.Height))

'    End Sub

'    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
'        Close()
'    End Sub

'#Region " Procedures "
'    Private Function IsOk() As Boolean
'        If txtName.Text = String.Empty Then
'            lblError.Text = "Debe indicar un nombre."
'            txtName.Focus()
'            Return False
'        End If

'        If txtServer.Text = String.Empty Then
'            lblError.Text = "Debe indicar un servidor."
'            txtServer.Focus()
'            Return False
'        End If

'        If txtDatabase.Text = String.Empty Then
'            lblError.Text = "Debe indicar una base de datos."
'            txtDatabase.Focus()
'            Return False
'        End If

'        If txtUser.Text = String.Empty Then
'            lblError.Text = "Debe indicar un usuario."
'            txtUser.Focus()
'            Return False
'        End If

'        If oConnInfo Is Nothing Then
'            If NameExist() Then
'                lblError.Text = "El nombre de la conexión ya existe."
'                txtUser.Focus()
'                Return False

'            End If
'        End If

'        Return True
'    End Function

'    Private Function NameExist() As Boolean
'        Dim oManager As ReadXML = New ReadXML

'        Return oManager.NameExist(txtName.Text)

'    End Function
'#End Region

'    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
'        'ewave.Tools.KeyFilter.FilterKeyText(sender, e)
'    End Sub

'End Class
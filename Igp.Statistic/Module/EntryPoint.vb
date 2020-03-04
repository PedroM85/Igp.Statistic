Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades

Module entrepoint
    Public oConn As New AccessControl.ConnectionInfo
    Public oAppPAR As Parameters
    Public AppPar As New ParameterEntity



    Public Sub Main()


        'oConn = New AccessControl.ConnectionInfo
        If oConn.GetConnectionInfo() Then
            oAppPAR = New Parameters
            AppPar.npiloto = oAppPAR.GetValue("NPILOTO")

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)


            '=================================================
            'Esto es para el sistema de login

            'Dim login As frmLogin = New frmLogin
            'login.ShowDialog()

            'Sistema de Login
            'If (login.DialogResult = DialogResult.OK) Then

            Application.Run(New FrmMain)

            'End If
            '=================================================
        Else
            'gWrkDialog.Close()
            'oApp.LogFile.LogEvent("No hay información de conexión a la aplicación")
            'POSMessageBox.Show("No se encontró la información de conexión de la aplicación.", "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Run(New frmMainLogon)

            'MessageBox.Show("No se encontró la información de conexión de la aplicación.", "IgpManager", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



        ' ThisIsTheEndMyFriend()
    End Sub



    Private Sub ThisIsTheEndMyFriend()
        ' oApp.LogFile.EndLog()
        'oApp.ExitFW()
        End
    End Sub



End Module

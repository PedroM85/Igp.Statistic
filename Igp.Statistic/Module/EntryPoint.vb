
Imports Igp.EventLog
Imports Igp.POSResources.CommonManagers
Imports IgpManager.BACK

Module entrepoint
    Public oApp As WindowsFramework

    Friend gWrkDialog As WorkingDialog
    Public Sub Main()

        oApp = New WindowsFramework

        'Importante, setear tipo de db
        Igp.DataAccessFactory.DALObjects.ProviderType = Igp.DataAccessFactory.DALObjects.DataProviderType.OleDb

        oApp.StartLog(Application.StartupPath)

        Dim InitError As String = Nothing
        'oConn = New AccessControl.ConnectionInfo
        If oApp.GetConnectionInfo() Then
            If oApp.InitConnection(Igp.POSResources.SysModule.IgpManager, True) Then
                If oApp.Init(InitError) Then




                    '        oAppPAR = New Parameters
                    '        AppPar.npiloto = oAppPAR.GetValue("NPILOTO")

                    Application.EnableVisualStyles()
                    Application.SetCompatibleTextRenderingDefault(False)


                    '=================================================
                    'Esto es para el sistema de login

                    'Dim login As frmLogin = New frmLogin
                    'login.ShowDialog()

                    'Sistema de Login
                    'If (login.DialogResult = DialogResult.OK) Then

                    Application.Run(New FrmMain)

                End If
                '=================================================
            Else
                MessageBox.Show("Se produjeron errores al inicializar la aplicación." & vbLf & "Compruebe la información de conexión o contáctese con el administrador del sistema.", "IgpManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'gWrkDialog.Close()
            'oApp.LogFile.LogEvent("No hay información de conexión a la aplicación")
            'POSMessageBox.Show("No se encontró la información de conexión de la aplicación.", "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Application.Run(New frmMainLogon)

            'MessageBox.Show("No se encontró la información de conexión de la aplicación.", "IgpManager", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If




        ThisIsTheEndMyFriend()
    End Sub



    Private Sub ThisIsTheEndMyFriend()
        ' oApp.LogFile.EndLog()
        'oApp.ExitFW()
        End
    End Sub



End Module

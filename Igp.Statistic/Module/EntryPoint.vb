
Imports Igp.EventLog
Imports Igp.POSResources.CommonManagers
Imports IgpManager.BACK

Module entrepoint
    Public oApp As WindowsFramework

    Public gMainMenuForm As FrmMain
    Friend gWrkDialog As WorkingDialog
    Public Sub Main()

        oApp = New WindowsFramework

        gWrkDialog = New WorkingDialog

        'Importante, setear tipo de db
        Igp.DataAccessFactory.DALObjects.ProviderType = Igp.DataAccessFactory.DALObjects.DataProviderType.OleDb

        oApp.StartLog(Application.StartupPath)

        Dim InitError As String = Nothing
        'oConn = New AccessControl.ConnectionInfo
        If oApp.GetConnectionInfo() Then
            If oApp.PrevInstance Then
                gWrkDialog.Close()
                oApp.LogFile.LogEvent("Instancia abierta existente.")
                POSMessageBox.Show("Ya existe una instancia abierta de esta aplicación.", "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If oApp.InitConnection(Igp.POSResources.SysModule.IgpManager, True) Then

                    If oApp.CheckIfTerminalRegistered Then
                        If oApp.Init(InitError) Then


                            'If oApp.HasLicensesFree Then

                            gMainMenuForm = New FrmMain

                                gWrkDialog.Close()
                                Application.DoEvents()

                                gMainMenuForm.Show()
                                oApp.LogFile.LogEvent("Running...")
                                ' [180405] Se oculta puntero
                                'Cursor.Hide() '26-12-11 Se muestra el puntero
                                Try
                                    Application.Run(gMainMenuForm)
                                Catch ex As Exception
                                    POSMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    oApp.LogFile.LogExcepton(ex)
                                End Try

                            ' Else
                            'oApp.LogFile.LogEvent("No hay licencias disponibles.")
                            'POSMessageBox.Show(EP_MSG1, "Unelca", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'End If


                        Else
                            gWrkDialog.Close()
                            oApp.LogFile.LogEvent(String.Format("Initialization Error: {0}", InitError))
                            POSMessageBox.Show(String.Format(EP_MSG4 + ": {0}", InitError), "Unelca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        gWrkDialog.Close()
                        oApp.LogFile.LogEvent("No hay información de la terminal en el Registry.")
                        POSMessageBox.Show("No se encuentra la información correspondiente a la terminal en la Registry de Windows.", "Unelca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    gWrkDialog.Close()
                    oApp.LogFile.LogEvent("Error en la inicialización de la conexión.")
                    POSMessageBox.Show("Se produjeron errores al inicializar la aplicación." & vbCrLf & "Compruebe la información de conexión o contáctese con el administrador del sistema.", "Unelca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            gWrkDialog.Close()
            oApp.LogFile.LogEvent("No hay información de conexión a la aplicación")
            POSMessageBox.Show("No se encontró la información de conexión de la aplicación.", "Unelca", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If




        ThisIsTheEndMyFriend()
    End Sub



    Private Sub ThisIsTheEndMyFriend()
        ' oApp.LogFile.EndLog()
        'oApp.ExitFW()
        End
    End Sub



    Private EP_MSG1 As String
    Private EP_MSG2 As String
    Private EP_MSG3 As String
    Private EP_MSG4 As String
    Private EP_MSG5 As String
    Private EP_MSG6 As String

    Public Sub LoadGlobalCaptionsConstants()
        EP_MSG1 = oApp.GlobalResources.GetString("EP_MSG1", "No hay mas licencias disponibles.")
        EP_MSG2 = oApp.GlobalResources.GetString("EP_MSG2", "El usuario se encuentra bloqueado, consulte al administrador.")
        EP_MSG3 = oApp.GlobalResources.GetString("EP_MSG3", "El usuario ha expirado y no puede ingresar a la aplicación.")
        EP_MSG4 = oApp.GlobalResources.GetString("EP_MSG4", "Se produjeron errores al inicializar la aplicación")
        EP_MSG5 = oApp.GlobalResources.GetString("EP_MSG5", "Se produjo un error al intentar iniciar sesión")
        EP_MSG6 = oApp.GlobalResources.GetString("EP_MSG6", "El usuario no está habilitado para utilizar Manager")
    End Sub

End Module

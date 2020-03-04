Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Igp.AccessControl
Imports Igp.AccessControl.Entidades

Module entrepoint

    Public oAppPAR As Parameters
    Public AppPar As New ParameterEntity



    Public Sub Main()



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
    End Sub







End Module

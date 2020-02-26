Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Igp.AccessControl

Module entrepoint

    Public oAppPAR As Parameters



    Public Sub Main()
        oAppPAR = New Parameters

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        'If oAppPAR.GetValue("NPILOTO") = "S" And oAppPAR.newsession Then
        'If oAppPAR.GetValue("NPILOTO") = "N" Then
        'MsgBox(oAppPAR.GetValue("NPILOTO"))
        '        MsgBox(oAppPAR.GetValue("NPILOTO").ToString)
        Application.Run(FrmMain)
        ''End If




    End Sub


End Module

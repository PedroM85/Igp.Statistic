Public Class WindowsFramework
    Inherits AccessControl.FrameworkBase

    Public Sub New()
        MyBase.New(AccessControl.SysModule.IgpManager)
    End Sub

    'Public Overrides Function CheckIfPasswordMustBeChanged() As Boolean

    '    Dim cmd As Data.OleDb.OleDbCommand = mConn.CreateCommand

    '    If (mUser.PasswordExpired = True And mConnected) OrElse (mUser.InitialChangePassword = True And mConnected) Then
    '        Try

    '            Dim oPassword As New PasswordChange(True)
    '            oPassword.UserId = mUser.Id

    '            If oPassword.ShowDialog = DialogResult.Cancel Then
    '                Return False
    '            End If

    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.CommandText = "USR_UpdatePasswordExpiryDate"

    '            cmd.Parameters.Add("@USR_Id", OleDb.OleDbType.Char, 20).Value = mUser.Id
    '            cmd.Parameters.Add("@USR_PasswordExpiryDate", OleDb.OleDbType.Date).Value = Today.AddDays(Me.Parameters.GetValue("PWDEXPIRE"))
    '            cmd.Parameters.Add("@USR_InitialChange", OleDb.OleDbType.Boolean).Value = False

    '            cmd.ExecuteNonQuery()

    '            Return True
    '        Catch oEx As Exception
    '            POSMessageBox.Show(oEx.Message, , MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return False
    '        Finally
    '            cmd.Dispose()
    '        End Try
    '    Else
    '        Return True
    '    End If

    'End Function

    'Public Overrides Sub HideMessagePopup()
    '    If Not IsNothing(mMsgPopup) Then
    '        mMsgPopup.Close() 'oMsgPopup.Dispose()
    '        mMsgPopup = Nothing
    '    End If
    'End Sub

    'Public Overrides Function UserHasSecurityLevelFromParameter(ByVal Paramstr As String) As Boolean
    '    Dim seclevel As Integer = CType(Parameters(Paramstr), Integer)
    '    Return User.SecurityLevel.Id <= seclevel

    'End Function

    'Public Overloads Function UserHasSecurityLevelFromParameter(ByVal Paramstr As String, ByVal showError As Boolean) As Boolean
    '    Dim rtn As Boolean = UserHasSecurityLevelFromParameter(Paramstr)
    '    If Not rtn And showError Then
    '        POSMessageBox.Show("No posee suficiente nivel de acceso para completar esta acción", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Function

    'Public Overrides Function CheckUserSecLevelAndAsk(ByVal ParamStr As String) As Boolean
    '    If UserHasSecurityLevelFromParameter(ParamStr) Then
    '        Return True
    '    Else
    '        Return AskForAuthorisation(CType(Parameters(ParamStr), Integer))
    '    End If
    'End Function

    'Public Overrides Function AskForAuthorisation(ByVal nAuthLevelRequested As Integer) As Boolean
    '    Dim sec As ewave.AccessController.SecurityManager = New ewave.AccessController.SecurityManager(mConn)
    '    Dim auth As New AuthorisationForm

    '    Dim result As DialogResult = auth.ShowDialog()

    '    If result = DialogResult.OK Then
    '        If sec.HasAuthorisationBy(mUser.Id, nAuthLevelRequested, auth.txtUser.Text, auth.txtPassword.Text) = "OK" Then
    '            mAudit.AddEntry(ewave.AccessController.AuditLogWriter.EventType.Authorisation, mUser.Id, mTerminalId, auth.txtUser.Text)
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Else
    '        Return False
    '    End If
    'End Function

    'Public Overrides Function InitPrinters() As Boolean
    '    If MyBase.InitPrinters() Then
    '        Try
    '            mFiscalPrinter.Open()

    '            mFPMgr = New eboc.BACK.FiscalPrinterManager
    '            If mFPMgr.FixFiscalPrinterStatus(True) Then
    '                If mFPMgr.FixFiscalPrinterFiscalStatus() Then
    '                    'Termino todos los docs empezados
    '                    mFiscalPrinter.EndAllDocuments()

    '                    Return True
    '                Else
    '                    Return False
    '                End If
    '            Else
    '                Return False
    '            End If

    '        Catch ex As Exception
    '            Return False
    '        Finally
    '            mFiscalPrinter.Close()
    '        End Try
    '    Else
    '        Return False
    '    End If
    'End Function

    'Protected Overrides Sub ShowMessage(ByVal Message As String)
    '    POSMessageBox.Show(Message, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub

    'Public Overrides Sub ShowException(ByVal Ex As Exception)
    '    POSMessageBox.Show(Ex.Message, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub

    'Public Overrides Sub PopMessage(ByVal Message As String, ByVal caption As String, ByVal iconError As Boolean)
    '    Dim icn As MessageBoxIcon
    '    If icn Then
    '        icn = MessageBoxIcon.Error
    '    Else
    '        icn = MessageBoxIcon.Information
    '    End If

    '    POSMessageBox.Show(Message, caption, MessageBoxButtons.OK, icn)
    'End Sub

    'Public Overrides Function PopAskMessage(ByVal Message As String, ByVal caption As String) As Boolean
    '    Return POSMessageBox.Show(Message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    'End Function

    'Public Overrides Sub NewInstantMessage()
    '    Dim msgWin As New MessageDialog
    '    msgWin.ShowDialog()
    '    msgWin.Dispose()
    'End Sub

    'Public Overrides Sub NewDeposit()
    '    If Me.mUser.SecurityLevel.Id <= mParams.GetValue("AUTHDEPLVL") OrElse
    '       oApp.AskForAuthorisation(mParams.GetValue("AUTHDEPLVL")) Then
    '        Dim depWin As New DepositDialog
    '        depWin.Location = Point.op_Addition(depWin.Location, Point.op_Explicit(gMainMenuForm.Location))
    '        depWin.ShowDialog()
    '        depWin.Dispose()
    '    Else
    '        POSMessageBox.Show(BACK.EnvironmentObjects.Msg_Err_AuthError, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    'Public Overrides Function GetAmountFromCalculator() As Double
    '    Dim cashCalc As New CashCalculatorDialog
    '    cashCalc.Location = Point.op_Addition(cashCalc.Location, Point.op_Explicit(gMainMenuForm.Location))
    '    cashCalc.ShowDialog()
    '    Dim amount As Double = cashCalc.GetTotalAmount
    '    cashCalc.Dispose()

    '    Return amount
    'End Function

    Public Overrides Sub ExecuteCalculator()
        '    Process.Start(Environment.SystemDirectory & "\calc.exe")
        Process.Start("calc.exe")
    End Sub

    Public Sub SayYes()
        Beep()
    End Sub

    Public Sub SayNo()
        Beep()
        Threading.Thread.Sleep(150)
        Beep()
    End Sub

    'Private Sub FPMgr_OnMessageBoxShow(ByVal Text As String, ByVal Buttons As System.Windows.Forms.MessageBoxButtons, ByVal Icon As System.Windows.Forms.MessageBoxIcon, ByVal DefaultButton As System.Windows.Forms.MessageBoxDefaultButton, ByRef DialogResult As System.Windows.Forms.DialogResult) Handles mFPMgr.OnMessageBoxShow
    '    DialogResult = POSMessageBox.Show(Text, "e-wave", Buttons, Icon, DefaultButton)
    'End Sub

    'Public Overrides Sub ShowWorkingDialog(ByVal message As String)
    '    gWrkDialog.Show()
    '    gWrkDialog.Message = message
    '    Application.DoEvents()
    'End Sub

    'Public Overrides Sub HideWorkingDialog(ByVal ShouldClose As Boolean)
    '    If ShouldClose Then
    '        gWrkDialog.Close()
    '    Else
    '        gWrkDialog.Hide()
    '    End If

    'End Sub

    'Public Overrides Function CheckIfTerminalRegistered() As Boolean
    '    Dim termOk As Boolean

    '    mTerminalId = ewave.TerminalConfig.DataLayer.GetTerminalInRegistry()

    '    If mTerminalId = "" Then
    '        Dim oTermConfig As New TerminalConfigDialog

    '        If oTermConfig.ShowDialog() = DialogResult.OK Then
    '            mTerminalId = ewave.TerminalConfig.DataLayer.GetTerminalInRegistry()
    '            termOk = True
    '        Else
    '            termOk = False
    '        End If

    '    Else
    '        termOk = True
    '    End If

    '    Return termOk
    'End Function

    'Public Function GetExternalIdTypes() As DataTable

    '    Dim cmd As OleDb.OleDbCommand = mConn.CreateCommand
    '    Dim adp As OleDb.OleDbDataAdapter
    '    Dim externalIdTypes As New DataTable

    '    Try

    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "ETY_GetActive"

    '        adp = New OleDb.OleDbDataAdapter(cmd)
    '        adp.Fill(externalIdTypes)

    '        If externalIdTypes.Rows.Count = 0 Then
    '            Throw New Exception("External id types don't found, check if STD_ExternalIdType not is empty.")
    '        End If

    '    Catch ex As Exception
    '        POSMessageBox.Show(ex.Message, "e-wave", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '    Return externalIdTypes

    'End Function




End Class

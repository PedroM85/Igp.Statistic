Imports System.Drawing.Printing

Public Class ConfigControl
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        ' LoadGlobalCaptions()

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents dsTerminal As Igp.TerminalConfig.TerminalDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboWindowsPrinter As System.Windows.Forms.ComboBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.dsTerminal = New Igp.TerminalConfig.TerminalDataSet()
        Me.cboWindowsPrinter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dsTerminal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(112, 32)
        Me.txtName.MaxLength = 60
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(256, 19)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(8, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(104, 19)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Nombre:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCode
        '
        Me.lblCode.Location = New System.Drawing.Point(8, 8)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(104, 19)
        Me.lblCode.TabIndex = 6
        Me.lblCode.Text = "Código:"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Enabled = False
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(112, 8)
        Me.txtCode.MaxLength = 5
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(72, 19)
        Me.txtCode.TabIndex = 0
        '
        'dsTerminal
        '
        Me.dsTerminal.DataSetName = "TerminalDataSet"
        Me.dsTerminal.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dsTerminal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboWindowsPrinter
        '
        Me.cboWindowsPrinter.BackColor = System.Drawing.Color.White
        Me.cboWindowsPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWindowsPrinter.ForeColor = System.Drawing.Color.Black
        Me.cboWindowsPrinter.Location = New System.Drawing.Point(112, 104)
        Me.cboWindowsPrinter.Name = "cboWindowsPrinter"
        Me.cboWindowsPrinter.Size = New System.Drawing.Size(256, 21)
        Me.cboWindowsPrinter.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Impresora Windows:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConfigControl
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.cboWindowsPrinter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "ConfigControl"
        Me.Size = New System.Drawing.Size(376, 376)
        CType(Me.dsTerminal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Instance variables "

    Private oDataLayer As DataLayer
    Private oTranslatedResources As Igp.GlobalResourcesEngine.ResourceLoader

    'Dim oFiscalPrinters As New ewave.FiscalPrinter.PrinterControllerFactory
    'Dim oPOSPrinters As New TicketPrinter.PrinterControllerFactory
    Dim dsFiscalPrinters As New DataTable
    Dim dsPOSPrinters As New DataTable
    Dim dsStockLocation As New TerminalDataSet
    Dim bValidData As Boolean

    Dim mDataload As DataLoadMode = DataLoadMode.Default
    Public Enum DataLoadMode
        [Default]
        Minimun
    End Enum

#End Region

#Region " Event handlers "

    Private Sub ConfigControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oFlatComboBox As FlatControl

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboPrinterPOS)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboPrinterFiscal)

        oFlatComboBox = New FlatControl
        oFlatComboBox.Attach(cboWindowsPrinter)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboLocation)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboStockLocation)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboPOSDesign)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboParallelPort)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboParallelPortPOS)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboSerialPort)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboSerialPortPOS)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboBauds)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboBaudsPOS)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboDataBits)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboDataBitsPOS)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboParity)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboParityPOS)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboStopBits)

        'oFlatComboBox = New FlatControl
        'oFlatComboBox.Attach(cboStopBitsPOS)

        'pnlFiscal.Top = 152

    End Sub

    'Private Sub cboStockLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStockLocation.SelectedIndexChanged

    '    If Me.cboStockLocation.Text = String.Empty Then
    '        ValidData = False
    '    Else
    '        ValidData = True
    '    End If

    'End Sub

#Region " - POS Printer "

    'Private Sub cboPrinterPOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cboPrinterPOS.SelectedIndex <> -1 AndAlso dsPOSPrinters.Rows(cboPrinterPOS.SelectedIndex).Item("ShowParams") = False Then
    '        optParallelPOS.Visible = False
    '        optParallelPOS.Checked = False
    '        optSerialPOS.Visible = False
    '        optSerialPOS.Checked = False
    '    Else
    '        optSerialPOS.Visible = True
    '        optParallelPOS.Visible = True
    '    End If
    'End Sub

    'Private Sub optSerialPOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If optSerialPOS.Checked = True Then
    '        pnlSerialPOS.Top = 152
    '        pnlSerialPOS.Visible = True
    '        pnlParallelPOS.Visible = False
    '        pnlFiscal.Top = 224
    '        pnlSerialFiscal.Top += 72
    '        pnlParallelFiscal.Top += 72
    '    Else
    '        pnlSerialPOS.Visible = False
    '        pnlFiscal.Top = 152
    '        pnlSerialFiscal.Top -= 72
    '        pnlParallelFiscal.Top -= 72
    '    End If

    'End Sub

    'Private Sub optParallelPOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If optParallelPOS.Checked = True Then
    '        pnlParallelPOS.Top = 152
    '        pnlParallelPOS.Visible = True
    '        pnlSerialPOS.Visible = False
    '        pnlFiscal.Top = 176
    '        pnlSerialFiscal.Top += 24
    '        pnlParallelFiscal.Top += 24
    '    Else
    '        pnlParallelPOS.Visible = False
    '        pnlFiscal.Top = 152
    '        pnlSerialFiscal.Top -= 24
    '        pnlParallelFiscal.Top -= 24
    '    End If
    'End Sub

#End Region

#Region " - Fiscal Printer "

    'Private Sub cboPrinterFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cboPrinterFiscal.SelectedIndex <> -1 AndAlso dsFiscalPrinters.Rows(cboPrinterFiscal.SelectedIndex).Item("ShowParams") = False Then
    '        optSerialFiscal.Visible = False
    '        optParallelFiscal.Visible = False
    '        optSerialFiscal.Checked = False
    '        optParallelFiscal.Checked = False
    '    Else
    '        optSerialFiscal.Visible = True
    '        optParallelFiscal.Visible = True
    '    End If
    'End Sub

    'Private Sub optSerialFiscal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If optSerialFiscal.Checked = True Then
    '        pnlSerialFiscal.Visible = True
    '        pnlSerialFiscal.Top = pnlFiscal.Top + 24
    '        pnlParallelFiscal.Visible = False
    '    Else
    '        pnlSerialFiscal.Visible = False
    '    End If
    'End Sub

    'Private Sub optParallelFiscal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If optParallelFiscal.Checked = True Then
    '        pnlParallelFiscal.Visible = True
    '        pnlParallelFiscal.Top = pnlFiscal.Top + 24
    '        pnlSerialFiscal.Visible = False
    '    Else
    '        pnlParallelFiscal.Visible = False
    '    End If
    'End Sub

#End Region

#End Region

#Region " Properties "

    Public WriteOnly Property TerminalId() As String
        Set(ByVal Value As String)
            txtCode.Text = Value
            LoadData(Value)
        End Set
    End Property

    Public WriteOnly Property DataLayer() As DataLayer
        Set(ByVal Value As DataLayer)
            oDataLayer = Value
        End Set
    End Property

    Public Property ValidData() As Boolean
        Get
            Return bValidData
        End Get
        Set(ByVal Value As Boolean)
            bValidData = Value
        End Set
    End Property

    Public Property DataLoad() As DataLoadMode
        Get
            Return mDataload
        End Get
        Set(ByVal Value As DataLoadMode)
            mDataload = Value
        End Set
    End Property



#End Region

#Region " Methods "

    Private Sub LoadData(ByVal sTerminalId As String)

        ''Impresora Pos
        'dsPOSPrinters = ewave.TicketPrinter.PrinterControllerFactory.GetPrinterDataTable
        'cboPrinterPOS.DataSource = dsPOSPrinters
        'cboPrinterPOS.ValueMember = "Code"
        'cboPrinterPOS.DisplayMember = "Description"

        ''Impresora Fiscal
        'dsFiscalPrinters = ewave.FiscalPrinter.PrinterControllerFactory.GetPrinterDataTable
        'cboPrinterFiscal.DataSource = dsFiscalPrinters
        'cboPrinterFiscal.ValueMember = "Code"
        'cboPrinterFiscal.DisplayMember = "Description"

        ' oDataLayer.FillLocation(dsTerminal, mDataload)
        ' oDataLayer.FillPOSDesign(dsTerminal, mDataload)
        ' oDataLayer.FillStockLocation(dsStockLocation, mDataload)

        'deshabilito estos combos si se carga minimo
        'If mDataload = DataLoadMode.Minimun Then
        '    cboPOSDesign.Enabled = False
        '    cboLocation.Enabled = False
        '    cboStockLocation.Enabled = False
        'End If

        'cboStockLocation.DataSource = dsStockLocation.CON_Location
        'cboStockLocation.ValueMember = "LCT_Id"
        'cboStockLocation.DisplayMember = "LCT_Description"

        'Si el terminal Id es distinto a lo que hay en el registro quiere
        'decir que se esta editando otra terminal, deshabilito la conf de impresora windows
        If sTerminalId = Igp.TerminalConfig.DataLayer.GetTerminalInRegistry Then
            ' Impresora Windows para tickets dcofre 19/9/2005
            Dim i As Integer
            cboWindowsPrinter.Items.Add(DBNull.Value)
            For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
                cboWindowsPrinter.Items.Add(PrinterSettings.InstalledPrinters.Item(i))
            Next
            cboWindowsPrinter.SelectedIndex = 0
        Else
            cboWindowsPrinter.Enabled = False
        End If


        If sTerminalId <> "" Then
            Dim sName As String = String.Empty
            Dim nLocationId As Integer
            Dim nStockLocation As Integer
            Dim nPOSDesignerId As Integer
            Dim sPrinter As String = String.Empty
            Dim sPrinterConnectionType As String = String.Empty
            Dim sPrinterConnectionParameters As String = String.Empty
            Dim sPOSCode As String = String.Empty
            Dim sWindowsPrinter As String = String.Empty
            Dim sFiscalPrinter As String = String.Empty
            Dim sFiscalPrinterConnectionType As String = String.Empty
            Dim sFiscalPrinterConnectionParameters As String = String.Empty


            oDataLayer.GetTerminal(sTerminalId, sName, nLocationId, sPrinter, sPrinterConnectionType, sPrinterConnectionParameters, nPOSDesignerId, sPOSCode, sFiscalPrinter, sFiscalPrinterConnectionType, sFiscalPrinterConnectionParameters, sWindowsPrinter, nStockLocation)

            txtCode.Enabled = False

            txtName.Text = sName
            'txtPOSCode.Text = sPOSCode

            'cboLocation.SelectedValue = nLocationId
            'cboStockLocation.SelectedValue = nStockLocation
            'cboPOSDesign.SelectedValue = nPOSDesignerId

            If cboWindowsPrinter.Enabled Then
                cboWindowsPrinter.SelectedValue = sWindowsPrinter
            End If

            'For i = 0 To cboWindowsPrinter.Items.Count - 1
            '    If (Not cboWindowsPrinter.Items(i) Is DBNull.Value) AndAlso cboWindowsPrinter.Items(i) = sWindowsPrinter Then
            '        cboWindowsPrinter.SelectedIndex = i
            '        Exit For
            '    End If
            'Next

            'cboPrinterPOS.SelectedValue = sPrinter.Trim
            'optParallelPOS.Checked = (sPrinterConnectionType = "P")

            'If sPrinterConnectionType = "S" Then
            '    optSerialPOS.Checked = True
            '    Dim sParams() As String = sPrinterConnectionParameters.Split(",")

            '    cboSerialPortPOS.SelectedItem = sParams(0)
            '    cboBaudsPOS.SelectedItem = sParams(1)
            '    cboDataBitsPOS.SelectedItem = sParams(2)
            '    Select Case sParams(3)
            '        Case "N"
            '            cboParityPOS.SelectedItem = "None"
            '        Case "E"
            '            cboParityPOS.SelectedItem = "Even"
            '        Case "O"
            '            cboParityPOS.SelectedItem = "Odd"
            '        Case "M"
            '            cboParityPOS.SelectedItem = "Mark"
            '    End Select
            '    cboStopBitsPOS.SelectedItem = sParams(4)
            'End If

            'If sPrinterConnectionType = "P" Then
            '    optParallelPOS.Checked = True
            '    cboParallelPortPOS.SelectedItem = sPrinterConnectionParameters
            'End If


            '' Impresora fiscal [AMI130405]
            'cboPrinterFiscal.SelectedValue = sFiscalPrinter.Trim
            'optParallelFiscal.Checked = (sFiscalPrinterConnectionType = "P")

            'If sFiscalPrinterConnectionType = "S" Then
            '    optSerialFiscal.Checked = True
            '    Dim sFiscalParams() As String = sFiscalPrinterConnectionParameters.Split(",")

            '    cboSerialPort.SelectedItem = sFiscalParams(0)
            '    cboBauds.SelectedItem = sFiscalParams(1)
            '    cboDataBits.SelectedItem = sFiscalParams(2)
            '    Select Case sFiscalParams(3)
            '        Case "N"
            '            cboParity.SelectedItem = "None"
            '        Case "E"
            '            cboParity.SelectedItem = "Even"
            '        Case "O"
            '            cboParity.SelectedItem = "Odd"
            '        Case "M"
            '            cboParity.SelectedItem = "Mark"
            '    End Select
            '    cboStopBits.SelectedItem = sFiscalParams(4)
            'End If

            'If sFiscalPrinterConnectionType = "P" Then
            '    optParallelFiscal.Checked = True
            '    cboParallelPort.SelectedItem = sFiscalPrinterConnectionParameters
            'End If

            'txtPOSCode.Focus()
        Else
            txtCode.Enabled = True

            txtCode.Focus()
        End If



    End Sub

    Public Sub SaveData()
        'Dim sPrinterConnectionType As String
        'Dim sPrinterConnectionParameters As String
        'Dim sFiscalPrinterConnectionType As String
        'Dim sFiscalPrinterConnectionParameters As String
        'Dim sFiscalValue As String
        'Dim sPOSValue As String

        'If optSerialPOS.Checked Then
        '    sPrinterConnectionType = "S"
        '    sPrinterConnectionParameters = String.Format("{0},{1},{2},{3},{4}", cboSerialPortPOS.SelectedItem, cboBaudsPOS.SelectedItem, cboDataBitsPOS.SelectedItem, cboParityPOS.SelectedItem.Chars(0), cboStopBitsPOS.SelectedItem)
        'ElseIf optParallelPOS.Checked Then
        '    sPrinterConnectionType = "P"
        '    sPrinterConnectionParameters = cboParallelPortPOS.SelectedItem
        'Else
        '    sPrinterConnectionType = ""
        '    sPrinterConnectionParameters = ""
        'End If

        '[AMI130405] Impresora fiscal
        'If optSerialFiscal.Checked Then
        '    sFiscalPrinterConnectionType = "S"
        '    sFiscalPrinterConnectionParameters = String.Format("{0},{1},{2},{3},{4}", cboSerialPort.SelectedItem, cboBauds.SelectedItem, cboDataBits.SelectedItem, cboParity.SelectedItem.Chars(0), cboStopBits.SelectedItem)
        'ElseIf optParallelFiscal.Checked Then
        '    sFiscalPrinterConnectionType = "P"
        '    sFiscalPrinterConnectionParameters = cboParallelPort.SelectedItem
        'Else
        '    sFiscalPrinterConnectionType = ""
        '    sFiscalPrinterConnectionParameters = ""
        'End If

        'sPOSValue = IIf(dsPOSPrinters.Rows(cboPrinterPOS.SelectedIndex).Item("Code") Is DBNull.Value, "", cboPrinterPOS.SelectedValue)
        'sFiscalValue = IIf(dsFiscalPrinters.Rows(cboPrinterFiscal.SelectedIndex).Item("Code") Is DBNull.Value, "", cboPrinterFiscal.SelectedValue)

        Dim siteId As String = oDataLayer.GetSiteId
        'oDataLayer.SetTerminal(txtCode.Text, txtName.Text, cboLocation.SelectedValue, sPOSValue, sPrinterConnectionType, sPrinterConnectionParameters, cboPOSDesign.SelectedValue, txtPOSCode.Text, sFiscalValue, sFiscalPrinterConnectionType, sFiscalPrinterConnectionParameters, cboWindowsPrinter.Text, cboStockLocation.SelectedValue, siteId)
        oDataLayer.SetTerminal(txtCode.Text, txtName.Text, "1", "pose1", "algo", "algo1", "1", "sss", "fiscal", "fiscal1", "fiscal2", cboWindowsPrinter.Text, "1", siteId)

        If txtCode.Enabled Then
            oDataLayer.SetTerminalInRegistry(txtCode.Text)
        End If
    End Sub

    'Public Sub SetLanguage(ByVal AssemblyName As String, ByVal TxtName As String)
    '    ' Carga los lenguajes indicados (para la traducción)
    '    oTranslatedResources = New ewave.GlobalResourcesEngine.ResourceLoader(AssemblyName, TxtName)
    '    Me.LoadGlobalCaptions()
    'End Sub

    'Friend ReadOnly Property TranslatedResources() As ewave.GlobalResourcesEngine.ResourceLoader
    '    Get
    '        Return oTranslatedResources
    '    End Get
    'End Property
#End Region

#Region " GlobalResourcesLoader "

    Public Sub LoadGlobalCaptions()

        lblName.Text = EnvironmentObjects.GlobalResources.GetString("lblNameText", Me.lblName.Text)
        lblCode.Text = EnvironmentObjects.GlobalResources.GetString("lblCodeText", Me.lblCode.Text)
        'lblLocation.Text = EnvironmentObjects.GlobalResources.GetString("lblLocationText", Me.lblLocation.Text)
        'lblPOSDesign.Text = EnvironmentObjects.GlobalResources.GetString("lblPOSDesignText", Me.lblPOSDesign.Text)
        ' lblPOSCode.Text = EnvironmentObjects.GlobalResources.GetString("lblPOSCodeText", Me.lblPOSCode.Text)
        Label1.Text = EnvironmentObjects.GlobalResources.GetString("TLabel1Text", Me.Label1.Text)
        'optSerialPOS.Text = EnvironmentObjects.GlobalResources.GetString("optSerialPOSText", Me.optSerialPOS.Text)
        'optParallelPOS.Text = EnvironmentObjects.GlobalResources.GetString("optParallelPOSText", Me.optParallelPOS.Text)
        'Label3.Text = EnvironmentObjects.GlobalResources.GetString("Label3Text", Me.Label3.Text)
        'Label4.Text = EnvironmentObjects.GlobalResources.GetString("Label4Text", Me.Label4.Text)
        'Label5.Text = EnvironmentObjects.GlobalResources.GetString("Label5Text", Me.Label5.Text)
        'Label6.Text = EnvironmentObjects.GlobalResources.GetString("Label6Text", Me.Label6.Text)
        'Label7.Text = EnvironmentObjects.GlobalResources.GetString("Label7Text", Me.Label7.Text)
        'Label8.Text = EnvironmentObjects.GlobalResources.GetString("Label8Text", Me.Label8.Text)
        'Label9.Text = EnvironmentObjects.GlobalResources.GetString("Label9Text", Me.Label9.Text)
        'Label2.Text = EnvironmentObjects.GlobalResources.GetString("Label2Text", Me.Label2.Text)
        'optSerialFiscal.Text = EnvironmentObjects.GlobalResources.GetString("optSerialFiscalText", Me.optSerialFiscal.Text)
        'optParallelFiscal.Text = EnvironmentObjects.GlobalResources.GetString("optParallelFiscalText", Me.optParallelFiscal.Text)
        'lblSerialPort.Text = EnvironmentObjects.GlobalResources.GetString("lblSerialPortText", Me.lblSerialPort.Text)
        'lblDataBits.Text = EnvironmentObjects.GlobalResources.GetString("lblDataBitsText", Me.lblDataBits.Text)
        'lblStopBits.Text = EnvironmentObjects.GlobalResources.GetString("lblStopBitsText", Me.lblStopBits.Text)
        'lblParity.Text = EnvironmentObjects.GlobalResources.GetString("lblParityText", Me.lblParity.Text)
        'lblBauds.Text = EnvironmentObjects.GlobalResources.GetString("lblBaudsText", Me.lblBauds.Text)
        'lblParallelPort.Text = EnvironmentObjects.GlobalResources.GetString("lblParallelPortText", Me.lblParallelPort.Text)

    End Sub

#End Region

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mniFileMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniProcessTestDataMniFileMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniOpenMniFileMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSaveMniFileMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniResetAllMniFileMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExitMniFileMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHelpMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniAboutMniHelpMnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTrxLog = New System.Windows.Forms.TextBox()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tabSummaryTbcMain = New System.Windows.Forms.TabPage()
        Me.grpMetricsTabSummaryTbcMain = New System.Windows.Forms.GroupBox()
        Me.txtMetricsGrpMetricsTabSummaryTbcMain = New System.Windows.Forms.TextBox()
        Me.txtToStringInfoTabSummaryTbcMain = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCountTrxLineTabSummaryTbcMain = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCountTrxTabSummaryTbcMain = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCountAccountTabSummaryTbcMain = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCountCustomerTabCustomerTbcMain = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstTrxLineIDTabSummaryTbcMain = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstTrxIDTabSummaryTbcMain = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstAccountIDTabSummaryTbcMain = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCustomerIDTabSummaryTbcMain = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcCustomerTbcMain = New System.Windows.Forms.TabPage()
        Me.grpCreateTabCustomerTbcMain = New System.Windows.Forms.GroupBox()
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain = New System.Windows.Forms.Button()
        Me.txtNameGrpCreateTabCustomerTbcMain = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpBirthdateGrpCreateTabCustomerTbcMain = New System.Windows.Forms.DateTimePicker()
        Me.cboCustomerIDTabCustomerTbcMain = New System.Windows.Forms.ComboBox()
        Me.lblCountTrxTabCustomerTbcMain = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lstTrxIDTabCustomerTbcMain = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtToStringInfoTabCustomerTbcMain = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabAccountTbcMain = New System.Windows.Forms.TabPage()
        Me.lblCountOwnersTabAccountTbcMain = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.grpClosedTabAccountTbcMain = New System.Windows.Forms.GroupBox()
        Me.dtpClosedDateGrpClosedTabAccountTbcMain = New System.Windows.Forms.DateTimePicker()
        Me.chkClosedGrpClosedTabAccountTbcMain = New System.Windows.Forms.CheckBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.lstCustomerIDTabAccountTbcMain = New System.Windows.Forms.ListBox()
        Me.btnModifyAccountTabAccountTbcMain = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.grpCreateModifyTabAccountTbcMain = New System.Windows.Forms.GroupBox()
        Me.txtTrxIDGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.DateTimePicker()
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.ListBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.nudAPRGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.NumericUpDown()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.txtAmountGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.grpTypeGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.GroupBox()
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.RadioButton()
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.RadioButton()
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.RadioButton()
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.Button()
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNameGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain = New System.Windows.Forms.DateTimePicker()
        Me.cboAccountIDTabAccountTbcMain = New System.Windows.Forms.ComboBox()
        Me.lblCountTrxLinesTabAccountTbcMain = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lstTrxLineIDTabAccountTbcMain = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtToStringInfoTabAccountTbcMain = New System.Windows.Forms.TextBox()
        Me.btnCreateAccountTabAccountTbcMain = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tabTransactionsTbcMain = New System.Windows.Forms.TabPage()
        Me.tbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TabControl()
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.DateTimePicker()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.NumericUpDown()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.ComboBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.ComboBox()
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.Button()
        Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.GroupBox()
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TabPage()
        Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.GroupBox()
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.ComboBox()
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.NumericUpDown()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.Button()
        Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TabPage()
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.GroupBox()
        Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.GroupBox()
        Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.ComboBox()
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.RadioButton()
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain = New System.Windows.Forms.Button()
        Me.tabReportsTbcMain = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tabFilesTbcMain = New System.Windows.Forms.TabPage()
        Me.btnDisplayBankStatusTabFilesTbcMain = New System.Windows.Forms.Button()
        Me.btnClearTrxLogTabFilesTbcMain = New System.Windows.Forms.Button()
        Me.txtFileNameTabFilesTbcMain = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.btnProcessTestDataTabFilesTbcMain = New System.Windows.Forms.Button()
        Me.btnResetAllTabFilesTbcMain = New System.Windows.Forms.Button()
        Me.btnSaveTabFilesTbcMain = New System.Windows.Forms.Button()
        Me.btnOpenTabFilesTbcMain = New System.Windows.Forms.Button()
        Me.tipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMain.SuspendLayout()
        Me.tbcMain.SuspendLayout()
        Me.tabSummaryTbcMain.SuspendLayout()
        Me.grpMetricsTabSummaryTbcMain.SuspendLayout()
        Me.tbcCustomerTbcMain.SuspendLayout()
        Me.grpCreateTabCustomerTbcMain.SuspendLayout()
        Me.tabAccountTbcMain.SuspendLayout()
        Me.grpClosedTabAccountTbcMain.SuspendLayout()
        Me.grpCreateModifyTabAccountTbcMain.SuspendLayout()
        CType(Me.nudAPRGrpCreateModifyTabAccountTbcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.SuspendLayout()
        Me.tabTransactionsTbcMain.SuspendLayout()
        Me.tbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        CType(Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        CType(Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SuspendLayout()
        Me.tabReportsTbcMain.SuspendLayout()
        Me.tabFilesTbcMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(811, 774)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 26)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.tipMain.SetToolTip(Me.btnExit, "click to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniFileMnuMain, Me.mniHelpMnuMain})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.mnuMain.Size = New System.Drawing.Size(1687, 26)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mniFileMnuMain
        '
        Me.mniFileMnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniProcessTestDataMniFileMnuMain, Me.mniOpenMniFileMnuMain, Me.mniSaveMniFileMnuMain, Me.mniResetAllMniFileMnuMain, Me.mniExitMniFileMnuMain})
        Me.mniFileMnuMain.Name = "mniFileMnuMain"
        Me.mniFileMnuMain.Size = New System.Drawing.Size(44, 24)
        Me.mniFileMnuMain.Text = "&File"
        '
        'mniProcessTestDataMniFileMnuMain
        '
        Me.mniProcessTestDataMniFileMnuMain.Name = "mniProcessTestDataMniFileMnuMain"
        Me.mniProcessTestDataMniFileMnuMain.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mniProcessTestDataMniFileMnuMain.Size = New System.Drawing.Size(245, 26)
        Me.mniProcessTestDataMniFileMnuMain.Text = "Process &Test Data"
        '
        'mniOpenMniFileMnuMain
        '
        Me.mniOpenMniFileMnuMain.Name = "mniOpenMniFileMnuMain"
        Me.mniOpenMniFileMnuMain.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mniOpenMniFileMnuMain.Size = New System.Drawing.Size(245, 26)
        Me.mniOpenMniFileMnuMain.Text = "&Open"
        '
        'mniSaveMniFileMnuMain
        '
        Me.mniSaveMniFileMnuMain.Name = "mniSaveMniFileMnuMain"
        Me.mniSaveMniFileMnuMain.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mniSaveMniFileMnuMain.Size = New System.Drawing.Size(245, 26)
        Me.mniSaveMniFileMnuMain.Text = "&Save"
        '
        'mniResetAllMniFileMnuMain
        '
        Me.mniResetAllMniFileMnuMain.Name = "mniResetAllMniFileMnuMain"
        Me.mniResetAllMniFileMnuMain.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mniResetAllMniFileMnuMain.Size = New System.Drawing.Size(245, 26)
        Me.mniResetAllMniFileMnuMain.Text = "&Reset All"
        '
        'mniExitMniFileMnuMain
        '
        Me.mniExitMniFileMnuMain.Name = "mniExitMniFileMnuMain"
        Me.mniExitMniFileMnuMain.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mniExitMniFileMnuMain.Size = New System.Drawing.Size(245, 26)
        Me.mniExitMniFileMnuMain.Text = "E&xit"
        '
        'mniHelpMnuMain
        '
        Me.mniHelpMnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAboutMniHelpMnuMain})
        Me.mniHelpMnuMain.Name = "mniHelpMnuMain"
        Me.mniHelpMnuMain.Size = New System.Drawing.Size(53, 24)
        Me.mniHelpMnuMain.Text = "&Help"
        '
        'mniAboutMniHelpMnuMain
        '
        Me.mniAboutMniHelpMnuMain.Name = "mniAboutMniHelpMnuMain"
        Me.mniAboutMniHelpMnuMain.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mniAboutMniHelpMnuMain.Size = New System.Drawing.Size(281, 26)
        Me.mniAboutMniHelpMnuMain.Text = "&About the Banking Project"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 519)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tr&x Log:"
        '
        'txtTrxLog
        '
        Me.txtTrxLog.Location = New System.Drawing.Point(25, 516)
        Me.txtTrxLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxLog.Multiline = True
        Me.txtTrxLog.Name = "txtTrxLog"
        Me.txtTrxLog.ReadOnly = True
        Me.txtTrxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTrxLog.Size = New System.Drawing.Size(1627, 206)
        Me.txtTrxLog.TabIndex = 3
        Me.tipMain.SetToolTip(Me.txtTrxLog, "transaction information is displayed here")
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabSummaryTbcMain)
        Me.tbcMain.Controls.Add(Me.tbcCustomerTbcMain)
        Me.tbcMain.Controls.Add(Me.tabAccountTbcMain)
        Me.tbcMain.Controls.Add(Me.tabTransactionsTbcMain)
        Me.tbcMain.Controls.Add(Me.tabReportsTbcMain)
        Me.tbcMain.Controls.Add(Me.tabFilesTbcMain)
        Me.tbcMain.Location = New System.Drawing.Point(51, 44)
        Me.tbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1625, 454)
        Me.tbcMain.TabIndex = 0
        Me.tipMain.SetToolTip(Me.tbcMain, "information of the customer,account,transaction,transaction line  is displayed he" &
        "re")
        '
        'tabSummaryTbcMain
        '
        Me.tabSummaryTbcMain.Controls.Add(Me.grpMetricsTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.txtToStringInfoTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label7)
        Me.tabSummaryTbcMain.Controls.Add(Me.lblCountTrxLineTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label12)
        Me.tabSummaryTbcMain.Controls.Add(Me.lblCountTrxTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label10)
        Me.tabSummaryTbcMain.Controls.Add(Me.lblCountAccountTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label8)
        Me.tabSummaryTbcMain.Controls.Add(Me.lblCountCustomerTabCustomerTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label6)
        Me.tabSummaryTbcMain.Controls.Add(Me.lstTrxLineIDTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label5)
        Me.tabSummaryTbcMain.Controls.Add(Me.lstTrxIDTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label4)
        Me.tabSummaryTbcMain.Controls.Add(Me.lstAccountIDTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label3)
        Me.tabSummaryTbcMain.Controls.Add(Me.lstCustomerIDTabSummaryTbcMain)
        Me.tabSummaryTbcMain.Controls.Add(Me.Label2)
        Me.tabSummaryTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabSummaryTbcMain.Name = "tabSummaryTbcMain"
        Me.tabSummaryTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabSummaryTbcMain.Size = New System.Drawing.Size(1617, 425)
        Me.tabSummaryTbcMain.TabIndex = 0
        Me.tabSummaryTbcMain.Text = "Summary"
        Me.tabSummaryTbcMain.UseVisualStyleBackColor = True
        '
        'grpMetricsTabSummaryTbcMain
        '
        Me.grpMetricsTabSummaryTbcMain.Controls.Add(Me.txtMetricsGrpMetricsTabSummaryTbcMain)
        Me.grpMetricsTabSummaryTbcMain.Location = New System.Drawing.Point(31, 260)
        Me.grpMetricsTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMetricsTabSummaryTbcMain.Name = "grpMetricsTabSummaryTbcMain"
        Me.grpMetricsTabSummaryTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMetricsTabSummaryTbcMain.Size = New System.Drawing.Size(1559, 140)
        Me.grpMetricsTabSummaryTbcMain.TabIndex = 18
        Me.grpMetricsTabSummaryTbcMain.TabStop = False
        Me.grpMetricsTabSummaryTbcMain.Text = "&Metrics"
        '
        'txtMetricsGrpMetricsTabSummaryTbcMain
        '
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.Location = New System.Drawing.Point(5, 21)
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.Multiline = True
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.Name = "txtMetricsGrpMetricsTabSummaryTbcMain"
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.ReadOnly = True
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.Size = New System.Drawing.Size(1548, 115)
        Me.txtMetricsGrpMetricsTabSummaryTbcMain.TabIndex = 0
        Me.tipMain.SetToolTip(Me.txtMetricsGrpMetricsTabSummaryTbcMain, "metrics of the bank")
        '
        'txtToStringInfoTabSummaryTbcMain
        '
        Me.txtToStringInfoTabSummaryTbcMain.Location = New System.Drawing.Point(676, 38)
        Me.txtToStringInfoTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToStringInfoTabSummaryTbcMain.Multiline = True
        Me.txtToStringInfoTabSummaryTbcMain.Name = "txtToStringInfoTabSummaryTbcMain"
        Me.txtToStringInfoTabSummaryTbcMain.ReadOnly = True
        Me.txtToStringInfoTabSummaryTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToStringInfoTabSummaryTbcMain.Size = New System.Drawing.Size(909, 186)
        Me.txtToStringInfoTabSummaryTbcMain.TabIndex = 17
        Me.tipMain.SetToolTip(Me.txtToStringInfoTabSummaryTbcMain, "information of  the selected customer ,account,transactions etc is shown here ")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(672, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ToString &Information:"
        '
        'lblCountTrxLineTabSummaryTbcMain
        '
        Me.lblCountTrxLineTabSummaryTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountTrxLineTabSummaryTbcMain.Location = New System.Drawing.Point(515, 223)
        Me.lblCountTrxLineTabSummaryTbcMain.Name = "lblCountTrxLineTabSummaryTbcMain"
        Me.lblCountTrxLineTabSummaryTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountTrxLineTabSummaryTbcMain.TabIndex = 15
        Me.lblCountTrxLineTabSummaryTbcMain.Text = "0"
        Me.lblCountTrxLineTabSummaryTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tipMain.SetToolTip(Me.lblCountTrxLineTabSummaryTbcMain, "count of all the transaction lines")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(457, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Count:"
        '
        'lblCountTrxTabSummaryTbcMain
        '
        Me.lblCountTrxTabSummaryTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountTrxTabSummaryTbcMain.Location = New System.Drawing.Point(372, 223)
        Me.lblCountTrxTabSummaryTbcMain.Name = "lblCountTrxTabSummaryTbcMain"
        Me.lblCountTrxTabSummaryTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountTrxTabSummaryTbcMain.TabIndex = 11
        Me.lblCountTrxTabSummaryTbcMain.Text = "0"
        Me.lblCountTrxTabSummaryTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tipMain.SetToolTip(Me.lblCountTrxTabSummaryTbcMain, "count of all the Transactions performed")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(313, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Count:"
        '
        'lblCountAccountTabSummaryTbcMain
        '
        Me.lblCountAccountTabSummaryTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountAccountTabSummaryTbcMain.Location = New System.Drawing.Point(228, 223)
        Me.lblCountAccountTabSummaryTbcMain.Name = "lblCountAccountTabSummaryTbcMain"
        Me.lblCountAccountTabSummaryTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountAccountTabSummaryTbcMain.TabIndex = 7
        Me.lblCountAccountTabSummaryTbcMain.Text = "0"
        Me.lblCountAccountTabSummaryTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tipMain.SetToolTip(Me.lblCountAccountTabSummaryTbcMain, "count of the accounts in the bank")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Count:"
        '
        'lblCountCustomerTabCustomerTbcMain
        '
        Me.lblCountCustomerTabCustomerTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountCustomerTabCustomerTbcMain.Location = New System.Drawing.Point(85, 223)
        Me.lblCountCustomerTabCustomerTbcMain.Name = "lblCountCustomerTabCustomerTbcMain"
        Me.lblCountCustomerTabCustomerTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountCustomerTabCustomerTbcMain.TabIndex = 3
        Me.lblCountCustomerTabCustomerTbcMain.Text = "0"
        Me.lblCountCustomerTabCustomerTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tipMain.SetToolTip(Me.lblCountCustomerTabCustomerTbcMain, "count of the customers in the Bank")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Count:"
        '
        'lstTrxLineIDTabSummaryTbcMain
        '
        Me.lstTrxLineIDTabSummaryTbcMain.FormattingEnabled = True
        Me.lstTrxLineIDTabSummaryTbcMain.ItemHeight = 16
        Me.lstTrxLineIDTabSummaryTbcMain.Location = New System.Drawing.Point(460, 38)
        Me.lstTrxLineIDTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTrxLineIDTabSummaryTbcMain.Name = "lstTrxLineIDTabSummaryTbcMain"
        Me.lstTrxLineIDTabSummaryTbcMain.Size = New System.Drawing.Size(107, 180)
        Me.lstTrxLineIDTabSummaryTbcMain.TabIndex = 13
        Me.tipMain.SetToolTip(Me.lstTrxLineIDTabSummaryTbcMain, "list of all the Transaction line ID's")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Trx&Line List:"
        '
        'lstTrxIDTabSummaryTbcMain
        '
        Me.lstTrxIDTabSummaryTbcMain.FormattingEnabled = True
        Me.lstTrxIDTabSummaryTbcMain.ItemHeight = 16
        Me.lstTrxIDTabSummaryTbcMain.Location = New System.Drawing.Point(317, 38)
        Me.lstTrxIDTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTrxIDTabSummaryTbcMain.Name = "lstTrxIDTabSummaryTbcMain"
        Me.lstTrxIDTabSummaryTbcMain.Size = New System.Drawing.Size(107, 180)
        Me.lstTrxIDTabSummaryTbcMain.TabIndex = 9
        Me.tipMain.SetToolTip(Me.lstTrxIDTabSummaryTbcMain, "list of all the Transaction ID's")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "&Trx List:"
        '
        'lstAccountIDTabSummaryTbcMain
        '
        Me.lstAccountIDTabSummaryTbcMain.FormattingEnabled = True
        Me.lstAccountIDTabSummaryTbcMain.ItemHeight = 16
        Me.lstAccountIDTabSummaryTbcMain.Items.AddRange(New Object() {"Account"})
        Me.lstAccountIDTabSummaryTbcMain.Location = New System.Drawing.Point(175, 38)
        Me.lstAccountIDTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstAccountIDTabSummaryTbcMain.Name = "lstAccountIDTabSummaryTbcMain"
        Me.lstAccountIDTabSummaryTbcMain.Size = New System.Drawing.Size(107, 180)
        Me.lstAccountIDTabSummaryTbcMain.TabIndex = 5
        Me.tipMain.SetToolTip(Me.lstAccountIDTabSummaryTbcMain, "list of all the Account ID's")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Account List:"
        '
        'lstCustomerIDTabSummaryTbcMain
        '
        Me.lstCustomerIDTabSummaryTbcMain.FormattingEnabled = True
        Me.lstCustomerIDTabSummaryTbcMain.ItemHeight = 16
        Me.lstCustomerIDTabSummaryTbcMain.Items.AddRange(New Object() {"customer", "id ", "here"})
        Me.lstCustomerIDTabSummaryTbcMain.Location = New System.Drawing.Point(31, 38)
        Me.lstCustomerIDTabSummaryTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCustomerIDTabSummaryTbcMain.Name = "lstCustomerIDTabSummaryTbcMain"
        Me.lstCustomerIDTabSummaryTbcMain.Size = New System.Drawing.Size(107, 180)
        Me.lstCustomerIDTabSummaryTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.lstCustomerIDTabSummaryTbcMain, "list of customer ID")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Customer List:"
        '
        'tbcCustomerTbcMain
        '
        Me.tbcCustomerTbcMain.Controls.Add(Me.grpCreateTabCustomerTbcMain)
        Me.tbcCustomerTbcMain.Controls.Add(Me.cboCustomerIDTabCustomerTbcMain)
        Me.tbcCustomerTbcMain.Controls.Add(Me.lblCountTrxTabCustomerTbcMain)
        Me.tbcCustomerTbcMain.Controls.Add(Me.Label16)
        Me.tbcCustomerTbcMain.Controls.Add(Me.lstTrxIDTabCustomerTbcMain)
        Me.tbcCustomerTbcMain.Controls.Add(Me.Label15)
        Me.tbcCustomerTbcMain.Controls.Add(Me.txtToStringInfoTabCustomerTbcMain)
        Me.tbcCustomerTbcMain.Controls.Add(Me.Label14)
        Me.tbcCustomerTbcMain.Controls.Add(Me.Label9)
        Me.tbcCustomerTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tbcCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbcCustomerTbcMain.Name = "tbcCustomerTbcMain"
        Me.tbcCustomerTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbcCustomerTbcMain.Size = New System.Drawing.Size(1617, 425)
        Me.tbcCustomerTbcMain.TabIndex = 1
        Me.tbcCustomerTbcMain.Text = "Customer"
        Me.tbcCustomerTbcMain.UseVisualStyleBackColor = True
        '
        'grpCreateTabCustomerTbcMain
        '
        Me.grpCreateTabCustomerTbcMain.Controls.Add(Me.btnCreateCustomerGrpCreateTabCustomerTbcMain)
        Me.grpCreateTabCustomerTbcMain.Controls.Add(Me.txtNameGrpCreateTabCustomerTbcMain)
        Me.grpCreateTabCustomerTbcMain.Controls.Add(Me.Label11)
        Me.grpCreateTabCustomerTbcMain.Controls.Add(Me.Label13)
        Me.grpCreateTabCustomerTbcMain.Controls.Add(Me.dtpBirthdateGrpCreateTabCustomerTbcMain)
        Me.grpCreateTabCustomerTbcMain.Location = New System.Drawing.Point(35, 74)
        Me.grpCreateTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCreateTabCustomerTbcMain.Name = "grpCreateTabCustomerTbcMain"
        Me.grpCreateTabCustomerTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCreateTabCustomerTbcMain.Size = New System.Drawing.Size(440, 194)
        Me.grpCreateTabCustomerTbcMain.TabIndex = 2
        Me.grpCreateTabCustomerTbcMain.TabStop = False
        Me.grpCreateTabCustomerTbcMain.Text = "&Create"
        '
        'btnCreateCustomerGrpCreateTabCustomerTbcMain
        '
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.Location = New System.Drawing.Point(113, 145)
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.Name = "btnCreateCustomerGrpCreateTabCustomerTbcMain"
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.Size = New System.Drawing.Size(212, 26)
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.TabIndex = 4
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.Text = "&Create Customer"
        Me.tipMain.SetToolTip(Me.btnCreateCustomerGrpCreateTabCustomerTbcMain, "click on create customer ")
        Me.btnCreateCustomerGrpCreateTabCustomerTbcMain.UseVisualStyleBackColor = True
        '
        'txtNameGrpCreateTabCustomerTbcMain
        '
        Me.txtNameGrpCreateTabCustomerTbcMain.Location = New System.Drawing.Point(105, 42)
        Me.txtNameGrpCreateTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNameGrpCreateTabCustomerTbcMain.Name = "txtNameGrpCreateTabCustomerTbcMain"
        Me.txtNameGrpCreateTabCustomerTbcMain.Size = New System.Drawing.Size(312, 22)
        Me.txtNameGrpCreateTabCustomerTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.txtNameGrpCreateTabCustomerTbcMain, "enter the name of the customer")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "&Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "&Birthdate:"
        '
        'dtpBirthdateGrpCreateTabCustomerTbcMain
        '
        Me.dtpBirthdateGrpCreateTabCustomerTbcMain.Location = New System.Drawing.Point(105, 87)
        Me.dtpBirthdateGrpCreateTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpBirthdateGrpCreateTabCustomerTbcMain.Name = "dtpBirthdateGrpCreateTabCustomerTbcMain"
        Me.dtpBirthdateGrpCreateTabCustomerTbcMain.Size = New System.Drawing.Size(312, 22)
        Me.dtpBirthdateGrpCreateTabCustomerTbcMain.TabIndex = 3
        Me.tipMain.SetToolTip(Me.dtpBirthdateGrpCreateTabCustomerTbcMain, "enter the birthdate ")
        '
        'cboCustomerIDTabCustomerTbcMain
        '
        Me.cboCustomerIDTabCustomerTbcMain.FormattingEnabled = True
        Me.cboCustomerIDTabCustomerTbcMain.Location = New System.Drawing.Point(128, 26)
        Me.cboCustomerIDTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCustomerIDTabCustomerTbcMain.Name = "cboCustomerIDTabCustomerTbcMain"
        Me.cboCustomerIDTabCustomerTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboCustomerIDTabCustomerTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.cboCustomerIDTabCustomerTbcMain, "enter an alphanumeric Customer ID")
        '
        'lblCountTrxTabCustomerTbcMain
        '
        Me.lblCountTrxTabCustomerTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountTrxTabCustomerTbcMain.Location = New System.Drawing.Point(616, 251)
        Me.lblCountTrxTabCustomerTbcMain.Name = "lblCountTrxTabCustomerTbcMain"
        Me.lblCountTrxTabCustomerTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountTrxTabCustomerTbcMain.TabIndex = 6
        Me.lblCountTrxTabCustomerTbcMain.Text = "0"
        Me.lblCountTrxTabCustomerTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(561, 252)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 17)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Count:"
        '
        'lstTrxIDTabCustomerTbcMain
        '
        Me.lstTrxIDTabCustomerTbcMain.FormattingEnabled = True
        Me.lstTrxIDTabCustomerTbcMain.ItemHeight = 16
        Me.lstTrxIDTabCustomerTbcMain.Location = New System.Drawing.Point(565, 48)
        Me.lstTrxIDTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTrxIDTabCustomerTbcMain.Name = "lstTrxIDTabCustomerTbcMain"
        Me.lstTrxIDTabCustomerTbcMain.Size = New System.Drawing.Size(107, 196)
        Me.lstTrxIDTabCustomerTbcMain.TabIndex = 4
        Me.tipMain.SetToolTip(Me.lstTrxIDTabCustomerTbcMain, "list of all the customer transactions is displayed ")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(561, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Customer's &Transactions:"
        '
        'txtToStringInfoTabCustomerTbcMain
        '
        Me.txtToStringInfoTabCustomerTbcMain.Location = New System.Drawing.Point(808, 47)
        Me.txtToStringInfoTabCustomerTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToStringInfoTabCustomerTbcMain.Multiline = True
        Me.txtToStringInfoTabCustomerTbcMain.Name = "txtToStringInfoTabCustomerTbcMain"
        Me.txtToStringInfoTabCustomerTbcMain.ReadOnly = True
        Me.txtToStringInfoTabCustomerTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToStringInfoTabCustomerTbcMain.Size = New System.Drawing.Size(389, 197)
        Me.txtToStringInfoTabCustomerTbcMain.TabIndex = 8
        Me.tipMain.SetToolTip(Me.txtToStringInfoTabCustomerTbcMain, "iformation of the customer is diaplayed in the tostring function")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(804, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "ToString &Information:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Customer I&D:"
        '
        'tabAccountTbcMain
        '
        Me.tabAccountTbcMain.Controls.Add(Me.lblCountOwnersTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.Label26)
        Me.tabAccountTbcMain.Controls.Add(Me.grpClosedTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.lstCustomerIDTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.btnModifyAccountTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.Label27)
        Me.tabAccountTbcMain.Controls.Add(Me.grpCreateModifyTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.cboAccountIDTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.lblCountTrxLinesTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.Label20)
        Me.tabAccountTbcMain.Controls.Add(Me.lstTrxLineIDTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.Label21)
        Me.tabAccountTbcMain.Controls.Add(Me.txtToStringInfoTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.btnCreateAccountTabAccountTbcMain)
        Me.tabAccountTbcMain.Controls.Add(Me.Label22)
        Me.tabAccountTbcMain.Controls.Add(Me.Label23)
        Me.tabAccountTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAccountTbcMain.Name = "tabAccountTbcMain"
        Me.tabAccountTbcMain.Size = New System.Drawing.Size(1617, 425)
        Me.tabAccountTbcMain.TabIndex = 2
        Me.tabAccountTbcMain.Text = "Account"
        Me.tabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'lblCountOwnersTabAccountTbcMain
        '
        Me.lblCountOwnersTabAccountTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountOwnersTabAccountTbcMain.Location = New System.Drawing.Point(801, 250)
        Me.lblCountOwnersTabAccountTbcMain.Name = "lblCountOwnersTabAccountTbcMain"
        Me.lblCountOwnersTabAccountTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountOwnersTabAccountTbcMain.TabIndex = 7
        Me.lblCountOwnersTabAccountTbcMain.Text = "Label7"
        Me.lblCountOwnersTabAccountTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(747, 252)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 17)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Count:"
        '
        'grpClosedTabAccountTbcMain
        '
        Me.grpClosedTabAccountTbcMain.Controls.Add(Me.dtpClosedDateGrpClosedTabAccountTbcMain)
        Me.grpClosedTabAccountTbcMain.Controls.Add(Me.chkClosedGrpClosedTabAccountTbcMain)
        Me.grpClosedTabAccountTbcMain.Controls.Add(Me.Label97)
        Me.grpClosedTabAccountTbcMain.Location = New System.Drawing.Point(252, 12)
        Me.grpClosedTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpClosedTabAccountTbcMain.Name = "grpClosedTabAccountTbcMain"
        Me.grpClosedTabAccountTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpClosedTabAccountTbcMain.Size = New System.Drawing.Size(439, 55)
        Me.grpClosedTabAccountTbcMain.TabIndex = 3
        Me.grpClosedTabAccountTbcMain.TabStop = False
        Me.grpClosedTabAccountTbcMain.Text = "Closed"
        '
        'dtpClosedDateGrpClosedTabAccountTbcMain
        '
        Me.dtpClosedDateGrpClosedTabAccountTbcMain.Location = New System.Drawing.Point(188, 22)
        Me.dtpClosedDateGrpClosedTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpClosedDateGrpClosedTabAccountTbcMain.Name = "dtpClosedDateGrpClosedTabAccountTbcMain"
        Me.dtpClosedDateGrpClosedTabAccountTbcMain.Size = New System.Drawing.Size(241, 22)
        Me.dtpClosedDateGrpClosedTabAccountTbcMain.TabIndex = 2
        Me.tipMain.SetToolTip(Me.dtpClosedDateGrpClosedTabAccountTbcMain, "closed is selected here")
        '
        'chkClosedGrpClosedTabAccountTbcMain
        '
        Me.chkClosedGrpClosedTabAccountTbcMain.AutoSize = True
        Me.chkClosedGrpClosedTabAccountTbcMain.Location = New System.Drawing.Point(17, 22)
        Me.chkClosedGrpClosedTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkClosedGrpClosedTabAccountTbcMain.Name = "chkClosedGrpClosedTabAccountTbcMain"
        Me.chkClosedGrpClosedTabAccountTbcMain.Size = New System.Drawing.Size(73, 21)
        Me.chkClosedGrpClosedTabAccountTbcMain.TabIndex = 0
        Me.chkClosedGrpClosedTabAccountTbcMain.Text = "Closed"
        Me.tipMain.SetToolTip(Me.chkClosedGrpClosedTabAccountTbcMain, "click on closed date")
        Me.chkClosedGrpClosedTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(97, 23)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(89, 17)
        Me.Label97.TabIndex = 1
        Me.Label97.Text = "Closed Date:"
        '
        'lstCustomerIDTabAccountTbcMain
        '
        Me.lstCustomerIDTabAccountTbcMain.FormattingEnabled = True
        Me.lstCustomerIDTabAccountTbcMain.ItemHeight = 16
        Me.lstCustomerIDTabAccountTbcMain.Location = New System.Drawing.Point(751, 47)
        Me.lstCustomerIDTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCustomerIDTabAccountTbcMain.Name = "lstCustomerIDTabAccountTbcMain"
        Me.lstCustomerIDTabAccountTbcMain.Size = New System.Drawing.Size(107, 196)
        Me.lstCustomerIDTabAccountTbcMain.TabIndex = 5
        Me.tipMain.SetToolTip(Me.lstCustomerIDTabAccountTbcMain, "list of account owner Id's are displayed")
        '
        'btnModifyAccountTabAccountTbcMain
        '
        Me.btnModifyAccountTabAccountTbcMain.Location = New System.Drawing.Point(229, 377)
        Me.btnModifyAccountTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModifyAccountTabAccountTbcMain.Name = "btnModifyAccountTabAccountTbcMain"
        Me.btnModifyAccountTabAccountTbcMain.Size = New System.Drawing.Size(168, 26)
        Me.btnModifyAccountTabAccountTbcMain.TabIndex = 15
        Me.btnModifyAccountTabAccountTbcMain.Text = "&Modify Account"
        Me.tipMain.SetToolTip(Me.btnModifyAccountTabAccountTbcMain, "click to modify account")
        Me.btnModifyAccountTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(747, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 17)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Account's &Owner IDs:"
        '
        'grpCreateModifyTabAccountTbcMain
        '
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.txtTrxIDGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label19)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label31)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label71)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label73)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label96)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.nudAPRGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label95)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.txtAmountGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label94)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.grpTypeGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label24)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.txtNameGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label17)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.Label18)
        Me.grpCreateModifyTabAccountTbcMain.Controls.Add(Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain)
        Me.grpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(33, 73)
        Me.grpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCreateModifyTabAccountTbcMain.Name = "grpCreateModifyTabAccountTbcMain"
        Me.grpCreateModifyTabAccountTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(544, 284)
        Me.grpCreateModifyTabAccountTbcMain.TabIndex = 2
        Me.grpCreateModifyTabAccountTbcMain.TabStop = False
        Me.grpCreateModifyTabAccountTbcMain.Text = "Create/&Modify"
        Me.tipMain.SetToolTip(Me.grpCreateModifyTabAccountTbcMain, "to createv and modify he account")
        '
        'txtTrxIDGrpCreateModifyTabAccountTbcMain
        '
        Me.txtTrxIDGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(315, 187)
        Me.txtTrxIDGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxIDGrpCreateModifyTabAccountTbcMain.Name = "txtTrxIDGrpCreateModifyTabAccountTbcMain"
        Me.txtTrxIDGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(76, 22)
        Me.txtTrxIDGrpCreateModifyTabAccountTbcMain.TabIndex = 11
        Me.tipMain.SetToolTip(Me.txtTrxIDGrpCreateModifyTabAccountTbcMain, "enter a alphanumeric transaction ID")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(235, 191)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Trx ID:"
        '
        'txtTrxLineIDGrpCreateModifyTabAccountTbcMain
        '
        Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(315, 219)
        Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Name = "txtTrxLineIDGrpCreateModifyTabAccountTbcMain"
        Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(76, 22)
        Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain.TabIndex = 16
        Me.tipMain.SetToolTip(Me.txtTrxLineIDGrpCreateModifyTabAccountTbcMain, "enter the transaction line id")
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(235, 223)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 17)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "TrxLine ID:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(23, 255)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(176, 17)
        Me.Label71.TabIndex = 17
        Me.Label71.Text = "Next Interest Accrual Date:"
        '
        'dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain
        '
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Enabled = False
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(205, 252)
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Name = "dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain"
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(313, 22)
        Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.TabIndex = 18
        Me.tipMain.SetToolTip(Me.dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain, "the next accrual date is displayed here")
        '
        'lstNewOwnerIDGrpCreateModifyTabAccountTbcMain
        '
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.FormattingEnabled = True
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.ItemHeight = 16
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(412, 46)
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Name = "lstNewOwnerIDGrpCreateModifyTabAccountTbcMain"
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(107, 196)
        Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.lstNewOwnerIDGrpCreateModifyTabAccountTbcMain, "list of owner Id's")
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(140, 223)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(20, 17)
        Me.Label73.TabIndex = 14
        Me.Label73.Text = "%"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(409, 26)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(108, 17)
        Me.Label96.TabIndex = 19
        Me.Label96.Text = "N&ew Owner IDs:"
        '
        'nudAPRGrpCreateModifyTabAccountTbcMain
        '
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.DecimalPlaces = 2
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(68, 220)
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.Name = "nudAPRGrpCreateModifyTabAccountTbcMain"
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(67, 22)
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.TabIndex = 13
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tipMain.SetToolTip(Me.nudAPRGrpCreateModifyTabAccountTbcMain, "enter the amount")
        Me.nudAPRGrpCreateModifyTabAccountTbcMain.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(23, 223)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(40, 17)
        Me.Label95.TabIndex = 12
        Me.Label95.Text = "APR:"
        '
        'txtAmountGrpCreateModifyTabAccountTbcMain
        '
        Me.txtAmountGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(135, 187)
        Me.txtAmountGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmountGrpCreateModifyTabAccountTbcMain.Name = "txtAmountGrpCreateModifyTabAccountTbcMain"
        Me.txtAmountGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtAmountGrpCreateModifyTabAccountTbcMain.TabIndex = 9
        Me.txtAmountGrpCreateModifyTabAccountTbcMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tipMain.SetToolTip(Me.txtAmountGrpCreateModifyTabAccountTbcMain, "enter a positive number")
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(23, 190)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(108, 17)
        Me.Label94.TabIndex = 8
        Me.Label94.Text = "Initial Amount: &$"
        '
        'grpTypeGrpCreateModifyTabAccountTbcMain
        '
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Controls.Add(Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Controls.Add(Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Controls.Add(Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(23, 54)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Name = "grpTypeGrpCreateModifyTabAccountTbcMain"
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(369, 58)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.TabIndex = 3
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.TabStop = False
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.Text = "Type"
        '
        'radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain
        '
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.AutoSize = True
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(256, 23)
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Name = "radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain"
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(100, 21)
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.TabIndex = 2
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.TabStop = True
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Text = "Credit Card"
        Me.tipMain.SetToolTip(Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain, "click on credit card")
        Me.radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'radLoanGrpTypeGrpCreateModifyTabAccountTbcMain
        '
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.AutoSize = True
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(148, 23)
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Name = "radLoanGrpTypeGrpCreateModifyTabAccountTbcMain"
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(61, 21)
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.TabIndex = 1
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.TabStop = True
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Text = "Loan"
        Me.tipMain.SetToolTip(Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain, "click on loan ")
        Me.radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain
        '
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.AutoSize = True
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(15, 23)
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Name = "radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain"
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(87, 21)
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.TabIndex = 0
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.TabStop = True
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Text = "Checking"
        Me.tipMain.SetToolTip(Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain, "click on checkings account")
        Me.radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain
        '
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(240, 23)
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Name = "btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain"
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(152, 26)
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.TabIndex = 2
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Text = "&Add Account Owner"
        Me.tipMain.SetToolTip(Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain, "add's the customer details to the account created")
        Me.btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'cboCustomerIDGrpCreateModifyTabAccountTbcMain
        '
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.FormattingEnabled = True
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(119, 23)
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.Name = "cboCustomerIDGrpCreateModifyTabAccountTbcMain"
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.cboCustomerIDGrpCreateModifyTabAccountTbcMain, "enter an alphanumeric Customer ID")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 17)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "C&ustomer ID:"
        '
        'txtNameGrpCreateModifyTabAccountTbcMain
        '
        Me.txtNameGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(76, 123)
        Me.txtNameGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNameGrpCreateModifyTabAccountTbcMain.Name = "txtNameGrpCreateModifyTabAccountTbcMain"
        Me.txtNameGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(316, 22)
        Me.txtNameGrpCreateModifyTabAccountTbcMain.TabIndex = 5
        Me.tipMain.SetToolTip(Me.txtNameGrpCreateModifyTabAccountTbcMain, "enter a valid name")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 17)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "&Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 17)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Date O&pened:"
        '
        'dtpDateOpenedGrpCreateModifyTabAccountTbcMain
        '
        Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Location = New System.Drawing.Point(125, 153)
        Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Name = "dtpDateOpenedGrpCreateModifyTabAccountTbcMain"
        Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Size = New System.Drawing.Size(267, 22)
        Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain.TabIndex = 7
        Me.tipMain.SetToolTip(Me.dtpDateOpenedGrpCreateModifyTabAccountTbcMain, "enter a valid date")
        '
        'cboAccountIDTabAccountTbcMain
        '
        Me.cboAccountIDTabAccountTbcMain.FormattingEnabled = True
        Me.cboAccountIDTabAccountTbcMain.Location = New System.Drawing.Point(121, 23)
        Me.cboAccountIDTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAccountIDTabAccountTbcMain.Name = "cboAccountIDTabAccountTbcMain"
        Me.cboAccountIDTabAccountTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboAccountIDTabAccountTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.cboAccountIDTabAccountTbcMain, "enter an alpha numeric account Id")
        '
        'lblCountTrxLinesTabAccountTbcMain
        '
        Me.lblCountTrxLinesTabAccountTbcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountTrxLinesTabAccountTbcMain.Location = New System.Drawing.Point(967, 251)
        Me.lblCountTrxLinesTabAccountTbcMain.Name = "lblCountTrxLinesTabAccountTbcMain"
        Me.lblCountTrxLinesTabAccountTbcMain.Size = New System.Drawing.Size(53, 18)
        Me.lblCountTrxLinesTabAccountTbcMain.TabIndex = 11
        Me.lblCountTrxLinesTabAccountTbcMain.Text = "Label7"
        Me.lblCountTrxLinesTabAccountTbcMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(912, 252)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Count:"
        '
        'lstTrxLineIDTabAccountTbcMain
        '
        Me.lstTrxLineIDTabAccountTbcMain.FormattingEnabled = True
        Me.lstTrxLineIDTabAccountTbcMain.ItemHeight = 16
        Me.lstTrxLineIDTabAccountTbcMain.Location = New System.Drawing.Point(916, 48)
        Me.lstTrxLineIDTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTrxLineIDTabAccountTbcMain.Name = "lstTrxLineIDTabAccountTbcMain"
        Me.lstTrxLineIDTabAccountTbcMain.Size = New System.Drawing.Size(107, 196)
        Me.lstTrxLineIDTabAccountTbcMain.TabIndex = 9
        Me.tipMain.SetToolTip(Me.lstTrxLineIDTabAccountTbcMain, "list of all the transaction line ID's are shown here")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(912, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(152, 17)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Account's &Trx Line IDs:"
        '
        'txtToStringInfoTabAccountTbcMain
        '
        Me.txtToStringInfoTabAccountTbcMain.Location = New System.Drawing.Point(1127, 47)
        Me.txtToStringInfoTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToStringInfoTabAccountTbcMain.Multiline = True
        Me.txtToStringInfoTabAccountTbcMain.Name = "txtToStringInfoTabAccountTbcMain"
        Me.txtToStringInfoTabAccountTbcMain.ReadOnly = True
        Me.txtToStringInfoTabAccountTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToStringInfoTabAccountTbcMain.Size = New System.Drawing.Size(389, 197)
        Me.txtToStringInfoTabAccountTbcMain.TabIndex = 13
        Me.tipMain.SetToolTip(Me.txtToStringInfoTabAccountTbcMain, "to display the information of the account,account owner and transactions etc..,")
        '
        'btnCreateAccountTabAccountTbcMain
        '
        Me.btnCreateAccountTabAccountTbcMain.Location = New System.Drawing.Point(33, 377)
        Me.btnCreateAccountTabAccountTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateAccountTabAccountTbcMain.Name = "btnCreateAccountTabAccountTbcMain"
        Me.btnCreateAccountTabAccountTbcMain.Size = New System.Drawing.Size(168, 26)
        Me.btnCreateAccountTabAccountTbcMain.TabIndex = 14
        Me.btnCreateAccountTabAccountTbcMain.Text = "&Create Account"
        Me.tipMain.SetToolTip(Me.btnCreateAccountTabAccountTbcMain, "click to create account")
        Me.btnCreateAccountTabAccountTbcMain.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(1123, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(140, 17)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "ToString &Information:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(31, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 17)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Account I&D:"
        '
        'tabTransactionsTbcMain
        '
        Me.tabTransactionsTbcMain.Controls.Add(Me.tbcTransactionsTabTransactionsTbcMain)
        Me.tabTransactionsTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabTransactionsTbcMain.Name = "tabTransactionsTbcMain"
        Me.tabTransactionsTbcMain.Size = New System.Drawing.Size(1617, 425)
        Me.tabTransactionsTbcMain.TabIndex = 3
        Me.tabTransactionsTbcMain.Text = "Transactions"
        Me.tabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'tbcTransactionsTabTransactionsTbcMain
        '
        Me.tbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(3, 2)
        Me.tbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbcTransactionsTabTransactionsTbcMain.Name = "tbcTransactionsTabTransactionsTbcMain"
        Me.tbcTransactionsTabTransactionsTbcMain.SelectedIndex = 0
        Me.tbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(1620, 423)
        Me.tbcTransactionsTabTransactionsTbcMain.TabIndex = 0
        '
        'tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label25)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label100)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label99)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label101)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label102)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label103)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label104)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain"
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(1612, 394)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 10
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "Make Deposit & Withdrawal, Use Debit Card, and Charge Purchase"
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(23, 252)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 17)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Date:"
        '
        'dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(119, 252)
        Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTb" &
    "cMain"
        Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(267, 22)
        Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 12
        Me.tipMain.SetToolTip(Me.dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "select the date of Transaction")
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(23, 222)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(60, 17)
        Me.Label100.TabIndex = 9
        Me.Label100.Text = "Amount:"
        '
        'nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.DecimalPlaces = 2
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(119, 219)
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbc" &
    "Main"
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 10
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tipMain.SetToolTip(Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "enter the amount for the transaction")
        Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(23, 158)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(80, 17)
        Me.Label99.TabIndex = 5
        Me.Label99.Text = "Account ID:"
        '
        'txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(119, 188)
        Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactions" &
    "TbcMain"
        Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 8
        Me.tipMain.SetToolTip(Me.txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID")
        '
        'cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.FormattingEnabled = True
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(119, 91)
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransaction" &
    "sTbcMain"
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 2
        Me.tipMain.SetToolTip(Me.cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "choose the Customer ID from the combo box")
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(23, 190)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(76, 17)
        Me.Label101.TabIndex = 7
        Me.Label101.Text = "TrxLine ID:"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(23, 94)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(89, 17)
        Me.Label102.TabIndex = 1
        Me.Label102.Text = "Customer ID:"
        '
        'cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.FormattingEnabled = True
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(119, 155)
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactions" &
    "TbcMain"
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 6
        Me.tipMain.SetToolTip(Me.cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "choose the Account ID from the combo box")
        '
        'txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(427, 114)
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Multiline = True
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsT" &
    "bcMain"
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.ReadOnly = True
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(455, 160)
        Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 14
        Me.tipMain.SetToolTip(Me.txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "Information of the transactions performed will be displayed here")
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(424, 96)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(140, 17)
        Me.Label103.TabIndex = 13
        Me.Label103.Text = "ToString Information:"
        '
        'btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(123, 351)
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransaction" &
    "sTbcMain"
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(179, 26)
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 15
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "&Process Transaction"
        Me.tipMain.SetToolTip(Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "click on process transaction to perform the transaction ")
        Me.btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(119, 124)
        Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcM" &
    "ain"
        Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 4
        Me.tipMain.SetToolTip(Me.txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "enter an alpha numeric transaction ID")
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(23, 126)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(49, 17)
        Me.Label104.TabIndex = 3
        Me.Label104.Text = "Trx ID:"
        '
        'grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(23, 12)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain"
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(636, 55)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 0
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabStop = False
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "Type"
        Me.tipMain.SetToolTip(Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "type of transaction ")
        '
        'radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(479, 20)
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTab" &
    "TransactionsTbcMain"
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(139, 21)
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 3
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabStop = True
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "Charge Purchase"
        Me.tipMain.SetToolTip(Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "click on charge purchase")
        Me.radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(327, 20)
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransacti" &
    "onsTbcMain"
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(125, 21)
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 2
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabStop = True
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "Use Debit Card"
        Me.tipMain.SetToolTip(Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "click to use debit card")
        Me.radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(164, 20)
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransact" &
    "ionsTbcMain"
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(136, 21)
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 1
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabStop = True
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "Make Withdrawal"
        Me.tipMain.SetToolTip(Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "click on make withdrawal")
        Me.radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain
        '
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(23, 20)
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Name = "radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTra" &
    "nsactionsTbcMain"
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(115, 21)
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabIndex = 0
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TabStop = True
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "Make Deposit"
        Me.tipMain.SetToolTip(Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, "click on make deposit")
        Me.radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label29)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label28)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label32)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label64)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label65)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label67)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label68)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label66)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label69)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(1612, 394)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 3
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "Make Payment & Transfer Funds"
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(412, 193)
        Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 16
        Me.tipMain.SetToolTip(Me.txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID")
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(293, 199)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 17)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "To TrxLine ID:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(23, 262)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 17)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "Date:"
        '
        'dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(147, 262)
        Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(267, 22)
        Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 12
        Me.tipMain.SetToolTip(Me.dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "select the transaction date")
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(23, 193)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(101, 17)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "To Account ID:"
        '
        'grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(23, 12)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(383, 55)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 0
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabStop = False
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "Type"
        Me.tipMain.SetToolTip(Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "select the type of transaction")
        '
        'radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(164, 20)
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsT" &
    "bcMain"
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(126, 21)
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 1
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabStop = True
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "Transfer Funds"
        Me.tipMain.SetToolTip(Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "click on transfer funds")
        Me.radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(23, 20)
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbc" &
    "Main"
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(122, 21)
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 0
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabStop = True
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "Make Payment"
        Me.tipMain.SetToolTip(Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "click on make payment")
        Me.radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.FormattingEnabled = True
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(147, 192)
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 8
        Me.tipMain.SetToolTip(Me.cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "choose the recipient account ID")
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(23, 161)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(116, 17)
        Me.Label64.TabIndex = 5
        Me.Label64.Text = "From Account ID:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(23, 231)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(60, 17)
        Me.Label65.TabIndex = 9
        Me.Label65.Text = "Amount:"
        '
        'cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.FormattingEnabled = True
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(147, 95)
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 2
        Me.tipMain.SetToolTip(Me.cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "choose the customer id from the combo box")
        '
        'nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.DecimalPlaces = 2
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(147, 226)
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 10
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tipMain.SetToolTip(Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "enter the amount for the transaction ")
        Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(23, 97)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(89, 17)
        Me.Label67.TabIndex = 1
        Me.Label67.Text = "Customer ID:"
        '
        'txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(412, 161)
        Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 14
        Me.tipMain.SetToolTip(Me.txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID")
        '
        'txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(563, 87)
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Multiline = True
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ReadOnly = True
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(385, 197)
        Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 18
        Me.tipMain.SetToolTip(Me.txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "displays the information of the transaction performed")
        '
        'cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.FormattingEnabled = True
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(147, 159)
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 6
        Me.tipMain.SetToolTip(Me.cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "choose the sender account ID")
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(560, 68)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(140, 17)
        Me.Label68.TabIndex = 17
        Me.Label68.Text = "ToString Information:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(293, 159)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(112, 17)
        Me.Label66.TabIndex = 13
        Me.Label66.Text = "From TrxLine ID:"
        '
        'btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(127, 350)
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbc" &
    "Main"
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(179, 26)
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 19
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "&Process Transaction"
        Me.tipMain.SetToolTip(Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "click on process transaction to perform the transaction ")
        Me.btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(147, 128)
        Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain"
        Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TabIndex = 4
        Me.tipMain.SetToolTip(Me.txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, "enter an alpha numeric transaction ID")
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(23, 129)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(49, 17)
        Me.Label69.TabIndex = 3
        Me.Label69.Text = "Trx ID:"
        '
        'tabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label46)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "tabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(1612, 394)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 2
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "Accrue Interest"
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label33)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label30)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label57)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label42)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(25, 44)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(460, 89)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 1
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabStop = False
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "All Accounts"
        Me.tipMain.SetToolTip(Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "informa")
        '
        'txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(115, 53)
        Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsT" &
    "bcMain"
        Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 3
        Me.tipMain.SetToolTip(Me.txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID start ")
        '
        'txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(115, 26)
        Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMai" &
    "n"
        Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID prefix")
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(225, 58)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(122, 17)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "TrxLine ID# Start :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(225, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(119, 17)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "TrxLine ID Prefix :"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(23, 55)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(91, 17)
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "Trx ID# Start:"
        '
        'txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(353, 53)
        Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransacti" &
    "onsTbcMain"
        Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 7
        Me.tipMain.SetToolTip(Me.txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID start ")
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(21, 25)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 17)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Trx ID Prefix:"
        '
        'txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(353, 26)
        Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTb" &
    "cMain"
        Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 5
        Me.tipMain.SetToolTip(Me.txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID prefix")
        '
        'grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label34)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label41)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.Label44)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Controls.Add(Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(25, 177)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(460, 98)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 3
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabStop = False
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "Specific Account"
        '
        'txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(353, 57)
        Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcM" &
    "ain"
        Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 5
        Me.tipMain.SetToolTip(Me.txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID")
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(268, 60)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 17)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "TrxLine ID:"
        '
        'txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(111, 59)
        Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(89, 22)
        Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 3
        Me.tipMain.SetToolTip(Me.txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "enter the transaction line ID")
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(21, 33)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 17)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Account ID:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(21, 62)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(49, 17)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Trx ID:"
        '
        'cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.FormattingEnabled = True
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(111, 31)
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcM" &
    "ain"
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(108, 24)
        Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 1
        Me.tipMain.SetToolTip(Me.cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "choose the account ID from combo box  ")
        '
        'radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(25, 153)
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(133, 21)
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 2
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "Specific Account"
        Me.radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.AutoSize = True
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(25, 20)
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(106, 21)
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 0
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "All Accounts"
        Me.tipMain.SetToolTip(Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "cilck on all accounts")
        Me.radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(512, 44)
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Multiline = True
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ReadOnly = True
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(312, 315)
        Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 5
        Me.tipMain.SetToolTip(Me.txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "displays Information of the accrue Interest ")
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(509, 22)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(140, 17)
        Me.Label46.TabIndex = 4
        Me.Label46.Text = "ToString Information:"
        '
        'btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain
        '
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Location = New System.Drawing.Point(25, 327)
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Name = "btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain"
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Size = New System.Drawing.Size(245, 26)
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TabIndex = 6
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "&Accrue Interest"
        Me.tipMain.SetToolTip(Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain, "click on accrue interest to set the accrue interest for the account")
        Me.btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.UseVisualStyleBackColor = True
        '
        'tabReportsTbcMain
        '
        Me.tabReportsTbcMain.Controls.Add(Me.TextBox4)
        Me.tabReportsTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabReportsTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabReportsTbcMain.Name = "tabReportsTbcMain"
        Me.tabReportsTbcMain.Size = New System.Drawing.Size(1617, 425)
        Me.tabReportsTbcMain.TabIndex = 4
        Me.tabReportsTbcMain.Text = "Reports"
        Me.tabReportsTbcMain.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(669, 203)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(280, 22)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = "#### No reports configured at this time..."
        '
        'tabFilesTbcMain
        '
        Me.tabFilesTbcMain.Controls.Add(Me.btnDisplayBankStatusTabFilesTbcMain)
        Me.tabFilesTbcMain.Controls.Add(Me.btnClearTrxLogTabFilesTbcMain)
        Me.tabFilesTbcMain.Controls.Add(Me.txtFileNameTabFilesTbcMain)
        Me.tabFilesTbcMain.Controls.Add(Me.Label59)
        Me.tabFilesTbcMain.Controls.Add(Me.btnProcessTestDataTabFilesTbcMain)
        Me.tabFilesTbcMain.Controls.Add(Me.btnResetAllTabFilesTbcMain)
        Me.tabFilesTbcMain.Controls.Add(Me.btnSaveTabFilesTbcMain)
        Me.tabFilesTbcMain.Controls.Add(Me.btnOpenTabFilesTbcMain)
        Me.tabFilesTbcMain.Location = New System.Drawing.Point(4, 25)
        Me.tabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabFilesTbcMain.Name = "tabFilesTbcMain"
        Me.tabFilesTbcMain.Size = New System.Drawing.Size(1617, 425)
        Me.tabFilesTbcMain.TabIndex = 5
        Me.tabFilesTbcMain.Text = "Files"
        Me.tabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'btnDisplayBankStatusTabFilesTbcMain
        '
        Me.btnDisplayBankStatusTabFilesTbcMain.Location = New System.Drawing.Point(1015, 144)
        Me.btnDisplayBankStatusTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisplayBankStatusTabFilesTbcMain.Name = "btnDisplayBankStatusTabFilesTbcMain"
        Me.btnDisplayBankStatusTabFilesTbcMain.Size = New System.Drawing.Size(212, 28)
        Me.btnDisplayBankStatusTabFilesTbcMain.TabIndex = 7
        Me.btnDisplayBankStatusTabFilesTbcMain.Text = "Display Bank Status"
        Me.btnDisplayBankStatusTabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'btnClearTrxLogTabFilesTbcMain
        '
        Me.btnClearTrxLogTabFilesTbcMain.Location = New System.Drawing.Point(788, 254)
        Me.btnClearTrxLogTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearTrxLogTabFilesTbcMain.Name = "btnClearTrxLogTabFilesTbcMain"
        Me.btnClearTrxLogTabFilesTbcMain.Size = New System.Drawing.Size(212, 26)
        Me.btnClearTrxLogTabFilesTbcMain.TabIndex = 5
        Me.btnClearTrxLogTabFilesTbcMain.Text = "Clear Trx Log"
        Me.tipMain.SetToolTip(Me.btnClearTrxLogTabFilesTbcMain, "click to clear the transaction log ")
        Me.btnClearTrxLogTabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'txtFileNameTabFilesTbcMain
        '
        Me.txtFileNameTabFilesTbcMain.Location = New System.Drawing.Point(464, 206)
        Me.txtFileNameTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFileNameTabFilesTbcMain.Name = "txtFileNameTabFilesTbcMain"
        Me.txtFileNameTabFilesTbcMain.Size = New System.Drawing.Size(267, 22)
        Me.txtFileNameTabFilesTbcMain.TabIndex = 2
        Me.tipMain.SetToolTip(Me.txtFileNameTabFilesTbcMain, "type the file that is to be opened or written")
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(391, 208)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(69, 17)
        Me.Label59.TabIndex = 1
        Me.Label59.Text = "Filename:"
        '
        'btnProcessTestDataTabFilesTbcMain
        '
        Me.btnProcessTestDataTabFilesTbcMain.Location = New System.Drawing.Point(788, 144)
        Me.btnProcessTestDataTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcessTestDataTabFilesTbcMain.Name = "btnProcessTestDataTabFilesTbcMain"
        Me.btnProcessTestDataTabFilesTbcMain.Size = New System.Drawing.Size(212, 26)
        Me.btnProcessTestDataTabFilesTbcMain.TabIndex = 0
        Me.btnProcessTestDataTabFilesTbcMain.Text = "&Process Test Data"
        Me.tipMain.SetToolTip(Me.btnProcessTestDataTabFilesTbcMain, "click on process test data to display the test data")
        Me.btnProcessTestDataTabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'btnResetAllTabFilesTbcMain
        '
        Me.btnResetAllTabFilesTbcMain.Location = New System.Drawing.Point(1015, 254)
        Me.btnResetAllTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResetAllTabFilesTbcMain.Name = "btnResetAllTabFilesTbcMain"
        Me.btnResetAllTabFilesTbcMain.Size = New System.Drawing.Size(212, 26)
        Me.btnResetAllTabFilesTbcMain.TabIndex = 6
        Me.btnResetAllTabFilesTbcMain.Text = "&Reset All"
        Me.tipMain.SetToolTip(Me.btnResetAllTabFilesTbcMain, "click to reset all ")
        Me.btnResetAllTabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'btnSaveTabFilesTbcMain
        '
        Me.btnSaveTabFilesTbcMain.Location = New System.Drawing.Point(1015, 201)
        Me.btnSaveTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveTabFilesTbcMain.Name = "btnSaveTabFilesTbcMain"
        Me.btnSaveTabFilesTbcMain.Size = New System.Drawing.Size(212, 26)
        Me.btnSaveTabFilesTbcMain.TabIndex = 4
        Me.btnSaveTabFilesTbcMain.Text = "&Save (Write Trx To) File"
        Me.tipMain.SetToolTip(Me.btnSaveTabFilesTbcMain, "click to save (Write Trx To) file")
        Me.btnSaveTabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'btnOpenTabFilesTbcMain
        '
        Me.btnOpenTabFilesTbcMain.Location = New System.Drawing.Point(788, 201)
        Me.btnOpenTabFilesTbcMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOpenTabFilesTbcMain.Name = "btnOpenTabFilesTbcMain"
        Me.btnOpenTabFilesTbcMain.Size = New System.Drawing.Size(212, 26)
        Me.btnOpenTabFilesTbcMain.TabIndex = 3
        Me.btnOpenTabFilesTbcMain.Text = "&Open (Read Trx From) File"
        Me.tipMain.SetToolTip(Me.btnOpenTabFilesTbcMain, "click to open(Read Trx From) the file")
        Me.btnOpenTabFilesTbcMain.UseVisualStyleBackColor = True
        '
        'dlgFileOpen
        '
        Me.dlgFileOpen.FileName = "OpenFileDialog1"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1687, 820)
        Me.Controls.Add(Me.tbcMain)
        Me.Controls.Add(Me.txtTrxLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1707, 870)
        Me.Name = "FrmMain"
        Me.Text = "I"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.tbcMain.ResumeLayout(False)
        Me.tabSummaryTbcMain.ResumeLayout(False)
        Me.tabSummaryTbcMain.PerformLayout()
        Me.grpMetricsTabSummaryTbcMain.ResumeLayout(False)
        Me.grpMetricsTabSummaryTbcMain.PerformLayout()
        Me.tbcCustomerTbcMain.ResumeLayout(False)
        Me.tbcCustomerTbcMain.PerformLayout()
        Me.grpCreateTabCustomerTbcMain.ResumeLayout(False)
        Me.grpCreateTabCustomerTbcMain.PerformLayout()
        Me.tabAccountTbcMain.ResumeLayout(False)
        Me.tabAccountTbcMain.PerformLayout()
        Me.grpClosedTabAccountTbcMain.ResumeLayout(False)
        Me.grpClosedTabAccountTbcMain.PerformLayout()
        Me.grpCreateModifyTabAccountTbcMain.ResumeLayout(False)
        Me.grpCreateModifyTabAccountTbcMain.PerformLayout()
        CType(Me.nudAPRGrpCreateModifyTabAccountTbcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.ResumeLayout(False)
        Me.grpTypeGrpCreateModifyTabAccountTbcMain.PerformLayout()
        Me.tabTransactionsTbcMain.ResumeLayout(False)
        Me.tbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        CType(Me.nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        CType(Me.nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ResumeLayout(False)
        Me.grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.PerformLayout()
        Me.tabReportsTbcMain.ResumeLayout(False)
        Me.tabReportsTbcMain.PerformLayout()
        Me.tabFilesTbcMain.ResumeLayout(False)
        Me.tabFilesTbcMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mniFileMnuMain As ToolStripMenuItem
    Friend WithEvents mniExitMniFileMnuMain As ToolStripMenuItem
    Friend WithEvents mniHelpMnuMain As ToolStripMenuItem
    Friend WithEvents mniAboutMniHelpMnuMain As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrxLog As TextBox
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tabSummaryTbcMain As TabPage
    Friend WithEvents lstTrxLineIDTabSummaryTbcMain As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstTrxIDTabSummaryTbcMain As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstAccountIDTabSummaryTbcMain As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstCustomerIDTabSummaryTbcMain As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbcCustomerTbcMain As TabPage
    Friend WithEvents tabAccountTbcMain As TabPage
    Friend WithEvents tabTransactionsTbcMain As TabPage
    Friend WithEvents tabReportsTbcMain As TabPage
    Friend WithEvents lblCountTrxLineTabSummaryTbcMain As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblCountTrxTabSummaryTbcMain As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCountAccountTabSummaryTbcMain As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCountCustomerTabCustomerTbcMain As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpMetricsTabSummaryTbcMain As GroupBox
    Friend WithEvents txtToStringInfoTabSummaryTbcMain As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMetricsGrpMetricsTabSummaryTbcMain As TextBox
    Friend WithEvents tabFilesTbcMain As TabPage
    Friend WithEvents txtToStringInfoTabCustomerTbcMain As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpBirthdateGrpCreateTabCustomerTbcMain As DateTimePicker
    Friend WithEvents txtNameGrpCreateTabCustomerTbcMain As TextBox
    Friend WithEvents btnCreateCustomerGrpCreateTabCustomerTbcMain As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCountTrxTabCustomerTbcMain As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lstTrxIDTabCustomerTbcMain As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboCustomerIDTabCustomerTbcMain As ComboBox
    Friend WithEvents grpCreateTabCustomerTbcMain As GroupBox
    Friend WithEvents grpCreateModifyTabAccountTbcMain As GroupBox
    Friend WithEvents btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain As Button
    Friend WithEvents cboCustomerIDGrpCreateModifyTabAccountTbcMain As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnCreateAccountTabAccountTbcMain As Button
    Friend WithEvents txtNameGrpCreateModifyTabAccountTbcMain As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents dtpDateOpenedGrpCreateModifyTabAccountTbcMain As DateTimePicker
    Friend WithEvents cboAccountIDTabAccountTbcMain As ComboBox
    Friend WithEvents lblCountTrxLinesTabAccountTbcMain As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lstTrxLineIDTabAccountTbcMain As ListBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtToStringInfoTabAccountTbcMain As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblCountOwnersTabAccountTbcMain As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lstCustomerIDTabAccountTbcMain As ListBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tbcTransactionsTabTransactionsTbcMain As TabControl
    Friend WithEvents tabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TabPage
    Friend WithEvents tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As TabPage
    Friend WithEvents mniOpenMniFileMnuMain As ToolStripMenuItem
    Friend WithEvents mniSaveMniFileMnuMain As ToolStripMenuItem
    Friend WithEvents mniResetAllMniFileMnuMain As ToolStripMenuItem
    Friend WithEvents btnResetAllTabFilesTbcMain As Button
    Friend WithEvents btnSaveTabFilesTbcMain As Button
    Friend WithEvents btnOpenTabFilesTbcMain As Button
    Friend WithEvents tipMain As ToolTip
    Friend WithEvents mniProcessTestDataMniFileMnuMain As ToolStripMenuItem
    Friend WithEvents btnProcessTestDataTabFilesTbcMain As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As NumericUpDown
    Friend WithEvents txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As ComboBox
    Friend WithEvents Label66 As Label
    Friend WithEvents cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As ComboBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As Button
    Friend WithEvents txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents grpTypeGrpCreateModifyTabAccountTbcMain As GroupBox
    Friend WithEvents radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain As RadioButton
    Friend WithEvents radLoanGrpTypeGrpCreateModifyTabAccountTbcMain As RadioButton
    Friend WithEvents radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain As RadioButton
    Friend WithEvents txtAmountGrpCreateModifyTabAccountTbcMain As TextBox
    Friend WithEvents Label94 As Label
    Friend WithEvents grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As GroupBox
    Friend WithEvents Label57 As Label
    Friend WithEvents txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As GroupBox
    Friend WithEvents txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As ComboBox
    Friend WithEvents radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As Button
    Friend WithEvents txtFileNameTabFilesTbcMain As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents dlgFileOpen As OpenFileDialog
    Friend WithEvents btnModifyAccountTabAccountTbcMain As Button
    Friend WithEvents Label97 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents grpClosedTabAccountTbcMain As GroupBox
    Friend WithEvents dtpClosedDateGrpClosedTabAccountTbcMain As DateTimePicker
    Friend WithEvents chkClosedGrpClosedTabAccountTbcMain As CheckBox
    Friend WithEvents Label73 As Label
    Friend WithEvents nudAPRGrpCreateModifyTabAccountTbcMain As NumericUpDown
    Friend WithEvents Label71 As Label
    Friend WithEvents dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain As DateTimePicker
    Friend WithEvents lstNewOwnerIDGrpCreateModifyTabAccountTbcMain As ListBox
    Friend WithEvents Label96 As Label
    Friend WithEvents tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As TabPage
    Friend WithEvents grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As GroupBox
    Friend WithEvents txtTrxLineIDGrpCreateModifyTabAccountTbcMain As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As NumericUpDown
    Friend WithEvents txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As ComboBox
    Friend WithEvents Label101 As Label
    Friend WithEvents cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As ComboBox
    Friend WithEvents Label102 As Label
    Friend WithEvents txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As Button
    Friend WithEvents txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label104 As Label
    Friend WithEvents radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents Label32 As Label
    Friend WithEvents cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As ComboBox
    Friend WithEvents grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As GroupBox
    Friend WithEvents radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As RadioButton
    Friend WithEvents txtTrxIDGrpCreateModifyTabAccountTbcMain As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents btnClearTrxLogTabFilesTbcMain As Button
    Friend WithEvents btnDisplayBankStatusTabFilesTbcMain As Button
End Class

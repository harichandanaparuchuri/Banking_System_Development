
'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               FrmMain.vb
'Author:             Hari Chandana Paruchuri
'Description:        User Interface for the Banking project.
'Date:               2016 Sep 29
'                      - UI finalized: Dan Turk.  Starting point for Project 2.
'                    2016 Oct 2
'                      - Created the FrmMain template,variables and process test data
'                    2016 Oct 9 
'                      - Created button click procedures for Customer and Account
'                    2016 oct 13
'                      - Created button click procedure for Make deposit,withdrawal,use Debit Card,Charge Purchase
'                    2016 Oct 15
'                      - Created button click procedure for Make Payment and Transefer Funds
'                    2016 Oct 17
'                      - Created button clik procedure for Accrue Interest
'                    2016 Nov 9
'                      - Created Business Logic Event Procedures for CustomerCreated ,AccountOpened ,DepositMade 
'                    2016 Nov 10
'                      - Created Business Logic Event Procedures for WithdrawalMade,DebitCardUsed,FundsTransferred 
'                    2016 Nov 11
'                      - Created Business Logic Event Procedures for AccountModified ,InterestAccrued ,PaymentMade ,PurchaseCharged
'                    2016 Nov 12
'                      - Created SelectedIndexChanged procedures for all the list boxes on the Summary tab and Account tab .
'Exceptions:         None Defined.
'Exception-Handling: None.
'Events:             None Defined.
'Event-Handling:     Regular User-Interface Events handled.
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
Imports System.IO
#End Region 'Option / Imports

Public Class FrmMain

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    'To give a name to the Bank using the constant

    Private Const mBANK_NAME = "MY BANK"
    '********** Module-level variables

    'Declaration of the module level variable for the Bank which 
    'is accessed thorughout the FrmMain to perform various operations


    Private WithEvents mMyBank As Bank

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    ' Private and Public get/set methods for the mMyBank variable  

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _aBank As Bank
        Get
            Return mMyBank
        End Get
        Set(ByVal pValue As Bank)
            mMyBank = pValue
        End Set
    End Property '_aBank

    'readonly property for the bank name constant 

    Private ReadOnly Property _BANKNAME As String
        Get
            Return mBANK_NAME
        End Get
    End Property '_BANKNAME
#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************
    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods
    Private Sub _initializeBusinessLogic()

        '_initializeBusinessLogic() reads in and/or sets any starting
        'data the program has or needs to initialize as the program 
        'starts up.

        mMyBank = New Bank(_BANKNAME)


    End Sub '_initializeBusinessLogic()

    Private Sub _initializeUserInterface()

        '_initializeUserInterface() sets the starting configuration
        'of the user interface as the program starts up.

        Me.Text = "Banking Application"
        Me.CancelButton = btnExit
        _clearAllFields()
        txtTrxLog.Text = ""
    End Sub  '_initializeUserInterface()
    Private Sub _clearAllFields()

        '_clearAllFields() clears all the input fields like textboxes 
        ' radio buttons etc.. of the GUI of the User Interface 

        _clearSummaryListAndComboFileds()
        _clearCustomerFields()
        _clearAccountFields()
        _clearTransactionfields()
        cboAccountIDTabAccountTbcMain.Items.Clear()
        cboCustomerIDTabCustomerTbcMain.Items.Clear()
    End Sub '_clearAllFields()
    Private Sub _clearCustomerFields()

        ' _clearCustomerFields() clears all the input fields 
        'present on the Customer tab of the FrmMain 



        cboCustomerIDTabCustomerTbcMain.ResetText()
        lstTrxIDTabCustomerTbcMain.Items.Clear()
        txtNameGrpCreateTabCustomerTbcMain.Clear()
        dtpBirthdateGrpCreateTabCustomerTbcMain.Value = Now
        lblCountTrxTabCustomerTbcMain.ResetText()
        txtToStringInfoTabCustomerTbcMain.Text = ""

    End Sub '_clearCustomerFields()
    Private Sub _clearAccountFields()

        ' _clearAccountFields() clears all the input fields 
        'present on the Account tab of the FrmMain 
        cboAccountIDTabAccountTbcMain.ResetText()

        cboAccountIDTabAccountTbcMain.SelectedIndex = -1
        lblCountOwnersTabAccountTbcMain.Text = ""
        lblCountTrxLinesTabAccountTbcMain.Text = ""
        txtToStringInfoTabAccountTbcMain.Text = ""
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Clear()
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectedIndex = -1
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text = ""
        radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = False
        radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = False
        radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = False
        txtNameGrpCreateModifyTabAccountTbcMain.Clear()
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Value = Date.Now
        txtAmountGrpCreateModifyTabAccountTbcMain.Clear()
        nudAPRGrpCreateModifyTabAccountTbcMain.Value = nudAPRGrpCreateModifyTabAccountTbcMain.Minimum
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Clear()
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Clear()
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Clear()
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Clear()
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Text = ""
        dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Value = Date.Now
        grpClosedTabAccountTbcMain.Enabled = False
        btnModifyAccountTabAccountTbcMain.Enabled = False
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = True
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = True



    End Sub '_clearAccountFields()
    Private Sub _clearTransactionfields()

        ' _clearTransferFields() clears all the input fields 
        'present on the Transfer tab of the FrmMain 

        radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False
        radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False
        radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False
        radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.ResetText()
        txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Clear()
        nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value = nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Minimum
        dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value = Now
        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Clear()
        radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked = False
        radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked = False
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ResetText()
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ResetText()
        txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value = nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Minimum
        dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value = Date.Now
        txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ResetText()
        txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ResetText()
        radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked = False
        cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1
        txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ResetText()
        radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked = False
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = ""
        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = ""
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1
        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1
        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1



    End Sub  '_clearTransactionfields()

    Private Sub _clearSummaryListAndComboFileds()

        ' _clearSummaryListAndComboFileds() clears all the input fields 
        'present on the Summary tab ,list and combo boxes of the FrmMain 
        lstCustomerIDTabSummaryTbcMain.Items.Clear()
        lstTrxIDTabSummaryTbcMain.Items.Clear()
        lstTrxLineIDTabSummaryTbcMain.Items.Clear()
        lstAccountIDTabSummaryTbcMain.Items.Clear()
        txtToStringInfoTabSummaryTbcMain.Text = ""
        lblCountCustomerTabCustomerTbcMain.Text = "0"
        lblCountAccountTabSummaryTbcMain.Text = "0"
        lblCountTrxTabSummaryTbcMain.Text = "0"
        lblCountTrxLineTabSummaryTbcMain.Text = "0"
        lstCustomerIDTabAccountTbcMain.Items.Clear()
        lstTrxLineIDTabAccountTbcMain.Items.Clear()
        cboAccountIDTabAccountTbcMain.Items.Clear()
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Items.Clear()
        cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Items.Clear()

    End Sub '_clearSummaryListAndComboFileds()



    Private Sub _processTestData()

        '_processTestData() is used to test the behavioral methods 
        'which are defined in bank class and event procedures which 
        'are defined in the FrmMain.vb.
        '_processTestData() uses the hard coded test data instead Of
        'Using the data that Is entered from GUI.

        'DECLARE VARIABLES
        'Variable declaration for four customers
        Dim firstCustomer As Customer
        Dim secondCustomer As Customer
        Dim thirdCustomer As Customer
        Dim fourthCustomer As Customer

        'Variable declaration for Eight Accounts(5 Checking Accounts,
        '1 Loan Account,1 CreditCard Account,1 for Modify Account)
        Dim firstCheckingAccount As Transaction
        Dim secondCheckingAccount As Transaction
        Dim thirdCheckingAccount As Transaction
        Dim fourthCheckingAccount As Transaction
        Dim fifthCheckingAccount As Transaction
        Dim theloanAccount As Transaction
        Dim thecreditCardAccount As Transaction
        Dim theCheckingModifiedAccount As Account

        'Variable declaration for all Transactions(1 make deposit ,1 make withdrawal,
        '1 debit card used,1 chargePurchase,1 Transfer funds,2 make payments,
        '1 all accounts accrue interest,3 Specific Accrue Interest )
        Dim theMakeDepositTransaction As Transaction
        Dim theWithdrawalTransaction As Transaction
        Dim theUseDebitCardTransaction As Transaction
        Dim theChargePurchaseTransaction As Transaction
        Dim theFromTransferFundsTransaction As Transaction
        Dim theToTransferFundsTransaction As Transaction = Nothing
        Dim firstFromMakePaymentTransaction As Transaction
        Dim firstToMakePaymentTransaction As Transaction = Nothing
        Dim secondFromMakePaymentTransaction As Transaction
        Dim secondToMakePaymentTransaction As Transaction = Nothing
        Dim theAllAccrueInterestTransaction As Transaction
        Dim firstSpecificAccrueInterestTransaction As Transaction
        Dim secondSpecificAccrueInterestTransaction As Transaction
        Dim thirdSpecificAccrueInterestTransaction As Transaction
        'PROCESSING AND DISPLAYING OUTPUT


        txtTrxLog.Text &=
            vbCrLf & vbCrLf _
           & "** PROCESS TEST DATA **" _
           & vbCrLf _
            & "** TESTING WITH BEHAVIORAL METHODS **"


        'displaying bank Test Data 
        txtTrxLog.Text &= vbCrLf & " BANK INFORMATION :" & _aBank.Tostring()


        'Creating the Customer objects using the Bank class Create Customer methods
        firstCustomer = _aBank.createCustomer("C1",
                                              "Sam Smith",
                                              New Date(1998, 8, 15),
                                              New DateTime(2016, 11, 4, 8, 0, 0))

        'txtTrxLog.Text = "array working"

        secondCustomer = _aBank.createCustomer("C2",
                                               "Sally Jones",
                                               New Date(2000, 1, 1),
                                               New DateTime(2016, 11, 4, 8, 0, 0))

        thirdCustomer = _aBank.createCustomer("C3",
                                              "Tim Alfonso",
                                              New Date(2002, 12, 25),
                                              New DateTime(2016, 11, 4, 8, 0, 0))

        fourthCustomer = _aBank.createCustomer("C4",
                                               "Teresa Willaby",
                                               New Date(2002, 12, 1),
                                               New DateTime(2016, 11, 4, 8, 0, 0))

        ' ACCOUNT PROCESSING AND DISPLAYING OUTPUT
        'First Checking Account processing
        If IsNothing(firstCustomer) And IsNothing(secondCustomer) And IsNothing(thirdCustomer) And IsNothing(fourthCustomer) Then
            MessageBox.Show(" Customers, Accounts,Transactions already exist")
            Exit Sub
        End If
        firstCheckingAccount = _aBank.openAccount(
                         "T1",
                         "TL1",
                         "A1",
                         "Sam's Checking",
                         New Date(2016, 11, 4),
                         1000,
                         1.5D,
                         "C1",
                         AccountType.Checking,
                         False,
                         New Date(9999, 12, 31))

        'Creating credit card bank account 

        thecreditCardAccount = _aBank.openAccount(
                         "T2",
                         "TL2",
                         "A2",
                         "Sam's Credit Card",
                         New Date(2016, 11, 4),
                         0,
                         20D,
                          "C1",
                         AccountType.CreditCard,
                         False,
                         New Date(9999, 12, 31))

        'Creating Loan bank account 

        theloanAccount = _aBank.openAccount(
                         "T3",
                         "TL3",
                         "A3",
                         "Sam's House Loan",
                        New Date(2016, 11, 4),
                         100000,
                         3D,
                        "C1",
                         AccountType.Loan,
                         False,
                         New Date(9999, 12, 31))

        'Second Checking Account processing
        secondCheckingAccount = _aBank.openAccount(
                         "T4",
                         "TL4",
                         "A4",
                         "Sam's 2nd Checking",
                         New Date(2016, 11, 4),
                         500,
                         0D,
                         "C1",
                         AccountType.Checking,
                         False,
                         New Date(9999, 12, 31))
        'Third Checking Account processing
        thirdCheckingAccount = _aBank.openAccount(
                         "T5",
                         "TL5",
                         "A5",
                         "Sally's Checking",
                         New Date(2016, 11, 4),
                         1500,
                         0.5D,
                         "C2",
                         AccountType.Checking,
                         False,
                         New Date(9999, 12, 31))

        'Fourth Checking Account processing
        fourthCheckingAccount = _aBank.openAccount(
                         "T6",
                         "TL6",
                         "A6",
                         "Tim's Checking",
                         New Date(2016, 11, 4),
                         2000,
                         0.1D,
                         "C3",
                         AccountType.Checking,
                         False,
                         New Date(9999, 12, 31))

        'Fifth Checking Account processing
        fifthCheckingAccount = _aBank.openAccount(
                         "T7",
                         "TL7",
                         "A7",
                         "Teresa's Checking",
                         New Date(2016, 11, 4),
                         100,
                         2D,
                         "C4",
                         AccountType.Checking,
                         False,
                         New Date(9999, 12, 31))

        ' Checking modify Account processing
        theCheckingModifiedAccount = _aBank.modifyAccount("C1" & ";" & "C2",
                                                          "A1",
                                                          "Sam's modofied Account",
                                                          1D, True,
                                                          Date.Now)
        'Transactions Processing.

        'Make Deposit Transaction Processing 
        theMakeDepositTransaction = _aBank.makeDepositTransaction(
                                    "T8",
                                    "TL8",
                                    New DateTime(2016, 11, 4, 10, 0, 0),
                                    "A1",
                                    "C1",
                                    TransactionType.MakeDeposit,
                                    500)


        'Withdrawal Transaction Processing 
        theWithdrawalTransaction = _aBank.withdrawalTransaction(
                                    "T9",
                                    "TL9",
                                    New DateTime(2016, 11, 4, 10, 0, 0),
                                   "C1",
                                    "A1",
                                    TransactionType.MakeWithdrawal,
                                    250)




        'Use Debit Card Transaction Processing 
        theUseDebitCardTransaction = _aBank.useDebitCardTransaction(
                                    "T10",
                                    "TL10",
                                    New DateTime(2016, 11, 4, 10, 0, 0),
                                    "C1",
                                    "A1",
                                    TransactionType.UseDebitCard,
                                    25)


        'Charge Purchase Transaction Processing 
        theChargePurchaseTransaction = _aBank.chargePurchaseTransaction(
                                    "T11",
                                    "TL11",
                                     New DateTime(2016, 11, 4, 10, 0, 0),
                                    "C1",
                                    "A2",
                                    TransactionType.ChargePurchase,
                                    75)

        'Transfer Funds Transaction Processing
        theFromTransferFundsTransaction = _aBank.transferFundsTransaction(
                                        "T12",
                                        "TL12",
                                        "TL13",
                                         New DateTime(2016, 11, 4, 11, 0, 0),
                                        "C1",
                                        "A2",
                                        "A1",
                                        TransactionType.TransferFunds,
                                        150,
                                        theToTransferFundsTransaction)

        'First Make Payment Transaction Processing
        firstFromMakePaymentTransaction = _aBank.makePaymentTransaction(
                                        "T13",
                                        "TL14",
                                        "TL15",
                                        New DateTime(2016, 11, 4, 11, 0, 0),
                                        "C1",
                                        "A1",
                                        "A2",
                                        TransactionType.MakePayment,
                                        50,
                                        firstToMakePaymentTransaction
                                        )

        'Second Make Payments Transaction Processing
        secondFromMakePaymentTransaction = _aBank.makePaymentTransaction(
                                        "T14",
                                        "TL16",
                                        "TL17",
                                        New DateTime(2016, 11, 4, 11, 0, 0),
                                        "C1",
                                        "A1",
                                        "A3",
                                        TransactionType.MakePayment,
                                        1500,
                                        secondToMakePaymentTransaction
                                        )

        'Specific Accrue Interest Transaction processing 


        firstSpecificAccrueInterestTransaction = _aBank.specificAccrueInterestTransaction("T15",
                                                                                 "TL18",
                                                                                 New DateTime(2016, 11, 4, 12, 0, 0),
                                                                                 "A1",
                                                                                 TransactionType.AccrueInterest)
        'Second Specific Accrue Interest Transaction processing 
        secondSpecificAccrueInterestTransaction = _aBank.specificAccrueInterestTransaction("T16",
                                                                                 "TL19",
                                                                                 New DateTime(2016, 11, 4, 12, 0, 0),
                                                                                 "A2",
                                                                                 TransactionType.AccrueInterest)
        'Third Specific Accrue Interest Transaction processing 
        thirdSpecificAccrueInterestTransaction = _aBank.specificAccrueInterestTransaction("T17",
                                                                                 "TL20",
                                                                                 New DateTime(2016, 11, 4, 12, 0, 0),
                                                                                 "A3",
                                                                                 TransactionType.AccrueInterest)

        'All Specific Accrue Interest Transaction processing 
        theAllAccrueInterestTransaction = _aBank.accrueInterestTransaction("T", 18,
                                                                           "TL", 21,
                                                                           New DateTime(2016, 11, 4, 12, 00, 00),
                                                                           TransactionType.AccrueInterest
                                                                          )
        'Display OutPut 
        'The output for all the objects created will be displayed in the transaction Log using the event 
        'procedures which are raised in the bank class and listened to in the FrmMain class 

    End Sub '_processTestData()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************


    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system
    Private Sub FrmMain_Load(
                            sender As Object,
                            e As EventArgs) _
        Handles _
                 MyBase.Load

        '_FrmMain_Load() runs when the program initially starts up
        'and causes the business logic data and user-interface
        'fields to be set to their starting values.

        _initializeBusinessLogic()
        _initializeUserInterface()

        'displays the bank information using Tostring()

        txtTrxLog.Text = " BANKING APPLICATION START " & vbCrLf & _aBank.Tostring()

    End Sub 'FrmMain_Load(sender,e)

    Private Sub _btnClose_Click(
                               sender As Object,
                               e As EventArgs) _
        Handles _
                   btnExit.Click,
                   mniExitMniFileMnuMain.Click

        ' _btnClose_Click() fires up when the exit button is 
        ' clicked And closes the running program .


        Me.Close()


    End Sub '_btnClose_Click(sender,e)

    Private Sub _btnCreateCustomerGrpCreateTabCustomerTbcMain_Click(sender As Object,
                                                                    e As EventArgs) _
        Handles _
                  btnCreateCustomerGrpCreateTabCustomerTbcMain.Click


        '_btnCreateCustomerGrpCreateTabCustomerTbcMain_Click() fires 
        'up when the user enter the appropriate data and clicks on the 
        'Create Customer button.This sub procedure is used to create a
        'Customer in the bank .


        'delare variables
        Dim aBankCustomer As Customer
        Dim theCustId As String
        Dim theCustName As String
        Dim theBirthDate As Date

        'Get/Validate Input

        'If and try catch statements for the Customer ID
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the customer Id variable.
        If cboCustomerIDTabCustomerTbcMain.Text = "" Then
            MessageBox.Show("Customer ID must be an ALPHANUMERIC such a CUST001,CUST002,CUST003,etc.,")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End If

        Try
            theCustId = cboCustomerIDTabCustomerTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Customer ID must be an ALPHANUMERIC such a CUST001,CUST002,CUST003,etc.,")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End Try

        'if the combo box already contains that ID then the customer should not be created'
        'if statement checks for the unique value of the customer id
        If cboCustomerIDTabCustomerTbcMain.Items.Contains(theCustId) Then
            MessageBox.Show("The Customer ID already exists. please give a new Customer ID. Ex:C1")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End If

        'If and try-catch for the Customer Name
        'The text box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the customer name variable.
        If txtNameGrpCreateTabCustomerTbcMain.Text = "" Then
            MessageBox.Show("Invalid Customer Name .Enter a Customer Name Ex: Dan Turk")
            txtNameGrpCreateTabCustomerTbcMain.SelectAll()
            txtNameGrpCreateTabCustomerTbcMain.Focus()
            Exit Sub
        End If
        Try
            theCustName = txtNameGrpCreateTabCustomerTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("A valid Customer Name must be entered Ex: CUST-01,etc.,")
            txtNameGrpCreateTabCustomerTbcMain.SelectAll()
            txtNameGrpCreateTabCustomerTbcMain.Focus()
            Exit Sub
        End Try

        'If and Try-catch statements for Date .
        'The datetime picker is checked with current 
        'Date as the birthday of the person cannot be 
        'current Date as the customer creation. 
        'and if not it is assigned to theBirthdate variable.
        If dtpBirthdateGrpCreateTabCustomerTbcMain.Value.Date = DateTime.Now.Date Then
            MessageBox.Show("Birthday cannot be a Current date .Enter a valid date EX:10/17/1995")
            dtpBirthdateGrpCreateTabCustomerTbcMain.Select()
            dtpBirthdateGrpCreateTabCustomerTbcMain.Focus()
            Exit Sub
        End If

        'checks for the condition that birthday cannt be in the future
        If dtpBirthdateGrpCreateTabCustomerTbcMain.Value > Date.Now Then
            MessageBox.Show("Birthday cannot be a future date .Enter a valid date EX:10/17/1995")
            'dtpBirthdateGrpCreateTabCustomerTbcMain.SelectAll()
            dtpBirthdateGrpCreateTabCustomerTbcMain.Select()
            dtpBirthdateGrpCreateTabCustomerTbcMain.Focus()
            Exit Sub
        End If
        theBirthDate = dtpBirthdateGrpCreateTabCustomerTbcMain.Value

        'perform processing
        'calls the bank class create customer public method to 
        'pass the variables for the customer creation.
        If Not IsNothing(_aBank.findCustomer(theCustId)) Then
            MessageBox.Show("The customer already exists with customer Id.please provide unique Id ")
            Exit Sub
        End If
        Try
            aBankCustomer = _aBank.createCustomer(theCustId, theCustName, theBirthDate)
            If IsNothing(aBankCustomer) Then
                MessageBox.Show("The customer could not be created")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("The Customer already exists with the following customer ID.Please create the customer with unique ID.")
            Exit Sub
        End Try


        'display output  

        'the output of the customer creation is displayed in the
        'Transaction Log using the event procedure which Is raised 
        'in the bank class And listened in the frmMai class business
        'logic event procedures _customerCreated(sender,e).

        'Get ready for next input

        'sets the focus() back to Customer class CustoerID combo box
        cboCustomerIDTabCustomerTbcMain.Focus()
        _clearCustomerFields()

    End Sub '_btnCreateCustomerGrpCreateTabCustomerTbcMain_Click(sender,e)


    Private Sub _btnCreateAccountTabAccountTbcMain_Click(sender As Object,
                                                         e As EventArgs) _
        Handles _
                 btnCreateAccountTabAccountTbcMain.Click
        'DECLARE VARIABLES
        Dim aBankAccount As Transaction
        Dim theAccId As String
        Dim theAccountName As String
        Dim theDateOpened As Date
        Dim theBalance As Decimal
        Dim theAnnualPercentageInterestRate As Decimal
        Dim theAccountType As AccountType
        Dim theAccountClosed As Boolean
        Dim theClosedDate As Date
        Dim custID As String
        Dim ID As String
        Dim trxId As String
        Dim trxLineId As String
        Dim custCount As Integer
        'GET/VALIDATE INPUT

        'If and try Catch statements for the Account Id validation
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Account Id variable.
        If cboAccountIDTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Enter a Valid Account ID Ex: ACCT001")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAccId = cboAccountIDTabAccountTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Valid alphanumeric Account ID Ex: ACCT001")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'if the combo box already contains that ID then the Account should not be created'
        'if statement checks for the unique value of the Account id

        If cboAccountIDTabAccountTbcMain.Items.Contains(theAccId) Then
            MessageBox.Show("Account ID already exists. please give a new Account ID Ex:A1")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End If


        'If statement for checking if the customer for that account was created .
        'checks if the customers are created before the account creation using 
        'the Customer ID  count .if the customer ID count is 0 then the message 
        'that the customer should be created first Is dislayed else the selected 
        'Customer Is added to the owner of the account.

        custCount = cboCustomerIDGrpCreateModifyTabAccountTbcMain.Items.Count()
        If custCount = 0 Then
            MessageBox.Show("Please create a Customer before creating an Account. Click OK to continue.." & vbCrLf & vbCrLf & "Note:Customer ID is read only")
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        'If and try Catch statements for the Customer Id validation
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the customer Id variable.

        If cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text = "" Then
            MessageBox.Show("select a Valid alphanumeric Customer ID Ex:Cust001")
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        'Try
        '    custID = cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text
        'Catch ex As Exception
        '    MessageBox.Show("select a Valid alphanumeric customer ID Ex: Cust001")
        '    cboCustomerIDGrpCreateModifyTabAccountTbcMain.SelectAll()
        '    cboCustomerIDGrpCreateModifyTabAccountTbcMain.Focus()
        '    Exit Sub
        'End Try
        If lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count > 0 Then
            For Each ID In lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items
                custID &= ID & ";"
            Next
        Else
            MessageBox.Show("The owners are selected from the combo box into the list box.click on add owners button to add customers to the account")
            Exit Sub
        End If

        'Checking if any of the account type is Checked or Not 
        'if the radio buttons are not checked then it displays a 
        'Message that no radio button is checked .

        If radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = False And
            radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = False And
            radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = False Then
            MessageBox.Show("Click on any one of the account type Ex:Checkings,loan,credit card ")
            grpTypeGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        'If else statements for giving the account type from the radio buttons

        If radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Checked Then
            theAccountType = AccountType.Checking
        ElseIf radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Checked Then
            theAccountType = AccountType.Loan
        Else
            theAccountType = AccountType.CreditCard
        End If

        'If and Try Catch statements for the Account Name 
        'The Test box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Account name variable.
        If txtNameGrpCreateModifyTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Enter a Account Name Ex: Account01")
            txtNameGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtNameGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAccountName = txtNameGrpCreateModifyTabAccountTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Account Name Ex: Account01")
            txtNameGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtNameGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'Date Validation
        'The datetime picker is checked with current 
        'Date as the date opened of an account cannot be 
        'Future Date but can be a current date . 

        If dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Value > Date.Now Then
            MessageBox.Show("Enter a valid date EX:10/17/1995")
            'dtpBirthdateGrpCreateTabCustomerTbcMain.SelectAll()
            dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Select()
            dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        theDateOpened = dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Value

        'If and Try statements for the Amount 
        'The Test box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the balance variable.
        If txtAmountGrpCreateModifyTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Amount must be an decimal such a 200,300.34 ,etc.,")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End If
        Try
            theBalance = Convert.ToDecimal(txtAmountGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("amount must be an decimal such a 200,300.34 ,etc.,")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End Try

        'If and try catch statements for teh APIR
        'The Numeric Up Down box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the balance variable.
        If nudAPRGrpCreateModifyTabAccountTbcMain.Text = "0.00" Then
            MessageBox.Show("Enter a valid Annual Percentage Interest Rate EX:2.5")
            nudAPRGrpCreateModifyTabAccountTbcMain.Select()
            nudAPRGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAnnualPercentageInterestRate = Convert.ToDecimal(nudAPRGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a valid Annual Percentage Interest Rate EX:2.5")
            nudAPRGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'If and try catch statements for the Transaction Id validation
        'The Test box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Transaction ID variable.
        If txtTrxIDGrpCreateModifyTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Enter the Transaction ID Ex: trx-001")
            txtTrxIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtTrxIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            trxId = txtTrxIDGrpCreateModifyTabAccountTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter the Transaction ID Ex: trx-001")
            txtTrxIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtTrxIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try


        'If and try catch statements for the Transaction Line Id validation
        'The Test box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Transaction Line variable.
        If txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Enter the Transaction Line ID Ex: trxln-001")
            txtTrxLineIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            trxLineId = txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter the Transaction Line ID Ex: trxln-001")
            txtTrxLineIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'checks if the transaction ID and transaction Line ID are same or not.
        If trxId = trxLineId Then
            MessageBox.Show("Transaction ID and Transaction Line ID cannot have the same value..Click ok to continue.")
            txtTrxIDGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtTrxIDGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If

        ' If and Try catch statement for the Account closed and closed Date 
        theAccountClosed = chkClosedGrpClosedTabAccountTbcMain.Checked
        If theAccountClosed = True Then
            Try
                theClosedDate = dtpClosedDateGrpClosedTabAccountTbcMain.Value
            Catch ex As Exception
                MessageBox.Show("A Valid date must be entered such as 10/13/2016")
                'dtpBirthdateGrpCreateTabCustomerTbcMain.SelectAll()
                dtpClosedDateGrpClosedTabAccountTbcMain.Select()
                dtpClosedDateGrpClosedTabAccountTbcMain.Focus()
                Exit Sub
            End Try
        End If

        'PERFORM PROCESSING

        'calls the bank class create Account public method to 
        'pass the variables for the Account creation.
        If Not IsNothing(_aBank.findAccount(theAccId)) Then
            MessageBox.Show("theAccount with that Account Id already exists")
            Exit Sub
        End If
        If Not IsNothing(_aBank.findTransaction(trxId)) Then
            MessageBox.Show("The Transaction ID should be unique ")
            Exit Sub
        End If

        For Each FromTransaction In _aBank.iterateTransaction("TransactionLine", trxLineId)
            If Not IsNothing(FromTransaction) Then
                MessageBox.Show("the Transaction Line Id should be unique")
                Exit Sub
            End If
        Next

        Try
            aBankAccount = _aBank.openAccount(trxId, trxLineId, theAccId, theAccountName,
                                          theDateOpened, theBalance, theAnnualPercentageInterestRate,
                                          custID, theAccountType, theAccountClosed, theClosedDate)
            If IsNothing(aBankAccount) Then
                MessageBox.Show("thebank account could not be made")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("The Account already exists with the following customer ID.Please create the Account with unique ID.")
            Exit Sub
        End Try

        'Display Output

        'the output of the Account creation is displayed in the
        'Transaction Log using the event procedure which Is raised 
        'in the bank class And listened in the frmMai class business
        'logic event procedures _AccountOpened(sender,e).

        'Get Ready for the next Input
        cboAccountIDTabAccountTbcMain.Items.Add(aBankAccount.trxAccount.accId)
        cboAccountIDTabAccountTbcMain.Focus()
        _clearAccountFields()

    End Sub '_btnCreateAccountTabAccountTbcMain_Click(sender,e)
    Private Sub _btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain_Click(
                sender As Object,
                e As EventArgs) _
        Handles _
                btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain.Click

        '_btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain_Click(sender,e)Adds the owner Id to the list of owner ID's
        If Not lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Contains(cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text) Then

            lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Add(cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text)
        Else
            MessageBox.Show("The Owner ID already exists in the list")
            Exit Sub
        End If

    End Sub '_btnAddAccountOwnerGrpCreateModifyTabAccountTbcMain_Click(sender,e)
    Private Sub _btnModifyAccountTabAccountTbcMain_Click(
                sender As Object,
                e As EventArgs) _
        Handles _
                btnModifyAccountTabAccountTbcMain.Click
        '_btnModifyAccountTabAccountTbcMain_Click(sender,e) fires up when the modify account button is clicked 
        'it modifies the already existing account using the selected account Id.
        'in the fourth project it will be able to search the account and update it.
        'DECLARE VARIABLES
        Dim aBankAccount As Account
        Dim theAccId As String    '2
        Dim theAccountName As String
        Dim theAnnualPercentageInterestRate As Decimal
        Dim customerID As String
        Dim theAccountClosed As Boolean
        Dim theClosedDate As Date
        Dim accountCount As Integer
        Dim ID As String
        Dim theAccount As Account
        'GET/VALIDATE INPUT

        'if the combo box already contains that ID then the Account should not be created'
        'if statement checks for the unique value of the Account id
        accountCount = cboAccountIDTabAccountTbcMain.Items.Count()
        If accountCount = 0 Then
            MessageBox.Show("Please create a Account before trying to Modify an Account. Click OK to continue..")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End If

        'If and try Catch statements for the Account Id validation
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Account Id variable.
        If cboAccountIDTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Enter a Valid Account ID Ex: ACCT001")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAccId = cboAccountIDTabAccountTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Valid alphanumeric Account ID Ex: ACCT001")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        theAccount = _aBank.findAccount(theAccId)

        If IsNothing(_aBank.findAccount(theAccId)) Then
            MessageBox.Show("the Account with this ID does not exist")
            Exit Sub

        End If

        'If and Try Catch statements for the Account Name 
        'The Test box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Account name variable.
        If txtNameGrpCreateModifyTabAccountTbcMain.Text = "" Then
            MessageBox.Show("Enter a Account Name Ex: Account01")
            txtNameGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtNameGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAccountName = txtNameGrpCreateModifyTabAccountTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Account Name Ex: Account01")
            txtNameGrpCreateModifyTabAccountTbcMain.SelectAll()
            txtNameGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try
        'If and try catch statements for the APIR

        If nudAPRGrpCreateModifyTabAccountTbcMain.Text = "0.00" Then
            MessageBox.Show("Enter a valid Annual Percentage Interest Rate EX:2.5")
            nudAPRGrpCreateModifyTabAccountTbcMain.Select()
            nudAPRGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAnnualPercentageInterestRate = Convert.ToDecimal(nudAPRGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("Enter a valid Annual Percentage Interest Rate EX:2.5")
            nudAPRGrpCreateModifyTabAccountTbcMain.Focus()
            Exit Sub
        End Try



        ' If and Try catch statement for the Account closed and closed Date  
        theAccountClosed = chkClosedGrpClosedTabAccountTbcMain.Checked
        If theAccountClosed = True Then

            'If IsNothing(_aBank.findAccount(theAccId)) Then
            '    MessageBox.Show("The account with that Account Id does not exist")
            '    Exit Sub
            'End If

            'If theAccount.accountType = AccountType.Loan Or theAccount.accountType = AccountType.CreditCard Then
            '    If Not theAccount.balance = 0D Then
            '        MessageBox.Show("Make Payment or Tranfer Funds should be made before Closing it")
            '        Exit Sub
            '    End If
            'End If
            Try
                theClosedDate = dtpClosedDateGrpClosedTabAccountTbcMain.Value
            Catch ex As Exception
                MessageBox.Show("A Valid date must be entered such as 10/13/2016")
                'dtpBirthdateGrpCreateTabCustomerTbcMain.SelectAll()
                dtpClosedDateGrpClosedTabAccountTbcMain.Select()
                dtpClosedDateGrpClosedTabAccountTbcMain.Focus()
                Exit Sub
            End Try
        End If
        customerID = ""
        If lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items.Count > 0 Then
            For Each ID In lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Items
                customerID &= ID & ";"
            Next
        End If
        'PERFORM PROCESSING
        'calls the bank class Modify Account public method to 
        'pass the variables for the Account creation.


        Try
            aBankAccount = _aBank.modifyAccount(customerID, theAccId, theAccountName, theAnnualPercentageInterestRate,
                                            theAccountClosed, theClosedDate) 'customerID, theNoOfOwners, theDateOpened, theBalance,  theNextAccrualDate,

            If IsNothing(aBankAccount) Then
                MessageBox.Show("the Modifing could not be done")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("The Account to be modified does not exist.")
            Exit Sub
        End Try

        'display output

        'the output of the Account Modification is displayed in the
        'Transaction Log using the event procedure which Is raised 
        'in the bank class And listened in the frmMai class business
        'logic event procedures _AccountModified(sender,e).

        'get ready for the next input

        cboAccountIDTabAccountTbcMain.Focus()
        _clearAccountFields()

    End Sub '_btnModifyAccountTabAccountTbcMain_Click(sender,e)


    'Button click procedure for the Make Deposit ,Withdrawal,use Debit Card and Charge Purchase Transactions

    Private Sub _btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_Click _
            (sender As Object, e As EventArgs) _
            Handles btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Click

        'This procedure fires up when the transactions make deposit 
        'Or withdrawal Or charge purchase Or use debit card transaction 
        'Is performed.This button takes the input from the transaction tab ,
        'validates, stores them in variables And calls the bank class 
        'Transaction methods for creating the transaction objects.

        'DECLARE VARIABLES
        Dim aBankTransaction As Transaction
        Dim theTrxId As String
        Dim theTrxLineId As String
        Dim theDateTime As DateTime
        Dim theTrxCustomer As Customer
        Dim theTrxAccount As Account
        Dim theTrxType As TransactionType
        Dim theAmount As Decimal
        Dim trxAccountID As String
        Dim trxCustomerID As String
        'GET/VALIDATE INPUT

        'If and try-catch statements for Transaction type .
        'checks if any of the radio buttons for the transaction type is 
        'checked or not.
        If radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False And
            radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False And
                radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False And
            radChargePurchaseGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked = False Then
            MessageBox.Show("Click on any one of the Transaction Type Ex:Make Deposit ,Withdrawal,use Debit Card,Charge Purchase ")
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        'Assigns the different transaction types to the trxType 
        'variable for different radio buttons clicked .
        If radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked Then

            theTrxType = TransactionType.MakeDeposit

        ElseIf radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked Then

            theTrxType = TransactionType.MakeWithdrawal

        ElseIf radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked Then
            theTrxType = TransactionType.UseDebitCard
        Else
            theTrxType = TransactionType.ChargePurchase
        End If

        'If and try-catch statements for Customer ID.
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the customer Id variable.
        If cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("select a Customer Id such as Cust001 ")
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            trxCustomerID = cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Select a Customer Id such as CUST001 ")
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
        End Try



        'If and try-catch statements for Transaction ID.
        'The text box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Transaction Id variable.
        If txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("Enter a Transaction Id such as trx001 ")
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            theTrxId = txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Transaction Id such as trx001 ")
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'If and try-catch statements for Account ID.
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the account Id variable.
        If cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("Select Account ID from the combo box Ex:ACC001 ")
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            trxAccountID = cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Select Account ID from the combo box Ex:ACC001 ")
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'If and try-catch statements for Transaction line ID.
        'The combo box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the Transaction Id variable.
        If txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("Enter a Transaction Line Id such as TL001 ")
            txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            theTrxLineId = txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Transaction Line Id such as TL001 ")
            txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxLineIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'Checks if the transaction ID and Transaction Line ID
        If theTrxId = theTrxLineId Then
            MessageBox.Show("Transaction ID and Transaction Line ID cannot have the same value.. click OK to continue. ")
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        'Checks if the date of transaction is in the future or not.
        'If it If Then it displays a message saying that it cannot 
        'have the value of future date 
        If dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value > Date.Now Then
            MessageBox.Show("enter a valid date Ex:10/17/1995")
            dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            theDateTime = dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value
        Catch ex As Exception
            MessageBox.Show("enter a valid date Ex:10/17/1995")
            dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            dtpTrxDateTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'If and try-catch statements for  Amount.
        'The Numeric Up Down box is checked if it empty and prints 
        'the error message and if it not empty it is 
        ' assigned to the amount variable.
        If nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value = 0 Then
            MessageBox.Show("Enter the positive valid amount EX:234")
            nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub

        End If
        Try
            theAmount = nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Value
        Catch ex As Exception
            MessageBox.Show("Select the correct Type of Transaction Ex: Use Debit Card")
            nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            nudAmountTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
        End Try

        'PERFROM PROCESSING


        If Not IsNothing(_aBank.findTransaction(theTrxId)) Then
            MessageBox.Show("The Transaction ID should be unique ")
            Exit Sub
        End If

        For Each FromTransaction In _aBank.iterateTransaction("TransactionLine", theTrxLineId)
            If Not IsNothing(FromTransaction) Then
                MessageBox.Show("the Transaction Line Id should be unique")
                Exit Sub
            End If
        Next

        'checks if the radio button is clicked and performs that 
        'radio Button transaction to the data that Is entered in the GUI
        If radMakeDepositGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked Then
            Try
                aBankTransaction = _aBank.makeDepositTransaction(
                                                            theTrxId,
                                                            theTrxLineId,
                                                            theDateTime,
                                                            trxAccountID,
                                                             trxCustomerID,
                                                            theTrxType,
                                                            theAmount)

            Catch ex As Exception
                MessageBox.Show("the Make deposit transaction should be unique ")
                Exit Sub
            End Try

        ElseIf radMakeWDGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked Then
            Try
                aBankTransaction = _aBank.withdrawalTransaction(theTrxId,
                                                            theTrxLineId,
                                                            theDateTime,
                                                            trxCustomerID,
                                                            trxAccountID,
                                                            theTrxType,
                                                            theAmount)

            Catch ex As Exception
                MessageBox.Show("the Make withdrawal transaction should be unique ")
                Exit Sub
            End Try
        ElseIf radUseDCGrpTypeTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Checked Then
            Try
                aBankTransaction = _aBank.useDebitCardTransaction(theTrxId,
                                                            theTrxLineId,
                                                            theDateTime,
                                                            trxCustomerID,
                                                            trxAccountID,
                                                            theTrxType,
                                                            theAmount)

            Catch ex As Exception
                MessageBox.Show("the use debit card transaction should be unique ")
                Exit Sub
            End Try
        Else
            Try
                aBankTransaction = _aBank.chargePurchaseTransaction(theTrxId,
                                                            theTrxLineId,
                                                            theDateTime,
                                                            trxCustomerID,
                                                            trxAccountID,
                                                            theTrxType,
                                                            theAmount)
            Catch ex As Exception
                MessageBox.Show("the charge Purchase transaction should be unique ")
                Exit Sub
            End Try
        End If

        'DISPLAY OUTPUT
        ' Business logic event procedures will display the appropriate outputs 

        'GET READY FOR NEXT INPUT
        'Brings the focus back on the button after the transaction is performed
        btnProcessTestDataTabFilesTbcMain.Focus()
        _clearTransactionfields()

    End Sub   '_btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain(sender,e)



    Private Sub btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_Click(sender As Object,
                                                                                                            e As EventArgs) _
          Handles _
                    btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Click

        'This procedure fires up when the transactions make Payment or   
        'transfer Funds is performed.This button takes the input from 
        'the transaction tab ,validates, stores them in variables And 
        'calls the bank class Transaction methods for creating the 
        'transaction objects.

        'Delcare Variables
        Dim FromTransaction As Transaction
        Dim ToTransaction As Transaction = Nothing
        Dim theTrxId As String
        Dim theFromTrxLineId As String
        Dim theToTrxLineId As String
        Dim FromtrxAccountID As String
        Dim TotrxAccountID As String
        Dim trxCustomerID As String
        Dim theDateTime As DateTime
        Dim theTrxType As TransactionType
        Dim theAmount As Decimal

        'Get/validate Variables

        'If and try-catch statements for assigning the Transaction Type .

        If radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked Then

            theTrxType = TransactionType.MakePayment

        ElseIf radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked Then

            theTrxType = TransactionType.TransferFunds

        End If

        'Checks if any of the radio buttons is clicked or not 
        If radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked = False And
            radTransferFundsGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked = False Then
            MessageBox.Show("Click on any one of the Transaction Type Ex:Make Payments or Transfer Funds")
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        'If and try-catch statements for the Customer ID .
        'checks if the text Box is empty or not
        If cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("select a Customer Id from the combo box Ex:Cust001 ")
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            trxCustomerID = cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("select a valid Customer Id from the combo box Ex:Cust001 ")
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try


        'If and try-catch statements for the Transaction ID .
        'checks if the text Box is empty or not
        If txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("enter a valid Transaction Id Ex:Trx001")
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        Try
            theTrxId = txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("enter a valid Transaction Id Ex:Trx001")
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try


        'If and try-catch statementsfor the From Account ID .
        'checks if the text Box is empty or not
        If cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("select a From Account Id from the combo box Ex: Acc001 ")
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        Try
            FromtrxAccountID = cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("select a valid From Account Id from the combo box Ex: Acc001 ")
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'If and try-catch statements for the To Account ID .
        'checks if the text Box is empty or not
        If cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("select a To Account Id from the combo box Ex: ACC001 ")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        Try
            TotrxAccountID = cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("select a valid To Account Id from the combo box Ex: ACC001 ")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        If FromtrxAccountID = TotrxAccountID Then
            MessageBox.Show("the From Account Id and To Account ID should be different ")
            Exit Sub
        End If
        'If and try-catch statements for the From Transaction Line ID .
        'checks if the text Box is empty or not
        If txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("enter a valid Transaction Line Id Ex:Trx001")
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            theFromTrxLineId = txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("enter a valid Transaction Line Id Ex:Trx001")
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'If and Try-catch statements for To Transaction line ID.
        'checks if the text Box is empty or not
        If txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "" Then
            MessageBox.Show("enter a valid To Transaction Line Id Ex:Trx001")
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            theToTrxLineId = txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text
        Catch ex As Exception
            MessageBox.Show("enter a valid To Transaction Line Id Ex:Trx001")
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'checks if the transaction id is same as transaction Line ID or not
        If theTrxId = theFromTrxLineId And theFromTrxLineId = theToTrxLineId Then
            MessageBox.Show("The Transaction ID and Transaction Line ID's cannot have the same value..Click OK to continue.")
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtTrxIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        'checks if the From transaction line id is same as To transaction Line ID or not
        If theFromTrxLineId = theToTrxLineId Then
            MessageBox.Show("The From Transaction line ID and To Transaction Line ID cannot have the same value..Click OK to continue.")
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtFromTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        'checks if the transaction id is same as To transaction Line ID or not
        If theTrxId = theToTrxLineId Then
            MessageBox.Show("The Transaction ID and To Transaction Line ID cannot have the same value..Click OK to continue.")
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectAll()
            txtToTrxLineIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If



        'If and Try-catch statements for Amount.
        'checks if the Amount is zero or not
        If nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value = 0 Then
            MessageBox.Show("Enter the amount Ex:123")
            nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        Try
            theAmount = nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value
        Catch ex As Exception
            MessageBox.Show("Enter the amount Ex:123")
            nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            nudTrxLineAmountTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        'If and Try-catch statements for Date.
        'checks if the Date is in the future or not.
        'As it cannot hold the future date value it will display the message
        If dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value > Date.Now Then
            MessageBox.Show("enter the valid date Ex:10/17/2016")
            dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        Try
            theDateTime = dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Value
        Catch ex As Exception
            MessageBox.Show("enter the valid date Ex:10/17/2016")
            dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            dtpTrxDateTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'Processing

        'checking if the transaction type is Make Payment ,then complete the make payment transaction 
        If Not IsNothing(_aBank.findTransaction(theTrxId)) Then
            MessageBox.Show("The Transaction ID should be unique ")
            Exit Sub
        End If
        For Each FromTransaction In _aBank.iterateTransaction("TransactionLine", theFromTrxLineId)
            If Not IsNothing(FromTransaction) Then
                MessageBox.Show("theFrom Transaction Line Id should be unique")
                Exit Sub
            End If
        Next
        For Each FromTransaction In _aBank.iterateTransaction("TransactionLine", theToTrxLineId)
            If Not IsNothing(FromTransaction) Then
                MessageBox.Show("the To Transaction Line Id should be unique")
                Exit Sub
            End If
        Next



        If radMakePaymentGrpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Checked Then
            Try
                FromTransaction = _aBank.makePaymentTransaction(theTrxId,
                                                       theFromTrxLineId,
                                                       theToTrxLineId,
                                                       theDateTime,
                                                       trxCustomerID,
                                                       FromtrxAccountID,
                                                       TotrxAccountID,
                                                       theTrxType,
                                                       theAmount,
                                                       ToTransaction)
            Catch ex As Exception
                MessageBox.Show("The Transaction should be unique ")
                Exit Sub
            End Try
            If IsNothing(FromTransaction) Then
                MessageBox.Show("The Transaction ID should be unique ")
                Exit Sub
            End If
        Else
            Try
                FromTransaction = _aBank.transferFundsTransaction(theTrxId,
                                                   theFromTrxLineId,
                                                   theToTrxLineId,
                                                   theDateTime,
                                                   trxCustomerID,
                                                   FromtrxAccountID,
                                                   TotrxAccountID,
                                                   theTrxType,
                                                   theAmount,
                                                   ToTransaction)
            Catch ex As Exception
                MessageBox.Show("The Transaction should be unique ")
            Exit Sub
            End Try
            If IsNothing(FromTransaction) Then
                MessageBox.Show("The Transaction ID should be unique ")
                Exit Sub
            End If
        End If

        'display output

        'the output of the Account Modification is displayed in the
        'Transaction Log using the event procedure which Is raised 
        'in the bank class And listened in the frmMai class business
        'logic event procedures _paymentsMade(sender,e) or _fundsTransferred(sender,e).

        'Get ready for the next input

        'sets the focus back to group and customer ID combo box
        grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
        cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()


        _clearTransactionfields()
    End Sub 'btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain(sender.e)
    Private Sub _btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_Click(sender As Object,
                                                                                               e As EventArgs) _
          Handles _
                   btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Click

        '
        'Declare variables
        Dim trxType As TransactionType
        Dim allAccountTrxLineId As String
        Dim allAccountTrxId As String
        Dim trxLineId As String
        Dim trxId As String
        Dim trxLinePrefixId As String
        Dim trxLineStartId As Integer
        Dim trxPrefixId As String
        Dim trxStartId As Integer
        Dim accountId As String
        'Dim theAccount As Account
        'Dim theCustomer As Customer
        Dim theBankTransaction As Transaction

        'Get/Validate Input

        'if and try-catch statements for accrue interest type radio buttons.
        'checks if any of the radio button is clicked or not
        If radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked = False And
                radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked = False Then
            MessageBox.Show("select all or specific account that you want to accrue interest to.click OK to cotinue.. ")
            Exit Sub
        End If
        ' if statement for all accounts radio buttons 
        'checks for what radio button is clicked and performs the appropriate validations and method calls
        If radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked = True Then
            'try catch for transaction type

            trxType = TransactionType.AccrueInterest


            'if statement for tarnsaction prefix Id
            'checks if the transaction prefix ID is empty or not
            If txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid transaction prefix ID.Enter the transaction prefix Ex:Trx1")
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                trxPrefixId = txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
            Catch ex As Exception
                MessageBox.Show("Invalid transaction prefix ID.Enter the transaction prefix Ex:Trx1")
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try


            'if statement for tarnsaction start Id
            'checks if the transaction start ID is empty or not
            If txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid transaction start ID.Enter the transaction start Ex:Trx1")
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                trxStartId = Integer.Parse(txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text)
            Catch ex As Exception
                MessageBox.Show("Invalid transaction start ID.Enter an integer for the transaction Start Ex:11")
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try



            'if and try-catch statement for transaction line prefix ID
            'checks if the transaction Line prefix ID is empty or not
            If txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid transaction line prefix ID.Enter the transaction line prefix Ex:Trx1")
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                trxLinePrefixId = txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
            Catch ex As Exception
                MessageBox.Show("Invalid transaction line prefix ID.Enter the transaction line prefix Ex:Trx1")
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try
            'if and try-catch statement for transaction line Start ID
            'checks if the transaction Line start ID is empty or not
            If txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid transaction line start ID.Enter the transaction line start Ex:Trx1")
                txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                trxLineStartId = Integer.Parse(txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text)
            Catch ex As Exception
                MessageBox.Show("Invalid transaction line start ID.Enter the transaction line start Ex:Trx1")
                txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try
            'Checks if the trxLinePrefixId is same as trxLineStartId or not.
            If trxLinePrefixId = Convert.ToString(trxLineStartId) Then
                MessageBox.Show("The Transaction Line Prefix ID and the Transaction Line Start Id cannot have the same value.. click OK to continue .. ")
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            'Checks if the trxPrefixId is same as trxStartId or not.
            If trxPrefixId = Convert.ToString(trxStartId) Then
                MessageBox.Show("Transaction Prefix ID and Transaction Start ID cannot have the same values.click ok to continue ")
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If

            'Checks if the trxLinePrefixId is same as trxPrefixId or not.
            If trxLinePrefixId = trxPrefixId Then
                MessageBox.Show("Transaction Prefix ID and Transaction Line Prefix ID cannot have the same values.click ok to continue ")
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If

            'Checks if the trxLineStartId is same as trxStartId or not.
            If trxLineStartId = trxStartId Then
                MessageBox.Show("Transaction Start ID and Transaction Line Start ID cannot have the same values.click ok to continue ")
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            'Checks if the trxLinePrefixId is same as trxStartId or not.
            If trxLinePrefixId = Convert.ToString(trxStartId) Then
                MessageBox.Show("Transaction Start ID and Transaction Line Prefix ID cannot have the same values.click ok to continue ")
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If

            'Checks if the trxLineStartId is same as trxPrefixId or not.
            If Convert.ToString(trxLineStartId) = trxPrefixId Then
                MessageBox.Show("Transaction Prefix ID and Transaction Line Start ID cannot have the same values.click ok to continue ")
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If

            'Processing

            'Calling the accrueInterest transaction method which is present in bank class 
            'Using the module level variable mMyBank and its private property.It is stored in 
            'the temporary Variable theBankTransaction and displayed 
            If Not IsNothing(_aBank.findTransaction(trxPrefixId & trxStartId)) Then
                MessageBox.Show("The Transaction ID should be unique ")
                Exit Sub
            End If
            For Each FromTransaction In _aBank.iterateTransaction("TransactionLine", trxLinePrefixId & trxLineStartId)
                If Not IsNothing(FromTransaction) Then
                    MessageBox.Show("theFrom Transaction Line Id should be unique")
                    Exit Sub
                End If
            Next
            theBankTransaction = _aBank.accrueInterestTransaction(trxPrefixId, trxStartId, trxLinePrefixId, trxLineStartId, Date.Now, trxType)

            If IsNothing(theBankTransaction) Then
                MessageBox.Show("the bank transaction could not be made.")
                Exit Sub
            End If

            'Displaying Output 

            'the output of the Account Modification is displayed in the
            'Transaction Log using the event procedure which Is raised 
            'in the bank class And listened in the frmMai class business
            'logic event procedures _interestAccrued(sender,e) .

            'Get ready for the next Input

            'brings the focus to the radio button
            radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
            _clearTransactionfields()
            Exit Sub
        End If

        'if statement for Specific account. 
        'checks if teh radio button is clicked and performs the appropriate validations and method call

        If radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Checked = True Then

            trxType = TransactionType.AccrueInterest

            'If and try-catch statement for Account ID validation
            'checks if the Account ID is empty or not
            If cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid Account Id .select or enter the Account Id Ex: ACC-001 ")
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                accountId = cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
            Catch ex As Exception
                MessageBox.Show("Invalid Account ID. select or enter the Account Id Ex: ACC-001")
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try

            'If and try-catch statement for Transaction line ID validation
            'checks if the transaction Line ID is empty or not
            If txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid transaction line ID.Enter the transaction line ID Ex: Trx1")
                txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                trxLineId = txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
            Catch ex As Exception
                MessageBox.Show("Invalid transaction line ID.Enter the transaction line ID Ex: Trx1")
                txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try

            'If and try-catch statement for Transaction line ID validation
            'checks if the transaction ID is empty or not
            If txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "" Then
                MessageBox.Show("Invalid transaction ID.Enter the transaction ID Ex: Trx1")
                txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End If
            Try
                trxId = txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text
            Catch ex As Exception
                MessageBox.Show("Invalid transaction ID.Enter the transaction ID Ex: Trx1")
                txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectAll()
                txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
                Exit Sub
            End Try

            'Processing

            'creates a place holder customer which is sent to the transaction method call
            'calls the bank class AccrueInterestTransaction 

            If Not IsNothing(_aBank.findTransaction(trxId)) Then
                MessageBox.Show("The Transaction ID should be unique ")
                Exit Sub
            End If
            For Each FromTransaction In _aBank.iterateTransaction("TransactionLine", trxLineId)
                If Not IsNothing(FromTransaction) Then
                    MessageBox.Show("theFrom Transaction Line Id should be unique")
                    Exit Sub
                End If
            Next
            theBankTransaction = _aBank.specificAccrueInterestTransaction(trxId, trxLineId, Date.Now, accountId, trxType)

            If IsNothing(theBankTransaction) Then
                MessageBox.Show("the bank transaction could not be made.")
                Exit Sub
            End If
            'Displaying Output

            'the output of the Account Modification is displayed in the
            'Transaction Log using the event procedure which Is raised 
            'in the bank class And listened in the frmMai class business
            'logic event procedures _interestAccrued(sender,e) .

            'Get ready for the next Input

            _clearTransactionfields()
            Exit Sub
        End If

    End Sub '_btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_Click(sender,e)


    Private Sub _btnProcessTestDataTabFilesTbcMain_Click(sender As Object,
                                                         e As EventArgs) _
        Handles _
                  btnProcessTestDataTabFilesTbcMain.Click,
                  mniProcessTestDataMniFileMnuMain.Click
        '_btnProcessTestDataTabFilesTbcMain_Click(sender,e)fires up 
        'when the  process test data button is clicked or from the menu tab.
        'This procedure calls the private method _processtestData()

        _processTestData()


    End Sub '_btnProcessTestDataTabFilesTbcMain_Click(sender ,e)




    Private Sub _btnClearTrxLogTabFilesTbcMain_Click(
                sender As Object,
                e As EventArgs) _
        Handles _
                 btnClearTrxLogTabFilesTbcMain.Click

        '_btnClearTrxLogTabFilesTbcMain_Click() clears the transaction log 

        txtTrxLog.Text = ""

    End Sub '_btnClearTrxLogTabFilesTbcMain_Click(sender,e)

    Private Sub _btnResetAllTabFilesTbcMain_Click(
                sender As Object,
                e As EventArgs) _
        Handles _
                btnResetAllTabFilesTbcMain.Click,
                mniResetAllMniFileMnuMain.Click

        '_btnResetAllTabFilesTbcMain_Click(sender,e) calls the 
        '_initializeBusinessLogic() _initializeUserInterface() 
        'which resets the bank entirely erasing the already performed processing.

        _initializeBusinessLogic()
        _initializeUserInterface()


    End Sub '_btnResetAllTabFilesTbcMain_Click(sender,e)


    Private Sub _txtTrxLog_TextChanged(sender As Object,
                                       e As EventArgs) _
        Handles _
                txtTrxLog.TextChanged,
                txtToStringInfoTabSummaryTbcMain.TextChanged,
                txtToStringInfoTabCustomerTbcMain.TextChanged,
                txtToStringInfoTabAccountTbcMain.TextChanged,
                txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TextChanged,
                txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TextChanged,
                txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TextChanged

        'Scrolls the text boxes as the Information is added to them

        'Summary text box scroll 
        txtToStringInfoTabSummaryTbcMain.SelectionStart = txtToStringInfoTabSummaryTbcMain.TextLength
        txtToStringInfoTabSummaryTbcMain.ScrollToCaret()


        'transcation textbox scroll
        txtTrxLog.SelectionStart = txtTrxLog.TextLength
        txtTrxLog.ScrollToCaret()


        'customer textbox scroll
        txtToStringInfoTabCustomerTbcMain.SelectionStart = txtToStringInfoTabCustomerTbcMain.TextLength
        txtToStringInfoTabCustomerTbcMain.ScrollToCaret()


        'account textbox scroll
        txtToStringInfoTabAccountTbcMain.SelectionStart = txtToStringInfoTabAccountTbcMain.TextLength
        txtToStringInfoTabAccountTbcMain.ScrollToCaret()


        'transaction textboxes scroll
        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectionStart = txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.TextLength
        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.ScrollToCaret()
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectionStart = txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.TextLength
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.ScrollToCaret()
        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectionStart = txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.TextLength
        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.ScrollToCaret()


    End Sub '_txtTrxLog_TextChanged(sender,e)

    Private Sub _tbcCustomerTbcMain_Enter(
                        sender As Object,
                        e As EventArgs) _
            Handles _
                        tbcCustomerTbcMain.Enter

        'sets the acceptButton to the button btnCreateCustomerGrpCreateTabCustomerTbcMain

        Me.AcceptButton = btnCreateCustomerGrpCreateTabCustomerTbcMain


    End Sub 'tbcCustomerTbcMain_Enter(sender,e)
    Private Sub _tabAccountTbcMain_Enter(
                        sender As Object,
                        e As EventArgs) _
                Handles _
                        tabAccountTbcMain.Enter
        'sets the acceptButton to the button btnCreateAccountTabAccountTbcMain

        Me.AcceptButton = btnCreateAccountTabAccountTbcMain

        btnModifyAccountTabAccountTbcMain.Enabled = False
        grpClosedTabAccountTbcMain.Enabled = False


    End Sub 'tabAccountTbcMain_Enter(sender,e)
    Private Sub _tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_Enter(
                                            sender As Object,
                                            e As EventArgs) _
                Handles _
                                tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Enter
        'sets the acceptButton to the button btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain

        Me.AcceptButton = btnProcessTrxTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain

    End Sub 'tabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_Enter(sender,e)

    Private Sub _tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_Enter(
                                            sender As Object,
                                            e As EventArgs) _
                Handles _
                                tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Enter

        'sets the acceptButton to the button btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain

        Me.AcceptButton = btnProcessTransactionTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain

    End Sub 'tabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_Enter(sender,e)

    Private Sub tabAccrueInterestTbcTransactionsTabTransactionsTbcMain_Enter(
                                            sender As Object,
                                            e As EventArgs) _
                Handles _
                            tabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enter

        'sets the acceptButton to the button btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain

        Me.AcceptButton = btnAccrueInterestTabAccrueInterestTbcTransactionsTabTransactionsTbcMain

    End Sub '_tabAccrueInterestTbcTransactionsTabTransactionsTbcMain_Enter(sender,e)

    Private Sub _lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                lstCustomerIDTabSummaryTbcMain.SelectedIndexChanged

        '_lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in all the parallel lists to be selected
        'when the corresonding element in lstID is selected.

        'parallel selection
        'Dim selectedIndex = lstCustomerIDTabSummaryTbcMain.SelectedIndex
        'lstAccountIDTabSummaryTbcMain.SelectedIndex = selectedIndex
        'lstTrxIDTabSummaryTbcMain.SelectedIndex = selectedIndex
        'lstTrxLineIDTabSummaryTbcMain.SelectedIndex = selectedIndex

        Dim selectedIndex As Integer
        Dim theCustomer As Customer
        Dim theCustomerAccounts As Account
        Dim theCustomerTransactions As Transaction
        selectedIndex = lstCustomerIDTabSummaryTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        'finds the customer using the customer id  
        Try
            theCustomer = _aBank.findCustomer(lstCustomerIDTabSummaryTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The customer with This ID has not been found")
            lstCustomerIDTabSummaryTbcMain.Select()
            lstCustomerIDTabSummaryTbcMain.Focus()
            Exit Sub
        End Try

        If theCustomer.ToString = Nothing Then
            MessageBox.Show("The customer with This ID has not been found")
            lstCustomerIDTabSummaryTbcMain.Select()
            lstCustomerIDTabSummaryTbcMain.Focus()
            Exit Sub
        End If

        'displays the customer information
        txtToStringInfoTabSummaryTbcMain.Text = "CUSTOMER INFORMATION" & theCustomer.ToString()
        lstAccountIDTabSummaryTbcMain.Items.Clear()
        lstTrxIDTabSummaryTbcMain.Items.Clear()
        lstTrxLineIDTabSummaryTbcMain.Items.Clear()


        For Each theCustomerAccounts In _aBank.iterateAccount(lstCustomerIDTabSummaryTbcMain.Text)
            If Not lstAccountIDTabSummaryTbcMain.Items.Contains(theCustomerAccounts.accId.ToString) Then
                lstAccountIDTabSummaryTbcMain.Items.Add(theCustomerAccounts.accId.ToString)
            End If
        Next

        For Each theCustomerTransactions In _aBank.iterateCustomer(lstCustomerIDTabSummaryTbcMain.Text)
            If Not lstTrxIDTabSummaryTbcMain.Items.Contains(theCustomerTransactions.trxId.ToString) Then
                lstTrxIDTabSummaryTbcMain.Items.Add(theCustomerTransactions.trxId.ToString)
            End If
            If Not lstTrxLineIDTabSummaryTbcMain.Items.Contains(theCustomerTransactions.trxLineId.ToString) Then
                lstTrxLineIDTabSummaryTbcMain.Items.Add(theCustomerTransactions.trxLineId.ToString)
            End If
        Next

        lblCountTrxLineTabSummaryTbcMain.Text = lstTrxLineIDTabSummaryTbcMain.Items.Count.ToString()
        lblCountTrxTabSummaryTbcMain.Text = lstTrxIDTabSummaryTbcMain.Items.Count.ToString()
        lblCountAccountTabSummaryTbcMain.Text = lstAccountIDTabSummaryTbcMain.Items.Count.ToString()
        lstAccountIDTabSummaryTbcMain.SelectedIndex = -1
        lstTrxIDTabSummaryTbcMain.SelectedIndex = -1
        lstTrxLineIDTabSummaryTbcMain.SelectedIndex = -1

    End Sub '_lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged(sender,e)
    Private Sub _lstAccountIDTabSummaryTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                lstAccountIDTabSummaryTbcMain.SelectedIndexChanged

        '_lstAccountIDTabSummaryTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that list to be selected
        'when the corresonding element in list is selected. It is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theAccount As Account
        Dim theAccountTransactions As Transaction
        selectedIndex = lstAccountIDTabSummaryTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        Try
            theAccount = _aBank.findAccount(lstAccountIDTabSummaryTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The Account with This ID has not been found")
            lstAccountIDTabSummaryTbcMain.Select()
            lstAccountIDTabSummaryTbcMain.Focus()
            Exit Sub
        End Try

        If theAccount.ToString = Nothing Then
            MessageBox.Show("The Account with This ID has not been found")
            lstAccountIDTabSummaryTbcMain.Select()
            lstAccountIDTabSummaryTbcMain.Focus()
            Exit Sub
        End If

        txtToStringInfoTabSummaryTbcMain.Text = "ACCOUNT INFORMATION" & theAccount.ToString()
        lstTrxIDTabSummaryTbcMain.Items.Clear()
        lstTrxLineIDTabSummaryTbcMain.Items.Clear()
        For Each theAccountTransactions In _aBank.iterateTransaction("Account", lstAccountIDTabSummaryTbcMain.Text)
            If Not lstTrxIDTabSummaryTbcMain.Items.Contains(theAccountTransactions.trxId.ToString) Then
                lstTrxIDTabSummaryTbcMain.Items.Add(theAccountTransactions.trxId.ToString)
            End If
            If Not lstTrxLineIDTabSummaryTbcMain.Items.Contains(theAccountTransactions.trxLineId.ToString) Then
                lstTrxLineIDTabSummaryTbcMain.Items.Add(theAccountTransactions.trxLineId.ToString)
            End If
        Next
        lblCountTrxLineTabSummaryTbcMain.Text = lstTrxLineIDTabSummaryTbcMain.Items.Count.ToString()
        lblCountTrxTabSummaryTbcMain.Text = lstTrxIDTabSummaryTbcMain.Items.Count.ToString()
        lstCustomerIDTabSummaryTbcMain.SelectedIndex = -1
        lstTrxIDTabSummaryTbcMain.SelectedIndex = -1
        lstTrxLineIDTabSummaryTbcMain.SelectedIndex = -1

    End Sub '_lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged(sender,e) 
    Private Sub _lstTrxIDTabSummaryTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                lstTrxIDTabSummaryTbcMain.SelectedIndexChanged

        '_lstTrxIDTabSummaryTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that list to be selected
        'when the corresonding element in list is selected. It is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theTransaction As Transaction
        selectedIndex = lstTrxIDTabSummaryTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        lstTrxLineIDTabSummaryTbcMain.Items.Clear()
        txtToStringInfoTabSummaryTbcMain.Text = ""
        Try
            For Each theTransaction In _aBank.iterateTransaction("Transaction", lstTrxIDTabSummaryTbcMain.SelectedItem.ToString)
                If IsNothing(theTransaction) Then
                    MessageBox.Show("The Transaction has not been found")
                    lstTrxIDTabSummaryTbcMain.Select()
                    lstTrxIDTabSummaryTbcMain.Focus()
                    Exit Sub
                End If
                txtToStringInfoTabSummaryTbcMain.Text &= "TRANSACTION INFORMATION" & theTransaction.ToString()
                If Not lstTrxLineIDTabSummaryTbcMain.Items.Contains(theTransaction.trxLineId.ToString) Then
                    lstTrxLineIDTabSummaryTbcMain.Items.Add(theTransaction.trxLineId.ToString)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("The Transaction has not been found")
            lstTrxIDTabSummaryTbcMain.Select()
            lstTrxIDTabSummaryTbcMain.Focus()
            Exit Sub
        End Try

        'txtToStringInfoTabSummaryTbcMain.Text = "TRANSACTION INFORMATION" & theTransaction.ToString
        lstAccountIDTabSummaryTbcMain.SelectedIndex = -1
        lstCustomerIDTabSummaryTbcMain.SelectedIndex = -1
        lstTrxLineIDTabSummaryTbcMain.SelectedIndex = -1
    End Sub '_lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged(sender,e)
    Private Sub _lstTrxLineIDTabSummaryTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                lstTrxLineIDTabSummaryTbcMain.SelectedIndexChanged

        '_lstTrxLineIDTabSummaryTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that list to be selected
        'when the corresonding element in list is selected. It is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theTransaction As Transaction
        selectedIndex = lstTrxLineIDTabSummaryTbcMain.SelectedIndex

        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        'theTransaction = _aBank.iterateTransaction("TransactionLine", lstTrxLineIDTabSummaryTbcMain.Text)
        For Each theTransaction In _aBank.iterateTransaction("TransactionLine", lstTrxLineIDTabSummaryTbcMain.Text)
            txtToStringInfoTabSummaryTbcMain.Text = "TRANSACTION LINE INFORMATION" & theTransaction.ToString()
        Next

        ' txtToStringInfoTabSummaryTbcMain.Text = lstTrxLineIDTabSummaryTbcMain.Text
        lstAccountIDTabSummaryTbcMain.SelectedIndex = -1
        lstCustomerIDTabSummaryTbcMain.SelectedIndex = -1
        lstTrxIDTabSummaryTbcMain.SelectedIndex = -1

    End Sub '_lstCustomerIDTabSummaryTbcMain_SelectedIndexChanged(sender,e)
    Private Sub _cboCustomerIDTabCustomerTbcMain_SelectedIndexChanged(
                                                                      sender As Object,
                                                                      e As EventArgs) _
        Handles _
                cboCustomerIDTabCustomerTbcMain.SelectedIndexChanged

        Dim selectedIndex As Integer
        Dim theTrx As Transaction
        selectedIndex = cboCustomerIDTabCustomerTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        lstTrxIDTabCustomerTbcMain.Items.Clear()
        For Each theTrx In _aBank.iterateCustomer(cboCustomerIDTabCustomerTbcMain.Text)
            If Not lstTrxIDTabCustomerTbcMain.Items.Contains(theTrx.trxId.ToString) Then
                lstTrxIDTabCustomerTbcMain.Items.Add(theTrx.trxId.ToString)
            End If

        Next
        lblCountTrxTabCustomerTbcMain.Text = lstTrxIDTabCustomerTbcMain.Items.Count().ToString
    End Sub '_cboCustomerIDTabCustomerTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _lstTrxIDTabCustomerTbcMain_SelectedIndexChanged(
                                                                sender As Object,
                                                                e As EventArgs) _
        Handles _
                lstTrxIDTabCustomerTbcMain.SelectedIndexChanged

        Dim selectedIndex As Integer
        Dim theTrx As Transaction
        selectedIndex = lstTrxIDTabCustomerTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        txtToStringInfoTabCustomerTbcMain.Text = ""
        For Each theTrx In _aBank.iterateTransaction("Transaction", lstTrxIDTabCustomerTbcMain.Text)
            txtToStringInfoTabCustomerTbcMain.Text &= "CUSTOMER TRANSACTIONS" & theTrx.ToString()
        Next


    End Sub '_lstTrxIDTabCustomerTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _lstCustomerIDTabAccountTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                 lstCustomerIDTabAccountTbcMain.SelectedIndexChanged
        '_lstCustomerIDTabAccountTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that list to be selected
        'when the corresonding element in list is selected. It is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theCustomer As Customer
        selectedIndex = lstCustomerIDTabAccountTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        Try
            theCustomer = _aBank.findCustomer(lstCustomerIDTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The customer with This ID has not been found")
            lstCustomerIDTabSummaryTbcMain.Select()
            lstCustomerIDTabSummaryTbcMain.Focus()
            Exit Sub
        End Try

        If theCustomer.ToString = Nothing Then
            MessageBox.Show("The customer with This ID has not been found")
            lstCustomerIDTabSummaryTbcMain.Select()
            lstCustomerIDTabSummaryTbcMain.Focus()
            Exit Sub
        End If
        txtToStringInfoTabAccountTbcMain.Text = "CUSTOMER INFORMATION " & theCustomer.ToString
        lstTrxLineIDTabAccountTbcMain.SelectedIndex = -1
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.SelectedIndex = -1

    End Sub '_lstCustomerIDTabAccountTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _lstTrxLineIDTabAccountTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                 lstTrxLineIDTabAccountTbcMain.SelectedIndexChanged

        '_lstTrxLineIDTabAccountTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that list to be selected
        'when the corresonding element in list is selected. It is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theTransaction As Transaction
        selectedIndex = lstTrxLineIDTabAccountTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        'txtToStringInfoTabAccountTbcMain.Text = lstTrxLineIDTabAccountTbcMain.Text
        For Each theTransaction In _aBank.iterateTransaction("TransactionLine", lstTrxLineIDTabAccountTbcMain.Text)
            txtToStringInfoTabAccountTbcMain.Text = "TRANSACTION LINE INFORMATION" & theTransaction.ToString()
        Next

        lstCustomerIDTabAccountTbcMain.SelectedIndex = -1
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.SelectedIndex = -1

    End Sub '_lstTrxLineIDTabAccountTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _lstNewOwnerIDGrpCreateModifyTabAccountTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
        lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.SelectedIndexChanged

        '_lstNewOwnerIDGrpCreateModifyTabAccountTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that list to be selected
        'when the corresonding element in list is selected. It is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theCustomer As Customer
        selectedIndex = lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If

        Try
            theCustomer = _aBank.findCustomer(lstNewOwnerIDGrpCreateModifyTabAccountTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The customer with This ID has not been found")
            lstCustomerIDTabSummaryTbcMain.Select()
            lstCustomerIDTabSummaryTbcMain.Focus()
            Exit Sub
        End Try

        If theCustomer.ToString = Nothing Then
            MessageBox.Show("The customer with This ID has not been found")
            lstCustomerIDTabSummaryTbcMain.Select()
            lstCustomerIDTabSummaryTbcMain.Focus()
            Exit Sub
        End If
        txtToStringInfoTabAccountTbcMain.Text = " OWNER INFORMATION " & theCustomer.ToString
        lstCustomerIDTabAccountTbcMain.SelectedIndex = -1
        lstTrxLineIDTabAccountTbcMain.SelectedIndex = -1

    End Sub '_lstNewOwnerIDGrpCreateModifyTabAccountTbcMain_SelectedIndexChanged(sender,e)

    Private Sub cboAccountIDTabAccountTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccountIDTabAccountTbcMain.TextUpdate
        '     If Not cboAccountIDTabAccountTbcMain.Items.Contains(cboAccountIDTabAccountTbcMain.DisplayMember) Then

        grpClosedTabAccountTbcMain.Enabled = False
        '  nudAPRGrpCreateModifyTabAccountTbcMain.Enabled = True
        grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = True
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = True

        'Else
        '    grpClosedTabAccountTbcMain.Enabled = True
        '    grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = False
        '    '    nudAPRGrpCreateModifyTabAccountTbcMain.Enabled = False
        '    dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = False
        '    txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = False
        '    txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = False
        '    txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = False

        ' End If


    End Sub 'cboAccountIDTabAccountTbcMain_SelectedIndexChanged(sender,e)


    Private Sub _cboAccountIDTabAccountTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                cboAccountIDTabAccountTbcMain.SelectedIndexChanged

        '_cboAccountIDTabAccountTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theAccount As Account
        Dim theAccountTransactions As Transaction
        selectedIndex = cboAccountIDTabAccountTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If

        'txtToStringInfoTabAccountTbcMain.Text = cboAccountIDTabAccountTbcMain.Text
        theAccount = _aBank.findAccount(cboAccountIDTabAccountTbcMain.Text)

        txtToStringInfoTabAccountTbcMain.Text = theAccount.ToString()
        lstCustomerIDTabAccountTbcMain.Items.Clear()
        lstTrxLineIDTabAccountTbcMain.Items.Clear()
        For Each theAccountTransactions In _aBank.iterateTransaction("Account", cboAccountIDTabAccountTbcMain.Text)
            lstTrxLineIDTabAccountTbcMain.Items.Add(theAccountTransactions.trxLineId)
        Next
        lstCustomerIDTabAccountTbcMain.Items.Add(theAccount.owners(0).custId)
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Text = theAccount.owners(0).custId
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Text = theAccount.dateOpened.ToString
        txtAmountGrpCreateModifyTabAccountTbcMain.Text = theAccount.balance.ToString
        For Each theAccountTransactions In _aBank.iterateTransaction("AccountObject", cboAccountIDTabAccountTbcMain.Text)
            txtTrxIDGrpCreateModifyTabAccountTbcMain.Text = theAccountTransactions.trxId
            txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Text = theAccountTransactions.trxLineId
        Next


        If theAccount.annualPercentageInterestRate = 0 Then
            nudAPRGrpCreateModifyTabAccountTbcMain.Value = nudAPRGrpCreateModifyTabAccountTbcMain.Minimum
        Else
            nudAPRGrpCreateModifyTabAccountTbcMain.Value = theAccount.annualPercentageInterestRate
        End If
        dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text = theAccount.NextAccrualInterestDate.ToString
        txtNameGrpCreateModifyTabAccountTbcMain.Text = theAccount.accountName
        If theAccount.accountType = AccountType.Checking Then
            radCheckingGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = True
        ElseIf theAccount.accountType = AccountType.Loan Then
            radLoanGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = True
        Else
            radCreditCardGrpTypeGrpCreateModifyTabAccountTbcMain.Checked = True
        End If
        lblCountTrxLinesTabAccountTbcMain.Text = lstTrxLineIDTabAccountTbcMain.Items.Count.ToString
        lblCountOwnersTabAccountTbcMain.Text = lstCustomerIDTabAccountTbcMain.Items.Count.ToString
        grpClosedTabAccountTbcMain.Enabled = True
        btnModifyAccountTabAccountTbcMain.Enabled = True
        grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = False
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = False
        txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = False
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = False
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = False
        'grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = True
        'dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = True
        'txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = True
        'txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        'txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = True
    End Sub '_cboAccountIDTabAccountTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                 cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        'cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theCustomer As Customer
        Dim theCustomerAccounts As Account
        selectedIndex = cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        Try
            theCustomer = _aBank.findCustomer(cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The Customer with This ID has not been found")
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        If theCustomer.ToString = Nothing Then
            MessageBox.Show("The Customer with This ID has not been found")
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = theCustomer.ToString

        cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        For Each theCustomerAccounts In _aBank.iterateAccount(cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text)
            If Not cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Contains(theCustomerAccounts.accId.ToString) Then
                cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Add(theCustomerAccounts.accId.ToString)
            End If
        Next


    End Sub '_cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        '_cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theAccount As Account
        selectedIndex = cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        Try
            theAccount = _aBank.findAccount(cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The Account with This ID has not been found")
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        If theAccount.ToString = Nothing Then
            MessageBox.Show("The Account with This ID has not been found")
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If


        txtToStringTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Text = "ACCOUNT INFORMATION" & theAccount.ToString
    End Sub '_cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged()


    Private Sub _cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
            Handles _
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        '_cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theCustomer As Customer
        Dim theCustomerAccounts As Account
        selectedIndex = cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        Try
            theCustomer = _aBank.findCustomer(cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The customer with This ID has not been found")
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        If theCustomer.ToString = Nothing Then
            MessageBox.Show("The customer with This ID has not been found")
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "CUSTOMER INFORMATION" & theCustomer.ToString
        cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Clear()
        For Each theCustomerAccounts In _aBank.iterateAccount(cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text)
            If Not cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Contains(theCustomerAccounts.accId.ToString) Then
                cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(theCustomerAccounts.accId.ToString)
            End If
            If Not cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Contains(theCustomerAccounts.accId.ToString) Then
                cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(theCustomerAccounts.accId.ToString)
            End If
        Next


    End Sub '_cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
         Handles _
                cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        '_cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theFromAccount As Account

        selectedIndex = cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If

        Try
            theFromAccount = _aBank.findAccount(cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The Account with This ID has not been found")
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        If theFromAccount.ToString = Nothing Then
            MessageBox.Show("The Account with This ID has not been found")
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "FROM ACCOUNT INFORMATION" & theFromAccount.ToString
    End Sub '_cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged
        '_cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theToAccount As Account
        selectedIndex = cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If

        'If cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Contains(cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text) Then

        'End If
        Try
            theToAccount = _aBank.findAccount(cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The Account with This ID has not been found")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        If theToAccount.ToString = Nothing Then
            MessageBox.Show("The Account with This ID has not been found")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If
        txtToStringTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Text = "TO ACCOUNT INFORMATION" & theToAccount.ToString

    End Sub '_cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) _
        Handles _
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectedIndexChanged

        '_cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged() causes the corresponding
        'elements in that Combo box to be selected
        'when the corresonding element in combo box is selected. 
        'It Is printed in the ToString Transaction Log
        Dim selectedIndex As Integer
        Dim theAccount As Account
        selectedIndex = cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectedIndex
        If selectedIndex < 0 Then 'no item is selected
            Exit Sub
        End If
        Try
            theAccount = _aBank.findAccount(cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text)
        Catch ex As Exception
            MessageBox.Show("The Account with This ID has not been found")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        If theAccount.ToString = Nothing Then
            MessageBox.Show("The Account with This ID has not been found")
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End If

        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Text = "ACCOUNT INFORMATION" & theAccount.ToString

    End Sub '_cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_SelectedIndexChanged(sender,e)

    Private Sub _radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_CheckedChanged(
                                                                                                        sender As Object,
                                                                                                        e As EventArgs
                                                                                                     ) _
            Handles _
                            radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.CheckedChanged

        '_radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_CheckedChanged() 
        'Is used to disable the specific account accrue interest group box And radio button and 
        'enable the group box of all acount accrue interest 

        grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = True
        grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = False

        'Clear input fields
        cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.SelectedIndex = -1
        txtTrxIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()
        txtTrxLineIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()
        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()

    End Sub '_radAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_CheckedChanged(sender,e)

    Private Sub _radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_CheckedChanged(
                                                                                                            sender As Object,
                                                                                                            e As EventArgs
                                                                                                       ) _
            Handles _
                            radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.CheckedChanged
        '_radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_CheckedChanged() 
        'Is used to disable the all account accrue interest group box And radio button and 
        'enable the group box of specific acount accrue interest 

        grpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = True
        grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Enabled = False

        'Clear input fields
        txtTrxIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()
        txtTrxIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()
        txtTrxLineIDPrefixGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()
        txtTrxLineIDStartNumberGrpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()
        txtToStringTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Clear()

    End Sub '_radSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain_CheckedChanged(sender,e)

    Private Sub _btnOpenTabFilesTbcMain_Click(
                sender As Object,
                e As EventArgs) _
        Handles _
                btnOpenTabFilesTbcMain.Click,
        mniOpenMniFileMnuMain.Click
        'declare variables
        Dim theFileName As String

        'get/validate input

        theFileName = txtFileNameTabFilesTbcMain.Text
        'theFileName = "C:\Users\hari chandana\Desktop\Transaction.txt"
        If theFileName = "" Then
            MessageBox.Show("No File Name is  entered.  Please enter a valid File Name.  Ex: sample.txt")
            txtFileNameTabFilesTbcMain.SelectAll()
            txtFileNameTabFilesTbcMain.Focus()
            Exit Sub
        End If

        If theFileName = Nothing Then
            MessageBox.Show("The file name has not been Entered.please eneter the file name the neds to be read from a file .")
            txtFileNameTabFilesTbcMain.SelectAll()
            txtFileNameTabFilesTbcMain.Focus()
            Exit Sub
        End If
        Try
            _aBank.readFromFileToArray(theFileName)
            MessageBox.Show("Reading from file done successfully")
        Catch ex As Exception
            MessageBox.Show("The reading from file could not be done .")
            btnOpenTabFilesTbcMain.Select()
            btnOpenTabFilesTbcMain.Focus()
            Exit Sub
        End Try

        'Perform Processing
        'get ready for next input
        txtFileNameTabFilesTbcMain.Text = ""
        txtFileNameTabFilesTbcMain.Focus()

    End Sub '_btnOpenTabFilesTbcMain_Click(sender,e)

    Private Sub _btnSaveTabFilesTbcMain_Click(
                sender As Object,
                e As EventArgs) _
        Handles _
                btnSaveTabFilesTbcMain.Click,
                mniSaveMniFileMnuMain.Click
        Dim theFileName As String

        'Get Input/Validate
        theFileName = txtFileNameTabFilesTbcMain.Text
        If theFileName = "" Then
            MessageBox.Show("No File Name is  entered.  Please enter a valid File Name.  Ex: sample.txt")
            txtFileNameTabFilesTbcMain.SelectAll()
            txtFileNameTabFilesTbcMain.Focus()
            Exit Sub
        End If
        If theFileName = Nothing Then
            MessageBox.Show("The file name has not been Entered.please eneter the file name the neds to be read from a file .")
            txtFileNameTabFilesTbcMain.SelectAll()
            txtFileNameTabFilesTbcMain.Focus()
            Exit Sub
        End If
        Try
            _aBank.writeFromArrayToFile(theFileName)
            MessageBox.Show("Writing to file done successfully")
        Catch ex As Exception
            MessageBox.Show("The writing to file could not be done .")
            btnSaveTabFilesTbcMain.Select()
            btnSaveTabFilesTbcMain.Focus()
        End Try


        'Perform processing
        'get ready for next input
        txtFileNameTabFilesTbcMain.Text = ""
        txtFileNameTabFilesTbcMain.Focus()
    End Sub '_btnSaveTabFilesTbcMain_Click(sender,e)

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

    Private Sub _customerCreated(
                ByVal sender As Object,
                ByVal e As EventArgs
                ) _
            Handles _
                    mMyBank.Bank_CustomerCreated
        '_customerCreated() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the customer class ToString()'
        'this also handles the getting ready to next input as in 
        'adding the ID's in various combo boxes and list Boxes.
        Dim theBankEventArgsCustomerCreated As Bank_EventArgs_CustomerCreated
        Dim theEventCustomer As Customer

        theBankEventArgsCustomerCreated = CType(e, Bank_EventArgs_CustomerCreated)

        Try
            theEventCustomer = theBankEventArgsCustomerCreated.customer
        Catch ex As Exception
            MessageBox.Show("ERROR: the Creation of Customer ran into problems. click on OK continue.. ")
            cboCustomerIDTabCustomerTbcMain.SelectAll()
            cboCustomerIDTabCustomerTbcMain.Focus()
            Exit Sub
        End Try

        'checks if the object has a value or not.
        If IsNothing(theEventCustomer) Then
            MessageBox.Show("The Customer object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If

        'adds the ID's to various Combo Boxes and list Boxes
        With theEventCustomer
            lstCustomerIDTabSummaryTbcMain.Items.Add(theEventCustomer.custId)
            cboCustomerIDGrpCreateModifyTabAccountTbcMain.Items.Add(theEventCustomer.custId)
            cboCustomerIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Add(theEventCustomer.custId)
            cboCustomerIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(theEventCustomer.custId)
            lstCustomerIDTabAccountTbcMain.Items.Add(theEventCustomer.custId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            cboCustomerIDTabCustomerTbcMain.Items.Add(theEventCustomer.custId)
        End With

        'display output
        txtTrxLog.Text &=
            vbCrLf _
            & "- CUSTOMER IS CREATED: " & theBankEventArgsCustomerCreated.ToString() & vbCrLf & _aBank.Tostring()

        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If


    End Sub

    Private Sub _accountOpened(
                ByVal sender As Object,
                ByVal e As EventArgs
                ) _
            Handles _
                    mMyBank.Bank_AccountOpened
        '_accountOpened() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Account class ToString()'
        'this also handles the getting ready to next input as in 
        'adding the ID's in various combo boxes and list Boxes.
        Dim theBankEventArgsAccountOpened As Bank_EventArgs_AccountOpened
        Dim theEventAccount As Transaction


        theBankEventArgsAccountOpened = CType(e, Bank_EventArgs_AccountOpened)

        Try
            theEventAccount = theBankEventArgsAccountOpened.account
        Catch ex As Exception
            MessageBox.Show("ERROR: the Creation of Customer ran into problems. click on OK continue.. ")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.

        If IsNothing(theEventAccount) Then
            MessageBox.Show("The Account object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If

        'adds the ID's to various Combo Boxes and list Boxes
        With theEventAccount
            If Not theEventAccount.trxAccount.accountClosed = True Then
                cboAccountIDTabMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Items.Add(theEventAccount.trxAccount.accId)
                cboFromAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(theEventAccount.trxAccount.accId)
                cboToAccountIDTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Items.Add(theEventAccount.trxAccount.accId)
                cboAccountIDGrpSpecificAccountTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Items.Add(theEventAccount.trxAccount.accId)
                cboAccountIDTabAccountTbcMain.Items.Add(theEventAccount.trxAccount.accId)
            End If
            lstAccountIDTabSummaryTbcMain.Items.Add(theEventAccount.trxAccount.accId)
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventAccount.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventAccount.trxLineId)
            'lstCustomerIDTabAccountTbcMain.Items.Add(theEventAccount.trxCustomer.custId)
            lstTrxLineIDTabAccountTbcMain.Items.Add(theEventAccount.trxLineId)
            dtpNextInterestAccrualDateGrpCreateModifyTabAccountTbcMain.Text = theEventAccount.trxAccount.NextAccrualInterestDate().ToString()
        End With

        'display output
        txtTrxLog.Text &=
            vbCrLf _
            & "- ACCOUNT OPENED: " & theBankEventArgsAccountOpened.ToString() & vbCrLf & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub

    Private Sub _accountModified(
                ByVal sender As Object,
                ByVal e As EventArgs
                ) _
            Handles _
                    mMyBank.Bank_AccountModified
        '_accountModified() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Account class ToString()'
        'this also handles the getting ready to next input as in 
        'adding the ID's in various combo boxes and list Boxes.

        Dim theBankEventArgsAccountModified As Bank_EventArgs_AccountModified
        Dim theEventAccount As Account

        theBankEventArgsAccountModified = CType(e, Bank_EventArgs_AccountModified)

        Try
            theEventAccount = theBankEventArgsAccountModified.account
        Catch ex As Exception
            MessageBox.Show("ERROR: the Creation of Customer ran into problems. click on OK continue.. ")
            cboAccountIDTabAccountTbcMain.SelectAll()
            cboAccountIDTabAccountTbcMain.Focus()
            Exit Sub
        End Try

        'checks if the object has a value or not.

        If IsNothing(theEventAccount) Then
            MessageBox.Show("The Account object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If

        'adds the ID's to various Combo Boxes and list Boxes
        'With theEventAccount
        '    'lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
        '    'lstTrxLineIDTabAccountTbcMain.Items.Add(theEventAccount.accountTransactions.trxId)
        'End With

        'display output
        txtTrxLog.Text &=
            vbCrLf _
            & "- ACCOUNT MODIFIED: " & theBankEventArgsAccountModified.ToString() & vbCrLf & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
        'get ready for the next input
        grpClosedTabAccountTbcMain.Enabled = False
        btnModifyAccountTabAccountTbcMain.Enabled = False
        cboCustomerIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        grpTypeGrpCreateModifyTabAccountTbcMain.Enabled = True
        dtpDateOpenedGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtAmountGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxLineIDGrpCreateModifyTabAccountTbcMain.Enabled = True
        txtTrxIDGrpCreateModifyTabAccountTbcMain.Enabled = True

    End Sub


    Private Sub _depositMade(ByVal sender As Object,
                ByVal e As EventArgs
                ) _
            Handles _
                     mMyBank.Bank_DepositMade
        '_depositMade() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 


        Dim theBankEventArgsDepositMade As Bank_EventArgs_DepositMade
        Dim theEventTransaction As Transaction

        theBankEventArgsDepositMade = CType(e, Bank_EventArgs_DepositMade)

        Try
            theEventTransaction = theBankEventArgsDepositMade.depositMade
        Catch ex As Exception
            MessageBox.Show("ERROR: the Making an deposit ran into problems. click on OK continue.. ")
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.

        If IsNothing(theEventTransaction) Then
            MessageBox.Show("The Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes
        With theEventTransaction
            If Not theEventTransaction.trxAccount.accountClosed = True Then

            End If
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxCustomer.custId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxLineId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With

        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " DEPOSIT MADE " & theBankEventArgsDepositMade.ToString() & _aBank.Tostring()

        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If


    End Sub

    Private Sub _withdrawalMade(ByVal sender As Object,
                   ByVal e As EventArgs
                   ) _
               Handles _
                        mMyBank.Bank_WithdrawalMade
        '_withdrawalMade() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 

        Dim theBankEventArgswithdrawalMade As Bank_EventArgs_WithdrawalMade
        Dim theEventTransaction As Transaction

        theBankEventArgswithdrawalMade = CType(e, Bank_EventArgs_WithdrawalMade)

        Try
            theEventTransaction = theBankEventArgswithdrawalMade.withdrawalMade
        Catch ex As Exception
            MessageBox.Show("ERROR: the Making an Withdrawal ran into problems. click on OK continue.. ")
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.
        If IsNothing(theEventTransaction) Then
            MessageBox.Show("The Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes
        With theEventTransaction
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxCustomer.custId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxLineId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With

        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " WITHDRAWAL MADE " & theBankEventArgswithdrawalMade.ToString() & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub

    Private Sub _debitCardUsed(ByVal sender As Object,
                   ByVal e As EventArgs
                   ) _
               Handles _
                        mMyBank.Bank_DebitCardUsed

        '_debitCardUsed() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 


        Dim theBankEventArgsDebitCardUsed As Bank_EventArgs_DebitCardUsed
        Dim theEventTransaction As Transaction

        theBankEventArgsDebitCardUsed = CType(e, Bank_EventArgs_DebitCardUsed)

        Try
            theEventTransaction = theBankEventArgsDebitCardUsed.debitCardUsed
        Catch ex As Exception
            MessageBox.Show("ERROR: Using a Debit Card ran into problems. click on OK continue.. ")
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.
        If IsNothing(theEventTransaction) Then
            MessageBox.Show("The Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes
        With theEventTransaction
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxCustomer.custId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxLineId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With

        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " DEBIT CARD USED " & theBankEventArgsDebitCardUsed.ToString() & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub
    Private Sub _purchasedCharged(ByVal sender As Object,
                   ByVal e As EventArgs
                   ) _
               Handles _
                        mMyBank.Bank_PurchaseCharged
        '_purchasedCharged() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 

        Dim theBankEventArgsPurchasedCharged As Bank_EventArgs_PurchaseCharged
        Dim theEventTransaction As Transaction

        theBankEventArgsPurchasedCharged = CType(e, Bank_EventArgs_PurchaseCharged)

        Try
            theEventTransaction = theBankEventArgsPurchasedCharged.purchaseCharged
        Catch ex As Exception
            MessageBox.Show("ERROR: the purchase charging ran into problems. click on OK continue.. ")
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeMakeDepositMakeWDUseDCChargePurchaseTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.
        If IsNothing(theEventTransaction) Then
            MessageBox.Show("The Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes

        With theEventTransaction
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxCustomer.custId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxLineId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With

        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " PURCHASE CHARGED " & theBankEventArgsPurchasedCharged.ToString() & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub

    Private Sub _paymentMade(ByVal sender As Object,
                   ByVal e As EventArgs
                   ) _
               Handles _
                        mMyBank.Bank_PaymentMade
        '_paymentMade() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 

        Dim theBankEventArgsPaymentMade As Bank_EventArgs_PaymentMade
        Dim theEventFromTransaction As Transaction
        Dim theEventToTransaction As Transaction

        theBankEventArgsPaymentMade = CType(e, Bank_EventArgs_PaymentMade)

        Try
            theEventFromTransaction = theBankEventArgsPaymentMade.fromPaymentMade
        Catch ex As Exception
            MessageBox.Show("ERROR: the Making A Payment ran into problems. click on OK continue.. ")
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        Try
            theEventToTransaction = theBankEventArgsPaymentMade.toPaymentMade
        Catch ex As Exception
            MessageBox.Show("ERROR: the Making A Payment ran into problems. click on OK continue.. ")
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.
        If IsNothing(theEventFromTransaction) Then
            MessageBox.Show("The From Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'checks if the object has a value or not.
        If IsNothing(theEventToTransaction) Then
            MessageBox.Show("The To Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If

        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes

        With theEventFromTransaction
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxCustomer.custId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxLineId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes

        With theEventToTransaction
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventToTransaction.trxLineId)
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventToTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventToTransaction.trxCustomer.custId)
        End With

        'display output
        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " PAYMENT MADE " & theBankEventArgsPaymentMade.ToString() & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub

    Private Sub _fundsTransferred(ByVal sender As Object,
               ByVal e As EventArgs
               ) _
           Handles _
                    mMyBank.Bank_FundsTransferred
        '_fundsTransferred() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 


        Dim theBankEventArgsFundsTransferred As Bank_EventArgs_FundsTransferred
        Dim theEventFromTransaction As Transaction
        Dim theEventToTransaction As Transaction

        theBankEventArgsFundsTransferred = CType(e, Bank_EventArgs_FundsTransferred)

        Try
            theEventFromTransaction = theBankEventArgsFundsTransferred.fromFundsTransferred
        Catch ex As Exception
            MessageBox.Show("ERROR: the Transferring Funds ran into problems. click on OK continue.. ")
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try

        Try
            theEventToTransaction = theBankEventArgsFundsTransferred.toFundsTransferred
        Catch ex As Exception
            MessageBox.Show("ERROR: the Transferring Funds ran into problems. click on OK continue.. ")
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Select()
            grpTypeTabMakePaymentTransferFundsTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.
        If IsNothing(theEventFromTransaction) Then
            MessageBox.Show("The From Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'checks if the object has a value or not.
        If IsNothing(theEventToTransaction) Then
            MessageBox.Show("The To Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes

        With theEventFromTransaction
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxCustomer.custId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventFromTransaction.trxLineId)
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes

        With theEventToTransaction
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventToTransaction.trxLineId)
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventToTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventToTransaction.trxCustomer.custId)
        End With

        'display output
        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " FUNDS TRANSFERRED " & theBankEventArgsFundsTransferred.ToString() & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub

    Private Sub _interestAccrued(ByVal sender As Object,
                   ByVal e As EventArgs
                   ) _
               Handles _
                        mMyBank.Bank_InterestAccrued
        '_interestAccrued() is the event procedure which handles 
        'the event rasied in the bank class and display the object 
        'in the transaction log using the EventArgs class tostring()
        'which in turn calls the Transaction class ToString()'
        'this also handles the getting ready to next input as in 
        Dim theBankEventArgsInterestAccrued As Bank_EventArgs_InterestAccrued
        Dim theEventTransaction As Transaction

        theBankEventArgsInterestAccrued = CType(e, Bank_EventArgs_InterestAccrued)

        Try
            theEventTransaction = theBankEventArgsInterestAccrued.interestAccrued
        Catch ex As Exception
            MessageBox.Show("ERROR: the accruing Interest ran into problems. click on OK continue.. ")
            grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Select()
            grpAllAccountsTabAccrueInterestTbcTransactionsTabTransactionsTbcMain.Focus()
            Exit Sub
        End Try
        'checks if the object has a value or not.
        If IsNothing(theEventTransaction) Then
            MessageBox.Show("The Transaction object  Holds Nothing ..Click Ok to continue.")
            Exit Sub
        End If
        'adds the ID's to various Combo Boxes and list Boxes and Displays the bank variables in the textboxes

        With theEventTransaction
            'lstAccountIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxAccount.accId)
            'lstCustomerIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxCustomer.custId)
            lstTrxLineIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxLineId)
            lstTrxIDTabSummaryTbcMain.Items.Add(theEventTransaction.trxId)
            lblCountCustomerTabCustomerTbcMain.Text = _aBank.NoOfCustomers.ToString()
            lblCountAccountTabSummaryTbcMain.Text = _aBank.NoOfAccounts.ToString()
            lblCountTrxTabSummaryTbcMain.Text = _aBank.NoOfTransactions.ToString()
            lblCountTrxLineTabSummaryTbcMain.Text = _aBank.NoOfTransactionLines.ToString()
        End With

        txtTrxLog.Text &= vbCrLf &
             " TRANSACTION CREATED :" & vbCrLf _
              & " INTEREST ACCRUED " & theBankEventArgsInterestAccrued.ToString() & _aBank.Tostring()
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = ""
        txtMetricsGrpMetricsTabSummaryTbcMain.Text = "The average age of Customers is " & _aBank.averageAge()
        If _aBank.NoOfAccounts > 0 Then
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is " & _aBank.calculateAverageAccountBalance()
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  " & _aBank.getLargestAmountOwed()
        Else
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The average balance in all the Checking Accounts is 0"
            txtMetricsGrpMetricsTabSummaryTbcMain.Text &= vbCrLf & "The largest Amount owed by a customer  0"

        End If
    End Sub

    Private Sub _btnDisplayBankStatusTabFilesTbcMain_Click(
                                                          sender As Object,
                                                          e As EventArgs) _
        Handles _
                btnDisplayBankStatusTabFilesTbcMain.Click
        'Displays the Bank status
        txtTrxLog.Text = "BANK STATUS:" & vbCrLf & _aBank.Tostring()

    End Sub




#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'FrmMain
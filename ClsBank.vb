'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsBank.vb
'Author:             Hari Chandana Paruchuri
'Description:        Business Logic of Bank class for the Banking project.
'Date:               2016 Oct 3
'                      - Created the Bank class,Module level variables 
'                        and Get/Set methods for the variables.
'                    2016 Oct 4 
'                      - Created the special constructor and ToString method.
'                    2016 oct 6
'                      - Created function for the CreateCustomer and OpenAccount
'                    2016 oct 13
'                      - Created Function for Make deposit,withdrawal,use Debit Card,
'                        Charge Purchase
'                    2016 Oct 15
'                      - Created Function for Make Payment and Transefer Funds
'                    2016 Oct 17
'                      - Created Function for Accrue Interest
'                    2016 Nov 9
'                      - Created events for customer, account and seven transactions 
'                        and raised events in the behavioral methods.
'                    2016 Nov 10 
'                      - Created the behavioral method for modify account and 
'                        rasied account modified In it.
'Tier:               Business Logic 
'Exceptions:         None Defined.
'Exception-Handling: None.
'Events:             Bank_CustomerCreated,Bank_AccountOpened,Bank_AccountModified,
'                    Bank_depositMade, Bank_DebitCardUsed, Bank_WithdrawalMade, 
'                    Bank_PurchasedCharged, Bank_PaymentsMade, Bank_FundsTransferred,
'                    Bank_InterestAccrued.
'Event-Handling:     None.
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
Imports System.IO
#End Region 'Option / Imports

Public Class Bank

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    Private Const mCUSTOMER_ARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mCUSTOMER_ARRAY_INCREMENT_DEFAULT As Integer = 5
    Private Const mACCOUNT_ARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mACCOUNT_ARRAY_INCREMENT_DEFAULT As Integer = 5
    Private Const mTRANSACTION_ARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mTRANSACTION_ARRAY_INCREMENT_DEFAULT As Integer = 5
    Private Const mTRANSACTIONRECORD_ARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mTRANSACTIONRECORD_ARRAY_INCREMENT_DEFAULT As Integer = 5
    '********** Module-level variables

    Private mBankName As String
    Private mNoOfCustomers As Integer
    Private mNoOfAccounts As Integer
    Private mNoOfTransactions As Integer
    Private mNoOfTransactionLines As Integer
    Private mCustomer() As Customer
    Private mMaxCustomer As Integer 'max number of customers.
    Private mAccount() As Account
    Private mMaxAccount As Integer 'max number of Accounts.
    Private mTransaction() As Transaction
    Private mMaxTransaction As Integer 'max number of transactions.
    Private mTransactionRecord() As String
    Private mNoOfTransactionRecordLines As Integer
    Private mMaxTransactionRecord As Integer 'max number of transactionsRecord.


#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************


    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes
    Public Sub New(ByVal pBankName As String)
        ' new constructor of bank will be called from the 
        ' initializeBusinessLogic() of FrmMain.vb 

        MyBase.New()
        _bankName = pBankName
        ' This call is required by the designer.
        ' Not normally needed in Business Logic class constructors, though.
        _maxCustomer = _CUSTOMER_ARRAY_SIZE_DEFAULT
        ReDim mCustomer(_maxCustomer - 1)
        _noOfCustomers = 0
        _maxAccount = _ACCOUNT_ARRAY_SIZE_DEFAULT
        ReDim mAccount(_maxAccount - 1)
        _noOfAccounts = 0
        _maxTransaction = _TRANSACTION_ARRAY_SIZE_DEFAULT
        ReDim mTransaction(_maxTransaction - 1)
        _noOfTransactions = 0
        _noOfTransactionLines = 0
        _maxTransactionRecord = _TRANSACTIONRECORD_ARRAY_SIZE_DEFAULT
        ReDim mTransactionRecord(_maxTransactionRecord - 1)
        _noOfTransactionRecordLines = 0
    End Sub 'new(pBankName)
    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************


    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public Property bankName As String
        Get
            Return _bankName

        End Get
        Set(ByVal pValue As String)
            _bankName = pValue
        End Set
    End Property 'bankName
    Public Property NoOfCustomers As Integer
        Get
            Return _noOfCustomers
        End Get
        Set(ByVal pValue As Integer)
            _noOfCustomers = pValue
        End Set
    End Property 'NoOfCustomers
    Public Property NoOfAccounts As Integer
        Get
            Return _noOfAccounts
        End Get
        Set(ByVal pValue As Integer)
            _noOfAccounts = pValue
        End Set
    End Property 'NoOfAccounts

    Public Property NoOfTransactions As Integer
        Get
            Return _noOfTransactions
        End Get
        Set(ByVal pValue As Integer)
            _noOfTransactions = pValue
        End Set
    End Property 'NoOfTransactions

    Public Property NoOfTransactionLines As Integer
        Get
            Return _noOfTransactionLines
        End Get
        Set(ByVal pValue As Integer)
            _noOfTransactionLines = pValue
        End Set
    End Property 'NoOfTransactionLines

    Public Property noOfTransactionRecordLines As Integer
        Get
            Return _noOfTransactionRecordLines
        End Get
        Set(ByVal pValue As Integer)
            _noOfTransactionRecordLines = pValue
        End Set
    End Property 'NoOfTransactionLines

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _bankName As String
        Get
            Return mBankName

        End Get
        Set(ByVal pValue As String)
            mBankName = pValue
        End Set
    End Property '_bankName
    Private Property _noOfCustomers As Integer
        Get
            Return mNoOfCustomers

        End Get
        Set(ByVal pValue As Integer)
            mNoOfCustomers = pValue
        End Set
    End Property '_noOfCustomers

    Private Property _noOfAccounts As Integer

        Get
            Return mNoOfAccounts
        End Get
        Set(ByVal pValue As Integer)
            mNoOfAccounts = pValue
        End Set
    End Property '_noOfAccounts

    Private Property _noOfTransactions As Integer

        Get
            Return mNoOfTransactions

        End Get
        Set(ByVal pValue As Integer)
            mNoOfTransactions = pValue
        End Set
    End Property '_noOfTransactions

    Private Property _noOfTransactionLines As Integer

        Get
            Return mNoOfTransactionLines

        End Get
        Set(ByVal pValue As Integer)
            mNoOfTransactionLines = pValue
        End Set
    End Property '_noOfTransactionLines

    Private Property _customer As Customer()
        Get
            Return mCustomer
        End Get
        Set(pValue As Customer())
            mCustomer = pValue
        End Set
    End Property
    Private Property _maxCustomer As Integer
        Get
            Return mMaxCustomer
        End Get
        Set(pValue As Integer)
            mMaxCustomer = pValue
        End Set
    End Property


    Private ReadOnly Property _CUSTOMER_ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mCUSTOMER_ARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _CUSTOMER_ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mCUSTOMER_ARRAY_INCREMENT_DEFAULT
        End Get
    End Property

    Private Property _account As Account()
        Get
            Return mAccount
        End Get
        Set(pValue As Account())
            mAccount = pValue
        End Set
    End Property
    Private Property _maxAccount As Integer
        Get
            Return mMaxAccount
        End Get
        Set(pValue As Integer)
            mMaxAccount = pValue
        End Set
    End Property


    Private ReadOnly Property _ACCOUNT_ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mACCOUNT_ARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _ACCOUNT_ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mACCOUNT_ARRAY_INCREMENT_DEFAULT
        End Get
    End Property


    Private Property _transaction As Transaction()
        Get
            Return mTransaction
        End Get
        Set(pValue As Transaction())
            mTransaction = pValue
        End Set
    End Property
    Private Property _maxTransaction As Integer
        Get
            Return mMaxTransaction
        End Get
        Set(pValue As Integer)
            mMaxTransaction = pValue
        End Set
    End Property

    Private Property _transactionRecord As String()
        Get
            Return mTransactionRecord
        End Get
        Set(pValue As String())
            mTransactionRecord = pValue
        End Set
    End Property
    Private Property _maxTransactionRecord As Integer
        Get
            Return mMaxTransactionRecord
        End Get
        Set(pValue As Integer)
            mMaxTransactionRecord = pValue
        End Set
    End Property

    Private Property _noOfTransactionRecordLines As Integer
        Get
            Return mNoOfTransactionRecordLines
        End Get
        Set(pValue As Integer)
            mNoOfTransactionRecordLines = pValue
        End Set
    End Property

    Private ReadOnly Property _TRANSACTION_ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mTRANSACTION_ARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _TRANSACTION_ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mTRANSACTION_ARRAY_INCREMENT_DEFAULT
        End Get
    End Property
    Private ReadOnly Property _TRANSACTIONRECORD_ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mTRANSACTION_ARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _TRANSACTIONRECORD_ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mTRANSACTION_ARRAY_INCREMENT_DEFAULT
        End Get
    End Property
    Private Property _ithCustomer(ByVal pIndex As Integer) As Customer
        Get
            'assumes :0<=pCustomerID <_numCustomer
            'throws an IndexOutOfRangeException if this is not the case
            'ithCustomer is used to get the value of the customer in the ith index
            If pIndex >= 0 And pIndex < _maxCustomer Then
                Return mCustomer(pIndex)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pValue As Customer)
            'ithCustomer is used to set the value of the customer in the ith index
            If pIndex >= 0 And pIndex < _maxCustomer Then
                mCustomer(pIndex) = pValue
            End If
        End Set
    End Property
    Private Property _ithAccount(ByVal pIndex As Integer) As Account
        Get
            'assumes :0<=pAccountID <_numAccount
            'throws an IndexOutOfRangeException if this is not the case
            'ithAccount is used to get the value of the account in the ith index
            If pIndex >= 0 And pIndex < _maxAccount Then
                Return mAccount(pIndex)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pValue As Account)
            'ithAccount is used to set the value of the account in the ith index
            If pIndex >= 0 And pIndex < _maxAccount Then
                mAccount(pIndex) = pValue
            End If
        End Set
    End Property
    Private Property _ithTransaction(ByVal pIndex As Integer) As Transaction
        Get
            'assumes :0<=pTransactionID <_numTransaction
            'throws an IndexOutOfRangeException if this is not the case
            'ithTransaction is used to get the value of the transaction in the ith index
            If pIndex >= 0 And pIndex < _maxTransaction Then
                Return mTransaction(pIndex)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pValue As Transaction)
            'ithTransaction is used to set the value of the transaction in the ith index
            If pIndex >= 0 And pIndex < _maxTransaction Then
                mTransaction(pIndex) = pValue
            End If
        End Set
    End Property

    Private Property _ithTransactionRecord(ByVal pIndex As Integer) As String
        Get
            'assumes :0<=pTransactionID <_numTransaction
            'throws an IndexOutOfRangeException if this is not the case
            'ithTransactionRecord is used to get the value of the transactionRecord in the ith index
            If pIndex >= _noOfTransactionRecordLines And pIndex < _maxTransactionRecord Then
                Return mTransactionRecord(pIndex)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pValue As String)
            'ithTransactionRecord is used to set the value of the transactionRecord in the ith index
            If pIndex >= _noOfTransactionRecordLines And pIndex < _maxTransactionRecord Then
                mTransactionRecord(pIndex) = pValue
            End If
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    'Public Function for Tostring method.
    Public Overrides Function Tostring() As String

        'ToString is fired from the Business Logic class.
        ' Returns the private _toString() method which displays the 
        'bank information.

        Return _toString()

    End Function 'Tostring()

    'Public Function for Create Customer
    Public Function createCustomer(ByVal pCustId As String,
                                   ByVal pCustName As String,
                                   ByVal pBirthDate As Date,
                                   Optional ByVal pRefDate As Date = Nothing) As Customer

        'call the private method _createCustomer() 
        'which in turn returns an Customer object.

        Return _createCustomer(pCustId,
                               pCustName,
                               pBirthDate,
                               pRefDate)

    End Function   'createCustomer(ByVal pCustId As String,ByVal pCustName As String,ByVal pBirthDate As Date) As Customer

    'Public Function for Opening Account
    Public Function openAccount(
                   ByVal pTrxId As String,
                   ByVal pTrxLineId As String,
                   ByVal pAccId As String,
                   ByVal pAccountName As String,
                   ByVal pDateOpened As Date,
                   ByVal pBalance As Decimal,
                   ByVal pAnnualPercentageInterestRate As Decimal,
                   ByVal pOwnerId As String,
                   ByVal pAccountType As AccountType,
                   ByVal pAccountClosed As Boolean,
                   ByVal pClosedDate As Date) As Transaction

        'call the private method _openAccount() 
        'which in turn returns an Transaction object as opening an accout 
        'is similar to making initial deposit .

        Return _openAccount(pTrxId, pTrxLineId, pAccId, pAccountName, pDateOpened, pBalance,
                                    pAnnualPercentageInterestRate, pOwnerId, pAccountType, pAccountClosed, pClosedDate)


    End Function 'openAccount(pAccId, pAccountName, pnoOfOwners, pDateOpened, pBalance, pAnnualPercentageInterestRate, pOwnerId,pNextAccrualDate, pAccountType, pAccountClosed, pClosedDate)

    'Public function for Modify account
    Public Function modifyAccount(
                                 ByVal pOwnerId As String,
                   ByVal pAccId As String,
                   ByVal pAccountName As String,
                   ByVal pAnnualPercentageInterestRate As Decimal,
                   ByVal pAccountClosed As Boolean,
                   ByVal pClosedDate As Date) As Account 'ByVal pCustomID As String,ByVal pnoOfOwners As Integer,ByVal pDateOpened As Date,  ByVal pBalance As Decimal,ByVal pNextAccrualDate As Date,


        'call the private method _modifyAccount() 
        'which in turn returns an Account object.


        Return _modifyAccount(pOwnerId, pAccId, pAccountName, pAnnualPercentageInterestRate,
                              pAccountClosed, pClosedDate) 'pCustomID, pnoOfOwners, pDateOpened, pBalance, pNextAccrualDate,


    End Function 'modifyAccount(pAccId, pAccountName, pnoOfOwners, pDateOpened, pBalance, pAnnualPercentageInterestRate, pOwnerId,pNextAccrualDate, pAccountType, pAccountClosed, pClosedDate)

    'public function for Making deposit
    Public Function makeDepositTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                           ByVal pAccountID As String,
                                           ByVal pCustomerID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal,
                                          Optional ByVal pTheAccount As Account = Nothing) As Transaction


        'call the private method _makeDepositTransaction() 
        'which in turn returns an Transaction object.
        Return _makeDepositTransaction(pTransactionId,
                                       pTransactionLineId,
                                       pTransactionDate,
                                       pAccountID,
                                       pCustomerID,
                                       pTransactionType,
                                       pTransactionAmount,
                                       pTheAccount)

    End Function 'makeDepositTransaction( pTransactionId , pTransactionLineId , pTransactionDate , pTransactionCustomer , pTransactionAccount , pTransactionType , pTransactionAmount )

    'public function for withdrawal transaction 
    Public Function withdrawalTransaction(
                                         ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                         ByVal pCustomerID As String,
                                         ByVal pAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal) As Transaction

        'call the private method _withdrawalTransaction() 
        'which in turn returns an Transaction object.

        Return _withdrawalTransaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           pCustomerID,
                                           pAccountID,
                                           pTransactionType,
                                           pTransactionAmount)
    End Function 'withdrawalTransaction( pTransactionId , pTransactionLineId , pTransactionDate , pTransactionCustomer , pTransactionAccount , pTransactionType , pTransactionAmount )

    'public function for using debit card
    Public Function useDebitCardTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                            ByVal pCustomerID As String,
                                           ByVal pAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal) As Transaction

        'call the private method _useDebitCardTransaction() 
        'which in turn returns an Transaction object.

        Return _useDebitCardTransaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           pCustomerID,
                                           pAccountID,
                                           pTransactionType,
                                           pTransactionAmount)
    End Function 'useDebitCardTransaction( pTransactionId , pTransactionLineId , pTransactionDate , pTransactionCustomer , pTransactionAccount , pTransactionType , pTransactionAmount )


    'public function for Charge Purchase.
    Public Function chargePurchaseTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                            ByVal pCustomerID As String,
                                           ByVal pAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal) As Transaction

        'call the private method _chargePurchaseTransaction() 
        'which in turn returns an Transaction object.

        Return _chargePurchaseTransaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           pCustomerID,
                                           pAccountID,
                                           pTransactionType,
                                           pTransactionAmount)
    End Function 'chargePurchaseTransaction( pTransactionId , pTransactionLineId , pTransactionDate , pTransactionCustomer , pTransactionAccount, pTransactionType , pTransactionAmount )

    ' public function for make payment transaction
    Public Function makePaymentTransaction(ByVal pTransactionId As String,
                                           ByVal pFromTransactionLineId As String,
                                           ByVal pToTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                           ByVal pTransactionCustomerId As String,
                                           ByVal pFromAccountID As String,
                                           ByVal pToAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal,
                                           ByRef pToTransactionId As Transaction) As Transaction

        'call the private method _makePaymentTransaction() 
        'which in turn returns an Transaction object.

        Return _makePaymentTransaction(pTransactionId,
                                           pFromTransactionLineId,
                                           pToTransactionLineId,
                                           pTransactionDate,
                                           pTransactionCustomerId,
                                           pFromAccountID,
                                           pToAccountID,
                                           pTransactionType,
                                           pTransactionAmount,
                                           pToTransactionId)


    End Function 'makePaymentTransaction( pTransactionId , pFromTransactionLineId ,pToTransactionLineId , pTransactionDate , pTransactionCustomerId , pFromAccountID , pToAccountID ,pTransactionType ,pTransactionAmount, pToTransaction )


    ' Public function for transfer funds 
    Public Function transferFundsTransaction(ByVal pTransactionId As String,
                                           ByVal pFromTransactionLineId As String,
                                           ByVal pToTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                           ByVal pTransactionCustomerId As String,
                                           ByVal pFromAccountID As String,
                                           ByVal pToAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal,
                                           ByRef pToTransactionId As Transaction) As Transaction


        'call the private method _transferFunds() 
        'which in turn returns an Transaction object.

        Return _transferFunds(pTransactionId,
                                           pFromTransactionLineId,
                                           pToTransactionLineId,
                                           pTransactionDate,
                                           pTransactionCustomerId,
                                           pFromAccountID,
                                           pToAccountID,
                                           pTransactionType,
                                           pTransactionAmount,
                                           pToTransactionId)



    End Function '_transferFundsTransaction( pTransactionId , pFromTransactionLineId ,pToTransactionLineId , pTransactionDate , pTransactionCustomerId , pFromAccountID , pToAccountID ,pTransactionType ,pTransactionAmount, pToTransaction )

    'Public function for Accrue Interest

    Public Function specificAccrueInterestTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                              ByVal pAccountId As String,
                                           ByVal pTransactionType As TransactionType
                                           ) As Transaction

        'call the private method _accrueIntetrestTransaction() 
        'which in turn returns an Transaction object.

        Return _specificAccrueIntetrestTransaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           pAccountId,
                                          pTransactionType)



    End Function 'accrueIntetrestTransaction(pTransactionId,pTransactionLineId,pTransactionDate,pTransactionCustomer,pTransactionAccount,pTransactionType,pTransactionAmount)
    Public Function accrueInterestTransaction(ByVal pTrxPrefixId As String,
                                              ByVal pTrxStartId As Integer,
                                              ByVal pTrxLinePrefixId As String,
                                              ByVal pTrxLineStartId As Integer,
                                              ByVal pTransactionDate As Date,
                                              ByVal pTransactionType As TransactionType
                                             ) As Transaction

        'call the private method _accrueIntetrestTransaction() 
        'which in turn returns an Transaction object.

        Return _accrueIntetrestTransaction(pTrxPrefixId,
                                           pTrxStartId,
                                           pTrxLinePrefixId,
                                           pTrxLineStartId,
                                           pTransactionDate,
                                           pTransactionType)



    End Function 'accrueIntetrestTransaction(pTransactionId,pTransactionLineId,pTransactionDate,pTransactionCustomer,pTransactionAccount,pTransactionType,pTransactionAmount)

    Public Function findCustomer(
                                ByVal pCustomerID As String
                                ) As Customer
        'calls the private findCustomer method which finds the 
        'Customer based on the customer ID And location of the customer
        Dim foundLocation As Integer
        Return _findCustomer(pCustomerID, foundLocation)
    End Function 'findCustomer(pCustomerID)

    Public Function findAccount(
                                ByVal pAccountID As String
                                ) As Account
        'calls the private findAccount method which finds the 
        'Account based on the cAccount ID And location of the account
        Dim foundLocation As Integer
        Return _findAccount(pAccountID, foundLocation)
    End Function 'findAccount(pAccountID)

    Public Function findTransaction(
                                ByVal pTransactionID As String
                                ) As Transaction
        'calls the private findTransaction method which finds the 
        'Account based on the tarnsaction ID And location of the Transaction
        Dim foundLocation As Integer
        Return _findTransaction(pTransactionID, foundLocation)
    End Function 'findTransaction(pTransactionID)

    Public Iterator Function iterateCustomer(ByVal pId As String) _
        As _
            IEnumerable
        'This is used to interate through the customers 
        'List to yield the transaction object based on the customer id
        Dim theObject As Object

        For Each theObject In _iterateCustomer(pId)

            Yield theObject

        Next theObject

    End Function 'iterateCustomer()
    Public Function calculateAverageAccountBalance() As String
        Return _calculateAverageAccountBalance()
    End Function
    Public Iterator Function iterateAccount(ByVal pId As String) _
        As _
            IEnumerable
        'This is used to interate through the Account 
        'List to yield the transaction object based  on accountId
        Dim theObject As Object

        For Each theObject In _iterateAccount(pId)

            Yield theObject

        Next theObject

    End Function 'iterateAccount()
    Public Function getLargestAmountOwed() As String
        Return _getLargestAmountOwed()
    End Function
    Public Iterator Function iterateTransaction(ByVal pIdentifier As String,
                                                ByVal pId As String
                                               ) _
        As _
            IEnumerable
        'This is used to interate through the Transaction 
        'List to yield the relevent object based on identifier and Id
        Dim theObject As Object

        For Each theObject In _iterateTransaction(pIdentifier, pId)

            Yield theObject

        Next theObject

    End Function 'iterateTransaction()

    Public Iterator Function iterateTransactionRecord(
                                               ) _
        As _
            IEnumerable
        'This is used to interate through the TransactionRecord 
        'List to yield the transaction Record string object based 
        'On identifier and Id
        Dim theObject As Object

        For Each theObject In _iterateTransactionRecord()
            Yield theObject
        Next theObject

    End Function 'iterateTransaction()

    Public Sub writeFromArrayToFile(ByVal pFileName As String)

        'calls the private _writefromArrayToFile(pFileName)
        'which is used to write the transaction record string array 
        'to the file .
        Try
            _writeFromArrayToFile(pFileName)
        Catch ex As Exception

        End Try


    End Sub '_writeFromArrayToFile()

    Public Function averageAge() As String
        Return _AverageAge()
    End Function
    Public Sub readFromFileToArray(ByVal pFileName As String)


        'calls the private _readFromFileToArray(pFileName)
        'which is used to read the file and write it to the arrays 
        Try
            _readFromFileToArray(pFileName)
        Catch ex As Exception
            Throw ex
        End Try


    End Sub '_readFromFileToArray()


    '*************** Private Non-Shared Behavioral Methods  ********************


    'Private function for creating a customer .
    Private Function _createCustomer(ByVal pCustId As String,
                                     ByVal pCustName As String,
                                     ByVal pBirthDate As Date,
                                     Optional ByVal pRefDate As Date = Nothing) As Customer

        'This private method is used to create the customer object using the 
        'new constructor of customer class. This method return the customer 
        'Object to the public method and raises the CustomerCreated event procedure.

        Dim bankCustomer As Customer
        Dim bankCustomerString As String
        Dim i As Integer

        'checks if the customer id already exists or not 
        For i = 0 To _noOfCustomers - 1
            If _ithCustomer(i).custId = pCustId Then
                Return Nothing
                Exit Function
            End If

        Next i

        'calls the constructor for creating the customer object
        bankCustomer = New Customer(pCustId, pCustName, pBirthDate)

        'checks if the array size is full or not .
        'If it Is Then it increments the array size
        If _noOfCustomers >= _maxCustomer Then
            _maxCustomer += _CUSTOMER_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mCustomer(_maxCustomer - 1)
        End If

        'do processing
        'stores the customer object in the in the customer array.
        Try
            _ithCustomer(_noOfCustomers) = bankCustomer
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'stores the customer information in to the string
        bankCustomerString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                             & "; " & "Customer" _
                             & "; " & "Create" _
                             & "; " & bankCustomer.custId _
                             & "; " & bankCustomer.custName _
                             & "; " & bankCustomer.birthdate.ToString("yyyyMMdd")

        ' & ";" & New DateTime(Date.Now.Hour, Date.Now.Minute, Date.Now.Second) _
        _transactionRecordArrayAddition(bankCustomerString)

        'Increments the customer count of the bank 
        _noOfCustomers += 1

        'Raising the event for creating a Customer which is listened 
        'in the frmMain class business logic event procedure _customerCreated(sender,e).

        RaiseEvent Bank_CustomerCreated(
                       Me,
                       New Bank_EventArgs_CustomerCreated(bankCustomer, pRefDate))
        Return bankCustomer

    End Function 'createCustomer(pCustId,pCustName,pBirthDate)

    'This is used to open an Account.
    Private Function _openAccount(
                   ByVal pTrxId As String,
                   ByVal pTrxLineId As String,
                   ByVal pAccId As String,
                   ByVal pAccountName As String,
                   ByVal pDateOpened As Date,
                   ByVal pBalance As Decimal,
                   ByVal pAnnualPercentageInterestRate As Decimal,
                   ByVal pOwnerIds As String,
                   ByVal pAccountType As AccountType,
                   ByVal pAccountClosed As Boolean,
                   ByVal pClosedDate As Date) As Transaction

        'This private method is used to create the account and transaction object using the 
        'new constructor of Account and Transaction class.This method return the transaction 
        'Object to the public method and raises the AccountOpened event procedure.

        Dim theOwners As Customer() = Nothing
        Dim theAccount As Account
        Dim accountOwner As String
        Dim theBankAccount As Transaction
        Dim theOwner As Customer


        'if the account type is other than checkings ,
        'the amount entered Is taken in the negative value 
        If pAccountType = AccountType.Loan Or pAccountType = AccountType.CreditCard Then
            pBalance = -pBalance
        End If

        'checks if the account already present in the array or not

        For i = 0 To _noOfAccounts - 1
            If _ithAccount(i).accId = pAccId Then
                Return Nothing
                Exit Function
            End If
        Next i

        'calls the new consructor for creating the account object
        theAccount = New Account(pAccId,
                                 pAccountName,
                                 pDateOpened,
                                 pBalance,
                                 pAnnualPercentageInterestRate,
                                 pAccountType,
                                 pAccountClosed,
                                 pClosedDate)

        ' theOwners,

        'adds the owners to the accounts 
        If Not pOwnerIds = String.Empty Then
            For Each accountOwner In Split(pOwnerIds.TrimEnd(";"c), ";")
                theAccount.addOwners(findCustomer(accountOwner)) 'null point here that is the reason the read from file is not happening
            Next
        End If


        theAccount.owners = theAccount.getAccountOwners()

        'calls the make deposit function for opening an account
        theBankAccount = _makeDepositTransaction(
                                                 pTrxId,
                                                 pTrxLineId,
                                                 pDateOpened,
                                                 pAccId,
                                                accountOwner,
                                                 TransactionType.OpenAccount,
                                                 pBalance, theAccount)

        'checks the array size and increments it
        If _noOfAccounts >= _maxAccount Then
            _maxAccount += _ACCOUNT_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mAccount(_maxAccount - 1)
        End If

        'do processing
        Try
            _ithAccount(_noOfAccounts) = theAccount
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try
        'Increments the number of Accounts in the Bank and the owners in Account object
        _noOfAccounts += 1
        'theBankAccount.trxAccount.noOfOwners = 1

        'Raising the event for Opening a bank Account which is listened 
        'in the frmMain class business logic event procedure _accountOpened(sender,e).
        RaiseEvent Bank_AccountOpened(
                       Me,
                       New Bank_EventArgs_AccountOpened(theBankAccount))

        Return theBankAccount

    End Function 'openAccount(pAccId, pAccountName, pnoOfOwners, pDateOpened, pBalance, pAnnualPercentageInterestRate, pOwnerId,pNextAccrualDate, pAccountType, pAccountClosed, pClosedDate)

    'Private function for modify account
    Private Function _modifyAccount(
                   ByVal pOwnerId As String,
                   ByVal pAccId As String,
                   ByVal pAccountName As String,
                   ByVal pAnnualPercentageInterestRate As Decimal,
                   ByVal pAccountClosed As Boolean,
                   ByVal pClosedDate As Date) As Account 'ByVal pOwnerID As String,ByVal pNoOfOwners As Integer,ByVal pDateOpened As Date,byVal pBalance As Decimal, ByVal pNextAccrualDate As Date,
        'This private method is used to Modify the account which is already created (in the 4th project) 
        'Using the new constructor of Account class.This method return the Account object to the public 
        'method And raises the AccountModified event procedure.

        Dim theOwner As Customer
        Dim theBalance As Decimal
        Dim theAccount As Account
        Dim bankAccountString As String
        Dim theId As String

        'finds the account based on the account Id
        theAccount = findAccount(pAccId)

        If IsNothing(theAccount) Then
            Return Nothing
            Exit Function
        End If

        'adds the account owners to the account
        If Not pOwnerId = String.Empty Then
            For Each theId In Split(pOwnerId.TrimEnd(";"c), ";")
                If IsNothing(theAccount.findOwner(theId)) Then
                    theAccount.addOwners(findCustomer(theId))
                    bankAccountString = Date.Now.ToString("yyyyMMdd") _
                         & "; " & Date.Now.ToString("hhmm") _
                         & "; " & "AddOwner" _
                         & ": " & theAccount.accId _
                         & "; " & theId
                    _transactionRecordArrayAddition(bankAccountString)
                End If
            Next

        End If

        'modifies the account name
        If Not theAccount.accountName = pAccountName Then
            theAccount.accountName = pAccountName
            bankAccountString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                             & "; " & "UpdateName" _
                             & "; " & theAccount.accId _
                             & "; " & theAccount.accountName
            _transactionRecordArrayAddition(bankAccountString)
        End If
        'modifies the account APR
        If Not theAccount.annualPercentageInterestRate = pAnnualPercentageInterestRate Then
            theAccount.annualPercentageInterestRate = pAnnualPercentageInterestRate
            bankAccountString = Date.Now.ToString("yyyyMMdd") _
                            & "; " & Date.Now.ToString("hhmm") _
                            & "; " & "UpdateInterestRate" _
                            & ": " & theAccount.accId _
                            & "; " & pAnnualPercentageInterestRate
            _transactionRecordArrayAddition(bankAccountString)
        End If

        'closes the account
        If Not theAccount.accountClosed = pAccountClosed Then
            theAccount.accountClosed = pAccountClosed
            bankAccountString = Date.Now.ToString("yyyyMMdd") _
                          & "; " & Date.Now.ToString("hhmm") _
                          & "; " & "Close" _
                          & ": " & theAccount.accId

            _transactionRecordArrayAddition(bankAccountString)

        End If

        'If pAccountClosed = True Then
        '    If Not theAccount.accountType Then
        '        theBalance = theAccount.balance
        '        _withdrawalTransaction()
        '    End If
        theAccount.closedDate = pClosedDate



        'Raising the event for Modifing a bank Account which is listened 
        'in the frmMain class business logic event procedure _accountModified(sender,e).

        RaiseEvent Bank_AccountModified(
                       Me,
                       New Bank_EventArgs_AccountModified(theAccount))


        Return theAccount
    End Function 'modifyAccount(pAccId, pAccountName, pnoOfOwners, pDateOpened, pBalance, pAnnualPercentageInterestRate, pOwnerId,pNextAccrualDate, pAccountType, pAccountClosed, pClosedDate)


    'Private function For make deposit transaction
    Private Function _makeDepositTransaction(
                                            ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                            ByVal pAccountID As String,
                                            ByVal pCustomerID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal,
                                            Optional ByVal pAccount As Account = Nothing) As Transaction


        'This private method is used to Make a deposit in the account Using the new constructor of Transaction class.
        'This method return the Transaction object to the public method And raises the depositMade event procedure.
        'Dim theCustomer As Customer
        Dim theAccount As Account
        Dim theBankTransaction As Transaction
        Dim bankTransactionString As String

        'based on the transaction type assigning the account variable
        If pTransactionType = TransactionType.OpenAccount Then
            theAccount = pAccount
        Else
            theAccount = findAccount(pAccountID)
        End If
        'checks if the transaction id is same or not 
        For i = 0 To _noOfTransactions - 1
            If _ithTransaction(i).trxId = pTransactionId Then
                Return Nothing
                Exit Function
            End If
        Next i

        'changing the amount of the account
        If theAccount.accountType = AccountType.Checking Then
            theAccount.balance += pTransactionAmount
            'Else
            '    theAccount.balance -= pTransactionAmount
        End If

        'calls the transaction class special constructor for creating the transaction object.
        theBankTransaction = New Transaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                          theAccount.owners(0),
                                           theAccount,
                                           pTransactionType,
                                           pTransactionAmount)


        'checks the array size and increments it if it is full
        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If



        'do processing
        'adds the transaction to transaction array

        Try
            _ithTransaction(_noOfTransactionLines) = theBankTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'assigns the bank transaction string based on the transaction type 
        If pTransactionType = TransactionType.OpenAccount Then
            bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                     & "; " & "Account" _
                                     & "; " & "Open" _
                                     & "; " & theBankTransaction.trxAccount.accountType.ToString _
                                     & "; " & theBankTransaction.trxId _
                                     & "; " & theBankTransaction.trxLineId _
                                     & "; " & theBankTransaction.trxAccount.accId.ToString _
                                     & "; " & theBankTransaction.trxAccount.accountName.ToString _
                                     & "; " & theBankTransaction.trxAccount.owners(0).custId.ToString _
                                     & "; " & theBankTransaction.trxAccount.balance.ToString _
                                     & "; " & theBankTransaction.trxAccount.annualPercentageInterestRate.ToString


        Else
            bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Customer" _
                                    & "; " & TransactionType.MakeDeposit.ToString _
                                    & "; " & theBankTransaction.trxId _
                                    & "; " & theBankTransaction.trxLineId _
                                    & "; " & theBankTransaction.trxAccount.owners(0).custId.ToString _
                                    & "; " & theBankTransaction.trxAccount.accId.ToString _
                                    & "; " & theBankTransaction.trxAccount.balance.ToString

        End If

        _transactionRecordArrayAddition(bankTransactionString)

        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1


        'Checks if the transaction type is open account or not .if the transaction type is 
        'Open Account then the Raising the event for Making a deposit Is Not performed .
        'if the transaction type is make deposit then the makeDeposit event is raised.

        If Not (pTransactionType = TransactionType.OpenAccount) Then
            RaiseEvent Bank_DepositMade(
                  Me,
                  New Bank_EventArgs_DepositMade(theBankTransaction))
        End If


        Return theBankTransaction

    End Function '_makeDepositTransaction( pTransactionId , pTransactionLineId , pTransactionDate , pTransactionCustomer , pTransactionAccount , pTransactionType , pTransactionAmount)

    'private function for withdrawal transaction
    Private Function _withdrawalTransaction(
                                           ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                            ByVal pCustomerID As String,
                                           ByVal pAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal) As Transaction

        'This private method is used to Make a wihdrawal in the account 
        'Using the New constructor Of Transaction Class.This method return 
        'the Transaction object to the public method And raises the Withdrawal 
        'Event procedure().


        Dim theBankTransaction As Transaction
        Dim theAccount As Account
        Dim bankTransactionString As String

        'finds the account based on the account id
        If IsNothing(findAccount(pAccountID)) Then
            Return Nothing
            Exit Function
        Else
            theAccount = findAccount(pAccountID)
        End If


        'assigns the transaction amount to the balance
        theAccount.balance -= pTransactionAmount
        'calls the transaction class constructor for creating the transaction object.
        theBankTransaction = New Transaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           theAccount.owners(0),
                                           theAccount,
                                           pTransactionType,
                                           pTransactionAmount)
        'increments the suze of the array if it is full
        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        'do processing
        'stores the transaction object in the transaction array
        Try
            _ithTransaction(_noOfTransactionLines) = theBankTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'writes the transaction information in the bank transaction string
        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Customer" _
                                    & "; " & TransactionType.MakeWithdrawal.ToString _
                                    & "; " & theBankTransaction.trxId _
                                    & "; " & theBankTransaction.trxLineId _
                                    & "; " & theBankTransaction.trxAccount.owners(0).custId.ToString _
                                    & "; " & theBankTransaction.trxAccount.accId.ToString _
                                    & "; " & theBankTransaction.trxAccount.balance.ToString

        'adds the bank transaction string to transaction record array
        _transactionRecordArrayAddition(bankTransactionString)

        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1

        'Raising the event for withdrawal made  which is listened 
        'in the frmMain class business logic event procedure _withdrawalMade(sender,e).
        RaiseEvent Bank_WithdrawalMade(
                   Me,
                   New Bank_EventArgs_WithdrawalMade(theBankTransaction))


        Return theBankTransaction
    End Function '_withdrawalTransaction(pTransactionId , pTransactionLineId , pTransactionDate , pTransactionCustomer , pTransactionAccount , pTransactionType , pTransactionAmount )

    'private function for using debit card
    Private Function _useDebitCardTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                            ByVal pCustomerID As String,
                                           ByVal pAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal) As Transaction

        'This private method is used to use a debit Card in the account Using the new constructor of Transaction class.
        'This method return the Transaction object to the public method And raises the DebitCardUsed event procedure.


        Dim theBankTransaction As Transaction
        Dim theAccount As Account
        Dim bankTransactionString As String
        'finds the account based on the account id
        If IsNothing(findAccount(pAccountID)) Then
            Return Nothing
            Exit Function
        Else
            theAccount = findAccount(pAccountID)

        End If
        'assigns the transaction amount to the balance 
        theAccount.balance -= pTransactionAmount
        'calls the special constructor of transaction class for creating the transaction object.
        theBankTransaction = New Transaction(
                                           pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           theAccount.owners(0),
                                           theAccount,
                                           pTransactionType,
                                           pTransactionAmount)


        'increments the suze of the array if it is full
        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        'do processing
        'stores the transaction object in the transaction array 
        Try
            _ithTransaction(_noOfTransactionLines) = theBankTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try
        'writes the transaction information in the bank transaction string
        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Customer" _
                                    & "; " & TransactionType.UseDebitCard.ToString _
                                    & "; " & theBankTransaction.trxId _
                                    & "; " & theBankTransaction.trxLineId _
                                    & "; " & theBankTransaction.trxAccount.owners(0).custId.ToString _
                                    & "; " & theBankTransaction.trxAccount.accId.ToString _
                                    & "; " & theBankTransaction.trxAccount.balance.ToString
        'adds the bank transaction string to transaction record array
        _transactionRecordArrayAddition(bankTransactionString)
        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1

        'Raising the event for using a debit card which is listened 
        'in the frmMain class business logic event procedure _useDebitCard(sender,e).
        RaiseEvent Bank_DebitCardUsed(
                   Me,
                   New Bank_EventArgs_DebitCardUsed(theBankTransaction))


        Return theBankTransaction
    End Function '_useDebitCardTransaction(pTransactionId , pTransactionLineId ,pTransactionDate , pTransactionCustomer ,pTransactionAccount , pTransactionType , pTransactionAmount )

    'private function for charge purchase

    Private Function _chargePurchaseTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                            ByVal pCustomerID As String,
                                           ByVal pAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal) As Transaction

        'This private method is used to Purchase Charged in the account Using the new constructor of Transaction class.
        'This method return the Transaction object to the public method And raises the purchaseCharged event procedure.

        'Declare Variables 
        Dim theBankTransaction As Transaction
        Dim theAccount As Account
        Dim bankTransactionString As String
        'finds the account based on the account id
        If IsNothing(findAccount(pAccountID)) Then
            Return Nothing
            Exit Function
        Else
            theAccount = findAccount(pAccountID)
        End If
        'assigns the transaction amount to the balance 
        theAccount.balance -= pTransactionAmount
        'calls the transaction class constructor for creating the transaction object 
        theBankTransaction = New Transaction(
                                           pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           theAccount.owners(0),
                                           theAccount,
                                           pTransactionType,
                                           pTransactionAmount)
        'increments the suze of the array if it is full
        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        'do processing
        'stores the transaction object in the transaction array 
        Try
            _ithTransaction(_noOfTransactionLines) = theBankTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'writes the transaction information in the bank transaction string
        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Customer" _
                                    & "; " & TransactionType.ChargePurchase.ToString _
                                    & "; " & theBankTransaction.trxId _
                                    & "; " & theBankTransaction.trxLineId _
                                    & "; " & theBankTransaction.trxAccount.owners(0).custId.ToString _
                                    & "; " & theBankTransaction.trxAccount.accId.ToString _
                                    & "; " & theBankTransaction.trxAccount.balance.ToString

        'adds the bank transaction string to transaction record array
        _transactionRecordArrayAddition(bankTransactionString)
        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1


        'Raising the event for purchasedCharge which is listened 
        'in the frmMain class business logic event procedure _accountModified(sender,e).
        RaiseEvent Bank_PurchaseCharged(
                   Me,
                   New Bank_EventArgs_PurchaseCharged(theBankTransaction))

        Return theBankTransaction
    End Function '_chargePurchaseTransaction( pTransactionId ,pTransactionLineId, pTransactionDate , pTransactionCustomer , pTransactionAccount, pTransactionType , pTransactionAmount )

    'private fuction for make payment
    Private Function _makePaymentTransaction(ByVal pTransactionId As String,
                                           ByVal pFromTransactionLineId As String,
                                           ByVal pToTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                           ByVal pTransactionCustomerId As String,
                                           ByVal pFromAccountID As String,
                                           ByVal pToAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal,
                                           ByRef pToTransaction As Transaction) As Transaction

        'This private method is used to make a payment in the account Using the new constructor of Transaction class.
        'This method returns the FromTransaction object which has a to transaction object passed By reference 
        'to the public method And raises the paymentMade event procedure.

        Dim theFromTransaction As Transaction
        Dim transactionCustomer As Customer
        Dim FromTransactionAccount As Account
        Dim ToTransactionAccount As Account
        Dim bankTransactionString As String
        ' calling a findcustomer to search a customer.

        transactionCustomer = findCustomer(pTransactionCustomerId)
        If IsNothing(transactionCustomer) Then
            Return Nothing
            Exit Function

        End If
        'calls the special constructor of the account class for creating the account objects 
        FromTransactionAccount = findAccount(pFromAccountID)
        If IsNothing(FromTransactionAccount) Then
            Return Nothing
            Exit Function
        End If
        FromTransactionAccount.balance -= pTransactionAmount

        ToTransactionAccount = findAccount(pToAccountID)
        If IsNothing(ToTransactionAccount) Then
            Return Nothing
            Exit Function
        End If
        ToTransactionAccount.balance += pTransactionAmount
        'calls the special constructor of transaction class for creating the From and To transction objects.

        theFromTransaction = New Transaction(
                                           pTransactionId,
                                           pFromTransactionLineId,
                                           pTransactionDate,
                                           transactionCustomer,
                                           FromTransactionAccount,
                                           pTransactionType,
                                           pTransactionAmount)

        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        'do processing
        Try
            _ithTransaction(_noOfTransactionLines) = theFromTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        _noOfTransactionLines += 1

        pToTransaction = New Transaction(pTransactionId,
                                           pToTransactionLineId,
                                           pTransactionDate,
                                           transactionCustomer,
                                           ToTransactionAccount,
                                           pTransactionType,
                                           pTransactionAmount)

        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_noOfTransactionLines) = pToTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Customer" _
                                    & "; " & TransactionType.MakePayment.ToString _
                                    & "; " & theFromTransaction.trxId _
                                    & "; " & theFromTransaction.trxLineId _
                                    & "; " & theFromTransaction.trxAccount.owners(0).custId.ToString _
                                    & "; " & theFromTransaction.trxAccount.accId.ToString _
                                    & "; " & pToTransaction.trxAccount.accId.ToString _
                                    & "; " & theFromTransaction.trxAccount.balance.ToString

        _transactionRecordArrayAddition(bankTransactionString)

        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1
        'Raising the event for making a payment which is listened 
        'in the frmMain class business logic event procedure _paymentMade(sender,e).

        RaiseEvent Bank_PaymentMade(
                   Me,
                   New Bank_EventArgs_PaymentMade(theFromTransaction, pToTransaction))

        Return theFromTransaction
    End Function 'makePaymentTransaction( pTransactionId , pFromTransactionLineId ,pToTransactionLineId , pTransactionDate , pTransactionCustomerId , pFromAccountID , pToAccountID ,pTransactionType ,pTransactionAmount, pToTransaction )

    'private function for Transfer funds transaction
    Private Function _transferFunds(ByVal pTransactionId As String,
                                           ByVal pFromTransactionLineId As String,
                                           ByVal pToTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                           ByVal pTransactionCustomerId As String,
                                           ByVal pFromAccountID As String,
                                           ByVal pToAccountID As String,
                                           ByVal pTransactionType As TransactionType,
                                           ByVal pTransactionAmount As Decimal,
                                           ByRef pToTransaction As Transaction) As Transaction

        'This private method is used to transfer funds in the account Using the new constructor of Transaction class.
        'This method returns the FromTransaction object which has a to transaction object passed By reference 
        'to the public method And raises the fundsTransferred event procedure.

        'Declare Variables
        Dim theFromTransaction As Transaction
        Dim transactionCustomer As Customer
        Dim FromTransactionAccount As Account
        Dim ToTransactionAccount As Account
        Dim bankTransactionString As String
        Dim i As Integer
        'Calls the new constructor from customer class for creating a new customer.
        transactionCustomer = findCustomer(pTransactionCustomerId)

        'call the account class constructor for Creating From and To Accounts 
        FromTransactionAccount = findAccount(pFromAccountID)
        FromTransactionAccount.balance -= pTransactionAmount
        ToTransactionAccount = findAccount(pToAccountID)
        ToTransactionAccount.balance += pTransactionAmount

        For i = 0 To _transaction.Count - 1
            If Not IsNothing(_transaction(i)) Then
                If _transaction(i).trxId = pTransactionId Then
                    Return Nothing
                    Exit Function
                End If
                If _transaction(i).trxLineId = pFromTransactionLineId Then
                    Return Nothing
                    Exit Function
                End If
                If _transaction(i).trxLineId = pToTransactionLineId Then
                    Return Nothing
                    Exit Function
                End If
            End If
        Next

        'calls the transaction class constructor to create From and To transaction object.
        theFromTransaction = New Transaction(
                                           pTransactionId,
                                           pFromTransactionLineId,
                                           pTransactionDate,
                                           transactionCustomer,
                                           FromTransactionAccount,
                                           pTransactionType,
                                           pTransactionAmount)

        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        'do processing
        Try
            _ithTransaction(_noOfTransactionLines) = theFromTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        _noOfTransactionLines += 1

        pToTransaction = New Transaction(pTransactionId,
                                           pToTransactionLineId,
                                           pTransactionDate,
                                           transactionCustomer,
                                           ToTransactionAccount,
                                           pTransactionType,
                                           pTransactionAmount)

        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_noOfTransactionLines) = pToTransaction
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Customer" _
                                    & "; " & TransactionType.TransferFunds.ToString _
                                    & "; " & theFromTransaction.trxId _
                                    & "; " & theFromTransaction.trxLineId _
                                    & "; " & theFromTransaction.trxAccount.owners(0).custId.ToString _
                                    & "; " & theFromTransaction.trxAccount.accId.ToString _
                                    & "; " & pToTransaction.trxAccount.accId.ToString _
                                    & "; " & theFromTransaction.trxAccount.balance.ToString


        _transactionRecordArrayAddition(bankTransactionString)
        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1

        'Raising the event for transferring funds which is listened 
        'in the frmMain class business logic event procedure _fundsTransferred(sender,e).
        RaiseEvent Bank_FundsTransferred(
                   Me,
                   New Bank_EventArgs_FundsTransferred(theFromTransaction, pToTransaction))


        Return theFromTransaction

    End Function '_transferFunds( pTransactionId , pFromTransactionLineId ,pToTransactionLineId , pTransactionDate , pTransactionCustomerId , pFromAccountID , pToAccountID ,pTransactionType ,pTransactionAmount, pToTransaction )


    'Private function for accrue interest .
    Private Function _specificAccrueIntetrestTransaction(ByVal pTransactionId As String,
                                           ByVal pTransactionLineId As String,
                                           ByVal pTransactionDate As Date,
                                           ByVal pAccountId As String,
                                           ByVal pTransactionType As TransactionType
                                           ) As Transaction

        'This private method is used to acruing Interest in the account 
        'Using the New constructor Of Transaction Class.
        'this also accrues interest on the amount in the transaction and 
        'sets the balance after the interest Is accrued for that account
        'This method returns the Transaction object to the public method 
        'And raises the fundsTransferred event procedure.

        Dim theBankTransaction As Transaction
        Dim theAccount As Account
        Dim theCustomer As Customer
        Dim theAmount As Decimal
        Dim bankTransactionString As String
        theAccount = findAccount(pAccountId)
        If IsNothing(theAccount) Then
            Return Nothing
            Exit Function
        End If
        theCustomer = findCustomer(theAccount.owners(0).custId)
        If IsNothing(theCustomer) Then
            Return Nothing
            Exit Function
        End If
        'calls the _calculateInterestAccrual() for calculating the interest that needs to 
        'be accrued on the balance of the account associated with the transaction
        theAmount = _calculateAccrueInterest(theAccount.annualPercentageInterestRate, theAccount.balance)

        'calls the new constructor of transaction class for creating a new transaction .
        theBankTransaction = New Transaction(pTransactionId,
                                           pTransactionLineId,
                                           pTransactionDate,
                                           theCustomer,
                                           theAccount,
                                           pTransactionType,
                                           theAmount)

        theBankTransaction.trxAccount.nextAccrualDate = theBankTransaction.trxAccount.setNextAccrualDate(pTransactionDate)

        If _noOfTransactionLines >= _maxTransaction Then
            _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransaction - 1)
        End If

        Try
            _ithTransaction(_noOfTransactionLines) = theBankTransaction

        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try
        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Account" _
                                    & "; " & "AccrueInterestIndividual" _
                                    & "; " & theBankTransaction.trxId _
                                    & "; " & theBankTransaction.trxLineId _
                                    & "; " & theBankTransaction.trxAccount.accId.ToString

        _transactionRecordArrayAddition(bankTransactionString)


        'Increments the no of transaction and transaction lines bank variables .
        _noOfTransactions += 1
        _noOfTransactionLines += 1


        'Raising the event for accruing interest which is listened 
        'in the frmMain class business logic event procedure _interestAccrued(sender,e).
        RaiseEvent Bank_InterestAccrued(
                   Me,
                   New Bank_EventArgs_InterestAccrued(theBankTransaction))


        Return theBankTransaction

    End Function 'accrueIntetrestTransaction(pTransactionId,pTransactionLineId,pTransactionDate,pTransactionCustomer,pTransactionAccount,pTransactionType,pTransactionAmount)
    Private Function _accrueIntetrestTransaction(ByVal pTrxPrefixId As String,
                                              ByVal pTrxStartId As Integer,
                                              ByVal pTrxLinePrefixId As String,
                                              ByVal pTrxLineStartId As Integer,
                                           ByVal pTransactionDate As Date,
                                           ByVal pTransactionType As TransactionType) As Transaction

        'This private method is used to acruing Interest in the account 
        'Using the New constructor Of Transaction Class.
        'this also accrues interest on the amount in the transaction and 
        'sets the balance after the interest Is accrued for that account
        'This method returns the Transaction object to the public method 
        'And raises the fundsTransferred event procedure.

        Dim theBankTransaction As Transaction
        Dim theAccount As Account
        Dim theAmount As Decimal
        Dim transactionId As String
        Dim transactionLineId As String
        Dim bankTransactionString As String
        Dim i As Integer
        Dim theTrxStart As Integer = pTrxStartId
        Dim theTrxLineStart As Integer = pTrxLineStartId


        For i = 0 To _noOfAccounts - 1

            theAccount = _account(i)
            transactionId = pTrxPrefixId & pTrxStartId
            transactionLineId = pTrxLinePrefixId & pTrxLineStartId
            'calls the _calculateInterestAccrual() for calculating the interest that needs to 
            'be accrued on the balance of the account associated with the transaction
            theAmount = _calculateAccrueInterest(theAccount.annualPercentageInterestRate, theAccount.balance)

            'If pTransactionDate < theAccount.nextAccrualDate Then
            '    Return Nothing
            '    Exit Function
            'End If
            'calls the new constructor of transaction class for creating a new transaction .

            theBankTransaction = New Transaction(transactionId,
                                           transactionLineId,
                                           pTransactionDate,
                                           theAccount.owners(0),
                                           theAccount,
                                           pTransactionType,
                                           theAmount)
            pTrxStartId += 1
            pTrxLineStartId += 1
            theBankTransaction.trxAccount.nextAccrualDate = theBankTransaction.trxAccount.setNextAccrualDate(pTransactionDate)

            If _noOfTransactionLines >= _maxTransaction Then
                _maxTransaction += _TRANSACTION_ARRAY_INCREMENT_DEFAULT
                ReDim Preserve mTransaction(_maxTransaction - 1)
            End If

            Try
                _ithTransaction(_noOfTransactionLines) = theBankTransaction
            Catch ex As Exception
                Throw New IndexOutOfRangeException
            End Try

            'Increments the no of transaction and transaction lines bank variables .
            _noOfTransactions += 1
            _noOfTransactionLines += 1

            'Raising the event for accruing interest which is listened 
            'in the frmMain class business logic event procedure _interestAccrued(sender,e).
            RaiseEvent Bank_InterestAccrued(
                   Me,
                   New Bank_EventArgs_InterestAccrued(theBankTransaction))


        Next i
        bankTransactionString = Date.Now.ToString("yyyyMMdd") _
                             & "; " & Date.Now.ToString("hhmm") _
                                    & "; " & "Account" _
                                    & "; " & "AccrueInterestAll" _
                                    & "; " & pTrxPrefixId _
                                    & "; " & theTrxStart _
                                    & "; " & pTrxLinePrefixId _
                                    & "; " & theTrxLineStart

        _transactionRecordArrayAddition(bankTransactionString)
        Return theBankTransaction

    End Function 'accrueIntetrestTransaction(pTransactionId,pTransactionLineId,pTransactionDate,pTransactionCustomer,pTransactionAccount,pTransactionType,pTransactionAmount)

    'Do we need an another Accrue interest procedure for specific accrue interest  
    'dim i as integer 
    'For i=0 to _noOfAccounts-1
    '_account[0].Balance = 

    Private Function _calculateAccrueInterest(ByVal pAPIR As Decimal,
                                               ByVal pTransactionAmount As Decimal) As Decimal

        'calculates the interest amount for the transaction amount'

        'Declare variables

        Dim monthlyInterestRate As Decimal
        Dim accruedInterstAmount As Decimal


        'using the aPRAmount , monthlyInterestRate is also calulated.
        monthlyInterestRate = pAPIR / 12
        accruedInterstAmount = Math.Round((monthlyInterestRate * pTransactionAmount) + pTransactionAmount, 2)

        Return accruedInterstAmount

    End Function '_calculateInterestAccrual(pTransactionAmount)
    'To display Bank details 
    Private Function _toString() As String
        'Private method which displays the bank information in the transaction log.
        'This method returns a string to the public ToString function.

        'Declare Variables
        Dim tmpstr As String

        ' calls all the private property procedures and 
        'stores the values in the tmpstr string which Is 
        'returned to the public ToString() method.

        tmpstr = vbCrLf & "(BANK : Bank Name =" & _bankName _
                & "  , No Of Customers = " & _noOfCustomers _
                & " ,No Of Accounts =" & _noOfAccounts _
                & " ,No Of Transaction =" & _noOfTransactions _
                & " ,No Of Transaction Lines =" & _noOfTransactionLines _
                & " )" & vbCrLf _
        ' & _transactionRecord(8).ToString
        Return tmpstr

    End Function '_toString()

    Private Function _findCustomer(
                     ByVal pCustomerID As String,
                     ByRef pFoundLocation As Integer) _
        As Customer
        Dim currentCustomer As Customer
        For pFoundLocation = 0 To _noOfCustomers - 1
            currentCustomer = _ithCustomer(pFoundLocation)
            If currentCustomer.custId = pCustomerID Then  'found @ pFoundLocation
                Return currentCustomer
            End If
        Next pFoundLocation
        Return Nothing
    End Function

    Private Function _findAccount(
                     ByVal pAccountID As String,
                     ByRef pFoundLocation As Integer) _
        As Account
        Dim currentAccount As Account
        For pFoundLocation = 0 To _noOfAccounts - 1
            currentAccount = _ithAccount(pFoundLocation)
            If currentAccount.accId = pAccountID Then  'found @ pFoundLocation
                Return currentAccount
            End If
        Next pFoundLocation
        Return Nothing
    End Function

    Private Function _findTransaction(
                     ByVal pTransactionID As String,
                     ByRef pFoundLocation As Integer) As Transaction
        Dim currentTransaction As Transaction
        For pFoundLocation = 0 To _noOfTransactionLines - 1
            currentTransaction = _ithTransaction(pFoundLocation)
            If currentTransaction.trxId = pTransactionID Then  'found @ pFoundLocation
                Return currentTransaction
            End If
        Next pFoundLocation
        Return Nothing
    End Function '_findTransaction(pTransactionID,pFoundLocation)
    Private Function _findTransactionLine(
                     ByVal pTransactionLineID As String,
                     ByRef pFoundLocation As Integer) As Transaction
        Dim currentTransaction As Transaction
        For pFoundLocation = 0 To _noOfTransactionLines - 1
            currentTransaction = _ithTransaction(pFoundLocation)
            If currentTransaction.trxLineId = pTransactionLineID Then  'found @ pFoundLocation
                Return currentTransaction
            End If
        Next pFoundLocation
        Return Nothing
    End Function '_findTransactionLine(pTransactionLineID,pFoundLocation)
    Private Iterator Function _iterateCustomer(ByVal pId As String) _
        As _
            IEnumerable

        Dim i As Integer
        'yeilds the transaction based on the customerid 
        For i = 0 To _transaction.Count - 1
            If Not IsNothing(_transaction(i)) Then
                If _transaction(i).trxAccount.owners(0).custId = pId Then
                    Yield _ithTransaction(i)
                End If
            End If
        Next i

    End Function '_iterateCustomer()

    Private Iterator Function _iterateAccount(ByVal pId As String) _
        As _
            IEnumerable

        Dim i As Integer
        'yields Account based on the customer id 
        For i = 0 To _account.Count - 1
            If Not IsNothing(_account(i)) Then
                If _account(i).owners(0).custId = pId Then
                    Yield _ithAccount(i)
                End If
            End If
        Next i

    End Function '_iterateAccount()

    Private Iterator Function _iterateTransaction(ByVal pIdentifier As String,
                                                  ByVal pId As String) _
        As _
            IEnumerable

        Dim i As Integer

        For i = 0 To _transaction.Count - 1
            If Not IsNothing(_transaction(i)) Then

                Select Case pIdentifier
                    Case "Customer"
                        If _transaction(i).trxCustomer.custId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "Account"
                        If _transaction(i).trxAccount.accId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "Transaction"
                        If _transaction(i).trxId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "TransactionLine"
                        If _transaction(i).trxLineId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "AccountObject"
                        If _transaction(i).trxAccount.accId = pId And _transaction(i).trxType = TransactionType.OpenAccount Then
                            Yield _ithTransaction(i)
                        End If
                End Select
            End If
        Next i

    End Function '_iterateTransaction()
    Private Iterator Function _iterateTransactionRecord() _
        As _
            IEnumerable

        Dim i As Integer

        For i = 0 To _noOfTransactionRecordLines
            If Not IsNothing(_transactionRecord(i)) Then

                Yield _ithTransactionRecord(i)

            End If
        Next i

    End Function '_iterateCustomer()

    Private Sub _transactionRecordArrayAddition(ByVal pLine As String)

        If _noOfTransactionRecordLines >= _maxTransactionRecord Then
            _maxTransactionRecord += _TRANSACTIONRECORD_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransactionRecord(_maxTransactionRecord - 1)
        End If
        Try
            _ithTransactionRecord(_noOfTransactionRecordLines) = pLine
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try
        _noOfTransactionRecordLines += 1

    End Sub '_transactionRecordArrayAddition(pLine)

    Private Function _AverageAge() As String

        'Declare variables
        Dim theField As String()
        Dim theTotalAge As Integer
        Dim theCustomer As Customer
        Dim age As Integer
        Dim averageAge As String
        Dim theStrAge As String
        Dim endPos As Integer

        'Get/Validate input

        'Do processing
        For Each theCustomer In _customer
            If Not IsNothing(theCustomer) Then
                theField = Split(theCustomer.ToString, ",")
                theStrAge = theField(3)
                endPos = theStrAge.IndexOf("' ")
                age = Integer.Parse(theStrAge.Substring(6, endPos - 6).TrimEnd)
                theTotalAge += age
            End If
        Next

        averageAge = Double.Parse(CType(theTotalAge / _noOfCustomers, String)).ToString("N2")

        'Display output

        'Get ready for next input

        Return averageAge

    End Function '_calculateAverageAge()

    Private Function _getLargestAmountOwed() As String

        'Declare variables
        Dim largestAmountOwed As Double
        Dim account As Account
        Dim accountBalance As Double


        'Get/Validate input
        largestAmountOwed = 0

        'Do processing
        For Each account In _account
            If Not IsNothing(account) Then
                If account.accountType = AccountType.Loan Or account.accountType = AccountType.CreditCard Then
                    accountBalance = account.balance
                    accountBalance = -accountBalance
                    If accountBalance > largestAmountOwed Then
                        largestAmountOwed = accountBalance
                    End If
                End If

            End If

        Next

        'Display output

        'Get ready for next input

        Return largestAmountOwed.ToString("N2")

    End Function '_getLargestAmountOwed()


    Private Function _calculateAverageAccountBalance() As String

        'Declare variables
        Dim field As String()
        Dim totalAccountBalance As Decimal
        Dim account As Account
        Dim accountBalance As Decimal
        Dim averageAccountBalance As String
        Dim str As String

        'Get/Validate input

        'Do processing
        For Each account In _account
            If Not IsNothing(account) Then
                If account.accountType = AccountType.Checking Then

                    totalAccountBalance += account.balance
                        End If

            End If
        Next

        If totalAccountBalance = 0 Or _noOfAccounts = 0 Then
            averageAccountBalance = "0.00"
        Else
            averageAccountBalance = (totalAccountBalance / _noOfAccounts).ToString("N2")
        End If

        'Display output

        'Get ready for next input

        Return averageAccountBalance

    End Function '_calculateAverageAccountBalance()


    Private Sub _metrics()
        '_metrics() function fires up whenever a new customer 
        'account or transaction occurs. It gives the average 
        'age of the customers of the bank ,average,largestand 
        'smallest checking account balance 


        _calculateAverageAccountBalance()
        _getLargestAmountOwed()
        _AverageAge()



    End Sub '_metrics()

    Private Sub _writeFromArrayToFile(ByVal pFileName As String)

        Dim outPutfile As StreamWriter
        Dim transactionRecord As String
        outPutfile = New StreamWriter(pFileName)
        For Each transactionRecord In _transactionRecord()
            outPutfile.WriteLine(transactionRecord)
        Next

        outPutfile.Close()


    End Sub '_writeFromArrayToFile()

    Private Sub _readFromFileToArray(ByVal pFileName As String)


        'reads theevery line in the  file and stores it to the string 
        'which is split in to parts and validates the format and creates
        'the appropriate objects and fills the gui
        Dim inputFile As StreamReader
        Dim thecurrentArrayLine As String
        Dim thecurrentArrayLineParts() As String
        Dim theArrayType As String
        Dim theCustomer As Customer
        Dim theCustomerId As String
        Dim theCustomerName As String
        Dim theCustomerBirthday As Date
        Dim theCustomerRefDate As Date
        Dim theAccountId As String
        Dim theAccountName As String
        Dim theAccountType As AccountType
        Dim theAccountBalance As Decimal
        Dim theAccountAPR As Decimal
        Dim theAccount As Account
        Dim theTransaction As Transaction
        Dim theTransactionId As String
        Dim theTransactionLineId As String
        Dim theToTransactionLineId As String
        Dim theTransactionAccountId As String
        Dim theToTransactionAccountId As String
        Dim theTransactionAmount As Decimal
        Dim theToTransaction As Transaction = Nothing
        Dim theTransactionPrefixId As String
        Dim TheTransactionStartId As Integer
        Dim theTransactionLinePrefixId As String
        Dim theTransactionLineStartId As Integer
        Dim i As Integer
        Dim custCount As Integer
        Dim transCount As Integer
        Dim thedate As Date
        Dim theYear As Integer
        Dim theMonth As Integer
        Dim theDay As Integer

        inputFile = New StreamReader(pFileName)

        Do While Not inputFile.EndOfStream
            thecurrentArrayLine = inputFile.ReadLine
            If thecurrentArrayLine.ToString = "" Then
                _transactionRecordArrayAddition(thecurrentArrayLine)
            ElseIf Not thecurrentArrayLine.StartsWith("#") Then
                thecurrentArrayLineParts = Split(thecurrentArrayLine, ";")
                For i = 0 To thecurrentArrayLineParts.Length - 1
                    thecurrentArrayLineParts(i) = Trim(thecurrentArrayLineParts(i))
                Next
                theYear = Integer.Parse(thecurrentArrayLineParts(0).Substring(0, 4))
                theMonth = Integer.Parse(thecurrentArrayLineParts(0).Substring(4, 2))
                theDay = Integer.Parse(thecurrentArrayLineParts(0).Substring(6, 2))
                thedate = New Date(theYear, theMonth, theDay)
                theArrayType = thecurrentArrayLineParts(2)
                If theArrayType = "Customer" Then
                    Select Case thecurrentArrayLineParts(3)
                        Case "Create"
                            theCustomerId = thecurrentArrayLineParts(4)
                            theCustomerName = thecurrentArrayLineParts(5)
                            theYear = Integer.Parse(thecurrentArrayLineParts(6).Substring(0, 4))
                            theMonth = Integer.Parse(thecurrentArrayLineParts(6).Substring(4, 2))
                            theDay = Integer.Parse(thecurrentArrayLineParts(6).Substring(6, 2))
                            theCustomerBirthday = New Date(theYear, theMonth, theDay)
                            theCustomerRefDate = thedate
                            For custCount = 0 To _noOfCustomers - 1
                                If _ithCustomer(custCount).custId = theCustomerId Then
                                    MessageBox.Show("The Customer already exists")
                                    Exit Sub
                                End If
                            Next custCount
                            Try
                                theCustomer = _createCustomer(theCustomerId, theCustomerName, theCustomerBirthday, theCustomerRefDate)
                            Catch ex As Exception
                                MessageBox.Show("The customer line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try
                        Case "MakeDeposit"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theCustomerId = thecurrentArrayLineParts(6)
                            theTransactionAccountId = thecurrentArrayLineParts(7)
                            theTransactionAmount = Decimal.Parse(thecurrentArrayLineParts(8))
                            For transCount = 0 To _noOfTransactionLines - 1
                                If _ithTransaction(transCount).trxId = theTransactionId Or _ithTransaction(transCount).trxLineId = theTransactionLineId Then
                                    MessageBox.Show("the transaction already exists")
                                    Exit Sub
                                End If
                            Next transCount
                            Try
                                theTransaction = _makeDepositTransaction(theTransactionId, theTransactionLineId, thedate, theTransactionAccountId, theCustomerId, TransactionType.MakeDeposit, theTransactionAmount)
                            Catch ex As Exception
                                MessageBox.Show("The Transaction line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try

                        Case "MakeWithdrawal"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theCustomerId = thecurrentArrayLineParts(6)
                            theTransactionAccountId = thecurrentArrayLineParts(7)
                            theTransactionAmount = Decimal.Parse(thecurrentArrayLineParts(8))
                            For transCount = 0 To _noOfTransactionLines - 1
                                If _ithTransaction(transCount).trxId = theTransactionId Or _ithTransaction(transCount).trxLineId = theTransactionLineId Then
                                    MessageBox.Show("the transaction already exists")
                                    Exit Sub
                                End If
                            Next transCount
                            Try
                                theTransaction = _withdrawalTransaction(theTransactionId, theTransactionLineId, thedate, theCustomerId, theTransactionAccountId, TransactionType.MakeWithdrawal, theTransactionAmount)
                            Catch ex As Exception
                                MessageBox.Show("The Transaction line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try

                        Case "UseDebitCard"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theCustomerId = thecurrentArrayLineParts(6)
                            theTransactionAccountId = thecurrentArrayLineParts(7)
                            theTransactionAmount = Decimal.Parse(thecurrentArrayLineParts(8))
                            For transCount = 0 To _noOfTransactionLines - 1
                                If _ithTransaction(transCount).trxId = theTransactionId Or _ithTransaction(transCount).trxLineId = theTransactionLineId Then
                                    MessageBox.Show("thetransaction already exists")
                                    Exit Sub
                                End If
                            Next transCount
                            Try
                                theTransaction = _useDebitCardTransaction(theTransactionId, theTransactionLineId, thedate, theCustomerId, theTransactionAccountId, TransactionType.UseDebitCard, theTransactionAmount)
                            Catch ex As Exception
                                MessageBox.Show("The Transaction line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try
                        Case "ChargePurchase"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theCustomerId = thecurrentArrayLineParts(6)
                            theTransactionAccountId = thecurrentArrayLineParts(7)
                            theTransactionAmount = Decimal.Parse(thecurrentArrayLineParts(8))
                            For transCount = 0 To _noOfTransactionLines - 1
                                If _ithTransaction(transCount).trxId = theTransactionId Or _ithTransaction(transCount).trxLineId = theTransactionLineId Then
                                    MessageBox.Show("The Transaction already exists")
                                    Exit Sub
                                End If
                            Next transCount
                            Try
                                theTransaction = _chargePurchaseTransaction(theTransactionId,
                                                                        theTransactionLineId,
                                                                        thedate,
                                                                        theCustomerId,
                                                                        theTransactionAccountId,
                                                                        TransactionType.MakeDeposit,
                                                                        theTransactionAmount)
                            Catch ex As Exception
                                MessageBox.Show("The Transaction line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try
                        Case "MakePayment"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theToTransactionLineId = thecurrentArrayLineParts(6)
                            theCustomerId = thecurrentArrayLineParts(7)
                            theTransactionAccountId = thecurrentArrayLineParts(8)
                            theToTransactionAccountId = thecurrentArrayLineParts(9)
                            theTransactionAmount = Decimal.Parse(thecurrentArrayLineParts(10))
                            For transCount = 0 To _noOfTransactionLines - 1
                                If _ithTransaction(transCount).trxId = theTransactionId Or _ithTransaction(transCount).trxLineId = theTransactionLineId Or _ithTransaction(transCount).trxLineId = theToTransactionLineId Then
                                    MessageBox.Show("The Transaction already exists")
                                    Exit Sub
                                End If
                            Next transCount
                            Try
                                theTransaction = _makePaymentTransaction(theTransactionId,
                                                                     theTransactionLineId,
                                                                     theToTransactionLineId,
                                                                     thedate,
                                                                     theCustomerId,
                                                                     theTransactionAccountId,
                                                                     theToTransactionAccountId,
                                                                     TransactionType.MakePayment,
                                                                     theTransactionAmount,
                                                                     theToTransaction)
                            Catch ex As Exception
                                MessageBox.Show("The Transaction line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try
                        Case "TransferFunds"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theToTransactionLineId = thecurrentArrayLineParts(6)
                            theCustomerId = thecurrentArrayLineParts(7)
                            theTransactionAccountId = thecurrentArrayLineParts(8)
                            theToTransactionAccountId = thecurrentArrayLineParts(9)
                            theTransactionAmount = Decimal.Parse(thecurrentArrayLineParts(10))
                            For transCount = 0 To _noOfTransactionLines - 1
                                If _ithTransaction(transCount).trxId = theTransactionId Or _ithTransaction(transCount).trxLineId = theTransactionLineId Or _ithTransaction(transCount).trxLineId = theToTransactionLineId Then
                                    MessageBox.Show("The Transaction already exists")
                                    Exit Sub
                                End If
                            Next transCount
                            Try
                                theTransaction = _transferFunds(theTransactionId,
                                                                     theTransactionLineId,
                                                                     theToTransactionLineId,
                                                                     thedate,
                                                                     theCustomerId,
                                                                     theTransactionAccountId,
                                                                     theToTransactionAccountId,
                                                                     TransactionType.TransferFunds,
                                                                     theTransactionAmount,
                                                                     theToTransaction)
                            Catch ex As Exception
                                MessageBox.Show("The Transaction line" & i & " in the file has Bad data in it.")
                                Exit Sub
                            End Try
                    End Select

                End If 'end if of the array type of customer
                If theArrayType = "Account" Then
                    Select Case thecurrentArrayLineParts(3)
                        Case "Open"
                            If AccountType.Checking.ToString() = thecurrentArrayLineParts(4) Then
                                theAccountType = AccountType.Checking
                                theAccountBalance = Decimal.Parse(thecurrentArrayLineParts(10))
                                theAccountAPR = Decimal.Parse(thecurrentArrayLineParts(11))
                            ElseIf AccountType.Loan.ToString() = thecurrentArrayLineParts(4) Then
                                theAccountType = AccountType.Loan
                                theAccountBalance = Decimal.Parse(thecurrentArrayLineParts(10))
                                theAccountAPR = Decimal.Parse(thecurrentArrayLineParts(11))
                            ElseIf theAccountType = AccountType.CreditCard Then
                                theAccountBalance = 0D

                                theAccountAPR = Decimal.Parse(thecurrentArrayLineParts(10))
                            End If
                            theTransactionId = thecurrentArrayLineParts(5)
                            theTransactionLineId = thecurrentArrayLineParts(6)
                            theAccountId = thecurrentArrayLineParts(7)
                            theAccountName = thecurrentArrayLineParts(8)
                            theCustomerId = thecurrentArrayLineParts(9)
                            'crashes here for the credit card 
                            theTransaction = _openAccount(theTransactionId,
                                                              theTransactionLineId,
                                                              theAccountId,
                                                              theAccountName,
                                                              thedate,
                                                              theAccountBalance,
                                                              theAccountAPR,
                                                              theCustomerId, theAccountType, False, New Date(1995, 10, 10))
                        Case "AddOwner"
                            theAccountId = thecurrentArrayLineParts(4)
                            theCustomerId = thecurrentArrayLineParts(5)
                            theAccount = findAccount(theAccountId)
                            If Not theAccount.ToString = Nothing Then
                                Try
                                    _modifyAccount(theCustomerId, theAccountId, theAccount.accountName, theAccount.annualPercentageInterestRate, theAccount.accountClosed, theAccount.closedDate)
                                Catch ex As Exception
                                    Exit Sub
                                End Try
                            End If

                        Case "AccrueInterestIndividual"
                            theTransactionId = thecurrentArrayLineParts(4)
                            theTransactionLineId = thecurrentArrayLineParts(5)
                            theAccountId = thecurrentArrayLineParts(6)
                            theTransaction = _specificAccrueIntetrestTransaction(theTransactionId, theTransactionLineId, thedate, theAccountId, TransactionType.AccrueInterest)
                        Case "AccrueInterestAll"
                            theTransactionPrefixId = thecurrentArrayLineParts(4)
                            TheTransactionStartId = Integer.Parse(thecurrentArrayLineParts(5))
                            theTransactionLinePrefixId = thecurrentArrayLineParts(6)
                            theTransactionLineStartId = Integer.Parse(thecurrentArrayLineParts(7))
                            theTransaction = _accrueIntetrestTransaction(theTransactionPrefixId, TheTransactionStartId, theTransactionLinePrefixId, theTransactionLineStartId, thedate, TransactionType.AccrueInterest)
                        Case "UpdateName"
                            theAccountId = thecurrentArrayLineParts(4)
                            theAccountName = thecurrentArrayLineParts(5)
                            theAccount = findAccount(theAccountId)
                            If Not theAccount.ToString = Nothing Then
                                Try
                                    _modifyAccount(theAccount.owners(0).custId, theAccountId, theAccountName, theAccount.annualPercentageInterestRate, theAccount.accountClosed, theAccount.closedDate)
                                Catch ex As Exception
                                    Exit Sub
                                End Try
                            End If
                        Case "Close"
                            theAccountId = thecurrentArrayLineParts(4)
                            theAccount = findAccount(theAccountId)
                            If Not theAccount.ToString = Nothing Then
                                Try
                                    _modifyAccount(theAccount.owners(0).custId, theAccountId, theAccount.accountName, theAccount.annualPercentageInterestRate, True, thedate)
                                Catch ex As Exception
                                    Exit Sub
                                End Try
                            End If

                        Case "UpdateInterestRate"
                            theAccountId = thecurrentArrayLineParts(4)
                            theAccountAPR = Decimal.Parse(thecurrentArrayLineParts(5))
                            theAccount = findAccount(theAccountId)
                            If Not theAccount.ToString = Nothing Then
                                Try
                                    _modifyAccount(theAccount.owners(0).custId, theAccountId, theAccount.accountName, theAccountAPR, theAccount.accountClosed, theAccount.closedDate)
                                Catch ex As Exception
                                    Exit Sub
                                End Try
                            End If
                    End Select

                End If ' end of array type account


            Else
                _transactionRecordArrayAddition(thecurrentArrayLine)

            End If 'end of # or "" if statement

        Loop
        inputFile.Close()
    End Sub '_readFromFileToArray()


#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'These are all public.

    'Event for the Customer Created 
    Public Event Bank_CustomerCreated(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Account Opened
    Public Event Bank_AccountOpened(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Account Opened
    Public Event Bank_AccountModified(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Deposit Made
    Public Event Bank_DepositMade(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Withdrawal Made
    Public Event Bank_WithdrawalMade(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the DebitCard Used
    Public Event Bank_DebitCardUsed(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Purchase Charged
    Public Event Bank_PurchaseCharged(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Payment Made
    Public Event Bank_PaymentMade(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Funds Transferred
    Public Event Bank_FundsTransferred(
           ByVal sender As System.Object,
           ByVal e As System.EventArgs)


    'Event for the Interest Accrued
    Public Event Bank_InterestAccrued(
          ByVal sender As System.Object,
          ByVal e As System.EventArgs)

#End Region 'Events

End Class 'Bank
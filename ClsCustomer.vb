'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsCustomer.vb
'Author:             Hari Chandana Paruchuri
'Description:        Business Logic of Customer class for the Banking project.
'Date:               2016 Oct 3
'                      - Created the Customer class,Module level variables and Get/Set methods for the variables.
'                    2016 Oct 4 
'                      - Created the special constructor and ToString method.
'                    2016 Nov 10
'                      - Created the procedures for calculating Age and isChild .
'Tier:               Business Logic 
'Exceptions:         None Defined.
'Exception-Handling: None.
'Events:             None Defined.
'Event-Handling:     None.  
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class Customer

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************


    '********** Module-level constants
    Private Const mTRANSACTION_ARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mTRANSACTION_ARRAY_INCREMENT_DEFAULT As Integer = 5
    Private Const mCUSTOMER_ISCHILD_LIMIT As Integer = 13
    '********** Module-level variables

    Private mCustId As String
    Private mCustName As String
    Private mBirthDate As Date
    Private mNoOfTransactions As Integer
    Private mTransactions() As Transaction
    Private mMaxTransactions As Integer 'max number of transactions.
    'Private refDate As Date
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
    Public Sub New(ByVal pCustId As String,
                   ByVal pCustName As String,
                   ByVal pBirthDate As Date)

        MyBase.New()
        custId = pCustId
        custName = pCustName
        birthdate = New Date(pBirthDate.Year, pBirthDate.Month, pBirthDate.Day)
        _maxTransactions = _TRANSACTIONS_ARRAY_SIZE_DEFAULT
        ReDim mTransactions(_maxTransactions - 1)
        _noOfTransactions = 0
    End Sub 'new(pCustId,pCustName,pBirthDate)

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************




    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public Property custId As String
        Get
            Return _custId

        End Get
        Set(ByVal pValue As String)
            _custId = pValue

        End Set
    End Property

    Public Property custName As String

        Get
            Return _custName
        End Get
        Set(ByVal pValue As String)
            _custName = pValue

        End Set
    End Property

    Public Property birthdate As Date
        Get
            Return _birthdate

        End Get
        Set(ByVal pValue As Date)
            _birthdate = pValue

        End Set
    End Property

    Public Property noOfTransactions As Integer
        Get
            Return _noOfTransactions

        End Get
        Set(ByVal pValue As Integer)
            _noOfTransactions = pValue

        End Set
    End Property


    Public Property customerTransaction As Transaction()
        Get
            Return _transactions
        End Get
        Set(ByVal pValue As Transaction())
            _transactions = pValue
        End Set
    End Property



    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _custId As String
        Get
            Return mCustId

        End Get
        Set(ByVal pValue As String)
            mCustId = pValue

        End Set
    End Property

    Private Property _custName As String
        Get
            Return mCustName
        End Get
        Set(ByVal pValue As String)
            mCustName = pValue

        End Set
    End Property

    Private Property _birthdate As Date
        Get
            Return mBirthDate

        End Get
        Set(ByVal pValue As Date)
            mBirthDate = pValue

        End Set
    End Property

    Private Property _noOfTransactions As Integer
        Get
            Return mNoOfTransactions

        End Get
        Set(ByVal pValue As Integer)
            mNoOfTransactions = pValue
        End Set
    End Property

    Private Property _transactions As Transaction()
        Get
            Return mTransactions
        End Get
        Set(ByVal pValue As Transaction())
            mTransactions = pValue
        End Set
    End Property
    Private Property _maxTransactions As Integer
        Get
            Return mMaxTransactions
        End Get
        Set(pValue As Integer)
            mMaxTransactions = pValue
        End Set
    End Property
    Private ReadOnly Property _CUSTOMER_ISCHILD_LIMIT As Integer
        Get
            Return mCUSTOMER_ISCHILD_LIMIT
        End Get
    End Property

    Private ReadOnly Property _TRANSACTIONS_ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mTRANSACTION_ARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _TRANSACTIONS_ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mTRANSACTION_ARRAY_INCREMENT_DEFAULT
        End Get
    End Property

    Private Property _ithTransaction(ByVal pTransactionID As Integer) As Transaction
        Get
            'assumes :0<=pTransactionID <_numTransaction
            'throws an IndexOutOfRangeException if this is not the case
            If pTransactionID >= 0 And pTransactionID < _maxTransactions Then
                Return mTransactions(pTransactionID)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pValue As Transaction)
            If pTransactionID >= 0 And pTransactionID < _maxTransactions Then
                mTransactions(pTransactionID) = pValue
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
    'Public Function age() As Integer
    '    Return _age()
    'End Function

    Public Function calculateAge() As Integer

        Return _calculateAge()

    End Function 'calculateAge()

    Public Function calculateAge(ByVal pRefDate As Date) As Integer

        Return _calculateAge(pRefDate)

    End Function 'calculateAge(pRefDate)

    Public Function calculateIsChild(ByVal pAge As Integer) As Boolean

        Return _calculateIsChild(pAge)

    End Function 'calculateIsChild(pAge)
    Public Function calculateIsChild(ByVal pRefDate As Date) As Boolean

        Return _calculateIsChild(pRefDate)

    End Function 'calculateIsChild(pRefDate)

    Public Overrides Function ToString() As String

        Return _tostring()

    End Function 'ToString()

    Public Overloads Function ToString(ByVal pRefDate As Date) As String

        'this tostring() will overload the ToString().
        'this will be printed if the reference date is passed to it

        Return _toString(pRefDate)

    End Function 'ToString(pRefDate)

    Public Function findTransaction(
                                ByVal pTransactionID As String
                                ) As Transaction
        Dim foundLocation As Integer
        Return _findTransaction(pTransactionID, foundLocation)
    End Function


    Public Iterator Function iterateTransaction(ByVal pIdentifier As String,
                                                ByVal pId As String
                                               ) _
        As _
            IEnumerable

        Dim theObject As Object

        For Each theObject In _iterateTransaction(pIdentifier, pId)
            Yield theObject
        Next theObject

    End Function 'iterateTransaction()

    '********** Private Non-Shared Behavioral Methods
    Private Function _calculateAge() As Integer

        'returns the _calculateAge with reference date as date.now
        'this is usually called when the customer is added from the GUI

        Return _calculateAge(Date.Now)

    End Function '_calculateAge()

    Private Function _calculateAge(ByVal pRefDate As Date) As Integer

        'calculate teh age based on the reference date

        Dim theAge As Integer
        ' pRefDate = New Date(2016, 11, 04)
        theAge = Integer.Parse(DateDiff(DateInterval.Year, _birthdate, pRefDate).ToString)
        ' theAge = pRefDate.Year - _birthdate.Year
        If (_birthdate > pRefDate.AddYears(-theAge)) Then
            theAge -= 1
        End If

        Return theAge

    End Function '_calculateAge(pRefDate)

    Private Function _calculateIsChild(ByVal pRefDate As Date) As Boolean

        Return _calculateIsChild(_calculateAge(pRefDate))

    End Function '_calculateIsChild(pRefDate)


    Private Function _calculateIsChild(ByVal pAge As Integer) As Boolean

        'Returns the ischild or not based on the the customer age limit 

        If pAge <= _CUSTOMER_ISCHILD_LIMIT Then
            Return True
        Else
            Return False
        End If

    End Function '_calculateIsChild(pAge)

    Private Function _findTransaction(
                     ByVal pTransactionID As String,
                     ByRef pFoundLocation As Integer) As Transaction
        Dim currentTransaction As Transaction
        For pFoundLocation = 0 To _noOfTransactions - 1
            currentTransaction = _ithTransaction(pFoundLocation)
            If currentTransaction.trxId = pTransactionID Or currentTransaction.trxLineId = pTransactionID Then  'found @ pFoundLocation
                Return currentTransaction
            End If
        Next pFoundLocation
        Return Nothing
    End Function '_findTransaction(pTransactionID,pFoundLocation)

    Private Iterator Function _iterateTransaction(ByVal pIdentifier As String,
                                                  ByVal pId As String) _
        As _
            IEnumerable

        Dim i As Integer

        For i = 0 To _transactions.Count - 1
            If Not IsNothing(_transactions(i)) Then

                Select Case pIdentifier
                    Case "Customer"
                        If _transactions(i).trxCustomer.custId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "Account"
                        If _transactions(i).trxAccount.accId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "Transaction"
                        If _transactions(i).trxId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "TransactionLine"
                        If _transactions(i).trxLineId = pId Then
                            Yield _ithTransaction(i)
                        End If
                    Case "AccountObject"
                        If _transactions(i).trxAccount.accId = pId And _transactions(i).trxAccount.accountType = TransactionType.OpenAccount Then
                            Yield _ithTransaction(i)
                        End If
                End Select
            End If
        Next i

    End Function '_iterateTransaction()
    Private Function _tostring() As String

        Dim tmpstr As String

        tmpstr &= vbCrLf & "CUSTOMER :ID='" & _custId & "'," _
            & "Name= '" & _custName & ", " _
            & "Birthdate='" & _birthdate & vbCrLf _
        & "' , Age='" & _calculateAge().ToString & "' , " _
        & "Is Customer Child ='" & _calculateIsChild(_calculateAge()).ToString() & "'."
        '"no of transactions =" & _noOfTransactions & "transactions ="& _transactions

        Return tmpstr

    End Function '_tostring()

    Private Function _toString(ByVal pRefDate As Date) As String
        'this toString() is called when a reference date is passed 
        'to as a parameter in the eventArgs class

        Dim tmpstr As String

        tmpstr &= vbCrLf & "CUSTOMER :ID='" & _custId & "', " _
            & "Name='" & _custName & "', " _
            & "Birthdate='" & _birthdate & vbCrLf & "', " _
        & "Age='" & _calculateAge(pRefDate).ToString & "' , " _
        & "Is Customer Child ='" & _calculateIsChild(_calculateAge(pRefDate)).ToString() & "' ."
        '"no of transactions =" & _noOfTransactions & "transactions ="& _transactions

        Return tmpstr

    End Function


    'Private Sub _customerMakeDepositTransaction(ByRef pTransactionID As String)
    '    Dim theTransaction As Transaction
    '    If _noOfTransactions >= _maxTransactions Then
    '        _maxTransactions += _TRANSACTIONS_ARRAY_INCREMENT_DEFAULT
    '        ReDim Preserve mTransactions(_maxTransactions - 1)
    '    End If
    '    For i = _noOfTransactions - 1 To _maxTransactions
    '        _ithTransaction(i) =
    '    Next i



    'End Sub '_customerMakeDepositTransaction(pTransactionId)


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

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'Customer
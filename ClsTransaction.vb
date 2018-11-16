'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsTransaction.vb
'Author:             Hari Chandana Paruchuri
'Description:        Business Logic of Transaction class for the Banking project.
'Date:               2016 Oct 3
'                      - Created the Transaction class,Module level variables and Get/Set methods for the variables.
'                    2016 Oct 4 
'                      - Created the Special Constructor and ToString Method.
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

Public Class Transaction

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************



    '********** Module-level constants

    '********** Module-level variables
    Private mTrxId As String
    Private mTrxLineId As String
    Private mDateTime As DateTime
    Private mTrxCustomer As Customer
    Private mTrxAccount As Account
    Private mTrxType As TransactionType
    Private mAmount As Decimal


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
    Public Sub New(
                  ByVal pTrxId As String,
                  ByVal pTrxLineId As String,
                  ByVal pDateTime As DateTime,
                  ByVal pTrxCustomer As Customer,
                  ByVal pTrxAccount As Account,
                  ByVal pTrxType As TransactionType,
                  ByVal pAmount As Decimal)


        _trxId = pTrxId
        _trxLineId = pTrxLineId
        _dateTime = pDateTime
        _trxCustomer = pTrxCustomer
        _trxAccount = pTrxAccount
        _trxType = pTrxType
        _amount = pAmount

    End Sub  'new(pTrxId, pTrxLineId, pDateTime, pTrxCustomer ,pTrxAccount , pTrxType , pAmount )

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************


    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public Property trxId As String
        Get
            Return _trxId
        End Get
        Set(ByVal pValue As String)
            _trxId = pValue
        End Set
    End Property
    Public Property trxLineId As String
        Get

            Return _trxLineId
        End Get
        Set(ByVal pValue As String)
            _trxLineId = pValue
        End Set
    End Property
    Public Property dateTime As DateTime
        Get
            Return _dateTime
        End Get
        Set(ByVal pValue As DateTime)
            _dateTime = pValue
        End Set
    End Property
    Public Property trxCustomer As Customer
        Get
            Return _trxCustomer

        End Get
        Set(ByVal pValue As Customer)
            _trxCustomer = pValue

        End Set
    End Property
    Public Property trxAccount As Account
        Get
            Return _trxAccount
        End Get
        Set(ByVal pValue As Account)
            _trxAccount = pValue
        End Set
    End Property
    Public Property trxType As TransactionType
        Get
            Return _trxType
        End Get
        Set(ByVal pValue As TransactionType)
            _trxType = pValue
        End Set
    End Property
    Public Property amount As Decimal
        Get
            Return _amount
        End Get
        Set(ByVal pValue As Decimal)
            _amount = pValue
        End Set
    End Property
    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _trxId As String
        Get
            Return mTrxId
        End Get
        Set(ByVal pValue As String)
            mTrxId = pValue
        End Set
    End Property
    Private Property _trxLineId As String
        Get

            Return mTrxLineId
        End Get
        Set(ByVal pValue As String)
            mTrxLineId = pValue
        End Set
    End Property
    Private Property _dateTime As DateTime
        Get
            Return mDateTime
        End Get
        Set(ByVal pValue As DateTime)
            mDateTime = pValue
        End Set
    End Property
    Private Property _trxCustomer As Customer
        Get
            Return mTrxCustomer

        End Get
        Set(ByVal pValue As Customer)
            mTrxCustomer = pValue

        End Set
    End Property
    Private Property _trxAccount As Account
        Get
            Return mTrxAccount
        End Get
        Set(ByVal pValue As Account)
            mTrxAccount = pValue
        End Set
    End Property
    Private Property _trxType As TransactionType
        Get
            Return mTrxType
        End Get
        Set(ByVal pValue As TransactionType)
            mTrxType = pValue
        End Set
    End Property
    Private Property _amount As Decimal
        Get
            Return mAmount
        End Get
        Set(ByVal pValue As Decimal)
            mAmount = pValue
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
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'Tostring()
    '********** Private Non-Shared Behavioral Methods
    Private Function _toString() As String
        Dim tmpstr As String
        tmpstr = vbCrLf _
           & "Transaction Id = " & _trxId _
           & " , Transaction Line Id = " & _trxLineId _
           & " , Date and Time of Transaction = " & _dateTime _
           & " , Transaction Type = " & _trxType.ToString() _
           & " , Amount in Transaction = " & _amount & " , " _
           & _trxAccount.ToString() & vbCrLf _
        '& _trxCustomer.ToString()

        Return tmpstr
    End Function '_tostring()
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

End Class 'Transaction
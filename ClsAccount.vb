'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking
'File:               ClsAccount.vb
'Author:             Hari Chandana Paruchuri
'Description:        Business Logic of Account class for the Banking project.
'Date:               2016 Oct 3
'                      - Created the Account class,Module level variables and Get/Set methods for the variables.
'                    2016 Oct 4 
'                      - Created the special constructor and ToString method.
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

Public Class Account

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************
    '********** Module-level constants
    Private Const mOWNER_ARRAY_SIZE_DEFAULT As Integer = 5
    Private Const mOWNER_ARRAY_INCREMENT_DEFAULT As Integer = 5
    '********** Module-level variables

    Private mAccId As String    '2
    Private mAccountName As String
    Private mNoOfOwners As Integer
    Private mOwners() As Customer
    Private mMaxOwners As Integer 'Max number of Owners in the owner list.
    Private mDateOpened As Date
    Private mBalance As Decimal
    Private mAnnualPercentageInterestRate As Decimal
    Private mNextAccrualDate As Date
    Private mAccountType As AccountType
    Private mAccountClosed As Boolean
    Private mClosedDate As Date
    Private mAccountNoOfTransactions As Integer
    Private mAccountTransactions As Transaction
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
                   ByVal pAccId As String,
                   ByVal pAccountName As String,
                   ByVal pDateOpened As Date,
                   ByVal pBalance As Decimal,
                   ByVal pAnnualPercentageInterestRate As Decimal,
                   ByVal pAccountType As AccountType,
                   ByVal pAccountClosed As Boolean,
                   ByVal pClosedDate As Date) ' ByVal pOwner As Customer(),
        'byval pAccountNoOfTransactions as integer
        'byval pAccountTransactions as transcation
        'ByVal pNextAccrualDate As Date
        _accId = pAccId
        _accountName = pAccountName
        _dateOpened = pDateOpened
        _balance = pBalance
        _annualPercentageInterestRate = pAnnualPercentageInterestRate
        _maxOwners = _OWNER_ARRAY_SIZE_DEFAULT
        ReDim mOwners(_maxOwners - 1)
        _noOfOwners = 0
        _accountType = pAccountType
        _accountClosed = pAccountClosed
        _closedDate = pClosedDate
        '_nextAccrualDate = pNextAccrualDate

    End Sub 'new(pAccId ,pAccountName ,pNoOfOwners ,pDateOpened ,pBalance ,pAnnualPercentageInterestRate, pOwner ,pNextAccrualDate ,pAccountType ,pAccountClosed ,pClosedDate)



    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************
    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public Property accId As String
        Get
            Return _accId
        End Get
        Set(ByVal pValue As String)
            _accId = pValue
        End Set
    End Property

    Public Property accountName As String
        Get
            Return _accountName
        End Get
        Set(ByVal pValue As String)
            _accountName = pValue
        End Set
    End Property

    Public Property noOfOwners As Integer
        Get
            Return _noOfOwners
        End Get
        Set(ByVal pValue As Integer)
            _noOfOwners = pValue
        End Set
    End Property

    Public Property owners As Customer()
        Get
            Return _owners
        End Get
        Set(ByVal pValue As Customer())
            _owners = pValue
        End Set
    End Property
    Public Property dateOpened As Date
        Get
            Return _dateOpened
        End Get
        Set(ByVal pValue As Date)
            _dateOpened = pValue
        End Set
    End Property

    Public Property balance As Decimal
        Get
            Return _balance
        End Get
        Set(pValue As Decimal)
            _balance = pValue
        End Set
    End Property

    Public Property annualPercentageInterestRate As Decimal
        Get
            Return _annualPercentageInterestRate

        End Get
        Set(ByVal pValue As Decimal)
            _annualPercentageInterestRate = pValue
        End Set
    End Property

    Public Property nextAccrualDate As Date
        Get
            Return _nextAccrualDate

        End Get
        Set(ByVal pValue As Date)
            _nextAccrualDate = pValue
        End Set
    End Property

    Public Property accountType As AccountType
        Get
            Return _accountType

        End Get
        Set(ByVal pValue As AccountType)
            _accountType = pValue
        End Set
    End Property

    Public Property accountClosed As Boolean
        Get
            Return _accountClosed
        End Get
        Set(ByVal pValue As Boolean)
            _accountClosed = pValue
        End Set
    End Property
    Public Property closedDate As Date
        Get
            Return _closedDate
        End Get
        Set(ByVal pValue As Date)
            _closedDate = pValue
        End Set
    End Property


    Public Property accountNoOfTransactions As Integer
        Get
            Return _accountNoOfTransactions
        End Get
        Set(ByVal pValue As Integer)
            _accountNoOfTransactions = pValue
        End Set
    End Property

    Public Property accountTransactions As Transaction
        Get
            Return _accountTransactions

        End Get
        Set(ByVal pValue As Transaction)
            _accountTransactions = pValue
        End Set
    End Property
    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _accId As String
        Get
            Return mAccId
        End Get
        Set(ByVal pValue As String)
            mAccId = pValue
        End Set
    End Property
    Private Property _accountName As String
        Get
            Return mAccountName
        End Get
        Set(ByVal pValue As String)
            mAccountName = pValue
        End Set
    End Property
    Private Property _noOfOwners As Integer
        Get
            Return mNoOfOwners
        End Get
        Set(ByVal pValue As Integer)
            mNoOfOwners = pValue
        End Set
    End Property


    Private Property _owners As Customer()
        Get
            Return mOwners
        End Get
        Set(ByVal pValue As Customer())
            mOwners = pValue
        End Set
    End Property
    Private Property _maxOwners As Integer
        Get
            Return mMaxOwners
        End Get
        Set(pValue As Integer)
            mMaxOwners = pValue
        End Set
    End Property
    Private ReadOnly Property _OWNER_ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mOWNER_ARRAY_SIZE_DEFAULT
        End Get
    End Property

    Private ReadOnly Property _OWNER_ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mOWNER_ARRAY_INCREMENT_DEFAULT
        End Get
    End Property
    Private Property _dateOpened As Date
        Get
            Return mDateOpened
        End Get
        Set(ByVal pValue As Date)
            mDateOpened = pValue
        End Set
    End Property

    Private Property _balance As Decimal
        Get
            Return mBalance
        End Get
        Set(pValue As Decimal)
            mBalance = pValue
        End Set
    End Property

    Private Property _annualPercentageInterestRate As Decimal
        Get
            Return mAnnualPercentageInterestRate

        End Get
        Set(ByVal pValue As Decimal)
            mAnnualPercentageInterestRate = pValue
        End Set
    End Property

    Private Property _nextAccrualDate As Date
        Get
            Return mNextAccrualDate

        End Get
        Set(ByVal pValue As Date)
            mNextAccrualDate = pValue
        End Set
    End Property

    Private Property _accountType As AccountType
        Get
            Return mAccountType

        End Get
        Set(ByVal pValue As AccountType)
            mAccountType = pValue
        End Set
    End Property

    Private Property _accountClosed As Boolean
        Get
            Return mAccountClosed
        End Get
        Set(ByVal pValue As Boolean)
            mAccountClosed = pValue
        End Set
    End Property

    Private Property _closedDate As Date
        Get
            Return mClosedDate
        End Get
        Set(ByVal pValue As Date)
            mClosedDate = pValue
        End Set
    End Property


    Private Property _accountNoOfTransactions As Integer
        Get
            Return mAccountNoOfTransactions
        End Get
        Set(ByVal pValue As Integer)
            mAccountNoOfTransactions = pValue
        End Set
    End Property

    Private Property _accountTransactions As Transaction
        Get
            Return mAccountTransactions

        End Get
        Set(ByVal pValue As Transaction)
            mAccountTransactions = pValue
        End Set
    End Property
    Private Property _ithOwner(ByVal pIndex As Integer) As Customer
        Get
            'ithOwner is used to get the value of the owner in the ith index

            If pIndex >= 0 And pIndex < _maxOwners Then
                Return mOwners(pIndex)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pValue As Customer)
            'ithOwner is used to set the value of the owner in the ith index
            If pIndex >= 0 And pIndex < _maxOwners Then
                mOwners(pIndex) = pValue
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
    Public Function NextAccrualInterestDate() As Date

        'returns the date value of the private 
        'nextAccrualDate() method .

        Return _nextAccrualInterestDate()

    End Function 'NextAccrualInterestDate()

    ' Public and Private Function for Tostring() 
    Public Overrides Function ToString() As String

        Return _toString()

    End Function 'Tostring()

    Public Function findOwner(
                                ByVal pOwnerID As String
                                ) As Customer

        'finds and returns the customer object using the customer Id
        '

        Dim foundLocation As Integer
        Return _findOwner(pOwnerID, foundLocation)
    End Function
    Public Iterator Function iterateOwner() _
        As _
            IEnumerable
        'This is used to interate through the owners 
        'List to yield the customer object   
        Dim theObject As Object

        For Each theObject In _iterateOwner() 'pId

            Yield theObject

        Next theObject

    End Function 'iterateCustomer()

    Public Sub addOwners(ByVal pAccountOwner As Customer)
        ' calls the private _addOwners method which is used to add owners  
        _addOwners(pAccountOwner)
    End Sub 'addOwners(pAccountOwner)
    Public Function getAccountOwners() As Customer()
        'calls the private _getAccountOwners() which returns the Account owners
        Return _getAccountOwners()
    End Function 'getAccountOwners()
    Public Function setNextAccrualDate(ByVal pRefDate As Date) As Date
        'is used to set the next accrual date after accruing the interest
        Return _setNextAccrualInterestDate(pRefDate)
    End Function 'setNextAccrualDate(pRefDate)
    '********** Private Non-Shared Behavioral Methods***********
    Private Function _nextAccrualInterestDate() As Date

        'calculates the nextAccrual Date for the account 
        'based on the date of account opened. 
        'declare variables
        Dim AccountOpenedDate As Date = _dateOpened.Date
        'Do processing
        If AccountOpenedDate.AddDays(1).Day.Equals(1) Then
            'the next accrual date is set for  last day of the month 
            nextAccrualDate = AccountOpenedDate.AddDays(1).AddMonths(1).AddDays(-1).Date
        Else
            'the next accrual date is set for any other day of the month
            nextAccrualDate = AccountOpenedDate.AddMonths(1).Date
        End If
        Return nextAccrualDate

    End Function '_nextAccrualInterestDate()

    Private Function _setNextAccrualInterestDate(ByVal pRefDate As Date) As Date

        'calculates the nextAccrual Date for the account 
        'based on the date of account opened. 

        Dim AccountOpenedDate As Date = _dateOpened.Date
        Dim monthDifference As Integer

        monthDifference = Integer.Parse(DateDiff(DateInterval.Month, dateOpened, pRefDate).ToString)
        'Do processing
        If AccountOpenedDate.AddDays(1).Day.Equals(1) Then
            'the next accrual date is set for  last day of the month 
            nextAccrualDate = AccountOpenedDate.AddDays(1).AddMonths(monthDifference).AddDays(-1).Date
        Else
            'the next accrual date is set for any other day of the month
            nextAccrualDate = AccountOpenedDate.AddMonths(monthDifference).Date
        End If
        Return nextAccrualDate

    End Function '_setNextAccrualInterestDate()
    Private Function _findOwner(
                     ByVal pOwnerID As String,
                     ByRef pFoundLocation As Integer) _
        As Customer
        'decalre variables
        Dim currentOwner As Customer
        'finding the location at which the customer is present and returning that 
        'customer based on the customer id 
        For pFoundLocation = 0 To _noOfOwners - 1
            currentOwner = _ithOwner(pFoundLocation)
            If currentOwner.custId = pOwnerID Then  'found @ pFoundLocation
                Return currentOwner
            End If
        Next pFoundLocation
        'returns nothing if the customer is not found
        Return Nothing
    End Function '_findOwner(pOwnerID,pFoundLocation)
    Private Iterator Function _iterateOwner() _
        As _
            IEnumerable

        Dim i As Integer
        'iterates through account owners id and yields each customer object
        For i = 0 To _owners.Count - 1
            If Not IsNothing(_owners(i)) Then
                Yield _ithOwner(i)
            End If
        Next i

    End Function '_iterateCustomer()


    Private Sub _addOwners(ByVal pAccountOwner As Customer)

        'checks if the owner exists or not 
        If IsNothing(pAccountOwner) Then
            MessageBox.Show("The Owner does not exist.")
            Exit Sub
        End If
        'checks if the owners array is full or not.if it is
        'full then the increment size isadded to the array
        If _noOfOwners >= _maxOwners Then
            _maxOwners += _OWNER_ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mOwners(_maxOwners - 1)
        End If

        'adds the owner to the owners array if it is not already there
        Try
            If Not _owners.Contains(pAccountOwner) Then
                _ithOwner(_noOfOwners) = pAccountOwner
            End If
        Catch ex As Exception
            Throw New IndexOutOfRangeException
        End Try

        'Increments the customer count of the  account 
        _noOfOwners += 1

    End Sub '_addOwners(pId)



    Private Function _toString() As String

        'Displays the account information
        Dim tmpstr As String

        tmpstr = vbCrLf & "( ACCOUNT : Account ID =" & _accId & "," _
                 & "Account Name = " & _accountName & ", " _
                 & "Account Type = " & _accountType.ToString & ", " _
                 & "Date Opened= " & _dateOpened & ", " _
                 & "Balance= " & _balance & ", " _
                 & "Accrue interest rate= " & _annualPercentageInterestRate & ", " _
                 & "Next accrual Date= " & _nextAccrualInterestDate().ToString & ", " _
                 & "No Of Owners= " & _noOfOwners & ", " _
                 & "Account Closed = " & _accountClosed & ", " _
                 & "Closed Date = " & _closedDate & ", " _
                 & "Account Owners = " & _getOwnerArray(_owners) _
                 & ") " & vbCrLf

        Return tmpstr

    End Function '_tostring()

    Private Function _getOwnerArray(ByVal pOwnersArray As Customer()) As String
        'declare variables
        Dim theOwner As Customer
        Dim theOwnersList As String = String.Empty

        'goes through each owner of the account and stores the 
        'ToString of the each owner and adds it to the theOwnersList 
        ' which is printed in the account to string
        For Each theOwner In pOwnersArray
            If Not IsNothing(theOwner) Then
                theOwnersList &= theOwner.ToString

            End If
        Next theOwner
        Return theOwnersList

    End Function
    Private Function _getAccountOwners() As Customer()

        'Declare variables
        Dim accountOwnersArray As Customer()

        'Do processing
        'stores the owner array into the accountOwners Array 
        accountOwnersArray = _owners

        'returns the accountOwnersArray
        Return accountOwnersArray

    End Function '_getAccountOwners()

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

End Class 'Account  
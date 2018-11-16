'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking Application
'File:               ClsBank_EventArgs_PurchaseCharged.vb
'Author:             Hari Chandana Paruchuri   
'Description:        Business Logic class for the event of Purchase Charged 
'Date:               2016 Nov 1
'                    - created the class and the filled the template with appropriate variables and methods.
'Tier:               Business Logic
'Exceptions:         None Defined
'Exception-Handling: None handled
'Events:             None Defined
'Event-Handling:     None Handled
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class Bank_EventArgs_PurchaseCharged
    Inherits System.EventArgs
#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mPurchaseCharged As Transaction

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
    Public Sub New(ByVal pPurchaseCharged As Transaction)
        MyBase.New()
        _purchaseCharged = pPurchaseCharged


    End Sub 'new(pPurchaseCharged)
    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************


    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public ReadOnly Property purchaseCharged As Transaction
        Get
            Return _purchaseCharged
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _purchaseCharged As Transaction
        Get
            Return mPurchaseCharged
        End Get
        Set(pValue As Transaction)
            mPurchaseCharged = pValue
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

    End Function '_ToString()

    '********** Private Non-Shared Behavioral Methods
    Private Function _toString() As String
        Dim tmpstr As String
        tmpstr = "( BANK_EVENTARGS_PURCHASECHARGED : " _
                  & "Purchase Charged = " & _purchaseCharged.ToString()

        Return tmpstr
    End Function '_toString()
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

End Class 'Bank_EventArgs_PurchaseCharged
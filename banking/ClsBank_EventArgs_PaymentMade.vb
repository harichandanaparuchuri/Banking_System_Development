'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking Application
'File:               ClsBank_EventArgs_PaymentMade.vb
'Author:             Hari Chandana Paruchuri   
'Description:        Business Logic class for the event of Making Payments
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

Public Class Bank_EventArgs_PaymentMade
    Inherits System.EventArgs
#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************



    '********** Module-level constants

    '********** Module-level variables
    Private mFromPaymentMade As Transaction
    Private mToPaymentMade As Transaction

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
    Public Sub New(ByVal pFromPaymentMade As Transaction,
                   ByVal pToPaymentMade As Transaction)
        MyBase.New()
        _fromPaymentMade = pFromPaymentMade
        _toPaymentMade = pToPaymentMade


    End Sub 'new(pPaymentMade)
    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************



    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public ReadOnly Property fromPaymentMade As Transaction
        Get
            Return _fromPaymentMade
        End Get
    End Property
    Public ReadOnly Property toPaymentMade As Transaction
        Get
            Return _toPaymentMade
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _fromPaymentMade As Transaction
        Get
            Return mFromPaymentMade
        End Get
        Set(pValue As Transaction)
            mFromPaymentMade = pValue
        End Set
    End Property
    Private Property _toPaymentMade As Transaction
        Get
            Return mToPaymentMade
        End Get
        Set(pValue As Transaction)
            mToPaymentMade = pValue
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

    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods
    Private Function _toString() As String
        Dim tmpstr As String
        tmpstr = "( BANK_EVENTARGS_PAYMENTMADE : " _
                  & "Payment Made = " & _fromPaymentMade.ToString() _
                  & _toPaymentMade.ToString()


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

End Class 'Bank_EventArgs_PaymentMade
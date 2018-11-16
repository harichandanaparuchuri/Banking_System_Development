'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking Application
'File:               ClsBank_EventArgs_InterestAccrued.vb
'Author:             Hari Chandana Paruchuri   
'Description:        Business Logic for the event of Accruing Interest 
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

Public Class Bank_EventArgs_InterestAccrued
    Inherits System.EventArgs
#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************


    '********** Module-level constants

    '********** Module-level variables
    Private mInterestAccrued As Transaction

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
    Public Sub New(ByVal pInterestAccrued As Transaction)
        MyBase.New()
        _interestAccrued = pInterestAccrued


    End Sub 'new(pInterestAccrued)
    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************



    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public ReadOnly Property interestAccrued As Transaction
        Get
            Return _interestAccrued
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _interestAccrued As Transaction
        Get
            Return mInterestAccrued
        End Get
        Set(pValue As Transaction)
            mInterestAccrued = pValue
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
        tmpstr = "( BANK_EVENTARGS_INTERESTACCRUED : " _
                  & " Interest Accrued = " & _interestAccrued.ToString()

        Return tmpstr
    End Function

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

End Class 'Bank_EventArgs_InterestAccrued
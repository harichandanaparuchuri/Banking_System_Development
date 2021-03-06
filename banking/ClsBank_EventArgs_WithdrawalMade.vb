﻿'Copyright (c) 2009-2016 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Banking Application
'File:               ClsBank_EventArgs_WithdrawalMade.vb
'Author:             Hari Chandana Paruchuri   
'Description:        Business Logic class for the event of Making withdrawal 
'Date:               2016 Nov 1
'                      - Created the class and the filled the template with appropriate variables and methods.
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

Public Class Bank_EventArgs_WithdrawalMade
    Inherits System.EventArgs
#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mWithdrawalMade As Transaction

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
    Public Sub New(ByVal pWithdrawalMade As Transaction)
        MyBase.New()

        _withdrawalMade = pWithdrawalMade

    End Sub 'new(pWithdrawalMade)


    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************


    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public ReadOnly Property withdrawalMade As Transaction
        Get
            Return _withdrawalMade
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _withdrawalMade As Transaction
        Get
            Return mWithdrawalMade
        End Get
        Set(pValue As Transaction)
            mWithdrawalMade = pValue
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
        tmpstr = "( BANK_EVENTARGS_WITHDRAWALMADE : " _
                  & "Withdrawal Made = " & _withdrawalMade.ToString()

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

End Class 'Bank_EventArgs_WithdrawalMade
Public Module ModBank
    'This holds "global" type definitions,
    'Enum entries are Integers, which can include negative values.
    'Default value for first entry is 0.
    'Default value for subsequent entries is 1 more than the previous entrie's value.

    Public Enum AccountType
        Checking = 1
        Loan           ' value is 2 by default
        CreditCard     ' value is 3 by default
    End Enum 'AccountType

    Public Enum TransactionType
        OpenAccount = 1
        MakeDeposit             ' value is 2 by default
        MakeWithdrawal          ' value is 3 by default
        UseDebitCard            ' value is 4 by default
        ChargePurchase          ' value is 5 by default
        MakePayment             ' value is 6 by default
        TransferFunds           ' value is 7 by default
        AccrueInterest          ' value is 8 by default
    End Enum 'TransactionType

End Module 'ModBank

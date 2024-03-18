using System;

namespace test.Basics.Lab09.Interfaces
{
    public interface IAccountWithLimit : IAccount
    {
        // przyznany limit debetowy
        // mozliwość zmiany, jeśli konto nie jest zablokowane
        decimal OneTimeDebetLimit { get; set; }

        // dostępne środki, z uwzględnieniem limitu
        decimal AvaibleFounds { get; }
    }
}

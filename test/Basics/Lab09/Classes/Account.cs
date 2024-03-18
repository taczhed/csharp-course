using System;
using test.Basics.Lab09.Interfaces;

namespace test.Basics.Lab09.Classes
{
    public class Account : IAccount
    {
        readonly string _name;
        decimal _balance;
        bool _isBlocked;

        public string Name { get => _name; }
        public decimal Balance { get => Math.Round(_balance, 4); }
        public bool IsBlocked { get => _isBlocked; }

        public Account(string name, decimal initialBalance = 0)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentOutOfRangeException();

            if (name.Trim().Length < 3)
                throw new ArgumentException();

            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException();

            _name = name.Trim();
            _balance = initialBalance;
            _isBlocked = false;
        }

        public void Block()
        {
            _isBlocked = true;
        }

        public void Unblock()
        {
            _isBlocked = false;
        }

        public bool Deposit(decimal amount)
        {
            if (_isBlocked || amount < 0) return false;
            _balance += amount;
            return true;
        }

        public bool Withdrawal(decimal amount)
        {
            if (_isBlocked || amount <= 0 || _balance < amount) return false;
            _balance -= amount;
            return true;
        }

        public override string ToString()
        {
            if (_isBlocked) return $"Account name: {Name}, balance: {Balance.ToString("N2")}, blocked";
            return $"Account name: {Name}, balance: {Balance.ToString("N2")}";
        }
    }
}

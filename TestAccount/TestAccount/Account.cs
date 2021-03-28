using System;

namespace TestAccount
{
    class Account
    {
        //Instance Variable
        private decimal _balance;
        private string _name;

        public Account(string name, decimal balance)
        {
            this._name = name;
            this._balance = balance;
        }
        public void Deposit(decimal amount)
        {
            this._balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this._balance -= amount;
        }
        public void Print()
        {
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Balance: " + this._balance.ToString("C"));
        }
        public string Name => "Name of Account: " + $"{_name}";
    }
}

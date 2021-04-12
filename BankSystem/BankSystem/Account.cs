using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
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
        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this._balance += amount;
                Console.WriteLine("Deposit succeeded! New Balance: " + this._balance);

                return true;
            }
            else 
            {
                Console.WriteLine("Deposit failed");
                return false;
            }
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= this._balance && amount > 0)
            {
                this._balance -= amount;
                Console.WriteLine("Withdraw success! New Balance: " + this._balance);
                return true;
            }
            else
            {
                Console.WriteLine("Cannot withdraw more than the available balance nor a negative amount");
                return false;
            }

        }
        public void Print()
        {
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Balance: " + this._balance.ToString("C"));
        }
        public string Name => "Name of Account: " + $"{_name}";

    }
}

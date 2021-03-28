using System;

namespace TestAccount
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account newAccount = new Account("Jack", 5);
            newAccount.Print();
            newAccount.Deposit(10);
            newAccount.Print();
            newAccount.Withdraw(5);
            newAccount.Print();

            newAccount.Name("Jack");
        }
    }
}

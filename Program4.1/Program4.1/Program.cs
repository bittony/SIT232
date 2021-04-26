using System;

namespace Program4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account("Sergey", "P", 100);
                account.Withdraw(1000);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {
                Account account = new Account(null, "P", 500);
                account.Deposit(1000);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (StackOverflowException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            try
            {

            }
            catch (SystemException exception)
            {
                Console.WriteLine("The following error detected: " + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }
            Console.ReadKey();
        }
    }
}
class Account
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Balance { get; private set; }

    public Account(string firstName, string lastName, int balance)
    {
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient fund");
        }
        Balance = Balance - amount;
    }

    public void Deposit(int amount)
    {
        if (amount > Balance)
        {
            throw new NullReferenceException("Insufficient null");
        }
        Balance = Balance + amount;
    }
}

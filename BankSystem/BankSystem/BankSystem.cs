using System;

namespace BankSystem
{
    enum MenuOption
    {
        Withdraw = 1,
        Deposit,
        Print,
        Quit
    }
    class BankSystem
    {
        
        static void Main(string[] args)
        {
            int userChoice;
            Account account1 = new Account("James", 20);
            userChoice = (int)ReadUserOption();
            
            switch (userChoice)
            {
                case 1:
                    DoWithdraw(account1);
                    break;
                case 2:
                    DoDeposit(account1);
                    break;
                case 3:
                    DoPrint(account1);
                    break;
                case 4:
                    Console.WriteLine("Quitting");
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            void DoWithdraw(Account account)
            {
                decimal amount;
                Console.WriteLine("Please enter an amount to withdraw: ");
                amount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(amount);
            }
            void DoDeposit(Account account)
            {
                decimal amount;
                Console.WriteLine("Please enter an amount to deposit: ");
                amount = Convert.ToDecimal(Console.ReadLine());
                account.Deposit(amount);
            }
            void DoPrint(Account account)
            {
                account.Print();
            }
        }
        public static MenuOption ReadUserOption()
        {
            MenuOption choice;

            do
            {
                Console.WriteLine("Please choose from the following options: ");
                Console.WriteLine("Enter 1 to withdraw");
                Console.WriteLine("Enter 2 to deposit");
                Console.WriteLine("Enter 3 to print account info");
                Console.WriteLine("Enter 4 to quit");
                choice = (MenuOption)Convert.ToInt32(Console.ReadLine());
                return choice;
            } while (choice > 0);
        }
        
    } 
}
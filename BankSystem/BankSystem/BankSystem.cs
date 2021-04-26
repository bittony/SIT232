using System;

namespace BankSystem
{
    enum MenuOption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }
    class BankSystem
    {

        static void Main(string[] args)
        {
            int userChoice;
            bool forever = true;
            Account account1 = new Account("James", 20);
            do
            {
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
                        forever = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            } while (forever);

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
            Enum Withdraw = MenuOption.Withdraw;
            Enum Deposit = MenuOption.Deposit;
            Enum Print = MenuOption.Print;
            Enum Quit = MenuOption.Quit;
            MenuOption choice;
            
            Console.WriteLine("Enter 1 to " + Withdraw.ToString());
            Console.WriteLine("Enter 2 to " + Deposit.ToString());
            Console.WriteLine("Enter 3 to " + Print.ToString());
            Console.WriteLine("Enter 4 to " + Quit.ToString());
            choice = (MenuOption)Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    } 
}
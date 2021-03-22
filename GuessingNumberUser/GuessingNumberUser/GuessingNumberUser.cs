using System;

namespace GuessingNumberUser
{
    class GuessingNumberUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 please enter a number: ");
            int user1 = UserInput1();
            
            Console.WriteLine("Player 2, please guess the number: ");
            do
            {
                int user2 = UserInput2();

                if (user1 == user2)
                {
                    Console.WriteLine("You have guessed correctly!");
                    break;
                }
                else if (user1 != user2)
                {
                    Console.WriteLine("Please try again!");
                }
            } while (true);
        }
        private static int UserInput1()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter in a correct format");
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }
        private static int UserInput2()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter in a correct format");
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }
    }
}
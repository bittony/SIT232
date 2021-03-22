using System;

namespace GuessingNumber
{
    class GuessingNumber
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine("Please guess a number between 1 and 10: ");
            do
            {
                int guess = Input();

                if (guess == number)
                {
                    Console.WriteLine("You have guessed correctly!"); 
                    break;
                }
                else if (guess < 1 || guess > 10)
                {
                    Console.WriteLine("Please enter a number between 1 and 10");
                }
                else if (guess != number)
                {
                    Console.WriteLine("Please try again!");
                }
            } while (true);
        }
        private static int Input()
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

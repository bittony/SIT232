using System;

namespace DemoTesting
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int sum = 7;
            if (sum > 20)
            {
                Console.WriteLine("You win ");
            }
            else
            {
                Console.WriteLine("You lose ");
            }
            Console.WriteLine("the prize.");
        }
    }
}
using System;

namespace DivisibleFour
{
    class DivisibleFour
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers divisible by 4 but not 5 are: ");

            for (int i = 1; i <= n; i++)
            {
                if ((i % 4 == 0) & (i % 5 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

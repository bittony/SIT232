using System;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;
            int number = 1;
            
            while (number <= upperbound)
            {
                sum += number;
                number++;
                Console.WriteLine(number);
            }
            
            Console.WriteLine("The sum is " + sum);
            average = (double)sum / upperbound;
            Console.WriteLine("The average is " + average);
        }
    }
}

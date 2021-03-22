using System;

namespace DoCasting
{
    class DoCasting
    {
        static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;
            int intAverage = sum / count;
            Console.WriteLine(intAverage);
            
            double doubleAverage = (double)sum / count;
            Console.WriteLine(doubleAverage);
        }
    }
}

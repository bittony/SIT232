using System;

namespace Microwave
{
    class Microwave
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please enter the number of items: ");
                int item = Input();

                Console.WriteLine("Please enter the heating time for a single item in seconds: ");
                int time = Input();

                if (item == 1)
                {
                    Console.WriteLine("The recommended heating time is: " + time + " seconds.");
                }
                else if (item == 2)
                {
                    Console.WriteLine("The recommended heating time is: " + time * 1.5 + " seconds.");
                }
                else if (item == 3)
                {
                    Console.WriteLine("The recommended heating time is: " + time * 2 + " seconds.");
                }
                else if (item > 3)
                {
                    Console.WriteLine("Heating more than three items at once is not recommended.");
                }
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
                    Console.WriteLine("Please enter in the correct format");
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }   
    }
}

using System;

namespace _1._1
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an integer): ");

            while (true)
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number == 1)
                    {
                        Console.WriteLine("ONE"); break;
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("TWO"); break;
                        }
                    else if (number == 3)
                    {
                        Console.WriteLine("THREE"); break;
                        }
                    else if (number == 4)
                    {
                        Console.WriteLine("FOUR"); break;
                        }
                    else if (number == 5)
                    {
                        Console.WriteLine("FIVE"); break;
                        }
                    else if (number == 6)
                    {
                        Console.WriteLine("SIX"); break;
                        }
                    else if (number == 7)
                    {
                        Console.WriteLine("SEVEN"); break;
                        }
                    else if (number == 8)
                    {
                        Console.WriteLine("EIGHT"); break;
                        }
                    else if (number == 9)
                    {
                        Console.WriteLine("NINE"); break;
                        }
                    else if ((number < 1) || (number >9))
                    {
                        Console.WriteLine("Please enter a number between 1 and 9");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter the number as an integer");
                }
        }
    }
}

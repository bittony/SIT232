using System;

namespace SnippetTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 500)
            {
                Console.WriteLine(x);
                x = x + 5;
            }
        }
    }
}

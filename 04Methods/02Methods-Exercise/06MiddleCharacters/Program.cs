using System;

namespace _06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        private static void PrintMiddleChar(string input)
        {
            int n = input.Length / 2;
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[n]);
            }
            else
            {
                Console.WriteLine($"{input[n - 1]}{input[n]}");
            }
        }
    }
}

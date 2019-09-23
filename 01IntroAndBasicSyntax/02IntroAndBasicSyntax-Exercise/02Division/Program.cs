using System;

namespace _02Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDivision = int.MinValue;

            if (n % 10 == 0)
            {
                maxDivision = 10;
            }
            else if (n % 7 == 0)
            {
                maxDivision = 7;
            }
            else if (n % 6 == 0)
            {
                maxDivision = 6;
            }
            else if (n % 3 == 0)
            {
                maxDivision = 3;
            }
            else if (n % 2 == 0)
            {
                maxDivision = 2;
            }

            if (maxDivision > 0)
            {
                Console.WriteLine($"The number is divisible by {maxDivision}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}

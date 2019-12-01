using System;

namespace _02SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int digits = number % 10;
                sum += digits;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}

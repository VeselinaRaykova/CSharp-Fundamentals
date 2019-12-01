using System;
using System.Linq;

namespace _02FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long sum = 0;
                long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                if (numbers[0] > numbers[1])
                {
                    sum = SumDigits(Math.Abs(numbers[0]));
                }
                else
                {
                    sum = SumDigits(Math.Abs(numbers[1]));
                }

                Console.WriteLine(sum);
            }
        }

        private static long SumDigits(long number)
        {
            long sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}

using System;
using System.Linq;

namespace _06EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int oddsum = 0;
            int evenSum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddsum += number;
                }
            }

            Console.WriteLine(evenSum - oddsum);
        }
    }
}

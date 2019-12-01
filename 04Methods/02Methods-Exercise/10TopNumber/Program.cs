using System;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 8; i <= number; i++)
            {
                if (IsTop(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTop(int number)
        {
            int digitsSum = 0;
            int oddDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                digitsSum += digit;
                if (digit % 2 != 0)
                {
                    oddDigits++;
                }
            }

            if (digitsSum % 8 == 0 && oddDigits > 0)
            {
                return true;
            }

            return false;
        }
    }
}

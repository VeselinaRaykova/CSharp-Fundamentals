using System;

namespace _06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int factorial = 1;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                factorial = 1;
                int currDigit = int.Parse(input[i].ToString());
                for (int j = 1; j <= currDigit; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

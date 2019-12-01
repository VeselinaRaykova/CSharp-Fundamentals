using System;

namespace _04TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            CalculateSequence(number);
        }

        private static void CalculateSequence(int number)
        {
            int[] tribonacci = new int[number];

            for (int i = 0; i < number; i++)
            {
                if (i < 2)
                {
                    tribonacci[i] = 1;
                }
                else if (i == 2)
                {
                    tribonacci[i] = 2;
                }
                else
                {
                    tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                }
            }

            Console.WriteLine(string.Join(" ", tribonacci));
        }
    }
}

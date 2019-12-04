using System;

namespace _03RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = GetFibonacci(n);

            Console.WriteLine(number);
        }

        private static int GetFibonacci(int n)
        {
            if (n > 2)
            {
                int number =  GetFibonacci(n - 1) + GetFibonacci(n - 2);
                return number;
            }
            else
            {
                return 1;
            }
        }
    }
}

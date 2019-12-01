using System;

namespace _05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            int result = Substract(sum, c);
            Console.WriteLine(result);
        }

        private static int Substract(int sum, int c)
        {
            return sum - c;
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}

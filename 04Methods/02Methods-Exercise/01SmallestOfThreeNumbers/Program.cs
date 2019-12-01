using System;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetSmallestNumber(a, b, c);

            Console.WriteLine(result);
        }

        private static int GetSmallestNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}

using System;

namespace _06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            CalculateArea(a, b);
        }

        private static void CalculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine($"{area}");
        }
    }
}

using System;

namespace _03LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lineA = GetDistance(x1, y1, x2, y2);
            double lineB = GetDistance(x3, y3, x4, y4);

            if (lineA >= lineB)
            {
                PrintPoints(x1, y1, x2, y2);
            }
            else
            {
                PrintPoints(x3, y3, x4, y4);
            }
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            double a = x2 - x1;
            double b = y2 - y1;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return c;
        }

        private static void PrintPoints(double x1, double y1, double x2, double y2)
        {
            double distanceA = GetDistance(x1, y1, 0, 0);
            double distanceB = GetDistance(x2, y2, 0, 0);

            if (distanceA <= distanceB)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}

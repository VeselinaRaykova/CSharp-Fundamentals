using System;

namespace _08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double factA = CalculateFactorial(a);
            double factB = CalculateFactorial(b);
            double factDivision = Divide(factA, factB);

            Console.WriteLine($"{factDivision:f2}");
        }

        private static double Divide(double factA, double factB)
        {
            return factA / factB * 1.00;
        }

        private static double CalculateFactorial(int num)
        {
            double factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}

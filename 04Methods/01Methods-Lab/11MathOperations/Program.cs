using System;

namespace _11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Calculate(a, b, command);

            Console.WriteLine(result);
        }

        private static double Calculate(int a, int b, string command)
        {
            double result = 0;

            switch (command)
            {
                case "*": result = a * b; break;
                case "/": result = a / b; break;
                case "+": result = a + b; break;
                case "-": result = a - b; break;

                default:
                    break;
            }

            return result;
        }
    }
}

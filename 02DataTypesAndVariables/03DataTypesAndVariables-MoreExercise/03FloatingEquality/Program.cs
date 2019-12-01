using System;

namespace _03FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if ((Math.Abs(firstNum-secondNum) < eps))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

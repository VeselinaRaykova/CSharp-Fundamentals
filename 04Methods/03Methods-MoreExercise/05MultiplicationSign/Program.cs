using System;

namespace _05MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            GetSign(n1, n2, n3);
        }

        private static void GetSign(int n1, int n2, int n3)
        {
            int negativesCount = 0;

            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            if (n1 < 0)
            {
                negativesCount++;
            }
            if (n2 < 0)
            {
                negativesCount++;
            }
            if (n3 < 0)
            {
                negativesCount++;
            }

            if (negativesCount % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}

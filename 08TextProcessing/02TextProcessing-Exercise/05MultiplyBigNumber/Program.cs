using System;
using System.Numerics;

namespace _05MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            BigInteger result = a * b;
            Console.WriteLine(result);
        }
    }
}

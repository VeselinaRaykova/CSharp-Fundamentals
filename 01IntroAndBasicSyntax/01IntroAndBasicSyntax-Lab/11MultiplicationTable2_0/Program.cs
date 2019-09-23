using System;

namespace _11MultiplicationTable2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());

            if (startNumber > 10)
            {
                Console.WriteLine($"{n} X {startNumber} = {n * startNumber}");
                return;
            }

            for (int i = startNumber; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}

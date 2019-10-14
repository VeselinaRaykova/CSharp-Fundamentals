using System;

namespace _07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int liters;
            int litertsInTank = 0;

            for (int i = 0; i < n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                if (liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                capacity -= liters;
                litertsInTank += liters;
            }

            Console.WriteLine(litertsInTank);
        }
    }
}

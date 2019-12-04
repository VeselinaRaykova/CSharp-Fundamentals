using System;

namespace _01BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            byte dailyPlunder = byte.Parse(Console.ReadLine());
            double target = double.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                total += dailyPlunder;
                if (i % 3 == 0)
                {
                    total += dailyPlunder / 2.0;
                }

                if (i % 5 == 0)
                {
                    total *= 0.7;
                }
            }

            if (total >= target)
            {
                Console.WriteLine($"Ahoy! {total:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {100 * total / target:f2}% of the plunder.");
            }
        }
    }
}

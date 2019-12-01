using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BiscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine()); //per worker
            int workers = int.Parse(Console.ReadLine());
            int competitorBiscuits = int.Parse(Console.ReadLine());
            int producedBicuits = 0;
            int diff = 0;
            double percentage = 0.0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    producedBicuits += (int)(biscuitsPerDay * 0.75 * workers);
                }
                else
                {
                    producedBicuits += biscuitsPerDay * workers;
                }
            }
            diff = producedBicuits - competitorBiscuits;
            percentage = (double)(100 * Math.Abs(diff) * 1.00 / competitorBiscuits * 1.00);

            Console.WriteLine($"You have produced {producedBicuits} biscuits for the past month.");

            if (diff < 0)
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");

            }
        }
    }
}

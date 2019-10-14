using System;

namespace _10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int halfPower = (int)(0.5 * power);
            int distance = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());
            int targets = 0;

            while (power >= distance)
            {
                power -= distance;
                targets++;
                if (power == halfPower && exhaustFactor != 0)
                {
                    power /= exhaustFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}

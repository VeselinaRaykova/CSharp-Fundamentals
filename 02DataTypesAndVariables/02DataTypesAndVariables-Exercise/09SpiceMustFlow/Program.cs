using System;

namespace _09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine()); //space mined on the first day

            int spices = 0;
            int left = 0;
            int consumed = 26;
            int days = 0;

            while (yield >= 100)
            {
                spices += yield;
                left += yield - consumed;
                yield -= 10;
                days++;
            }

            left = left > 26 ? left -= 26 : 0;

            Console.WriteLine(days);
            Console.WriteLine(left);
        }
    }
}

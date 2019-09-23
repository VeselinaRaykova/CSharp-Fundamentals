using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (groupType == "Students")
            {
                switch (day)
                {
                    case "Friday": price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                    default:
                        break;
                }

                price *= n;

                if (n >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                switch (day)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                    default:
                        break;
                }

                if (n >= 100)
                {
                    n -= 10;
                }

                price *= n;

            }
            else if (groupType == "Regular")
            {
                switch (day)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                    default:
                        break;
                }

                price *= n;

                if (n >= 10 && n <= 20)
                {
                    price *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double total = 0;
            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                double gamePrice = 0;
                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:
                        break;
                }

                if (gamePrice == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (gamePrice <= money)
                {
                    money -= gamePrice;
                    total += gamePrice;
                    Console.WriteLine($"Bought {game}");

                    if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${money:f2}");
        }
    }
}

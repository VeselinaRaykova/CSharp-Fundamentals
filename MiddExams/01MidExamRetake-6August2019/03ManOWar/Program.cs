using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShipSections = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warShipSections = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxHealthCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "Retire")
            {
                string command = input[0];
                List<int> commandArgs = input.Skip(1).Select(int.Parse).ToList();

                if (command == "Fire")
                {
                    int index = commandArgs[0];
                    int damage = commandArgs[1];
                    if (index >= 0 && index < warShipSections.Count)
                    {
                        warShipSections[index] -= damage;
                        if (warShipSections[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = commandArgs[0];
                    int endIndex = commandArgs[1];
                    int damage = commandArgs[2];

                    if (startIndex >= 0 && startIndex < pirateShipSections.Count &&
                        endIndex >= 0 && endIndex < pirateShipSections.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShipSections[i] -= damage;
                            if (pirateShipSections[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if (command == "Repair")
                {
                    int index = commandArgs[0];
                    int health = commandArgs[1];
                    if (index >= 0 && index < pirateShipSections.Count)
                    {
                        pirateShipSections[index] += health;
                        if (pirateShipSections[index] > maxHealthCapacity)
                        {
                            pirateShipSections[index] = maxHealthCapacity;
                        }
                    }

                }
                else if (command == "Status")
                {
                    int count = 0;
                    double targetHealth = maxHealthCapacity * 0.2;
                    foreach (int section in pirateShipSections)
                    {
                        if (section < targetHealth)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }

                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Pirate ship status: {pirateShipSections.Sum()}");
            Console.WriteLine($"Warship status: {warShipSections.Sum()}");
        }
    }
}

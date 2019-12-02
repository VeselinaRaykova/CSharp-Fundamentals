using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "end")
            {
                if (commandArgs[0] == "Add")
                {
                    int newWagon = int.Parse(commandArgs[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int passengers = int.Parse(commandArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}

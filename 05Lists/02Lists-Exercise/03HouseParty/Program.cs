using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] message = Console.ReadLine().Split().ToArray();
                string name = message[0];
                if (message[2] == "not")
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }
                }
                else
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

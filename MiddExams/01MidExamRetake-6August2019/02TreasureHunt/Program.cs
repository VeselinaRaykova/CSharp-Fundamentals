using System;
using System.Collections.Generic;
using System.Linq;

namespace _02TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loots = Console.ReadLine().Split('|').ToList();
            string input = Console.ReadLine();
            double averageGain = 0;

            while (input != "Yohoho!")
            {
                List<string> commandArgs = input.Split(' ').ToList();
                string command = commandArgs[0];
                commandArgs = commandArgs.Skip(1).ToList();

                if (command == "Loot")
                {
                    foreach (string loot in commandArgs)
                    {
                        if (loots.IndexOf(loot) < 0)
                        {
                            loots.Insert(0, loot);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(commandArgs[0]);
                    if (index >= 0 && loots.Count > index)
                    {
                        string temp = loots[index];
                        loots.RemoveAt(index);
                        loots.Add(temp);
                    }
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(commandArgs[0]);
                    List<string> removed = new List<string>();
                    if (count >= loots.Count)
                    {
                        removed = loots;
                        Console.WriteLine(string.Join(", ", removed));
                        loots.RemoveRange(0, loots.Count);
                    }
                    else
                    {
                        //0 1 2 3 4 5 6 7 8
                        int startIndex = loots.Count - count;
                        removed = loots.Skip(startIndex).ToList();
                        Console.WriteLine(string.Join(", ", removed));
                        loots.RemoveRange(startIndex, count);
                    }
                }

                input = Console.ReadLine();
            }

            if (loots.Count > 0)
            {
                foreach (var treasure in loots)
                {
                    averageGain += treasure.Length;
                }
                averageGain /= loots.Count;

                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            string input = Console.ReadLine();

            string namePattern = @"[A-Za-z]+";
            string scorePattern = @"\d";
            Dictionary<string, int> participants = new Dictionary<string, int>();

            while (input != "end of race")
            {
                MatchCollection nameMatchs = Regex.Matches(input, namePattern);
                string name = "";
                foreach (Match m in nameMatchs)
                {
                    name += m.Value;
                }

                if (names.Contains(name))
                {
                    if (!participants.ContainsKey(name))
                    {
                        participants.Add(name, 0);
                    }
                    MatchCollection scoreMatches = Regex.Matches(input, scorePattern);
                    foreach (Match item in scoreMatches)
                    {
                        participants[name] += int.Parse(item.Value);
                    }
                }

                input = Console.ReadLine();
            }

            List<string> winners = new List<string>();
            foreach (var p in participants.OrderByDescending(p => p.Value).Take(3))
            {
                winners.Add(p.Key);
            }

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }
    }
}

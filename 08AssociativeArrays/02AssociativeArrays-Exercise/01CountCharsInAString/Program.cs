using System;
using System.Collections.Generic;

namespace _01CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (!chars.ContainsKey(c))
                {
                    chars.Add(c, 0);
                }

                chars[c]++;
            }

            foreach (var pair in chars)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

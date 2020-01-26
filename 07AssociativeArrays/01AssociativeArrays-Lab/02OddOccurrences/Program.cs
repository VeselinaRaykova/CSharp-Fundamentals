using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();

                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }

            foreach (var pair in counts.Where(p => p.Value % 2 != 0))
            {
                Console.Write($"{pair.Key} ");
            }
        }
    }
}

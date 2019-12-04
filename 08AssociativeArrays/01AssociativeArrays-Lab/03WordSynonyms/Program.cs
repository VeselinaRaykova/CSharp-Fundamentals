using System;
using System.Collections.Generic;

namespace _03WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }

                words[word].Add(synonym);
            }

            foreach (var pair in words)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}

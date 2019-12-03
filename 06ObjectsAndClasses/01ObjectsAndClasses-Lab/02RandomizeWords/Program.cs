using System;
using System.Collections.Generic;
using System.Linq;

namespace _02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            while (words.Count > 0)
            {
                int index = rnd.Next(0, words.Count - 1);
                string word = words[index];
                Console.WriteLine(word);
                words.RemoveAt(index);
            }
        }
    }
}

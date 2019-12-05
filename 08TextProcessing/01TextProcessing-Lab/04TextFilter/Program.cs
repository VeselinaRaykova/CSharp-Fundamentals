using System;
using System.Linq;

namespace _04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                while (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}

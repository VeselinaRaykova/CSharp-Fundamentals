using System;
using System.Linq;
using System.Text;

namespace _02RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}

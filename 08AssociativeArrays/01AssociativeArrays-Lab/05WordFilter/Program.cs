using System;
using System.Linq;

namespace _05WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string[] evenWords = words.Where(x => x.Length % 2 == 0).ToArray();
            foreach (string w in evenWords)
            {
                Console.WriteLine(w);
            }
        }
    }
}

using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                text = text.Remove(text.IndexOf(key), key.Length);
            }

            Console.WriteLine(text);
        }
    }
}

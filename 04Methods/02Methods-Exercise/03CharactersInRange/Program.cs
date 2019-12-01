using System;

namespace _03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharsBetween(firstChar, secondChar);
        }

        private static void PrintCharsBetween(char firstChar, char secondChar)
        {
            int startIndex = Math.Min((int)firstChar, (int)secondChar);
            int endIndex = Math.Max((int)firstChar, (int)secondChar);

            for (int i = startIndex+1; i < endIndex; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}

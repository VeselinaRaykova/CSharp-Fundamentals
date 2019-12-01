using System;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = GetVowelsCound(word);

            Console.WriteLine(count);
        }

        private static int GetVowelsCound(string word)
        {
            int vowelsCount = 0;
            foreach (char ch in word)
            {
                if (ch == 'a' ||
                    ch == 'o' ||
                    ch == 'i' ||
                    ch == 'e' ||
                    ch == 'u' ||
                    ch == 'A' ||
                    ch == 'O' ||
                    ch == 'I' ||
                    ch == 'E' ||
                    ch == 'U')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}

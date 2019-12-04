using System;

namespace _01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] decoded = new int[n];
            int[] vowels = new int[] { 65, 69, 73, 79, 85, 97, 101, 105, 111, 117 };

            for (int i = 0; i < n; i++)
            {
                string wordToDecode = Console.ReadLine();
                int wordSum = 0;

                foreach (char ch in wordToDecode)
                {
                    int code = (int)ch;
                    bool isVowel = Array.IndexOf(vowels, code) >= 0;
                    if (isVowel)
                    {
                        wordSum += code * wordToDecode.Length;
                    }
                    else
                    {
                        wordSum += (int)(code / wordToDecode.Length);
                    }
                }

                decoded[i] = wordSum;
            }

            Array.Sort(decoded);

            foreach (int sum in decoded)
            {
                Console.WriteLine(sum);
            }
        }

            
    }
}

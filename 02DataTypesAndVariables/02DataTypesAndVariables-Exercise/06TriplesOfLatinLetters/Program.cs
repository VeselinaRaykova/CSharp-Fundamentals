using System;

namespace _06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = (int)'a';
            int last = first + n;

            for (int i = first; i < last; i++)
            {
                for (int j = first; j < last; j++)
                {
                    for (int k = first; k < last; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}

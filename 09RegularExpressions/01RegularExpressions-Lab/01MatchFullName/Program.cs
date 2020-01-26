using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(string.Join(" ", matches));
            //foreach (Match match in matches)
            //{
            //    Console.Write($"{match.Value} ");
            //}
            //Console.WriteLine();
        }
    }
}

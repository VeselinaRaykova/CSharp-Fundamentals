using System;
using System.Text;

namespace _05DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    symbols.Append(ch);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}

using System;
using System.Linq;

namespace _08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0.0;

            for (int i = 0; i < data.Length; i++)
            {
                string text = data[i];
                char firstLetter = text[0];
                char lastLetter = text[text.Length - 1];
                double number = double.Parse(text.Substring(1, (text.Length - 2)));
                double tempResult = 0;

                if (char.IsUpper(firstLetter))
                {
                    tempResult = number / ((int)firstLetter - 64);
                }
                else if (char.IsLower(firstLetter))
                {
                    tempResult = number * ((int)firstLetter - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    tempResult -= (int)lastLetter - 64;
                }
                else if (char.IsLower(lastLetter))
                {
                    tempResult += (int)lastLetter - 96;
                }

                sum += tempResult;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}

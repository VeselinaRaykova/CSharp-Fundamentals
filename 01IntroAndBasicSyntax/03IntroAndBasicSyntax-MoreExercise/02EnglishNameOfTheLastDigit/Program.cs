using System;

namespace _02EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            string digitName = "";

            switch (digit)
            {
                case 0: digitName = "zero"; break;
                case 1: digitName = "one"; break;
                case 2: digitName = "two"; break;
                case 3: digitName = "three"; break;
                case 4: digitName = "four"; break;
                case 5: digitName = "five"; break;
                case 6: digitName = "six"; break;
                case 7: digitName = "seven"; break;
                case 8: digitName = "eight"; break;
                case 9: digitName = "nine"; break;
                default:
                    break;
            }

            Console.WriteLine(digitName);
        }
    }
}

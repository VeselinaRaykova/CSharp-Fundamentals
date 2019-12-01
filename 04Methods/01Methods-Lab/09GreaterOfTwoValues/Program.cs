using System;

namespace _09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int resultInt = GetMax(int.Parse(a), int.Parse(b));
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char resultChar = GetMax(char.Parse(a), char.Parse(b));
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string resultString = GetMax(a, b);
                    Console.WriteLine(resultString);
                    break;
                default:
                    break;
            }
        }

        private static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) > 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

        private static char GetMax(char ch1, char ch2)
        {
            return (char)Math.Max(ch1, ch2);
        }

        private static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }
}

using System;

namespace _01DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            PrintResult(type, input);
        }

        private static void PrintResult(string type, string input)
        {
            switch (type)
            {
                case "int":
                    Console.WriteLine($"{int.Parse(input) * 2}");
                    break;
                case "real":
                    Console.WriteLine($"{double.Parse(input) * 1.5:f2}");
                    break;
                default: //string
                    Console.WriteLine($"${input}$");
                    break;
            }
        }
    }
}

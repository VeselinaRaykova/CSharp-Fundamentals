using System;
using System.Text.RegularExpressions;

namespace _01Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>\b(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)\b";
            double spendMoney = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    MatchCollection matches = Regex.Matches(input, pattern);

                    foreach (Match m in matches)
                    {
                        string name = m.Groups["name"].Value;
                        double price = double.Parse(m.Groups["price"].Value);
                        int quantity = int.Parse(m.Groups["quantity"].Value);
                        spendMoney += price * quantity;
                        Console.WriteLine(name);
                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"Total money spend: {spendMoney:f2}");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            double income = 0;

            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match customer = Regex.Match(input, pattern);
                    string name = customer.Groups["name"].Value;
                    string product = customer.Groups["product"].Value;
                    int count = int.Parse(customer.Groups["count"].Value);
                    double price = double.Parse(customer.Groups["price"].Value);
                    double totalPrice = count * price;
                    income += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}

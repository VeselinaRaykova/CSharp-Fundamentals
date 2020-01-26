using System;
using System.Text.RegularExpressions;

namespace _02Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int successfulRegistrationsCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$.*?P@\$(?<password>[A-Za-z]{5,}\d+)P@\$";
                Match match = Regex.Match(input, pattern);

                if (Regex.IsMatch(input, pattern))// && match.Groups["username"])
                {
                    string userName = match.Groups["username"].Value;
                    string password = match.Groups["password"].Value;
                    successfulRegistrationsCount++;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {userName}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}

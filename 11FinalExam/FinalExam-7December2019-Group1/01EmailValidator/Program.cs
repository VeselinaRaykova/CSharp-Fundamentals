using System;
using System.Collections.Generic;
using System.Linq;

namespace _01EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "Complete")
            {
                string command = commandArgs[0];

                if (command == "Make")
                {
                    if (commandArgs[1] == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(commandArgs[1]);
                    string result = email.Substring(email.Length - count, count);
                    Console.WriteLine(result);
                }
                else if (command == "GetUsername")
                {
                    int indexOfAt = email.LastIndexOf('@');

                    if (indexOfAt > 0)
                    {
                        string userName = email.Substring(0, indexOfAt);
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (command == "Replace")
                {
                    char charToReplace = char.Parse(commandArgs[1]);
                    email = email.Replace(charToReplace, '-');
                    Console.WriteLine(email);
                }
                else if (command == "Encrypt")
                {
                    List<int> values = new List<int>();
                    foreach (char c in email)
                    {
                        values.Add(c);
                    }
                    Console.WriteLine(string.Join(" ", values));
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }
        }
    }
}

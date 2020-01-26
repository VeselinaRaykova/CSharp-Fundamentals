using System;
using System.Collections.Generic;
using System.Linq;

namespace _05SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                string command = data[0];
                string userName = data[1];

                if (command == "register")
                {
                    string licenseNumber = data[2];

                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[userName]}");
                    }
                    else
                    {
                        users.Add(userName, licenseNumber);
                        Console.WriteLine($"{userName} registered {licenseNumber} successfully");
                    }
                }
                else
                {
                    if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        users.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var pair in users)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}

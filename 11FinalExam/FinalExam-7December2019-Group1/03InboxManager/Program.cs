using System;
using System.Collections.Generic;
using System.Linq;

namespace _03InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split("->").ToArray();
            Dictionary<string, User> users = new Dictionary<string, User>();

            while (commandArgs[0] != "Statistics")
            {
                string command = commandArgs[0];

                if (command == "Add")
                {
                    string username = commandArgs[1];

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        users.Add(username, new User(username));
                    }
                }
                else if (command == "Send")
                {
                    string userName = commandArgs[1];
                    string email = commandArgs[2];
                    users[userName].Emails.Add(email);
                }
                else if (command == "Delete")
                {
                    string userName = commandArgs[1];
                    if (users.ContainsKey(userName))
                    {
                        users.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }

                commandArgs = Console.ReadLine().Split("->").ToArray();
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (User user in users.Values.OrderByDescending(u => u.Emails.Count).ThenBy(u => u.Name))
            {
                Console.WriteLine(user.Name);
                foreach (string email in user.Emails)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }

    public class User
    {
        public string Name;
        public List<string> Emails;

        public User(string name)
        {
            this.Name = name;
            this.Emails = new List<string>();
        }
    }

}

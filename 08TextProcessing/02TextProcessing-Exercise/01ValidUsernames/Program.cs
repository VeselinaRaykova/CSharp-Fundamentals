using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            //Console.ReadLine().Split(", ").ToArray(); //=>100/100
            List<string> validUsers = new List<string>();

            foreach (string userName in users.Where(u => u.Length >= 3 && u.Length <= 16))
            {
                bool isValid = true;

                foreach (char ch in userName)
                {
                    if (char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
                    {
                        continue;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    validUsers.Add(userName);
                }
            }

            foreach (string user in validUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}

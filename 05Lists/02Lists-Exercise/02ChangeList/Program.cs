using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "end")
            {
                string command = commandArgs[0];

                if (command == "Delete")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.RemoveAll(n => n == number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, number);
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

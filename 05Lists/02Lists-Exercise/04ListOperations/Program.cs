using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "End")
            {
                string command = commandArgs[0];

                if (command == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index < numbers.Count && index >= 0)
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index < numbers.Count && index >= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Shift")
                {
                    string direction = commandArgs[1];
                    int n = int.Parse(commandArgs[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < n; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

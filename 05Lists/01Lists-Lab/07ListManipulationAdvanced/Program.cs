using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();
            bool toPrint = false;

            while (commandArgs[0] != "end")
            {
                string command = commandArgs[0];

                if (command == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);
                    toPrint = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Remove(number);
                    toPrint = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(index);
                    toPrint = true;
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, number);
                    toPrint = true;
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(commandArgs[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = commandArgs[1];
                    int number = int.Parse(commandArgs[2]);
                    List<int> result = new List<int>();

                    switch (condition)
                    {
                        case "<":
                            result = numbers.Where(n => n < number).ToList();
                            break;
                        case ">":
                            result = numbers.Where(n => n > number).ToList();
                            break;
                        case "<=":
                            result = numbers.Where(n => n <= number).ToList();
                            break;
                        case ">=":
                            result = numbers.Where(n => n >= number).ToList();
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(string.Join(" ", result));
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            if (toPrint)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

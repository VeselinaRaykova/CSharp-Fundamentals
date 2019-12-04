using System;
using System.Linq;

namespace _01StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "Done")
            {
                string command = commandArgs[0];

                if (command == "Change")
                {
                    char oldChar = char.Parse(commandArgs[1]);
                    char newChar = char.Parse(commandArgs[2]);
                    input = input.Replace(oldChar, newChar);
                }
                else if (command == "Includes")
                {
                    string text = commandArgs[1];
                    if (input.IndexOf(text) > 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (command == "End")
                {
                    string text = commandArgs[1];
                    if (input.EndsWith(text))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    char ch = char.Parse(commandArgs[1]);
                    Console.WriteLine(input.IndexOf(ch));
                }
                else if (command == "Cut")
                {
                    //TODO

                    int startIndex = int.Parse(commandArgs[1]);
                    int lenght = int.Parse(commandArgs[2]);
                    var result = input.ToArray().Skip(startIndex + 1);
                        result = result.Take(lenght);
                    Console.WriteLine(input);
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponName = Console.ReadLine().Split('|').ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "Done")
            {
                string command = string.Join(" ", commandArgs.Take(2));

                if (command == "Move Left")
                {
                    int index = int.Parse(commandArgs[2]);
                    if (index > 0 && index < weaponName.Count)
                    {
                        string temp = weaponName[index - 1];
                        weaponName[index - 1] = weaponName[index];
                        weaponName[index] = temp;

                        //weaponName.Reverse(index - 1, 2);
                    }
                }
                else if (command == "Move Right")
                {
                    int index = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < weaponName.Count - 1)
                    {
                        string temp = weaponName[index + 1];
                        weaponName[index + 1] = weaponName[index];
                        weaponName[index] = temp;
                        //weaponName.Reverse(index, 2);
                    }
                }
                else if (command == "Check Even")
                {
                    for (int i = 0; i < weaponName.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(weaponName[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "Check Odd")
                {
                    for (int i = 0; i < weaponName.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(weaponName[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"You crafted {string.Join("", weaponName)}!");
        }
    }
}

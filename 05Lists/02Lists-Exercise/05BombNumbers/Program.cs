using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = commandArgs[0];
            int bombPower = commandArgs[1];

            while (numbers.Contains(bomb))
            {
                List<int> temp = new List<int>();
                int bombIndex = numbers.IndexOf(bomb);

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i < bombIndex - bombPower || i > bombIndex + bombPower)
                    {
                        temp.Add(numbers[i]);
                    }
                }
                numbers = temp;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}

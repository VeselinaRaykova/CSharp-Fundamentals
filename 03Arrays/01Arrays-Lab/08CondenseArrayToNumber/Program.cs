﻿using System;
using System.Linq;
namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = numbers;

            while (condensed.Length > 1)
            {
                condensed = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                numbers = condensed;
            }

            Console.WriteLine(condensed[0]);
        }
    }
}

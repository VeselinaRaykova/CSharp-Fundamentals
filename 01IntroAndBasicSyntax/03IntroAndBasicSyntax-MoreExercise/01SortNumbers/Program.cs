using System;
using System.Collections.Generic;

namespace _01SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();
            numbers.Reverse();

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

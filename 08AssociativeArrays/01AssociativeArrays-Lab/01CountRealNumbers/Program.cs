using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> uniqueNumbers = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (uniqueNumbers.ContainsKey(numbers[i]))
                {
                    uniqueNumbers[numbers[i]] += 1;
                }
                else
                {
                    uniqueNumbers.Add(numbers[i], 1);
                }
            }

            foreach (var pair in uniqueNumbers.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

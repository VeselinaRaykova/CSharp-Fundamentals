using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            if (first.Count > second.Count)
            {
                first.RemoveRange(0, second.Count);
                result.AddRange(first);
            }
            else
            {
                second.RemoveRange(0, first.Count);
                result.AddRange(second);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

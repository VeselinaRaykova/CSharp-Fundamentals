using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').ToList();
            List<int> numbers = new List<int>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                List<int> temp = arrays[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                numbers.AddRange(temp);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

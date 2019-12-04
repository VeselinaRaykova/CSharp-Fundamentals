using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTop;

            for (int i = 0; i < array.Length; i++)
            {
                isTop = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int leftIndex = 0; leftIndex < i; leftIndex++)
                {
                    leftSum += numbers[leftIndex];
                }

                for (int rightIndex = i + 1; rightIndex < numbers.Length; rightIndex++)
                {
                    rightSum += numbers[rightIndex];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}

using System;
using System.Linq;

namespace _07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSequence = 1;
            int currSequence = 1;
            int maxNum = int.MinValue;
            int currNum = int.MinValue;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currSequence++;
                    currNum = numbers[i];
                    if (currSequence > maxSequence)
                    {
                        maxSequence = currSequence;
                        maxNum = currNum;
                    }
                }
                else
                {
                    currSequence = 1;
                }
            }

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write($"{maxNum} ");
            }
        }
    }
}

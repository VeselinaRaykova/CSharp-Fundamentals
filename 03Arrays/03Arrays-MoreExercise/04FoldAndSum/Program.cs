using System;
using System.Linq;

namespace _04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] foldedNumbers = new int[numbers.Length / 2];
            int k = foldedNumbers.Length / 2;

            for (int i = 0; i < k; i++) 
            {
                foldedNumbers[i] = numbers[i + k] + numbers[k - 1 - i];
            }

            for (int i = k; i < 2 * k; i++) 
            {
                foldedNumbers[i] = numbers[i + k] + numbers[4 * k - i + k - 1];
            }

            Console.WriteLine(string.Join(" ", foldedNumbers));
        }
    }
}

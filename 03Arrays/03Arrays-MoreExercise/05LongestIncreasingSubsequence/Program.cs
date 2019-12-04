using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbers.Length;
            int[] lenght = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                lenght[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        lenght[i] += 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {

            }
        }
    }
}

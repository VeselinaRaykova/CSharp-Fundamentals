using System;
using System.Linq;

namespace _02CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ").ToArray();
            GetMultipliedCode(data[0], data[1]);
        }

        private static void GetMultipliedCode(string str1, string str2)
        {
            int result = 0;
            int n = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < n; i++)
            {
                int a = i < str1.Length ? str1[i] : 1;
                int b = i < str2.Length ? str2[i] : 1;

                result += a * b;
            }

            Console.WriteLine(result);
        }
    }
}

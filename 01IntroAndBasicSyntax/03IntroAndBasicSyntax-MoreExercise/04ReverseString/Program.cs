using System;
using System.Linq;

namespace _04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            //V2
            //char[] input = Console.ReadLine().ToArray();
            //Array.Reverse(input);
            //string result = new string(input);
            //Console.WriteLine(result);
        }
    }
}

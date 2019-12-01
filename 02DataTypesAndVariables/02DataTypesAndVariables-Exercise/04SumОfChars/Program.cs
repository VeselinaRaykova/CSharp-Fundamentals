using System;

namespace _04SumОfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int code = (int)letter;
                sum += code;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

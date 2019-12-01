using System;

namespace _09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (IsPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string number)
        {
            string reversed = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }

            if (number == reversed)
            {
                return true;
            }

            return false;
        }
    }
}

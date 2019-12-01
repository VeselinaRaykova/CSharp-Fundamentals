using System;

namespace _04PasswordValidator
{
    class Program
    {
        public static int digitsCount = 0;

        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            GetIsValid(password);
        }

        private static void GetIsValid(string password)
        {
            bool isLenghtValid = GetIsLenghtValid(password);
            bool areCharsValid = GetAreCharsValid(password);
            bool areDigitsEnough = digitsCount >= 2 ? true : false;

            if (isLenghtValid && areCharsValid && areDigitsEnough)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!isLenghtValid)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!areCharsValid)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!areDigitsEnough)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool GetAreCharsValid(string password)
        {
            foreach (char ch in password)
            {
                if ((ch > 64 && ch < 91) || (ch > 96 && ch < 123))
                {
                    continue;
                }
                else if (ch > 47 && ch < 58)
                {
                    digitsCount++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static bool GetIsLenghtValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}

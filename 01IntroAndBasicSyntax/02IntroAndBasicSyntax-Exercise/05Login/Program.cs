using System;

namespace _05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string enteredPass = Console.ReadLine();
            char[] passArr = username.ToCharArray();
            Array.Reverse(passArr);
            string correctPass = new string(passArr);
            int counter = 1;

            while (enteredPass != correctPass && counter < 4)
            {
                counter += 1;
                Console.WriteLine($"Incorrect password. Try again.");
                enteredPass = Console.ReadLine();
            }

            if (enteredPass == correctPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }

        }
    }
}

using System;

namespace _05DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decryptedMessage = "";

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int decryptedCode = (int)ch + key;
                decryptedMessage += (char)decryptedCode;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}

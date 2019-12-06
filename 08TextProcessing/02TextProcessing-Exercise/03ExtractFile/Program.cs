using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string fullName = path.Substring(path.LastIndexOf('\\') + 1);
            string name = fullName.Substring(0, fullName.LastIndexOf('.'));
            string ext = path.Substring(path.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}

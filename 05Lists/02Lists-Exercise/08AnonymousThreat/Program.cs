using System;
using System.Collections.Generic;
using System.Linq;

namespace _08AnonymousThreat
{
    class Program
    {
        public static List<string> data = new List<string>();

        static void Main(string[] args)
        {
            data = Console.ReadLine().Split().ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "3:1")
            {
                string command = commandArgs[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    Merge(startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandArgs[1]);
                    int parts = int.Parse(commandArgs[2]);
                    Divide(index, parts);
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static void Divide(int index, int parts)
        {
            List<string> result = new List<string>();
            string word = data[index];
            int partLenght = word.Length / parts;
            string currentWord = "";

            for (int i = 0; i < parts; i++)
            {
                if (i == parts - 1)
                {
                    currentWord = word.Substring(i * partLenght);
                }
                else
                {
                    currentWord = word.Substring(i * partLenght, partLenght);
                }

                result.Add(currentWord);
            }

            data.RemoveAt(index);
            data.InsertRange(index, result);
        }

        private static void Merge(int startIndex, int endIndex)
        {
            string result = "";
            startIndex = NormalizeIndex(startIndex);
            endIndex = NormalizeIndex(endIndex);

            for (int i = startIndex; i <= endIndex; i++)
            {
                result += data[i];
            }
            data.RemoveRange(startIndex, endIndex - startIndex + 1);
            data.Insert(startIndex, result);
        }

        private static int NormalizeIndex(int index)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index > data.Count - 1)
            {
                index = data.Count - 1;
            }

            return index;
        }
    }
}

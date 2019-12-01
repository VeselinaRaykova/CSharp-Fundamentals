using System;

namespace _01DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int intResult;
            double doubleResult;
            bool boolResult;
            char charResult;
            string type = "";

            while (input!="END")
            {
                if (int.TryParse(input,out intResult))
                {
                    type = "integer";
                }
                else if (double.TryParse(input, out doubleResult))
                {
                    type = "floating point";
                }
                else if (char.TryParse(input, out charResult))
                {
                    type = "character";
                }
                else if (bool.TryParse(input, out boolResult))
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }

                Console.WriteLine($"{input} is {type} type");

                input = Console.ReadLine();
            }
        }
    }
}

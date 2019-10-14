using System;

namespace _06BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch;
            int openingBrackets = 0;
            int closingBrackets = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (char.TryParse(input, out ch))
                {
                    if (ch == '(')
                    {
                        openingBrackets++;
                    }
                    else if (ch == ')')
                    {
                        closingBrackets++;
                        if (closingBrackets > openingBrackets)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                }
            }

            if (openingBrackets == closingBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}

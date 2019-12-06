using System;

namespace _07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symb = text[i];

                if (symb == '>')
                {
                    bomb += int.Parse(text[i + 1].ToString());
                }
                else if (symb != '>' && bomb > 0)
                {
                    text = text.Remove(i, 1);
                    bomb--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}

using System;

namespace _10LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());
            int code = (int)c;

            //ASCI codes: a=97, z=122, A=65, Z=90
            if (code >= 97 && code <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else //if (code >= 67 && code <= 90)
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}

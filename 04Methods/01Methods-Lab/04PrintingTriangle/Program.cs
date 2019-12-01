using System;

namespace _04PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                PrintLine(1, rows);
            }
            for (int rows = n - 1; rows >= 0; rows--)
            {
                PrintLine(1, rows);
            }
        }

        private static void PrintLine(int start, int end)
        {

            for (int cols = 1; cols <= end; cols++)
            {
                Console.Write(cols + " ");
            }

            Console.WriteLine();
        }
    }
}

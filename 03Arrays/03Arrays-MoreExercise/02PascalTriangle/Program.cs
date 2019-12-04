using System;

namespace _02PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] formerArr = new int[n];


            for (int rows = 1; rows <= n; rows++)
            {
                int[] currentArr = new int[n];
                currentArr[0] = 1;

                for (int cols = 0; cols < rows; cols++)
                {
                    if (cols == 0 || cols == rows - 1)
                    {
                        currentArr[cols] = 1;
                    }
                    else
                    {
                        currentArr[cols] = formerArr[cols] + formerArr[cols - 1];
                    }
                    Console.Write(currentArr[cols] + " ");
                }

                Console.WriteLine();
                formerArr = currentArr;
            }
        }
    }
}

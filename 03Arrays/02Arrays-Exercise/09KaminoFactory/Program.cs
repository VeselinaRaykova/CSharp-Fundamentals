using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////TODO
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] bestDna = new int[n];
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int bestCount = 1;
            int currSequenceIndex = 0;
            int currSequenceSum = 0;
            int currCount = 1;
            int bestSamplesCount = 0;
            int bestSampleNumber = 0;

            while (input != "Clone them!")
            {
                int[] sampleDna = input.Split('!').Select(int.Parse).ToArray();

                for (int i = 0; i < sampleDna.Length - 1; i++)
                {
                    if (sampleDna[i] == 1 && sampleDna[i] == sampleDna[i + 1])
                    {
                        currCount++;
                        currSequenceIndex = i + 1 - (currCount - 1);
                        currSequenceSum = sampleDna.Sum();



                        if ((currCount > bestCount) ||
                            (currCount == bestCount && currSequenceIndex < bestSequenceIndex) ||
                            (currCount == bestCount && currSequenceIndex >= bestSequenceIndex && currSequenceSum > bestSequenceSum)
                            )
                        {
                            if (sampleDna != bestDna)
                            {
                                bestSamplesCount++;
                            }
                            bestDna = sampleDna;
                            bestCount = currCount;
                            bestSequenceIndex = currSequenceIndex;
                            bestSequenceSum = currSequenceSum;
                            bestSampleNumber = bestSamplesCount;
                        }
                    }
                    else
                    {
                        currCount = 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSamplesCount} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}

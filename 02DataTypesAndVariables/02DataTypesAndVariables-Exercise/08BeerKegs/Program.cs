using System;

namespace _08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = int.MinValue;
            string maxKegModel = "";

            for (int i = 0; i < n; i++)
            {
                string currKegModel = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double currVolume = Math.PI * r * r * h;
                if (currVolume > maxVolume)
                {
                    maxVolume = currVolume;
                    maxKegModel = currKegModel;
                }
            }

            Console.WriteLine(maxKegModel);
        }
    }
}

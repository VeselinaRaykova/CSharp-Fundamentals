using System;

namespace _06ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "unknown";

            if (country == "England" || country == "USA")
            {
                language = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                language = "Spanish";
            }

            Console.WriteLine(language);
        }
    }
}

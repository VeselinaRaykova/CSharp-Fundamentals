using System;
using System.Globalization;

namespace _01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(parsedDate.DayOfWeek);
        }
    }
}

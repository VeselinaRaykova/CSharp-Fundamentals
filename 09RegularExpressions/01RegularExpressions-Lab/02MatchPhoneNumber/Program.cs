﻿using System;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchedPhones = regex.Matches(text);

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _0BasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<(?<tag>\w+)[^>]*>.*?<\/\1>";
            Regex regex = new Regex(pattern);
            var text = @"<b>Regular Expressions</b> are cool!" +
                        "<p>I am a paragraph</p> … some text after" +
                        "Hello, <div>I am a<code>DIV</code></div>!" +
                        "<span>Hello, I am Span</span>" +
                        "<a href='https://softuni.bg/'>SoftUni</a>" +
                        "< div <";
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                //match.
                Console.WriteLine(match);
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Groups[1].Value); //returns the content of the first group
                Console.WriteLine(match.Groups["tag"].Value); //returns the content of the group with name "tag"  
            }

            /////////////////////////////////
            text = "Nakov: 123, Branson: 456";
            pattern = @"\d{3}";
            string replacement = "999";

            regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
            // Nakov: 999, Branson: 999

            ////////////////////////////////
            text = "1   2 3      4";
            pattern = @"\s+";

            string[] results = Regex.Split(text, pattern);
            Console.WriteLine(string.Join(", ", results));
            // 1, 2, 3, 4

        }
    }
}

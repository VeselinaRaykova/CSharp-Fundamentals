using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string[] data = Console.ReadLine().Split(':').Select(x => x.Trim()).ToArray();
            while (data[0] != "end")
            {
                string courseName = data[0];
                string studentName = data[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                if (!courses[courseName].Contains(studentName))
                {
                    courses[courseName].Add(studentName);
                }

                data = Console.ReadLine().Split(':').Select(x => x.Trim()).ToArray();
            }

            foreach (var course in courses.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (string student in course.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}

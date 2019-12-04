using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            foreach (Student s in students.OrderByDescending(s=>s.Grade))
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}: {s.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;
        public double Grade;

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "end")
            {
                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string homeTown = commandArgs[3];
                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            string city = Console.ReadLine();

            foreach (Student s in students.Where(s => s.HomeTown == city))
            {
                Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.");
            }
        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string HomeTown;

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
    }
}

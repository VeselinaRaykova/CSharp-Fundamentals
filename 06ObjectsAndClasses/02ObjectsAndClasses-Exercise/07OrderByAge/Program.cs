using System;
using System.Collections.Generic;
using System.Linq;

namespace _07OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            List<Person> people = new List<Person>();

            while (data[0] != "End")
            {
                string name = data[0];
                string ID = data[1];
                int age = int.Parse(data[2]);

                Person person = new Person(name, ID, age);
                people.Add(person);

                data = Console.ReadLine().Split().ToArray();
            }

            foreach (Person p in people.OrderBy(p=>p.Age))
            {
                Console.WriteLine($"{p.Name} with ID: {p.ID} is {p.Age} years old.");
            }
        }

        public class Person {
            public string Name;
            public string ID;
            public int Age;

            public Person(string name, string iD, int age)
            {
                this.Name = name;
                this.ID = iD;
                this.Age = age;
            }
        }
    }
}

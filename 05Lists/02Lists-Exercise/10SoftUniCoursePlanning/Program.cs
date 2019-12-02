using System;
using System.Collections.Generic;
using System.Linq;

namespace _10SoftUniCoursePlanning
{
    class Program
    {
        public static List<string> lessons = new List<string>();

        static void Main(string[] args)
        {
            lessons = Console.ReadLine().Split(new char[] { ',' }).Select(x => x.Trim()).ToList();
            string[] commandArgs = Console.ReadLine().Split(':').ToArray();

            while (commandArgs[0] != "course start")
            {
                string command = commandArgs[0];

                if (command == "Add")
                {
                    string lessonTitle = commandArgs[1];
                    AddLesson(lessonTitle);
                }
                else if (command == "Insert")
                {
                    string lessonTitle = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    InsertLesson(index, lessonTitle);
                }
                else if (command == "Remove")
                {
                    string lessonTitle = commandArgs[1];
                    RemoveLesson(lessonTitle);
                }
                else if (command == "Swap")
                {
                    string firstTitle = commandArgs[1];
                    string secondTitle = commandArgs[2];
                    SwapLessons(firstTitle, secondTitle);
                }
                else if (command == "Exercise")
                {
                    string lessonTitle = commandArgs[1];
                    AddExercise(lessonTitle);
                }

                commandArgs = Console.ReadLine().Split(':').ToArray();
            }

            PrintLessons();
        }

        private static void PrintLessons()
        {
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        private static void AddExercise(string lessonTitle)
        {
            int lessonIndex = lessons.IndexOf(lessonTitle);
            string exercise = $"{lessonTitle}-Exercise";

            if (lessonIndex < 0)
            {
                lessons.Add(lessonTitle);
                lessons.Add(exercise);
            }
            else if (lessonIndex == lessons.Count - 1)
            {
                lessons.Add(exercise);
            }
            else if (lessonIndex >= 0 && !lessons[lessonIndex + 1].Contains("Exercise"))
            {
                lessons.Insert(lessonIndex + 1, exercise);
            }
        }

        private static void SwapLessons(string firstTitle, string secondTitle)
        {
            int firstIndex = lessons.IndexOf(firstTitle);
            int secondIndex = lessons.IndexOf(secondTitle);
            string firstExersice = $"{firstTitle}-Exercise";
            string secondExercise = $"{secondTitle}-Exercise";

            if (firstIndex < 0 || secondIndex < 0)
            {
                return;
            }

            lessons[firstIndex] = secondTitle;
            lessons[secondIndex] = firstTitle;

            if (lessons.Contains(firstExersice))
            {
                lessons.Remove(firstExersice);
                lessons.Insert(secondIndex + 1, firstExersice);
            }
            if (lessons.Contains(secondExercise))
            {
                lessons.Remove(secondExercise);
                lessons.Insert(firstIndex + 1, secondExercise);
            }
        }

        private static void RemoveLesson(string lessonTitle)
        {
            string exercise = lessonTitle + "-Exercise";
            if (lessons.Contains(lessonTitle))
            {
                lessons.Remove(lessonTitle);
                if (lessons.Contains(exercise))
                {
                    lessons.Remove(exercise);
                }
            }
        }

        private static void InsertLesson(int index, string lessonTitle)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Insert(index, lessonTitle);
            }
        }

        private static void AddLesson(string lessonTitle)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
            }
        }
    }
}

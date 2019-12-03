using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split('_').ToArray();
                string typeList = commandArgs[0];
                string name = commandArgs[1];
                string time = commandArgs[2];
                Song newSong = new Song(typeList, name, time);
                songs.Add(newSong);
            }

            string typeToPrint = Console.ReadLine();

            if (typeToPrint == "all")
            {
                foreach (Song s in songs)
                {
                    Console.WriteLine(s.Name);
                }
            }
            else
            {
                foreach (Song s in songs.Where(s => s.TypeList == typeToPrint))
                {
                    Console.WriteLine(s.Name);
                }
            }
        }
    }

    public class Song
    {
        public string TypeList;
        public string Name;
        public string Time;

        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
    }
}

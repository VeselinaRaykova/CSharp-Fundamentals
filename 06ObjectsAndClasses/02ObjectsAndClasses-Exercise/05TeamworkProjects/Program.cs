using System;
using System.Collections.Generic;
using System.Linq;

namespace _05TeamworkProjects
{
    class Program
    {
        public static List<Team> teams = new List<Team>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CreateTeams(n);
            PopulateMembers();
            PrintTeamMembers();
        }

        private static void CreateTeams(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('-').ToArray();
                string creator = data[0];
                string teamName = data[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(creator, teamName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        private static void PopulateMembers()
        {
            string[] data = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (data[0] != "end of assignment")
            {
                string userName = data[0];
                string teamName = data[1];

                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.Creator == userName) || teams.Any(x => x.Members.Contains(userName)))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    //Team teamToJoin = teams.Where(t => t.Name == teamName).First();
                    Team teamToJoin = teams.First(t => t.Name == teamName);
                    teamToJoin.Members.Add(userName);
                }

                data = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }

        private static void PrintTeamMembers()
        {
            List<Team> orderedTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            List<Team> emptyTeams = teams
                .Where(t => t.Members.Count <= 0)
                .OrderBy(t => t.Name)
                .ToList();

            PrintTeams(orderedTeams);
            PrintTeamsToDisband(emptyTeams);
        }

        private static void PrintTeams(List<Team> orderedTeams)
        {
            foreach (Team team in orderedTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                team.Members.Sort();
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        private static void PrintTeamsToDisband(List<Team> emptyTeams)
        {
            Console.WriteLine($"Teams to disband:");
            foreach (Team team in emptyTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public string Name;
        public string Creator;
        public List<string> Members;

        public Team(string creator, string teamName)
        {
            this.Members = new List<string>();
            this.Creator = creator;
            this.Name = teamName;
        }
    }
}

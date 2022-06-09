using _05.FootballTeamGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string[] commandArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "END")
                {
                    break;
                }

                string command = commandArgs[0];

                try
                {
                    if (command == "Team")
                    {
                        string teamName = commandArgs[1];

                        Team team = new Team(teamName);

                        if (!teams.Contains(team))
                        {
                            teams.Add(team);
                        }
                    }
                    else if (command == "Add")
                    {
                        string teamName = commandArgs[1];
                        string playerName = commandArgs[2];

                        Player player = new Player(playerName, int.Parse(commandArgs[3]), int.Parse(commandArgs[4]), int.Parse(commandArgs[5]), int.Parse(commandArgs[6]), int.Parse(commandArgs[7]));

                        Team team = teams.First(x => x.Name == teamName);

                        if (team != null)
                        {
                            team.AddPlayer(player);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (command == "Remove")
                    {
                        string teamName = commandArgs[1];
                        string playerName = commandArgs[2];

                        Team team = teams.First(x => x.Name == teamName);

                        if (team != null)
                        {
                            team.RemovePlayer(playerName);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (command == "Rating")
                    {
                        string teamName = commandArgs[1];

                        Team team = teams.First(x => x.Name == teamName);

                        if (team != null)
                        {
                            Console.WriteLine($"{team.Name} - {team.Rating}");
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

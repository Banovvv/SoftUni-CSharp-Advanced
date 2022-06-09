using _05.FootballTeamGenerator.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator.Model
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (!Validator.ValidateName(value))
                {
                    Console.WriteLine("A name should not be empty.");
                }

                name = value;
            }
        }

        public int Rating => CalculateRating();

        public void AddPlayer(Player player)
        {
            if (!players.Contains(player))
            {
                players.Add(player);
            }
        }

        public Player RemovePlayer(string playerName)
        {
            Player player = players.First(x => x.Name == playerName);

            if (player == null)
            {
                Console.WriteLine($"Player {player.Name} is not in {this.Name} team.");
            }

            players.Remove(player);

            return player;
        }

        private int CalculateRating() => (int)players.Average(x => x.Rating);
    }
}

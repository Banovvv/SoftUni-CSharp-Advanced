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
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (!Validator.ValidateName(value))
                {
                    throw new ArgumentException("A name should not be empty.");
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
            Player player = players.FirstOrDefault(x => x.Name == playerName);

            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            else
            {
                players.Remove(player);
            }

            return player;
        }

        private int CalculateRating() => players.Count != 0 ? (int)Math.Round(players.Average(x => x.Rating)) : 0;
    }
}

using _05.FootballTeamGenerator.Validators;
using System;

namespace _05.FootballTeamGenerator.Model
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private readonly int minStatValue = 0;
        private readonly int maxStatValue = 100;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public double Rating => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0f;
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
        public int Endurance
        {
            get => endurance;
            private set
            {
                if (!Validator.ValidateStat(value, minStatValue, maxStatValue))
                {
                    Console.WriteLine($"{nameof(this.Endurance)} should be between 0 and 100.");
                }

                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                if (!Validator.ValidateStat(value, minStatValue, maxStatValue))
                {
                    Console.WriteLine($"{nameof(this.Sprint)} should be between 0 and 100.");
                }

                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                if (!Validator.ValidateStat(value, minStatValue, maxStatValue))
                {
                    Console.WriteLine($"{nameof(this.Dribble)} should be between 0 and 100.");
                }

                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                if (!Validator.ValidateStat(value, minStatValue, maxStatValue))
                {
                    Console.WriteLine($"{nameof(this.Passing)} should be between 0 and 100.");
                }

                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                if (!Validator.ValidateStat(value, minStatValue, maxStatValue))
                {
                    Console.WriteLine($"{nameof(this.Shooting)} should be between 0 and 100.");
                }

                shooting = value;
            }
        }
    }
}

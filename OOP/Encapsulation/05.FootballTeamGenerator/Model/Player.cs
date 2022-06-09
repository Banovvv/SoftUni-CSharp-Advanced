using _05.FootballTeamGenerator.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator.Model
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;

        public Player()
        {

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

        public int Endurance
        {
            get => endurance;
            private set
            {
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                sprint = value;
            }
        }
    }
}

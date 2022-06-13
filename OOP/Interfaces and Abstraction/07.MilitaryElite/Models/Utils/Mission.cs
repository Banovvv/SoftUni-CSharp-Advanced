using _07.MilitaryElite.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MilitaryElite.Models.Utils
{
    public class Mission
    {
        private string state;
        private IReadOnlyCollection<string> validStates = new string[] { "inProgress", "Finished" };

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; private set; }
        public string State
        {
            get => state;
            private set
            {
                if (!validStates.Contains(value))
                {
                    throw new InvalidMissionStateException();
                }
                state = value;
            }
        }

        public void Complete()
        {
            State = "Finished";
        }

        public override string ToString() => $"Code Name: {CodeName} State: {State}";
    }
}

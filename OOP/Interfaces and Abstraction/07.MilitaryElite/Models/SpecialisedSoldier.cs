using _07.MilitaryElite.Exceptions;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected string corps;
        protected IReadOnlyCollection<string> corpsTypes = new string[] { "Airforces", "Marines" };

        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public string Corps
        {
            get => corps;
            private set
            {
                if (!corpsTypes.Contains(value))
                {
                    throw new InvalidCorpsException();
                }

                corps = value;
            }
        }
    }
}

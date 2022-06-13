using _07.MilitaryElite.Interfaces;
using _07.MilitaryElite.Models.Utils;
using System.Collections.Generic;

namespace _07.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, IEnumerable<Repair> repairs) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<Repair>(repairs);
        }

        public IReadOnlyCollection<Repair> Repairs { get; private set; }
    }
}

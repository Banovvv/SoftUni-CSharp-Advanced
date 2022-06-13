using _07.MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, IEnumerable<Soldier> privates) : base(id, firstName, lastName, salary)
        {
            Privates = new List<Soldier>(privates);
        }

        public IReadOnlyCollection<Soldier> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");

            foreach (Private @private in Privates)
            {
                sb.AppendLine($"  {@private}");
            }

            return sb.ToString().Trim();
        }
    }
}

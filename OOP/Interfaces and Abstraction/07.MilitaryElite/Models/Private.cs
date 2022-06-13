using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";
    }
}

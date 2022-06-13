using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, IEnumerable<Private> privates) : base(id, firstName, lastName, salary)
        {
            Privates = new List<Private>(privates);
        }

        public IReadOnlyCollection<Private> Privates {get; private set;}
    }
}

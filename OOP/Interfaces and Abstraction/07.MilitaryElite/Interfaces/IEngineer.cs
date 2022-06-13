using _07.MilitaryElite.Models.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}

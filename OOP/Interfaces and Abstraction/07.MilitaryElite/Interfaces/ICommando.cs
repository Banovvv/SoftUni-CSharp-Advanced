using _07.MilitaryElite.Models.Utils;
using System.Collections.Generic;

namespace _07.MilitaryElite.Interfaces
{
    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }
        void CompleteMission(string mission);
    }
}

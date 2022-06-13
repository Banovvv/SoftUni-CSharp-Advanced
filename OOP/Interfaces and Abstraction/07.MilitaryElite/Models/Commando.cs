using _07.MilitaryElite.Interfaces;
using _07.MilitaryElite.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, IEnumerable<Mission> misions) : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<Mission>(misions);
        }

        public IReadOnlyCollection<Mission> Missions { get; private set; }

        public void CompleteMission(string mission)
        {
            var missionToComplete = Missions.FirstOrDefault(x => x.CodeName == mission);

            if(missionToComplete != null)
            {
                missionToComplete.Complete();
            }
        }
    }
}

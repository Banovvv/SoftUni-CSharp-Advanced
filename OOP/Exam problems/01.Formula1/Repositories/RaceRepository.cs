using Formula1.Models.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Formula1.Repositories
{
    public class RaceRepository
    {
        private readonly ICollection<IRace> models;

        public ICollection<IRace> Models => models;

        public void Add(IRace race)
        {
            models.Add(race);
        }

        public bool Remove(IRace race)
        {
            return models.Remove(race);
        }

        public IRace FindByName(string raceName)
        {
            return models.Where(x => x.RaceName == raceName).FirstOrDefault();
        }
    }
}

using Formula1.Models.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Formula1.Repositories
{
    public class PilotRepository
    {
        private readonly ICollection<IPilot> models;

        public PilotRepository()
        {
            models = new List<IPilot>();
        }

        public ICollection<IPilot> Models => models;

        public void Add(IPilot pilot)
        {
            models.Add(pilot);
        }

        public bool Remove(IPilot pilot)
        {
            return models.Remove(pilot);
        }

        public IPilot FindByName(string fullName)
        {
            return models.Where(x => x.FullName == fullName).FirstOrDefault();
        }
    }
}

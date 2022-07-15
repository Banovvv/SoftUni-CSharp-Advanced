using Formula1.Models.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository
    {
        private readonly ICollection<IFormulaOneCar> models;

        public ICollection<IFormulaOneCar> Models => models;

        public void Add(IFormulaOneCar car)
        {
            models.Add(car);
        }

        public bool Remove(IFormulaOneCar car)
        {
            return models.Remove(car);
        }

        public IFormulaOneCar FindByName(string model)
        {
            return models.Where(x => x.Model == model).FirstOrDefault();
        }
    }
}

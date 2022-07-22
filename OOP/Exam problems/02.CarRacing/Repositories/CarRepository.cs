using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> models;

        public CarRepository()
        {
            models = new List<ICar>();
        }

        public IReadOnlyCollection<ICar> Models => models.AsReadOnly();

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Car Repository");
            }

            models.Add(model);
        }

        public ICar FindBy(string property) => models.Where(x => x.VIN == property).FirstOrDefault();

        public bool Remove(ICar model)
        {
            return models.Remove(model);
        }
    }
}

using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private ICollection<ICar> models;
        public CarRepository()
        {
            models = new List<ICar>();
        }

        public ICollection<ICar> Models => (ICollection<ICar>)models;

        public void Add(ICar model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return Models.ToList().AsReadOnly();
        }

        public ICar GetByName(string name)
        {
            return models.FirstOrDefault(m => m.Model == name);
        }

        public bool Remove(ICar model)
        {
            return models.Remove(model);
        }
    }
}

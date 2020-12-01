using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly IList<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => (IReadOnlyCollection<IGun>)models;

        public void Add(IGun model)
        {
            if (model is null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }

            models.Add(model);
        }
        
        public IGun FindByName(string name)
        => models.FirstOrDefault(m => m.Name == name);

        public bool Remove(IGun model)
        => models.Remove(model);
    }
}

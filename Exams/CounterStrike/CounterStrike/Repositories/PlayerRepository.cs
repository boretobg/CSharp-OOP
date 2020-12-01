using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private readonly IList<IPlayer> models;

        public PlayerRepository()
        {
            this.models = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models => (IReadOnlyCollection<IPlayer>)models;

        public void Add(IPlayer model)
        {
            if (model is null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }

            models.Add(model);
        }

        public IPlayer FindByName(string name)
        => models.FirstOrDefault(m => m.Username == name);

        public bool Remove(IPlayer model)
        => models.Remove(model);
    }
}

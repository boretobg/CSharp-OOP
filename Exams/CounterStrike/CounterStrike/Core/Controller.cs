using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private IRepository<IGun> guns;
        private IRepository<IPlayer> players;
        private IMap map;

        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            Gun gun = null;
            switch (type)
            {
                case "Pistol":
                    gun = new Pistol(name, bulletsCount);
                    break;
                case "Rifle":
                    gun = new Rifle(name, bulletsCount);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

            guns.Add(gun);
            return $"Successfully added gun {gun.Name}.";
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            Player player = null;

            var gun = guns.Models.FirstOrDefault(g => g.Name == gunName);
            if (gun is null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }

            switch (type)
            {
                case "Terrorist":
                   player = new Terrorist(username, health, armor, gun);
                    break;
                case "CounterTerrorist":
                   player = new CounterTerrorist(username, health, armor, gun);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }

            players.Add(player);
            return $"Successfully added player {player.Username}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            var ordered = players.Models
                .OrderBy(p => p.GetType().Name)
                .ThenByDescending(p => p.Health)
                .ThenBy(p => p.Username);

            foreach (var player in ordered)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }

        public string StartGame()
        {
            ICollection<IPlayer> alive = players.Models.Where(p => p.IsAlive).ToList();
            return map.Start(alive);
        }
    }
}

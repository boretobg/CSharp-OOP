using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            var terrorists = new List<IPlayer>();
            var counterTerrorists = new List<IPlayer>();

            foreach (var player in players)
            {
                if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
                else
                {
                    counterTerrorists.Add(player);
                }
            }

            while (true)
            {
                foreach (var terrorist in terrorists)
                {
                    if (terrorist.IsAlive)
                    {
                        foreach (var counterTerrorist in counterTerrorists)
                        {
                            counterTerrorist.TakeDamage(terrorist.Gun.Fire());
                        }
                    }
                }

                foreach (var counterTerrorist in counterTerrorists)
                {
                    if (counterTerrorist.IsAlive)
                    {
                        foreach (var terrorist in terrorists)
                        {
                            counterTerrorist.TakeDamage(counterTerrorist.Gun.Fire());
                        }
                    }
                }

                if (terrorists.Any(t => t.IsAlive))
                {
                    return "Terrorist wins!";
                }
                else
                {
                    return "Counter Terrorist wins!";
                }
            }
        }
    }
}

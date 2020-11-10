using Raiding.Contracts;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        public Paladin(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }
        public override int Power { get; set; } = 100;
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}

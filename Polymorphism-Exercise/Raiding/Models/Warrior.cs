using Raiding.Contracts;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }
        public override int Power { get; set; } = 100;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}

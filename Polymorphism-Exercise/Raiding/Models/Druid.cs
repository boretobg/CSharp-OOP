using Raiding.Contracts;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }
        public override int Power { get; set; } = 80;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Mouse : Mammal, ISoundable
    {
        public override string[] Eats { get; set; } = new string[] { "Vegetable", "Fruit"};
        public Mouse(string name, double weight, string livingRegion) : base(livingRegion)
        {
            Name = name;
            Weight = weight;
        }

        public override string LivingRegion { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }
        public override double WeightGainer { get; set; } = 0.10;
        public override string Sound { get; set; } = "Squeak";

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

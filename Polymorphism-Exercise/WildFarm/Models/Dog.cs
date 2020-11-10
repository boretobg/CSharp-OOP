using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Dog : Mammal, ISoundable
    {
        public override string[] Eats { get; set; } = new string[] { "Meat" };
        public override string LivingRegion { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }
        public override string Sound { get; set; } = "Woof!";
        public override double WeightGainer { get; set; } = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(livingRegion)
        {
            Name = name;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

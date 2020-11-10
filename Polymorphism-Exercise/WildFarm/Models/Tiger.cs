using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Tiger : Feline, ISoundable
    {
        
        public override string Breed { get; set; }
        public override string LivingRegion { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }
        public override string Sound { get; set; } = "ROAR!!!";
        public override string[] Eats { get; set; } = new string[] { "Meat" };
        public override double WeightGainer { get; set; } = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(livingRegion)
        {
            Breed = breed;
            Name = name;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, { Breed}, {Weight}, {LivingRegion}, { FoodEaten}]";
        }
    }
}

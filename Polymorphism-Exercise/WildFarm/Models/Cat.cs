using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Cat : Feline, ISoundable
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(livingRegion)
        {
            Breed = breed;
            Name = name;
            Weight = weight;
        }

        public override string[] Eats { get; set; } = new string[] { "Vegetable", "Meat" };
        public override string Breed { get; set; }
        public override string LivingRegion { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }
        public override double WeightGainer { get; set; } = 0.30;

        public override string Sound { get; set; } = "Meow";

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, { Breed}, {Weight}, {LivingRegion}, { FoodEaten}]";
        }
    }
}

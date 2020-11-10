using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Owl : Bird, ISoundable
    {
        public override string[] Eats { get; set; } = new string[] { "Meat" };
        public override double WingSize { get; set ; }
        public override string Name { get; set ; }
        public override double Weight { get ; set; }
        public override int FoodEaten { get; set ; }
        public override double WeightGainer { get; set; } = 0.25;

        public override string Sound { get; set; } = "Hoot Hoot";

        public Owl(string name, double weight, double wingSize) : base (wingSize)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}

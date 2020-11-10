using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Hen : Bird, ISoundable
    {

        public Hen(string name, double weight, double wingSize) 
            : base (wingSize)
        {
            WingSize = wingSize;
            Name = name;
            Weight = weight;
        }

        public override string[] Eats { get; set; } = new string[] { "Vegetable", "Fruit", "Meat", "Seeds" };
        public override double WingSize { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }
        public override double WeightGainer { get; set; } = 0.35;
        public override string Sound { get; set; } = "Cluck";

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}

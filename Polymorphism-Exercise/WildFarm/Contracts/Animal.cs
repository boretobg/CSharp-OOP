using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace WildFarm.Contracts
{
    public abstract class Animal
    {
        public abstract string[] Eats { get; set; }
        public abstract string Name { get; set; }
        public abstract double Weight { get; set; }
        public abstract int FoodEaten { get; set; }
        public abstract string Sound { get; set; }
        public abstract double WeightGainer { get; set; }
    }
}

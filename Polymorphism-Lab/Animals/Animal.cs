using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favoriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my fovourite food is {this.favoriteFood}";
        }
    }
}

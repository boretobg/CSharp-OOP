using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake : Dessert
    {
        public Cake(string name, decimal price, double grams, double calories) : base(name, price, grams, calories)
        {
            this.Grams = 250;
            this.Price = 5;
            this.Calories = 1000;
        }
    }
}

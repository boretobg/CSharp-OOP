using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Coffee : HotBeverage
    {
        public double CoffeeMilliliters { get; set; }
        public decimal CoffeePrice { get; set; }
        public double Caffeine { get; set; }
        public Coffee(string name, decimal price, double milliliters, double caffeine) : base(name, price, milliliters)
        {
            this.CoffeeMilliliters = 50;
            this.CoffeePrice = 3.50M;
            this.Caffeine = caffeine;
        }
    }
}

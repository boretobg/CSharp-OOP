using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }
        public override decimal Price { get => 3.50m; }
        public override double Milliliters { get => 50; }
        public virtual double Caffeine { get; set; }
    }
}

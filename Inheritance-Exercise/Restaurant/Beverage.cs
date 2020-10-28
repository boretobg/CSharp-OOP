using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Restaurant
{
    class Beverage : Product
    {
        public double Milliliters { get; set; }
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            this.Milliliters = milliliters;
        }
    }
}

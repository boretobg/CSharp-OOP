using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Restaurant
{
    class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            this.Grams = grams;
        }
    }
}

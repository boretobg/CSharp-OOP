using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Drinks
{
    public class Water : Drink
    {
        public Water(string name, int portion, string brand)
            : base(name, portion, brand)
        {
        }

        public override decimal Price => 1.50m;
    }
}

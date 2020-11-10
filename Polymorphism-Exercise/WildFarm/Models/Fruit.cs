using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Fruit : Food
    {
        public override int Quantity { get; set; }
    }
}

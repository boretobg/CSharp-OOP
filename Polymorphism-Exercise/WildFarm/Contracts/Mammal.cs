using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Contracts
{
    public abstract class Mammal : Animal
    {
        public abstract string LivingRegion { get; set; }

        public Mammal(string livingRegion)
        {
            this.LivingRegion = livingRegion;
        }
    }
}

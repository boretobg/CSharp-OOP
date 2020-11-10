using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Contracts
{
    public abstract class Feline : Mammal
    {
        protected Feline(string livingRegion) : base(livingRegion)
        {
        }

        public abstract string Breed { get; set; }
    }
}

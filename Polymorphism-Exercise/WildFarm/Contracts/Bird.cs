using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Contracts
{
   public abstract class Bird : Animal
    {
        public abstract double WingSize { get; set; }
        public Bird(double wingSize)
        {
            this.WingSize = wingSize;
        }
    }
}

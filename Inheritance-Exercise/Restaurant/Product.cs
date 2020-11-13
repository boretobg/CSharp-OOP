using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string Name { get { return this.name; }  set { this.name = value; } }
        public virtual decimal Price { get { return this.price; }  set { this.price = value; } }
    }
}

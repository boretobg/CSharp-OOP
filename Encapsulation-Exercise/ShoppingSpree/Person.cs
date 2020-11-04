using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private readonly List<Product> bag;

        public Person()
        {
            this.bag = new List<Product>();
        }
        public Person(string name, double money) : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Constants.EmptyStringException);
                }

                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Constants.NoMoneyException);
                }

                this.money = value;
            }
        }
        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly();
        public override string ToString()
        {
            string bagItems = this.bag.Count > 0 ? String.Join(", ", this.Bag) : "Nothing bought";
            return $"{this.name} - {bagItems}";
        }
        public void BuyProduct(Product product)
        {
            if (this.money >= product.Cost)
            {
                Person person = new Person();
                this.bag.Add(product);
                this.money -= product.Cost;
                Console.WriteLine($"{this.name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
        }
    }
}

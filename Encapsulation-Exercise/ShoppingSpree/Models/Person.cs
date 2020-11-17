using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        public List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                this.money = value;
            }
        }
    }
}

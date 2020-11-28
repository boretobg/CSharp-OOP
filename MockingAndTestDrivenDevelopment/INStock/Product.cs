using INStock.Contracts;
using System;

namespace INStock
{
    public class Product : IProduct
    {
        private int quantity;
        private string label;
        private decimal price;

        public int Quantity
        {
            get => this.quantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative number.");
                }

                this.quantity = value;
            }
        }
        public string Label
        {
            get => this.label;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Label cannot be null or empty.");
                }

                this.label = value;
            }
        }
        public decimal Price
        {
            get => this.price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative number.");
                }

                this.price = value;
            }
        }

        public Product(int quantity, string label, decimal price)
        {
            this.Quantity = quantity;
            this.Label = label;
            this.Price = price;
        }

    }
}

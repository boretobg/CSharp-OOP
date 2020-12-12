using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> foods;
        private List<IDrink> drinks;

        private int capacity;
        private int numberOfPeople;
        private decimal price;
        private bool isReserved;

        protected Table(int tableNumber, int capacity)
        {
            TableNumber = tableNumber;
            Capacity = capacity;

            this.foods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
        }

        public ICollection<IBakedFood> FoodOrders => foods;
        public ICollection<IDrink> DrinkOrders => drinks;

        public int TableNumber { get; protected set; }

        public int Capacity
        {
            get => this.capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }

                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => this.numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }

                this.numberOfPeople = value;
            }
        }

        public virtual decimal PricePerPerson { get; protected set; }

        public bool IsReserved { get; set; }

        public decimal Price => PricePerPerson* NumberOfPeople;

        public void Clear()
        {
            drinks.Clear();
            foods.Clear();
            IsReserved = false;
        }

        public decimal GetBill()
        {
            decimal price = 0;

            foreach (var item in DrinkOrders)
            {
                price += item.Price;
            }
            foreach (var item in FoodOrders)
            {
                price += item.Price;
            }

            return this.Price + price;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Price per Person: {PricePerPerson}"); 

            return sb.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            drinks.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            foods.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.IsReserved = true;
            NumberOfPeople = numberOfPeople;
        }
    }
}

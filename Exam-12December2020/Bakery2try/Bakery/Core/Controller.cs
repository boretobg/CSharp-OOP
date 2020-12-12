using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private List<IBakedFood> foodList;
        private List<IDrink> drinkList;
        private List<ITable> tableList;

        public Controller()
        {
            this.foodList = new List<IBakedFood>();
            this.drinkList = new List<IDrink>();
            this.tableList = new List<ITable>();
        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = null;
            switch (type)
            {
                case "Tea":
                    drink = new Tea(name, portion, brand);
                    break;
                case "Water":
                    drink = new Water(name, portion, brand);
                    break;
            }

            drinkList.Add(drink); //TODO: idk
            return $"Added {drink.Name} ({drink.GetType().Name}) to the drink menu"; //TODO: if??
        }

        public string AddFood(string type, string name, decimal price)
        {
            IBakedFood food = null;
            switch (type)
            {
                case "Bread":
                    food = new Bread(name, price);
                    break;
                case "Cake":
                    food = new Cake(name, price);
                    break;
            }

            foodList.Add(food); //TODO: idk
            return $"Added {food.Name} ({food.GetType().Name}) to the menu"; //TODO: if??
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = null;
            switch (type)
            {
                case "InsideTable":
                    table = new InsideTable(tableNumber, capacity);
                    break;
                case "OutsideTable":
                    table = new OutsideTable(tableNumber, capacity);
                    break;
            }

            tableList.Add(table); //TODO: idk
            return $"Added table number {table.TableNumber} in the bakery"; //TODO: if??
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in tableList)
            {
                if (!item.IsReserved)
                {
                    sb.AppendLine(item.GetFreeTableInfo());
                }
            }

            return sb.ToString().Trim();
        }

        public string GetTotalIncome()
        {
            decimal income = 0;


            foreach (var item in tableList)
            {
               income += item.GetBill();
            }

            return $"Total income: {income:f2}lv";
        }

        public string LeaveTable(int tableNumber)
        {
            StringBuilder sb = new StringBuilder();
            var table = tableList.FirstOrDefault(t => t.TableNumber == tableNumber);

            table.Clear();

            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {table.GetBill():f2}");

            return sb.ToString().Trim();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var table = tableList.FirstOrDefault(t => t.TableNumber == tableNumber);
            var drink = drinkList.FirstOrDefault(f => f.Brand == drinkBrand && f.Name == drinkName);

            if (table is null)
            {
                return $"Could not find table {tableNumber}";
            }
            else if (drink is null)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }

            table.OrderDrink(drink);
            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var table = tableList.FirstOrDefault(t => t.TableNumber == tableNumber);
            var food = foodList.FirstOrDefault(f => f.Name == foodName);

            if (table is null)
            {
                return $"Could not find table {tableNumber}";
            }
            else if (food is null)
            {
                return $"No {foodName} in the menu";
            }

            table.OrderFood(food);
            return $"Table {tableNumber} ordered {foodName}";
        }

        public string ReserveTable(int numberOfPeople)
        {
            var table = tableList.FirstOrDefault(t => t.IsReserved == false && t.Capacity >= numberOfPeople);

            if (table is null)
            {
                return $"No available table for {numberOfPeople} people";
            }

            table.Reserve(numberOfPeople);
            return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
        }
    }
}

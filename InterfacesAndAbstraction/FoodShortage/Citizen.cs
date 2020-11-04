using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public int Food { get; set; }
        public string name;
        private int age;
        private string id;
        private string birthdate;
        public List<Citizen> citizens;

        public Citizen()
        {
            this.citizens = new List<Citizen>();
        }
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}

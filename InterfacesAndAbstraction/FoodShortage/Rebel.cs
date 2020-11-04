using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public int Food { get; set; }
        public string name;
        private int age;
        private string group;
        public List<Rebel> rebels;

        public Rebel()
        {
            this.rebels = new List<Rebel>();
        }
        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
        }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}

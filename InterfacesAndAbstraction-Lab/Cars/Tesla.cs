using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cars
{
    class Tesla : IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Start()
        {

            return "";
        }

        public string Stop()
        {

            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); //Red Tesla Model 3 with 2 Batteries
            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery}");
            sb.AppendLine($"Engine start");
            sb.AppendLine($"Breaaak!");
            return sb.ToString().Trim();
        }
    }
}

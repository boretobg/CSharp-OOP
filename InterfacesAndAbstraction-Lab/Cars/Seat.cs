using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Start()
        {

            return "";
        }

        public string Stop()
        {

            return "";
        }
    //Grey Seat Leon
    //Engine start
    //Breaaak!

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Seat {this.Model}");
            sb.AppendLine($"Engine start");
            sb.AppendLine($"Breaaak!");
            return sb.ToString().Trim();
        }
    }
}

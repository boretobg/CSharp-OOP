using EasterRaces.Utilities.Messages;
using System;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const int minHP = 400;
        private const int maxHP = 600;

        public MuscleCar(string model, int horsePower) : 
            base(model, horsePower)
        {
            HorsePower = horsePower;
        }

        public override int HorsePower 
        { 
            get => base.HorsePower; 
            set
            {
                if (value < minHP || value > maxHP)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                base.HorsePower = value;
            }
        }
        public override double CubicCentimeters { get; set; } = 5000;
    }
}

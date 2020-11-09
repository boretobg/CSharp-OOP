using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Classes
{
    public class Car : IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 0.9;
        }
        public void Drive(double distance)
        {
            double liters = distance * this.FuelConsumption;
            if (this.FuelQuantity > liters)
            {
                this.FuelQuantity = this.FuelQuantity - liters;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}

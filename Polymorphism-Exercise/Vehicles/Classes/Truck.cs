using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Classes
{
    public class Truck : IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 1.6;
        }
        public void Drive(double distance)
        {
            double liters = distance * this.FuelConsumption;
            if (this.FuelQuantity > liters)
            {
                this.FuelQuantity = this.FuelQuantity - liters;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double fuel)
        {
            this.FuelQuantity += fuel - fuel * 0.05;
        }
    }
}

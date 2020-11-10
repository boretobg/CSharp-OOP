using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtensions.Contracts;

namespace VehiclesExtensions.Models
{
    public class Truck : IVehicle
    {
        private double fuelQuantity;

        private double fuelConsumptionIncrease = 1.6;

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                if (value <= this.TankCapacity)
                {
                    this.fuelQuantity = value;
                }

                else
                {
                    this.fuelQuantity = 0;
                }
            }
        }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }



        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }



        public void Drive(double distance)
        {
            double fuelNeeded = distance * (fuelConsumptionIncrease + this.FuelConsumption);

            if (this.FuelQuantity >= fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;

                Console.WriteLine($"Truck travelled {distance} km");
            }

            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double fuelAmount)
        {
            if (fuelAmount > 0)
            {
                if (this.TankCapacity >= this.FuelQuantity + fuelAmount)
                {
                    this.FuelQuantity += (fuelAmount * 0.95);
                }

                else
                {
                    Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                }
            }

            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        void Drive(double distance);
        void Refuel(double fuel);
    }
}

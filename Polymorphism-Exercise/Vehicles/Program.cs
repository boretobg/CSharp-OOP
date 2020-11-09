using System;
using System.Transactions;
using Vehicles.Classes;
using Vehicles.Interfaces;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            IVehicle car = new Car(double.Parse(input[1]), double.Parse(input[2]));
            input = Console.ReadLine().Split();
            IVehicle truck = new Truck(double.Parse(input[1]), double.Parse(input[2]));

            IVehicle vehicle = null;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                if (input[0] == "Drive")
                {
                    if (input[1] == "Car")
                    {
                        vehicle = car;
                    }
                    else
                    {
                        vehicle = truck;
                    }
                    vehicle.Drive(double.Parse(input[2]));
                }
                else if (input[0] == "Refuel")
                {
                    if (input[1] == "Car")
                    {
                        vehicle = car;
                    }
                    else
                    {
                        vehicle = truck;
                    }
                    vehicle.Refuel(double.Parse(input[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}\nTruck: {truck.FuelQuantity:f2}");
        }
    }
}

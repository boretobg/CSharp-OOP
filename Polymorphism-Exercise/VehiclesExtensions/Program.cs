using System;
using VehiclesExtensions.Contracts;
using VehiclesExtensions.Models;

namespace VehiclesExtensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split();

            string[] truckData = Console.ReadLine().Split();

            string[] busData = Console.ReadLine().Split();

            IVehicle car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));
            IVehicle truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));
            IVehicle bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[1] == "Car")
                {
                    car = ExecuteCommand(command, car);
                }

                else if (command[1] == "Truck")
                {
                    truck = ExecuteCommand(command, truck);
                }

                else if (command[1] == "Bus")
                {
                    bus = ExecuteCommand(command, bus);
                }
            }

            Console.WriteLine($"Car: {Math.Round(car.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
            Console.WriteLine($"Truck: {Math.Round(truck.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
            Console.WriteLine($"Bus: {Math.Round(bus.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
        }

        public static IVehicle ExecuteCommand(string[] command, IVehicle vehicle)
        {
            if (command[0] == "Drive")
            {
                vehicle.Drive(double.Parse(command[2]));
            }

            else if (command[0] == "Refuel")
            {
                vehicle.Refuel(double.Parse(command[2]));
            }

            else if (command[0] == "DriveEmpty")
            {
                Bus bus = vehicle as Bus;

                bus.DriveEmpty(double.Parse(command[2]));

                vehicle = bus;
            }

            return vehicle;
        }
    }
}

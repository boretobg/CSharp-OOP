using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private DriverRepository drivers;
        private CarRepository cars;
        private RaceRepository races;

        public ChampionshipController()
        {
            drivers = new DriverRepository();
            cars = new CarRepository();
            races = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            var driver = drivers.Models.FirstOrDefault(d => d.Name == driverName);
            if (!drivers.Models.Contains(driver))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            var car = cars.Models.FirstOrDefault(c => c.Model == carModel);
            if (car is null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, car.Model));
            }

            driver.AddCar(car);
            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            var race = races.Models.FirstOrDefault(r => r.Name == raceName);
            if (!races.Models.Contains(race))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            var driver = drivers.Models.FirstOrDefault(d => d.Name == driverName);
            if (!drivers.Models.Contains(driver))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            race.AddDriver(driver);
            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = null;

            switch (type)
            {
                case "Muscle":
                    car = new MuscleCar(model, horsePower);
                    break;
                case "Sports":
                    car = new SportsCar(model, horsePower);
                    break;
            }

            if (cars.Models.Contains(cars.Models.FirstOrDefault(c => c.Model == model)))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, car.GetType().Name));
            }

            cars.Models.Add(car);

            return $"{car.GetType().Name} {car.Model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            var driver = new Driver(driverName);
            if (drivers.Models.Contains(drivers.Models.FirstOrDefault(d => d.Name == driverName)))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }

            drivers.Models.Add(driver);
            return string.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateRace(string name, int laps)
        {
            var race = new Race(name, laps);
            if (races.Models.Contains(race))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }

            races.Models.Add(race);
            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string StartRace(string raceName)
        {
            var race = races.Models.FirstOrDefault(r => r.Name == raceName);
            if (!races.Models.Contains(race))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (drivers.Models.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }
            var sorted = drivers.Models.OrderByDescending(d => d.Car.CalculateRacePoints(race.Laps)).ToArray();

            var listOfThreeFastest = new List<IDriver>();
            for (int i = 0; i < 3; i++)
            {
                listOfThreeFastest.Add(sorted[i]);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Driver {listOfThreeFastest[0].Name} wins {raceName} race.");
            sb.AppendLine($"Driver {listOfThreeFastest[1].Name} is second in {raceName} race.");
            sb.AppendLine($"Driver {listOfThreeFastest[2].Name} is third in {raceName} race.");

            return sb.ToString().Trim();
        }
    }
}

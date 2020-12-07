using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;
using System;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private string name;
        private bool canParticipate;

        public Driver(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }

                this.name = value;
            }
        }

        public ICar Car { get; set; }

        public int NumberOfWins { get; set; }

        public bool CanParticipate /* => Car != null;*/
        {
            get => this.canParticipate;
            private set
            {
                if (Car != null)
                {
                    this.canParticipate = true;
                }

                this.canParticipate = value;
            }
        }
        public void AddCar(ICar car)
        {
            if (car is null)
            {
                throw new ArgumentException(ExceptionMessages.CarInvalid);
            }

            this.Car = car;
            this.CanParticipate = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}

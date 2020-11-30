using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        protected IDictionary<string, IRobot> robots;
        public Garage()
        {

        }

        public IReadOnlyDictionary<string, IRobot> Robots => (IReadOnlyDictionary<string, IRobot>)robots;

        public int Capacity = 10;

        public void Manufacture(IRobot robot)
        {
            if (this.Capacity == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            if (this.robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingRobot, robot.Name));
            }

            this.robots.Add(robot.Name, robot);
            Capacity--;
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!this.robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            IRobot currentRobot = robots.FirstOrDefault(r => r.Key == robotName).Value;

            currentRobot.Owner = ownerName;
            currentRobot.IsBought = true;

            this.robots.Remove(robotName);
            Capacity++;
        }
    }
}

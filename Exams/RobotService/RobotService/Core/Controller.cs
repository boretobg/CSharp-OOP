using RobotService.Core.Contracts;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using RobotService.Models.Procedures;
using System;
using System.Linq;
using RobotService.Models.Garages;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace RobotService.Core
{
    //class should not handle exeptions!
    public class Controller : IController
    {
        private IGarage garage;
        private Chip chip;
        private TechCheck techCheck;
        private Rest rest;
        private Work work;
        private Charge charge;
        private Polish polish;

        public Controller()
        {
            this.garage = new Garage();
        }
        
        public void Exit()
        {
            Environment.Exit(0);
        }

        public string Charge(string robotName, int procedureTime)
        {
            RobotExist(robotName); //throws exception if doesn't exist

            charge = new Charge();
            charge.DoService(GetRobotByName(robotName), procedureTime);

            return $"{robotName} had charge procedure";
        }

        public string Chip(string robotName, int procedureTime)
        {
            RobotExist(robotName); //throws exception if doesn't exist

            chip = new Chip();
            chip.DoService(GetRobotByName(robotName), procedureTime);

            return $"{robotName} had chip procedure";
        }

        public string History(string procedureType) //dont check if exists
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{procedureType}");
            foreach (var robot in garage.AllRobots)
            {
                sb.AppendLine($" Robot type: {robot.GetType().Name} - {robot.Name} - Happiness: {robot.Happiness} - Energy: {robot.Energy}");
            }

            return sb.ToString().Trim();
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime) //dont check if exists
        {
            //ALTERNATIVE AND MORE ADVANCED METHOD, NOT MINE (including RobotTypeEnums in Utilites folder)
            //if (!Enum.TryParse(robotType, out RobotTypeEnums robotTypeEnum))
            //{
            //    throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robotType));
            //}

            //IRobot robot = robotTypeEnum switch
            //{
            //    RobotTypeEnums.HouseholdRobot => new HouseholdRobot(name, energy, happiness, procedureTime),
            //    RobotTypeEnums.PetRobot => new PetRobot(name, energy, happiness, procedureTime),
            //    RobotTypeEnums.WalkerRobot => new WalkerRobot(name, energy, happiness, procedureTime),
            //    _ => null
            //};

            //my method:
            string[] types = new string[] { "HouseholdRobot", "PetRobot", "WalkerRobot" };
            if (!types.Contains(robotType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robotType));
            }

            IRobot robot = null;
            switch (robotType)
            {
                case "HouseholdRobot":
                    robot = new HouseholdRobot(name, energy, happiness, procedureTime);
                    break;
                case "PetRobot":
                    robot = new PetRobot(name, energy, happiness, procedureTime);
                    break;
                case "WalkerRobot":
                    robot = new WalkerRobot(name, energy, happiness, procedureTime);
                    break;
            }

            this.garage.Manufacture(robot);
            return $"Robot {name} registered successfully";
        }

        public string Polish(string robotName, int procedureTime)
        {
            RobotExist(robotName); //throws exception if doesn't exist

            polish = new Polish();
            polish.DoService(GetRobotByName(robotName), procedureTime);

            return $"{robotName} had polish procedure";
        }

        public string Rest(string robotName, int procedureTime)
        {
            RobotExist(robotName); //throws exception if doesn't exist

            rest = new Rest();
            rest.DoService(GetRobotByName(robotName), procedureTime);

            return $"{robotName} had rest procedure";
        }

        public string Sell(string robotName, string ownerName)
        {
            RobotExist(robotName);
            IRobot robot = GetRobotByName(robotName);

            garage.Sell(robotName, ownerName);

            if (robot.IsChipped)
            {
                return $"{ownerName} bought robot with chip";
            }

            return $"{ownerName} bought robot without chip";
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            RobotExist(robotName); //throws exception if doesn't exist

            techCheck = new TechCheck();
            techCheck.DoService(GetRobotByName(robotName), procedureTime);

            return $"{robotName} had tech check procedure";
        }

        public string Work(string robotName, int procedureTime)
        {
            RobotExist(robotName); //throws exception if doesn't exist

            work = new Work();
            work.DoService(GetRobotByName(robotName), procedureTime);

            return $"{robotName} was working for {procedureTime} hours";
        }

        public void RobotExist(string name)
        {
            if (!garage.Robots.ContainsKey(name))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, name));
            }
        }

        public IRobot GetRobotByName(string name)
        {
            return garage.Robots.FirstOrDefault(r => r.Key == name).Value;
        }
    }
}

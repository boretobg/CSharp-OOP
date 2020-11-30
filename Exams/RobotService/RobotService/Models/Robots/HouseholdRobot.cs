using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Robots
{
    public class HouseholdRobot : Robot, IRobot
    {
        public HouseholdRobot(string name, int energy, int happiness, int procedureTime) : 
            base(name, energy, happiness, procedureTime)
        {
        }
    }
}

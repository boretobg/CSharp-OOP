using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Robots
{
    public class WalkerRobot : Robot, IRobot
    {
        public WalkerRobot(string name, int energy, int happiness, int procedureTime) : 
            base(name, energy, happiness, procedureTime)
        {
        }
    }
}

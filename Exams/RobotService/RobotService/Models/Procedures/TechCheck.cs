using RobotService.Models.Robots.Contracts;
using RobotService.Utilities;

namespace RobotService.Models.Procedures
{
    public class TechCheck : Procedure
    {
        private CheckProcedureTime checkProcedureTime;
        private int RemoveEnergyPoints = 8;

        public TechCheck()
        {
            this.checkProcedureTime = new CheckProcedureTime();
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            checkProcedureTime.CheckProcedureTimeMethod(robot, procedureTime);

            robot.Energy -= RemoveEnergyPoints;
            if (robot.IsChecked)
            {
                robot.Energy -= RemoveEnergyPoints;
            }
            robot.IsChecked = true;
        }
    }
}

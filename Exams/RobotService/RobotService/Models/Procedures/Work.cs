using RobotService.Models.Robots.Contracts;
using RobotService.Utilities;

namespace RobotService.Models.Procedures
{
    public class Work : Procedure
    {
        private CheckProcedureTime checkProcedureTime;
        private int AddHapinessPoints = 12;
        private int RemoveEnergyPoints = 6;

        public Work()
        {
            this.checkProcedureTime = new CheckProcedureTime();
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            checkProcedureTime.CheckProcedureTimeMethod(robot, procedureTime);

            robot.Happiness += AddHapinessPoints;
            robot.Energy -= RemoveEnergyPoints;
        }
    }
}

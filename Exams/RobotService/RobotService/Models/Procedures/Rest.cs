using RobotService.Models.Robots.Contracts;
using RobotService.Utilities;

namespace RobotService.Models.Procedures
{
    public class Rest : Procedure
    {
        private CheckProcedureTime checkProcedureTime;
        private int RemoveHapinessPoints = 3;
        private int AddEnergyPoints = 10;

        public override void DoService(IRobot robot, int procedureTime)
        {
            checkProcedureTime.CheckProcedureTimeMethod(robot, procedureTime);

            robot.Happiness -= RemoveHapinessPoints;
            robot.Energy += AddEnergyPoints;
        }
    }
}

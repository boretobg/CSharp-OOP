using RobotService.Models.Robots.Contracts;
using RobotService.Utilities;

namespace RobotService.Models.Procedures
{
    public class Polish : Procedure
    {
        private CheckProcedureTime checkProcedureTime;
        private int RemoveHapinessPoints = 7;

        public override void DoService(IRobot robot, int procedureTime)
        {
            checkProcedureTime.CheckProcedureTimeMethod(robot, procedureTime);

            robot.Happiness -= RemoveHapinessPoints;
        }
    }
}

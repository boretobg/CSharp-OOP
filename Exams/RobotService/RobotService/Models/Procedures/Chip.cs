using RobotService.Models.Robots.Contracts;
using RobotService.Utilities;
using RobotService.Utilities.Messages;
using System;

namespace RobotService.Models.Procedures
{
    public class Chip : Procedure
    {
        private CheckProcedureTime checkProcedureTime;
        private int HappinessValueToRemove = 5;
        public override void DoService(IRobot robot, int procedureTime)
        {
            checkProcedureTime.CheckProcedureTimeMethod(robot, procedureTime);

            robot.Happiness -= HappinessValueToRemove;

            if (robot.IsChipped)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.AlreadyChipped, robot.Name));
            }
            robot.IsChipped = true;
        }
    }
}

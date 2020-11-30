using RobotService.Models.Robots.Contracts;
using RobotService.Utilities;

namespace RobotService.Models.Procedures
{
    public class Charge : Procedure
    {
        private CheckProcedureTime checkProcedureTime;
        private int AddHapinessPoints = 12;
        private int AddEnergyPoints = 10;

        public Charge()
        {
            this.checkProcedureTime = new CheckProcedureTime();
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            checkProcedureTime.CheckProcedureTimeMethod(robot, procedureTime);

            robot.Happiness += AddHapinessPoints;
            robot.Energy += AddEnergyPoints;
        }
    }
}

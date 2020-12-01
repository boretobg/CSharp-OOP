namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        [Test]
        public void TestIfConstructorWorks()
        {
            Robot robot = new Robot("K9", 5000);

            var expextedName = "K9";
            var expectedBettery = 5000;
            var expectedMaximumBattery = 5000;

            Assert.AreEqual(expextedName, robot.Name);
            Assert.AreEqual(expectedBettery, robot.Battery);
            Assert.AreEqual(expectedMaximumBattery, robot.MaximumBattery);
        }
    }
}

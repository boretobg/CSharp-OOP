using NUnit.Framework;
using System;

namespace Robots.Tests
{
    public class RobotManagerTests
    {
        private Robot testRobot1 = new Robot("Robot1", 100);
        private Robot testRobot2 = new Robot("Robot2", 100);

        [Test]
        public void TestIfConstructorWorksProperly()
        {
            RobotManager robotManager = new RobotManager(20);

            int expected = 20;

            Assert.AreEqual(expected, robotManager.Capacity);
        }

        [Test]
        public void TestIfRobotsListWorkProperly()
        {
            RobotManager robotManager = new RobotManager(20);

            robotManager.Add(testRobot1);
            robotManager.Add(testRobot2);

            int expectedCount = 2;

            Assert.AreEqual(expectedCount, robotManager.Count);
        }

        [Test]
        public void CheckIfCapacityPropertyThrowsExceptions()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                RobotManager robotManager = new RobotManager(-2);
            });
        }

        [Test]
        public void CheckIfCountPropertyWorks()
        {
            RobotManager robotManager = new RobotManager(1);

            int expectedCount = 0;

            Assert.AreEqual(expectedCount, robotManager.Count);
        }

        [Test]
        public void TestAddMethodIfWorksCorrectly()
        {
            RobotManager robotManager = new RobotManager(2);

            robotManager.Add(testRobot1);
            robotManager.Add(testRobot2);

            int expected = 2;

            Assert.AreEqual(expected, robotManager.Count);
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenNameIsDuplicated()
        {
            RobotManager robotManager = new RobotManager(2);

            robotManager.Add(testRobot1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Add(testRobot1);
            });
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenCapacityIsFull()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Add(testRobot1);
            });
        }

        [Test]
        public void TestIfRemoveMethodWorks()
        {
            RobotManager robotManager = new RobotManager(2);

            robotManager.Add(testRobot1);
            robotManager.Add(testRobot2);

            robotManager.Remove("Robot1");

            int expectedCount = 1;

            Assert.AreEqual(expectedCount, robotManager.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWhenNameDoesntExist()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Remove("invalid name");
            });
        }


        [Test]
        public void TestIfWorkMethodWorksProperly()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            robotManager.Work("Robot1", "job", 40);

            int expectedValue = 60;

            Assert.AreEqual(expectedValue, testRobot1.Battery);
        }

        [Test]
        public void WorkMethodShouldThrowExceptionWhenNameIsInvalid()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Work("invalid name", "job", 100);
            });
        }

        [Test]
        public void WorkMethodShouldThrowExceptionWhenNotEnoughBattery()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Work("Robot1", "job", 120);
            });
        }

        [Test]
        public void TestChargeMethodIfItWorksCorrectly()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            int expectedValue = 100;

            robotManager.Charge("Robot1");

            Assert.AreEqual(expectedValue, testRobot1.Battery);
        }

        [Test]
        public void ChargeMethodShouldThrowExceptionIfRobotNameIsInvalid()
        {
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(testRobot1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Charge("invalid name");
            });
        }
    }
}

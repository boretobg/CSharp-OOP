using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BothConstructorsTest()
        {
            var expectedMake = "VW";
            var expectedModel = "Golf";
            var expectedFuelConsumption = 2.5;
            var expectedFuelAmount = 0;
            var expectedFuelCapacity = 60;

            this.car = new Car("VW", "Golf", 2.5, 60);

            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedFuelConsumption, car.FuelConsumption);
            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }

        [Test]
        public void TestIfMakePropertieWorksCorrectly()
        {
            Assert.Throws<ArgumentException>(() => 
            {
                this.car = new Car("", "Golf", 2.5, 60);
            });
        }

        [Test]
        public void TestIfModelWorksCorrectly()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car("VW", "", 2.5, 60);
            });
        }

        [Test]
        public void TestIfFuelConsumptionsWorksCorrectly()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car("VW", "Golf", 0, 60);
            });
        }
        
        [Test]
        public void TestIfFuelCapacityWorksCorrectly()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car("VW", "Golf", 2.5, 0);
            });
        }
        
        [Test]
        public void TestIfFuelAmountyWorksCorrectly()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.car = new Car("VW", "Golf", 2.5, 60);
                this.car.Drive(int.MaxValue);
            });
        }

        [Test]
        public void TestRefuelMethod()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(-1);
            });
        }

        [Test]
        public void TestDriveMethod()
        {
            Assert.Throws<InvalidOperationException>(() => 
            {
                car.Drive(int.MaxValue);
            }
            );
        }
    }
}
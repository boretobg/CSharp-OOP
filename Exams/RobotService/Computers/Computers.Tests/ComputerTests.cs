namespace Computers.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class ComputerTests
    {
        private Computer computer = new Computer("PC1");
        private Part part = new Part("Part1", 10m);
        private List<Part> parts = new List<Part>
        {
           new Part("Part1", 10m),
           new Part("Part2", 20m),
           new Part("Part3", 30m),
        };

        [TestCase(null)]
        [TestCase("   ")]
        public void CheckIfNamePropertyThrowsAppropriateExceptions(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Computer computer = new Computer(name);
            });
        }

        [Test]
        public void TestPartsProperty()
        {
            int expectedCount = 0;
            Assert.AreEqual(expectedCount, computer.Parts.Count);
        }

        [Test]
        public void TestTotalPriceProperty()
        {
            Computer computer = new Computer("Computer");
            foreach (var part in parts)
            {
                computer.AddPart(part);
            }

            decimal expectedPrice = 60m;
            decimal actualPrice = computer.TotalPrice;

            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [Test]
        public void TestIfAddPartMethodThrowsExceptionsRight()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                computer.AddPart(null);
            });
        }

        [Test]
        public void TestRemoveMethod()
        {
            foreach (var part in parts)
            {
                computer.AddPart(part);
            }

            int expectedCount = 2;
            computer.RemovePart(parts[0]);

            Assert.AreEqual(expectedCount, computer.Parts.Count);
        }

        [Test]
        public void TestIfGetMethodReturnsRightPart()
        {
            Part part = new Part("RAM", 20m);
            Computer computer = new Computer("PC");
            computer.AddPart(part);

            var expected = part;
            var actual = computer.GetPart("RAM");

            Assert.AreEqual(expected, actual);
        }
    }
}
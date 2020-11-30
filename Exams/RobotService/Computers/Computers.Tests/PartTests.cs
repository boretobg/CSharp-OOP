using NUnit.Framework;

namespace Computers.Tests
{
    public class PartTests
    {
        [Test]
        public void TestIfConstructorAndPropertiesWork()
        {
            string expectedName = "Tool";
            decimal expectedPrice = 21.2m;

            Part part = new Part("Tool", 21.2m);

            Assert.AreEqual(expectedName, part.Name);
            Assert.AreEqual(expectedPrice, part.Price);
        }
    }
}

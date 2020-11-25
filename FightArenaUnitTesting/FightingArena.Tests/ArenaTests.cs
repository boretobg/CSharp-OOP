using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena = new Arena();
        private Warrior[] warriors = new Warrior[] {   
                new Warrior("Ivan", 30, 100),
                new Warrior("Gogo", 50, 78),
                new Warrior("Miro", 20, 11)};

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfConstructorWorksProperly()
        {
            int expectedCount = 0;
            Arena arena = new Arena();
            Assert.AreEqual(expectedCount, arena.Count);
        }

        [Test]
        public void TestWarriorsPropertie()
        {
            int expectedCount = 0;
            Arena arena = new Arena();
            Assert.AreEqual(expectedCount, arena.Warriors.Count);
        }

        [Test]
        public void TestCountPropertie()
        {
            int expectedCount = 0;
            Arena arena = new Arena();
            Assert.AreEqual(expectedCount, arena.Count);
        }

        [Test]
        public void CheckIfEnrollMethodsThrowsExceptionWhenNameIsDuplicated()
        {
            arena.Enroll(warriors[0]);
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warriors[0]);
            });
        }

        [Test]
        public void CheckIfFightMethodThrowsExceptionWhenThereIsNoWarriorWithGivenName()
        {
            Assert.Throws<InvalidOperationException>(() => 
            {
                arena.Fight("", "");
            });
        }
    }
}

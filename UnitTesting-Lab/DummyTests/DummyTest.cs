using NUnit.Framework;
using System;

namespace DummyTests
{
    public class Tests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            var dummy = new Dummy(10, 10);

            dummy.TakeAttack(1);

            Assert.That(dummy.Health, Is.EqualTo(9), "Health error.");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var dummy = new Dummy(0, 10);

                dummy.TakeAttack(1);
            }, "Dummy is not dead.");
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            var dummy = new Dummy(0, 5);

            int xp = dummy.GiveExperience();

            Assert.That(xp, Is.EqualTo(5), "error");
        }

        [Test]
        public void AliveDummyCantGiveXp()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var dummy = new Dummy(1, 5);

                dummy.GiveExperience();
            }, "Error");
        }
    }
}
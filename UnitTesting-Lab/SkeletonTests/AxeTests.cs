using NUnit.Framework;
using System;

namespace SkeletonTests
{
    public class Tests
    {
        [Test]
        public void AxeLooseDurabilityAfterAttack()
        {
            var axe = new Axe(10, 10);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");
        }

        [Test]
        public void AxeAttackingWithBrokenWeaponException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var axe = new Axe(10, 0);
                var dummy = new Dummy(10, 10);

                axe.Attack(dummy);
            }, "Axe is broken");
        }
    }
}
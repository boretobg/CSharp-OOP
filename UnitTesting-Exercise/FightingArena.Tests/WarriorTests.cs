using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructor()
        {
            var expectedName = "Pero";
            var expectedDamage = 30;
            var expectedHP = 100;

            Warrior warrior = new Warrior("Pero", 30, 100);
            Assert.AreEqual(expectedName, warrior.Name);
            Assert.AreEqual(expectedDamage, warrior.Damage);
            Assert.AreEqual(expectedHP, warrior.HP);
        }

        [TestCase(null)]
        [TestCase(" ")]
        public void CheckIfNamePropertieThrowsExceptionWhenNameIsNullOtWhiteSpace(string name)
        {
            Assert.Throws<ArgumentException>(() => { Warrior warrior = new Warrior(name, 30, 100); });
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CheckIfDamagePropertieThrowsExceptionWhenValueIsBellowOrZero(int damage)
        {
            Assert.Throws<ArgumentException>(() => { Warrior warrior = new Warrior("Gosho", damage, 100); });
        }

       [Test]
        public void CheckIfHPPropertieThrowsExceptionWhenValueIsBellowZero()
        {
            Assert.Throws<ArgumentException>(() => { Warrior warrior = new Warrior("Gosho", 30, -1); });
        }

        [Test]
        public void CheckIfAttackMethodThrowsExceptionWhenHPIsTooLow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Warrior attacker = new Warrior("Gosho", 50, 30);
                Warrior enemy = new Warrior("Ivan", 50, 100);
                attacker.Attack(enemy);
            });
        }

        [Test]
        public void CheckIfAttackMethodThrowsExceptionWhenEnemyHPIsTooLow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Warrior attacker = new Warrior("Gosho", 50, 100);
                Warrior enemy = new Warrior("Ivan", 50, 29);
                attacker.Attack(enemy);
            });
        }

        [Test]
        public void CheckIfAttackMethodThrowsExceptionWhenHPIsLessThanEnemysHP()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Warrior attacker = new Warrior("Gosho", 30, 50);
                Warrior enemy = new Warrior("Ivan", 60, 100);
                attacker.Attack(enemy);
            });
        }     
    }
}
using FakeAxeAndDummy.Interfaces;
using FakeAxeAndDummy.Models;
using NUnit.Framework;
using System;

namespace FakeAxeAndDummy.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [TestCase(1, 1)]
        [TestCase(5, 10)]
        [TestCase(25, 50)]
        [TestCase(49, 99)]
        [TestCase(50, 100)]
        public void AxeInitiliazationShouldWorkWithValidParameters(int damage, int durability)
        {
            IWeapon axe = new Axe(damage, durability);
            Assert.AreEqual(damage, axe.Damage);
            Assert.AreEqual(durability, axe.Durability);
        }

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-25)]
        [TestCase(51)]
        [TestCase(500)]
        public void AxeInitializationShouldNotWorkWithInvalidDamageParameter(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Axe(damage, 100));
        }

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-250)]
        [TestCase(101)]
        [TestCase(1000)]
        public void AxeInitializationShouldNotWorkWithInvalidDurabilityParameter(int durability)
        {
            Assert.Throws<ArgumentException>(() => new Axe(50, durability));
        }
    }
}

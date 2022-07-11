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
    }
}

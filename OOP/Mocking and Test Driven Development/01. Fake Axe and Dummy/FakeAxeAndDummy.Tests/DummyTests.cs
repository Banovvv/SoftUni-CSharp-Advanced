using FakeAxeAndDummy.Interfaces;
using FakeAxeAndDummy.Models;
using NUnit.Framework;
using System;

namespace FakeAxeAndDummy.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(99)]
        [TestCase(100)]
        public void DummyInitiliazationShouldWorkWithValidParameters(int health)
        {
            ITarget dummy = new Dummy(health);
            Assert.AreEqual(health, dummy.Health);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-15)]
        [TestCase(990)]
        [TestCase(101)]
        public void DummyInitiliazationShouldNotWorkWithInvalidParameters(int health)
        {
            Assert.Throws<ArgumentException>(() => new Dummy(health));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(55)]
        [TestCase(99)]
        public void DummyTakeDamageShouldWorkWithValidParameters(int damage)
        {
            ITarget dummy = new Dummy(100);
            dummy.TakeDamage(damage);
            Assert.AreEqual(100 - damage, dummy.Health);
        }
    }
}
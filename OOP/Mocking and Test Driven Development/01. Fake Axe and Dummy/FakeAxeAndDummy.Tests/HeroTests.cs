using FakeAxeAndDummy.Interfaces;
using FakeAxeAndDummy.Models;
using Moq;
using NUnit.Framework;
using System;

namespace FakeAxeAndDummy.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [TestCase(1)]
        [TestCase(43)]
        [TestCase(99)]
        [TestCase(100)]
        public void HeroInitializationShouldWorkWithValidWeapon(int health)
        {
            var mockWeapon = new Mock<IWeapon>().Object;


            Hero hero = new Hero(mockWeapon, health);

            Assert.AreEqual(health, hero.Health);
            Assert.AreEqual(mockWeapon, hero.Weapon);
        }

        [Test]
        public void HeroInitializationShouldNotWorkWithInvalidWeapon()
        {
            Assert.Throws<ArgumentNullException>(() => new Hero(null, 100), "Weapon cannot be null!");
        }
    }
}

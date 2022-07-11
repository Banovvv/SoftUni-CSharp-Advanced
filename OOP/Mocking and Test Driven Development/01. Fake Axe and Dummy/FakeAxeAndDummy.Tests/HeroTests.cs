using FakeAxeAndDummy.Interfaces;
using FakeAxeAndDummy.Models;
using NUnit.Framework;
using System;

namespace FakeAxeAndDummy.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroInitializationShouldNotWorkWithInvalidWeapon()
        {
            Assert.Throws<ArgumentNullException>(() => new Hero(null, 100), "Weapon cannot be null!");
        }
    }
}

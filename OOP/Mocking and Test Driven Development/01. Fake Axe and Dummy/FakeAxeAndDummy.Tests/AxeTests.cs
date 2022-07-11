using FakeAxeAndDummy.Interfaces;
using FakeAxeAndDummy.Models;
using NUnit.Framework;
using System;

namespace FakeAxeAndDummy.Tests
{
    [TestFixture]
    public class AxeTests
    {
        public void AxeInitiliazationShouldWorkWithValidParameters(int damage, int durability)
        {
            IWeapon axe = new Axe(damage, durability);
        }
    }
}

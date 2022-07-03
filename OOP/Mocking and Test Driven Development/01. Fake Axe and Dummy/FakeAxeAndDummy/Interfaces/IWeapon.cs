using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy.Interfaces
{
    public interface IWeapon
    {
        public int Damage { get; }
        public int Durability { get; }
    }
}

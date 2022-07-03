using FakeAxeAndDummy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy.Models
{
    public class Axe : IWeapon
    {
        private int damage;
        private int durability;

        public Axe(int damage, int durability)
        {
            Damage = damage;
            Durability = durability;
        }

        public int Damage
        {
            get => damage;
            private set
            {
                damage = value;
            }
        }

        public int Durability
        {
            get => durability;
            private set
            {
                durability = value;
            }
        }
    }
}

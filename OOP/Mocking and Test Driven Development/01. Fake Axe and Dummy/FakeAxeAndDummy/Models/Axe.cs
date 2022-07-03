using FakeAxeAndDummy.Interfaces;
using System;

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
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentException();
                }

                damage = value;
            }
        }

        public int Durability
        {
            get => durability;
            private set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentException();
                }

                durability = value;
            }
        }
    }
}

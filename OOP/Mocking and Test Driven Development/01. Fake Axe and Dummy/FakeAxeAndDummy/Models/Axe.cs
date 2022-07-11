using FakeAxeAndDummy.Interfaces;
using System;

namespace FakeAxeAndDummy.Models
{
    public class Axe : IWeapon
    {
        private int damage;
        private int durability;
        private readonly int minDamage = 0;
        private readonly int maxDamage = 50;
        private readonly int minDurability = 0;
        private readonly int maxDurability = 100;

        public Axe(int damage, int durability)
        {
            Damage = damage;
            Durability = durability;
        }

        public int Damage
        {
            get => damage;
            set
            {
                if (value <= minDamage || value > maxDamage)
                {
                    throw new ArgumentException($"Weapon damage should be between {minDamage} and {maxDamage}!");
                }

                damage = value;
            }
        }

        public int Durability
        {
            get => durability;
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentException($"Weapon damage should be between {minDurability} and {maxDurability}!");
                }

                durability = value;
            }
        }
    }
}

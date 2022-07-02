using FakeAxeAndDummy.Interfaces;
using System;

namespace FakeAxeAndDummy.Models
{
    public class Hero : ITarget
    {
        private IWeapon weapon;
        private int health;

        public Hero(IWeapon weapon, int health)
        {
            Weapon = weapon;
            Health = health;
        }

        public int Health
        {
            get => health;
            private set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentException("Health must be > 0 and <= 100");
                }

                health = value;
            }
        }

        public IWeapon Weapon
        {
            get => weapon;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Weapon cannot be null!");
                }

                weapon = value;
            }
        }
    }
}

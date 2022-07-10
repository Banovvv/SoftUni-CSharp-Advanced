using FakeAxeAndDummy.Interfaces;
using System;

namespace FakeAxeAndDummy.Models
{
    public class Hero : IHero, ITarget
    {
        private int health;
        private IWeapon weapon;
        private readonly int minHealth = 0;
        private readonly int maxHealth = 100;

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
                if (value <= minHealth || value > maxHealth)
                {
                    throw new ArgumentException($"Health must be between {minHealth} and {maxHealth}!");
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

        public void Attack(ITarget target)
        {
            throw new NotImplementedException();
        }
    }
}

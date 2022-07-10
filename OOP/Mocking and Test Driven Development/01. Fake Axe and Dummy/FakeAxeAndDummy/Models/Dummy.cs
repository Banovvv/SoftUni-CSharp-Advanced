using FakeAxeAndDummy.Interfaces;
using System;

namespace FakeAxeAndDummy.Models
{
    public class Dummy : ITarget
    {
        private int health;
        private readonly int minHealth = 0;
        private readonly int maxHealth = 100;

        public Dummy(int health)
        {
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
    }
}

using FakeAxeAndDummy.Interfaces;
using System;

namespace FakeAxeAndDummy.Models
{
    public class Dummy : ITarget
    {
        private int health;

        public Dummy(int health)
        {
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
    }
}

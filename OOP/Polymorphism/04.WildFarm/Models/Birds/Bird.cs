using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public abstract class Bird : Animal
    {
        public Bird(string name, decimal weight, decimal wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }

        public decimal WingSize { get; protected set; }

        public override string ToString() => $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; protected set; }
    }
}

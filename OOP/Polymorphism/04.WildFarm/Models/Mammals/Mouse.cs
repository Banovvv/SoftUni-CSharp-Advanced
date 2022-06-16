using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double WeightIncreaseFactor = 0.10f;

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(int quantity)
        {
            Weight += quantity * WeightIncreaseFactor;
        }

        public override void MakeSound(int quantity)
        {
            Console.WriteLine("Squeak");

            Eat(quantity);
        }
    }
}

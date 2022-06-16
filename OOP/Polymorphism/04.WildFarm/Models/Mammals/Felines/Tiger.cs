using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double WeightIncreaseFactor = 1.00f;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override void Eat(int quantity)
        {
            Weight += quantity * WeightIncreaseFactor;
        }

        public override void MakeSound(int quantity)
        {
            Console.WriteLine("ROAR!!!");

            Eat(quantity);
        }
    }
}

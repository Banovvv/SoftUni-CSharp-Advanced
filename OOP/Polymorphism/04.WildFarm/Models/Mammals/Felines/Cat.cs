using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Cat : Feline
    {
        private const double WeightIncreaseFactor = 0.30f;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(int quantity)
        {
            Weight += quantity * WeightIncreaseFactor;
        }

        public override void MakeSound(int quantity)
        {
            Console.WriteLine("Meow");

            Eat(quantity);
        }
    }
}

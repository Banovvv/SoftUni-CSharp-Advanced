using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Owl : Bird
    {
        private const double WeightIncreaseFactor = 0.25f;

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Eat(int quantity)
        {
            Weight += quantity * WeightIncreaseFactor;
        }

        public override void MakeSound(int quantity)
        {
            Console.WriteLine("Hoot Hoot");

            Eat(quantity);
        }
    }
}

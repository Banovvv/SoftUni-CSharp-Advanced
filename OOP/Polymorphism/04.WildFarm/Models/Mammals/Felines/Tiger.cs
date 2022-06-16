using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double WeightIncreaseFactor = 1.00f;
        private IList<string> AcceptedFood = new string[] { "Meat" };

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(string foodType, int quantity)
        {
            if (!AcceptedFood.Contains(foodType))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {foodType}!");
            }

            Weight += quantity * WeightIncreaseFactor;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}

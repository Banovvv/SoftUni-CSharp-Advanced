using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double WeightIncreaseFactor = 0.40f;
        private IList<string> AcceptedFood = new string[] { "Vegetable", "Fruit", "Meat", "Seeds" };

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
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
            Console.WriteLine("Woof!");
        }
    }
}

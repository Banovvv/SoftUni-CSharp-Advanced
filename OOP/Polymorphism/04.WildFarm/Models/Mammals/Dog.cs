using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Dog : Mammal
    {
        private const decimal WeightIncreaseFactor = 0.40M;
        private IList<string> AcceptedFood = new string[] { "Meat" };

        public Dog(string name, decimal weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(string foodType, int quantity)
        {
            if (!AcceptedFood.Contains(foodType))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {foodType}!");
            }

            Weight += quantity * WeightIncreaseFactor;
            FoodEaten += quantity;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}

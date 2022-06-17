using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Owl : Bird
    {
        private const decimal WeightIncreaseFactor = 0.25M;
        private IList<string> AcceptedFood = new string[] { "Meat" };

        public Owl(string name, decimal weight, decimal wingSize) : base(name, weight, wingSize)
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
            Console.WriteLine("Hoot Hoot");
        }
    }
}

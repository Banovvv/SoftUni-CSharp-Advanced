using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Hen : Bird
    {
        private const decimal WeightIncreaseFactor = 0.35M;
        private IList<string> AcceptedFood = new string[] { "Vegetable", "Fruit", "Meat", "Seeds" };

        public Hen(string name, decimal weight, decimal wingSize) : base(name, weight, wingSize)
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
            Console.WriteLine("Cluck");
        }
    }
}

using System;
using System.Collections.Generic;

namespace _04.PizzaCalories.Models
{
    public class Topping
    {
        private string type;
        private double weight;
        private readonly int minWeight = 1;
        private readonly int maxWeight = 50;
        private readonly double baseCaloriesPerGram = 2;
        private readonly List<string> allowedToppings = new List<string>() { "meat", "veggies", "cheese", "sauce" };

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            private set
            {
                if (!ValidTopping(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }
        private double Weight
        {
            get => weight;
            set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [{minWeight}..{maxWeight}].");
                }

                weight = value;
            }
        }
        public double Modifier => CalculateModifier(Type);
        public double TotalCalories => CalculateTotalCalories();

        private double CalculateTotalCalories() => Modifier * Weight * baseCaloriesPerGram;

        private double CalculateModifier(string type)
        {
            if (type.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (type.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (type.ToLower() == "cheese")
            {
                return 1.1;
            }
            else if (type.ToLower() == "sauce")
            {
                return 0.9;
            }
            else
            {
                return 1.0;
            }
        }

        private bool ValidTopping(string value) => allowedToppings.Contains(value.ToLower());
    }
}

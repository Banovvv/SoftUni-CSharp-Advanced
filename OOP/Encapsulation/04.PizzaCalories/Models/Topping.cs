using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories.Models
{
    internal class Topping
    {
        private string type;
        private double weight;
        private double modifier;
        private double totalCalories;
        private readonly int minWeight = 1;
        private readonly int maxWeight = 50;
        private readonly List<string> allowedToppings = new List<string>() { "Meat", "Veggies", "Cheese", "Sauce" };

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
                    throw new ArgumentException($"{Type} weight should be in the range[{minWeight}..{maxWeight}].");
                }

                weight = value;
            }
        }
        public double Modifier
        {
            get => modifier;
            private set
            {
                modifier = CalculateModifier(Type);
            }
        }
        public double TotalCalories
        {
            get => totalCalories;
            private set
            {
                totalCalories = CalculateTotalCalories();
            }
        }

        private double CalculateTotalCalories() => Modifier * Weight;

        private double CalculateModifier(string type)
        {
            if (type == "Meat")
            {
                return 1.1;
            }
            else if (type == "Veggies")
            {
                return 0.8;
            }
            else if (type == "Cheese")
            {
                return 1.1;
            }
            else if (type == "Sauce")
            {
                return 0.9;
            }
            else
            {
                return 1.0;
            }
        }

        private bool ValidTopping(string value) => allowedToppings.Contains(value);
    }
}

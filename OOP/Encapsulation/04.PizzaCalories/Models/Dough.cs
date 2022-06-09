using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories.Models
{
    internal class Dough
    {
        private FlourType flourType;
        private BakingTechnique bakingTechnique;
        private double weight;
        private double totalCalories;
        private readonly int caloriesPerGram = 2;
        private readonly int minWeight = 1;
        private readonly int maxWeight = 200;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            Weight = weight;
            FlourType = new FlourType(flourType);
            BakingTechnique = new BakingTechnique(bakingTechnique);
        }

        private FlourType FlourType { get => flourType; set => flourType = value; }
        private BakingTechnique BakingTechnique { get => bakingTechnique; set => bakingTechnique = value; }
        private double Weight
        {
            get => weight;
            set
            {
                if(value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minWeight}..{maxWeight}].");
                }

                weight = value;
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

        private double CalculateTotalCalories()
        {
            return (Weight * caloriesPerGram) * FlourType.Modifier * BakingTechnique.Modifier;
        }
    }
}

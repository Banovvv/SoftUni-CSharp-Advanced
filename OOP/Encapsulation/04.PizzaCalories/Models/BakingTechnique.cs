using System;
using System.Collections.Generic;

namespace _04.PizzaCalories.Models
{
    internal class BakingTechnique
    {
        private string technique;
        private readonly List<string> allowedBakingTechniques = new List<string>() { "crispy", "chewy", "homemade" };

        public BakingTechnique(string technique)
        {
            Technique = technique;
        }

        public string Technique
        {
            get => technique;
            set
            {
                if (!ValidateTehnique(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                technique = value;
            }
        }
        public double Modifier => CalculateModifier(Technique);

        private double CalculateModifier(string technique)
        {
            if (technique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (technique.ToLower() == "chewy")
            {
                return 1.1;
            }
            else if (technique.ToLower() == "homemade")
            {
                return 1.0;
            }
            else
            {
                return 1.0;
            }
        }

        private bool ValidateTehnique(string value) => allowedBakingTechniques.Contains(value.ToLower());
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories.Models
{
    internal class BakingTechnique
    {
        private string technique;
        private double modifier;
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
        public double Modifier
        {
            get => modifier;
            private set
            {
                modifier = CalculateModifier(Technique);
            }
        }

        private double CalculateModifier(string technique)
        {
            if (technique == "Crispy")
            {
                return 0.9;
            }
            else if (technique == "Chewy")
            {
                return 1.1;
            }
            else if (technique == "Homemade")
            {
                return 1.0;
            }
            else
            {
                return 1.0;
            }
        }

        private bool ValidateTehnique(string value) => allowedBakingTechniques.Contains(value);
    }
}

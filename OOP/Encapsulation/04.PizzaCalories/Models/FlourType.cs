using System;
using System.Collections.Generic;

namespace _04.PizzaCalories.Models
{
    internal class FlourType
    {
        private string type;
        private double modifier;
        private readonly List<string> allowedFlourTypes = new List<string>() { "White", "Wholegrain" };

        public FlourType(string type)
        {
            Type = type;
        }

        public string Type
        {
            get => type;
            set
            {
                if (!ValidateFlourType(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                type = value;
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

        private double CalculateModifier(string type)
        {
            if (type == "White")
            {
                return 1.5;
            }
            else if (type == "Wholegrain")
            {
                return 1.0;
            }
            else
            {
                return 1.0;
            }
        }

        private bool ValidateFlourType(string value) => allowedFlourTypes.Contains(value);
    }
}

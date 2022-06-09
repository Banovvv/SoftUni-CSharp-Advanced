using System;
using System.Collections.Generic;

namespace _04.PizzaCalories.Models
{
    internal class FlourType
    {
        private string type;
        private readonly List<string> allowedFlourTypes = new List<string>() { "white", "wholegrain" };

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

        public double Modifier => CalculateModifier(Type);

        private double CalculateModifier(string type)
        {
            if (type.ToLower() == "white")
            {
                return 1.5;
            }
            else if (type.ToLower() == "wholegrain")
            {
                return 1.0;
            }
            else
            {
                return 1.0;
            }
        }

        private bool ValidateFlourType(string value) => allowedFlourTypes.Contains(value.ToLower());
    }
}

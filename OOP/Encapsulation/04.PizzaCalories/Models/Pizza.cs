using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private double totalCalories;
        private readonly int maxNameLength = 15;
        private readonly int maxNumberOfToppings = 10;
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > maxNameLength)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and {maxNameLength} symbols.");
                }

                name = value;
            }
        }
        public Dough Dough { get => dough; private set => dough = value; }
        public List<Topping> Toppings { get => toppings; private set => toppings = value; }
        public int NumberOfTppings => Toppings.Count;
        public double TotalCalories => CalculateTotalCalories();

        public override string ToString() => $"{Name} - {TotalCalories:F2} Calories.";

        public void AddTopping(Topping topping)
        {
            if (NumberOfTppings + 1 > maxNumberOfToppings)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{maxNumberOfToppings}].");
            }

            toppings.Add(topping);
        }

        private double CalculateTotalCalories()
        {
            return Dough.TotalCalories + Toppings.Sum(x => x.TotalCalories);
        }
    }
}

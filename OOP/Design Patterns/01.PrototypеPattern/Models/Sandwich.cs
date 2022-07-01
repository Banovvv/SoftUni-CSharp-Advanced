using System;

namespace _01.PrototypеPattern.Models
{
    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public string Bread
        {
            get => bread;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                bread = value;
            }
        }
        public string Meat
        {
            get => meat;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                meat = value;
            }
        }
        public string Cheese
        {
            get => cheese;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                cheese = value;
            }
        }
        public string Veggies
        {
            get => veggies;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                veggies = value;
            }
        }

        public override SandwichPrototype Clone()
        {
            Console.WriteLine($"Clonning Sandwitch with ingredients: {GetIngredients()}");
            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredients() => $"{Bread}, {Meat}, {Cheese}, {Veggies}";
    }
}

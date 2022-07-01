using System;

namespace _01.PrototypеPattern.Models
{
    public class Sandwich : SandwichPrototype
    {
        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public string Bread { get; private set; }
        public string Meat { get; private set; }
        public string Cheese { get; private set; }
        public string Veggies { get; private set; }

        public override SandwichPrototype Clone()
        {
            Console.WriteLine($"Clonning Sandwitch with ingredients: {GetIngredients()}");
            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredients() => $"{Bread}, {Meat}, {Cheese}, {Veggies}";
    }
}

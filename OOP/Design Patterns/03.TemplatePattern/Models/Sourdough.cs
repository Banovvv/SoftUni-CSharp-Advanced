using System;

namespace _03.TemplatePattern.Models
{
    public class Sourdough : Bread
    {
        private readonly int _timeToBake = 20;

        public override void Bake()
        {
            Console.WriteLine($"Baking the Sourdough Bread. ({_timeToBake} minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering and mixing ingredients for the Sourdough Bread.");
        }
    }
}

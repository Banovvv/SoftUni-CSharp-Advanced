using System;

namespace _03.TemplatePattern.Models
{
    public class Ciabatta : Bread
    {
        private readonly int _timeToBake = 15;

        public override void Bake()
        {
            Console.WriteLine($"Baking the Ciabatta. ({_timeToBake} minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering and mixing ingredients for the Ciabatta.");
        }
    }
}

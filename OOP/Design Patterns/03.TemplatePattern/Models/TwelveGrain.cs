using System;

namespace _03.TemplatePattern.Models
{
    public class TwelveGrain : Bread
    {
        private readonly int _timeToBake = 25;

        public override void Bake()
        {
            Console.WriteLine($"Baking the 12-Grain Bread. ({_timeToBake} minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering and mixing ingredients for the 12-Grain Bread.");
        }
    }
}

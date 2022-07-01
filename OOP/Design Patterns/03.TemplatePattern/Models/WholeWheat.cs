using System;

namespace _03.TemplatePattern.Models
{
    public class WholeWheat : Bread
    {
        private readonly int _timeToBake = 20;

        public override void Bake()
        {
            Console.WriteLine($"Baking the Whole Wheat Bread. ({_timeToBake} minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering and mixing ingredients for the Whole Wheat Bread.");
        }
    }
}

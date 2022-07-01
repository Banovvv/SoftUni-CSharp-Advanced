using System;
using System.Collections.Generic;
using System.Text;

namespace _03.TemplatePattern.Models
{
    public class Baguette : Bread
    {
        private readonly int _timeToBake = 10;

        public override void Bake()
        {
            Console.WriteLine($"Baking the Baguette. ({_timeToBake} minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering and mixing ingredients for the Baguette.");
        }
    }
}

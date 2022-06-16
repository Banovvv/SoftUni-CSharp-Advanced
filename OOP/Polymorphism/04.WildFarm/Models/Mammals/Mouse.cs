﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}

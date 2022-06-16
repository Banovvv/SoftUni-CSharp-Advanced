using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}

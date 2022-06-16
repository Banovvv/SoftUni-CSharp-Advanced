using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}

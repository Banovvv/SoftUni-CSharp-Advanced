using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}

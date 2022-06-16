using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Interfaces
{
    public interface IAnimal
    {
        void Eat(string foodType, int quantity);
        void MakeSound();
    }
}

using _04.WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, decimal weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; protected set; }
        public decimal Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract void Eat(string foodType, int quantity);

        public abstract void MakeSound();
    }
}

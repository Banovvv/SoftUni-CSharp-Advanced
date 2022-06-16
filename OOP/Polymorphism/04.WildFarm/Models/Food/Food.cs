using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; protected set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage.Interfaces
{
    internal interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyFood();
    }
}

using System;

namespace _02.Composite.Models
{
    public class Gift : GiftBox
    {
        public Gift(string name, int price) : base(name, price)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} with the price: {Price}");

            return Price;
        }
    }
}

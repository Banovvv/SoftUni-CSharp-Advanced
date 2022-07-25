using _02.Composite.Contracts;
using System;
using System.Collections.Generic;

namespace _02.Composite.Models
{
    public class CompositeGift : GiftBox, IGiftOperations
    {
        private IList<GiftBox> _gifts;

        public CompositeGift(string name, int price) : base(name, price)
        {
            _gifts = new List<GiftBox>();
        }

        public void Add(GiftBox gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(GiftBox gift)
        {
            _gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} contains the following products with prices:");

            int totalPrice = 0;

            foreach (var gift in _gifts)
            {
                totalPrice += gift.CalculateTotalPrice();
            }

            return totalPrice;
        }
    }
}

using _02.Composite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Composite.Models
{
    public class CompositeGift : GiftBox, IGiftOperations
    {
        private IList<GiftBox> _gifts;

        public CompositeGift(string name, int price) : base(name, price)
        {
        }

        public void Add(GiftBox gift)
        {
            throw new NotImplementedException();
        }

        public void Remove(GiftBox gift)
        {
            throw new NotImplementedException();
        }

        public override int CalculateTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}

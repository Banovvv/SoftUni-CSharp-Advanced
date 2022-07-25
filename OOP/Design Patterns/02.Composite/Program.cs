using _02.Composite.Models;
using System;

namespace _02.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phone = new Gift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var giftBox = new CompositeGift("Gift box", 0);
            var truckToy = new Gift("Truck toy", 289);
            var soldierToy = new Gift("Soldier toy", 587);
            giftBox.Add(truckToy);
            giftBox.Add(soldierToy);
            var childBox = new CompositeGift("Child box", 0);
            var carToy = new Gift("Car toy", 200);
            childBox.Add(carToy);
            giftBox.Add(childBox);

            Console.WriteLine($"Total price of this gift box is: {giftBox.CalculateTotalPrice()}");
        }
    }
}

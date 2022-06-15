using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private decimal conditioner;
        private readonly decimal tankHoleSize = 0.95M;

        public Truck(decimal fuel, decimal fuelConsumption, decimal tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        protected override decimal Conditioner { get => conditioner; set => conditioner = 1.6M; }

        public override void Refuel(decimal liters)
        {            
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (Fuel + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                Fuel += liters * tankHoleSize;
            }
        }
    }
}

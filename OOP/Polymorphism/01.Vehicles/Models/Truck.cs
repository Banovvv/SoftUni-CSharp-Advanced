using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private readonly decimal conditioner = 1.6M;
        private readonly decimal tankHoleSize = 0.95M;

        public Truck(decimal fuel, decimal fuelConsumption) : base(fuel, fuelConsumption)
        {
        }

        protected override decimal Conditioner => conditioner;

        public override void Refuel(decimal liters)
        {
            Fuel += liters * tankHoleSize;
        }
    }
}

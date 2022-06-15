using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private readonly decimal conditioner = 0.9M;

        public Car(decimal fuel, decimal fuelConsumption, decimal tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        protected override decimal Conditioner => conditioner;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private readonly decimal conditioner = 0.9M;

        public Car(decimal fuel, decimal fuelConsumption) : base(fuel, fuelConsumption)
        {
        }

        protected override decimal Conditioner => conditioner;
    }
}

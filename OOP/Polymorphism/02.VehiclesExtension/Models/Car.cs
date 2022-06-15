using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private decimal conditioner;

        public Car(decimal fuel, decimal fuelConsumption, decimal tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        protected override decimal Conditioner { get => conditioner; set => conditioner = 0.9M; }
    }
}

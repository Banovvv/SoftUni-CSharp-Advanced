using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(decimal fuel, decimal fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }

        public decimal Fuel { get; protected set; }
        public decimal FuelConsumption { get; protected set; }
        protected abstract decimal Conditioner { get; }

        public virtual void Drive(decimal kilometers)
        {            
            if(Fuel - (FuelConsumption + Conditioner) * kilometers >= 0)
            {
                Fuel -= (FuelConsumption + Conditioner) * kilometers;
                Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(decimal liters)
        {
            Fuel += liters;
        }

        public override string ToString() => $"{this.GetType().Name}: {Fuel:F2}";
    }
}

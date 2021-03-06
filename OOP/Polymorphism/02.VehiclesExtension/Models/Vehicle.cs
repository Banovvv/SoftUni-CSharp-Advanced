using System;

namespace _02.VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected decimal fuel;

        public Vehicle(decimal fuel, decimal fuelConsumption, decimal tankCapacity)
        {
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            Fuel = fuel;
        }

        public decimal Fuel
        {
            get => fuel;
            protected set
            {
                if (value > TankCapacity)
                {
                    fuel = 0;
                }
                else
                {
                    fuel = value;
                }
            }
        }
        public decimal FuelConsumption { get; protected set; }
        public decimal TankCapacity { get; protected set; }
        protected virtual decimal Conditioner { get; }

        public void Drive(decimal kilometers)
        {
            if (Fuel - (FuelConsumption + Conditioner) * kilometers >= 0)
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
                Fuel += liters;
            }
        }

        public override string ToString() => $"{this.GetType().Name}: {Fuel:F2}";
    }
}

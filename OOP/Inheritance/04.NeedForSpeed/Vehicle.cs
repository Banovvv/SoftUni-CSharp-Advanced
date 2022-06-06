using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        //Create a base class Vehicle. It should contain the following members:
        //    ⦁	A constructor that accepts the following parameters: int horsePower, double fuel
        //    ⦁	DefaultFuelConsumption – double 
        //    ⦁	FuelConsumption – virtual double
        //    ⦁	Fuel – double
        //    ⦁	HorsePower – int
        //    ⦁	virtual void Drive(double kilometers)
        //    ⦁	The Drive method should have a functionality to reduce the Fuel based on the traveled kilometers.
        //The default fuel consumption for Vehicle is 1.25. Some of the classes have different default fuel consumption values:
        //    ⦁	SportCar – DefaultFuelConsumption = 10
        //    ⦁	RaceMotorcycle – DefaultFuelConsumption = 8
        //    ⦁	Car – DefaultFuelConsumption = 3

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption
        {
            get
            {
                return FuelConsumption;
            }
            set
            {
                FuelConsumption = DefaultFuelConsumption;
            }
        }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.DefaultFuelConsumption;
        }
    }
}

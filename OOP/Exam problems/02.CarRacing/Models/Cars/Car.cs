using CarRacing.Models.Cars.Contracts;
using System;

namespace CarRacing.Models.Cars
{
    public abstract class Car : ICar
    {
        private string vin;
        private string make;
        private string model;
        private int horsePower;
        private double fuelAvailable;
        private double fuelConsumptionPerRace;

        public string Make
        {
            get => make;
            protected set
            {
                make = value;
            }
        }

        public string Model
        {
            get => model;
            protected set
            {
                model = value;
            }
        }

        public string VIN
        {
            get => vin;
            protected set
            {
                vin = value;
            }
        }

        public int HorsePower
        {
            get => horsePower;
            protected set
            {
                horsePower = value;
            }
        }

        public double FuelAvailable
        {
            get => fuelAvailable;
            protected set
            {
                fuelAvailable = value;
            }
        }

        public double FuelConsumptionPerRace
        {
            get => fuelConsumptionPerRace;
            protected set
            {
                fuelConsumptionPerRace = value;
            }
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}

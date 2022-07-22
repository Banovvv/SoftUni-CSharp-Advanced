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

        public Car(string make, string model, string vin, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            Make = make;
            Model = model;
            VIN = vin;
            HorsePower = horsePower;
            FuelAvailable = fuelAvailable;
            FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        public string Make
        {
            get => make;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Car make cannot be null or empty.");
                }

                make = value;
            }
        }

        public string Model
        {
            get => model;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Car model cannot be null or empty.");
                }

                model = value;
            }
        }

        public string VIN
        {
            get => vin;
            protected set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException("Car VIN must be exactly 17 characters long.");
                }

                vin = value;
            }
        }

        public int HorsePower
        {
            get => horsePower;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Horse power cannot be below 0.");
                }

                horsePower = value;
            }
        }

        public double FuelAvailable
        {
            get => fuelAvailable;
            protected set
            {
                if (value < 0)
                {
                    value = 0;
                }

                fuelAvailable = value;
            }
        }

        public double FuelConsumptionPerRace
        {
            get => fuelConsumptionPerRace;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel consumption cannot be below 0.");
                }

                fuelConsumptionPerRace = value;
            }
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}

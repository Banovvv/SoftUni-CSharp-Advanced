using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            #region PopulateList
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carArgs = Console.ReadLine().Split();

                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1], CultureInfo.InvariantCulture);
                double fuelConsumption = double.Parse(carArgs[2], CultureInfo.InvariantCulture);

                if (cars.Where(x => x.Model == model).FirstOrDefault() == null)
                {
                    cars.Add(new Car(model, fuelAmount, fuelConsumption));
                }
            }
            #endregion

            #region Actions
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                string model = commandArgs[1];
                int distance = int.Parse(commandArgs[2]);

                Car currentCar = cars.Where(x=>x.Model==model).FirstOrDefault();

                if (currentCar != null)
                {
                    currentCar.Drive(distance);
                }

                command = Console.ReadLine();
            }
            #endregion

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
            TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public int TravelledDistance { get; set; }

        public void Drive(int kilometers)
        {
            // "Insufficient fuel for the drive"
            double fuelNeeded = kilometers * FuelConsumptionPerKilometer;

            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}

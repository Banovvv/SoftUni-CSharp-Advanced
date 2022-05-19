using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfLine; i++)
            {
                string[] carArgs = Console.ReadLine().Split();

                cars.Add(new Car(carArgs[0], int.Parse(carArgs[1]), int.Parse(carArgs[2]), int.Parse(carArgs[3]), carArgs[4], double.Parse(carArgs[5]), int.Parse(carArgs[6]), double.Parse(carArgs[7]), int.Parse(carArgs[8]), double.Parse(carArgs[9]), int.Parse(carArgs[10]), double.Parse(carArgs[11]), int.Parse(carArgs[12])));
            }

            string cargoType = Console.ReadLine();

            PrintCars(cars, cargoType);
        }

        static void PrintCars(List<Car> cars, string cargoType)
        {
            if (cargoType == "fragile")
            {
                List<Car> carsToPrint = cars.Where(x => x.Cargo.Type == cargoType && x.Tires.Any(t => t.Pressure < 1)).ToList();
                PrintIndividualCars(carsToPrint);
            }
            else if (cargoType == "flammable")
            {
                List<Car> carsToPrint = cars.Where(x => x.Cargo.Type == cargoType && x.Engine.Power > 250).ToList();
                PrintIndividualCars(carsToPrint);
            }
        }

        static void PrintIndividualCars(List<Car> carsToPrint)
        {
            foreach (Car car in carsToPrint)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}

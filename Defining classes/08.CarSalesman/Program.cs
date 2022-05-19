using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Engines
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string engineModel = engineArgs[0];
                int enginePower = int.Parse(engineArgs[1]);

                if (engineArgs.Length == 3)
                {
                    if (int.TryParse(engineArgs[2], out int engineDisplacement))
                    {
                        engines.Add(new Engine(engineModel, enginePower, engineDisplacement));
                    }
                    else
                    {
                        string engineEfficiency = engineArgs[2];
                        engines.Add(new Engine(engineModel, enginePower, engineEfficiency));
                    }

                }
                else if (engineArgs.Length == 4)
                {
                    int engineDisplacement = int.Parse(engineArgs[2]);
                    string engineEfficiency = engineArgs[3];

                    engines.Add(new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency));
                }
                else
                {
                    engines.Add(new Engine(engineModel, enginePower));
                }
            }
            #endregion

            #region Cards
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                Engine engine = engines.Where(x => x.Model == carArgs[1]).First();

                if (carArgs.Length == 3)
                {
                    if (int.TryParse(carArgs[2], out int weight))
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = carArgs[2];
                        cars.Add(new Car(model, engine, color));
                    }

                }
                else if (carArgs.Length == 4)
                {
                    int weight = int.Parse(carArgs[2]);
                    string color = carArgs[3];

                    cars.Add(new Car(model, engine, weight, color));
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }
            #endregion

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

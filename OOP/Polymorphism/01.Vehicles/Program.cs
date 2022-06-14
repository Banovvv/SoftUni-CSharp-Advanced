using _01.Vehicles.Models;
using System;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carParams = Console.ReadLine().Split();
            string[] truckParams = Console.ReadLine().Split();

            Car car = new Car(decimal.Parse(carParams[1]), decimal.Parse(carParams[2]));
            Truck truck = new Truck(decimal.Parse(truckParams[1]), decimal.Parse(truckParams[2]));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                string vehicle = commandArgs[1];
                decimal param = decimal.Parse(commandArgs[2]);

                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        car.Drive(param);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Drive(param);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(param);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(param);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;
            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    int currentGreenLight = greenLight;

                    while (cars.Any() && currentGreenLight > 0)
                    {
                        string currentCar = cars.Dequeue();

                        if (currentGreenLight - currentCar.Length >= 0)
                        {
                            currentGreenLight -= currentCar.Length;
                            totalCarsPassed++;
                            continue;
                        }

                        if (currentGreenLight + freeWindow - currentCar.Length >= 0)
                        {
                            currentGreenLight = 0;
                            totalCarsPassed++;
                            continue;
                        }

                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {currentCar[currentGreenLight + freeWindow]}.");
                        return;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}

using _04.WildFarm.Interfaces;
using _04.WildFarm.Models;
using System;
using System.Collections.Generic;

namespace _04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                string[] animalArgs = command.Split();
                string[] foodArgs = Console.ReadLine().Split();

                string type = animalArgs[0];
                string name = animalArgs[1];
                decimal weight = decimal.Parse(animalArgs[2]);

                switch (type)
                {
                    case "Cat":
                        {
                            string livingRegion = animalArgs[3];
                            string breed = animalArgs[4];

                            animals.Add(new Cat(name, weight, livingRegion, breed));

                            break;
                        }
                    case "Tiger":
                        {
                            string livingRegion = animalArgs[3];
                            string breed = animalArgs[4];

                            animals.Add(new Tiger(name, weight, livingRegion, breed));

                            break;
                        }
                    case "Hen":
                        {
                            decimal wingSize = decimal.Parse(animalArgs[3]);

                            animals.Add(new Hen(name, weight, wingSize));

                            break;
                        }
                    case "Owl":
                        {
                            decimal wingSize = decimal.Parse(animalArgs[3]);

                            animals.Add(new Owl(name, weight, wingSize));

                            break;
                        }
                    case "Dog":
                        {
                            string livingRegion = animalArgs[3];

                            animals.Add(new Dog(name, weight, livingRegion));

                            break;
                        }
                    case "Mouse":
                        {
                            string livingRegion = animalArgs[3];

                            animals.Add(new Mouse(name, weight, livingRegion));

                            break;
                        }
                    default:
                        throw new ArgumentException("Invalid Animal Type!");
                }

                string foodType = foodArgs[0];
                int quantity = int.Parse(foodArgs[1]);

                IAnimal animal = animals[counter];

                animal.MakeSound();

                try
                {
                    animal.Eat(foodType, quantity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                counter++;
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}

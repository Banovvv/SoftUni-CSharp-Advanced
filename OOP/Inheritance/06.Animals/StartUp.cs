using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string animalType = Console.ReadLine();

                if(animalType == "Beast!")
                {
                    break;
                }

                string[] animalArgs = Console.ReadLine().Split();

                AddAnimal(animals, animalType, animalArgs);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void AddAnimal(List<Animal> animals, string animalType, string[] animalArgs)
        {
            string name = animalArgs[0];
            int age = int.Parse(animalArgs[1]);
            string gender = animalArgs[2];

            try
            {
                if (animalType == "Cat")
                {
                    animals.Add(new Cat(name, age, gender));
                }
                else if (animalType == "Tomcat")
                {
                    animals.Add(new Tomcat(name, age));
                }
                else if (animalType == "Kitten")
                {
                    animals.Add(new Kitten(name, age));
                }
                else if (animalType == "Dog")
                {
                    animals.Add(new Dog(name, age, gender));
                }
                else if (animalType == "Frog")
                {
                    animals.Add(new Frog(name, age, gender));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

using _06.FoodShortage.Interfaces;
using _06.FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfBuyers = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < numberOfBuyers; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                if (commandArgs.Length == 3)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string group = commandArgs[2];

                    var buyer = new Rebel(name, age, group);

                    if (buyers.FirstOrDefault(x => x.Name == name) == null)
                    {
                        buyers.Add(buyer);
                    }
                }
                else if (commandArgs.Length == 4)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string id = commandArgs[2];
                    string birthdate = commandArgs[3];

                    var buyer = new Citizen(name, age, id, birthdate);

                    if (buyers.FirstOrDefault(x => x.Name == name) == null)
                    {
                        buyers.Add(buyer);
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var buyer = buyers.FirstOrDefault(x => x.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}

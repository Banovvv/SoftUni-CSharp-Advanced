using _05.BirthdayCelebrations.Interfaces;
using _05.BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IBirthable> citizensWithBirthday = new List<IBirthable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                if (command == "Citizen")
                {
                    string name = commandArgs[1];
                    int age = int.Parse(commandArgs[2]);
                    string id = commandArgs[3];
                    string birthdate = commandArgs[4];

                    citizensWithBirthday.Add(new Citizen(name, age, id, birthdate));
                }
                else if (command == "Pet")
                {
                    string name = commandArgs[1];
                    string birthdate = commandArgs[2];

                    citizensWithBirthday.Add(new Pet(name, birthdate));
                }
            }

            string year = Console.ReadLine();

            foreach (var citizen in citizensWithBirthday)
            {
                if (citizen.HasBirthday(year))
                {
                    Console.WriteLine(citizen.Birthdate);
                }
            }
        }
    }
}

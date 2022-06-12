using _04.BorderControl.Interfaces;
using _04.BorderControl.Models;
using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ICitizen> citizens = new List<ICitizen>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] commandArgs = command.Split();

                if (commandArgs.Length == 2)
                {
                    string model = commandArgs[0];
                    string id = commandArgs[1];

                    citizens.Add(new Robot(model, id));
                }
                else if (commandArgs.Length == 3)
                {
                    string model = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string id = commandArgs[2];

                    citizens.Add(new Citizen(model, age, id));
                }
            }

            string idEnding = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                if (citizen.IsIdFake(idEnding))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}

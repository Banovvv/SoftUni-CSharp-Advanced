using _09.ExplicitInterfaces.Interfaces;
using _09.ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;

namespace _09.ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] commandArgs = command.Split();

                string name = commandArgs[0];
                string country = commandArgs[1];
                int age = int.Parse(commandArgs[2]);

                citizens.Add(new Citizen(name, country, age));
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}

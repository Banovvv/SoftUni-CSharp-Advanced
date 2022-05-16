using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Remove")
                {
                    string condition = commandArgs[1];
                    string parameter = commandArgs[2];

                    guests = RemoveGuests(guests, condition, parameter);
                }
                else if (action == "Double")
                {
                    string condition = commandArgs[1];
                    string parameter = commandArgs[2];

                    guests = DoubleGuests(guests, condition, parameter);
                }

                command = Console.ReadLine();
            }

            if (guests.Any())
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static List<string> RemoveGuests(List<string> guests, string condition, string parameter)
        {
            List<string> newList = new List<string>();

            foreach (string guest in guests)
            {
                if(condition == "StartsWith")
                {
                    if (!guest.StartsWith(parameter,StringComparison.InvariantCultureIgnoreCase))
                    {
                        newList.Add(guest);
                    }
                }
                else if (condition == "EndsWith")
                {
                    if (!guest.EndsWith(parameter))
                    {
                        newList.Add(guest);
                    }
                }
                else if (condition == "Length")
                {
                    if (guest.Length != int.Parse(parameter))
                    {
                        newList.Add(guest);
                    }
                }
            }

            return newList;
        }

        private static List<string> DoubleGuests(List<string> guests, string condition, string parameter)
        {
            List<string> newList = new List<string>();

            int position = 0;

            foreach (string guest in guests)
            {
                newList.Insert(position, guest);

                if (condition == "StartsWith")
                {
                    if (guest.StartsWith(parameter))
                    {
                        newList.Insert(position, guest);
                    }
                }
                else if (condition == "EndsWith")
                {
                    if (guest.EndsWith(parameter))
                    {
                        newList.Insert(position, guest);
                    }
                }
                else if (condition == "Length")
                {
                    if (guest.Length == int.Parse(parameter))
                    {
                        newList.Insert(position, guest);
                    }
                }

                position++;
            }

            return newList;
        }
    }
}

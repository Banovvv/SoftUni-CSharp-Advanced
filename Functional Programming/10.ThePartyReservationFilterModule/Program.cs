using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Print")
                {
                    break;
                }

                string[] commandArgs = command.Split(';');
                string action = commandArgs[0];

                UpdateFilters(filters, action, commandArgs);
            }

            foreach(var filter in filters)
            {
                string[] filterArgs = filter.Split(';');
                string filterAction = filterArgs[0];
                string filterParam = filterArgs[1];

                if (filterAction == "Starts with")
                {
                    invitations = invitations.Where(x=> !x.StartsWith(filterParam)).ToList();
                }
                else if (filterAction == "Ends with")
                {
                    invitations = invitations.Where(x => !x.EndsWith(filterParam)).ToList();
                }
                else if (filterAction == "Length")
                {
                    invitations = invitations.Where(x => x.Length != int.Parse(filterParam)).ToList();
                }
                else if (filterAction == "Contains")
                {
                    invitations = invitations.Where(x => !x.Contains(filterParam)).ToList();
                }
            }

            Console.WriteLine(string.Join(" ", invitations));
        }

        static void UpdateFilters(List<string> filters, string action, string[] commandArgs)
        {
            if (action == "Add filter")
            {
                string filterType = commandArgs[1];
                string filterParameter = commandArgs[2];
                filters.Add($"{filterType};{filterParameter}");
            }
            else if (action == "Remove filter")
            {
                string filterType = commandArgs[1];
                string filterParameter = commandArgs[2];
                filters.Remove($"{filterType};{filterParameter}");
            }
        }
    }
}

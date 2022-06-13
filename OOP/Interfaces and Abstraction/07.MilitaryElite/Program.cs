using System;

namespace _07.MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                string[] commandArgs = command.Split();

                string soldierType = commandArgs[0];

                int id = int.Parse(commandArgs[1]);
                string firstName = commandArgs[2];
                string lastName = commandArgs[3];

                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(commandArgs[4]);
                }
                else if (soldierType == "LeutenantGeneral")
                {
                    decimal salary = decimal.Parse(commandArgs[4]);
                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(commandArgs[4]);
                }
                else if (soldierType == "Commando")
                {
                    
                    decimal salary = decimal.Parse(commandArgs[4]);
                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(commandArgs[4]);
                }
            }
        }
    }
}

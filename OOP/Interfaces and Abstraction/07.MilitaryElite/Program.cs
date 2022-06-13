using _07.MilitaryElite.Models;
using _07.MilitaryElite.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
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

                    soldiers.Add(new Private(id, firstName, lastName, salary));
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(commandArgs[4]);
                    int[] privateIds = commandArgs.Skip(5).Select(int.Parse).ToArray();

                    var privatesToAdd = soldiers.Where(x => privateIds.Contains(x.Id) && x.GetType() == typeof(Private)).OrderByDescending(x=>x.Id);

                    soldiers.Add(new LieutenantGeneral(id, firstName, lastName, salary, privatesToAdd));
                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(commandArgs[4]);
                    string corps = commandArgs[5];
                    string[] repairParams = commandArgs.Skip(6).ToArray();

                    List<Repair> repairs = new List<Repair>();

                    for (int i = 0; i < repairParams.Length - 1; i += 2)
                    {
                        string partName = repairParams[i];
                        int hoursWorked = int.Parse(repairParams[i + 1]);

                        repairs.Add(new Repair(partName, hoursWorked));
                    }

                    try
                    {
                        soldiers.Add(new Engineer(id, firstName, lastName, salary, corps, repairs));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(commandArgs[4]);
                    string corps = commandArgs[5];
                    string[] misionParams = commandArgs.Skip(6).ToArray();

                    List<Mission> missions = new List<Mission>();

                    for (int i = 0; i < misionParams.Length - 1; i += 2)
                    {
                        string partName = misionParams[i];
                        string state = misionParams[i + 1];

                        try
                        {
                            missions.Add(new Mission(partName, state));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    try
                    {
                        soldiers.Add(new Commando(id, firstName, lastName, salary, corps, missions));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(commandArgs[4]);

                    soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}

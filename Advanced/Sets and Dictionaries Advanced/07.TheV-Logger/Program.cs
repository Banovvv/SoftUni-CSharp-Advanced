using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    public class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            List<Vlogger> Vloggers = new List<Vlogger>();

            while (command != "Statistics")
            {
                string[] args = command.Split();

                string action = args[1];

                if (action == "joined")
                {
                    string vlogger = args[0];

                    Vlogger currentVlogger = Vloggers.Where(x => x.Name == vlogger).FirstOrDefault();

                    if (currentVlogger == null)
                    {
                        Vloggers.Add(new Vlogger(vlogger));
                    }
                }
                else if (action == "followed")
                {
                    string vloggerOne = args[0];
                    string vloggerTwo = args[2];

                    Vlogger currentVloggerOne = Vloggers.Where(x => x.Name == vloggerOne).FirstOrDefault();
                    Vlogger currentVloggerTwo = Vloggers.Where(x => x.Name == vloggerTwo).FirstOrDefault();

                    if (currentVloggerOne != null && currentVloggerTwo != null)
                    {
                        if (currentVloggerOne.Name != currentVloggerTwo.Name)
                        {
                            if (!currentVloggerTwo.Followers.Contains(currentVloggerOne.Name))
                            {
                                currentVloggerTwo.Followers.Add(currentVloggerOne.Name);
                                currentVloggerOne.Following.Add(currentVloggerTwo.Name);
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (Vloggers.Any())
            {
                Vloggers = Vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following.Count).ToList();

                Console.WriteLine($"The V-Logger has a total of {Vloggers.Count} vloggers in its logs.");

                for (int i = 1; i <= Vloggers.Count; i++)
                {
                    Vlogger currentVlogger = Vloggers[i - 1];

                    Console.WriteLine($"{i}. {currentVlogger.Name} : {currentVlogger.Followers.Count} followers, {currentVlogger.Following.Count} following");

                    if (i == 1)
                    {
                        foreach (var follower in currentVlogger.Followers.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }
                }
            }
        }
    }

    public class Vlogger
    {
        public Vlogger(string vlogger)
        {
            Name = vlogger;
            Followers = new List<string>();
            Following = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Followers { get; set; }
        public List<string> Following { get; set; }
    }
}

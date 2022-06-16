using _03.Raiding.Interfaces;
using _03.Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            List<ICaster> heroes = new List<ICaster>();
            HeroFactory factory = new HeroFactory();

            while(heroes.Count != numberOfHeroes)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    heroes.Add(factory.CreateHero(name, type));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            Raid(heroes, bossPower);
        }

        private static void Raid(List<ICaster> heroes, int bossPower)
        {
            foreach (ICaster hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int heroesPower = heroes.Sum(x => x.Power);

            if(heroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}

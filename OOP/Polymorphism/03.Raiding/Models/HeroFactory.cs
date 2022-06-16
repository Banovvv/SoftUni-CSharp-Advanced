using _03.Raiding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Models
{
    public class HeroFactory : IHeroFactory
    {
        public ICaster CreateHero(string name, string type)
        {
            ICaster hero = null;

            if(type == "Druid")
            {
                hero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }

            return hero;
        }
    }
}

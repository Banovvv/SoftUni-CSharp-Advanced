using _03.Raiding.Interfaces;

namespace _03.Raiding.Models
{
    public abstract class BaseHero : ICaster
    {
        public BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; protected set; }
        public int Power { get; protected set; }

        public abstract string CastAbility();
    }
}

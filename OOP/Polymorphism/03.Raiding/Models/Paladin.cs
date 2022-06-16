namespace _03.Raiding.Models
{
    public class Paladin : BaseHero
    {
        private static readonly int power = 100;

        public Paladin(string name) : base(name, power)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} healed for {Power}";
    }
}

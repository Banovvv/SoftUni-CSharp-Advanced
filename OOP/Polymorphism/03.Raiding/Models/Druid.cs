namespace _03.Raiding.Models
{
    public class Druid : BaseHero
    {
        private static readonly int power = 80;

        public Druid(string name) : base(name, power)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} healed for {Power}";
    }
}

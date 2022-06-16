namespace _03.Raiding.Models
{
    internal class Rogue : BaseHero
    {
        private static readonly int power = 80;

        public Rogue(string name) : base(name, power)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}

namespace _03.Raiding.Models
{
    internal class Warrior : BaseHero
    {
        private static readonly int power = 100;

        public Warrior(string name) : base(name, power)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}

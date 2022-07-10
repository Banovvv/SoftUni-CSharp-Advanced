namespace FakeAxeAndDummy.Interfaces
{
    public interface IHero
    {
        public int Health { get; }
        public IWeapon Weapon { get; }
        public void Attack(ITarget target);
    }
}

namespace _03.Raiding.Interfaces
{
    public interface IHeroFactory
    {
        ICaster CreateHero(string name, string type);
    }
}

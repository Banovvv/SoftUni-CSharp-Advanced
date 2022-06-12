namespace _06.FoodShortage.Interfaces
{
    public interface ICitizen
    {
        string Id { get; }
        bool IsIdFake(string idEnding);
    }
}

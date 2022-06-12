namespace _05.BirthdayCelebrations.Interfaces
{
    public interface ICitizen
    {
        string Id { get; }
        bool IsIdFake(string idEnding);
    }
}

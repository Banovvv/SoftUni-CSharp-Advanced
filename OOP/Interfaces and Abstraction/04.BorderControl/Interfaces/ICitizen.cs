namespace _04.BorderControl.Interfaces
{
    public interface ICitizen
    {
        string Id { get; }
        bool IsIdFake(string idEnding);
    }
}

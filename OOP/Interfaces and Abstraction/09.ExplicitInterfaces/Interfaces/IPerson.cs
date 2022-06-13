namespace _09.ExplicitInterfaces.Interfaces
{
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }

        string GetName();
    }
}

namespace _05.BirthdayCelebrations.Interfaces
{
    internal interface IBirthable
    {
        string Birthdate { get; }
        bool HasBirthday(string year);
    }
}

namespace _06.FoodShortage.Interfaces
{
    internal interface IBirthable
    {
        string Birthdate { get; }
        bool HasBirthday(string year);
    }
}

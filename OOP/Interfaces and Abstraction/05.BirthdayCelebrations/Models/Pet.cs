using _05.BirthdayCelebrations.Interfaces;

namespace _05.BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public string Birthdate { get; private set; }

        public bool HasBirthday(string year)
        {
            if (Birthdate.EndsWith(year))
            {
                return true;
            }

            return false;
        }
    }
}

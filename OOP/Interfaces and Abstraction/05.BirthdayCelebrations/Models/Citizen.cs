using _05.BirthdayCelebrations.Interfaces;

namespace _05.BirthdayCelebrations.Models
{
    public class Citizen : ICitizen, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public bool HasBirthday(string year)
        {
            if (Birthdate.EndsWith(year))
            {
                return true;
            }

            return false;
        }

        public bool IsIdFake(string idEnding)
        {
            if (Id.EndsWith(idEnding))
            {
                return true;
            }

            return false;
        }
    }
}

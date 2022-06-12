using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Citizen : ICitizen, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }

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

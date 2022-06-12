using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

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

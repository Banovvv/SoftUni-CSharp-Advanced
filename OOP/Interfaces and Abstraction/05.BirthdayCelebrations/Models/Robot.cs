using _05.BirthdayCelebrations.Interfaces;

namespace _05.BirthdayCelebrations.Models
{
    public class Robot : ICitizen
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }
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

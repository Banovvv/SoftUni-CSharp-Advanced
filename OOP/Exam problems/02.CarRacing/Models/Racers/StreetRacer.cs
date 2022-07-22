using CarRacing.Models.Cars.Contracts;

namespace CarRacing.Models.Racers
{
    public class StreetRacer : Racer
    {
        private static readonly string racingBehavior = "aggressive";
        private static readonly int drivingExperience = 10;

        public StreetRacer(string username, ICar car) : base(username, racingBehavior, drivingExperience, car)
        {
        }
    }
}

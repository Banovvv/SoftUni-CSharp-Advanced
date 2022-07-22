using CarRacing.Models.Cars.Contracts;

namespace CarRacing.Models.Racers
{
    public class ProfessionalRacer : Racer
    {
        private static readonly string racingBehavior = "strict";
        private static readonly int drivingExperience = 30;

        public ProfessionalRacer(string username, ICar car) : base(username, racingBehavior, drivingExperience, car)
        {
        }
    }
}

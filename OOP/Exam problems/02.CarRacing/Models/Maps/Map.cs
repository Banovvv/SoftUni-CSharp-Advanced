using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return "Race cannot be completed because both racers are not available!";
            }

            if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }

            if (!racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }

            return $"{racerOne.Username} has just raced against {racerTwo.Username}! {GetWinner(racerOne, racerTwo)} is the winner!";
        }

        private string GetWinner(IRacer racerOne, IRacer racerTwo)
        {
            if (CalculateChanceOfWinning(racerOne) > CalculateChanceOfWinning(racerTwo))
            {
                return racerOne.Username;
            }
            else
            {
                return racerTwo.Username;
            }
        }

        private double CalculateChanceOfWinning(IRacer racer)
        {
            double racingBehaviorMultiplier = CalculateRacingBehaviorMultiplier(racer);

            return racer.Car.HorsePower * racer.DrivingExperience * racingBehaviorMultiplier;
        }

        private double CalculateRacingBehaviorMultiplier(IRacer racer)
        {
            if (racer.RacingBehavior == "strict")
            {
                return 1.2;
            }

            if (racer.RacingBehavior == "aggressive")
            {
                return 1.1;
            }

            return 1;
        }
    }
}

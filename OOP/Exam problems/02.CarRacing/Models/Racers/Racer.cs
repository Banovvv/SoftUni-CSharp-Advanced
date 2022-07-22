using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Text;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    {
        private string username;
        private string racingBehavior;
        private int drivingExperience;
        private readonly int drivingExperienceMinValue = 0;
        private readonly int drivingExperienceMaxValue = 100;
        private ICar car;

        public Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            Username = username;
            RacingBehavior = racingBehavior;
            DrivingExperience = drivingExperience;
            Car = car;
        }

        public string Username
        {
            get => username; protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username cannot be null or empty.");
                }

                username = value;
            }
        }

        public string RacingBehavior
        {
            get => racingBehavior;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Racing behavior cannot be null or empty.");
                }

                racingBehavior = value;
            }
        }

        public int DrivingExperience
        {
            get => drivingExperience;
            protected set
            {
                if (value < drivingExperienceMinValue || value > drivingExperienceMaxValue)
                {
                    throw new ArgumentException($"Racer driving experience must be between {drivingExperienceMinValue} and {drivingExperienceMaxValue}.");
                }

                drivingExperience = value;
            }
        }

        public ICar Car
        {
            get => car;
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentException("Car cannot be null or empty.");
                }

                car = value;
            }
        }

        public bool IsAvailable()
        {
            if (car.FuelAvailable - car.FuelConsumptionPerRace < 0)
            {
                return false;
            }

            return true;
        }

        public void Race()
        {
            // Drive the car
            car.Drive();

            // Increase XP
            if (GetType().Name == "ProfessionalRacer")
            {
                DrivingExperience += 10;
            }
            else if (GetType().Name == "StreetRacer")
            {
                DrivingExperience += 5;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}: {Username}");
            sb.AppendLine($"--Driving behavior: {RacingBehavior}");
            sb.AppendLine($"--Driving experience: {DrivingExperience}");
            sb.AppendLine($"--Car: {Car.Make} {Car.Model} ({Car.VIN})");

            return sb.ToString().Trim();
        }
    }
}

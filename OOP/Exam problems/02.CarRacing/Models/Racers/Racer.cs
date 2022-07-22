using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;

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
            throw new NotImplementedException();
        }

        public void Race()
        {
            throw new NotImplementedException();
        }
    }
}

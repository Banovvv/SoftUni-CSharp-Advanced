using Formula1.Models.Contracts;
using System;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;

        public Pilot(string fullName)
        {
            FullName = fullName;
            CanRace = false;
            NumberOfWins = 0;
        }

        public string FullName
        {
            get => fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid pilot model: {value}.");
                }

                fullName = value;
            }
        }

        public bool CanRace { get; private set; }

        public IFormulaOneCar Car
        {
            get => car;
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot car can not be null.");
                }
                car = value;
            }
        }

        public int NumberOfWins { get; private set; }

        public void AddCar(IFormulaOneCar car)
        {
            Car = car;
            CanRace = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }

        public override string ToString() => $"Pilot {FullName} has {NumberOfWins} wins.";

    }
}

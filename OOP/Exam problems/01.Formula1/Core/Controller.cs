using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;

        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot currentPilot = pilotRepository.Models.Where(x => x.FullName == pilotName).FirstOrDefault();

            if (currentPilot == null || currentPilot.CanRace)
            {
                throw new InvalidOperationException($"Pilot {pilotName} does not exist or has a car.");
            }

            IFormulaOneCar currentCar = carRepository.Models.Where(x => x.Model == carModel).FirstOrDefault();

            if (currentCar == null)
            {
                throw new NullReferenceException($"Car {carModel} does not exist.");
            }

            currentPilot.AddCar(currentCar);

            return $"Pilot {pilotName} will drive a {currentCar.GetType()} {currentCar.Model} car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IRace currentRace = raceRepository.Models.Where(x => x.RaceName == raceName).FirstOrDefault();

            if (currentRace == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            IPilot currentPilot = pilotRepository.Models.Where(x => x.FullName == pilotFullName).FirstOrDefault();

            if (currentPilot == null || !currentPilot.CanRace || currentRace.Pilots.Where(x => x.FullName == pilotFullName).Any())
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }

            currentRace.AddPilot(currentPilot);

            return $"Pilot {pilotFullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (carRepository == null)
            {
                carRepository = new FormulaOneCarRepository();
            }

            if (carRepository.Models.Where(x => x.Model == model).Any())
            {
                throw new InvalidOperationException($"Formula one car {model} is already created.");
            }

            if (type != "Ferrari")
            {
                carRepository.Models.Add(new Ferrari(model, horsepower, engineDisplacement));
            }
            else if (type != "Williams")
            {
                carRepository.Models.Add(new Williams(model, horsepower, engineDisplacement));
            }
            else
            {
                throw new InvalidOperationException($"Formula one car type {type} is not valid.");
            }

            return $"Car {type}, model {model} is created.";
        }

        public string CreatePilot(string fullName)
        {
            if (pilotRepository == null)
            {
                pilotRepository = new PilotRepository();
            }

            if (pilotRepository.Models.Where(x => x.FullName == fullName).Any())
            {
                throw new InvalidOperationException($"Pilot {fullName} is already created.");
            }

            pilotRepository.Models.Add(new Pilot(fullName));

            return $"Pilot {fullName} is created.";
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            if (raceRepository == null)
            {
                raceRepository = new RaceRepository();
            }

            if (raceRepository.Models.Where(x => x.RaceName == raceName).Any())
            {
                throw new InvalidOperationException($"Race {raceName} is already created.");
            }

            return $"Race {raceName} is created.";
        }

        public string PilotReport()
        {
            throw new NotImplementedException();
        }

        public string RaceReport()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var race in raceRepository.Models.Where(x => x.TookPlace))
            {
                sb.AppendLine(race.RaceInfo());
            }

            return sb.ToString().Trim();
        }

        public string StartRace(string raceName)
        {
            IRace currentRace = raceRepository.FindByName(raceName);

            if (currentRace == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            if (currentRace.Pilots.Count() < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than three participants.");
            }

            if (currentRace.TookPlace)
            {
                throw new InvalidOperationException($"Can not execute race {raceName}.");
            }

            var topPilots = currentRace.Pilots.OrderBy(x => x.Car.RaceScoreCalculator(currentRace.NumberOfLaps)).ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Pilot {topPilots[0].FullName} wins the {raceName} race.");
            sb.AppendLine($"Pilot {topPilots[1].FullName} is second in the {raceName} race.");
            sb.AppendLine($"Pilot {topPilots[2].FullName} is third in the {raceName} race.");

            topPilots[0].WinRace();
            currentRace.TookPlace = true;

            return sb.ToString().Trim();
        }
    }
}

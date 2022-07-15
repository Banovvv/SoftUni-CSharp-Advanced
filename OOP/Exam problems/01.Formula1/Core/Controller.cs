using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            throw new NotImplementedException();
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if(carRepository == null)
            {
                carRepository = new FormulaOneCarRepository();
            }

            if(carRepository.Models.Where(x=>x.Model == model).Any())
            {
                throw new InvalidOperationException($"Formula one car {model} is already created.");
            }

            if(type != "Ferrari")
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
            if(pilotRepository == null)
            {
                pilotRepository = new PilotRepository();
            }

            if(pilotRepository.Models.Where(x=>x.FullName == fullName).Any())
            {
                throw new InvalidOperationException($"Pilot {fullName} is already created.");
            }

            pilotRepository.Models.Add(new Pilot(fullName));

            return $"Pilot {fullName} is created.";
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            throw new NotImplementedException();
        }

        public string PilotReport()
        {
            throw new NotImplementedException();
        }

        public string RaceReport()
        {
            throw new NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new NotImplementedException();
        }
    }
}

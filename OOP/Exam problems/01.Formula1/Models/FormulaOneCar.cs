﻿using System;

namespace Formula1.Models
{
    public abstract class FormulaOneCar
    {
        private string model;
        private int horsepower;
        private double engineDisplacement;

        public FormulaOneCar(string model, int horsepower, double engineDisplacement)
        {
            Model = model;
            Horsepower = horsepower;
            EngineDisplacement = engineDisplacement;
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException($"Invalid car model: {value}.");
                }

                model = value;
            }
        }

        public int Horsepower
        {
            get => horsepower;
            private set
            {
                if (value < 900 || value > 1050)
                {
                    throw new ArgumentException($"Invalid car horsepower: {value}.");
                }

                horsepower = value;
            }
        }

        public double EngineDisplacement
        {
            get => engineDisplacement;
            private set
            {
                if (value < 1.6 || value > 2.0)
                {
                    throw new ArgumentException($"Invalid car engine displacement: {value}.");
                }

                engineDisplacement = value;
            }
        }

        public double RaceScoreCalculator(int laps)
        {
            return engineDisplacement / horsepower * laps;
        }
    }
}

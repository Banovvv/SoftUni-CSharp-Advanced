using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator.Validators
{
    internal class Validator
    {
        internal static bool ValidateName(string name)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateStat(int stat, int minValue, int maxValue)
        {
            if(stat < minValue || stat > maxValue)
            {
                return false;
            }

            return true;
        }
    }
}

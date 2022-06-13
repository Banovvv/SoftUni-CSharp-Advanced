using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models.Utils
{
    public class Repair
    {
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }
        public int HoursWorked { get; private set; }
    }
}

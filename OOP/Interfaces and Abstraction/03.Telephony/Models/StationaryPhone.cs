using _03.Telephony.Interfaces;
using System;
using System.Linq;

namespace _03.Telephony.Models
{
    public class StationaryPhone : IStationaryPhone
    {
        public virtual void CallNumber(string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine($"Dialing... {number}");
            }
        }

        protected bool IsValidNumber(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return true;
        }
    }
}

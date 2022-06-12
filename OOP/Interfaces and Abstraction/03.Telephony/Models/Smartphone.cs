using _03.Telephony.Interfaces;
using System;
using System.Linq;

namespace _03.Telephony.Models
{
    public class Smartphone : StationaryPhone, ISmartphone
    {
        public override void CallNumber(string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine($"Calling... {number}");
            }
        }

        public void BrowseWebsite(string website)
        {
            if (IsValidWebsite(website))
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }

        private bool IsValidWebsite(string website)
        {
            if (website.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return true;
        }
    }
}

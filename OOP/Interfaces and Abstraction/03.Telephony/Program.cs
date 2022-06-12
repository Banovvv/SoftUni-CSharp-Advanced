using _03.Telephony.Models;
using System;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
             
            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            CallNumbers(stationaryPhone, smartphone, numbers);
            BrowseWebsites(smartphone, websites);
        }

        private static void BrowseWebsites(Smartphone smartphone, string[] websites)
        {
            foreach (var website in websites)
            {
                try
                {
                    smartphone.BrowseWebsite(website);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void CallNumbers(StationaryPhone stationaryPhone, Smartphone smartphone, string[] numbers)
        {
            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        stationaryPhone.CallNumber(number);
                    }
                    else if (number.Length == 10)
                    {
                        smartphone.CallNumber(number);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

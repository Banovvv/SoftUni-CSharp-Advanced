using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Exceptions
{
    public class InvalidMissionStateException : Exception
    {
        private const string ExceptionMessage = "Ivalid Mission State";

        public InvalidMissionStateException() : base(ExceptionMessage)
        {

        }
    }
}

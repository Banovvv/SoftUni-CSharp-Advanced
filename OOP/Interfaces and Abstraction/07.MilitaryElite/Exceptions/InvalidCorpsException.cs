using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string ExceptionMessage = "Ivalid Corps Type";

        public InvalidCorpsException() : base(ExceptionMessage)
        {

        }
    }
}

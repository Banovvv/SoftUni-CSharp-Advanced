using System;

namespace _03.Cards.Exceptions
{
    public class InvalidCardException : Exception
    {
        private const string _message = "Invalid card!";

        public InvalidCardException() : base(_message)
        {

        }
    }
}

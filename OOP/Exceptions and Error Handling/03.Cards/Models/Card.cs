using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Cards.Models
{
    public class Card
    {
        private readonly string[] _validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public Card(string face, string suit)
        {

        }

        public string Face { get; private set; }
        public string Suit { get; private set; }

        public override string ToString() => $"[{Face}{Suit}]";
    }
}

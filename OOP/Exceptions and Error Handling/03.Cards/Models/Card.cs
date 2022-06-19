using _03.Cards.Exceptions;
using System.Linq;

namespace _03.Cards.Models
{
    public class Card
    {
        private readonly string[] _validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private readonly string[] _validSuits = new string[] { "S", "H", "D", "C" };
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get => face;
            private set
            {
                if (!_validFaces.Contains(value))
                {
                    throw new InvalidCardException();
                }

                face = value;
            }
        }
        public string Suit
        {
            get => suit;
            private set
            {
                if (!_validSuits.Contains(value))
                {
                    throw new InvalidCardException();
                }

                suit = GetSuit(value);
            }
        }

        public override string ToString() => $"[{Face}{Suit}]";

        private string GetSuit(string value)
        {
            return value switch
            {
                "S" => "\u2660",
                "H" => "\u2665",
                "D" => "\u2666",
                "C" => "\u2663",
                _ => throw new InvalidCardException(),
            };
        }
    }
}

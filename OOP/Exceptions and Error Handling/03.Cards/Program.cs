using _03.Cards.Models;
using System;
using System.Collections.Generic;

namespace _03.Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] deckArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            IList<Card> deck = new List<Card>();

            foreach (var cardArgs in deckArgs)
            {
                string[] cardParams = cardArgs.Split();

                string face = cardParams[0];
                string suit = cardParams[1];

                try
                {
                    deck.Add(new Card(face, suit));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(" ", deck));
        }
    }
}

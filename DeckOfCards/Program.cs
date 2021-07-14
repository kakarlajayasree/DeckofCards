
using System;
using Cards.Domain.Standard;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            var cards = deck.TakeCards(13);
            foreach (var card in cards)
            {
                var newCard = card as Card;
                Console.WriteLine(newCard.CardNumber);

            }
            Console.ReadLine();

        }
    }
}

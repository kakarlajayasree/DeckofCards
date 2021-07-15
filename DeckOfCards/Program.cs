
using System;
using System.Collections.Generic;
using Cards.Domain.Standard;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {


        static void Main(string[] args)
        {
            var allCards = (CardNumber[])Enum.GetValues(typeof(CardNumber));
            var allSuits = (Suit[])Enum.GetValues(typeof(Suit));

            var CardCount = Enum.GetValues(typeof(CardNumber)).Length;
            var SuitCount = Enum.GetValues(typeof(Suit)).Length;

            Console.WriteLine("Full Deck " + +CardCount * SuitCount);///Total count
            Console.WriteLine("\n");

            var deck = new Deck();
            deck.Shuffle();
            deck.Reset();
            var Shuffledcards = deck.TakeCards(52);


            foreach (var suit in allSuits)/// display suits
                Console.Write(suit + "  ");
            Console.WriteLine("\n");




            deck.Shuffle();
            deck.Reset();
            Shuffledcards = deck.TakeCards(52);
            foreach (var card in Shuffledcards) // display single suit
            {
                var newCard = card as Card;
                Console.Write(newCard.Suit + "---");
                Console.WriteLine(newCard.CardNumber);
            }

            deck.Shuffle();
            Shuffledcards = deck.TakeCards(13);
            Console.WriteLine("Enter Face Value to check worth point value"); /// Face value and point value
            string str = Console.ReadLine();
            str = str.ToUpper();
            if (str == "JACK" || str == "QUEEN" || str == "KING")
            {
                Console.WriteLine("Point Value " + 10);
            }
            else
            {
                Console.WriteLine("Point Value " + str);
            }

            deck.Shuffle();
            deck.Reset();
            Shuffledcards = deck.TakeCards(13);
            foreach (var card in Shuffledcards)
            {
                var newCard = card as Card;
                
                if((int)newCard.CardNumber == 11 ||(int) newCard.CardNumber == 12 || (int)newCard.CardNumber == 13)               
                Console.WriteLine(newCard.CardNumber);
            }

            Console.ReadLine();
        }
    }
}

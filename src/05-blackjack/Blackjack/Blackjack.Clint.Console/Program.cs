using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clint.Console
{
    using System;
    using Blackjack.Core;
    using System.Security.Policy;

    public class Program
    {
        static void Main(string[] args)
        {
            //aces are all 11 or 1 points, player chooses
            //when player draws a card, house draws a card

            var cards = new List<Card>

            {
            new Card("4", Suite.Club, 4, false),
            new Card("6", Suite.Heart, 6, false),
            new Card("8", Suite.Spade, 8, false),
            new Card("J", Suite.Diamond, 10, true),
            new Card("4", Suite.Spade, 4, false),
            new Card("T", Suite.Heart, 10, true)
            };


            var deck = new Deck(cards);

            Console.WriteLine("Welcome to the game of BlackJack!");
            Console.WriteLine();

            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");

            Console.WriteLine("What is your decision?");
            Console.WriteLine("Choice 1: Take another card");
            Console.WriteLine("Choice 2: Finish");
            Console.WriteLine();
            Console.WriteLine("I choose 1");
            Console.WriteLine();

            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}");
            Console.WriteLine();

            Console.WriteLine("What is your decision?");
            Console.WriteLine("Choice 1: Take another card");
            Console.WriteLine("Choice 2: Finish");
            Console.WriteLine();
            Console.WriteLine("I choose 2");
            Console.WriteLine();

            Console.WriteLine("Your score: 14");
            Console.WriteLine("House score: 17");
            Console.WriteLine("House wins");
            Console.WriteLine();

            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }

        public static string GetCardDescription(Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
    }
}


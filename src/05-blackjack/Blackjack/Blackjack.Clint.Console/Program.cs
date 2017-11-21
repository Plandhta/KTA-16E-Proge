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

            
            var c4 = new Card("4", Suite.Club, 4);
            c4.Hidden = false;

            var h6 = new Card("6", Suite.Heart, 6);
            h6.Hidden = false;

            var s8 = new Card("8", Suite.Spade, 8);
            s8.Hidden = false;

            var dJ = new Card("J", Suite.Diamond, 10);

            // 4C = card.Rank 0 card.Suite
            // 4C = card.Dscription;



            Console.WriteLine("Welcome to the game of BlackJack!");
            Console.WriteLine();

            Console.WriteLine($"You have been dealt: {c4.Description}, {h6.Description}");
            Console.WriteLine($"House has been dealt: {s8.Description}, {(dJ.Hidden ? "[?]" : dJ.Description)}");

            Console.WriteLine("What is your decision?");
            Console.WriteLine("Choice 1: Take another card");
            Console.WriteLine("Choice 2: Finish");
            Console.WriteLine();
            Console.WriteLine("I choose 1");
            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4S");
            Console.WriteLine("House has been dealt: [?]");
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
    }
}

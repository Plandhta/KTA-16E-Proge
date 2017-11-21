using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clint.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //aces are all 11 or 1 points, player chooses
            //when player draws a card, house draws a card


            Console.WriteLine("Welcome to the game of BlackJack!");
            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4C, 6H");
            Console.WriteLine("House has been dealt: 8S, [?]");

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

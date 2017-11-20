using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("> /roll 3d6 2d8");
            Console.Write(Environment.NewLine);

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = new DiceRoller().Roll(new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8 });

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine($"Roll tota: { diceRolls.Sum(x => x.Value) }");
            Console.Write(Environment.NewLine);
            Console.Write("> ");
            Console.ReadLine();


            //var total = 0;

            //var d6 = Dice.D6;
            //for (int i = 0; i < 3; i++)
            //{
            //    var roll = d6.Roll();
            //    Console.WriteLine($"{d6.Description}: {  roll}");
            //    total += roll;
            //}

            //var d8 = Dice.D8;
            //for (int i = 0; i < 2; i++)
            //{
            //    var roll = d8.Roll();
            //    Console.WriteLine($"{d8.Description}: { roll}");
            //    total += roll;
            //}
            //Console.Write(Environment.NewLine);          
            //Console.WriteLine("Roll total:" + total);
            //Console.Write(Environment.NewLine);
            //Console.WriteLine("> ");
            //Console.ReadLine();
                
        }
    }
}

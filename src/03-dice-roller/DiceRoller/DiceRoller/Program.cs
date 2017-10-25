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

            var total = 0;
            Dice d6 = new Dice(6);
            for (int i = 0; i < 3; i++)
            {
                var roll = d6.Roll();
                Console.WriteLine("1d6: " + roll);
                total += roll;
            }

            Dice d8 = new Dice(8);
            for (int i = 0; i < 2; i++)
            {
                var roll = d8.Roll();
                Console.WriteLine("1d8: " + roll);
                total += roll;
            }
            Console.Write(Environment.NewLine);          
            Console.WriteLine("Roll total:" + total);
            Console.Write(Environment.NewLine);
            Console.WriteLine("> ");
            Console.ReadLine();
                
        }
    }
}

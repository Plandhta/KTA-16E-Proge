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
            Random rnd = new Random();

            Console.WriteLine("/roll 3d6 2d8");
            Console.Write(Environment.NewLine);

            var total = 0;

            for (int i = 0; i < 3; i++)
            {
                var roll = rnd.Next(1, 7);
                Console.WriteLine("1d6: " + roll);
                total += roll;
            }

            for (int i = 0; i < 2; i++)
            {
                var roll = rnd.Next(1, 9);
                Console.WriteLine("1d8: " + roll);
                total += roll;
            }
            Console.Write(Environment.NewLine);          
            Console.WriteLine("Roll total:" + total);
            Console.ReadLine();
                
        }
    }
}

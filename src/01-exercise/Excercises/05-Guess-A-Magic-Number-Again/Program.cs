using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Guess_A_Magic_Number_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            Console.WriteLine("Ma valin ühe suvaline numbri vahemikus 1-100. Sina proovi see ära arvata");
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            Console.Write("Sina pakud: ");
            
            while (guess != num)
            {
                guess = int.Parse(Console.ReadLine());

                if (guess < num)
                {
                    Console.WriteLine("Pakkusid mööda, number mida mõtlesin on suurem kui " + guess + " paku uuesti");
                }
                else if (guess > num)
                {
                    Console.WriteLine("Pakkusid mööda, number mida mõtlesin on väiksem kui " + guess + " paku uuesti");
                }
            }

            Console.WriteLine("Pakkusid täppi, number mida mõtlesin oli " + num);
            Console.ReadLine();



        }
    }
}

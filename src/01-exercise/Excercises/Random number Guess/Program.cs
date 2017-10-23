using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_number_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata");
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            Console.Write("Sina pakud: ");
            guess = int.Parse(Console.ReadLine());
            if ( guess == num)
            {
                Console.WriteLine("Pakkid täppi!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pakkusid mööda, number mida ma mõtlesin oli: " + num);
                Console.ReadLine();
            }


        }
    }
}

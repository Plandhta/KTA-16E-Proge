using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Excuses_Print_All_For
{
    class Program
    {
        static void Main(string[] args)
        {
            var excuses = new[] { "koer sõi kodutööd ära", "ema ei luba arvutis tiksuda" };
            // use foreach instead
            //for (int i = 0; i < excuses.Length; i++) 
            //{
            //    Console.WriteLine($"{i + 1}. {excuses[i]}");
            //}
            //Console.ReadLine();
            int i = 0;
            foreach (var excuse in excuses)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
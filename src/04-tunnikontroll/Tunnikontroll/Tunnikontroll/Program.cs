using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taco Palanque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("--------------------------------------------");
            double sum = 0;
            double a = 0;
            while (true)
            {             
                Console.Write("Enter price of food items [-1 to quit]:");
                a = Double.Parse(Console.ReadLine());
                sum += a;
                if (a == -1)
                    break;
                sum  =+ a;
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Subtotal: €" + sum);
            Console.WriteLine("15.00 % Gratuity: €" + sum * 0.15);
            Console.WriteLine("Total: €" + sum*0.85);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}

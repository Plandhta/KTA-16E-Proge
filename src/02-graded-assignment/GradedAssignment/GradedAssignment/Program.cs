using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is a Discount Calculator.");
            Console.Write("Enter a sum to be calculated: ");
            int sum = int.Parse(Console.ReadLine());
            if ( sum < 50)
            {
                Console.WriteLine("There is no discount for sums under 50 bucks dude");
            }
            if ( sum > 50 || sum < 250)
            {
                
                int discount1 = sum/100*95;
                Console.WriteLine("Entered sum: " + sum);
                Console.WriteLine("Discount percent is 5%");
                Console.WriteLine("Sum which would have to be paid after the discount is reduced is:" + discount1);
                Console.ReadLine();
            }

        }
    }
}

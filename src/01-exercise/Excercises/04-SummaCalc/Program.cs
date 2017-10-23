using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SummaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja mina ütlen Sulle nende summa.");
            Console.Write(Environment.NewLine);
            Console.Write("Esimene number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Teine number: ");
            num2 = int.Parse(Console.ReadLine());
            //m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);
            Console.Write("Summa on: ");
            num3 = num1 + num2;
            Convert.ToString(num3);
            Console.WriteLine(num3);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();



    

            
        }
    }
}

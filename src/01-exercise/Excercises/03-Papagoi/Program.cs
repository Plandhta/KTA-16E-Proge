using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Papagoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVariable;

            Console.WriteLine("Mina olen papagoi programm. Ütle mulle midagi ja ma kordan selle sulle tagasi...");
            Console.Write(Environment.NewLine);
            Console.Write("Sina ütled: ");
            myVariable = Console.ReadLine();
            Console.Write("Mina ütlen: ");
            Console.WriteLine(myVariable);
            Console.ReadLine();

            
        }
    }
}

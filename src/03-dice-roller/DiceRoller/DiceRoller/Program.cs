﻿using System;
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
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("1d6: " + rnd.Next(1, 6));
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("1d8: " + rnd.Next(1, 8));
            }
            Console.Write(Environment.NewLine);          
            Console.WriteLine("Roll total: 20");
            Console.ReadLine();
                
        }
    }
}

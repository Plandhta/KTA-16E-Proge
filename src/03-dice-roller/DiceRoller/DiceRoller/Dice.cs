using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        private Random Random { get; }

        private int Sides { get; }

        public Dice(int sides)
        {
            this.Sides = sides;
            this.Random = new Random();
            
        }

        public int Roll()
        {
            return this.Random.Next(1, this.Sides + 1);
        }

    }
}

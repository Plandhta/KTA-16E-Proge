using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Card
    {

        public string Description => this._rank + this._suite.GetShortName();

        public bool Hidden { get; set; }

        private string _rank;
        private Suite _suite;
        private int _points;

        public Card(string rank, Suite suite, int points, bool hidden)
        {
            _rank = rank;
            _suite = suite;
            _points = points;

            this.Hidden = hidden;
        }
    }
}

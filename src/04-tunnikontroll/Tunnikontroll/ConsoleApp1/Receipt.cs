using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReceipt
{

    public class Receipt
    {
        private Tab Tab;
        public Receipt(Tab tab)
        {
            this.Tab = tab;
        }
        public override string ToString()
        {
            var sum = Tab.items.Sum(x => (x));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Subtotal: €" + sum);
            Console.WriteLine("15,00 % Gratuity: €" + sum * 0.15);
            Console.WriteLine("Total: €" + sum * 0.85);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");

            return base.ToString();
        }

        
    }
}
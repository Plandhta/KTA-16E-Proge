using System;

namespace RestaurantReceipt
{
    class Restaurant
    {
        private string v1;
        private string v2;

        public Restaurant(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine("------------------------------------");
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(tab);
        }
    }
}